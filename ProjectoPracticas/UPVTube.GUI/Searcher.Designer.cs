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
            this.labelKeyWords = new System.Windows.Forms.Label();
            this.labelUplNick = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.textBoxKeyWords = new System.Windows.Forms.TextBox();
            this.textBoxUplNick = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.labelEarly = new System.Windows.Forms.Label();
            this.labelLate = new System.Windows.Forms.Label();
            this.dateTimePickerEarly = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLate = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxSearchRes = new System.Windows.Forms.ListBox();
            this.GoBackButton = new System.Windows.Forms.Button();
            
            this.SuspendLayout();
            // 
            // labelKeyWords
            // 
            this.labelKeyWords.AutoSize = true;
            this.labelKeyWords.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.labelKeyWords.Location = new System.Drawing.Point(46, 58);
            this.labelKeyWords.Name = "labelKeyWords";
            this.labelKeyWords.Size = new System.Drawing.Size(139, 24);
            this.labelKeyWords.TabIndex = 0;
            this.labelKeyWords.Text = "Palabras clave:";
            // 
            // labelUplNick
            // 
            this.labelUplNick.AutoSize = true;
            this.labelUplNick.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.labelUplNick.Location = new System.Drawing.Point(46, 118);
            this.labelUplNick.Name = "labelUplNick";
            this.labelUplNick.Size = new System.Drawing.Size(154, 24);
            this.labelUplNick.TabIndex = 1;
            this.labelUplNick.Text = "Nick del creador:";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.labelSubject.Location = new System.Drawing.Point(46, 169);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(78, 24);
            this.labelSubject.TabIndex = 2;
            this.labelSubject.Text = "Subject:";
            // 
            // textBoxKeyWords
            // 
            this.textBoxKeyWords.Location = new System.Drawing.Point(202, 58);
            this.textBoxKeyWords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKeyWords.Name = "textBoxKeyWords";
            this.textBoxKeyWords.Size = new System.Drawing.Size(242, 26);
            this.textBoxKeyWords.TabIndex = 3;
            // 
            // textBoxUplNick
            // 
            this.textBoxUplNick.Location = new System.Drawing.Point(202, 118);
            this.textBoxUplNick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUplNick.Name = "textBoxUplNick";
            this.textBoxUplNick.Size = new System.Drawing.Size(242, 26);
            this.textBoxUplNick.TabIndex = 4;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(203, 166);
            this.textBoxSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(241, 26);
            this.textBoxSubject.TabIndex = 5;
            // 
            // labelEarly
            // 
            this.labelEarly.AutoSize = true;
            this.labelEarly.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.labelEarly.Location = new System.Drawing.Point(46, 271);
            this.labelEarly.Name = "labelEarly";
            this.labelEarly.Size = new System.Drawing.Size(210, 24);
            this.labelEarly.TabIndex = 6;
            this.labelEarly.Text = "Fecha de subida inicial:";
            // 
            // labelLate
            // 
            this.labelLate.AutoSize = true;
            this.labelLate.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.labelLate.Location = new System.Drawing.Point(46, 371);
            this.labelLate.Name = "labelLate";
            this.labelLate.Size = new System.Drawing.Size(198, 24);
            this.labelLate.TabIndex = 7;
            this.labelLate.Text = "Fecha de subida final:";
            // 
            // dateTimePickerEarly
            // 
            this.dateTimePickerEarly.Location = new System.Drawing.Point(50, 309);
            this.dateTimePickerEarly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerEarly.Name = "dateTimePickerEarly";
            this.dateTimePickerEarly.Size = new System.Drawing.Size(373, 26);
            this.dateTimePickerEarly.TabIndex = 8;
            // 
            // dateTimePickerLate
            // 
            this.dateTimePickerLate.Location = new System.Drawing.Point(50, 408);
            this.dateTimePickerLate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerLate.Name = "dateTimePickerLate";
            this.dateTimePickerLate.Size = new System.Drawing.Size(373, 26);
            this.dateTimePickerLate.TabIndex = 9;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.Location = new System.Drawing.Point(338, 494);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(84, 29);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // listBoxSearchRes
            // 
            this.listBoxSearchRes.FormattingEnabled = true;
            this.listBoxSearchRes.ItemHeight = 20;
            this.listBoxSearchRes.Location = new System.Drawing.Point(512, 15);
            this.listBoxSearchRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxSearchRes.Name = "listBoxSearchRes";
            this.listBoxSearchRes.Size = new System.Drawing.Size(476, 524);
            this.listBoxSearchRes.Sorted = true;
            this.listBoxSearchRes.TabIndex = 12;
            this.listBoxSearchRes.SelectedIndexChanged += new System.EventHandler(this.ListBoxSearchRes_SelectedIndexChanged);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold);
            this.GoBackButton.Location = new System.Drawing.Point(53, 494);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(84, 29);
            this.GoBackButton.TabIndex = 13;
            this.GoBackButton.Text = "Atrás";
            this.GoBackButton.UseVisualStyleBackColor = true;
            // 
            
            // Searcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1002, 562);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.listBoxSearchRes);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dateTimePickerLate);
            this.Controls.Add(this.dateTimePickerEarly);
            this.Controls.Add(this.labelLate);
            this.Controls.Add(this.labelEarly);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxUplNick);
            this.Controls.Add(this.textBoxKeyWords);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelUplNick);
            this.Controls.Add(this.labelKeyWords);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Searcher";
            this.Text = "Search";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKeyWords;
        private System.Windows.Forms.Label labelUplNick;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox textBoxKeyWords;
        private System.Windows.Forms.TextBox textBoxUplNick;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label labelEarly;
        private System.Windows.Forms.Label labelLate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEarly;
        private System.Windows.Forms.DateTimePicker dateTimePickerLate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxSearchRes;
        private System.Windows.Forms.Button GoBackButton;
        
    }
}