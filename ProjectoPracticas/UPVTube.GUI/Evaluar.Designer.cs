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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Título = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Público = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignaturas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Evaluar contenido";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Título,
            this.Nick,
            this.Descripción,
            this.Público,
            this.Asignaturas});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(101, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(677, 239);
            this.dataGridView1.TabIndex = 1;
            // 
            // Título
            // 
            this.Título.DataPropertyName = "ds_titulo";
            this.Título.HeaderText = "Título";
            this.Título.MinimumWidth = 6;
            this.Título.Name = "Título";
            this.Título.Width = 125;
            // 
            // Nick
            // 
            this.Nick.DataPropertyName = "ds_nick";
            this.Nick.HeaderText = "Nick";
            this.Nick.MinimumWidth = 6;
            this.Nick.Name = "Nick";
            this.Nick.Width = 125;
            // 
            // Descripción
            // 
            this.Descripción.DataPropertyName = "ds_descripcion";
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MinimumWidth = 6;
            this.Descripción.Name = "Descripción";
            this.Descripción.Width = 125;
            // 
            // Público
            // 
            this.Público.DataPropertyName = "ds_publico";
            this.Público.HeaderText = "Column1";
            this.Público.MinimumWidth = 6;
            this.Público.Name = "Público";
            this.Público.Width = 125;
            // 
            // Asignaturas
            // 
            this.Asignaturas.DataPropertyName = "ds_asignaturas";
            this.Asignaturas.HeaderText = "Column1";
            this.Asignaturas.MinimumWidth = 6;
            this.Asignaturas.Name = "Asignaturas";
            this.Asignaturas.Width = 125;
            // 
            // Evaluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Evaluar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Título;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nick;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Público;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignaturas;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}