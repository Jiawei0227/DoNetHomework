namespace Homwork3
{
    partial class Form5
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
            this.superCourseDataSet = new Homwork3.SuperCourseDataSet();
            this.superCourseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.superCourseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.superCourseDataSet1 = new Homwork3.SuperCourseDataSet1();
            this.lessonplanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonplanTableAdapter = new Homwork3.SuperCourseDataSet1TableAdapters.lessonplanTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xingqiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessontimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.superCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superCourseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superCourseDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superCourseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonplanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // superCourseDataSet
            // 
            this.superCourseDataSet.DataSetName = "SuperCourseDataSet";
            this.superCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // superCourseDataSetBindingSource
            // 
            this.superCourseDataSetBindingSource.DataSource = this.superCourseDataSet;
            this.superCourseDataSetBindingSource.Position = 0;
            // 
            // superCourseDataSetBindingSource1
            // 
            this.superCourseDataSetBindingSource1.DataSource = this.superCourseDataSet;
            this.superCourseDataSetBindingSource1.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.xingqiDataGridViewTextBoxColumn,
            this.lessontimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lessonplanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(445, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // superCourseDataSet1
            // 
            this.superCourseDataSet1.DataSetName = "SuperCourseDataSet1";
            this.superCourseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lessonplanBindingSource
            // 
            this.lessonplanBindingSource.DataMember = "lessonplan";
            this.lessonplanBindingSource.DataSource = this.superCourseDataSet1;
            // 
            // lessonplanTableAdapter
            // 
            this.lessonplanTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "以下为我的课程：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(17, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "添加课表";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(176, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "删除课程";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(339, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "返回";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "课程名";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 140;
            // 
            // xingqiDataGridViewTextBoxColumn
            // 
            this.xingqiDataGridViewTextBoxColumn.DataPropertyName = "xingqi";
            this.xingqiDataGridViewTextBoxColumn.HeaderText = "上课日期";
            this.xingqiDataGridViewTextBoxColumn.Name = "xingqiDataGridViewTextBoxColumn";
            this.xingqiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lessontimeDataGridViewTextBoxColumn
            // 
            this.lessontimeDataGridViewTextBoxColumn.DataPropertyName = "lessontime";
            this.lessontimeDataGridViewTextBoxColumn.HeaderText = "上课时间";
            this.lessontimeDataGridViewTextBoxColumn.Name = "lessontimeDataGridViewTextBoxColumn";
            this.lessontimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lessontimeDataGridViewTextBoxColumn.Width = 160;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 357);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.superCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superCourseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superCourseDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superCourseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonplanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperCourseDataSet superCourseDataSet;
        private System.Windows.Forms.BindingSource superCourseDataSetBindingSource;
        private System.Windows.Forms.BindingSource superCourseDataSetBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SuperCourseDataSet1 superCourseDataSet1;
        private System.Windows.Forms.BindingSource lessonplanBindingSource;
        private SuperCourseDataSet1TableAdapters.lessonplanTableAdapter lessonplanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xingqiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessontimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}