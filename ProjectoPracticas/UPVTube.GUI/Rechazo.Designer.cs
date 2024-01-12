namespace UPVTube.GUI
{
    partial class Rechazo
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
            this.textBoxMotivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonEv = new System.Windows.Forms.Button();
            this.botonEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMotivo
            // 
            this.textBoxMotivo.Location = new System.Drawing.Point(140, 79);
            this.textBoxMotivo.Multiline = true;
            this.textBoxMotivo.Name = "textBoxMotivo";
            this.textBoxMotivo.Size = new System.Drawing.Size(617, 364);
            this.textBoxMotivo.TabIndex = 0;
            this.textBoxMotivo.TextChanged += new System.EventHandler(this.textBoxMotivo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Motivo del Rechazo";
            // 
            // botonEv
            // 
            this.botonEv.Location = new System.Drawing.Point(140, 484);
            this.botonEv.Name = "botonEv";
            this.botonEv.Size = new System.Drawing.Size(100, 42);
            this.botonEv.TabIndex = 2;
            this.botonEv.Text = "Atrás";
            this.botonEv.UseVisualStyleBackColor = true;
            this.botonEv.Click += new System.EventHandler(this.botonEv_Click);
            // 
            // botonEmail
            // 
            this.botonEmail.Location = new System.Drawing.Point(657, 484);
            this.botonEmail.Name = "botonEmail";
            this.botonEmail.Size = new System.Drawing.Size(100, 41);
            this.botonEmail.TabIndex = 3;
            this.botonEmail.Text = "Aceptar";
            this.botonEmail.UseVisualStyleBackColor = true;
            this.botonEmail.Click += new System.EventHandler(this.botonEmail_Click);
            // 
            // Rechazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.botonEmail);
            this.Controls.Add(this.botonEv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMotivo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Rechazo";
            this.Text = "Rechazo";
            this.Load += new System.EventHandler(this.Rechazo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMotivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonEv;
        private System.Windows.Forms.Button botonEmail;
    }
}