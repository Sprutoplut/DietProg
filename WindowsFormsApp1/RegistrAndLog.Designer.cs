namespace WindowsFormsApp1
{
    partial class RegistrAndLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrAndLog));
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.None = new Telerik.WinControls.UI.RadLiveTileElement();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.radPanorama1 = new Telerik.WinControls.UI.RadPanorama();
            this.bRegister = new Telerik.WinControls.UI.RadButton();
            this.bInput = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).BeginInit();
            this.radPanorama1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // None
            // 
            this.None.AutoSize = false;
            this.None.Bounds = new System.Drawing.Rectangle(0, 0, 360, 90);
            this.None.Column = 1;
            this.None.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.None.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.None.Name = "None";
            this.None.Row = 1;
            this.None.Text = "Вход";
            this.None.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.None.UseCompatibleTextRendering = false;
            // 
            // radPanorama1
            // 
            this.radPanorama1.Controls.Add(this.bRegister);
            this.radPanorama1.Controls.Add(this.bInput);
            this.radPanorama1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanorama1.Location = new System.Drawing.Point(0, 0);
            this.radPanorama1.Name = "radPanorama1";
            this.radPanorama1.RowsCount = 3;
            this.radPanorama1.Size = new System.Drawing.Size(562, 412);
            this.radPanorama1.TabIndex = 0;
            this.radPanorama1.ThemeName = "Office2010Silver";
            // 
            // bRegister
            // 
            this.bRegister.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRegister.ForeColor = System.Drawing.Color.White;
            this.bRegister.Location = new System.Drawing.Point(105, 205);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(361, 90);
            this.bRegister.TabIndex = 1;
            this.bRegister.Text = "Регистрация";
            this.bRegister.ThemeName = "FluentDark";
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // bInput
            // 
            this.bInput.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bInput.ForeColor = System.Drawing.Color.White;
            this.bInput.Location = new System.Drawing.Point(105, 103);
            this.bInput.Name = "bInput";
            this.bInput.Size = new System.Drawing.Size(361, 92);
            this.bInput.TabIndex = 0;
            this.bInput.Text = "Вход";
            this.bInput.ThemeName = "FluentDark";
            this.bInput.Click += new System.EventHandler(this.bInput_Click);
            // 
            // RegistrAndLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 412);
            this.Controls.Add(this.radPanorama1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 445);
            this.MinimumSize = new System.Drawing.Size(570, 445);
            this.Name = "RegistrAndLog";
            this.Text = "Главная";
            this.ThemeName = "FluentDark";
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).EndInit();
            this.radPanorama1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanorama radPanorama1;
        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.UI.RadLiveTileElement None;
        private Telerik.WinControls.UI.RadButton bInput;
        private Telerik.WinControls.UI.RadButton bRegister;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
    }
}
