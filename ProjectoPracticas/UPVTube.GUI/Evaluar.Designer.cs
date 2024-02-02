namespace UPVTube.GUI
{
    partial class Evaluar
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
            this.label1 = new System.Windows.Forms.Label();
            this.contentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMotivo = new System.Windows.Forms.TextBox();
            this.GridPending = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSubida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignaturas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BotonRec = new UPVTube.GUI.custom.Botones();
            this.BotonPer = new UPVTube.GUI.custom.Botones();
            this.buttonVerCont = new UPVTube.GUI.custom.Botones();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPending)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(249, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Evaluar Contenido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentBindingSource
            // 
            this.contentBindingSource.DataSource = typeof(UPVTube.Entities.Content);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(256, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Motivo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMotivo
            // 
            this.textBoxMotivo.Location = new System.Drawing.Point(45, 352);
            this.textBoxMotivo.Multiline = true;
            this.textBoxMotivo.Name = "textBoxMotivo";
            this.textBoxMotivo.Size = new System.Drawing.Size(692, 127);
            this.textBoxMotivo.TabIndex = 20;
            // 
            // GridPending
            // 
            this.GridPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPending.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Autor,
            this.Descripcion,
            this.Acceso,
            this.FechaSubida,
            this.Asignaturas,
            this.Id});
            this.GridPending.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.GridPending.Location = new System.Drawing.Point(43, 63);
            this.GridPending.MultiSelect = false;
            this.GridPending.Name = "GridPending";
            this.GridPending.RowHeadersWidth = 62;
            this.GridPending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPending.Size = new System.Drawing.Size(693, 214);
            this.GridPending.TabIndex = 21;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 8;
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 200;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 8;
            this.Autor.Name = "Autor";
            this.Autor.Width = 75;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 150;
            // 
            // Acceso
            // 
            this.Acceso.HeaderText = "Acceso";
            this.Acceso.MinimumWidth = 8;
            this.Acceso.Name = "Acceso";
            this.Acceso.Width = 75;
            // 
            // FechaSubida
            // 
            this.FechaSubida.HeaderText = "Fecha de Subida";
            this.FechaSubida.MinimumWidth = 8;
            this.FechaSubida.Name = "FechaSubida";
            this.FechaSubida.Width = 150;
            // 
            // Asignaturas
            // 
            this.Asignaturas.HeaderText = "Asignaturas";
            this.Asignaturas.MinimumWidth = 8;
            this.Asignaturas.Name = "Asignaturas";
            this.Asignaturas.Width = 150;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 150;
            // 
            // BotonRec
            // 
            this.BotonRec.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BotonRec.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BotonRec.BorderColor = System.Drawing.Color.White;
            this.BotonRec.BorderRadius = 20;
            this.BotonRec.BorderSize = 0;
            this.BotonRec.FlatAppearance.BorderSize = 0;
            this.BotonRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonRec.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold);
            this.BotonRec.ForeColor = System.Drawing.Color.White;
            this.BotonRec.Location = new System.Drawing.Point(603, 514);
            this.BotonRec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonRec.Name = "BotonRec";
            this.BotonRec.Size = new System.Drawing.Size(133, 37);
            this.BotonRec.TabIndex = 25;
            this.BotonRec.Text = "Rechazar";
            this.BotonRec.TextColor = System.Drawing.Color.White;
            this.BotonRec.UseVisualStyleBackColor = false;
            this.BotonRec.Click += new System.EventHandler(this.BotonRec_Click);
            // 
            // BotonPer
            // 
            this.BotonPer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BotonPer.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BotonPer.BorderColor = System.Drawing.Color.White;
            this.BotonPer.BorderRadius = 20;
            this.BotonPer.BorderSize = 0;
            this.BotonPer.FlatAppearance.BorderSize = 0;
            this.BotonPer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonPer.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold);
            this.BotonPer.ForeColor = System.Drawing.Color.White;
            this.BotonPer.Location = new System.Drawing.Point(323, 514);
            this.BotonPer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonPer.Name = "BotonPer";
            this.BotonPer.Size = new System.Drawing.Size(133, 37);
            this.BotonPer.TabIndex = 24;
            this.BotonPer.Text = "Autorizar";
            this.BotonPer.TextColor = System.Drawing.Color.White;
            this.BotonPer.UseVisualStyleBackColor = false;
            this.BotonPer.Click += new System.EventHandler(this.BotonPer_Click);
            // 
            // buttonVerCont
            // 
            this.buttonVerCont.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonVerCont.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.buttonVerCont.BorderColor = System.Drawing.Color.White;
            this.buttonVerCont.BorderRadius = 20;
            this.buttonVerCont.BorderSize = 0;
            this.buttonVerCont.FlatAppearance.BorderSize = 0;
            this.buttonVerCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerCont.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold);
            this.buttonVerCont.ForeColor = System.Drawing.Color.White;
            this.buttonVerCont.Location = new System.Drawing.Point(45, 514);
            this.buttonVerCont.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonVerCont.Name = "buttonVerCont";
            this.buttonVerCont.Size = new System.Drawing.Size(133, 37);
            this.buttonVerCont.TabIndex = 23;
            this.buttonVerCont.Text = "Ver Contenido";
            this.buttonVerCont.TextColor = System.Drawing.Color.White;
            this.buttonVerCont.UseVisualStyleBackColor = false;
            this.buttonVerCont.Click += new System.EventHandler(this.buttonVerCont_Click);
            // 
            // Evaluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(775, 581);
            this.Controls.Add(this.BotonRec);
            this.Controls.Add(this.BotonPer);
            this.Controls.Add(this.buttonVerCont);
            this.Controls.Add(this.GridPending);
            this.Controls.Add(this.textBoxMotivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Evaluar";
            this.Text = "Evaluar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Evaluar_FormClosing);
            this.Load += new System.EventHandler(this.Evaluar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPending)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource contentBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMotivo;
        private System.Windows.Forms.DataGridView GridPending;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSubida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignaturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private custom.Botones buttonVerCont;
        private custom.Botones BotonPer;
        private custom.Botones BotonRec;
    }
}