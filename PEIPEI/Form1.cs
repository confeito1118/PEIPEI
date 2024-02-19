using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Security.Policy;
using System.Text;
using System.Xml;

namespace PEIPEI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void qfile1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"\\192.168.100.250");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"\\NAS303F9E");
        }

        private void mail_Click(object sender, EventArgs e)
        {
            ProcessStartInfo pi = new ProcessStartInfo()
            {
                FileName = "https://mail.yahoo.co.jp/",
                UseShellExecute = true,
            };

            Process.Start(pi);
        }

        private void kuruma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"\\192.168.100.250\010 npo\�Q�ԗ��֌W");
        }

        private void test_Click(object sender, EventArgs e)
        {
            // �e�[�u���������݂��Ȃ���΍쐬����
            StringBuilder query = new StringBuilder();
            query.Clear();
            query.Append("CREATE TABLE IF NOT EXISTS PURCHASELIST (");
            query.Append(" NO INTEGER PRIMARY KEY AUTOINCREMENT");
            query.Append(" ,DATETIME TEXT NOT NULL");
            query.Append(" ,NAME TEXT NOT NULL");
            query.Append(" ,PRICE INTEGER NOT NULL");
            //query.Append(" ,primary key (NO)");
            query.Append(")");

            // �N�G���[���s
            ExecuteNonQuery(query.ToString());

            InsertRecord(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "coffee", 100);
            InsertRecord(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "meet", 350);
            InsertRecord(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "snacks", 200);
            InsertRecord(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "juice", 150);
        }

        private void ExecuteNonQuery(string query)
        {
            try
            {
                // �ڑ�����w��
                using (var conn = new SQLiteConnection("Data Source=DataBase.sqlite"))
                using (var command = conn.CreateCommand())
                {
                    // �ڑ�
                    conn.Open();

                    // �R�}���h�̎��s����
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    //var value = command.ExecuteNonQuery();
                    //MessageBox.Show($"�X�V���ꂽ���R�[�h���� {value} �ł��B");
                }
            }
            catch (Exception ex)
            {
                //��O�������������̓��b�Z�[�W�{�b�N�X��\��
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertRecord(string datetime, string name, int price)
        {
            // ���R�[�h�̓o�^
            var query = "INSERT INTO PURCHASELIST (DATETIME,NAME,PRICE) VALUES (" +
                $"'{datetime}','{name}',{price})";

            // �N�G���[���s
            ExecuteNonQuery(query.ToString());
        }
    }
}
