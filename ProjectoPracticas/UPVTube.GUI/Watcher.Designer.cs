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
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.UploadTextBox = new System.Windows.Forms.TextBox();
            this.CreatorTextBox = new System.Windows.Forms.TextBox();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(15, 17);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(60, 20);
            this.Title.TabIndex = 0;
            this.Title.Text = "Titulo:";
            // 
            // CreatorNick
            // 
            this.CreatorNick.AutoSize = true;
            this.CreatorNick.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.CreatorNick.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreatorNick.Location = new System.Drawing.Point(3, 28);
            this.CreatorNick.Name = "CreatorNick";
            this.CreatorNick.Size = new System.Drawing.Size(74, 20);
            this.CreatorNick.TabIndex = 1;
            this.CreatorNick.Text = "Creador:";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.Description.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Description.Location = new System.Drawing.Point(3, 141);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(101, 20);
            this.Description.TabIndex = 2;
            this.Description.Text = "Descripcion:";
            this.Description.Click += new System.EventHandler(this.Description_Click);
            // 
            // UploadDate
            // 
            this.UploadDate.AutoSize = true;
            this.UploadDate.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.UploadDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UploadDate.Location = new System.Drawing.Point(3, 94);
            this.UploadDate.Name = "UploadDate";
            this.UploadDate.Size = new System.Drawing.Size(77, 40);
            this.UploadDate.TabIndex = 3;
            this.UploadDate.Text = "Fecha de subida:";
            // 
            // IdLable
            // 
            this.IdLable.AutoSize = true;
            this.IdLable.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.IdLable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IdLable.Location = new System.Drawing.Point(3, 55);
            this.IdLable.Name = "IdLable";
            this.IdLable.Size = new System.Drawing.Size(91, 20);
            this.IdLable.TabIndex = 4;
            this.IdLable.Text = "Contenido:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.62637F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.37363F));
            this.tableLayoutPanel1.Controls.Add(this.Description, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.UploadDate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.IdLable, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CreatorNick, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DescripcionTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TitleTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ContentTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.UploadTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CreatorTextBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(117, 144);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(365, 230);
            this.DescripcionTextBox.TabIndex = 9;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(117, 3);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(365, 22);
            this.TitleTextBox.TabIndex = 10;
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Location = new System.Drawing.Point(117, 58);
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(365, 22);
            this.ContentTextBox.TabIndex = 11;
            // 
            // UploadTextBox
            // 
            this.UploadTextBox.Location = new System.Drawing.Point(117, 97);
            this.UploadTextBox.Name = "UploadTextBox";
            this.UploadTextBox.Size = new System.Drawing.Size(365, 22);
            this.UploadTextBox.TabIndex = 12;
            // 
            // CreatorTextBox
            // 
            this.CreatorTextBox.Location = new System.Drawing.Point(117, 31);
            this.CreatorTextBox.Name = "CreatorTextBox";
            this.CreatorTextBox.Size = new System.Drawing.Size(365, 22);
            this.CreatorTextBox.TabIndex = 13;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.GoBackButton.Location = new System.Drawing.Point(17, 422);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(75, 23);
            this.GoBackButton.TabIndex = 6;
            this.GoBackButton.Text = "Atrás";
            this.GoBackButton.UseVisualStyleBackColor = true;
            // 
            // Watcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(505, 471);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label IdLable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.TextBox UploadTextBox;
        private System.Windows.Forms.TextBox CreatorTextBox;
    }
}