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
            this.BtnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonBuscar
            // 
            this.ButtonBuscar.Location = new System.Drawing.Point(86, 225);
            this.ButtonBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBuscar.Name = "ButtonBuscar";
            this.ButtonBuscar.Size = new System.Drawing.Size(143, 54);
            this.ButtonBuscar.TabIndex = 0;
            this.ButtonBuscar.Text = "Buscar";
            this.ButtonBuscar.UseVisualStyleBackColor = true;
            this.ButtonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // ButtonSubir
            // 
            this.ButtonSubir.Location = new System.Drawing.Point(400, 225);
            this.ButtonSubir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSubir.Name = "ButtonSubir";
            this.ButtonSubir.Size = new System.Drawing.Size(198, 54);
            this.ButtonSubir.TabIndex = 1;
            this.ButtonSubir.Text = "Subir Contenido";
            this.ButtonSubir.UseVisualStyleBackColor = true;
            this.ButtonSubir.Click += new System.EventHandler(this.ButtonSubir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "¡Bienvenid@!";
            // 
            // BtnVolver
            // 
            this.BtnVolver.Location = new System.Drawing.Point(448, 366);
            this.BtnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(138, 41);
            this.BtnVolver.TabIndex = 3;
            this.BtnVolver.Text = "Salir";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 430);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSubir);
            this.Controls.Add(this.ButtonBuscar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBuscar;
        private System.Windows.Forms.Button ButtonSubir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnVolver;
    }
}