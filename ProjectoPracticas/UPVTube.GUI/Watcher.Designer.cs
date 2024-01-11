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
            this.IdLable = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.titleField = new System.Windows.Forms.Label();
            this.CreatorNickField = new System.Windows.Forms.Label();
            this.ContentIdField = new System.Windows.Forms.Label();
            this.UploadDateField = new System.Windows.Forms.Label();
            this.DescriptionField = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(3, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(43, 16);
            this.Title.TabIndex = 0;
            this.Title.Text = "Titulo:";
            // 
            // CreatorNick
            // 
            this.CreatorNick.AutoSize = true;
            this.CreatorNick.Location = new System.Drawing.Point(3, 28);
            this.CreatorNick.Name = "CreatorNick";
            this.CreatorNick.Size = new System.Drawing.Size(59, 16);
            this.CreatorNick.TabIndex = 1;
            this.CreatorNick.Text = "Creador:";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(3, 141);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(82, 16);
            this.Description.TabIndex = 2;
            this.Description.Text = "Descripcion:";
            // 
            // UploadDate
            // 
            this.UploadDate.AutoSize = true;
            this.UploadDate.Location = new System.Drawing.Point(3, 94);
            this.UploadDate.Name = "UploadDate";
            this.UploadDate.Size = new System.Drawing.Size(67, 32);
            this.UploadDate.TabIndex = 3;
            this.UploadDate.Text = "Fecha de subida:";
            // 
            // IdLable
            // 
            this.IdLable.AutoSize = true;
            this.IdLable.Location = new System.Drawing.Point(3, 55);
            this.IdLable.Name = "IdLable";
            this.IdLable.Size = new System.Drawing.Size(71, 16);
            this.IdLable.TabIndex = 4;
            this.IdLable.Text = "Contenido:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.5567F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.4433F));
            this.tableLayoutPanel1.Controls.Add(this.Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Description, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.UploadDate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.IdLable, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CreatorNick, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.titleField, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CreatorNickField, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ContentIdField, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.UploadDateField, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DescriptionField, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(485, 377);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // titleField
            // 
            this.titleField.AutoSize = true;
            this.titleField.Location = new System.Drawing.Point(92, 0);
            this.titleField.Name = "titleField";
            this.titleField.Size = new System.Drawing.Size(44, 16);
            this.titleField.TabIndex = 5;
            this.titleField.Text = "label1";
            // 
            // CreatorNickField
            // 
            this.CreatorNickField.AutoSize = true;
            this.CreatorNickField.Location = new System.Drawing.Point(92, 28);
            this.CreatorNickField.Name = "CreatorNickField";
            this.CreatorNickField.Size = new System.Drawing.Size(44, 16);
            this.CreatorNickField.TabIndex = 6;
            this.CreatorNickField.Text = "label2";
            // 
            // ContentIdField
            // 
            this.ContentIdField.AutoSize = true;
            this.ContentIdField.Location = new System.Drawing.Point(92, 55);
            this.ContentIdField.Name = "ContentIdField";
            this.ContentIdField.Size = new System.Drawing.Size(44, 16);
            this.ContentIdField.TabIndex = 7;
            this.ContentIdField.Text = "label3";
            // 
            // UploadDateField
            // 
            this.UploadDateField.AutoSize = true;
            this.UploadDateField.Location = new System.Drawing.Point(92, 94);
            this.UploadDateField.Name = "UploadDateField";
            this.UploadDateField.Size = new System.Drawing.Size(44, 16);
            this.UploadDateField.TabIndex = 8;
            this.UploadDateField.Text = "label4";
            // 
            // DescriptionField
            // 
            this.DescriptionField.AutoSize = true;
            this.DescriptionField.Location = new System.Drawing.Point(92, 141);
            this.DescriptionField.Name = "DescriptionField";
            this.DescriptionField.Size = new System.Drawing.Size(44, 16);
            this.DescriptionField.TabIndex = 9;
            this.DescriptionField.Text = "label5";
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(236, 421);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(75, 23);
            this.GoBackButton.TabIndex = 6;
            this.GoBackButton.Text = "Atrás";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // Watcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 473);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Watcher";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label CreatorNick;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label UploadDate;
        private System.Windows.Forms.Label IdLable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label titleField;
        private System.Windows.Forms.Label CreatorNickField;
        private System.Windows.Forms.Label ContentIdField;
        private System.Windows.Forms.Label UploadDateField;
        private System.Windows.Forms.Label DescriptionField;
        private System.Windows.Forms.Button GoBackButton;
    }
}