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
            this.buttonAtras = new System.Windows.Forms.Button();
            this.BotonPer = new System.Windows.Forms.Button();
            this.BotonRec = new System.Windows.Forms.Button();
            this.buttonShowPending = new System.Windows.Forms.Button();
            this.GridPending = new System.Windows.Forms.DataGridView();
            this.contentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publico = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FechaSubida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignaturas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridPending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(321, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Evaluar Contenido";
            // 
            // buttonAtras
            // 
            this.buttonAtras.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.buttonAtras.Location = new System.Drawing.Point(43, 324);
            this.buttonAtras.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(71, 30);
            this.buttonAtras.TabIndex = 6;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            this.buttonAtras.Leave += new System.EventHandler(this.buttonAtras_Click);
            // 
            // BotonPer
            // 
            this.BotonPer.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.BotonPer.Location = new System.Drawing.Point(420, 324);
            this.BotonPer.Margin = new System.Windows.Forms.Padding(2);
            this.BotonPer.Name = "BotonPer";
            this.BotonPer.Size = new System.Drawing.Size(99, 30);
            this.BotonPer.TabIndex = 14;
            this.BotonPer.Text = "Autorizar";
            this.BotonPer.UseVisualStyleBackColor = true;
            this.BotonPer.Click += new System.EventHandler(this.BotonPer_Click);
            // 
            // BotonRec
            // 
            this.BotonRec.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.BotonRec.Location = new System.Drawing.Point(602, 324);
            this.BotonRec.Margin = new System.Windows.Forms.Padding(2);
            this.BotonRec.Name = "BotonRec";
            this.BotonRec.Size = new System.Drawing.Size(85, 30);
            this.BotonRec.TabIndex = 15;
            this.BotonRec.Text = "Rechazar";
            this.BotonRec.UseVisualStyleBackColor = true;
            this.BotonRec.Click += new System.EventHandler(this.BotonRec_Click);
            // 
            // buttonShowPending
            // 
            this.buttonShowPending.Location = new System.Drawing.Point(190, 325);
            this.buttonShowPending.Name = "buttonShowPending";
            this.buttonShowPending.Size = new System.Drawing.Size(147, 29);
            this.buttonShowPending.TabIndex = 16;
            this.buttonShowPending.Text = "Mostrar Pendientes";
            this.buttonShowPending.UseVisualStyleBackColor = true;
            this.buttonShowPending.Click += new System.EventHandler(this.buttonShowPending_Click);
            // 
            // GridPending
            // 
            this.GridPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPending.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Autor,
            this.Descripcion,
            this.Publico,
            this.FechaSubida,
            this.Asignaturas});
            this.GridPending.Location = new System.Drawing.Point(45, 62);
            this.GridPending.Name = "GridPending";
            this.GridPending.Size = new System.Drawing.Size(1222, 223);
            this.GridPending.TabIndex = 17;
            // 
            // contentBindingSource
            // 
            this.contentBindingSource.DataSource = typeof(UPVTube.Entities.Content);
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 200;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.Width = 50;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Publico
            // 
            this.Publico.HeaderText = "Publico";
            this.Publico.Name = "Publico";
            // 
            // FechaSubida
            // 
            this.FechaSubida.HeaderText = "FechaSubida";
            this.FechaSubida.Name = "FechaSubida";
            // 
            // Asignaturas
            // 
            this.Asignaturas.HeaderText = "Asignaturas";
            this.Asignaturas.Name = "Asignaturas";
            this.Asignaturas.Width = 500;
            // 
            // Evaluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1406, 365);
            this.Controls.Add(this.GridPending);
            this.Controls.Add(this.buttonShowPending);
            this.Controls.Add(this.BotonRec);
            this.Controls.Add(this.BotonPer);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Evaluar";
            this.Text = "Evaluar";
            ((System.ComponentModel.ISupportInitialize)(this.GridPending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Button BotonPer;
        private System.Windows.Forms.Button BotonRec;
        private System.Windows.Forms.Button buttonShowPending;
        private System.Windows.Forms.BindingSource contentBindingSource;
        private System.Windows.Forms.DataGridView GridPending;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Publico;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSubida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignaturas;
    }
}