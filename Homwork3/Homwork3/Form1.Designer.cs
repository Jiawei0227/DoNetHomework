namespace Homwork3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.addCourse = new System.Windows.Forms.Button();
            this.addDetailCourse = new System.Windows.Forms.Button();
            this.myCourse = new System.Windows.Forms.Button();
            this.courseDetail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addCourse
            // 
            this.addCourse.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addCourse.ForeColor = System.Drawing.Color.DarkBlue;
            this.addCourse.Location = new System.Drawing.Point(44, 45);
            this.addCourse.Name = "addCourse";
            this.addCourse.Size = new System.Drawing.Size(121, 49);
            this.addCourse.TabIndex = 0;
            this.addCourse.Text = "添加上课信息";
            this.addCourse.UseVisualStyleBackColor = true;
            this.addCourse.Click += new System.EventHandler(this.addCourse_Click);
            // 
            // addDetailCourse
            // 
            this.addDetailCourse.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addDetailCourse.ForeColor = System.Drawing.Color.DarkBlue;
            this.addDetailCourse.Location = new System.Drawing.Point(44, 152);
            this.addDetailCourse.Name = "addDetailCourse";
            this.addDetailCourse.Size = new System.Drawing.Size(121, 53);
            this.addDetailCourse.TabIndex = 1;
            this.addDetailCourse.Text = "添加课程信息";
            this.addDetailCourse.UseVisualStyleBackColor = true;
            this.addDetailCourse.Click += new System.EventHandler(this.addDetailCourse_Click);
            // 
            // myCourse
            // 
            this.myCourse.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myCourse.ForeColor = System.Drawing.Color.DarkBlue;
            this.myCourse.Location = new System.Drawing.Point(44, 100);
            this.myCourse.Name = "myCourse";
            this.myCourse.Size = new System.Drawing.Size(121, 46);
            this.myCourse.TabIndex = 2;
            this.myCourse.Text = "我的课程表";
            this.myCourse.UseVisualStyleBackColor = true;
            // 
            // courseDetail
            // 
            this.courseDetail.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.courseDetail.ForeColor = System.Drawing.Color.DarkBlue;
            this.courseDetail.Location = new System.Drawing.Point(44, 211);
            this.courseDetail.Name = "courseDetail";
            this.courseDetail.Size = new System.Drawing.Size(121, 55);
            this.courseDetail.TabIndex = 3;
            this.courseDetail.Text = "课程详细信息";
            this.courseDetail.UseVisualStyleBackColor = true;
            this.courseDetail.Click += new System.EventHandler(this.courseDetail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(182, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "欢迎使用超级课程表系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(273, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "作者：王家玮";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(282, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "141250136";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 296);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseDetail);
            this.Controls.Add(this.myCourse);
            this.Controls.Add(this.addDetailCourse);
            this.Controls.Add(this.addCourse);
            this.Name = "Form1";
            this.Text = "超级课程表管理系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addCourse;
        private System.Windows.Forms.Button addDetailCourse;
        private System.Windows.Forms.Button myCourse;
        private System.Windows.Forms.Button courseDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

