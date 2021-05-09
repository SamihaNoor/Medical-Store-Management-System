namespace App
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.top_panel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.back = new Bunifu.Framework.UI.BunifuFlatButton();
            this.medicalStore_Label = new Bunifu.UI.WinForms.BunifuLabel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.toDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.fromDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.show = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.top_panel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("top_panel.BackgroundImage")));
            this.top_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top_panel.Controls.Add(this.logout);
            this.top_panel.Controls.Add(this.back);
            this.top_panel.Controls.Add(this.medicalStore_Label);
            this.top_panel.GradientBottomLeft = System.Drawing.Color.White;
            this.top_panel.GradientBottomRight = System.Drawing.Color.White;
            this.top_panel.GradientTopLeft = System.Drawing.Color.DarkMagenta;
            this.top_panel.GradientTopRight = System.Drawing.Color.DarkMagenta;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Quality = 10;
            this.top_panel.Size = new System.Drawing.Size(1200, 150);
            this.top_panel.TabIndex = 3;
            // 
            // logout
            // 
            this.logout.Active = false;
            this.logout.Activecolor = System.Drawing.Color.Indigo;
            this.logout.BackColor = System.Drawing.Color.Purple;
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.BorderRadius = 0;
            this.logout.ButtonText = "Logout";
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.DisabledColor = System.Drawing.Color.Gray;
            this.logout.Iconcolor = System.Drawing.Color.Transparent;
            this.logout.Iconimage = null;
            this.logout.Iconimage_right = null;
            this.logout.Iconimage_right_Selected = null;
            this.logout.Iconimage_Selected = null;
            this.logout.IconMarginLeft = 0;
            this.logout.IconMarginRight = 0;
            this.logout.IconRightVisible = true;
            this.logout.IconRightZoom = 0D;
            this.logout.IconVisible = true;
            this.logout.IconZoom = 90D;
            this.logout.IsTab = false;
            this.logout.Location = new System.Drawing.Point(1053, 18);
            this.logout.Name = "logout";
            this.logout.Normalcolor = System.Drawing.Color.Purple;
            this.logout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.logout.OnHoverTextColor = System.Drawing.Color.White;
            this.logout.selected = false;
            this.logout.Size = new System.Drawing.Size(100, 28);
            this.logout.TabIndex = 16;
            this.logout.Text = "Logout";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logout.Textcolor = System.Drawing.Color.White;
            this.logout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // back
            // 
            this.back.Active = false;
            this.back.Activecolor = System.Drawing.Color.Indigo;
            this.back.BackColor = System.Drawing.Color.Purple;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.BorderRadius = 0;
            this.back.ButtonText = "Back";
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.DisabledColor = System.Drawing.Color.Gray;
            this.back.Iconcolor = System.Drawing.Color.Transparent;
            this.back.Iconimage = null;
            this.back.Iconimage_right = null;
            this.back.Iconimage_right_Selected = null;
            this.back.Iconimage_Selected = null;
            this.back.IconMarginLeft = 0;
            this.back.IconMarginRight = 0;
            this.back.IconRightVisible = true;
            this.back.IconRightZoom = 0D;
            this.back.IconVisible = true;
            this.back.IconZoom = 90D;
            this.back.IsTab = false;
            this.back.Location = new System.Drawing.Point(14, 18);
            this.back.Name = "back";
            this.back.Normalcolor = System.Drawing.Color.Purple;
            this.back.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.back.OnHoverTextColor = System.Drawing.Color.White;
            this.back.selected = false;
            this.back.Size = new System.Drawing.Size(100, 28);
            this.back.TabIndex = 15;
            this.back.Text = "Back";
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.back.Textcolor = System.Drawing.Color.White;
            this.back.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // medicalStore_Label
            // 
            this.medicalStore_Label.AutoEllipsis = false;
            this.medicalStore_Label.CursorType = null;
            this.medicalStore_Label.Font = new System.Drawing.Font("Segoe UI", 69.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicalStore_Label.Location = new System.Drawing.Point(316, 18);
            this.medicalStore_Label.Name = "medicalStore_Label";
            this.medicalStore_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.medicalStore_Label.Size = new System.Drawing.Size(568, 126);
            this.medicalStore_Label.TabIndex = 14;
            this.medicalStore_Label.Text = "Medical Store";
            this.medicalStore_Label.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.medicalStore_Label.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.DarkMagenta;
            this.sidePanel.Controls.Add(this.toDate);
            this.sidePanel.Controls.Add(this.fromDate);
            this.sidePanel.Controls.Add(this.show);
            this.sidePanel.Location = new System.Drawing.Point(0, 200);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(165, 460);
            this.sidePanel.TabIndex = 4;
            // 
            // toDate
            // 
            this.toDate.BackColor = System.Drawing.Color.Purple;
            this.toDate.BorderRadius = 1;
            this.toDate.CustomFormat = "yyyy-MM-dd";
            this.toDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.toDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.toDate.DisabledColor = System.Drawing.Color.Gray;
            this.toDate.DisplayWeekNumbers = false;
            this.toDate.DPHeight = 0;
            this.toDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.toDate.FillDatePicker = false;
            this.toDate.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.ForeColor = System.Drawing.Color.White;
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDate.Icon = ((System.Drawing.Image)(resources.GetObject("toDate.Icon")));
            this.toDate.IconColor = System.Drawing.Color.White;
            this.toDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.toDate.Location = new System.Drawing.Point(2, 193);
            this.toDate.MinimumSize = new System.Drawing.Size(117, 35);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(160, 35);
            this.toDate.TabIndex = 16;
            // 
            // fromDate
            // 
            this.fromDate.BackColor = System.Drawing.Color.Purple;
            this.fromDate.BorderRadius = 1;
            this.fromDate.CustomFormat = "yyyy-MM-dd";
            this.fromDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.fromDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.fromDate.DisabledColor = System.Drawing.Color.Gray;
            this.fromDate.DisplayWeekNumbers = false;
            this.fromDate.DPHeight = 0;
            this.fromDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fromDate.FillDatePicker = false;
            this.fromDate.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.ForeColor = System.Drawing.Color.White;
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDate.Icon = ((System.Drawing.Image)(resources.GetObject("fromDate.Icon")));
            this.fromDate.IconColor = System.Drawing.Color.White;
            this.fromDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.fromDate.Location = new System.Drawing.Point(2, 138);
            this.fromDate.MinimumSize = new System.Drawing.Size(117, 35);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(160, 35);
            this.fromDate.TabIndex = 15;
            // 
            // show
            // 
            this.show.Active = false;
            this.show.Activecolor = System.Drawing.Color.Indigo;
            this.show.BackColor = System.Drawing.Color.Purple;
            this.show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.show.BorderRadius = 0;
            this.show.ButtonText = "Show Chart";
            this.show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show.DisabledColor = System.Drawing.Color.Gray;
            this.show.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.Iconcolor = System.Drawing.Color.Transparent;
            this.show.Iconimage = null;
            this.show.Iconimage_right = null;
            this.show.Iconimage_right_Selected = null;
            this.show.Iconimage_Selected = null;
            this.show.IconMarginLeft = 0;
            this.show.IconMarginRight = 0;
            this.show.IconRightVisible = true;
            this.show.IconRightZoom = 0D;
            this.show.IconVisible = true;
            this.show.IconZoom = 90D;
            this.show.IsTab = false;
            this.show.Location = new System.Drawing.Point(1, 248);
            this.show.Name = "show";
            this.show.Normalcolor = System.Drawing.Color.Purple;
            this.show.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.show.OnHoverTextColor = System.Drawing.Color.White;
            this.show.selected = false;
            this.show.Size = new System.Drawing.Size(162, 38);
            this.show.TabIndex = 9;
            this.show.Text = "Show Chart";
            this.show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.show.Textcolor = System.Drawing.Color.White;
            this.show.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Location = new System.Drawing.Point(310, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 444);
            this.panel2.TabIndex = 7;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(22, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Lavender,
        System.Drawing.Color.Plum,
        System.Drawing.Color.LavenderBlush,
        System.Drawing.Color.LightPink,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128))))),
        System.Drawing.Color.Azure,
        System.Drawing.Color.PaleGreen,
        System.Drawing.Color.NavajoWhite,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))),
        System.Drawing.Color.LightCoral};
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Quantity";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(689, 438);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.top_panel);
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sales_FormClosing);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel top_panel;
        private Bunifu.UI.WinForms.BunifuLabel medicalStore_Label;
        private System.Windows.Forms.Panel sidePanel;
        private Bunifu.Framework.UI.BunifuFlatButton logout;
        private Bunifu.Framework.UI.BunifuFlatButton back;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton show;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Bunifu.UI.WinForms.BunifuDatePicker fromDate;
        private Bunifu.UI.WinForms.BunifuDatePicker toDate;
    }
}