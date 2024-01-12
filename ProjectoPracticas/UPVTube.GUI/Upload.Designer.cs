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
            this.TextBoxTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxURI = new System.Windows.Forms.TextBox();
            this.CheckBoxPublico = new System.Windows.Forms.CheckBox();
            this.ButtonSubir = new System.Windows.Forms.Button();
            this.ButtonAtras = new System.Windows.Forms.Button();
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
            // TextBoxTitulo
            // 
            this.TextBoxTitulo.Location = new System.Drawing.Point(186, 105);
            this.TextBoxTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxTitulo.Name = "TextBoxTitulo";
            this.TextBoxTitulo.Size = new System.Drawing.Size(236, 26);
            this.TextBoxTitulo.TabIndex = 2;
            this.TextBoxTitulo.TextChanged += new System.EventHandler(this.TextBoxTitulo_TextChanged);
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
            // TextBoxDescripcion
            // 
            this.TextBoxDescripcion.Location = new System.Drawing.Point(55, 185);
            this.TextBoxDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxDescripcion.Multiline = true;
            this.TextBoxDescripcion.Name = "TextBoxDescripcion";
            this.TextBoxDescripcion.Size = new System.Drawing.Size(366, 125);
            this.TextBoxDescripcion.TabIndex = 4;
            this.TextBoxDescripcion.TextChanged += new System.EventHandler(this.TextBoxDescripcion_TextChanged);
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
            // TextBoxURI
            // 
            this.TextBoxURI.Location = new System.Drawing.Point(186, 336);
            this.TextBoxURI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxURI.Name = "TextBoxURI";
            this.TextBoxURI.Size = new System.Drawing.Size(236, 26);
            this.TextBoxURI.TabIndex = 6;
            this.TextBoxURI.TextChanged += new System.EventHandler(this.TextBoxURI_TextChanged);
            // 
            // CheckBoxPublico
            // 
            this.CheckBoxPublico.AutoSize = true;
            this.CheckBoxPublico.Location = new System.Drawing.Point(55, 388);
            this.CheckBoxPublico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckBoxPublico.Name = "CheckBoxPublico";
            this.CheckBoxPublico.Size = new System.Drawing.Size(197, 24);
            this.CheckBoxPublico.TabIndex = 7;
            this.CheckBoxPublico.Text = "Desea que sea público";
            this.CheckBoxPublico.UseVisualStyleBackColor = true;
            this.CheckBoxPublico.CheckedChanged += new System.EventHandler(this.CheckBoxPublico_CheckedChanged);
            // 
            // ButtonSubir
            // 
            this.ButtonSubir.Location = new System.Drawing.Point(186, 450);
            this.ButtonSubir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSubir.Name = "ButtonSubir";
            this.ButtonSubir.Size = new System.Drawing.Size(108, 51);
            this.ButtonSubir.TabIndex = 8;
            this.ButtonSubir.Text = "SUBIR";
            this.ButtonSubir.UseVisualStyleBackColor = true;
            this.ButtonSubir.Click += new System.EventHandler(this.ButtonSubir_Click);
            // 
            // ButtonAtras
            // 
            this.ButtonAtras.Location = new System.Drawing.Point(15, 519);
            this.ButtonAtras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAtras.Name = "ButtonAtras";
            this.ButtonAtras.Size = new System.Drawing.Size(62, 29);
            this.ButtonAtras.TabIndex = 9;
            this.ButtonAtras.Text = "Atrás";
            this.ButtonAtras.UseVisualStyleBackColor = true;
            this.ButtonAtras.Click += new System.EventHandler(this.ButtonAtras_Click);
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 562);
            this.Controls.Add(this.ButtonAtras);
            this.Controls.Add(this.ButtonSubir);
            this.Controls.Add(this.CheckBoxPublico);
            this.Controls.Add(this.TextBoxURI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Upload";
            this.Text = "Upload";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxURI;
        private System.Windows.Forms.CheckBox CheckBoxPublico;
        private System.Windows.Forms.Button ButtonSubir;
        private System.Windows.Forms.Button ButtonAtras;
    }
}