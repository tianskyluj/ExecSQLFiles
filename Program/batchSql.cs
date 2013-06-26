using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Collections;

namespace batchSql
{
    public partial class batchSql : Form
    {
        public batchSql()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.uid_edit.Enabled = false;
                this.pwd_edit.Enabled = false;
            }
            else
            {
                this.uid_edit.Enabled = true;
                this.pwd_edit.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.serverUrl_eidt.Text.Trim() == "")
            {
                MessageBox.Show("请输入服务器地址");
                return;
            }
            if (this.database_edit.Text.Trim() == "")
            {
                MessageBox.Show("请输入数据库名称");
                return;
            }
               

            bool IsCanConnectioned = false;

            SqlConnection objConnection=new SqlConnection(this.getConnectString());


            try
            {
                //Open DataBase
                //打开数据库
                objConnection.Open();
                IsCanConnectioned = true;
            }
            catch
            {
                //Can not Open DataBase
                //打开不成功 则连接不成功
                IsCanConnectioned = false;
            }
            finally
            {
                //Close DataBase
                //关闭数据库连接
                objConnection.Close();
            }
            objConnection.Close();
            if (IsCanConnectioned)
                MessageBox.Show("链接成功");
            else
                MessageBox.Show("链接失败，请检查输入字符串是否正确");
        }

        protected string getConnectString()
        {
            string strConnection = string.Empty;
            if (this.checkBox1.Checked)
            {
                strConnection = "integrated security=true;";
                strConnection += "initial catalog=" + this.database_edit.Text.Trim() + ";Server=" + this.serverUrl_eidt.Text.Trim() + ";";
                strConnection += "Connect Timeout=30";
            }
            else
            {
                strConnection = "uid="+this.uid_edit.Text.Trim()+";password="+this.pwd_edit.Text.Trim()+";";
                strConnection += "initial catalog="+this.database_edit.Text.Trim()+";Server="+this.serverUrl_eidt.Text.Trim()+";";
                strConnection += "Connect Timeout=5";
            }
            return strConnection;
        }

        private void fileSelection_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                fileUrl_show.Text = fd.SelectedPath;
            //this.folderBrowserDialog1.ShowDialog();
        }

        /// <summary>
        /// 执行Sql文件
        /// </summary>
        /// <param name="varFileName"></param>
        /// <returns></returns>
        public  bool ExecuteSqlFile(string varFileName)
        {
            if (!File.Exists(varFileName))
            {
                return false;
            }

            StreamReader sr = File.OpenText(varFileName);

            ArrayList alSql = new ArrayList();

            string commandText = "";

            string varLine = "";

            while (sr.Peek() > -1)
            {
                varLine = sr.ReadLine();
                if (varLine == "")
                {
                    continue;
                }
                if (varLine != "GO")
                {
                    commandText += varLine;
                    commandText += "\r\n";
                }
                else
                {
                    alSql.Add(commandText);
                    commandText = "";
                }
            }

            sr.Close();

            try
            {
                ExecuteCommand(alSql);
            }
            catch
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 执行
        /// </summary>
        /// <param name="varSqlList"></param>
        public  void ExecuteCommand(ArrayList varSqlList)
        {
            SqlConnection objConnection = new SqlConnection(this.getConnectString());

            objConnection.Open();
            SqlTransaction varTrans = objConnection.BeginTransaction();

            SqlCommand command = new SqlCommand();
            command.Connection = objConnection;
            command.Transaction = varTrans;

            try
            {
                foreach (string varcommandText in varSqlList)
                {
                    command.CommandText = varcommandText;
                    command.ExecuteNonQuery();
                }
                varTrans.Commit();
            }
            catch (Exception ex)
            {
                varTrans.Rollback();
                throw ex;
            }
            finally
            {
                objConnection.Close();
            }
        }

        /// <summary>
        /// 执行所有的sql文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void execSql_Click(object sender, EventArgs e)
        {
            int successNum = 0;
            int faildNum = 0;
            foreach (string name in Directory.GetFiles(this.fileUrl_show.Text.Trim()))
            {
                if (ExecuteSqlFile(name))
                {
                    this.result_ok.Text +=name+" 操作成功" + Environment.NewLine;
                    successNum++;
                }
                else
                {
                    this.result_faild.Text += name + " 操作失败" + Environment.NewLine;
                    faildNum++;
                }
            }
            MessageBox.Show("总共执行(" + Directory.GetFiles(this.fileUrl_show.Text.Trim()).Length.ToString()+") 成功("+successNum.ToString()+") 失败("+faildNum.ToString()+")");
        }

    }
}
