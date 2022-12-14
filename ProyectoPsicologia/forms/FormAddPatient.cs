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
    public partial class FormAddPatient : Form
    {
        public int? Id;
        public int? bandera;
        Pacientes tablaPacientes;
        //public string valorSemestre;

        public FormAddPatient(int? Id = null,int? bandera=null)
        {
            //DateTimePicker dateTimePickerActual = new DateTimePicker();
            InitializeComponent();
            this.Id = Id;
            this.bandera = bandera;
            if (Id != null)
                CargarData();
            if (dateTimePicker1.Value.Month >= 8)
            {
               textBoxSemestreActual.Text = dateTimePicker1.Value.Year.ToString() + "-2";
            }
            else
            {
                textBoxSemestreActual.Text = dateTimePicker1.Value.Year.ToString() + "-1";
            }
              
            
        }
        private void CargarData()
        {
            using (PsicologiaBDEntities1 db = new PsicologiaBDEntities1())
            {
                tablaPacientes = db.Pacientes.Find(Id);
                if(bandera!=1)
                    dateTimePicker1.Value = tablaPacientes.Fecha;
                textBoxName.Text = tablaPacientes.Nombre;
                if (tablaPacientes.Sexo == "Masculino")
                    radioButtonMale.Checked = true;
                if (tablaPacientes.Sexo == "Femenino")
                    radioButtonFemale.Checked = true;

                textBoxControl.Text = tablaPacientes.Num_Control;
                comboBoxCareer.SelectedItem = tablaPacientes.Carrera;
                textBoxSemester.Text = tablaPacientes.Semestre;
                comboBoxCanalizo.Text = tablaPacientes.Canalizo;
                comboBoxService.Text = tablaPacientes.Servicio;
                richTextBoxObservaciones.Text = tablaPacientes.Observaciones;

                if(bandera==1)
                    Id = null;
                
               
            }
        }


        private void labelCareer_Click(object sender, EventArgs e)
        {

        }

        private void labelSex_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSemester_Click(object sender, EventArgs e)
        {

        }
        /*
        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
             using (PsicologiaBDEntities1 db = new PsicologiaBDEntities1()){
                Pacientes tabla = new Pacientes();
                tabla.Fecha = dateTimePicker1.Value;
                tabla.Nombre = textBoxName.Text;
                if(radioButtonMale.Checked==true)
                    tabla.Sexo = radioButtonMale.Text;
                if (radioButtonFemale.Checked == true)
                    tabla.Sexo = radioButtonFemale.Text;
                tabla.Semestre = comboBoxCareer.Text;
                tabla.Canalizo = textBoxCanalizo.Text;
                tabla.Servicio = textBoxService.Text;
                tabla.Observaciones = richTextBoxObservaciones.Text;
            }
            
        }
        */

        private void FormAddPatient_Load(object sender, EventArgs e)
        {
            //comboBoxCareer.SelectedItem = "Ing. Sistemas Computacionales";
        }

        private void labelObservations_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            using (PsicologiaBDEntities1 db = new PsicologiaBDEntities1())
            {
                if(Id == null)
                    tablaPacientes = new Pacientes();


                tablaPacientes.Fecha = dateTimePicker1.Value;
                tablaPacientes.Semestre_Actual = textBoxSemestreActual.Text;
                tablaPacientes.Nombre = textBoxName.Text;
                if(radioButtonMale.Checked==true)
                    tablaPacientes.Sexo = radioButtonMale.Text;
                if (radioButtonFemale.Checked == true)
                    tablaPacientes.Sexo = radioButtonFemale.Text;
                tablaPacientes.Num_Control = textBoxControl.Text;
                tablaPacientes.Carrera = comboBoxCareer.Text;
                tablaPacientes.Semestre = textBoxSemester.Text;
                tablaPacientes.Canalizo = comboBoxCanalizo.Text;
                tablaPacientes.Servicio = comboBoxService.Text;
                tablaPacientes.Observaciones = richTextBoxObservaciones.Text;

                
                if (Id == null)
                {
                    db.Pacientes.Add(tablaPacientes);
                }
                else
                {
                    db.Entry(tablaPacientes).State = System.Data.Entity.EntityState.Modified;
                }


                db.SaveChanges();

                this.Close();
            }
        }

        private void comboBoxCareer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCanalizo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSemestreActual_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
