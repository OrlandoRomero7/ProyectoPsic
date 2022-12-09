using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows;
//using System.Windows;
//using System.Windows;
using System.Windows.Forms;
using ProyectoPsicologia.Models;
using SpreadsheetLight;

namespace ProyectoPsicologia.forms
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            refreshTable();
            if (DateTime.Now.Month >= 8)
            {
                textBoxSemestreExportar.Text = DateTime.Now.Year.ToString() + "-2";
            }
            else
            {
                textBoxSemestreExportar.Text = DateTime.Now.Year.ToString() + "-1";
            }
            //DateTime kk = DateTime.Now.Year;
            
            
            
        }

        #region HELPER
        private void refreshTable()
        {
            using (PsicologiaBDEntities1 db = new PsicologiaBDEntities1())
            {
                var lstAll = (from d in db.Pacientes
                           orderby d.Id descending
                           select d).AsQueryable();
                
                var lstSemestreActual = (from d in db.Pacientes
                                         where d.Semestre_Actual.Contains("")
                                         orderby d.Id descending
                              select d).AsQueryable();
                /*

                if (!textBoxSemestreExportar.Text.Trim().Equals(""))
                {
                    lstAll = lstAll.Where(d => d.Semestre_Actual.Contains(textBoxSemestreExportar.Text.Trim()));
                    
                }
                */

                if (!textBoxSearchName.Text.Trim().Equals(""))
                {
                    lstAll = lstAll.Where(d => d.Nombre.Contains(textBoxSearchName.Text.Trim()));
                    //dataGridView.DataSource = lstAll.ToList();
                }
                if (!textBoxSearchControl.Text.Trim().Equals(""))
                {
                    lstAll = lstAll.Where(d => d.Num_Control.Contains(textBoxSearchControl.Text.Trim()));
                    
                }
                dataGridView.DataSource = lstAll.ToList();


                //dataGridView.Columns["Semestre_Actual"].Visible = false;
            }

        }
        #endregion

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButtonOpenFormAdd_Click(object sender, EventArgs e)
        {
            forms.FormAddPatient tabla = new forms.FormAddPatient();
            tabla.ShowDialog();
            refreshTable();
        }

        private int? GetID() 
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                return int.Parse(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value.ToString());
            }
            
            else
            {
                MessageBox.Show("Necesita seleccionar algun registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
                
            }
            
            
            
        }

        private void iconButtonAddAgain_Click(object sender, EventArgs e)
        {
            int? Id = GetID();
            int bandera = 1;
            if (Id != null)
            {
                forms.FormAddPatient tabla = new forms.FormAddPatient(Id,bandera);
                tabla.ShowDialog();

                refreshTable();

            }

        }

        private void iconButtonEdit_Click(object sender, EventArgs e)
        {
           

            int? Id = GetID();
            if (Id != null)
            {
                forms.FormAddPatient tabla = new forms.FormAddPatient(Id);
                tabla.Text = "Editar Registro";
                tabla.ShowDialog();

                refreshTable();

            }

        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult myResult;
            myResult = MessageBox.Show("¿Esta seguro que quiere el registro?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                int? Id = GetID();
                if (Id != null)
                {

                    using (PsicologiaBDEntities1 db = new PsicologiaBDEntities1())
                    {

                        Pacientes tablaPacientes = db.Pacientes.Find(Id);
                        db.Pacientes.Remove(tablaPacientes);
                        db.SaveChanges();
                    }

                    refreshTable();

                }
            }
            else
            {
                //No delete
            }

            

        }

        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            refreshTable();
            textBoxSearchName.Text = "";
            textBoxSearchControl.Text = "";
            
        }

        private void iconButtonExport_Click(object sender, EventArgs e)
        {
            using (PsicologiaBDEntities1 db = new PsicologiaBDEntities1())
            {


                var lstSemestreActual = (from d in db.Pacientes
                                         where d.Semestre_Actual.Contains(textBoxSemestreExportar.Text)
                                         orderby d.Id descending
                                         select d).AsQueryable();

                dataGridView.DataSource = lstSemestreActual.ToList();
            }

            SLDocument sl = new SLDocument();

            int ic =1;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                sl.SetCellValue(1, ic, column.HeaderText.ToString());
                ic++;
            }


            int ir = 2;
            foreach(DataGridViewRow row in dataGridView.Rows)
            {
                //sl.SetCellValue(ir, 1, row.Cells[0].Value.ToString());
                sl.SetCellValue(ir, 2, row.Cells[1].Value.ToString());
                sl.SetCellValue(ir, 3, row.Cells[2].Value.ToString());
                sl.SetCellValue(ir, 4, row.Cells[3].Value.ToString());
                sl.SetCellValue(ir, 5, row.Cells[4].Value.ToString());
                sl.SetCellValue(ir, 6, row.Cells[5].Value.ToString());
                sl.SetCellValue(ir, 7, row.Cells[6].Value.ToString());
                sl.SetCellValue(ir, 8, row.Cells[7].Value.ToString());
                sl.SetCellValue(ir, 9, row.Cells[8].Value.ToString());
                sl.SetCellValue(ir, 10, row.Cells[9].Value.ToString());
                //sl.SetCellValue(ir, 11, row.Cells[10].Value.ToString());
                ir++;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Guardar archivo";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sl.SaveAs(saveFileDialog1.FileName);
                    MessageBox.Show("Archivo exportado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            refreshTable();
        }

        private void textBoxSemestreExportar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
