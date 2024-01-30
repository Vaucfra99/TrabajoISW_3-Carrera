namespace UPVTube.GUI
{
    partial class Watcher
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
            this.Title = new System.Windows.Forms.Label();
            this.CreatorNick = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.UploadDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxPropietario = new System.Windows.Forms.TextBox();
            this.textBoxUri = new System.Windows.Forms.TextBox();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(11, 14);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(47, 16);
            this.Title.TabIndex = 0;
            this.Title.Text = "Titulo:";
            // 
            // CreatorNick
            // 
            this.CreatorNick.AutoSize = true;
            this.CreatorNick.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.CreatorNick.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreatorNick.Location = new System.Drawing.Point(2, 22);
            this.CreatorNick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreatorNick.Name = "CreatorNick";
            this.CreatorNick.Size = new System.Drawing.Size(58, 16);
            this.CreatorNick.TabIndex = 1;
            this.CreatorNick.Text = "Creador:";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.Description.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Description.Location = new System.Drawing.Point(2, 114);
            this.Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(81, 16);
            this.Description.TabIndex = 2;
            this.Description.Text = "Descripcion:";
            // 
            // UploadDate
            // 
            this.UploadDate.AutoSize = true;
            this.UploadDate.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.UploadDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UploadDate.Location = new System.Drawing.Point(2, 76);
            this.UploadDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UploadDate.Name = "UploadDate";
            this.UploadDate.Size = new System.Drawing.Size(60, 32);
            this.UploadDate.TabIndex = 3;
            this.UploadDate.Text = "Fecha de subida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(2, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Uri:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.62637F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.37363F));
            this.tableLayoutPanel1.Controls.Add(this.Description, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.UploadDate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CreatorNick, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDescripcion, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDate, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPropietario, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxUri, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 306);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(87, 116);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(275, 188);
            this.textBoxDescripcion.TabIndex = 9;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(87, 2);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(275, 20);
            this.textBoxTitle.TabIndex = 10;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(87, 78);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(275, 20);
            this.textBoxDate.TabIndex = 12;
            // 
            // textBoxPropietario
            // 
            this.textBoxPropietario.Location = new System.Drawing.Point(87, 24);
            this.textBoxPropietario.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPropietario.Name = "textBoxPropietario";
            this.textBoxPropietario.Size = new System.Drawing.Size(275, 20);
            this.textBoxPropietario.TabIndex = 13;
            // 
            // textBoxUri
            // 
            this.textBoxUri.Location = new System.Drawing.Point(88, 47);
            this.textBoxUri.Name = "textBoxUri";
            this.textBoxUri.Size = new System.Drawing.Size(273, 20);
            this.textBoxUri.TabIndex = 14;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(19, 346);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(72, 31);
            this.buttonVolver.TabIndex = 6;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            this.buttonVolver.Leave += new System.EventHandler(this.buttonVolver_Click);
            // 
            // Watcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 383);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Watcher";
            this.Text = "Watcher";
            this.Load += new System.EventHandler(this.Watcher_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label CreatorNick;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label UploadDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxPropietario;
        private System.Windows.Forms.TextBox textBoxUri;
        private System.Windows.Forms.Button buttonVolver;
    }
}