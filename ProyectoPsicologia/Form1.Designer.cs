namespace ProyectoPsicologia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButtonGraph = new FontAwesome.Sharp.IconButton();
            this.iconButtonHome = new FontAwesome.Sharp.IconButton();
            this.panelName = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHome = new System.Windows.Forms.Panel();
            this.timerHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(0)))), ((int)(((byte)(118)))));
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.iconButtonGraph);
            this.panelMenu.Controls.Add(this.iconButtonHome);
            this.panelMenu.Controls.Add(this.panelName);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 753);
            this.panelMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 553);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // iconButtonGraph
            // 
            this.iconButtonGraph.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonGraph.FlatAppearance.BorderSize = 0;
            this.iconButtonGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonGraph.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonGraph.IconChar = FontAwesome.Sharp.IconChar.PieChart;
            this.iconButtonGraph.IconColor = System.Drawing.Color.Snow;
            this.iconButtonGraph.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonGraph.IconSize = 40;
            this.iconButtonGraph.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonGraph.Location = new System.Drawing.Point(0, 159);
            this.iconButtonGraph.Name = "iconButtonGraph";
            this.iconButtonGraph.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonGraph.Size = new System.Drawing.Size(200, 50);
            this.iconButtonGraph.TabIndex = 2;
            this.iconButtonGraph.Text = "Estadisticas";
            this.iconButtonGraph.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonGraph.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonGraph.UseVisualStyleBackColor = true;
            this.iconButtonGraph.Click += new System.EventHandler(this.iconButtonGraph_Click);
            // 
            // iconButtonHome
            // 
            this.iconButtonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonHome.FlatAppearance.BorderSize = 0;
            this.iconButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonHome.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonHome.IconChar = FontAwesome.Sharp.IconChar.HouseChimney;
            this.iconButtonHome.IconColor = System.Drawing.Color.Snow;
            this.iconButtonHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHome.IconSize = 40;
            this.iconButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHome.Location = new System.Drawing.Point(0, 109);
            this.iconButtonHome.Name = "iconButtonHome";
            this.iconButtonHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonHome.Size = new System.Drawing.Size(200, 50);
            this.iconButtonHome.TabIndex = 1;
            this.iconButtonHome.Text = "Inicio";
            this.iconButtonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonHome.UseVisualStyleBackColor = true;
            this.iconButtonHome.Click += new System.EventHandler(this.iconButtonHome_Click);
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(0)))), ((int)(((byte)(93)))));
            this.panelName.Controls.Add(this.pictureBox2);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.Location = new System.Drawing.Point(0, 0);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(200, 109);
            this.panelName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(0)))), ((int)(((byte)(93)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 56);
            this.panel1.TabIndex = 1;
            // 
            // panelHome
            // 
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(200, 56);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1182, 697);
            this.panelHome.TabIndex = 2;
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHome_Paint);
            // 
            // timerHoraFecha
            // 
            this.timerHoraFecha.Enabled = true;
            this.timerHoraFecha.Tick += new System.EventHandler(this.timerHoraFecha_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Coordinación de orientación educativa y psicología";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelName;
        private FontAwesome.Sharp.IconButton iconButtonGraph;
        private FontAwesome.Sharp.IconButton iconButtonHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Timer timerHoraFecha;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

