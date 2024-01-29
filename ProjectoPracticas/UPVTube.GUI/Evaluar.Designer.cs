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
            this.buttonAtras = new System.Windows.Forms.Button();
            this.ListaPendientes = new System.Windows.Forms.ListBox();
            this.BotonPer = new System.Windows.Forms.Button();
            this.BotonRec = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(272, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Evaluar Contenido";
            // 
            // buttonAtras
            // 
            this.buttonAtras.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.buttonAtras.Location = new System.Drawing.Point(45, 327);
            this.buttonAtras.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(71, 30);
            this.buttonAtras.TabIndex = 6;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            this.buttonAtras.Leave += new System.EventHandler(this.buttonAtras_Click);
            // 
            // ListaPendientes
            // 
            this.ListaPendientes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ListaPendientes.FormattingEnabled = true;
            this.ListaPendientes.Location = new System.Drawing.Point(45, 46);
            this.ListaPendientes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ListaPendientes.Name = "ListaPendientes";
            this.ListaPendientes.Size = new System.Drawing.Size(524, 264);
            this.ListaPendientes.Sorted = true;
            this.ListaPendientes.TabIndex = 13;
            this.ListaPendientes.SelectedIndexChanged += new System.EventHandler(this.ListaPendientes_SelectedIndexChanged_1);
            // 
            // BotonPer
            // 
            this.BotonPer.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.BotonPer.Location = new System.Drawing.Point(351, 325);
            this.BotonPer.Margin = new System.Windows.Forms.Padding(2);
            this.BotonPer.Name = "BotonPer";
            this.BotonPer.Size = new System.Drawing.Size(99, 30);
            this.BotonPer.TabIndex = 14;
            this.BotonPer.Text = "Autorizar";
            this.BotonPer.UseVisualStyleBackColor = true;
            this.BotonPer.Click += new System.EventHandler(this.BotonPer_Click);
            // 
            // BotonRec
            // 
            this.BotonRec.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.BotonRec.Location = new System.Drawing.Point(483, 325);
            this.BotonRec.Margin = new System.Windows.Forms.Padding(2);
            this.BotonRec.Name = "BotonRec";
            this.BotonRec.Size = new System.Drawing.Size(85, 30);
            this.BotonRec.TabIndex = 15;
            this.BotonRec.Text = "Rechazar";
            this.BotonRec.UseVisualStyleBackColor = true;
            this.BotonRec.Click += new System.EventHandler(this.BotonRec_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(156, 325);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "Mostrar Pendientes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // Evaluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 365);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BotonRec);
            this.Controls.Add(this.BotonPer);
            this.Controls.Add(this.ListaPendientes);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Evaluar";
            this.Text = "Evaluar";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.ListBox ListaPendientes;
        private System.Windows.Forms.Button BotonPer;
        private System.Windows.Forms.Button BotonRec;
        private System.Windows.Forms.Button button2;
    }
}