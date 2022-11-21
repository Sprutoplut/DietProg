namespace WindowsFormsApp1
{
    partial class Login
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
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.tbPas = new Telerik.WinControls.UI.RadTextBox();
            this.rbLog = new Telerik.WinControls.UI.RadButton();
            this.ErrorLogPas = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tbLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLogPas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLog
            // 
            this.tbLog.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLog.Location = new System.Drawing.Point(105, 97);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(317, 33);
            this.tbLog.TabIndex = 1;
            this.tbLog.ThemeName = "Office2010Blue";
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel2.ForeColor = System.Drawing.Color.White;
            this.radLabel2.Location = new System.Drawing.Point(228, 58);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(70, 33);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Логин";
            // 
            // radLabel3
            // 
            this.radLabel3.BackColor = System.Drawing.Color.Transparent;
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel3.ForeColor = System.Drawing.Color.White;
            this.radLabel3.Location = new System.Drawing.Point(221, 136);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(84, 33);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Пароль";
            // 
            // tbPas
            // 
            this.tbPas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPas.Location = new System.Drawing.Point(105, 175);
            this.tbPas.Name = "tbPas";
            this.tbPas.PasswordChar = '*';
            this.tbPas.Size = new System.Drawing.Size(317, 33);
            this.tbPas.TabIndex = 3;
            this.tbPas.ThemeName = "Office2010Blue";
            // 
            // rbLog
            // 
            this.rbLog.Location = new System.Drawing.Point(202, 248);
            this.rbLog.Name = "rbLog";
            this.rbLog.Size = new System.Drawing.Size(120, 36);
            this.rbLog.TabIndex = 5;
            this.rbLog.Text = "Войти";
            this.rbLog.ThemeName = "MaterialBlueGrey";
            this.rbLog.Click += new System.EventHandler(this.rbLog_Click);
            // 
            // ErrorLogPas
            // 
            this.ErrorLogPas.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLogPas.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLogPas.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorLogPas.Location = new System.Drawing.Point(117, 302);
            this.ErrorLogPas.Name = "ErrorLogPas";
            this.ErrorLogPas.Size = new System.Drawing.Size(295, 25);
            this.ErrorLogPas.TabIndex = 6;
            this.ErrorLogPas.Text = "Неправильный логин или пароль";
            this.ErrorLogPas.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ovshchi_spetsii_risunok;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(505, 367);
            this.Controls.Add(this.ErrorLogPas);
            this.Controls.Add(this.rbLog);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.tbPas);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.tbLog);
            this.Name = "Login";
            this.Text = "Login";
            this.ThemeName = "FluentDark";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLogPas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private Telerik.WinControls.UI.RadTextBox tbLog;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox tbPas;
        private Telerik.WinControls.UI.RadButton rbLog;
        private Telerik.WinControls.UI.RadLabel ErrorLogPas;
    }
}
