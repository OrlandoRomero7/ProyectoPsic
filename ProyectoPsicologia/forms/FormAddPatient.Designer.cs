namespace ProyectoPsicologia.forms
{
    partial class FormAddPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.textBoxSemester = new System.Windows.Forms.TextBox();
            this.labelCareer = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.richTextBoxObservaciones = new System.Windows.Forms.RichTextBox();
            this.labelObservations = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCareer = new System.Windows.Forms.ComboBox();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.iconButtonCancel = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxControl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCanalizo = new System.Windows.Forms.ComboBox();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.textBoxSemestreActual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(46, 93);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(81, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nombre";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(51, 126);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(535, 30);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Checked = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(157, 192);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(122, 29);
            this.radioButtonMale.TabIndex = 2;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Masculino";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(353, 189);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(120, 29);
            this.radioButtonFemale.TabIndex = 3;
            this.radioButtonFemale.Text = "Femenino";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSex.Location = new System.Drawing.Point(47, 172);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(58, 25);
            this.labelSex.TabIndex = 4;
            this.labelSex.Text = "Sexo";
            this.labelSex.Click += new System.EventHandler(this.labelSex_Click);
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.Location = new System.Drawing.Point(45, 380);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(96, 25);
            this.labelSemester.TabIndex = 8;
            this.labelSemester.Text = "Semestre";
            this.labelSemester.Click += new System.EventHandler(this.labelSemester_Click);
            // 
            // textBoxSemester
            // 
            this.textBoxSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSemester.Location = new System.Drawing.Point(52, 409);
            this.textBoxSemester.Name = "textBoxSemester";
            this.textBoxSemester.Size = new System.Drawing.Size(534, 30);
            this.textBoxSemester.TabIndex = 9;
            // 
            // labelCareer
            // 
            this.labelCareer.AutoSize = true;
            this.labelCareer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCareer.Location = new System.Drawing.Point(45, 301);
            this.labelCareer.Name = "labelCareer";
            this.labelCareer.Size = new System.Drawing.Size(78, 25);
            this.labelCareer.TabIndex = 10;
            this.labelCareer.Text = "Carrera";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelService.Location = new System.Drawing.Point(45, 523);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(168, 25);
            this.labelService.TabIndex = 12;
            this.labelService.Text = "Servicio de apoyo";
            // 
            // richTextBoxObservaciones
            // 
            this.richTextBoxObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxObservaciones.Location = new System.Drawing.Point(669, 169);
            this.richTextBoxObservaciones.Name = "richTextBoxObservaciones";
            this.richTextBoxObservaciones.Size = new System.Drawing.Size(464, 179);
            this.richTextBoxObservaciones.TabIndex = 13;
            this.richTextBoxObservaciones.Text = "";
            // 
            // labelObservations
            // 
            this.labelObservations.AutoSize = true;
            this.labelObservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservations.Location = new System.Drawing.Point(664, 126);
            this.labelObservations.Name = "labelObservations";
            this.labelObservations.Size = new System.Drawing.Size(144, 25);
            this.labelObservations.TabIndex = 14;
            this.labelObservations.Text = "Observaciones";
            this.labelObservations.Click += new System.EventHandler(this.labelObservations_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDate.Location = new System.Drawing.Point(47, 18);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(67, 25);
            this.labelDate.TabIndex = 15;
            this.labelDate.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(535, 30);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // comboBoxCareer
            // 
            this.comboBoxCareer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCareer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCareer.FormattingEnabled = true;
            this.comboBoxCareer.Items.AddRange(new object[] {
            "Ing. en Innovación Agrícola Sustentable",
            "Ing. Electromecánica",
            "Ing. Eletrónica",
            "Ing. Gestión Empresarial",
            "Ing. Industrial",
            "Ing. Mecatrónica",
            "Ing. Sistemas Computacionales",
            "Lic. en Administración",
            "Posgrado"});
            this.comboBoxCareer.Location = new System.Drawing.Point(52, 329);
            this.comboBoxCareer.Name = "comboBoxCareer";
            this.comboBoxCareer.Size = new System.Drawing.Size(534, 33);
            this.comboBoxCareer.TabIndex = 19;
            this.comboBoxCareer.SelectedIndexChanged += new System.EventHandler(this.comboBoxCareer_SelectedIndexChanged);
            // 
            // iconButtonSave
            // 
            this.iconButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(0)))), ((int)(((byte)(93)))));
            this.iconButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSave.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconButtonSave.IconColor = System.Drawing.Color.White;
            this.iconButtonSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSave.IconSize = 20;
            this.iconButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonSave.Location = new System.Drawing.Point(1003, 409);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Size = new System.Drawing.Size(130, 43);
            this.iconButtonSave.TabIndex = 20;
            this.iconButtonSave.Text = "Guardar";
            this.iconButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSave.UseVisualStyleBackColor = false;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click);
            // 
            // iconButtonCancel
            // 
            this.iconButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCancel.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.iconButtonCancel.IconColor = System.Drawing.Color.Black;
            this.iconButtonCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCancel.IconSize = 25;
            this.iconButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCancel.Location = new System.Drawing.Point(669, 408);
            this.iconButtonCancel.Name = "iconButtonCancel";
            this.iconButtonCancel.Size = new System.Drawing.Size(130, 43);
            this.iconButtonCancel.TabIndex = 21;
            this.iconButtonCancel.Text = "Cancelar";
            this.iconButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCancel.UseVisualStyleBackColor = true;
            this.iconButtonCancel.Click += new System.EventHandler(this.iconButtonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Canalizó";
            // 
            // textBoxControl
            // 
            this.textBoxControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxControl.Location = new System.Drawing.Point(52, 252);
            this.textBoxControl.Name = "textBoxControl";
            this.textBoxControl.Size = new System.Drawing.Size(534, 30);
            this.textBoxControl.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Numero de control";
            // 
            // comboBoxCanalizo
            // 
            this.comboBoxCanalizo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCanalizo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCanalizo.FormattingEnabled = true;
            this.comboBoxCanalizo.Items.AddRange(new object[] {
            "Si/Docente",
            "Si/Tutor",
            "No"});
            this.comboBoxCanalizo.Location = new System.Drawing.Point(52, 487);
            this.comboBoxCanalizo.Name = "comboBoxCanalizo";
            this.comboBoxCanalizo.Size = new System.Drawing.Size(534, 33);
            this.comboBoxCanalizo.TabIndex = 26;
            // 
            // comboBoxService
            // 
            this.comboBoxService.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Items.AddRange(new object[] {
            "IPEBC",
            "IPEBC/ADICCIONES",
            "INMUJERE",
            "SERVICIOS EXTERNOS/PSIC/MÉDICO",
            "SERVICIOS ESCOLARES/BECAS",
            "ASESORIAS ACADEMICAS"});
            this.comboBoxService.Location = new System.Drawing.Point(50, 551);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(534, 33);
            this.comboBoxService.TabIndex = 27;
            // 
            // textBoxSemestreActual
            // 
            this.textBoxSemestreActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSemestreActual.Location = new System.Drawing.Point(963, 46);
            this.textBoxSemestreActual.Name = "textBoxSemestreActual";
            this.textBoxSemestreActual.Size = new System.Drawing.Size(170, 30);
            this.textBoxSemestreActual.TabIndex = 28;
            this.textBoxSemestreActual.TextChanged += new System.EventHandler(this.textBoxSemestreActual_TextChanged);
            // 
            // FormAddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(210)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1193, 626);
            this.Controls.Add(this.textBoxSemestreActual);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.comboBoxCanalizo);
            this.Controls.Add(this.textBoxControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButtonCancel);
            this.Controls.Add(this.iconButtonSave);
            this.Controls.Add(this.comboBoxCareer);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelObservations);
            this.Controls.Add(this.richTextBoxObservaciones);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.labelCareer);
            this.Controls.Add(this.textBoxSemester);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "FormAddPatient";
            this.Text = "Crear Registro";
            this.Load += new System.EventHandler(this.FormAddPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.TextBox textBoxSemester;
        private System.Windows.Forms.Label labelCareer;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.RichTextBox richTextBoxObservaciones;
        private System.Windows.Forms.Label labelObservations;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxCareer;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private FontAwesome.Sharp.IconButton iconButtonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCanalizo;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.TextBox textBoxSemestreActual;
    }
}