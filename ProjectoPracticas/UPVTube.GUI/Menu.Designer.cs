namespace UPVTube.GUI
{
    partial class Menu
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
            this.ButtonBuscar = new System.Windows.Forms.Button();
            this.ButtonSubir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonEvaluate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonBuscar
            // 
            this.ButtonBuscar.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.ButtonBuscar.Location = new System.Drawing.Point(65, 130);
            this.ButtonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonBuscar.Name = "ButtonBuscar";
            this.ButtonBuscar.Size = new System.Drawing.Size(95, 35);
            this.ButtonBuscar.TabIndex = 0;
            this.ButtonBuscar.Text = "Buscar";
            this.ButtonBuscar.UseVisualStyleBackColor = true;
            this.ButtonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // ButtonSubir
            // 
            this.ButtonSubir.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.ButtonSubir.Location = new System.Drawing.Point(265, 130);
            this.ButtonSubir.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSubir.Name = "ButtonSubir";
            this.ButtonSubir.Size = new System.Drawing.Size(132, 35);
            this.ButtonSubir.TabIndex = 1;
            this.ButtonSubir.Text = "Subir Contenido";
            this.ButtonSubir.UseVisualStyleBackColor = true;
            this.ButtonSubir.Click += new System.EventHandler(this.ButtonSubir_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sitka Small", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(236, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "¡Bienvenid@!";
            // 
            // ButtonEvaluate
            // 
            this.ButtonEvaluate.Location = new System.Drawing.Point(479, 137);
            this.ButtonEvaluate.Name = "ButtonEvaluate";
            this.ButtonEvaluate.Size = new System.Drawing.Size(118, 27);
            this.ButtonEvaluate.TabIndex = 4;
            this.ButtonEvaluate.Text = "Evaluar";
            this.ButtonEvaluate.UseVisualStyleBackColor = true;
            this.ButtonEvaluate.Click += new System.EventHandler(this.buttonEvaluate_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(653, 396);
            this.Controls.Add(this.ButtonEvaluate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSubir);
            this.Controls.Add(this.ButtonBuscar);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonBuscar;
        private System.Windows.Forms.Button ButtonSubir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonEvaluate;
    }
}