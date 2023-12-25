namespace DB_Kursovaya
{
    partial class Form2
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
            this.dataSet1 = new DB_Kursovaya.DataSet1();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new DB_Kursovaya.DataSet1TableAdapters.ClientTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.strahovieDataSet = new DB_Kursovaya.StrahovieDataSet();
            this.strahovieDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iskTableAdapter = new DB_Kursovaya.StrahovieDataSetTableAdapters.IskTableAdapter();
            this.iskIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isknumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iskdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iskSummDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iskStatuseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strahovieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strahovieDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dataSet1;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iskIDDataGridViewTextBoxColumn,
            this.isknumberDataGridViewTextBoxColumn,
            this.iskdateDataGridViewTextBoxColumn,
            this.iskSummDataGridViewTextBoxColumn,
            this.iskStatuseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iskBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // strahovieDataSet
            // 
            this.strahovieDataSet.DataSetName = "StrahovieDataSet";
            this.strahovieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // strahovieDataSetBindingSource
            // 
            this.strahovieDataSetBindingSource.DataSource = this.strahovieDataSet;
            this.strahovieDataSetBindingSource.Position = 0;
            // 
            // iskBindingSource
            // 
            this.iskBindingSource.DataMember = "Isk";
            this.iskBindingSource.DataSource = this.strahovieDataSetBindingSource;
            // 
            // iskTableAdapter
            // 
            this.iskTableAdapter.ClearBeforeFill = true;
            // 
            // iskIDDataGridViewTextBoxColumn
            // 
            this.iskIDDataGridViewTextBoxColumn.DataPropertyName = "Isk_ID";
            this.iskIDDataGridViewTextBoxColumn.HeaderText = "Isk_ID";
            this.iskIDDataGridViewTextBoxColumn.Name = "iskIDDataGridViewTextBoxColumn";
            // 
            // isknumberDataGridViewTextBoxColumn
            // 
            this.isknumberDataGridViewTextBoxColumn.DataPropertyName = "Isk_number";
            this.isknumberDataGridViewTextBoxColumn.HeaderText = "Isk_number";
            this.isknumberDataGridViewTextBoxColumn.Name = "isknumberDataGridViewTextBoxColumn";
            // 
            // iskdateDataGridViewTextBoxColumn
            // 
            this.iskdateDataGridViewTextBoxColumn.DataPropertyName = "Isk_date";
            this.iskdateDataGridViewTextBoxColumn.HeaderText = "Isk_date";
            this.iskdateDataGridViewTextBoxColumn.Name = "iskdateDataGridViewTextBoxColumn";
            // 
            // iskSummDataGridViewTextBoxColumn
            // 
            this.iskSummDataGridViewTextBoxColumn.DataPropertyName = "Isk_Summ";
            this.iskSummDataGridViewTextBoxColumn.HeaderText = "Isk_Summ";
            this.iskSummDataGridViewTextBoxColumn.Name = "iskSummDataGridViewTextBoxColumn";
            // 
            // iskStatuseDataGridViewTextBoxColumn
            // 
            this.iskStatuseDataGridViewTextBoxColumn.DataPropertyName = "Isk_Statuse";
            this.iskStatuseDataGridViewTextBoxColumn.HeaderText = "Isk_Statuse";
            this.iskStatuseDataGridViewTextBoxColumn.Name = "iskStatuseDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(29, 221);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(29, 247);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "номер иска";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "дата иска";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "сумма иска";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "статус иска";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 195);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strahovieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strahovieDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource strahovieDataSetBindingSource;
        private StrahovieDataSet strahovieDataSet;
        private System.Windows.Forms.BindingSource iskBindingSource;
        private StrahovieDataSetTableAdapters.IskTableAdapter iskTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iskIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isknumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iskdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iskSummDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iskStatuseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}