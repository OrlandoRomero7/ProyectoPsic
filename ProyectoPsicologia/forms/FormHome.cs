using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPsicologia.Models;

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
        }

        #region HELPER
        private void refreshTable()
        {
            using (PsicologiaBDEntities1 db = new PsicologiaBDEntities1())
            {
                var lst = (from d in db.Pacientes
                           orderby d.Id descending
                           select d).AsQueryable();

                if (!textBoxSearchName.Text.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.Nombre.Contains(textBoxSearchName.Text.Trim()));
                }
                if (!textBoxSearchControl.Text.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.Num_Control.Contains(textBoxSearchControl.Text.Trim()));
                }

                dataGridView.DataSource = lst.ToList();
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
            try
            {
                return int.Parse(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void iconButtonAddAgain_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonEdit_Click(object sender, EventArgs e)
        {
            int? Id = GetID();
            if (Id != null)
            {
                forms.FormAddPatient tabla = new forms.FormAddPatient(Id);
                tabla.ShowDialog();

                refreshTable();

            }

        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
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

        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            refreshTable();
            textBoxSearchName.Text = "";
            textBoxSearchControl.Text = "";
            
        }
    }
}
