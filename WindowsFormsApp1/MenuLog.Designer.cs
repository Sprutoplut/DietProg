namespace WindowsFormsApp1
{
    partial class MenuLog
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
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CategoricalAxis categoricalAxis1 = new Telerik.WinControls.UI.CategoricalAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis1 = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.LineSeries lineSeries1 = new Telerik.WinControls.UI.LineSeries();
            Telerik.WinControls.UI.LineSeries lineSeries2 = new Telerik.WinControls.UI.LineSeries();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuLog));
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.pvpChangeWeid = new Telerik.WinControls.UI.RadPageViewPage();
            this.rcvWeid = new Telerik.WinControls.UI.RadChartView();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.cbbTable = new Telerik.WinControls.UI.CommandBarButton();
            this.cbbGraph = new Telerik.WinControls.UI.CommandBarButton();
            this.cbbExport = new Telerik.WinControls.UI.CommandBarButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.seDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.seWeid = new Telerik.WinControls.UI.RadSpinEditor();
            this.bInsertChange = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.pvpEat = new Telerik.WinControls.UI.RadPageViewPage();
            this.rgvEat = new Telerik.WinControls.UI.RadGridView();
            this.pvpCalcEat = new Telerik.WinControls.UI.RadPageViewPage();
            this.pvpBuyEat = new Telerik.WinControls.UI.RadPageViewPage();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.pvpChangeWeid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rcvWeid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seWeid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bInsertChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.pvpEat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvEat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvEat.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.pvpChangeWeid);
            this.radPageView1.Controls.Add(this.pvpEat);
            this.radPageView1.Controls.Add(this.pvpCalcEat);
            this.radPageView1.Controls.Add(this.pvpBuyEat);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radPageView1.Location = new System.Drawing.Point(0, 0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.pvpChangeWeid;
            this.radPageView1.Size = new System.Drawing.Size(1033, 546);
            this.radPageView1.TabIndex = 3;
            this.radPageView1.ThemeName = "FluentDark";
            this.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.NavigationView;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).DisplayMode = Telerik.WinControls.UI.NavigationViewDisplayModes.Expanded;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).CollapsedPaneWidth = 60;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).ItemExpandCollapseMode = Telerik.WinControls.UI.NavigationViewItemExpandCollapseMode.OnExpanderClick;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).HierarchyPopupExpandMode = Telerik.WinControls.UI.NavigationViewHierarchyPopupExpandMode.OnItemClick;
            // 
            // pvpChangeWeid
            // 
            this.pvpChangeWeid.BackColor = System.Drawing.Color.Gray;
            this.pvpChangeWeid.Controls.Add(this.rcvWeid);
            this.pvpChangeWeid.Controls.Add(this.radCommandBar1);
            this.pvpChangeWeid.Controls.Add(this.radPanel1);
            this.pvpChangeWeid.ItemSize = new System.Drawing.SizeF(145F, 39F);
            this.pvpChangeWeid.Location = new System.Drawing.Point(281, 37);
            this.pvpChangeWeid.Name = "pvpChangeWeid";
            this.pvpChangeWeid.Size = new System.Drawing.Size(751, 508);
            this.pvpChangeWeid.Text = "Изменение веса";
            // 
            // rcvWeid
            // 
            this.rcvWeid.AreaDesign = cartesianArea1;
            categoricalAxis1.IsPrimary = true;
            categoricalAxis1.Title = "Дата";
            linearAxis1.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            linearAxis1.IsPrimary = true;
            linearAxis1.TickOrigin = null;
            linearAxis1.Title = "Вес";
            this.rcvWeid.Axes.AddRange(new Telerik.WinControls.UI.Axis[] {
            categoricalAxis1,
            linearAxis1});
            this.rcvWeid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rcvWeid.Location = new System.Drawing.Point(0, 31);
            this.rcvWeid.Name = "rcvWeid";
            lineSeries1.CategoryMember = "dt";
            lineSeries1.HorizontalAxis = categoricalAxis1;
            lineSeries1.ValueMember = "weid";
            lineSeries1.VerticalAxis = linearAxis1;
            lineSeries2.HorizontalAxis = categoricalAxis1;
            lineSeries2.VerticalAxis = linearAxis1;
            this.rcvWeid.Series.AddRange(new Telerik.WinControls.UI.ChartSeries[] {
            lineSeries1,
            lineSeries2});
            this.rcvWeid.ShowGrid = false;
            this.rcvWeid.Size = new System.Drawing.Size(751, 377);
            this.rcvWeid.TabIndex = 9;
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(751, 31);
            this.radCommandBar1.TabIndex = 8;
            this.radCommandBar1.ThemeName = "FluentDark";
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Name = "commandBarRowElement1";
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            this.commandBarRowElement1.Text = "";
            this.commandBarRowElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElement1.UseCompatibleTextRendering = false;
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.cbbTable,
            this.cbbGraph,
            this.cbbExport});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.StretchHorizontally = false;
            this.commandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement1.UseCompatibleTextRendering = false;
            // 
            // cbbTable
            // 
            this.cbbTable.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cbbTable.DisplayName = "commandBarButton1";
            this.cbbTable.DrawText = true;
            this.cbbTable.Image = ((System.Drawing.Image)(resources.GetObject("cbbTable.Image")));
            this.cbbTable.Name = "cbbTable";
            this.cbbTable.Text = "Таблица";
            this.cbbTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cbbTable.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cbbTable.UseCompatibleTextRendering = false;
            // 
            // cbbGraph
            // 
            this.cbbGraph.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cbbGraph.DisplayName = "commandBarButton2";
            this.cbbGraph.DrawText = true;
            this.cbbGraph.Image = ((System.Drawing.Image)(resources.GetObject("cbbGraph.Image")));
            this.cbbGraph.Name = "cbbGraph";
            this.cbbGraph.Text = "График";
            this.cbbGraph.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cbbGraph.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cbbGraph.UseCompatibleTextRendering = false;
            // 
            // cbbExport
            // 
            this.cbbExport.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cbbExport.DisplayName = "commandBarButton3";
            this.cbbExport.DrawText = true;
            this.cbbExport.Image = ((System.Drawing.Image)(resources.GetObject("cbbExport.Image")));
            this.cbbExport.Name = "cbbExport";
            this.cbbExport.Text = "Скачать";
            this.cbbExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cbbExport.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cbbExport.UseCompatibleTextRendering = false;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Controls.Add(this.seDate);
            this.radPanel1.Controls.Add(this.seWeid);
            this.radPanel1.Controls.Add(this.bInsertChange);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel1.Location = new System.Drawing.Point(0, 408);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(751, 100);
            this.radPanel1.TabIndex = 4;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel2.ForeColor = System.Drawing.Color.Black;
            this.radLabel2.Location = new System.Drawing.Point(236, 37);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(48, 25);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Дата";
            // 
            // seDate
            // 
            this.seDate.CalendarSize = new System.Drawing.Size(290, 320);
            this.seDate.Location = new System.Drawing.Point(321, 31);
            this.seDate.Name = "seDate";
            this.seDate.Size = new System.Drawing.Size(198, 36);
            this.seDate.TabIndex = 4;
            this.seDate.TabStop = false;
            this.seDate.Text = "18 ноября 2022 г.";
            this.seDate.ThemeName = "MaterialBlueGrey";
            this.seDate.Value = new System.DateTime(2022, 11, 18, 23, 9, 29, 552);
            // 
            // seWeid
            // 
            this.seWeid.Location = new System.Drawing.Point(99, 31);
            this.seWeid.Name = "seWeid";
            this.seWeid.Size = new System.Drawing.Size(100, 36);
            this.seWeid.TabIndex = 3;
            this.seWeid.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.seWeid.ThemeName = "MaterialBlueGrey";
            // 
            // bInsertChange
            // 
            this.bInsertChange.Location = new System.Drawing.Point(556, 21);
            this.bInsertChange.Name = "bInsertChange";
            this.bInsertChange.Size = new System.Drawing.Size(182, 57);
            this.bInsertChange.TabIndex = 1;
            this.bInsertChange.Text = "Добавить/Изменить";
            this.bInsertChange.ThemeName = "MaterialBlueGrey";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel1.ForeColor = System.Drawing.Color.Black;
            this.radLabel1.Location = new System.Drawing.Point(25, 37);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(37, 25);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Вес";
            // 
            // pvpEat
            // 
            this.pvpEat.BackColor = System.Drawing.Color.Gray;
            this.pvpEat.Controls.Add(this.rgvEat);
            this.pvpEat.ItemSize = new System.Drawing.SizeF(145F, 39F);
            this.pvpEat.Location = new System.Drawing.Point(281, 37);
            this.pvpEat.Name = "pvpEat";
            this.pvpEat.Size = new System.Drawing.Size(751, 508);
            this.pvpEat.Text = "Питание";
            // 
            // rgvEat
            // 
            this.rgvEat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rgvEat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rgvEat.Location = new System.Drawing.Point(0, 218);
            // 
            // 
            // 
            gridViewDateTimeColumn1.HeaderText = "Дата";
            gridViewDateTimeColumn1.Name = "column1";
            gridViewDateTimeColumn1.Width = 165;
            gridViewTextBoxColumn1.HeaderText = "Продукты";
            gridViewTextBoxColumn1.Multiline = true;
            gridViewTextBoxColumn1.Name = "column2";
            gridViewTextBoxColumn1.Width = 370;
            gridViewDecimalColumn1.HeaderText = "Вес";
            gridViewDecimalColumn1.Name = "column3";
            gridViewDecimalColumn1.Width = 100;
            gridViewTextBoxColumn2.HeaderText = "Изменение";
            gridViewTextBoxColumn2.Name = "column4";
            gridViewTextBoxColumn2.Width = 100;
            this.rgvEat.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn1,
            gridViewDecimalColumn1,
            gridViewTextBoxColumn2});
            this.rgvEat.MasterTemplate.ShowRowHeaderColumn = false;
            this.rgvEat.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvEat.Name = "rgvEat";
            this.rgvEat.ReadOnly = true;
            this.rgvEat.ShowGroupPanel = false;
            this.rgvEat.Size = new System.Drawing.Size(751, 290);
            this.rgvEat.TabIndex = 0;
            this.rgvEat.ThemeName = "MaterialBlueGrey";
            // 
            // pvpCalcEat
            // 
            this.pvpCalcEat.BackColor = System.Drawing.Color.Gray;
            this.pvpCalcEat.ItemSize = new System.Drawing.SizeF(145F, 39F);
            this.pvpCalcEat.Location = new System.Drawing.Point(281, 37);
            this.pvpCalcEat.Name = "pvpCalcEat";
            this.pvpCalcEat.Size = new System.Drawing.Size(751, 508);
            this.pvpCalcEat.Text = "Расчет питания";
            // 
            // pvpBuyEat
            // 
            this.pvpBuyEat.BackColor = System.Drawing.Color.Gray;
            this.pvpBuyEat.ItemSize = new System.Drawing.SizeF(145F, 39F);
            this.pvpBuyEat.Location = new System.Drawing.Point(281, 37);
            this.pvpBuyEat.Name = "pvpBuyEat";
            this.pvpBuyEat.Size = new System.Drawing.Size(751, 508);
            this.pvpBuyEat.Text = "Заказ еды";
            // 
            // MenuLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 546);
            this.Controls.Add(this.radPageView1);
            this.Name = "MenuLog";
            this.Text = "";
            this.ThemeName = "FluentDark";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuLog_FormClosed);
            this.Load += new System.EventHandler(this.MenuLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.pvpChangeWeid.ResumeLayout(false);
            this.pvpChangeWeid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rcvWeid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seWeid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bInsertChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.pvpEat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgvEat.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvEat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage pvpChangeWeid;
        private Telerik.WinControls.UI.RadChartView rcvWeid;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton cbbTable;
        private Telerik.WinControls.UI.CommandBarButton cbbGraph;
        private Telerik.WinControls.UI.CommandBarButton cbbExport;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDateTimePicker seDate;
        private Telerik.WinControls.UI.RadSpinEditor seWeid;
        private Telerik.WinControls.UI.RadButton bInsertChange;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPageViewPage pvpEat;
        private Telerik.WinControls.UI.RadGridView rgvEat;
        private Telerik.WinControls.UI.RadPageViewPage pvpCalcEat;
        private Telerik.WinControls.UI.RadPageViewPage pvpBuyEat;
    }
}
