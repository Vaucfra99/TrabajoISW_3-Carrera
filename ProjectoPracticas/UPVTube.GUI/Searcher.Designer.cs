namespace UPVTube.GUI
{
    partial class Searcher
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
            this.components = new System.ComponentModel.Container();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUplNick = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelEarly = new System.Windows.Forms.Label();
            this.labelLate = new System.Windows.Forms.Label();
            this.dateTimePickerEarly = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLate = new System.Windows.Forms.DateTimePicker();
            this.GridContents = new System.Windows.Forms.DataGridView();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.contentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.comboBoxMember = new System.Windows.Forms.ComboBox();
            this.buttonVerCont = new UPVTube.GUI.custom.Botones();
            this.buttonSearch = new UPVTube.GUI.custom.Botones();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSubida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignaturas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimoAcceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridContents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitle.Location = new System.Drawing.Point(28, 75);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(73, 22);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Título:";
            // 
            // labelUplNick
            // 
            this.labelUplNick.AutoSize = true;
            this.labelUplNick.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUplNick.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUplNick.Location = new System.Drawing.Point(28, 129);
            this.labelUplNick.Name = "labelUplNick";
            this.labelUplNick.Size = new System.Drawing.Size(174, 22);
            this.labelUplNick.TabIndex = 1;
            this.labelUplNick.Text = "Nick del creador:";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSubject.Location = new System.Drawing.Point(28, 185);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(120, 22);
            this.labelSubject.TabIndex = 2;
            this.labelSubject.Text = "Asignatura:";
            // 
            // labelEarly
            // 
            this.labelEarly.AutoSize = true;
            this.labelEarly.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEarly.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEarly.Location = new System.Drawing.Point(34, 283);
            this.labelEarly.Name = "labelEarly";
            this.labelEarly.Size = new System.Drawing.Size(236, 22);
            this.labelEarly.TabIndex = 6;
            this.labelEarly.Text = "Fecha de subida inicial:";
            // 
            // labelLate
            // 
            this.labelLate.AutoSize = true;
            this.labelLate.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLate.Location = new System.Drawing.Point(34, 383);
            this.labelLate.Name = "labelLate";
            this.labelLate.Size = new System.Drawing.Size(222, 22);
            this.labelLate.TabIndex = 7;
            this.labelLate.Text = "Fecha de subida final:";
            // 
            // dateTimePickerEarly
            // 
            this.dateTimePickerEarly.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEarly.Location = new System.Drawing.Point(39, 308);
            this.dateTimePickerEarly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerEarly.Name = "dateTimePickerEarly";
            this.dateTimePickerEarly.Size = new System.Drawing.Size(394, 32);
            this.dateTimePickerEarly.TabIndex = 8;
            // 
            // dateTimePickerLate
            // 
            this.dateTimePickerLate.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerLate.Location = new System.Drawing.Point(39, 408);
            this.dateTimePickerLate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerLate.Name = "dateTimePickerLate";
            this.dateTimePickerLate.Size = new System.Drawing.Size(394, 32);
            this.dateTimePickerLate.TabIndex = 9;
            // 
            // GridContents
            // 
            this.GridContents.AllowUserToAddRows = false;
            this.GridContents.AllowUserToDeleteRows = false;
            this.GridContents.AllowUserToResizeColumns = false;
            this.GridContents.AllowUserToResizeRows = false;
            this.GridContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridContents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Propietario,
            this.Descripcion,
            this.Acceso,
            this.FechaSubida,
            this.Asignaturas,
            this.UltimoAcceso,
            this.ID});
            this.GridContents.Location = new System.Drawing.Point(507, 60);
            this.GridContents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridContents.MultiSelect = false;
            this.GridContents.Name = "GridContents";
            this.GridContents.RowHeadersWidth = 62;
            this.GridContents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridContents.Size = new System.Drawing.Size(1102, 488);
            this.GridContents.TabIndex = 14;
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubject.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(210, 182);
            this.comboBoxSubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(241, 28);
            this.comboBoxSubject.TabIndex = 15;
            // 
            // contentBindingSource
            // 
            this.contentBindingSource.DataSource = typeof(UPVTube.Entities.Content);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(208, 72);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(242, 32);
            this.textBoxTitle.TabIndex = 3;
            // 
            // comboBoxMember
            // 
            this.comboBoxMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMember.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMember.FormattingEnabled = true;
            this.comboBoxMember.Location = new System.Drawing.Point(210, 129);
            this.comboBoxMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMember.Name = "comboBoxMember";
            this.comboBoxMember.Size = new System.Drawing.Size(241, 28);
            this.comboBoxMember.TabIndex = 16;
            // 
            // buttonVerCont
            // 
            this.buttonVerCont.BackColor = System.Drawing.Color.Navy;
            this.buttonVerCont.BackgroundColor = System.Drawing.Color.Navy;
            this.buttonVerCont.BorderColor = System.Drawing.Color.White;
            this.buttonVerCont.BorderRadius = 20;
            this.buttonVerCont.BorderSize = 0;
            this.buttonVerCont.FlatAppearance.BorderSize = 0;
            this.buttonVerCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerCont.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerCont.ForeColor = System.Drawing.Color.White;
            this.buttonVerCont.Location = new System.Drawing.Point(39, 498);
            this.buttonVerCont.Name = "buttonVerCont";
            this.buttonVerCont.Size = new System.Drawing.Size(164, 65);
            this.buttonVerCont.TabIndex = 20;
            this.buttonVerCont.Text = "Ver Contenido";
            this.buttonVerCont.TextColor = System.Drawing.Color.White;
            this.buttonVerCont.UseVisualStyleBackColor = false;
            this.buttonVerCont.Click += new System.EventHandler(this.buttonVerCont_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSearch.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSearch.BorderColor = System.Drawing.Color.White;
            this.buttonSearch.BorderRadius = 20;
            this.buttonSearch.BorderSize = 0;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(266, 498);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(166, 65);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.TextColor = System.Drawing.Color.White;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Titulo
            // 
            this.Titulo.Frozen = true;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 8;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 150;
            // 
            // Propietario
            // 
            this.Propietario.Frozen = true;
            this.Propietario.HeaderText = "Propietario";
            this.Propietario.MinimumWidth = 8;
            this.Propietario.Name = "Propietario";
            this.Propietario.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.Frozen = true;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 90;
            // 
            // Acceso
            // 
            this.Acceso.Frozen = true;
            this.Acceso.HeaderText = "Acceso";
            this.Acceso.MinimumWidth = 8;
            this.Acceso.Name = "Acceso";
            this.Acceso.ReadOnly = true;
            // 
            // FechaSubida
            // 
            this.FechaSubida.Frozen = true;
            this.FechaSubida.HeaderText = "FechaSubida";
            this.FechaSubida.MinimumWidth = 8;
            this.FechaSubida.Name = "FechaSubida";
            this.FechaSubida.ReadOnly = true;
            this.FechaSubida.Width = 250;
            // 
            // Asignaturas
            // 
            this.Asignaturas.Frozen = true;
            this.Asignaturas.HeaderText = "Asignaturas";
            this.Asignaturas.MinimumWidth = 8;
            this.Asignaturas.Name = "Asignaturas";
            this.Asignaturas.ReadOnly = true;
            this.Asignaturas.Width = 150;
            // 
            // UltimoAcceso
            // 
            this.UltimoAcceso.Frozen = true;
            this.UltimoAcceso.HeaderText = "UltimoAcceso";
            this.UltimoAcceso.MinimumWidth = 8;
            this.UltimoAcceso.Name = "UltimoAcceso";
            this.UltimoAcceso.ReadOnly = true;
            this.UltimoAcceso.Width = 250;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 150;
            // 
            // Searcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1712, 632);
            this.Controls.Add(this.buttonVerCont);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxMember);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.GridContents);
            this.Controls.Add(this.dateTimePickerLate);
            this.Controls.Add(this.dateTimePickerEarly);
            this.Controls.Add(this.labelLate);
            this.Controls.Add(this.labelEarly);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelUplNick);
            this.Controls.Add(this.labelTitle);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Searcher";
            this.Text = "Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Searcher_FormClosing);
            this.Load += new System.EventHandler(this.Searcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridContents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUplNick;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelEarly;
        private System.Windows.Forms.Label labelLate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEarly;
        private System.Windows.Forms.DateTimePicker dateTimePickerLate;
        private System.Windows.Forms.BindingSource contentBindingSource;
        private System.Windows.Forms.DataGridView GridContents;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ComboBox comboBoxMember;
        private custom.Botones buttonSearch;
        private custom.Botones buttonVerCont;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSubida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignaturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimoAcceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}