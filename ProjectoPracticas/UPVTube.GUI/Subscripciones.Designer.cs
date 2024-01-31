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
            this.buttonSuscribe = new System.Windows.Forms.Button();
            this.buttonUnSubscribe = new System.Windows.Forms.Button();
            this.listViewSubscribed = new System.Windows.Forms.ListView();
            this.listViewNotSubscribed = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Miembros suscritos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Miembros no suscritos";
            // 
            // buttonSuscribe
            // 
            this.buttonSuscribe.Location = new System.Drawing.Point(200, 103);
            this.buttonSuscribe.Name = "buttonSuscribe";
            this.buttonSuscribe.Size = new System.Drawing.Size(106, 26);
            this.buttonSuscribe.TabIndex = 4;
            this.buttonSuscribe.Text = "Suscribirse";
            this.buttonSuscribe.UseVisualStyleBackColor = true;
            this.buttonSuscribe.Click += new System.EventHandler(this.buttonSuscribe_Click);
            // 
            // buttonUnSubscribe
            // 
            this.buttonUnSubscribe.Location = new System.Drawing.Point(200, 311);
            this.buttonUnSubscribe.Name = "buttonUnSubscribe";
            this.buttonUnSubscribe.Size = new System.Drawing.Size(106, 29);
            this.buttonUnSubscribe.TabIndex = 5;
            this.buttonUnSubscribe.Text = "Desuscribirse";
            this.buttonUnSubscribe.UseVisualStyleBackColor = true;
            this.buttonUnSubscribe.Click += new System.EventHandler(this.buttonUnSubscribe_Click);
            // 
            // listViewSubscribed
            // 
            this.listViewSubscribed.HideSelection = false;
            this.listViewSubscribed.Location = new System.Drawing.Point(48, 103);
            this.listViewSubscribed.MultiSelect = false;
            this.listViewSubscribed.Name = "listViewSubscribed";
            this.listViewSubscribed.Size = new System.Drawing.Size(91, 237);
            this.listViewSubscribed.TabIndex = 7;
            this.listViewSubscribed.UseCompatibleStateImageBehavior = false;
            this.listViewSubscribed.View = System.Windows.Forms.View.List;
            // 
            // listViewNotSubscribed
            // 
            this.listViewNotSubscribed.HideSelection = false;
            this.listViewNotSubscribed.Location = new System.Drawing.Point(367, 103);
            this.listViewNotSubscribed.Name = "listViewNotSubscribed";
            this.listViewNotSubscribed.Size = new System.Drawing.Size(107, 237);
            this.listViewNotSubscribed.TabIndex = 8;
            this.listViewNotSubscribed.UseCompatibleStateImageBehavior = false;
            this.listViewNotSubscribed.View = System.Windows.Forms.View.List;
            // 
            // Subscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 398);
            this.Controls.Add(this.listViewNotSubscribed);
            this.Controls.Add(this.listViewSubscribed);
            this.Controls.Add(this.buttonUnSubscribe);
            this.Controls.Add(this.buttonSuscribe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button buttonSuscribe;
        private System.Windows.Forms.Button buttonUnSubscribe;
        private System.Windows.Forms.ListView listViewSubscribed;
        private System.Windows.Forms.ListView listViewNotSubscribed;
    }
}