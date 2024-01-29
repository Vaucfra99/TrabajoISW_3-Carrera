namespace UPVTube.GUI
{
    partial class UPVTubeApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.buttonBD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenid@ a UPVTube";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.BtnLogin.Location = new System.Drawing.Point(9, 73);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(106, 39);
            this.BtnLogin.TabIndex = 1;
            this.BtnLogin.Text = "Iniciar Sesión";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.BtnRegister.Location = new System.Drawing.Point(132, 73);
            this.BtnRegister.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(106, 39);
            this.BtnRegister.TabIndex = 2;
            this.BtnRegister.Text = "Registrarse";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.BtnExit.Location = new System.Drawing.Point(181, 150);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(57, 32);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Salir";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // buttonBD
            // 
            this.buttonBD.Location = new System.Drawing.Point(20, 155);
            this.buttonBD.Name = "buttonBD";
            this.buttonBD.Size = new System.Drawing.Size(94, 26);
            this.buttonBD.TabIndex = 4;
            this.buttonBD.Text = "Reiniciar BD";
            this.buttonBD.UseVisualStyleBackColor = true;
            this.buttonBD.Click += new System.EventHandler(this.buttonBD_Click);
            // 
            // UPVTubeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(247, 191);
            this.Controls.Add(this.buttonBD);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "UPVTubeApp";
            this.Text = "UPVTube";
            this.Load += new System.EventHandler(this.UPVTubeApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button buttonBD;
    }
}

