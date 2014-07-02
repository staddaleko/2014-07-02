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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.biblioteka = new Kontakty2.biblioteka();
            this.kategorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorieTableAdapter = new Kontakty2.bibliotekaTableAdapters.KategorieTableAdapter();
            this.fKKsiazkiKategorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ksiazkiTableAdapter = new Kontakty2.bibliotekaTableAdapters.KsiazkiTableAdapter();
            this.iDKsiazkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDKategorii = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.comboBox1.Location = new System.Drawing.Point(45, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(450, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "IDKategorii";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKsiazkiDataGridViewTextBoxColumn,
            this.tytulDataGridViewTextBoxColumn,
            this.IDKategorii});
            this.dataGridView1.DataSource = this.fKKsiazkiKategorieBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(45, 65);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(300, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 300);
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
            this.iDKsiazkiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDKsiazkiDataGridViewTextBoxColumn.DataPropertyName = "IDKsiazki";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.iDKsiazkiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.iDKsiazkiDataGridViewTextBoxColumn.DividerWidth = 10;
            this.iDKsiazkiDataGridViewTextBoxColumn.FillWeight = 50F;
            this.iDKsiazkiDataGridViewTextBoxColumn.HeaderText = "IDKsiążki";
            this.iDKsiazkiDataGridViewTextBoxColumn.Name = "iDKsiazkiDataGridViewTextBoxColumn";
            this.iDKsiazkiDataGridViewTextBoxColumn.Width = 86;
            // 
            // tytulDataGridViewTextBoxColumn
            // 
            this.tytulDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tytulDataGridViewTextBoxColumn.DataPropertyName = "Tytul";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tytulDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.tytulDataGridViewTextBoxColumn.DividerWidth = 10;
            this.tytulDataGridViewTextBoxColumn.HeaderText = "Tytuł";
            this.tytulDataGridViewTextBoxColumn.Name = "tytulDataGridViewTextBoxColumn";
            // 
            // IDKategorii
            // 
            this.IDKategorii.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDKategorii.DataPropertyName = "IDKategorii";
            this.IDKategorii.FillWeight = 50F;
            this.IDKategorii.HeaderText = "IDKategorii";
            this.IDKategorii.Name = "IDKategorii";
            this.IDKategorii.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // KsiazkiWgKategorii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(541, 532);
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
        private System.Windows.Forms.DataGridViewButtonColumn IDKategorii;
    }
}