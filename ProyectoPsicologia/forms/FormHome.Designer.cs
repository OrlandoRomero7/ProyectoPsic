namespace ProyectoPsicologia.forms
{
    partial class FormHome
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
            this.iconButtonOpenFormAdd = new FontAwesome.Sharp.IconButton();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.textBoxSearchControl = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            this.iconButtonAddAgain = new FontAwesome.Sharp.IconButton();
            this.iconButtonEdit = new FontAwesome.Sharp.IconButton();
            this.iconButtonDelete = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButtonOpenFormAdd
            // 
            this.iconButtonOpenFormAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonOpenFormAdd.IconColor = System.Drawing.Color.Black;
            this.iconButtonOpenFormAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonOpenFormAdd.Location = new System.Drawing.Point(35, 37);
            this.iconButtonOpenFormAdd.Name = "iconButtonOpenFormAdd";
            this.iconButtonOpenFormAdd.Size = new System.Drawing.Size(142, 31);
            this.iconButtonOpenFormAdd.TabIndex = 0;
            this.iconButtonOpenFormAdd.Text = "Crear Registro";
            this.iconButtonOpenFormAdd.UseVisualStyleBackColor = true;
            this.iconButtonOpenFormAdd.Click += new System.EventHandler(this.iconButtonOpenFormAdd_Click);
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchName.Location = new System.Drawing.Point(35, 135);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(323, 30);
            this.textBoxSearchName.TabIndex = 1;
            // 
            // textBoxSearchControl
            // 
            this.textBoxSearchControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchControl.Location = new System.Drawing.Point(377, 135);
            this.textBoxSearchControl.Name = "textBoxSearchControl";
            this.textBoxSearchControl.Size = new System.Drawing.Size(257, 30);
            this.textBoxSearchControl.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(35, 205);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(932, 394);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // iconButtonSearch
            // 
            this.iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonSearch.IconColor = System.Drawing.Color.Black;
            this.iconButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearch.Location = new System.Drawing.Point(661, 135);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Size = new System.Drawing.Size(142, 30);
            this.iconButtonSearch.TabIndex = 4;
            this.iconButtonSearch.Text = "Buscar";
            this.iconButtonSearch.UseVisualStyleBackColor = true;
            this.iconButtonSearch.Click += new System.EventHandler(this.iconButtonSearch_Click);
            // 
            // iconButtonAddAgain
            // 
            this.iconButtonAddAgain.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonAddAgain.IconColor = System.Drawing.Color.Black;
            this.iconButtonAddAgain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddAgain.Location = new System.Drawing.Point(992, 205);
            this.iconButtonAddAgain.Name = "iconButtonAddAgain";
            this.iconButtonAddAgain.Size = new System.Drawing.Size(142, 31);
            this.iconButtonAddAgain.TabIndex = 5;
            this.iconButtonAddAgain.Text = "Registrar de Nuevo";
            this.iconButtonAddAgain.UseVisualStyleBackColor = true;
            this.iconButtonAddAgain.Click += new System.EventHandler(this.iconButtonAddAgain_Click);
            // 
            // iconButtonEdit
            // 
            this.iconButtonEdit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonEdit.IconColor = System.Drawing.Color.Black;
            this.iconButtonEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEdit.Location = new System.Drawing.Point(992, 299);
            this.iconButtonEdit.Name = "iconButtonEdit";
            this.iconButtonEdit.Size = new System.Drawing.Size(142, 31);
            this.iconButtonEdit.TabIndex = 6;
            this.iconButtonEdit.Text = "Editar";
            this.iconButtonEdit.UseVisualStyleBackColor = true;
            this.iconButtonEdit.Click += new System.EventHandler(this.iconButtonEdit_Click);
            // 
            // iconButtonDelete
            // 
            this.iconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonDelete.IconColor = System.Drawing.Color.Black;
            this.iconButtonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDelete.Location = new System.Drawing.Point(992, 390);
            this.iconButtonDelete.Name = "iconButtonDelete";
            this.iconButtonDelete.Size = new System.Drawing.Size(142, 31);
            this.iconButtonDelete.TabIndex = 7;
            this.iconButtonDelete.Text = "Eliminar";
            this.iconButtonDelete.UseVisualStyleBackColor = true;
            this.iconButtonDelete.Click += new System.EventHandler(this.iconButtonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar por Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buscar por Numero de Control";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 697);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButtonDelete);
            this.Controls.Add(this.iconButtonEdit);
            this.Controls.Add(this.iconButtonAddAgain);
            this.Controls.Add(this.iconButtonSearch);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxSearchControl);
            this.Controls.Add(this.textBoxSearchName);
            this.Controls.Add(this.iconButtonOpenFormAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonOpenFormAdd;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.TextBox textBoxSearchControl;
        private System.Windows.Forms.DataGridView dataGridView;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private FontAwesome.Sharp.IconButton iconButtonAddAgain;
        private FontAwesome.Sharp.IconButton iconButtonEdit;
        private FontAwesome.Sharp.IconButton iconButtonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}