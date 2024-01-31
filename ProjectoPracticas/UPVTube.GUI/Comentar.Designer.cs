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
            this.buttonComentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxComentar
            // 
            this.textBoxComentar.Location = new System.Drawing.Point(89, 83);
            this.textBoxComentar.Multiline = true;
            this.textBoxComentar.Name = "textBoxComentar";
            this.textBoxComentar.Size = new System.Drawing.Size(361, 222);
            this.textBoxComentar.TabIndex = 0;
            this.textBoxComentar.TextChanged += new System.EventHandler(this.textBoxComentar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escribe aquí tu comentario:";
            // 
            // buttonComentar
            // 
            this.buttonComentar.Location = new System.Drawing.Point(354, 332);
            this.buttonComentar.Name = "buttonComentar";
            this.buttonComentar.Size = new System.Drawing.Size(96, 32);
            this.buttonComentar.TabIndex = 2;
            this.buttonComentar.Text = "Comentar";
            this.buttonComentar.UseVisualStyleBackColor = true;
            this.buttonComentar.Click += new System.EventHandler(this.buttonComentar_Click);
            // 
            // Comentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 404);
            this.Controls.Add(this.buttonComentar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxComentar);
            this.Name = "Comentar";
            this.Text = "Comentar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Comentar_FormClosing);
            this.Load += new System.EventHandler(this.Comentar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxComentar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonComentar;
    }
}