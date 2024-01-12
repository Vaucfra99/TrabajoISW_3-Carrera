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
            this.TextBoxMotivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonEv = new System.Windows.Forms.Button();
            this.BotonEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxMotivo
            // 
            this.TextBoxMotivo.Location = new System.Drawing.Point(140, 79);
            this.TextBoxMotivo.Multiline = true;
            this.TextBoxMotivo.Name = "TextBoxMotivo";
            this.TextBoxMotivo.Size = new System.Drawing.Size(617, 364);
            this.TextBoxMotivo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(321, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Motivo del Rechazo";
            // 
            // BotonEv
            // 
            this.BotonEv.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.BotonEv.Location = new System.Drawing.Point(140, 484);
            this.BotonEv.Name = "BotonEv";
            this.BotonEv.Size = new System.Drawing.Size(100, 42);
            this.BotonEv.TabIndex = 2;
            this.BotonEv.Text = "Atrás";
            this.BotonEv.UseVisualStyleBackColor = true;
            // 
            // BotonEmail
            // 
            this.BotonEmail.Location = new System.Drawing.Point(657, 484);
            this.BotonEmail.Name = "BotonEmail";
            this.BotonEmail.Size = new System.Drawing.Size(100, 41);
            this.BotonEmail.TabIndex = 3;
            this.BotonEmail.Text = "Aceptar";
            this.BotonEmail.UseVisualStyleBackColor = true;
            this.BotonEmail.Click += new System.EventHandler(this.BotonEmail_Click);
            // 
            // Rechazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.BotonEmail);
            this.Controls.Add(this.BotonEv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxMotivo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Rechazo";
            this.Text = "Rechazo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxMotivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonEv;
        private System.Windows.Forms.Button BotonEmail;
    }
}