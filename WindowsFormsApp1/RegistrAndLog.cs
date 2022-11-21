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
    public partial class RegistrAndLog : Telerik.WinControls.UI.RadForm
    {
        public RegistrAndLog()
        {
            InitializeComponent();
        }

        private void bInput_Click(object sender, EventArgs e)
        {
            Form form = new Login();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            Form form1 = new Register();
            Hide();
            form1.ShowDialog();
            Show();
        }
    }
}
