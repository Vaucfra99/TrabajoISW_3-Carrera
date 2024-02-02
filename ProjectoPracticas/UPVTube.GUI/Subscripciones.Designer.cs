namespace UPVTube.GUI
{
    partial class Subscripciones
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
            this.label2 = new System.Windows.Forms.Label();
            this.listViewSubscribed = new System.Windows.Forms.ListView();
            this.listViewNotSubscribed = new System.Windows.Forms.ListView();
            this.buttonUnSubscribe = new UPVTube.GUI.custom.Botones();
            this.buttonSuscribe = new UPVTube.GUI.custom.Botones();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(61, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Miembros suscritos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(513, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Miembros no suscritos";
            // 
            // listViewSubscribed
            // 
            this.listViewSubscribed.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listViewSubscribed.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSubscribed.HideSelection = false;
            this.listViewSubscribed.Location = new System.Drawing.Point(85, 158);
            this.listViewSubscribed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewSubscribed.MultiSelect = false;
            this.listViewSubscribed.Name = "listViewSubscribed";
            this.listViewSubscribed.Size = new System.Drawing.Size(158, 362);
            this.listViewSubscribed.TabIndex = 7;
            this.listViewSubscribed.UseCompatibleStateImageBehavior = false;
            this.listViewSubscribed.View = System.Windows.Forms.View.List;
            // 
            // listViewNotSubscribed
            // 
            this.listViewNotSubscribed.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listViewNotSubscribed.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewNotSubscribed.HideSelection = false;
            this.listViewNotSubscribed.Location = new System.Drawing.Point(550, 158);
            this.listViewNotSubscribed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewNotSubscribed.Name = "listViewNotSubscribed";
            this.listViewNotSubscribed.Size = new System.Drawing.Size(158, 362);
            this.listViewNotSubscribed.TabIndex = 8;
            this.listViewNotSubscribed.UseCompatibleStateImageBehavior = false;
            this.listViewNotSubscribed.View = System.Windows.Forms.View.List;
            // 
            // buttonUnSubscribe
            // 
            this.buttonUnSubscribe.BackColor = System.Drawing.Color.Navy;
            this.buttonUnSubscribe.BackgroundColor = System.Drawing.Color.Navy;
            this.buttonUnSubscribe.BorderColor = System.Drawing.Color.White;
            this.buttonUnSubscribe.BorderRadius = 20;
            this.buttonUnSubscribe.BorderSize = 0;
            this.buttonUnSubscribe.FlatAppearance.BorderSize = 0;
            this.buttonUnSubscribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnSubscribe.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnSubscribe.ForeColor = System.Drawing.Color.White;
            this.buttonUnSubscribe.Location = new System.Drawing.Point(315, 461);
            this.buttonUnSubscribe.Name = "buttonUnSubscribe";
            this.buttonUnSubscribe.Size = new System.Drawing.Size(162, 59);
            this.buttonUnSubscribe.TabIndex = 10;
            this.buttonUnSubscribe.Text = "Desuscribirse";
            this.buttonUnSubscribe.TextColor = System.Drawing.Color.White;
            this.buttonUnSubscribe.UseVisualStyleBackColor = false;
            this.buttonUnSubscribe.Click += new System.EventHandler(this.buttonUnSubscribe_Click);
            // 
            // buttonSuscribe
            // 
            this.buttonSuscribe.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSuscribe.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSuscribe.BorderColor = System.Drawing.Color.White;
            this.buttonSuscribe.BorderRadius = 20;
            this.buttonSuscribe.BorderSize = 0;
            this.buttonSuscribe.FlatAppearance.BorderSize = 0;
            this.buttonSuscribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuscribe.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuscribe.ForeColor = System.Drawing.Color.White;
            this.buttonSuscribe.Location = new System.Drawing.Point(315, 158);
            this.buttonSuscribe.Name = "buttonSuscribe";
            this.buttonSuscribe.Size = new System.Drawing.Size(162, 59);
            this.buttonSuscribe.TabIndex = 9;
            this.buttonSuscribe.Text = "Suscribirse";
            this.buttonSuscribe.TextColor = System.Drawing.Color.White;
            this.buttonSuscribe.UseVisualStyleBackColor = false;
            this.buttonSuscribe.Click += new System.EventHandler(this.buttonSuscribe_Click);
            // 
            // Subscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(795, 612);
            this.Controls.Add(this.buttonUnSubscribe);
            this.Controls.Add(this.buttonSuscribe);
            this.Controls.Add(this.listViewNotSubscribed);
            this.Controls.Add(this.listViewSubscribed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Subscripciones";
            this.Text = "Subscripciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Subscripciones_FormClosing);
            this.Load += new System.EventHandler(this.Subscripciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewSubscribed;
        private System.Windows.Forms.ListView listViewNotSubscribed;
        private custom.Botones buttonSuscribe;
        private custom.Botones buttonUnSubscribe;
    }
}