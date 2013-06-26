namespace batchSql
{
    partial class batchSql
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
            this.serverUrl_eidt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.database_edit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uid_edit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pwd_edit = new System.Windows.Forms.TextBox();
            this.testConnect = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.fileSelection = new System.Windows.Forms.Button();
            this.execSql = new System.Windows.Forms.Button();
            this.fileUrl_show = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.result_ok = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.result_faild = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器地址：";
            // 
            // serverUrl_eidt
            // 
            this.serverUrl_eidt.Location = new System.Drawing.Point(96, 16);
            this.serverUrl_eidt.Name = "serverUrl_eidt";
            this.serverUrl_eidt.Size = new System.Drawing.Size(176, 21);
            this.serverUrl_eidt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "数据库名称:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // database_edit
            // 
            this.database_edit.Location = new System.Drawing.Point(96, 65);
            this.database_edit.Name = "database_edit";
            this.database_edit.Size = new System.Drawing.Size(176, 21);
            this.database_edit.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "用户名:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uid_edit
            // 
            this.uid_edit.Location = new System.Drawing.Point(96, 106);
            this.uid_edit.Name = "uid_edit";
            this.uid_edit.Size = new System.Drawing.Size(176, 21);
            this.uid_edit.TabIndex = 5;
            this.uid_edit.Text = "sa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "密码:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pwd_edit
            // 
            this.pwd_edit.Location = new System.Drawing.Point(96, 151);
            this.pwd_edit.Name = "pwd_edit";
            this.pwd_edit.Size = new System.Drawing.Size(176, 21);
            this.pwd_edit.TabIndex = 7;
            // 
            // testConnect
            // 
            this.testConnect.Location = new System.Drawing.Point(193, 189);
            this.testConnect.Name = "testConnect";
            this.testConnect.Size = new System.Drawing.Size(79, 25);
            this.testConnect.TabIndex = 8;
            this.testConnect.Text = "测试连接";
            this.testConnect.UseVisualStyleBackColor = true;
            this.testConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 198);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "无密码登录";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // fileSelection
            // 
            this.fileSelection.Location = new System.Drawing.Point(337, 65);
            this.fileSelection.Name = "fileSelection";
            this.fileSelection.Size = new System.Drawing.Size(148, 149);
            this.fileSelection.TabIndex = 10;
            this.fileSelection.Text = "选择文件";
            this.fileSelection.UseVisualStyleBackColor = true;
            this.fileSelection.Click += new System.EventHandler(this.fileSelection_Click);
            // 
            // execSql
            // 
            this.execSql.Location = new System.Drawing.Point(548, 65);
            this.execSql.Name = "execSql";
            this.execSql.Size = new System.Drawing.Size(148, 149);
            this.execSql.TabIndex = 11;
            this.execSql.Text = "执行sql文件";
            this.execSql.UseVisualStyleBackColor = true;
            this.execSql.Click += new System.EventHandler(this.execSql_Click);
            // 
            // fileUrl_show
            // 
            this.fileUrl_show.AutoSize = true;
            this.fileUrl_show.Location = new System.Drawing.Point(335, 19);
            this.fileUrl_show.Name = "fileUrl_show";
            this.fileUrl_show.Size = new System.Drawing.Size(0, 12);
            this.fileUrl_show.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 238);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 246);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.result_ok);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 221);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "执行成功";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // result_ok
            // 
            this.result_ok.Location = new System.Drawing.Point(7, 7);
            this.result_ok.MaximumSize = new System.Drawing.Size(767, 210);
            this.result_ok.Multiline = true;
            this.result_ok.Name = "result_ok";
            this.result_ok.Size = new System.Drawing.Size(767, 210);
            this.result_ok.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.result_faild);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 221);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "执行失败";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // result_faild
            // 
            this.result_faild.Location = new System.Drawing.Point(4, 5);
            this.result_faild.MaximumSize = new System.Drawing.Size(767, 210);
            this.result_faild.Multiline = true;
            this.result_faild.Name = "result_faild";
            this.result_faild.Size = new System.Drawing.Size(767, 210);
            this.result_faild.TabIndex = 1;
            // 
            // batchSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 496);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.fileUrl_show);
            this.Controls.Add(this.execSql);
            this.Controls.Add(this.fileSelection);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.testConnect);
            this.Controls.Add(this.pwd_edit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uid_edit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.database_edit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverUrl_eidt);
            this.Controls.Add(this.label1);
            this.Name = "batchSql";
            this.Text = "批量执行sql文件";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverUrl_eidt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox database_edit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uid_edit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pwd_edit;
        private System.Windows.Forms.Button testConnect;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button fileSelection;
        private System.Windows.Forms.Button execSql;
        private System.Windows.Forms.Label fileUrl_show;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox result_ok;
        private System.Windows.Forms.TextBox result_faild;
    }
}

