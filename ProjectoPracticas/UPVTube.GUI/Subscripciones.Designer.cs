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
            this.buttonSuscribed = new System.Windows.Forms.Button();
            this.buttonNonSubscribed = new System.Windows.Forms.Button();
            this.buttonShowContents = new System.Windows.Forms.Button();
            this.GridViewSubscribedTo = new System.Windows.Forms.DataGridView();
            this.GridViewNonSubscribedTo = new System.Windows.Forms.DataGridView();
            this.nonSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSubscribedTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewNonSubscribedTo)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(527, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Miembros no suscritos";
            // 
            // buttonSuscribed
            // 
            this.buttonSuscribed.Location = new System.Drawing.Point(355, 94);
            this.buttonSuscribed.Name = "buttonSuscribed";
            this.buttonSuscribed.Size = new System.Drawing.Size(106, 26);
            this.buttonSuscribed.TabIndex = 4;
            this.buttonSuscribed.Text = "Suscribirse";
            this.buttonSuscribed.UseVisualStyleBackColor = true;
            this.buttonSuscribed.Click += new System.EventHandler(this.buttonSuscribed_Click);
            // 
            // buttonNonSubscribed
            // 
            this.buttonNonSubscribed.Location = new System.Drawing.Point(355, 184);
            this.buttonNonSubscribed.Name = "buttonNonSubscribed";
            this.buttonNonSubscribed.Size = new System.Drawing.Size(106, 29);
            this.buttonNonSubscribed.TabIndex = 5;
            this.buttonNonSubscribed.Text = "Desuscribirse";
            this.buttonNonSubscribed.UseVisualStyleBackColor = true;
            this.buttonNonSubscribed.Click += new System.EventHandler(this.buttonNonSubscribed_Click);
            // 
            // buttonShowContents
            // 
            this.buttonShowContents.Location = new System.Drawing.Point(355, 271);
            this.buttonShowContents.Name = "buttonShowContents";
            this.buttonShowContents.Size = new System.Drawing.Size(106, 28);
            this.buttonShowContents.TabIndex = 6;
            this.buttonShowContents.Text = "Mostrar Contenidos";
            this.buttonShowContents.UseVisualStyleBackColor = true;
            this.buttonShowContents.Click += new System.EventHandler(this.buttonShowContents_Click);
            // 
            // GridViewSubscribedTo
            // 
            this.GridViewSubscribedTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewSubscribedTo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sub});
            this.GridViewSubscribedTo.Location = new System.Drawing.Point(46, 86);
            this.GridViewSubscribedTo.Name = "GridViewSubscribedTo";
            this.GridViewSubscribedTo.Size = new System.Drawing.Size(242, 291);
            this.GridViewSubscribedTo.TabIndex = 7;
            // 
            // GridViewNonSubscribedTo
            // 
            this.GridViewNonSubscribedTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewNonSubscribedTo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nonSub});
            this.GridViewNonSubscribedTo.Location = new System.Drawing.Point(530, 86);
            this.GridViewNonSubscribedTo.Name = "GridViewNonSubscribedTo";
            this.GridViewNonSubscribedTo.Size = new System.Drawing.Size(242, 291);
            this.GridViewNonSubscribedTo.TabIndex = 8;
            // 
            // nonSub
            // 
            this.nonSub.HeaderText = "Miembros no suscritos";
            this.nonSub.Name = "nonSub";
            this.nonSub.Width = 199;
            // 
            // sub
            // 
            this.sub.HeaderText = "Miembros suscritos";
            this.sub.Name = "sub";
            this.sub.Width = 199;
            // 
            // Subscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridViewNonSubscribedTo);
            this.Controls.Add(this.GridViewSubscribedTo);
            this.Controls.Add(this.buttonShowContents);
            this.Controls.Add(this.buttonNonSubscribed);
            this.Controls.Add(this.buttonSuscribed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Subscripciones";
            this.Text = "Subscripciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Subscripciones_FormClosing);
            this.Load += new System.EventHandler(this.Subscripciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSubscribedTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewNonSubscribedTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSuscribed;
        private System.Windows.Forms.Button buttonNonSubscribed;
        private System.Windows.Forms.Button buttonShowContents;
        private System.Windows.Forms.DataGridView GridViewSubscribedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub;
        private System.Windows.Forms.DataGridView GridViewNonSubscribedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nonSub;
    }
}