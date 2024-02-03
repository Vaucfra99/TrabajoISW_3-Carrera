namespace UPVTube.GUI
{
    partial class Comentar
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
            this.textBoxComentar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonComentar = new UPVTube.GUI.custom.Botones();
            this.SuspendLayout();
            // 
            // textBoxComentar
            // 
            this.textBoxComentar.Location = new System.Drawing.Point(89, 78);
            this.textBoxComentar.Multiline = true;
            this.textBoxComentar.Name = "textBoxComentar";
            this.textBoxComentar.Size = new System.Drawing.Size(361, 222);
            this.textBoxComentar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(85, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escribe aquí tu comentario:";
            // 
            // buttonComentar
            // 
            this.buttonComentar.BackColor = System.Drawing.Color.Navy;
            this.buttonComentar.BackgroundColor = System.Drawing.Color.Navy;
            this.buttonComentar.BorderColor = System.Drawing.Color.White;
            this.buttonComentar.BorderRadius = 20;
            this.buttonComentar.BorderSize = 0;
            this.buttonComentar.FlatAppearance.BorderSize = 0;
            this.buttonComentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComentar.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComentar.ForeColor = System.Drawing.Color.White;
            this.buttonComentar.Location = new System.Drawing.Point(294, 319);
            this.buttonComentar.Name = "buttonComentar";
            this.buttonComentar.Size = new System.Drawing.Size(156, 51);
            this.buttonComentar.TabIndex = 3;
            this.buttonComentar.Text = "Comentar";
            this.buttonComentar.TextColor = System.Drawing.Color.White;
            this.buttonComentar.UseVisualStyleBackColor = false;
            this.buttonComentar.Click += new System.EventHandler(this.buttonComentar_Click);
            // 
            // Comentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(547, 404);
            this.Controls.Add(this.buttonComentar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxComentar);
            this.Name = "Comentar";
            this.Text = "Comentar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Comentar_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxComentar;
        private System.Windows.Forms.Label label1;
        private custom.Botones buttonComentar;
    }
}