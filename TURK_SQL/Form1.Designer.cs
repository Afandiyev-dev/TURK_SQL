namespace TURK_SQL
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_bksq = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ksq4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ksq3 = new System.Windows.Forms.TextBox();
            this.textBox_ksq2 = new System.Windows.Forms.TextBox();
            this.textBox_ksq1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KSQ1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KSQ2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KSQ3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KSQ4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BKSQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new TURK_SQL.TestDataSet();
            this.schoolBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet3 = new TURK_SQL.TestDataSet3();
            this.schoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet1 = new TURK_SQL.TestDataSet1();
            this.schoolTableAdapter = new TURK_SQL.TestDataSet1TableAdapters.SchoolTableAdapter();
            this.schoolTableAdapter1 = new TURK_SQL.TestDataSet3TableAdapters.SchoolTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.schoolBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolTableAdapter2 = new TURK_SQL.TestDataSetTableAdapters.SchoolTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button_reset);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox_bksq);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_ksq4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_ksq3);
            this.groupBox1.Controls.Add(this.textBox_ksq2);
            this.groupBox1.Controls.Add(this.textBox_ksq1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_delete);
            this.groupBox1.Controls.Add(this.button_update);
            this.groupBox1.Controls.Add(this.button_insert);
            this.groupBox1.Controls.Add(this.textBox_surname);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(291, 162);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(44, 23);
            this.button_reset.TabIndex = 18;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.Button_reset_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "BKSQ";
            // 
            // textBox_bksq
            // 
            this.textBox_bksq.Location = new System.Drawing.Point(290, 130);
            this.textBox_bksq.Name = "textBox_bksq";
            this.textBox_bksq.Size = new System.Drawing.Size(45, 20);
            this.textBox_bksq.TabIndex = 16;
            this.textBox_bksq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_bksq_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "KSQ4";
            // 
            // textBox_ksq4
            // 
            this.textBox_ksq4.Location = new System.Drawing.Point(290, 104);
            this.textBox_ksq4.Name = "textBox_ksq4";
            this.textBox_ksq4.Size = new System.Drawing.Size(45, 20);
            this.textBox_ksq4.TabIndex = 14;
            this.textBox_ksq4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_ksq4_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "KSQ3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "KSQ2";
            // 
            // textBox_ksq3
            // 
            this.textBox_ksq3.Location = new System.Drawing.Point(290, 82);
            this.textBox_ksq3.Name = "textBox_ksq3";
            this.textBox_ksq3.Size = new System.Drawing.Size(45, 20);
            this.textBox_ksq3.TabIndex = 11;
            this.textBox_ksq3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_ksq3_KeyPress);
            // 
            // textBox_ksq2
            // 
            this.textBox_ksq2.Location = new System.Drawing.Point(290, 59);
            this.textBox_ksq2.Name = "textBox_ksq2";
            this.textBox_ksq2.Size = new System.Drawing.Size(45, 20);
            this.textBox_ksq2.TabIndex = 10;
            this.textBox_ksq2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_ksq2_KeyPress);
            // 
            // textBox_ksq1
            // 
            this.textBox_ksq1.Location = new System.Drawing.Point(290, 36);
            this.textBox_ksq1.Name = "textBox_ksq1";
            this.textBox_ksq1.Size = new System.Drawing.Size(45, 20);
            this.textBox_ksq1.TabIndex = 9;
            this.textBox_ksq1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_ksq1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "KSQ1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(28, 158);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 27);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(28, 129);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 27);
            this.button_update.TabIndex = 4;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.Button_update_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(28, 100);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(75, 27);
            this.button_insert.TabIndex = 3;
            this.button_insert.Text = "Insert";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.Button_insert_Click);
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(18, 64);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(100, 20);
            this.textBox_surname.TabIndex = 1;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(18, 38);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.estimateDataGridViewTextBoxColumn,
            this.BAL,
            this.KSQ1,
            this.KSQ2,
            this.KSQ3,
            this.KSQ4,
            this.BKSQ});
            this.dataGridView1.DataSource = this.schoolBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(838, 265);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 40F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estimateDataGridViewTextBoxColumn
            // 
            this.estimateDataGridViewTextBoxColumn.DataPropertyName = "Estimate";
            this.estimateDataGridViewTextBoxColumn.HeaderText = "Estimate";
            this.estimateDataGridViewTextBoxColumn.Name = "estimateDataGridViewTextBoxColumn";
            this.estimateDataGridViewTextBoxColumn.ReadOnly = true;
            this.estimateDataGridViewTextBoxColumn.Width = 60;
            // 
            // BAL
            // 
            this.BAL.DataPropertyName = "BAL";
            this.BAL.HeaderText = "BAL";
            this.BAL.Name = "BAL";
            this.BAL.ReadOnly = true;
            this.BAL.Width = 50;
            // 
            // KSQ1
            // 
            this.KSQ1.DataPropertyName = "KSQ1";
            this.KSQ1.HeaderText = "KSQ1";
            this.KSQ1.Name = "KSQ1";
            this.KSQ1.ReadOnly = true;
            this.KSQ1.Width = 40;
            // 
            // KSQ2
            // 
            this.KSQ2.DataPropertyName = "KSQ2";
            this.KSQ2.HeaderText = "KSQ2";
            this.KSQ2.Name = "KSQ2";
            this.KSQ2.ReadOnly = true;
            this.KSQ2.Width = 40;
            // 
            // KSQ3
            // 
            this.KSQ3.DataPropertyName = "KSQ3";
            this.KSQ3.HeaderText = "KSQ3";
            this.KSQ3.Name = "KSQ3";
            this.KSQ3.ReadOnly = true;
            this.KSQ3.Width = 40;
            // 
            // KSQ4
            // 
            this.KSQ4.DataPropertyName = "KSQ4";
            this.KSQ4.HeaderText = "KSQ4";
            this.KSQ4.Name = "KSQ4";
            this.KSQ4.ReadOnly = true;
            this.KSQ4.Width = 40;
            // 
            // BKSQ
            // 
            this.BKSQ.DataPropertyName = "BKSQ";
            this.BKSQ.HeaderText = "BKSQ";
            this.BKSQ.Name = "BKSQ";
            this.BKSQ.ReadOnly = true;
            this.BKSQ.Width = 40;
            // 
            // schoolBindingSource3
            // 
            this.schoolBindingSource3.DataMember = "School";
            this.schoolBindingSource3.DataSource = this.testDataSetBindingSource;
            // 
            // testDataSetBindingSource
            // 
            this.testDataSetBindingSource.DataSource = this.testDataSet;
            this.testDataSetBindingSource.Position = 0;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "TestDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolBindingSource1
            // 
            this.schoolBindingSource1.DataMember = "School";
            this.schoolBindingSource1.DataSource = this.testDataSet3;
            // 
            // testDataSet3
            // 
            this.testDataSet3.DataSetName = "TestDataSet3";
            this.testDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolBindingSource
            // 
            this.schoolBindingSource.DataMember = "School";
            this.schoolBindingSource.DataSource = this.testDataSet1;
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "TestDataSet1";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolTableAdapter
            // 
            this.schoolTableAdapter.ClearBeforeFill = true;
            // 
            // schoolTableAdapter1
            // 
            this.schoolTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TURK_SQL.Properties.Resources.SilverPlushAmericanriverotter_max_1mb;
            this.pictureBox1.Location = new System.Drawing.Point(553, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 289);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // schoolBindingSource2
            // 
            this.schoolBindingSource2.DataMember = "School";
            this.schoolBindingSource2.DataSource = this.testDataSetBindingSource;
            // 
            // schoolTableAdapter2
            // 
            this.schoolTableAdapter2.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 575);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TestDataSet1 testDataSet1;
        private System.Windows.Forms.BindingSource schoolBindingSource;
        private TestDataSet1TableAdapters.SchoolTableAdapter schoolTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ksq4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ksq3;
        private System.Windows.Forms.TextBox textBox_ksq2;
        private System.Windows.Forms.TextBox textBox_ksq1;
        private System.Windows.Forms.Label label4;
        private TestDataSet testDataSet;
        private System.Windows.Forms.BindingSource testDataSetBindingSource;
        private TestDataSet3 testDataSet3;
        private System.Windows.Forms.BindingSource schoolBindingSource1;
        private TestDataSet3TableAdapters.SchoolTableAdapter schoolTableAdapter1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_bksq;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn KSQ1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KSQ2;
        private System.Windows.Forms.DataGridViewTextBoxColumn KSQ3;
        private System.Windows.Forms.DataGridViewTextBoxColumn KSQ4;
        private System.Windows.Forms.DataGridViewTextBoxColumn BKSQ;
        private System.Windows.Forms.BindingSource schoolBindingSource2;
        private TestDataSetTableAdapters.SchoolTableAdapter schoolTableAdapter2;
        private System.Windows.Forms.BindingSource schoolBindingSource3;
    }
}

