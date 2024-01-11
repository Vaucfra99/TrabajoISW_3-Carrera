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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Evaluar Contenido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaPendientes
            // 
            this.listaPendientes.FormattingEnabled = true;
            this.listaPendientes.ItemHeight = 16;
            this.listaPendientes.Location = new System.Drawing.Point(36, 49);
            this.listaPendientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaPendientes.Name = "listaPendientes";
            this.listaPendientes.Size = new System.Drawing.Size(697, 324);
            this.listaPendientes.Sorted = true;
            this.listaPendientes.TabIndex = 13;
            this.listaPendientes.SelectedIndexChanged += new System.EventHandler(this.listaPendientes_SelectedIndexChanged_1);
            // 
            // Evaluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaPendientes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Evaluar";
            this.Text = "Evaluar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listaPendientes;
    }
}