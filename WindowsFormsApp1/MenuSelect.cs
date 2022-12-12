using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace WindowsFormsApp1
{
    public partial class MenuSelect : Telerik.WinControls.UI.RadForm
    {
        
        public MenuSelect()
        {
            InitializeComponent();
        }

        private void MenuSelect_Load(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            MenuLog ml = this.Owner as MenuLog;
            ml.IsChange = false;
            ml.rgvBreakfast.Rows.Clear();
            ml.rgvBreakfast.Rows.AddNew();
            ml.rgvBreakfast.Rows[0].Cells[0].Value = "Картофель отварной";
            ml.rgvBreakfast.Rows[0].Cells[1].Value = 200;
            ml.rgvBreakfast.Rows.AddNew();
            ml.rgvBreakfast.Rows[1].Cells[0].Value = "Банан";
            ml.rgvBreakfast.Rows[1].Cells[1].Value = 350;
            ml.rgvBreakfast.Rows.AddNew();
            ml.rgvBreakfast.Rows[2].Cells[0].Value = "Кофе молотый Арабика";
            ml.rgvBreakfast.Rows[2].Cells[1].Value = 200;
            ml.rgvLunch.Rows.Clear();
            ml.rgvLunch.Rows.AddNew();
            ml.rgvLunch.Rows[0].Cells[0].Value = "Яблоки";
            ml.rgvLunch.Rows[0].Cells[1].Value = 300;
            ml.rgvLunch.Rows.AddNew();
            ml.rgvLunch.Rows[1].Cells[0].Value = "Грецкие орехи";
            ml.rgvLunch.Rows[1].Cells[1].Value = 100;
            ml.rgvDiner.Rows.Clear();
            ml.rgvDiner.Rows.AddNew();
            ml.rgvDiner.Rows[0].Cells[0].Value = "Спагетти отварные";
            ml.rgvDiner.Rows[0].Cells[1].Value = 200;
            ml.rgvDiner.Rows.AddNew();
            ml.rgvDiner.Rows[1].Cells[0].Value = "Киви";
            ml.rgvDiner.Rows[1].Cells[1].Value = 50;
            ml.rgvDiner.Rows.AddNew();
            ml.rgvDiner.Rows[2].Cells[0].Value = "Брокколи";
            ml.rgvDiner.Rows[2].Cells[1].Value = 100;
            ml.rgvDiner.Rows.AddNew();
            ml.rgvDiner.Rows[3].Cells[0].Value = "Овсянные хлопья геркулес";
            ml.rgvDiner.Rows[3].Cells[1].Value = 200;
            ml.IsChange = true;
            ml.ChangeEatList();
            this.Close();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            MenuLog ml = this.Owner as MenuLog;
            ml.IsChange = false;
            ml.rgvBreakfast.Rows.Clear();
            ml.rgvBreakfast.Rows.AddNew();
            ml.rgvBreakfast.Rows[0].Cells[0].Value = "Рис отварной";
            ml.rgvBreakfast.Rows[0].Cells[1].Value = 300;
            ml.rgvBreakfast.Rows.AddNew();
            ml.rgvBreakfast.Rows[1].Cells[0].Value = "Банан";
            ml.rgvBreakfast.Rows[1].Cells[1].Value = 350;
            ml.rgvBreakfast.Rows.AddNew();
            ml.rgvBreakfast.Rows[2].Cells[0].Value = "Филе куриной грудки";
            ml.rgvBreakfast.Rows[2].Cells[1].Value = 150;


            ml.rgvLunch.Rows.Clear();
            ml.rgvLunch.Rows.AddNew();
            ml.rgvLunch.Rows[0].Cells[0].Value = "Киви";
            ml.rgvLunch.Rows[0].Cells[1].Value = 50;
            ml.rgvLunch.Rows.AddNew();
            ml.rgvLunch.Rows[1].Cells[0].Value = "Грецкие орехи";
            ml.rgvLunch.Rows[1].Cells[1].Value = 70;


            ml.rgvDiner.Rows.Clear();
            ml.rgvDiner.Rows.AddNew();
            ml.rgvDiner.Rows[0].Cells[0].Value = "Спагетти отварные";
            ml.rgvDiner.Rows[0].Cells[1].Value = 300;
            ml.rgvDiner.Rows.AddNew();
            ml.rgvDiner.Rows[1].Cells[0].Value = "Сельдь атлантическая жирная";
            ml.rgvDiner.Rows[1].Cells[1].Value = 150;
            ml.rgvDiner.Rows.AddNew();
            ml.rgvDiner.Rows[2].Cells[0].Value = "Сыр Адыгейский";
            ml.rgvDiner.Rows[2].Cells[1].Value = 50;
            ml.rgvDiner.Rows.AddNew();
            ml.rgvDiner.Rows[3].Cells[0].Value = "Ряженка";
            ml.rgvDiner.Rows[3].Cells[1].Value = 100;
            ml.rgvDiner.Rows.AddNew();
            ml.rgvDiner.Rows[4].Cells[0].Value = "Творог 1%";
            ml.rgvDiner.Rows[4].Cells[1].Value = 200;
            ml.IsChange = true;
            ml.ChangeEatList();
            this.Close();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            MenuLog ml = this.Owner as MenuLog;
            ml.IsChange = false;
            ml.rgvBreakfast.Rows.Clear();
            ml.rgvBreakfast.Rows.AddNew();
            ml.rgvBreakfast.Rows[0].Cells[0].Value = "Гречневая крупа";
            ml.rgvBreakfast.Rows[0].Cells[1].Value = 150;
            ml.rgvBreakfast.Rows.AddNew();
            ml.rgvBreakfast.Rows[1].Cells[0].Value = "Авокадо";
            ml.rgvBreakfast.Rows[1].Cells[1].Value = 50;


            ml.rgvLunch.Rows.Clear();
            ml.rgvLunch.Rows.AddNew();
            ml.rgvLunch.Rows[0].Cells[0].Value = "Бульон куриный";
            ml.rgvLunch.Rows[0].Cells[1].Value = 300;
            ml.rgvLunch.Rows.AddNew();
            ml.rgvLunch.Rows[1].Cells[0].Value = "Кабачок";
            ml.rgvLunch.Rows[1].Cells[1].Value = 100;


            ml.rgvDiner.Rows.Clear();
            ml.rgvDiner.Rows.AddNew();
            ml.rgvDiner.Rows[0].Cells[0].Value = "Огурцы";
            ml.rgvDiner.Rows[0].Cells[1].Value = 100;
            ml.rgvDiner.Rows.AddNew();
            ml.rgvDiner.Rows[1].Cells[0].Value = "Борщ лёгкий";
            ml.rgvDiner.Rows[1].Cells[1].Value = 300;
            ml.rgvDiner.Rows.AddNew();
            ml.rgvDiner.Rows[2].Cells[0].Value = "Филе куриной грудки";
            ml.rgvDiner.Rows[2].Cells[1].Value = 100;
            ml.rgvDiner.Rows.AddNew();
            ml.rgvDiner.Rows[3].Cells[0].Value = "Кефир 1%";
            ml.rgvDiner.Rows[3].Cells[1].Value = 150;
            ml.rgvDiner.Rows.AddNew();
            ml.rgvDiner.Rows[4].Cells[0].Value = "Творог 1%";
            ml.rgvDiner.Rows[4].Cells[1].Value = 150;
            ml.IsChange = true;
            ml.ChangeEatList();
            this.Close();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            MenuLog ml = this.Owner as MenuLog;
            ml.IsChange = false;
            ml.rgvBreakfast.Rows.Clear();
            ml.rgvBreakfast.Rows.AddNew();
            ml.rgvBreakfast.Rows[0].Cells[0].Value = "Гречневая крупа";
            ml.rgvBreakfast.Rows[0].Cells[1].Value = 150;
            ml.rgvBreakfast.Rows.AddNew();
            ml.rgvBreakfast.Rows[1].Cells[0].Value = "Филе куриной грудки";
            ml.rgvBreakfast.Rows[1].Cells[1].Value = 100;
            ml.rgvBreakfast.Rows.AddNew();
            ml.rgvBreakfast.Rows[2].Cells[0].Value = "Кефир 1%";
            ml.rgvBreakfast.Rows[2].Cells[1].Value = 100;

            ml.rgvLunch.Rows.Clear();
            ml.rgvLunch.Rows.AddNew();
            ml.rgvLunch.Rows[0].Cells[0].Value = "Брокколи";
            ml.rgvLunch.Rows[0].Cells[1].Value = 100;
            ml.rgvLunch.Rows.AddNew();
            ml.rgvLunch.Rows[1].Cells[0].Value = "Яйца";
            ml.rgvLunch.Rows[1].Cells[1].Value = 30;


            ml.rgvDiner.Rows.Clear();
            ml.rgvDiner.Rows.AddNew();
            ml.rgvDiner.Rows[0].Cells[0].Value = "Огурцы";
            ml.rgvDiner.Rows[0].Cells[1].Value = 100;
            ml.rgvDiner.Rows.AddNew();
            ml.rgvDiner.Rows[1].Cells[0].Value = "Ряженка";
            ml.rgvDiner.Rows[1].Cells[1].Value = 200;
            ml.rgvDiner.Rows.AddNew();
            ml.rgvDiner.Rows[2].Cells[0].Value = "Томат";
            ml.rgvDiner.Rows[2].Cells[1].Value = 100;
            ml.rgvDiner.Rows.AddNew();
            ml.rgvDiner.Rows[3].Cells[0].Value = "Овсянка";
            ml.rgvDiner.Rows[3].Cells[1].Value = 150;
            ml.rgvDiner.Rows.AddNew();
            ml.rgvDiner.Rows[4].Cells[0].Value = "Макароны отварные";
            ml.rgvDiner.Rows[4].Cells[1].Value = 150;
            ml.IsChange = true;
            ml.ChangeEatList();
            this.Close();
        }
    }
}
