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
    public partial class MenuLog : Telerik.WinControls.UI.RadForm
    {
        DataBase database = new DataBase();
        private List<Weid> weids = new List<Weid>();
        public MenuLog()
        {
            InitializeComponent();
        }

        

        private void MenuLog_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MenuLog_Load(object sender, EventArgs e)
        {
            
            string log = this.Text.Substring(9, this.Text.Length-9);
            string querystr = $"select w.Date,w.Weid from Weid w,Log l where l.Login='{log}' and l.Code_Log=w.Code_Log";
            SqlCommand command = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            Weid wd;
            while(reader.Read())
            {
                wd = new Weid();
                wd.dt = reader.GetDateTime(0);
                wd.weid = reader.GetDouble(1);
                weids.Add(wd);
            }
            reader.Close();
            ViewChart();
            database.closeConnection();
            
        }
        public void ViewChart()
        {
            
            rcvWeid.DataSource = null;
            rcvWeid.DataSource = weids;
            rgvEat.Refresh();
        }
    }
    #region Листы
    public class Weid
    {
        public DateTime dt { get; set; }
        public double weid { get; set; }
    }

    #endregion
}
