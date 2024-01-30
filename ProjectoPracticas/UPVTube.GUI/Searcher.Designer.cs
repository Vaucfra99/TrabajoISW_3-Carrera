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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.GridContents = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSubida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignaturas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimoAcceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.contentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.comboBoxMember = new System.Windows.Forms.ComboBox();
            this.buttonVerCont = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridContents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(31, 38);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(47, 16);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Título:";
            // 
            // labelUplNick
            // 
            this.labelUplNick.AutoSize = true;
            this.labelUplNick.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.labelUplNick.Location = new System.Drawing.Point(31, 77);
            this.labelUplNick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUplNick.Name = "labelUplNick";
            this.labelUplNick.Size = new System.Drawing.Size(106, 16);
            this.labelUplNick.TabIndex = 1;
            this.labelUplNick.Text = "Nick del creador:";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.labelSubject.Location = new System.Drawing.Point(31, 110);
            this.labelSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(77, 16);
            this.labelSubject.TabIndex = 2;
            this.labelSubject.Text = "Asignatura:";
            // 
            // labelEarly
            // 
            this.labelEarly.AutoSize = true;
            this.labelEarly.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.labelEarly.Location = new System.Drawing.Point(31, 176);
            this.labelEarly.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEarly.Name = "labelEarly";
            this.labelEarly.Size = new System.Drawing.Size(143, 16);
            this.labelEarly.TabIndex = 6;
            this.labelEarly.Text = "Fecha de subida inicial:";
            // 
            // labelLate
            // 
            this.labelLate.AutoSize = true;
            this.labelLate.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.labelLate.Location = new System.Drawing.Point(31, 241);
            this.labelLate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLate.Name = "labelLate";
            this.labelLate.Size = new System.Drawing.Size(134, 16);
            this.labelLate.TabIndex = 7;
            this.labelLate.Text = "Fecha de subida final:";
            // 
            // dateTimePickerEarly
            // 
            this.dateTimePickerEarly.Location = new System.Drawing.Point(33, 201);
            this.dateTimePickerEarly.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateTimePickerEarly.Name = "dateTimePickerEarly";
            this.dateTimePickerEarly.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerEarly.TabIndex = 8;
            // 
            // dateTimePickerLate
            // 
            this.dateTimePickerLate.Location = new System.Drawing.Point(33, 265);
            this.dateTimePickerLate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateTimePickerLate.Name = "dateTimePickerLate";
            this.dateTimePickerLate.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerLate.TabIndex = 9;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.Location = new System.Drawing.Point(225, 321);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(56, 28);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.GoBackButton.Location = new System.Drawing.Point(35, 321);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(66, 28);
            this.GoBackButton.TabIndex = 13;
            this.GoBackButton.Text = "Atrás";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            this.GoBackButton.Leave += new System.EventHandler(this.GoBackButton_Click);
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
            this.GridContents.Location = new System.Drawing.Point(338, 39);
            this.GridContents.MultiSelect = false;
            this.GridContents.Name = "GridContents";
            this.GridContents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridContents.Size = new System.Drawing.Size(734, 309);
            this.GridContents.TabIndex = 14;
            // 
            // Titulo
            // 
            this.Titulo.Frozen = true;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Propietario
            // 
            this.Propietario.Frozen = true;
            this.Propietario.HeaderText = "Propietario";
            this.Propietario.Name = "Propietario";
            this.Propietario.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.Frozen = true;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Acceso
            // 
            this.Acceso.Frozen = true;
            this.Acceso.HeaderText = "Acceso";
            this.Acceso.Name = "Acceso";
            this.Acceso.ReadOnly = true;
            // 
            // FechaSubida
            // 
            this.FechaSubida.Frozen = true;
            this.FechaSubida.HeaderText = "FechaSubida";
            this.FechaSubida.Name = "FechaSubida";
            this.FechaSubida.ReadOnly = true;
            // 
            // Asignaturas
            // 
            this.Asignaturas.Frozen = true;
            this.Asignaturas.HeaderText = "Asignaturas";
            this.Asignaturas.Name = "Asignaturas";
            this.Asignaturas.ReadOnly = true;
            // 
            // UltimoAcceso
            // 
            this.UltimoAcceso.Frozen = true;
            this.UltimoAcceso.HeaderText = "UltimoAcceso";
            this.UltimoAcceso.Name = "UltimoAcceso";
            this.UltimoAcceso.ReadOnly = true;
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(135, 114);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(162, 21);
            this.comboBoxSubject.TabIndex = 15;
            // 
            // contentBindingSource
            // 
            this.contentBindingSource.DataSource = typeof(UPVTube.Entities.Content);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(135, 38);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(163, 20);
            this.textBoxTitle.TabIndex = 3;
            // 
            // comboBoxMember
            // 
            this.comboBoxMember.FormattingEnabled = true;
            this.comboBoxMember.Location = new System.Drawing.Point(136, 79);
            this.comboBoxMember.Name = "comboBoxMember";
            this.comboBoxMember.Size = new System.Drawing.Size(162, 21);
            this.comboBoxMember.TabIndex = 16;
            // 
            // buttonVerCont
            // 
            this.buttonVerCont.Location = new System.Drawing.Point(118, 321);
            this.buttonVerCont.Name = "buttonVerCont";
            this.buttonVerCont.Size = new System.Drawing.Size(88, 28);
            this.buttonVerCont.TabIndex = 17;
            this.buttonVerCont.Text = "Ver Contenido";
            this.buttonVerCont.UseVisualStyleBackColor = true;
            this.buttonVerCont.Click += new System.EventHandler(this.buttonVerCont_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Searcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1099, 365);
            this.Controls.Add(this.buttonVerCont);
            this.Controls.Add(this.comboBoxMember);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.GridContents);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dateTimePickerLate);
            this.Controls.Add(this.dateTimePickerEarly);
            this.Controls.Add(this.labelLate);
            this.Controls.Add(this.labelEarly);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelUplNick);
            this.Controls.Add(this.labelTitle);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Searcher";
            this.Text = "Search";
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
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.BindingSource contentBindingSource;
        private System.Windows.Forms.DataGridView GridContents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSubida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignaturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimoAcceso;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ComboBox comboBoxMember;
        private System.Windows.Forms.Button buttonVerCont;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}