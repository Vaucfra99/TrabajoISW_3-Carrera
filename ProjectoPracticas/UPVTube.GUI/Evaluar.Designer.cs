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
            this.listaPendientes = new System.Windows.Forms.ListView();
            this.textBoxComentario = new System.Windows.Forms.TextBox();
            this.buttonAutorizar = new System.Windows.Forms.Button();
            this.buttonDenegar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaPendientes
            // 
            this.listaPendientes.HideSelection = false;
            this.listaPendientes.Location = new System.Drawing.Point(25, 71);
            this.listaPendientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listaPendientes.Name = "listaPendientes";
            this.listaPendientes.Size = new System.Drawing.Size(844, 145);
            this.listaPendientes.TabIndex = 0;
            this.listaPendientes.UseCompatibleStateImageBehavior = false;
            this.listaPendientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listaPendientes_SelectedIndexChanged);
            // 
            // textBoxComentario
            // 
            this.textBoxComentario.Location = new System.Drawing.Point(25, 304);
            this.textBoxComentario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxComentario.Multiline = true;
            this.textBoxComentario.Name = "textBoxComentario";
            this.textBoxComentario.Size = new System.Drawing.Size(844, 126);
            this.textBoxComentario.TabIndex = 1;
            // 
            // buttonAutorizar
            // 
            this.buttonAutorizar.Location = new System.Drawing.Point(660, 489);
            this.buttonAutorizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAutorizar.Name = "buttonAutorizar";
            this.buttonAutorizar.Size = new System.Drawing.Size(94, 46);
            this.buttonAutorizar.TabIndex = 2;
            this.buttonAutorizar.Text = "Autorizar";
            this.buttonAutorizar.UseVisualStyleBackColor = true;
            this.buttonAutorizar.Click += new System.EventHandler(this.buttonAutorizar_Click);
            // 
            // buttonDenegar
            // 
            this.buttonDenegar.Location = new System.Drawing.Point(774, 489);
            this.buttonDenegar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDenegar.Name = "buttonDenegar";
            this.buttonDenegar.Size = new System.Drawing.Size(96, 46);
            this.buttonDenegar.TabIndex = 3;
            this.buttonDenegar.Text = "Denegar";
            this.buttonDenegar.UseVisualStyleBackColor = true;
            this.buttonDenegar.Click += new System.EventHandler(this.buttonDenegar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Evaluar Contenido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Motivo del rechazo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 489);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Evaluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDenegar);
            this.Controls.Add(this.buttonAutorizar);
            this.Controls.Add(this.textBoxComentario);
            this.Controls.Add(this.listaPendientes);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Evaluar";
            this.Text = "Evaluar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listaPendientes;
        private System.Windows.Forms.TextBox textBoxComentario;
        private System.Windows.Forms.Button buttonAutorizar;
        private System.Windows.Forms.Button buttonDenegar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}