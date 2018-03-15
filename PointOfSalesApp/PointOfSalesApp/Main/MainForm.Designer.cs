namespace PointOfSalesApp.Main
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.appName2 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Transaction = new MetroFramework.Controls.MetroTabControl();
            this.tabDashboard = new MetroFramework.Controls.MetroTabPage();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.tileTealTransact = new MetroFramework.Controls.MetroTile();
            this.tileLimeSales = new MetroFramework.Controls.MetroTile();
            this.tabCshReg = new MetroFramework.Controls.MetroTabPage();
            this.tabInventory = new MetroFramework.Controls.MetroTabPage();
            this.tabSettings = new MetroFramework.Controls.MetroTabPage();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.tileCalendarIcon = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.tabImgDashboard = new MetroFramework.Controls.MetroTile();
            this.tileProduct = new MetroFramework.Controls.MetroTile();
            this.tileTransactions = new MetroFramework.Controls.MetroTile();
            this.tileSales = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCalendar = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTransactions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroPanel1.SuspendLayout();
            this.Transaction.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // appName2
            // 
            this.appName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.appName2.AutoSize = true;
            this.appName2.BackColor = System.Drawing.Color.Transparent;
            this.appName2.Font = new System.Drawing.Font("Helvetica Neue", 9.749999F);
            this.appName2.Location = new System.Drawing.Point(33, 10);
            this.appName2.Name = "appName2";
            this.appName2.Size = new System.Drawing.Size(280, 15);
            this.appName2.TabIndex = 3;
            this.appName2.Text = "MOTORPOINT Motorcyle Parts and Accesories";
            this.appName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lblCalendar);
            this.metroPanel1.Controls.Add(this.tileCalendarIcon);
            this.metroPanel1.Controls.Add(this.tabImgDashboard);
            this.metroPanel1.Controls.Add(this.Transaction);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(10, 31);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1331, 716);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Transaction
            // 
            this.Transaction.Controls.Add(this.tabDashboard);
            this.Transaction.Controls.Add(this.tabCshReg);
            this.Transaction.Controls.Add(this.tabInventory);
            this.Transaction.Controls.Add(this.tabSettings);
            this.Transaction.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.Transaction.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.Transaction.ItemSize = new System.Drawing.Size(135, 34);
            this.Transaction.Location = new System.Drawing.Point(15, 22);
            this.Transaction.Name = "Transaction";
            this.Transaction.SelectedIndex = 0;
            this.Transaction.Size = new System.Drawing.Size(1301, 682);
            this.Transaction.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Transaction.Style = MetroFramework.MetroColorStyle.Green;
            this.Transaction.TabIndex = 2;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.chart2);
            this.tabDashboard.Controls.Add(this.chartTransactions);
            this.tabDashboard.Controls.Add(this.chart1);
            this.tabDashboard.Controls.Add(this.metroTile4);
            this.tabDashboard.Controls.Add(this.tileTealTransact);
            this.tabDashboard.Controls.Add(this.tileLimeSales);
            this.tabDashboard.Controls.Add(this.tileProduct);
            this.tabDashboard.Controls.Add(this.tileTransactions);
            this.tabDashboard.Controls.Add(this.tileSales);
            this.tabDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDashboard.HorizontalScrollbarBarColor = true;
            this.tabDashboard.Location = new System.Drawing.Point(4, 38);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Size = new System.Drawing.Size(1293, 640);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "       Dashboard";
            this.tabDashboard.VerticalScrollbarBarColor = true;
            // 
            // metroTile4
            // 
            this.metroTile4.Location = new System.Drawing.Point(882, 101);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(408, 12);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile4.TabIndex = 7;
            // 
            // tileTealTransact
            // 
            this.tileTealTransact.Location = new System.Drawing.Point(450, 101);
            this.tileTealTransact.Name = "tileTealTransact";
            this.tileTealTransact.Size = new System.Drawing.Size(408, 12);
            this.tileTealTransact.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileTealTransact.TabIndex = 6;
            // 
            // tileLimeSales
            // 
            this.tileLimeSales.Location = new System.Drawing.Point(17, 101);
            this.tileLimeSales.Name = "tileLimeSales";
            this.tileLimeSales.Size = new System.Drawing.Size(408, 12);
            this.tileLimeSales.Style = MetroFramework.MetroColorStyle.Lime;
            this.tileLimeSales.TabIndex = 5;
            // 
            // tabCshReg
            // 
            this.tabCshReg.HorizontalScrollbarBarColor = true;
            this.tabCshReg.Location = new System.Drawing.Point(4, 38);
            this.tabCshReg.Name = "tabCshReg";
            this.tabCshReg.Padding = new System.Windows.Forms.Padding(1);
            this.tabCshReg.Size = new System.Drawing.Size(1293, 640);
            this.tabCshReg.TabIndex = 1;
            this.tabCshReg.Text = "     Cash Register";
            this.tabCshReg.VerticalScrollbarBarColor = true;
            // 
            // tabInventory
            // 
            this.tabInventory.HorizontalScrollbarBarColor = true;
            this.tabInventory.Location = new System.Drawing.Point(4, 38);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Size = new System.Drawing.Size(1293, 640);
            this.tabInventory.TabIndex = 2;
            this.tabInventory.Text = "       Inventory";
            this.tabInventory.VerticalScrollbarBarColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.HorizontalScrollbarBarColor = true;
            this.tabSettings.Location = new System.Drawing.Point(4, 38);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(1293, 640);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "    Settings";
            this.tabSettings.VerticalScrollbarBarColor = true;
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "dasboard 2.png");
            this.imgList.Images.SetKeyName(1, "cart2.png");
            this.imgList.Images.SetKeyName(2, "inventory.png");
            this.imgList.Images.SetKeyName(3, "Group 135.png");
            // 
            // metroTile1
            // 
            this.metroTile1.CustomBackground = true;
            this.metroTile1.CustomForeColor = true;
            this.metroTile1.Location = new System.Drawing.Point(426, 57);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(28, 27);
            this.metroTile1.TabIndex = 9;
            this.metroTile1.TileImage = global::PointOfSalesApp.Properties.Resources.Group_135;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseTileImage = true;
            // 
            // metroTile3
            // 
            this.metroTile3.CustomBackground = true;
            this.metroTile3.CustomForeColor = true;
            this.metroTile3.Location = new System.Drawing.Point(302, 58);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(28, 27);
            this.metroTile3.TabIndex = 8;
            this.metroTile3.TileImage = global::PointOfSalesApp.Properties.Resources.inventory;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseTileImage = true;
            // 
            // tileCalendarIcon
            // 
            this.tileCalendarIcon.CustomBackground = true;
            this.tileCalendarIcon.CustomForeColor = true;
            this.tileCalendarIcon.Location = new System.Drawing.Point(980, 4);
            this.tileCalendarIcon.Name = "tileCalendarIcon";
            this.tileCalendarIcon.Size = new System.Drawing.Size(54, 52);
            this.tileCalendarIcon.TabIndex = 10;
            this.tileCalendarIcon.Text = "                ";
            this.tileCalendarIcon.TileImage = global::PointOfSalesApp.Properties.Resources.calendar_2x1;
            this.tileCalendarIcon.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileCalendarIcon.UseTileImage = true;
            // 
            // metroTile2
            // 
            this.metroTile2.CustomBackground = true;
            this.metroTile2.CustomForeColor = true;
            this.metroTile2.Location = new System.Drawing.Point(158, 60);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(28, 27);
            this.metroTile2.TabIndex = 6;
            this.metroTile2.TileImage = global::PointOfSalesApp.Properties.Resources.cart2;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseTileImage = true;
            // 
            // tabImgDashboard
            // 
            this.tabImgDashboard.CustomBackground = true;
            this.tabImgDashboard.CustomForeColor = true;
            this.tabImgDashboard.Location = new System.Drawing.Point(27, 29);
            this.tabImgDashboard.Name = "tabImgDashboard";
            this.tabImgDashboard.Size = new System.Drawing.Size(28, 27);
            this.tabImgDashboard.TabIndex = 2;
            this.tabImgDashboard.TileImage = global::PointOfSalesApp.Properties.Resources.dasboard_2;
            this.tabImgDashboard.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabImgDashboard.UseTileImage = true;
            // 
            // tileProduct
            // 
            this.tileProduct.Location = new System.Drawing.Point(882, 14);
            this.tileProduct.Name = "tileProduct";
            this.tileProduct.Size = new System.Drawing.Size(408, 87);
            this.tileProduct.Style = MetroFramework.MetroColorStyle.Red;
            this.tileProduct.TabIndex = 4;
            this.tileProduct.Text = "Product";
            this.tileProduct.TileImage = global::PointOfSalesApp.Properties.Resources.prodicts;
            this.tileProduct.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileProduct.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileProduct.UseTileImage = true;
            // 
            // tileTransactions
            // 
            this.tileTransactions.Location = new System.Drawing.Point(450, 14);
            this.tileTransactions.Name = "tileTransactions";
            this.tileTransactions.Size = new System.Drawing.Size(408, 87);
            this.tileTransactions.Style = MetroFramework.MetroColorStyle.Blue;
            this.tileTransactions.TabIndex = 3;
            this.tileTransactions.Text = "Transactions";
            this.tileTransactions.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileTransactions.TileImage = global::PointOfSalesApp.Properties.Resources.transaction;
            this.tileTransactions.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileTransactions.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileTransactions.UseTileImage = true;
            // 
            // tileSales
            // 
            this.tileSales.Location = new System.Drawing.Point(17, 14);
            this.tileSales.Name = "tileSales";
            this.tileSales.Size = new System.Drawing.Size(408, 87);
            this.tileSales.Style = MetroFramework.MetroColorStyle.Green;
            this.tileSales.TabIndex = 2;
            this.tileSales.Text = "Sales";
            this.tileSales.TileImage = global::PointOfSalesApp.Properties.Resources.sales;
            this.tileSales.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSales.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileSales.UseTileImage = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PointOfSalesApp.Properties.Resources.cabildo_motor_parts_pos_icon16;
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 16);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCalendar
            // 
            this.lblCalendar.AutoSize = true;
            this.lblCalendar.Location = new System.Drawing.Point(1040, 4);
            this.lblCalendar.Name = "lblCalendar";
            this.lblCalendar.Size = new System.Drawing.Size(55, 19);
            this.lblCalendar.TabIndex = 10;
            this.lblCalendar.Text = "Today is";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(27, 190);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))))};
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.ShadowColor = System.Drawing.Color.DimGray;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(362, 238);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // chartTransactions
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTransactions.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartTransactions.Legends.Add(legend2);
            this.chartTransactions.Location = new System.Drawing.Point(465, 190);
            this.chartTransactions.Name = "chartTransactions";
            this.chartTransactions.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chartTransactions.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))))};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.ShadowColor = System.Drawing.Color.DimGray;
            this.chartTransactions.Series.Add(series2);
            this.chartTransactions.Size = new System.Drawing.Size(362, 238);
            this.chartTransactions.TabIndex = 9;
            this.chartTransactions.Text = "chart2";
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(914, 190);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chart2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.DimGray;
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(362, 238);
            this.chart2.TabIndex = 10;
            this.chart2.Text = "chart2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(2F, 5F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.appName2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(7, 60, 7, 7);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.Transaction.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label appName2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTabPage tabDashboard;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroTabControl Transaction;
        private MetroFramework.Controls.MetroTabPage tabCshReg;
        private MetroFramework.Controls.MetroTile tabImgDashboard;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.ImageList imgList;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTabPage tabInventory;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile tileSales;
        private MetroFramework.Controls.MetroTabPage tabSettings;
        private MetroFramework.Controls.MetroTile tileProduct;
        private MetroFramework.Controls.MetroTile tileTransactions;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile tileTealTransact;
        private MetroFramework.Controls.MetroTile tileLimeSales;
        private MetroFramework.Controls.MetroTile tileCalendarIcon;
        private MetroFramework.Controls.MetroLabel lblCalendar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTransactions;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}