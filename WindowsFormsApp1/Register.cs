using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using WindowsFormsApp1.Database;

namespace WindowsFormsApp1
{
    public partial class Register : Telerik.WinControls.UI.RadForm
    {
        DataBase database = new DataBase();
        public Register()
        {
            InitializeComponent();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            string log = tbLog.Text;
            string pas = tbPas.Text;
            DateTime born = dtpBorn.Value;
            double weig = Convert.ToDouble(seWeidth.Value);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystr = $"select Login from Log where Login='{log}'";
            SqlCommand command = new SqlCommand(querystr,database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            database.openConnection();
            ErrorLog.Visible = false;
            ErrorPas.Visible = false;
            ErrorPas.Visible = false;
            if(table.Rows.Count!=0)
            {
                MessageBox.Show("Такой логин уже существует");
            }
            else if (tbLog.Text.Contains(" ") || tbLog.Text.Length < 5 || tbLog.Text.Length >30)
            {
                ErrorLog.Visible = true;
            }
            else if(tbPas.Text.Contains(" ") || tbPas.Text.Length < 5 || tbPas.Text.Length > 30)
            {
                ErrorPas.Visible = true;
            }
            else if(tbLog.Text=="" || tbPas.Text==""|| seWeidth.Value==0)
            {
                MessageBox.Show("Заполните все поля");
            }
            else if (tbPas.Text!=tbPas2.Text)
            {
                ErrorPas2.Visible = true;
            }
            else
            {

                querystr = $"insert into Log(Login,Password,Date_born,Weidth,Date_reg) values (@Логин,@Пароль,@Дата,@Вес,@Дата_рег)";
                command = new SqlCommand(querystr,database.getConnection());
                command.Parameters.AddWithValue("@Логин", log);
                command.Parameters.AddWithValue("@Пароль", pas);
                command.Parameters.AddWithValue("@Дата", born);
                command.Parameters.AddWithValue("@Вес", weig);
                command.Parameters.AddWithValue("@Дата_рег", DateTime.Now);
                command.ExecuteNonQuery();
                querystr = $"select Code_Log from Log where Login='{log}'";
                command = new SqlCommand(querystr, database.getConnection());
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                int code = Convert.ToInt32(reader[0]);
                reader.Close();
                querystr = $"insert into Weid(Date,Weid,Code_Log) values (@Дата,@Вес,@Код)";
                command = new SqlCommand(querystr, database.getConnection());
                command.Parameters.AddWithValue("@Дата", DateTime.Now);
                command.Parameters.AddWithValue("@Вес", weig);
                command.Parameters.AddWithValue("@Код", code);
                command.ExecuteNonQuery();
                ErrorLog.Visible = false;
                ErrorPas.Visible = false;
                ErrorPas.Visible = false;
                MessageBox.Show("Успешная регистрация");
                
            }
            database.closeConnection();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            ErrorLog.Visible = false;
            ErrorPas.Visible = false;
            ErrorPas.Visible = false;
        }
    }
}
