namespace Kontakty2
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.biblioteka = new Kontakty2.biblioteka();
            this.autorzyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorzyTableAdapter = new Kontakty2.bibliotekaTableAdapters.AutorzyTableAdapter();
            this.iDAutoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonZapisz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioteka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorzyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAutoraDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.autorzyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // biblioteka
            // 
            this.biblioteka.DataSetName = "biblioteka";
            this.biblioteka.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autorzyBindingSource
            // 
            this.autorzyBindingSource.DataMember = "Autorzy";
            this.autorzyBindingSource.DataSource = this.biblioteka;
            // 
            // autorzyTableAdapter
            // 
            this.autorzyTableAdapter.ClearBeforeFill = true;
            // 
            // iDAutoraDataGridViewTextBoxColumn
            // 
            this.iDAutoraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDAutoraDataGridViewTextBoxColumn.DataPropertyName = "IDAutora";
            this.iDAutoraDataGridViewTextBoxColumn.HeaderText = "IDAutora";
            this.iDAutoraDataGridViewTextBoxColumn.Name = "iDAutoraDataGridViewTextBoxColumn";
            this.iDAutoraDataGridViewTextBoxColumn.ToolTipText = "Tu wpisujemy podpowiedzi";
            this.iDAutoraDataGridViewTextBoxColumn.Width = 45;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imię";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonZapisz.Location = new System.Drawing.Point(545, 0);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(48, 288);
            this.buttonZapisz.TabIndex = 1;
            this.buttonZapisz.Text = "&Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(593, 288);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioteka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorzyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private biblioteka biblioteka;
        private System.Windows.Forms.BindingSource autorzyBindingSource;
        private bibliotekaTableAdapters.AutorzyTableAdapter autorzyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAutoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonZapisz;

    }
}

