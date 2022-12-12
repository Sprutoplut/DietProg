using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WindowsFormsApp1.Database;
using System.IO;
using System.Globalization;
using Microsoft.Office.Interop.Word;
using WindowsFormsApp1.Common;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class MenuLog : Telerik.WinControls.UI.RadForm
    {
        #region Глобальные переменные
        private int Code_User { get; set; }
        DataBase database = new DataBase();
        private List<Weid> weids = new List<Weid>();
        private List<ListEat> listEat = new List<ListEat>();
        private List<MarketPrice> Market = new List<MarketPrice>();
        private List<MarketSumPrice> MarketSum = new List<MarketSumPrice>();
        private List<TableBLD> TableBLDs = new List<TableBLD>();
        List<string> name = new List<string> { };
        List<double> belki = new List<double> { };
        List<double> jir = new List<double> { };
        List<double> uglevod = new List<double> { };
        List<double> kal = new List<double> { };
        public bool IsChange = true;
        #endregion

        #region Инициализация, загрузка и закрытие формы
        public MenuLog()
        {
            InitializeComponent();
        }

        

        private void MenuLog_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void MenuLog_Load(object sender, EventArgs e)
        {
            rlVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            dPol = 0;
            dObraz = 0;
            dTarget = 1;
            rgvEat.Rows.Clear();
            weids.Clear();
            string log = this.Text.Substring(9, this.Text.Length-9);
            string querystr = $"select w.Date,w.Weid,w.Code_Log from Weid w,Log l where l.Login='{log}' and l.Code_Log=w.Code_Log";
            SqlCommand command = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            Weid wd;
            while(reader.Read())
            {
                wd = new Weid();
                wd.dt = reader.GetDateTime(0);
                wd.weid = reader.GetDouble(1);
                Code_User = reader.GetInt32(2);
                weids.Add(wd);
            }
            reader.Close();
            ViewChart();
            database.closeConnection();

            querystr = $"select e.Date,e.EatList,e.KalAll,e.KalChange from Eat e,Log l where l.Login='{log}' and l.Code_Log=e.Code_Log";
            command = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                rgvEat.Rows.AddNew();
                rgvEat.Rows[i].Cells[0].Value = reader.GetString(0);
                rgvEat.Rows[i].Cells[1].Value = reader.GetString(1);
                rgvEat.Rows[i].Cells[2].Value = reader.GetDouble(2);
                rgvEat.Rows[i].Cells[3].Value = reader.GetDouble(3);
                i++;
            }
            reader.Close();
            database.closeConnection();

            string[] row = new string[5];
            FileInfo fInfo = new FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);

            string folderBin = fInfo.DirectoryName;
            string folderSys = new FileInfo(folderBin).DirectoryName;
            string csvFile = folderSys + "\\Tablitsa_kaloriynosti_produktov.csv";
            StreamReader sr = new StreamReader(csvFile);
            string s = sr.ReadLine();
            while(!sr.EndOfStream)
            {
                s = sr.ReadLine();
                row=s.Split(';');
                name.Add(row[0]);
                belki.Add(Convert.ToDouble(row[1]));
                jir.Add(Convert.ToDouble(row[2]));
                uglevod.Add(Convert.ToDouble(row[3]));
                kal.Add(Convert.ToDouble(row[4]));
            }
            string[] row1 = new string[3];
            fInfo = new FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);

            folderBin = fInfo.DirectoryName;
            folderSys = new FileInfo(folderBin).DirectoryName;
            csvFile = folderSys + "\\Magazine.csv";
            sr = new StreamReader(csvFile);
            s = sr.ReadLine();
            MarketPrice mp;
            while (!sr.EndOfStream)
            {
                mp = new MarketPrice();
                s = sr.ReadLine();
                row1 = s.Split(';');
                mp.NameMarket= row1[0];
                mp.NameEat=row1[1];
                mp.Price=Convert.ToDouble(row1[2]);
                Market.Add(mp);
            }
            (rgvBreakfast.Columns[0] as GridViewComboBoxColumn).DataSource = name;
            (rgvBreakfast.Columns[0] as GridViewComboBoxColumn).AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            (rgvLunch.Columns[0] as GridViewComboBoxColumn).DataSource = name;
            (rgvLunch.Columns[0] as GridViewComboBoxColumn).AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            (rgvDiner.Columns[0] as GridViewComboBoxColumn).DataSource = name;
            (rgvDiner.Columns[0] as GridViewComboBoxColumn).AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            (rgvDelivery.Columns[0] as GridViewComboBoxColumn).DataSource = name;
            (rgvDelivery.Columns[0] as GridViewComboBoxColumn).AutoCompleteMode = AutoCompleteMode.SuggestAppend;




            querystr = $"select Date_born from Log where Login='{log}'";
            database.openConnection();
            command = new SqlCommand(querystr, database.getConnection());
            reader = command.ExecuteReader();
            reader.Read();
            Born = Convert.ToDateTime(reader[0]);
            reader.Close();
            database.closeConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            System.Data.DataTable table = new System.Data.DataTable();
            querystr = $"select Target,Kal,Bel,Jir,Ugl from Planb where Login='{log}'";
            command = new SqlCommand(querystr, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            database.openConnection();
            if (table.Rows.Count != 0)
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cblTarget.Text = reader.GetString(0);
                    cblKal.Text = Convert.ToString(reader.GetDouble(1));
                    cblBel.Text = Convert.ToString(reader.GetDouble(2));
                    cblJir.Text = Convert.ToString(reader.GetDouble(3));
                    cblUgl.Text = Convert.ToString(reader.GetDouble(4));
                }
                reader.Close();
            }
            database.closeConnection();

        }
        #endregion

        #region Вспомогательные
        public void ViewChart()
        {
            
            rcvWeid.DataSource = null;
            rcvWeid.DataSource = weids;
            rgvEat.Refresh();
        }
        public void RefreshWeid()
        {
            weids.Clear();
            string querystr = $"select Date,Weid from Weid where Code_Log='{Code_User}'";
            SqlCommand command = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            Weid wd;
            while (reader.Read())
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
        public void ChangeEatList()
        {
            if (IsChange == true)
            {
                listEat.Clear();
                ListEat le;
                for (int i = 0; i < rgvBreakfast.RowCount; i++)
                {
                    le = new ListEat();
                    le.Name = rgvBreakfast.Rows[i].Cells[0].Value.ToString();
                    for (int j = 0; j < name.Count; j++)
                    {
                        if (le.Name == name[j])
                        {
                            le.NameId = j;
                            break;
                        }
                    }
                    le.Jir = jir[le.NameId] / 100 * Convert.ToDouble(rgvBreakfast.Rows[i].Cells[1].Value);
                    le.Belki = belki[le.NameId] / 100 * Convert.ToDouble(rgvBreakfast.Rows[i].Cells[1].Value);
                    le.Uglevodi = uglevod[le.NameId] / 100 * Convert.ToDouble(rgvBreakfast.Rows[i].Cells[1].Value);
                    le.Kal = kal[le.NameId] / 100 * Convert.ToDouble(rgvBreakfast.Rows[i].Cells[1].Value);
                    le.gram = Convert.ToDouble(rgvBreakfast.Rows[i].Cells[1].Value);
                    listEat.Add(le);
                }

                for (int i = 0; i < rgvLunch.RowCount; i++)
                {
                    le = new ListEat();
                    le.Name = rgvLunch.Rows[i].Cells[0].Value.ToString();
                    for (int j = 0; j < name.Count; j++)
                    {
                        if (le.Name == name[j])
                        {
                            le.NameId = j;
                            break;
                        }
                    }
                    le.Jir = jir[le.NameId] / 100 * Convert.ToDouble(rgvLunch.Rows[i].Cells[1].Value);
                    le.Belki = belki[le.NameId] / 100 * Convert.ToDouble(rgvLunch.Rows[i].Cells[1].Value);
                    le.Uglevodi = uglevod[le.NameId] / 100 * Convert.ToDouble(rgvLunch.Rows[i].Cells[1].Value);
                    le.Kal = kal[le.NameId] / 100 * Convert.ToDouble(rgvLunch.Rows[i].Cells[1].Value);
                    le.gram = Convert.ToDouble(rgvLunch.Rows[i].Cells[1].Value);
                    listEat.Add(le);

                }


                for (int i = 0; i < rgvDiner.RowCount; i++)
                {
                    le = new ListEat();
                    le.Name = rgvDiner.Rows[i].Cells[0].Value.ToString();
                    for (int j = 0; j < name.Count; j++)
                    {
                        if (le.Name == name[j])
                        {
                            le.NameId = j;
                            break;
                        }
                    }
                    le.Jir = jir[le.NameId] / 100 * Convert.ToDouble(rgvDiner.Rows[i].Cells[1].Value);
                    le.Belki = belki[le.NameId] / 100 * Convert.ToDouble(rgvDiner.Rows[i].Cells[1].Value);
                    le.Uglevodi = uglevod[le.NameId] / 100 * Convert.ToDouble(rgvDiner.Rows[i].Cells[1].Value);
                    le.Kal = kal[le.NameId] / 100 * Convert.ToDouble(rgvDiner.Rows[i].Cells[1].Value);
                    le.gram = Convert.ToDouble(rgvDiner.Rows[i].Cells[1].Value);
                    listEat.Add(le);

                }

                double sumk = 0;
                double sumj = 0;
                double sumb = 0;
                double sumu = 0;
                for (int i = 0; i < listEat.Count; i++)
                {
                    sumk += listEat[i].Kal;
                    sumj += listEat[i].Jir;
                    sumb += listEat[i].Belki;
                    sumu += listEat[i].Uglevodi;
                }
                rlKal.Text = sumk.ToString();
                rlBelki.Text = sumb.ToString();
                rlJir.Text = sumj.ToString();
                rlUglevodi.Text = sumu.ToString();
            }
        }
        #endregion

        #region Кнопки
        private void cbbExport_Click(object sender, EventArgs e)
        {
            try
            {
                string path;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Png Image (.png)|*.png";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    path = sfd.FileName;

                    if (!string.IsNullOrEmpty(path))
                    {
                        rcvWeid.ExportToImage(path, rcvWeid.MaximumSize);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void rbSelectMenu_Click(object sender, EventArgs e)
        {
            MenuSelect mu = new MenuSelect();
            mu.ShowDialog(this);
        }

        private void rbAutoInsert_Click(object sender, EventArgs e)
        {
            TableBLDs.Clear();
            TableBLD tbld;
            for (int i = 0; i < rgvBreakfast.RowCount; i++)
            {
                tbld = new TableBLD();
                tbld.Name = rgvBreakfast.Rows[i].Cells[0].Value.ToString();
                tbld.Mass = Convert.ToDouble(rgvBreakfast.Rows[i].Cells[1].Value);
                TableBLDs.Add(tbld);
            }
            for (int i = 0; i < rgvDiner.RowCount; i++)
            {
                tbld = new TableBLD();
                tbld.Name = rgvDiner.Rows[i].Cells[0].Value.ToString();
                tbld.Mass = Convert.ToDouble(rgvDiner.Rows[i].Cells[1].Value);
                TableBLDs.Add(tbld);
            }
            for (int i = 0; i < rgvLunch.RowCount; i++)
            {
                tbld = new TableBLD();
                tbld.Name = rgvLunch.Rows[i].Cells[0].Value.ToString();
                tbld.Mass = Convert.ToDouble(rgvLunch.Rows[i].Cells[1].Value);
                TableBLDs.Add(tbld);
            }
            rgvDelivery.Rows.Clear();
            for (int i = 0; i < TableBLDs.Count; i++)
            {
                rgvDelivery.Rows.AddNew();
                rgvDelivery.Rows[i].Cells[0].Value = TableBLDs[i].Name;
                rgvDelivery.Rows[i].Cells[1].Value = TableBLDs[i].Mass;
            }
        }

        private void rbDeliveryCalc_Click(object sender, EventArgs e)
        {
            int v = 0;
            MarketSum.Clear();
            MarketPrice mp;
            MarketSumPrice mps;
            for (int i = 0; i < clbMarket.Items.Count; i++)
            {
                if (clbMarket.Items[i].CheckState == Telerik.WinControls.Enumerations.ToggleState.On)
                {
                    mps = new MarketSumPrice();
                    mps.NameMarket = clbMarket.Items[i].Text;
                    mps.SumPrice = 0;
                    MarketSum.Add(mps);
                    v = v + 1;
                }
            }
            if (v != 0)
            {
                for (int i = 0; i < rgvDelivery.RowCount; i++)
                {
                    for (int j = 0; j < Market.Count; j++)
                    {
                        for (int k = 0; k < MarketSum.Count; k++)
                        {
                            if (Market[j].NameMarket == MarketSum[k].NameMarket && Market[j].NameEat == rgvDelivery.Rows[i].Cells[0].Value.ToString())
                            {
                                MarketSum[k].SumPrice = MarketSum[k].SumPrice + (Market[j].Price / 100) * Convert.ToDouble(rgvDelivery.Rows[i].Cells[1].Value);
                            }
                        }
                    }
                }
                double min = MarketSum[0].SumPrice;
                string name = MarketSum[0].NameMarket;
                for (int i = 0; i < MarketSum.Count; i++)
                {
                    if (min >= MarketSum[i].SumPrice)
                    {
                        min = MarketSum[i].SumPrice;
                        name = MarketSum[i].NameMarket;
                    }
                }
                rlMarketName.Text = name;
                rlPrice.Text = min.ToString("N1") + " руб.";
            }
        }
        private void bInsertChange_Click(object sender, EventArgs e)
        {
            string querystr = $"insert into Weid(Date,Weid,Code_Log) values (@Дата,@Вес,@Код)";
            SqlCommand command = new SqlCommand(querystr, database.getConnection());
            database.openConnection();
            command.Parameters.AddWithValue("@Дата", seDate.Value);
            command.Parameters.AddWithValue("@Вес", seWeid.Value);
            command.Parameters.AddWithValue("@Код", Code_User);
            command.ExecuteNonQuery();

            database.closeConnection();
            RefreshWeid();
        }
        private void rgvBreakfast_RowsChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            ChangeEatList();
        }

        private void rgvLunch_RowsChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            ChangeEatList();
        }

        private void rgvDiner_RowsChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            ChangeEatList();
        }

        private void rbInsertEat_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < listEat.Count; i++)
            {
                s = s + listEat[i].Name + ": " + listEat[i].gram + "грамм; ";
            }
            int k = rgvEat.Rows.Count;
            rgvEat.Rows.AddNew();
            rgvEat.Rows[k].Cells[0].Value = dtpEat.Value.ToString("dd.MM.yyyy");
            rgvEat.Rows[k].Cells[1].Value = s;
            double sumk = 0;
            for (int i = 0; i < listEat.Count; i++)
            {
                sumk += listEat[i].Kal;
            }
            rgvEat.Rows[k].Cells[2].Value = sumk;
            if (rgvEat.Rows.Count > 1)
            {
                rgvEat.Rows[k].Cells[3].Value = Convert.ToDouble(rgvEat.Rows[k].Cells[2].Value) - Convert.ToDouble(rgvEat.Rows[k - 1].Cells[2].Value);
            }
            else
                rgvEat.Rows[k].Cells[3].Value = 0;

            string log = this.Text.Substring(9, this.Text.Length - 9);
            SqlDataAdapter adapter = new SqlDataAdapter();
            System.Data.DataTable table = new System.Data.DataTable();
            string querystr = $"select Code_Log from Log where Login='{log}'";
            database.openConnection();
            SqlCommand command = new SqlCommand(querystr, database.getConnection());
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int code = Convert.ToInt32(reader[0]);
            reader.Close();

            querystr = $"insert into Eat(Code_Log,Date,EatList,KalAll,KalChange) values (@Код,@Дата,@Еда,@Кал,@Изм)";
            command = new SqlCommand(querystr, database.getConnection());
            command.Parameters.AddWithValue("@Код", code);
            command.Parameters.AddWithValue("@Дата", dtpEat.Value.ToString("dd.MM.yyyy"));
            command.Parameters.AddWithValue("@Еда", s);
            command.Parameters.AddWithValue("@Кал", sumk);
            command.Parameters.AddWithValue("@Изм", Convert.ToDouble(rgvEat.Rows[k].Cells[3].Value));
            command.ExecuteNonQuery();
            
            database.closeConnection();

        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            string log = this.Text.Substring(9, this.Text.Length - 9);
            string target = "";
            if (rrbLow.IsChecked)
                target = "Сбросить вес";
            else if (rrbNorm.IsChecked)
                target = "Поддерживать вес";
            else target ="Набрать мышечную массу";
            SqlDataAdapter adapter = new SqlDataAdapter();
            System.Data.DataTable table = new System.Data.DataTable();
            string querystr = $"select Code_Plan from Planb where Login='{log}'";
            SqlCommand command = new SqlCommand(querystr, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            database.openConnection();
            if(table.Rows.Count==0)
            {
                querystr = $"insert into Planb(Login,Kal,Bel,Jir,Ugl,Target) values (@Лог,@Кал,@Бел,@Жир,@Угл,@Цель)";
                command = new SqlCommand(querystr, database.getConnection());
                command.Parameters.AddWithValue("@Лог", log);
                command.Parameters.AddWithValue("@Кал", Convert.ToDouble(rlKalCalEat.Text));
                command.Parameters.AddWithValue("@Бел", Convert.ToDouble(rlBelCalEat.Text));
                command.Parameters.AddWithValue("@Жир", Convert.ToDouble(rlJirCalEat.Text));
                command.Parameters.AddWithValue("@Угл", Convert.ToDouble(rlUglCalEat.Text));
                command.Parameters.AddWithValue("@Цель", target);
                command.ExecuteNonQuery();
            }
            else
            {
                querystr = $"update Planb set Kal='{Convert.ToDouble(rlKalCalEat.Text)}',Bel='{Convert.ToDouble(rlBelCalEat.Text)}',Jir='{Convert.ToDouble(rlJirCalEat.Text)}',Ugl='{Convert.ToDouble(rlUglCalEat.Text)}',Target='{target}' where Login='{log}'";
                command = new SqlCommand(querystr, database.getConnection());
                command.ExecuteNonQuery();
            }
            cblTarget.Text = target;
            cblKal.Text = rlKalCalEat.Text;
            cblBel.Text = rlBelCalEat.Text;
            cblJir.Text = rlJirCalEat.Text;
            cblUgl.Text = rlUglCalEat.Text;


            database.closeConnection();
        }

        private void seMass_ValueChanged(object sender, EventArgs e)
        {
            Mass = Convert.ToDouble(seMass.Value);
            rlIMT.Text = IMT.ToString("N0");
            rlBOO.Text = BOO.ToString("N0");
            rlKalCalEat.Text = Kal.ToString("N0");
            rlJirCalEat.Text = Jir.ToString("N0");
            rlBelCalEat.Text = Belki.ToString("N0");
            rlUglCalEat.Text = Ugl.ToString("N0");
            rlEatStatus.Text = EatStatus;
        }

        private void seHeight_ValueChanged(object sender, EventArgs e)
        {
            Heightt = Convert.ToDouble(seHeight.Value);
            rlIMT.Text = IMT.ToString("N0");
            rlBOO.Text = BOO.ToString("N0");
            rlKalCalEat.Text = Kal.ToString("N0");
            rlJirCalEat.Text = Jir.ToString("N0");
            rlBelCalEat.Text = Belki.ToString("N0");
            rlUglCalEat.Text = Ugl.ToString("N0");
            rlEatStatus.Text = EatStatus;
        }
        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Pol = radDropDownList1.SelectedIndex;
            rlBOO.Text = BOO.ToString("N0");
            rlKalCalEat.Text = Kal.ToString("N0");
            rlJirCalEat.Text = Jir.ToString("N0");
            rlBelCalEat.Text = Belki.ToString("N0");
            rlUglCalEat.Text = Ugl.ToString("N0");
        }
        private void rddObraz_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Obraz = rddObraz.SelectedIndex;
            rlKalCalEat.Text = Kal.ToString("N0");
            rlJirCalEat.Text = Jir.ToString("N0");
            rlBelCalEat.Text = Belki.ToString("N0");
            rlUglCalEat.Text = Ugl.ToString("N0");
        }
        private void rrbLow_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (rrbLow.IsChecked)
                Target = 0;
            else if (rrbNorm.IsChecked)
                Target = 1;
            else
                Target = 2;
            rlKalCalEat.Text = Kal.ToString("N0");
            rlJirCalEat.Text = Jir.ToString("N0");
            rlBelCalEat.Text = Belki.ToString("N0");
            rlUglCalEat.Text = Ugl.ToString("N0");
        }

        private void rrbNorm_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (rrbLow.IsChecked)
                Target = 0;
            else if (rrbNorm.IsChecked)
                Target = 1;
            else
                Target = 2;
            rlKalCalEat.Text = Kal.ToString("N0");
            rlJirCalEat.Text = Jir.ToString("N0");
            rlBelCalEat.Text = Belki.ToString("N0");
            rlUglCalEat.Text = Ugl.ToString("N0");
        }

        private void rrbMax_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (rrbLow.IsChecked)
                Target = 0;
            else if (rrbNorm.IsChecked)
                Target = 1;
            else
                Target = 2;
            rlKalCalEat.Text = Kal.ToString("N0");
            rlJirCalEat.Text = Jir.ToString("N0");
            rlBelCalEat.Text = Belki.ToString("N0");
            rlUglCalEat.Text = Ugl.ToString("N0");
        }
        private void cbbExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp;
            try
            {
                excelApp = new Microsoft.Office.Interop.Excel.Application();
            }
            catch (Exception)
            {
                return;
            }
            Workbook excelBook = MReport.Excel_NewBook(excelApp);
            Worksheet objSheet;
            objSheet = excelBook.Worksheets.Add();
            objSheet.Name = "Рацион питания";

            int ind;
            ind = 1;
            MReport.Excel_FourData(objSheet, ref ind, "Дата", "Продукты", "Калории", "Изменение");
            for (int i = 0; i < rgvEat.RowCount; i++)
            {
                MReport.Excel_FourData(objSheet, ref ind, rgvEat.Rows[i].Cells[0].Value.ToString(), rgvEat.Rows[i].Cells[1].Value.ToString(), Math.Round(Convert.ToDouble(rgvEat.Rows[i].Cells[2].Value),2), Math.Round(Convert.ToDouble(rgvEat.Rows[i].Cells[2].Value), 2));
            }

            string path = Path.GetTempPath();
            string put = path + "image123455432111.jpg";
            if (!string.IsNullOrEmpty(put))
            {
                rcvWeid.ExportToImage(put, rcvWeid.Size);
            }
            Image img = null;
            Bitmap src = null;
            img = Image.FromFile(put);
            src = (Bitmap)img;
            objSheet = excelBook.Worksheets.Add();
            objSheet.Name = "График истечения";
            ind = 1;
            MReport.Excel_CoupleData(objSheet, ref ind, "График", "веса");
            objSheet.Shapes.AddPicture(put, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 50, 50, rcvWeid.Size.Width, rcvWeid.Size.Height);
            excelApp.Visible = true;
        }

        private void cbbWord_Click(object sender, EventArgs e)
        {
            // инициализируем Word 
            Microsoft.Office.Interop.Word.Application wordApp;
            try
            {
                wordApp = new Microsoft.Office.Interop.Word.Application();
            }
            catch (Exception)
            {
                return;
            }

            // создаем документ  
            Document wordDoc = MReport.Word_Begin(wordApp);
            Microsoft.Office.Interop.Word.Range wordRange = null;

            // вставляем заголовок отчета 
            MReport.Word_Title(wordApp, "Статистические значения", 18, WdParagraphAlignment.wdAlignParagraphJustify);

            MReport.Word_Title(wordApp, "Рацион питания", 16, WdParagraphAlignment.wdAlignParagraphJustify);
            wordRange = wordApp.Selection.Range;
            wordRange.Collapse(0);
            MReport.Word_TextLine(wordRange, String.Format("{0}^{1}^{2}^{3}", "Дата", "Продукты", "Калории", "Изменение"));
            for (int i = 0; i < rgvEat.RowCount; i++)
            {
                MReport.Word_TextLine(wordRange, String.Format("{0}^{1}^{2}^{3}", rgvEat.Rows[i].Cells[0].Value.ToString(), rgvEat.Rows[i].Cells[1].Value.ToString(), Math.Round(Convert.ToDouble(rgvEat.Rows[i].Cells[2].Value), 2).ToString(), Math.Round(Convert.ToDouble(rgvEat.Rows[i].Cells[3].Value), 2).ToString()));
            }
            wordRange.ConvertToTable("^");
            try
            {
                wordDoc.Tables[1].AutoFormat(Format: 14);
                wordDoc.Tables[1].Columns[1].Width = 100;
                wordDoc.Tables[1].Columns[2].Width = 200;
                wordDoc.Tables[1].Columns[3].Width = 100;
                wordDoc.Tables[1].Columns[4].Width = 100;
                wordDoc.Tables[1].Rows.Alignment = WdRowAlignment.wdAlignRowCenter;
            }
            catch (Exception)
            {
            }
            wordApp.Selection.Move(4, 2000000);
            MReport.Word_Absaz(wordApp, "");
            MReport.Word_Title(wordApp, "Рацион питания", 16, WdParagraphAlignment.wdAlignParagraphJustify);
            MReport.Word_Absaz(wordApp, String.Format("Ваша цель: {0}, калории = {1}, белки = {2}, жиры = {3}, углеводы = {4}.", cblTarget.Text, cblKal.Text, cblBel.Text, cblJir.Text, cblUgl.Text));
            MReport.Word_Absaz(wordApp, "");
            string path = Path.GetTempPath();
            string put = path + "image1234554321.jpg";

            if (!string.IsNullOrEmpty(put))
            {
                rcvWeid.ExportToImage(put, rcvWeid.Size);
            }
            Image img = null;
            Bitmap src = null;
            img = Image.FromFile(put);
            src = (Bitmap)img;
            MReport.Word_Title(wordApp, "График изменения веса", 16, WdParagraphAlignment.wdAlignParagraphLeft);
            MReport.Word_Image(wordApp, src);

            wordApp.Visible = true;
        }
        #endregion

        #region Решатель

        #region Входные данные
        private double dMass, dHeight;
        private DateTime dBorn;
        private int dPol, dObraz,dTarget;
        public int Pol
        {
            get
            {
                return dPol;
            }
            set
            {
                dPol = value;
            }
        }
        public DateTime Born
        {
            get
            {
                return dBorn;
            }
            set
            {
                dBorn = value;
            }
        }
        public double Mass
        {
            get
            {
                return dMass;
            }
            set
            {
                dMass = value;
            }
        }
        public double Heightt
        {
            get
            {
                return dHeight;
            }
            set
            {
                dHeight = value/100;
            }
        }
        public int Obraz
        {
            get
            {
                return dObraz;
            }
            set
            {
                dObraz = value;
            }
        }
        public int Target
        {
            get
            {
                return dTarget;
            }
            set
            {
                dTarget = value;
            }
        }
        #endregion

        #region Промежуточные
        public int Age
        {
            get
            {
                var date= DateTime.ParseExact(Born.ToString("dd.MM.yyyy"), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                int age = DateTime.Now.Year - date.Year;
                if (DateTime.Now.DayOfYear < date.DayOfYear)
                    age++;
                return age;
            }
        }
        #endregion

        #region Результирующие
        public double IMT
        {
            get
            {
                return Mass / (Heightt * Heightt);
            }
        }
        public double BOO
        {
            get
            {
                if (Pol == 0)
                    return 9.99 * Mass + 6.25 * Heightt*100 - 4.92 * Age + 5;
                else
                    return 9.99 * Mass + 6.25 * Heightt*100 - 4.92 * Age - 161;

            }
        }
        public string EatStatus
        {
            get
            {
                if (IMT < 18.5)
                    return "Дефицит МТ";
                else if (IMT < 25)
                    return "Нормальная МТ";
                else if (IMT < 30)
                    return "Избыточная МТ";
                else if (IMT < 35)
                    return "Ожирение I степени";
                else if (IMT < 40)
                    return "Ожирение II степени";
                else
                    return "Ожирение III степени";
            }
        }
        public double Kal
        {
            get
            {
                double k = 1.2;
                if (Obraz == 0)
                    k = 1.2;
                else if (Obraz == 1)
                    k = 1.375;
                else if (Obraz == 2)
                    k = 1.55;
                else if (Obraz == 3)
                    k = 1.7;
                else
                    k = 1.9;
                if (Target == 0)
                    return BOO * k * 0.8;
                else if (Target == 1)
                    return BOO * k;
                else return BOO * k * 1.2;

            }
        }
        public double Belki
        {
            get
            {
                return Kal * 0.3 / 4;
            }
        }
        public double Jir
        {
            get
            {
                if (Target == 1 || Target == 2)
                    return Kal * 0.3 / 9;
                else
                    return Kal * 0.2 / 9;
            }
        }
        public double Ugl
        {
            get
            {
                if (Target == 1 || Target == 2)
                    return Kal * 0.4 / 4;
                else
                    return Kal * 0.5 / 4;
            }
        }
        #endregion

        #endregion 
    }

    #region Листы
    public class Weid
    {
        public DateTime dt { get; set; }
        public double weid { get; set; }
    }

    public class ListEat
    {
        public string Name { get; set; }
        public int NameId { get; set; }
        public double Belki { get; set; }
        public double Jir { get; set; }
        public double Uglevodi { get; set; }
        public double Kal { get; set; }
        public double gram { get; set; }
    }

    public class MarketPrice
    {
        public int Index { get; set; }
        public string NameMarket { get; set; }
        public string NameEat { get; set; }
        public double Price { get; set; }
    }

    public class MarketSumPrice
    {
        public string NameMarket { get; set; }
        public double SumPrice { get; set; }
    }
    public class TableBLD
    {
        public string Name { get; set; }
        public double Mass { get; set; }
    }

    #endregion
}
