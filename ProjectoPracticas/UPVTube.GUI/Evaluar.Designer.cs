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
            this.button1 = new System.Windows.Forms.Button();
            this.listaPendientes = new System.Windows.Forms.ListBox();
            this.botonPer = new System.Windows.Forms.Button();
            this.botonRec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Evaluar Contenido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 503);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaPendientes
            // 
            this.listaPendientes.FormattingEnabled = true;
            this.listaPendientes.ItemHeight = 20;
            this.listaPendientes.Location = new System.Drawing.Point(67, 70);
            this.listaPendientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaPendientes.Name = "listaPendientes";
            this.listaPendientes.Size = new System.Drawing.Size(784, 404);
            this.listaPendientes.Sorted = true;
            this.listaPendientes.TabIndex = 13;
            this.listaPendientes.SelectedIndexChanged += new System.EventHandler(this.listaPendientes_SelectedIndexChanged_1);
            // 
            // botonPer
            // 
            this.botonPer.Location = new System.Drawing.Point(603, 500);
            this.botonPer.Name = "botonPer";
            this.botonPer.Size = new System.Drawing.Size(105, 46);
            this.botonPer.TabIndex = 14;
            this.botonPer.Text = "Autorizar";
            this.botonPer.UseVisualStyleBackColor = true;
            this.botonPer.Click += new System.EventHandler(this.botonPer_Click);
            // 
            // botonRec
            // 
            this.botonRec.Location = new System.Drawing.Point(742, 500);
            this.botonRec.Name = "botonRec";
            this.botonRec.Size = new System.Drawing.Size(109, 46);
            this.botonRec.TabIndex = 15;
            this.botonRec.Text = "Rechazar";
            this.botonRec.UseVisualStyleBackColor = true;
            this.botonRec.Click += new System.EventHandler(this.botonRec_Click);
            // 
            // Evaluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.botonRec);
            this.Controls.Add(this.botonPer);
            this.Controls.Add(this.listaPendientes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Evaluar";
            this.Text = "Evaluar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listaPendientes;
        private System.Windows.Forms.Button botonPer;
        private System.Windows.Forms.Button botonRec;
    }
}