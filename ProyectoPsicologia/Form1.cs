using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;


namespace ProyectoPsicologia
{
    public partial class Form1 : Form
    {
        //Fields
        private IconButton currentButton;
        private Panel leftBorderButton;
        public Form1()
        {
            InitializeComponent();
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderButton);
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderButton, Color color)
        {
            if (senderButton != null)
            {
                DisableButton();
                //Button
                currentButton = (IconButton)senderButton;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderButton.BackColor = color;
                leftBorderButton.Location = new Point(0,currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(178, 0, 118);
                currentButton.ForeColor = Color.Snow;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Snow;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void iconButtonGraph_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            //OpenChildForm(new FormDashboard());
            OpenFormHome(new forms.FormStatistics());

        }

        private void iconButtonHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            //OpenChildForm(new FormDashboard());
            OpenFormHome(new forms.FormHome());

        }
        private void OpenFormHome(object child_form)
        {
            panelHome.Visible = true;
            //labelFecha.Visible = true;
            //labelHora.Visible = true;

            if (this.panelHome.Controls.Count > 0)
                this.panelHome.Controls.RemoveAt(0);
            Form cf = child_form as Form;
            cf.TopLevel = false;
            cf.Dock= DockStyle.Fill;   
            this.panelHome.Controls.Add(cf);
            this.panelHome.Tag = cf;
            cf.Show();


        }

        
        public void Reset()
        {
            DisableButton();
            leftBorderButton.Visible = false;
            

        }

        private void labelLogo_Click(object sender, EventArgs e)
        {
            panelHome.Visible = false;
            //labelFecha.Visible = false;
            //labelHora.Visible = false;
            Reset();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerHoraFecha_Tick(object sender, EventArgs e)
        {
            //labelHora.Text = DateTime.Now.ToString("hh:mm:ss");

        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelHome.Visible = false;
            //labelFecha.Visible = false;
            //labelHora.Visible = false;
            Reset();

        }
    }
}
