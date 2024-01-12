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
            this.Button1 = new System.Windows.Forms.Button();
            this.ListaPendientes = new System.Windows.Forms.ListBox();
            this.BotonPer = new System.Windows.Forms.Button();
            this.BotonRec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(408, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Evaluar Contenido";
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.Button1.Location = new System.Drawing.Point(67, 503);
            this.Button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(84, 46);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "Atrás";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // ListaPendientes
            // 
            this.ListaPendientes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ListaPendientes.FormattingEnabled = true;
            this.ListaPendientes.ItemHeight = 20;
            this.ListaPendientes.Location = new System.Drawing.Point(67, 70);
            this.ListaPendientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListaPendientes.Name = "ListaPendientes";
            this.ListaPendientes.Size = new System.Drawing.Size(784, 404);
            this.ListaPendientes.Sorted = true;
            this.ListaPendientes.TabIndex = 13;
            this.ListaPendientes.SelectedIndexChanged += new System.EventHandler(this.ListaPendientes_SelectedIndexChanged_1);
            // 
            // BotonPer
            // 
            this.BotonPer.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.BotonPer.Location = new System.Drawing.Point(603, 500);
            this.BotonPer.Name = "BotonPer";
            this.BotonPer.Size = new System.Drawing.Size(105, 46);
            this.BotonPer.TabIndex = 14;
            this.BotonPer.Text = "Autorizar";
            this.BotonPer.UseVisualStyleBackColor = true;
            this.BotonPer.Click += new System.EventHandler(this.BotonPer_Click);
            // 
            // BotonRec
            // 
            this.BotonRec.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.BotonRec.Location = new System.Drawing.Point(742, 500);
            this.BotonRec.Name = "BotonRec";
            this.BotonRec.Size = new System.Drawing.Size(109, 46);
            this.BotonRec.TabIndex = 15;
            this.BotonRec.Text = "Rechazar";
            this.BotonRec.UseVisualStyleBackColor = true;
            this.BotonRec.Click += new System.EventHandler(this.BotonRec_Click);
            // 
            // Evaluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.BotonRec);
            this.Controls.Add(this.BotonPer);
            this.Controls.Add(this.ListaPendientes);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Evaluar";
            this.Text = "Evaluar";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.ListBox ListaPendientes;
        private System.Windows.Forms.Button BotonPer;
        private System.Windows.Forms.Button BotonRec;
    }
}