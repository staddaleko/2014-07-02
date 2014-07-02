namespace Kontakty2
{
    partial class KsiazkiWgKategorii
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.biblioteka = new Kontakty2.biblioteka();
            this.kategorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorieTableAdapter = new Kontakty2.bibliotekaTableAdapters.KategorieTableAdapter();
            this.fKKsiazkiKategorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ksiazkiTableAdapter = new Kontakty2.bibliotekaTableAdapters.KsiazkiTableAdapter();
            this.iDKsiazkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKategoriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioteka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKKsiazkiKategorieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.kategorieBindingSource;
            this.comboBox1.DisplayMember = "Kategoria";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(512, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "IDKategorii";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKsiazkiDataGridViewTextBoxColumn,
            this.tytulDataGridViewTextBoxColumn,
            this.iDKategoriiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKKsiazkiKategorieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(512, 233);
            this.dataGridView1.TabIndex = 1;
            // 
            // biblioteka
            // 
            this.biblioteka.DataSetName = "biblioteka";
            this.biblioteka.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorieBindingSource
            // 
            this.kategorieBindingSource.DataMember = "Kategorie";
            this.kategorieBindingSource.DataSource = this.biblioteka;
            // 
            // kategorieTableAdapter
            // 
            this.kategorieTableAdapter.ClearBeforeFill = true;
            // 
            // fKKsiazkiKategorieBindingSource
            // 
            this.fKKsiazkiKategorieBindingSource.DataMember = "FK_Ksiazki_Kategorie";
            this.fKKsiazkiKategorieBindingSource.DataSource = this.kategorieBindingSource;
            // 
            // ksiazkiTableAdapter
            // 
            this.ksiazkiTableAdapter.ClearBeforeFill = true;
            // 
            // iDKsiazkiDataGridViewTextBoxColumn
            // 
            this.iDKsiazkiDataGridViewTextBoxColumn.DataPropertyName = "IDKsiazki";
            this.iDKsiazkiDataGridViewTextBoxColumn.HeaderText = "IDKsiazki";
            this.iDKsiazkiDataGridViewTextBoxColumn.Name = "iDKsiazkiDataGridViewTextBoxColumn";
            // 
            // tytulDataGridViewTextBoxColumn
            // 
            this.tytulDataGridViewTextBoxColumn.DataPropertyName = "Tytul";
            this.tytulDataGridViewTextBoxColumn.HeaderText = "Tytul";
            this.tytulDataGridViewTextBoxColumn.Name = "tytulDataGridViewTextBoxColumn";
            // 
            // iDKategoriiDataGridViewTextBoxColumn
            // 
            this.iDKategoriiDataGridViewTextBoxColumn.DataPropertyName = "IDKategorii";
            this.iDKategoriiDataGridViewTextBoxColumn.HeaderText = "IDKategorii";
            this.iDKategoriiDataGridViewTextBoxColumn.Name = "iDKategoriiDataGridViewTextBoxColumn";
            // 
            // KsiazkiWgKategorii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(596, 393);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "KsiazkiWgKategorii";
            this.Text = "KsiazkiWgKategorii";
            this.Load += new System.EventHandler(this.KsiazkiWgKategorii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioteka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKKsiazkiKategorieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private biblioteka biblioteka;
        private System.Windows.Forms.BindingSource kategorieBindingSource;
        private bibliotekaTableAdapters.KategorieTableAdapter kategorieTableAdapter;
        private System.Windows.Forms.BindingSource fKKsiazkiKategorieBindingSource;
        private bibliotekaTableAdapters.KsiazkiTableAdapter ksiazkiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKsiazkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKategoriiDataGridViewTextBoxColumn;
    }
}