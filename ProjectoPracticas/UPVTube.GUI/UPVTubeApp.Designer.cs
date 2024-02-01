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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BtnRegister = new UPVTube.GUI.custom.Botones();
            this.BtnLogin = new UPVTube.GUI.custom.Botones();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBD = new UPVTube.GUI.custom.Botones();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UPVTube.GUI.Properties.Resources._3259396_media_social_youtube_icon;
            this.pictureBox1.Location = new System.Drawing.Point(-54, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(593, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.Navy;
            this.BtnRegister.BackgroundColor = System.Drawing.Color.Navy;
            this.BtnRegister.BorderColor = System.Drawing.Color.White;
            this.BtnRegister.BorderRadius = 20;
            this.BtnRegister.BorderSize = 0;
            this.BtnRegister.FlatAppearance.BorderSize = 0;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.Color.White;
            this.BtnRegister.Location = new System.Drawing.Point(545, 290);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(177, 68);
            this.BtnRegister.TabIndex = 6;
            this.BtnRegister.Text = "Registrarse";
            this.BtnRegister.TextColor = System.Drawing.Color.White;
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnLogin.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BtnLogin.BorderColor = System.Drawing.Color.White;
            this.BtnLogin.BorderRadius = 20;
            this.BtnLogin.BorderSize = 0;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.BtnLogin.Location = new System.Drawing.Point(545, 182);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(177, 67);
            this.BtnLogin.TabIndex = 7;
            this.BtnLogin.Text = "Iniciar Sesión";
            this.BtnLogin.TextColor = System.Drawing.Color.Transparent;
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(260, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bienvenid@ a UPVTube";
            // 
            // buttonBD
            // 
            this.buttonBD.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonBD.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.buttonBD.BorderColor = System.Drawing.Color.White;
            this.buttonBD.BorderRadius = 20;
            this.buttonBD.BorderSize = 0;
            this.buttonBD.FlatAppearance.BorderSize = 0;
            this.buttonBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBD.Font = new System.Drawing.Font("Lucida Sans Unicode", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBD.ForeColor = System.Drawing.Color.White;
            this.buttonBD.Location = new System.Drawing.Point(12, 451);
            this.buttonBD.Name = "buttonBD";
            this.buttonBD.Size = new System.Drawing.Size(145, 43);
            this.buttonBD.TabIndex = 9;
            this.buttonBD.Text = "Reiniciar BD";
            this.buttonBD.TextColor = System.Drawing.Color.White;
            this.buttonBD.UseVisualStyleBackColor = false;
            this.buttonBD.Click += new System.EventHandler(this.buttonBD_Click);
            // 
            // UPVTubeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(821, 513);
            this.Controls.Add(this.buttonBD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UPVTubeApp";
            this.Text = "UPVTube";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UPVTubeApp_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private custom.Botones BtnRegister;
        private custom.Botones BtnLogin;
        private System.Windows.Forms.Label label1;
        private custom.Botones buttonBD;
    }
}

