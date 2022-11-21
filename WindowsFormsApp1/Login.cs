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
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        public string Log { get; set; }
        DataBase database = new DataBase();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

            Close();
           
        }

        private void rbLog_Click(object sender, EventArgs e)
        {
            ErrorLogPas.Visible = false;
            string log = tbLog.Text;
            string pas = tbPas.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystr = $"select Login from Log where Login='{log}' and Password='{pas}'";
            SqlCommand command = new SqlCommand(querystr, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            database.openConnection();
            if (table.Rows.Count==1)
            {
                Log = log;
                Form form = new MenuLog();
                Hide();
                form.Text = "Профиль: " + log;
                form.ShowDialog();
                
            }
            else
            {
                ErrorLogPas.Visible = true;
            }
            database.closeConnection();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ErrorLogPas.Visible = false;
        }
    }
}
