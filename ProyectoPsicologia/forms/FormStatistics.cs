using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using ProyectoPsicologia.Models;

namespace ProyectoPsicologia.forms
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            if (DateTime.Now.Month >= 8)
            {
                textBoxSemestreEstadisticas.Text = DateTime.Now.Year.ToString() + "-2";
            }
            else
            {
                textBoxSemestreEstadisticas.Text = DateTime.Now.Year.ToString() + "-1";
            }

        }
        private void GraficoTotal()
        {
            //var desde = dateTimePickerDesde.Value.Date;
            //var hasta = dateTimePickerHasta.Value.Date;
            using (PsicologiaBDEntities1 db = new PsicologiaBDEntities1())
            {

                var innovacion = (from d in db.Pacientes where d.Carrera.Contains("Ing. en Innovación Agrícola Sustentablel") where d.Semestre_Actual.Contains(textBoxSemestreEstadisticas.Text) select d).Count();
                chartGraficoBarras.Series[0].Points.AddXY("Ing.en Innovación Agrícola", innovacion);

                var electromecanica = (from d in db.Pacientes where d.Carrera.Contains("Ing. Electromecánica") where d.Semestre_Actual.Contains(textBoxSemestreEstadisticas.Text) select d).Count();
                chartGraficoBarras.Series[0].Points.AddXY("Ing.Electromecánica", electromecanica);

                var electronica = (from d in db.Pacientes where d.Carrera.Contains("Ing. Eletrónica") where d.Semestre_Actual.Contains(textBoxSemestreEstadisticas.Text) select d).Count();
                chartGraficoBarras.Series[0].Points.AddXY("Ing.Eletrónica", electronica);

                var gestion = (from d in db.Pacientes where d.Carrera.Contains("Ing. Gestión Empresarial") where d.Semestre_Actual.Contains(textBoxSemestreEstadisticas.Text) select d).Count();
                chartGraficoBarras.Series[0].Points.AddXY("Ing.Gestión Empresarial", gestion);

                var industrial = (from d in db.Pacientes where d.Carrera.Contains("Ing. Industrial") where d.Semestre_Actual.Contains(textBoxSemestreEstadisticas.Text) select d).Count();
                chartGraficoBarras.Series[0].Points.AddXY("Ing.Industrial", industrial);

                var mecatronica = (from d in db.Pacientes where d.Carrera.Contains("Ing. Mecatrónica") where d.Semestre_Actual.Contains(textBoxSemestreEstadisticas.Text) select d).Count();
                chartGraficoBarras.Series[0].Points.AddXY("Ing.Mecatrónica", mecatronica);

                
                var sistemas = (from d in db.Pacientes where d.Carrera.Contains("Ing. Sistemas Computacionales") where d.Semestre_Actual.Contains(textBoxSemestreEstadisticas.Text) select d).Count();
                //chartGraficoBarras.Series[0].Points.AddXY("Ing.Sistemas Computacionales", sistemas);

                var admin = (from d in db.Pacientes where d.Carrera.Contains("Lic. en Administración") where d.Semestre_Actual.Contains(textBoxSemestreEstadisticas.Text) select d).Count();
                chartGraficoBarras.Series[0].Points.AddXY("Lic.en Administración", admin);
                /*
                using(EntityCommand cmd = new EntityCommand())
                {
                    EntityParameter totalSis = new EntityParameter();
                    totalSis.ParameterName = ;
                    //totalSis.Value = ;
                    //cmd.Parameters.Add(totalSis);
                    chartGraficoBarras.Series[0].Points.AddXY("Ing.Sistemas Computacionales", totalSis.Value.ToString());

                    //EntityParameter totalInnova = new EntityParameter("@totalSistemas",0);
                    // totalInnova.Direction = ParameterDirection.Output;
                    //totalInnova.Value = 0;
                    //cmd.Parameters.Add(totalInnova);
                    //Console.WriteLine(totalInnova);
                    //totalInnova.Direction = ParameterDirection.Output;
                    //db.GraficoCarreras();
                }
                */
                

            }


        }

        private void iconButtonConsultar_Click(object sender, EventArgs e)
        {

            chartGraficoBarras.Series[0].Points.Clear();
            
            GraficoTotal();
        }

        private void textBoxSemestreEstadisticas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
