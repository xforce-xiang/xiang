namespace xml_练习
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtEnName = new System.Windows.Forms.TextBox();
            this.txtCnName = new System.Windows.Forms.TextBox();
            this.gpSex = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.gpSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "类别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "学号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "中文名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "英文名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "性别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "电话：";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(63, 241);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(193, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(326, 241);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 7;
            this.btnEnd.Text = "结束";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "本科",
            "专科"});
            this.cmbType.Location = new System.Drawing.Point(129, 64);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(100, 20);
            this.cmbType.TabIndex = 8;
            this.cmbType.Text = "本科";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(340, 72);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 21);
            this.txtNo.TabIndex = 9;
            // 
            // txtEnName
            // 
            this.txtEnName.Location = new System.Drawing.Point(340, 110);
            this.txtEnName.Name = "txtEnName";
            this.txtEnName.Size = new System.Drawing.Size(100, 21);
            this.txtEnName.TabIndex = 9;
            // 
            // txtCnName
            // 
            this.txtCnName.Location = new System.Drawing.Point(129, 116);
            this.txtCnName.Name = "txtCnName";
            this.txtCnName.Size = new System.Drawing.Size(100, 21);
            this.txtCnName.TabIndex = 9;
            // 
            // gpSex
            // 
            this.gpSex.Controls.Add(this.rdoFemale);
            this.gpSex.Controls.Add(this.rdoMale);
            this.gpSex.Location = new System.Drawing.Point(111, 152);
            this.gpSex.Name = "gpSex";
            this.gpSex.Size = new System.Drawing.Size(118, 38);
            this.gpSex.TabIndex = 10;
            this.gpSex.TabStop = false;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(68, 16);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(35, 16);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(18, 16);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(35, 16);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(340, 178);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 21);
            this.txtTel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 330);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.gpSex);
            this.Controls.Add(this.txtCnName);
            this.Controls.Add(this.txtEnName);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpSex.ResumeLayout(false);
            this.gpSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtEnName;
        private System.Windows.Forms.TextBox txtCnName;
        private System.Windows.Forms.GroupBox gpSex;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.TextBox txtTel;
    }
}

