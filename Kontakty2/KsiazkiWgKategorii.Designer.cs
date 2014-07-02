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
            this.kategorieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.biblioteka = new Kontakty2.biblioteka();
            this.ksiazkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ksiazkiTableAdapter = new Kontakty2.bibliotekaTableAdapters.KsiazkiTableAdapter();
            this.kategorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorieTableAdapter = new Kontakty2.bibliotekaTableAdapters.KategorieTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fKKsiazkiKategorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKKsiazkiKategorieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDKsiazkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKategoriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kategorieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioteka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKKsiazkiKategorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKKsiazkiKategorieBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.kategorieBindingSource1;
            this.comboBox1.DisplayMember = "Kategoria";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(512, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "IDKategorii";
            // 
            // kategorieBindingSource1
            // 
            this.kategorieBindingSource1.DataMember = "Kategorie";
            this.kategorieBindingSource1.DataSource = this.biblioteka;
            // 
            // biblioteka
            // 
            this.biblioteka.DataSetName = "biblioteka";
            this.biblioteka.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ksiazkiBindingSource
            // 
            this.ksiazkiBindingSource.DataMember = "Ksiazki";
            this.ksiazkiBindingSource.DataSource = this.biblioteka;
            // 
            // ksiazkiTableAdapter
            // 
            this.ksiazkiTableAdapter.ClearBeforeFill = true;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKsiazkiDataGridViewTextBoxColumn,
            this.tytulDataGridViewTextBoxColumn,
            this.iDKategoriiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKKsiazkiKategorieBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(42, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(512, 233);
            this.dataGridView1.TabIndex = 1;
            // 
            // fKKsiazkiKategorieBindingSource
            // 
            this.fKKsiazkiKategorieBindingSource.DataMember = "FK_Ksiazki_Kategorie";
            this.fKKsiazkiKategorieBindingSource.DataSource = this.kategorieBindingSource1;
            // 
            // fKKsiazkiKategorieBindingSource1
            // 
            this.fKKsiazkiKategorieBindingSource1.DataMember = "FK_Ksiazki_Kategorie";
            this.fKKsiazkiKategorieBindingSource1.DataSource = this.kategorieBindingSource1;
            // 
            // iDKsiazkiDataGridViewTextBoxColumn
            // 
            this.iDKsiazkiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDKsiazkiDataGridViewTextBoxColumn.DataPropertyName = "IDKsiazki";
            this.iDKsiazkiDataGridViewTextBoxColumn.FillWeight = 40F;
            this.iDKsiazkiDataGridViewTextBoxColumn.HeaderText = "IDKsiazki";
            this.iDKsiazkiDataGridViewTextBoxColumn.Name = "iDKsiazkiDataGridViewTextBoxColumn";
            this.iDKsiazkiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tytulDataGridViewTextBoxColumn
            // 
            this.tytulDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tytulDataGridViewTextBoxColumn.DataPropertyName = "Tytul";
            this.tytulDataGridViewTextBoxColumn.HeaderText = "Tytul";
            this.tytulDataGridViewTextBoxColumn.Name = "tytulDataGridViewTextBoxColumn";
            // 
            // iDKategoriiDataGridViewTextBoxColumn
            // 
            this.iDKategoriiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            ((System.ComponentModel.ISupportInitialize)(this.kategorieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioteka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKKsiazkiKategorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKKsiazkiKategorieBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private biblioteka biblioteka;
        private System.Windows.Forms.BindingSource ksiazkiBindingSource;
        private bibliotekaTableAdapters.KsiazkiTableAdapter ksiazkiTableAdapter;
        private System.Windows.Forms.BindingSource kategorieBindingSource;
        private bibliotekaTableAdapters.KategorieTableAdapter kategorieTableAdapter;
        private System.Windows.Forms.BindingSource kategorieBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKsiazkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKategoriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKKsiazkiKategorieBindingSource1;
        private System.Windows.Forms.BindingSource fKKsiazkiKategorieBindingSource;
    }
}