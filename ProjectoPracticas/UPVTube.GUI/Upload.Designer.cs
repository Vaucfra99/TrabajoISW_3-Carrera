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
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxSubjects = new System.Windows.Forms.CheckedListBox();
            this.ButtonSubir = new UPVTube.GUI.custom.Botones();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(28, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Introduzca el título:";
            // 
            // TextBoxTitulo
            // 
            this.TextBoxTitulo.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTitulo.Location = new System.Drawing.Point(236, 54);
            this.TextBoxTitulo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxTitulo.Name = "TextBoxTitulo";
            this.TextBoxTitulo.Size = new System.Drawing.Size(236, 32);
            this.TextBoxTitulo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(30, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Introduzca la descripción:";
            // 
            // TextBoxDescripcion
            // 
            this.TextBoxDescripcion.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDescripcion.Location = new System.Drawing.Point(32, 152);
            this.TextBoxDescripcion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxDescripcion.Multiline = true;
            this.TextBoxDescripcion.Name = "TextBoxDescripcion";
            this.TextBoxDescripcion.Size = new System.Drawing.Size(440, 126);
            this.TextBoxDescripcion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(42, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Introduzca la URI:";
            // 
            // TextBoxURI
            // 
            this.TextBoxURI.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxURI.Location = new System.Drawing.Point(236, 323);
            this.TextBoxURI.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxURI.Name = "TextBoxURI";
            this.TextBoxURI.Size = new System.Drawing.Size(236, 32);
            this.TextBoxURI.TabIndex = 6;
            // 
            // CheckBoxPublico
            // 
            this.CheckBoxPublico.AutoSize = true;
            this.CheckBoxPublico.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxPublico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CheckBoxPublico.Location = new System.Drawing.Point(46, 543);
            this.CheckBoxPublico.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CheckBoxPublico.Name = "CheckBoxPublico";
            this.CheckBoxPublico.Size = new System.Drawing.Size(251, 24);
            this.CheckBoxPublico.TabIndex = 7;
            this.CheckBoxPublico.Text = "¿Desea que sea público?";
            this.CheckBoxPublico.UseVisualStyleBackColor = true;
            this.CheckBoxPublico.CheckedChanged += new System.EventHandler(this.CheckBoxPublico_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Asignaturas:";
            // 
            // checkedListBoxSubjects
            // 
            this.checkedListBoxSubjects.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxSubjects.FormattingEnabled = true;
            this.checkedListBoxSubjects.Location = new System.Drawing.Point(206, 405);
            this.checkedListBoxSubjects.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.checkedListBoxSubjects.Name = "checkedListBoxSubjects";
            this.checkedListBoxSubjects.Size = new System.Drawing.Size(100, 120);
            this.checkedListBoxSubjects.TabIndex = 11;
            // 
            // ButtonSubir
            // 
            this.ButtonSubir.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonSubir.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonSubir.BorderColor = System.Drawing.Color.White;
            this.ButtonSubir.BorderRadius = 20;
            this.ButtonSubir.BorderSize = 0;
            this.ButtonSubir.FlatAppearance.BorderSize = 0;
            this.ButtonSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSubir.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSubir.ForeColor = System.Drawing.Color.White;
            this.ButtonSubir.Location = new System.Drawing.Point(174, 628);
            this.ButtonSubir.Name = "ButtonSubir";
            this.ButtonSubir.Size = new System.Drawing.Size(155, 58);
            this.ButtonSubir.TabIndex = 12;
            this.ButtonSubir.Text = "SUBIR";
            this.ButtonSubir.TextColor = System.Drawing.Color.White;
            this.ButtonSubir.UseVisualStyleBackColor = false;
            this.ButtonSubir.Click += new System.EventHandler(this.ButtonSubir_Click);
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(502, 728);
            this.Controls.Add(this.ButtonSubir);
            this.Controls.Add(this.checkedListBoxSubjects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckBoxPublico);
            this.Controls.Add(this.TextBoxURI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxTitulo);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxSubjects;
        private custom.Botones ButtonSubir;
    }
}