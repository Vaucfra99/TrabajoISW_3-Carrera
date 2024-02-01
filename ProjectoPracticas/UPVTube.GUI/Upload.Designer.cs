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
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxURI = new System.Windows.Forms.TextBox();
            this.CheckBoxPublico = new System.Windows.Forms.CheckBox();
            this.ButtonSubir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxSubjects = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(28, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Introduzca el título";
            // 
            // TextBoxTitulo
            // 
            this.TextBoxTitulo.Location = new System.Drawing.Point(148, 35);
            this.TextBoxTitulo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxTitulo.Name = "TextBoxTitulo";
            this.TextBoxTitulo.Size = new System.Drawing.Size(159, 20);
            this.TextBoxTitulo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(28, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Introduzca la descripción";
            // 
            // TextBoxDescripcion
            // 
            this.TextBoxDescripcion.Location = new System.Drawing.Point(31, 99);
            this.TextBoxDescripcion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxDescripcion.Multiline = true;
            this.TextBoxDescripcion.Name = "TextBoxDescripcion";
            this.TextBoxDescripcion.Size = new System.Drawing.Size(285, 83);
            this.TextBoxDescripcion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(28, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Introduzca la URI";
            // 
            // TextBoxURI
            // 
            this.TextBoxURI.Location = new System.Drawing.Point(157, 210);
            this.TextBoxURI.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxURI.Name = "TextBoxURI";
            this.TextBoxURI.Size = new System.Drawing.Size(159, 20);
            this.TextBoxURI.TabIndex = 6;
            // 
            // CheckBoxPublico
            // 
            this.CheckBoxPublico.AutoSize = true;
            this.CheckBoxPublico.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.CheckBoxPublico.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CheckBoxPublico.Location = new System.Drawing.Point(31, 353);
            this.CheckBoxPublico.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CheckBoxPublico.Name = "CheckBoxPublico";
            this.CheckBoxPublico.Size = new System.Drawing.Size(156, 20);
            this.CheckBoxPublico.TabIndex = 7;
            this.CheckBoxPublico.Text = "Desea que sea público?";
            this.CheckBoxPublico.UseVisualStyleBackColor = true;
            this.CheckBoxPublico.CheckedChanged += new System.EventHandler(this.CheckBoxPublico_CheckedChanged);
            // 
            // ButtonSubir
            // 
            this.ButtonSubir.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.ButtonSubir.Location = new System.Drawing.Point(128, 398);
            this.ButtonSubir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ButtonSubir.Name = "ButtonSubir";
            this.ButtonSubir.Size = new System.Drawing.Size(72, 33);
            this.ButtonSubir.TabIndex = 8;
            this.ButtonSubir.Text = "SUBIR";
            this.ButtonSubir.UseVisualStyleBackColor = true;
            this.ButtonSubir.Click += new System.EventHandler(this.ButtonSubir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(28, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Asignaturas";
            // 
            // checkedListBoxSubjects
            // 
            this.checkedListBoxSubjects.FormattingEnabled = true;
            this.checkedListBoxSubjects.Location = new System.Drawing.Point(137, 263);
            this.checkedListBoxSubjects.Margin = new System.Windows.Forms.Padding(5);
            this.checkedListBoxSubjects.Name = "checkedListBoxSubjects";
            this.checkedListBoxSubjects.Size = new System.Drawing.Size(50, 79);
            this.checkedListBoxSubjects.TabIndex = 11;
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(335, 473);
            this.Controls.Add(this.checkedListBoxSubjects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSubir);
            this.Controls.Add(this.CheckBoxPublico);
            this.Controls.Add(this.TextBoxURI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxTitulo);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Upload";
            this.Text = "Upload";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Upload_FormClosing);
            this.Load += new System.EventHandler(this.Upload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxURI;
        private System.Windows.Forms.CheckBox CheckBoxPublico;
        private System.Windows.Forms.Button ButtonSubir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxSubjects;
    }
}