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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.listaPendientes = new System.Windows.Forms.ListView();
            this.Título = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nick = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripción = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Público = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Asignaturas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Evaluar Contenido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 480);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(843, 71);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 372);
            this.vScrollBar1.TabIndex = 7;
            // 
            // listaPendientes
            // 
            this.listaPendientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Título,
            this.Nick,
            this.Descripción,
            this.Público,
            this.Subida,
            this.Asignaturas});
            this.listaPendientes.FullRowSelect = true;
            this.listaPendientes.GridLines = true;
            this.listaPendientes.HideSelection = false;
            this.listaPendientes.Location = new System.Drawing.Point(41, 71);
            this.listaPendientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listaPendientes.Name = "listaPendientes";
            this.listaPendientes.Size = new System.Drawing.Size(799, 372);
            this.listaPendientes.TabIndex = 0;
            this.listaPendientes.UseCompatibleStateImageBehavior = false;
            this.listaPendientes.View = System.Windows.Forms.View.Details;
            this.listaPendientes.SelectedIndexChanged += new System.EventHandler(this.listaPendientes_SelectedIndexChanged);
            this.listaPendientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listaPendientes_SelectedIndexChanged);
            // 
            // Título
            // 
            this.Título.Text = "Título";
            // 
            // Nick
            // 
            this.Nick.Text = "Nick";
            // 
            // Descripción
            // 
            this.Descripción.Text = "Descripción";
            // 
            // Público
            // 
            this.Público.Text = "Público";
            // 
            // Subida
            // 
            this.Subida.Text = "Fecha";
            // 
            // Asignaturas
            // 
            this.Asignaturas.Text = "Asignaturas";
            // 
            // Evaluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaPendientes);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Evaluar";
            this.Text = "Evaluar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ListView listaPendientes;
        private System.Windows.Forms.ColumnHeader Título;
        private System.Windows.Forms.ColumnHeader Nick;
        private System.Windows.Forms.ColumnHeader Descripción;
        private System.Windows.Forms.ColumnHeader Público;
        private System.Windows.Forms.ColumnHeader Subida;
        private System.Windows.Forms.ColumnHeader Asignaturas;
    }
}