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
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonSubir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(76, 180);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(127, 43);
            this.buttonBuscar.TabIndex = 0;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonSubir
            // 
            this.buttonSubir.Location = new System.Drawing.Point(356, 180);
            this.buttonSubir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSubir.Name = "buttonSubir";
            this.buttonSubir.Size = new System.Drawing.Size(176, 43);
            this.buttonSubir.TabIndex = 1;
            this.buttonSubir.Text = "Subir Contenido";
            this.buttonSubir.UseVisualStyleBackColor = true;
            this.buttonSubir.Click += new System.EventHandler(this.buttonSubir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "¡Bienvenid@!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Location = new System.Drawing.Point(398, 293);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(123, 33);
            this.BtnVolver.TabIndex = 3;
            this.BtnVolver.Text = "Salir";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 344);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSubir);
            this.Controls.Add(this.buttonBuscar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonSubir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnVolver;
    }
}