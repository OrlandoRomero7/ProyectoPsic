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
            this.iconButtonOpenFormAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(0)))), ((int)(((byte)(93)))));
            this.iconButtonOpenFormAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconButtonOpenFormAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOpenFormAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonOpenFormAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonOpenFormAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonOpenFormAdd.IconColor = System.Drawing.Color.Snow;
            this.iconButtonOpenFormAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonOpenFormAdd.IconSize = 25;
            this.iconButtonOpenFormAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonOpenFormAdd.Location = new System.Drawing.Point(35, 28);
            this.iconButtonOpenFormAdd.Name = "iconButtonOpenFormAdd";
            this.iconButtonOpenFormAdd.Size = new System.Drawing.Size(216, 48);
            this.iconButtonOpenFormAdd.TabIndex = 0;
            this.iconButtonOpenFormAdd.Text = "Crear Registro";
            this.iconButtonOpenFormAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOpenFormAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonOpenFormAdd.UseVisualStyleBackColor = false;
            this.iconButtonOpenFormAdd.Click += new System.EventHandler(this.iconButtonOpenFormAdd_Click);
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchName.Location = new System.Drawing.Point(35, 135);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(323, 34);
            this.textBoxSearchName.TabIndex = 1;
            // 
            // textBoxSearchControl
            // 
            this.textBoxSearchControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchControl.Location = new System.Drawing.Point(377, 135);
            this.textBoxSearchControl.Name = "textBoxSearchControl";
            this.textBoxSearchControl.Size = new System.Drawing.Size(324, 34);
            this.textBoxSearchControl.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(35, 205);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(932, 394);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // iconButtonSearch
            // 
            this.iconButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonSearch.IconColor = System.Drawing.Color.Black;
            this.iconButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearch.IconSize = 25;
            this.iconButtonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonSearch.Location = new System.Drawing.Point(731, 135);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Size = new System.Drawing.Size(142, 34);
            this.iconButtonSearch.TabIndex = 4;
            this.iconButtonSearch.Text = "Buscar";
            this.iconButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSearch.UseVisualStyleBackColor = true;
            this.iconButtonSearch.Click += new System.EventHandler(this.iconButtonSearch_Click);
            // 
            // iconButtonAddAgain
            // 
            this.iconButtonAddAgain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonAddAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(0)))), ((int)(((byte)(93)))));
            this.iconButtonAddAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAddAgain.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonAddAgain.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonAddAgain.IconColor = System.Drawing.Color.Black;
            this.iconButtonAddAgain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddAgain.Location = new System.Drawing.Point(992, 205);
            this.iconButtonAddAgain.Name = "iconButtonAddAgain";
            this.iconButtonAddAgain.Size = new System.Drawing.Size(148, 65);
            this.iconButtonAddAgain.TabIndex = 5;
            this.iconButtonAddAgain.Text = "Registrar de Nuevo";
            this.iconButtonAddAgain.UseVisualStyleBackColor = false;
            this.iconButtonAddAgain.Click += new System.EventHandler(this.iconButtonAddAgain_Click);
            // 
            // iconButtonEdit
            // 
            this.iconButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonEdit.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.iconButtonEdit.IconColor = System.Drawing.Color.Black;
            this.iconButtonEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEdit.IconSize = 25;
            this.iconButtonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonEdit.Location = new System.Drawing.Point(992, 307);
            this.iconButtonEdit.Name = "iconButtonEdit";
            this.iconButtonEdit.Size = new System.Drawing.Size(148, 50);
            this.iconButtonEdit.TabIndex = 6;
            this.iconButtonEdit.Text = "Editar";
            this.iconButtonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEdit.UseVisualStyleBackColor = true;
            this.iconButtonEdit.Click += new System.EventHandler(this.iconButtonEdit_Click);
            // 
            // iconButtonDelete
            // 
            this.iconButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonDelete.BackColor = System.Drawing.Color.Red;
            this.iconButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonDelete.IconColor = System.Drawing.Color.White;
            this.iconButtonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDelete.IconSize = 25;
            this.iconButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonDelete.Location = new System.Drawing.Point(992, 390);
            this.iconButtonDelete.Name = "iconButtonDelete";
            this.iconButtonDelete.Size = new System.Drawing.Size(148, 50);
            this.iconButtonDelete.TabIndex = 7;
            this.iconButtonDelete.Text = "Eliminar";
            this.iconButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDelete.UseVisualStyleBackColor = false;
            this.iconButtonDelete.Click += new System.EventHandler(this.iconButtonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar por Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buscar por Numero de Control";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(210)))), ((int)(((byte)(234)))));
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