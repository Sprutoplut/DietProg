namespace WindowsFormsApp1
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.tbLog = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.tbPas = new Telerik.WinControls.UI.RadTextBox();
            this.tbPas2 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.dtpBorn = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.seWeidth = new Telerik.WinControls.UI.RadSpinEditor();
            this.rbReg = new Telerik.WinControls.UI.RadButton();
            this.ErrorLog = new Telerik.WinControls.UI.RadLabel();
            this.ErrorPas = new Telerik.WinControls.UI.RadLabel();
            this.ErrorPas2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tbLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBorn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seWeidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLog
            // 
            this.tbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.tbLog.Location = new System.Drawing.Point(66, 27);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(218, 21);
            this.tbLog.TabIndex = 0;
            this.tbLog.ThemeName = "Office2010Blue";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 28);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(48, 21);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Логин";
            this.radLabel1.ThemeName = "Office2010Blue";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 70);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(58, 21);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Пароль";
            this.radLabel2.ThemeName = "Office2010Blue";
            // 
            // tbPas
            // 
            this.tbPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.tbPas.Location = new System.Drawing.Point(76, 69);
            this.tbPas.Name = "tbPas";
            this.tbPas.PasswordChar = '*';
            this.tbPas.Size = new System.Drawing.Size(208, 21);
            this.tbPas.TabIndex = 3;
            this.tbPas.ThemeName = "Office2010Blue";
            // 
            // tbPas2
            // 
            this.tbPas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.tbPas2.Location = new System.Drawing.Point(150, 111);
            this.tbPas2.Name = "tbPas2";
            this.tbPas2.PasswordChar = '*';
            this.tbPas2.Size = new System.Drawing.Size(134, 21);
            this.tbPas2.TabIndex = 5;
            this.tbPas2.ThemeName = "Office2010Blue";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(12, 112);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(132, 21);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Повторите пароль";
            this.radLabel3.ThemeName = "Office2010Blue";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(12, 154);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(112, 21);
            this.radLabel4.TabIndex = 6;
            this.radLabel4.Text = "Дата рождения";
            this.radLabel4.ThemeName = "Office2010Blue";
            // 
            // dtpBorn
            // 
            this.dtpBorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.dtpBorn.Location = new System.Drawing.Point(130, 153);
            this.dtpBorn.Name = "dtpBorn";
            this.dtpBorn.Size = new System.Drawing.Size(154, 21);
            this.dtpBorn.TabIndex = 7;
            this.dtpBorn.TabStop = false;
            this.dtpBorn.Text = "17 ноября 2022 г.";
            this.dtpBorn.ThemeName = "Office2010Blue";
            this.dtpBorn.Value = new System.DateTime(2022, 11, 17, 12, 35, 40, 363);
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(12, 195);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(31, 21);
            this.radLabel5.TabIndex = 8;
            this.radLabel5.Text = "Вес";
            this.radLabel5.ThemeName = "Office2010Blue";
            // 
            // seWeidth
            // 
            this.seWeidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.seWeidth.Location = new System.Drawing.Point(49, 194);
            this.seWeidth.Name = "seWeidth";
            this.seWeidth.Size = new System.Drawing.Size(100, 21);
            this.seWeidth.TabIndex = 9;
            this.seWeidth.ThemeName = "Office2010Blue";
            // 
            // rbReg
            // 
            this.rbReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.rbReg.Location = new System.Drawing.Point(66, 226);
            this.rbReg.Name = "rbReg";
            this.rbReg.Size = new System.Drawing.Size(176, 36);
            this.rbReg.TabIndex = 10;
            this.rbReg.Text = "Зарегестрироваться";
            this.rbReg.ThemeName = "MaterialBlueGrey";
            this.rbReg.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // ErrorLog
            // 
            this.ErrorLog.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLog.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorLog.Location = new System.Drawing.Point(21, 50);
            this.ErrorLog.Name = "ErrorLog";
            this.ErrorLog.Size = new System.Drawing.Size(275, 14);
            this.ErrorLog.TabIndex = 11;
            this.ErrorLog.Text = "* Логин должен содержать более 5 символов и не содержать пробелы";
            this.ErrorLog.Visible = false;
            // 
            // ErrorPas
            // 
            this.ErrorPas.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorPas.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorPas.Location = new System.Drawing.Point(12, 92);
            this.ErrorPas.Name = "ErrorPas";
            this.ErrorPas.Size = new System.Drawing.Size(284, 14);
            this.ErrorPas.TabIndex = 12;
            this.ErrorPas.Text = "** Пароль должен содержать более 5 символов и не содержать пробелы";
            this.ErrorPas.Visible = false;
            // 
            // ErrorPas2
            // 
            this.ErrorPas2.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorPas2.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorPas2.Location = new System.Drawing.Point(150, 133);
            this.ErrorPas2.Name = "ErrorPas2";
            this.ErrorPas2.Size = new System.Drawing.Size(101, 14);
            this.ErrorPas2.TabIndex = 13;
            this.ErrorPas2.Text = "*** Пароли не совпадают";
            this.ErrorPas2.Visible = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 272);
            this.Controls.Add(this.ErrorPas2);
            this.Controls.Add(this.ErrorPas);
            this.Controls.Add(this.ErrorLog);
            this.Controls.Add(this.rbReg);
            this.Controls.Add(this.seWeidth);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.dtpBorn);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.tbPas2);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.tbPas);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.tbLog);
            this.Name = "Register";
            this.Text = "Register";
            this.ThemeName = "MaterialBlueGrey";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBorn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seWeidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private Telerik.WinControls.UI.RadTextBox tbLog;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox tbPas;
        private Telerik.WinControls.UI.RadTextBox tbPas2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDateTimePicker dtpBorn;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadSpinEditor seWeidth;
        private Telerik.WinControls.UI.RadButton rbReg;
        private Telerik.WinControls.UI.RadLabel ErrorLog;
        private Telerik.WinControls.UI.RadLabel ErrorPas2;
        private Telerik.WinControls.UI.RadLabel ErrorPas;
    }
}
