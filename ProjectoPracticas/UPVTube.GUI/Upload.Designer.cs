namespace UPVTube.GUI
{
    partial class Upload
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxURI = new System.Windows.Forms.TextBox();
            this.checkBoxPublico = new System.Windows.Forms.CheckBox();
            this.buttonSubir = new System.Windows.Forms.Button();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subir contenido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Introduzca el título";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(186, 105);
            this.textBoxTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(236, 26);
            this.textBoxTitulo.TabIndex = 2;
            this.textBoxTitulo.TextChanged += new System.EventHandler(this.textBoxTitulo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Introduzca la descripción";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(55, 185);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(366, 125);
            this.textBoxDescripcion.TabIndex = 4;
            this.textBoxDescripcion.TextChanged += new System.EventHandler(this.textBoxDescripcion_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Introduzca la URI";
            // 
            // textBoxURI
            // 
            this.textBoxURI.Location = new System.Drawing.Point(186, 336);
            this.textBoxURI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxURI.Name = "textBoxURI";
            this.textBoxURI.Size = new System.Drawing.Size(236, 26);
            this.textBoxURI.TabIndex = 6;
            this.textBoxURI.TextChanged += new System.EventHandler(this.textBoxURI_TextChanged);
            // 
            // checkBoxPublico
            // 
            this.checkBoxPublico.AutoSize = true;
            this.checkBoxPublico.Location = new System.Drawing.Point(55, 388);
            this.checkBoxPublico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxPublico.Name = "checkBoxPublico";
            this.checkBoxPublico.Size = new System.Drawing.Size(197, 24);
            this.checkBoxPublico.TabIndex = 7;
            this.checkBoxPublico.Text = "Desea que sea público";
            this.checkBoxPublico.UseVisualStyleBackColor = true;
            this.checkBoxPublico.CheckedChanged += new System.EventHandler(this.checkBoxPublico_CheckedChanged);
            // 
            // buttonSubir
            // 
            this.buttonSubir.Location = new System.Drawing.Point(186, 450);
            this.buttonSubir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSubir.Name = "buttonSubir";
            this.buttonSubir.Size = new System.Drawing.Size(108, 51);
            this.buttonSubir.TabIndex = 8;
            this.buttonSubir.Text = "SUBIR";
            this.buttonSubir.UseVisualStyleBackColor = true;
            this.buttonSubir.Click += new System.EventHandler(this.buttonSubir_Click);
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(15, 519);
            this.buttonAtras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(62, 29);
            this.buttonAtras.TabIndex = 9;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 562);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.buttonSubir);
            this.Controls.Add(this.checkBoxPublico);
            this.Controls.Add(this.textBoxURI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Upload";
            this.Text = "Upload";
            this.Load += new System.EventHandler(this.Upload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxURI;
        private System.Windows.Forms.CheckBox checkBoxPublico;
        private System.Windows.Forms.Button buttonSubir;
        private System.Windows.Forms.Button buttonAtras;
    }
}