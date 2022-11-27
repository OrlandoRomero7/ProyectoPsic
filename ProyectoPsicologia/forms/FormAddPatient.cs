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
        public FormAddPatient()
        {
            InitializeComponent();
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

        private void FormAddPatient_Load(object sender, EventArgs e)
        {
            comboBoxCareer.SelectedIndex = 0;
        }

        private void labelObservations_Click(object sender, EventArgs e)
        {

        }
    }
}
