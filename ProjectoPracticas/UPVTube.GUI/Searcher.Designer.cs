namespace UPVTube.GUI
{
    partial class Searcher
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
            this.components = new System.ComponentModel.Container();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUplNick = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxUplNick = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.labelEarly = new System.Windows.Forms.Label();
            this.labelLate = new System.Windows.Forms.Label();
            this.dateTimePickerEarly = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLate = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.GridContents = new System.Windows.Forms.DataGridView();
            this.contentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPublicDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uploadDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastAccess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridContents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(41, 47);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(60, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Título:";
            // 
            // labelUplNick
            // 
            this.labelUplNick.AutoSize = true;
            this.labelUplNick.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.labelUplNick.Location = new System.Drawing.Point(41, 95);
            this.labelUplNick.Name = "labelUplNick";
            this.labelUplNick.Size = new System.Drawing.Size(134, 20);
            this.labelUplNick.TabIndex = 1;
            this.labelUplNick.Text = "Nick del creador:";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.labelSubject.Location = new System.Drawing.Point(41, 135);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(70, 20);
            this.labelSubject.TabIndex = 2;
            this.labelSubject.Text = "Subject:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(180, 47);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(216, 22);
            this.textBoxTitle.TabIndex = 3;
            // 
            // textBoxUplNick
            // 
            this.textBoxUplNick.Location = new System.Drawing.Point(180, 95);
            this.textBoxUplNick.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxUplNick.Name = "textBoxUplNick";
            this.textBoxUplNick.Size = new System.Drawing.Size(216, 22);
            this.textBoxUplNick.TabIndex = 4;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(180, 133);
            this.textBoxSubject.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(215, 22);
            this.textBoxSubject.TabIndex = 5;
            // 
            // labelEarly
            // 
            this.labelEarly.AutoSize = true;
            this.labelEarly.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.labelEarly.Location = new System.Drawing.Point(41, 217);
            this.labelEarly.Name = "labelEarly";
            this.labelEarly.Size = new System.Drawing.Size(183, 20);
            this.labelEarly.TabIndex = 6;
            this.labelEarly.Text = "Fecha de subida inicial:";
            // 
            // labelLate
            // 
            this.labelLate.AutoSize = true;
            this.labelLate.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.labelLate.Location = new System.Drawing.Point(41, 297);
            this.labelLate.Name = "labelLate";
            this.labelLate.Size = new System.Drawing.Size(173, 20);
            this.labelLate.TabIndex = 7;
            this.labelLate.Text = "Fecha de subida final:";
            // 
            // dateTimePickerEarly
            // 
            this.dateTimePickerEarly.Location = new System.Drawing.Point(44, 247);
            this.dateTimePickerEarly.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dateTimePickerEarly.Name = "dateTimePickerEarly";
            this.dateTimePickerEarly.Size = new System.Drawing.Size(332, 22);
            this.dateTimePickerEarly.TabIndex = 8;
            // 
            // dateTimePickerLate
            // 
            this.dateTimePickerLate.Location = new System.Drawing.Point(44, 326);
            this.dateTimePickerLate.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dateTimePickerLate.Name = "dateTimePickerLate";
            this.dateTimePickerLate.Size = new System.Drawing.Size(332, 22);
            this.dateTimePickerLate.TabIndex = 9;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.Location = new System.Drawing.Point(300, 395);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 35);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.GoBackButton.Location = new System.Drawing.Point(47, 395);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(75, 35);
            this.GoBackButton.TabIndex = 13;
            this.GoBackButton.Text = "Atrás";
            this.GoBackButton.UseVisualStyleBackColor = true;
            // 
            // GridContents
            // 
            this.GridContents.AutoGenerateColumns = false;
            this.GridContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridContents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.isPublicDataGridViewCheckBoxColumn,
            this.uploadDateDataGridViewTextBoxColumn,
            this.subjectsDataGridViewTextBoxColumn,
            this.LastAccess});
            this.GridContents.DataSource = this.contentBindingSource;
            this.GridContents.Location = new System.Drawing.Point(485, 47);
            this.GridContents.Margin = new System.Windows.Forms.Padding(4);
            this.GridContents.Name = "GridContents";
            this.GridContents.RowHeadersWidth = 51;
            this.GridContents.Size = new System.Drawing.Size(931, 383);
            this.GridContents.TabIndex = 14;
            // 
            // contentBindingSource
            // 
            this.contentBindingSource.DataSource = typeof(UPVTube.Entities.Content);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "Owner";
            this.ownerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            this.ownerDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // isPublicDataGridViewCheckBoxColumn
            // 
            this.isPublicDataGridViewCheckBoxColumn.DataPropertyName = "IsPublic";
            this.isPublicDataGridViewCheckBoxColumn.HeaderText = "IsPublic";
            this.isPublicDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isPublicDataGridViewCheckBoxColumn.Name = "isPublicDataGridViewCheckBoxColumn";
            this.isPublicDataGridViewCheckBoxColumn.Width = 125;
            // 
            // uploadDateDataGridViewTextBoxColumn
            // 
            this.uploadDateDataGridViewTextBoxColumn.DataPropertyName = "UploadDate";
            this.uploadDateDataGridViewTextBoxColumn.HeaderText = "UploadDate";
            this.uploadDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uploadDateDataGridViewTextBoxColumn.Name = "uploadDateDataGridViewTextBoxColumn";
            this.uploadDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectsDataGridViewTextBoxColumn
            // 
            this.subjectsDataGridViewTextBoxColumn.DataPropertyName = "Subjects";
            this.subjectsDataGridViewTextBoxColumn.HeaderText = "Subjects";
            this.subjectsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectsDataGridViewTextBoxColumn.Name = "subjectsDataGridViewTextBoxColumn";
            this.subjectsDataGridViewTextBoxColumn.Width = 125;
            // 
            // LastAccess
            // 
            this.LastAccess.HeaderText = "LastAccess";
            this.LastAccess.MinimumWidth = 6;
            this.LastAccess.Name = "LastAccess";
            this.LastAccess.Width = 125;
            // 
            // Searcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1465, 449);
            this.Controls.Add(this.GridContents);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dateTimePickerLate);
            this.Controls.Add(this.dateTimePickerEarly);
            this.Controls.Add(this.labelLate);
            this.Controls.Add(this.labelEarly);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxUplNick);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelUplNick);
            this.Controls.Add(this.labelTitle);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "Searcher";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Searcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridContents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUplNick;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxUplNick;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label labelEarly;
        private System.Windows.Forms.Label labelLate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEarly;
        private System.Windows.Forms.DateTimePicker dateTimePickerLate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.BindingSource contentBindingSource;
        private System.Windows.Forms.DataGridView GridContents;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPublicDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastAccess;
    }
}