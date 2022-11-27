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
        Pacientes tablaPacientes;

        public FormAddPatient(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
            if (Id != null)
                CargarData();
        }
        private void CargarData()
        {
            using (PsicologiaBDEntities1 db = new PsicologiaBDEntities1())
            {
                tablaPacientes = db.Pacientes.Find(Id);
                dateTimePicker1.Value = tablaPacientes.Fecha;
                textBoxName.Text = tablaPacientes.Nombre;
                if (tablaPacientes.Sexo == "Masculino")
                    radioButtonMale.Checked = true;
                if (tablaPacientes.Sexo == "Femenino")
                    radioButtonFemale.Checked = true;

                textBoxControl.Text = tablaPacientes.Num_Control;
                comboBoxCareer.SelectedItem = tablaPacientes.Carrera;
                textBoxSemester.Text = tablaPacientes.Semestre;
                textBoxCanalizo.Text = tablaPacientes.Canalizo;
                textBoxService.Text = tablaPacientes.Servicio;
                richTextBoxObservaciones.Text = tablaPacientes.Observaciones;

               
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
                tablaPacientes.Nombre = textBoxName.Text;
                if(radioButtonMale.Checked==true)
                    tablaPacientes.Sexo = radioButtonMale.Text;
                if (radioButtonFemale.Checked == true)
                    tablaPacientes.Sexo = radioButtonFemale.Text;
                tablaPacientes.Num_Control = textBoxControl.Text;
                tablaPacientes.Carrera = comboBoxCareer.Text;
                tablaPacientes.Semestre = textBoxSemester.Text;
                tablaPacientes.Canalizo = textBoxCanalizo.Text;
                tablaPacientes.Servicio = textBoxService.Text;
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
    }
}
