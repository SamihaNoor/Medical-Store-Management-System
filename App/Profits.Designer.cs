namespace App
{
    partial class Profits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profits));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.show_chart = new Bunifu.Framework.UI.BunifuFlatButton();
            this.toDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.fromDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.top_panel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.back = new Bunifu.Framework.UI.BunifuFlatButton();
            this.medicalStore_Label = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.weekly_profit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.sidePanel.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekly_profit)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.DarkMagenta;
            this.sidePanel.Controls.Add(this.show_chart);
            this.sidePanel.Controls.Add(this.toDate);
            this.sidePanel.Controls.Add(this.fromDate);
            this.sidePanel.Location = new System.Drawing.Point(0, 200);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(165, 460);
            this.sidePanel.TabIndex = 5;
            // 
            // show_chart
            // 
            this.show_chart.Active = false;
            this.show_chart.Activecolor = System.Drawing.Color.Indigo;
            this.show_chart.BackColor = System.Drawing.Color.Purple;
            this.show_chart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.show_chart.BorderRadius = 0;
            this.show_chart.ButtonText = "Show Chart";
            this.show_chart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_chart.DisabledColor = System.Drawing.Color.Gray;
            this.show_chart.Iconcolor = System.Drawing.Color.Transparent;
            this.show_chart.Iconimage = null;
            this.show_chart.Iconimage_right = null;
            this.show_chart.Iconimage_right_Selected = null;
            this.show_chart.Iconimage_Selected = null;
            this.show_chart.IconMarginLeft = 0;
            this.show_chart.IconMarginRight = 0;
            this.show_chart.IconRightVisible = true;
            this.show_chart.IconRightZoom = 0D;
            this.show_chart.IconVisible = true;
            this.show_chart.IconZoom = 90D;
            this.show_chart.IsTab = false;
            this.show_chart.Location = new System.Drawing.Point(0, 234);
            this.show_chart.Name = "show_chart";
            this.show_chart.Normalcolor = System.Drawing.Color.Purple;
            this.show_chart.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.show_chart.OnHoverTextColor = System.Drawing.Color.White;
            this.show_chart.selected = false;
            this.show_chart.Size = new System.Drawing.Size(165, 48);
            this.show_chart.TabIndex = 8;
            this.show_chart.Text = "Show Chart";
            this.show_chart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.show_chart.Textcolor = System.Drawing.Color.White;
            this.show_chart.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_chart.Click += new System.EventHandler(this.show_chart_Click);
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
            this.toDate.Location = new System.Drawing.Point(2, 176);
            this.toDate.MinimumSize = new System.Drawing.Size(117, 35);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(160, 35);
            this.toDate.TabIndex = 18;
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
            this.fromDate.Location = new System.Drawing.Point(2, 121);
            this.fromDate.MinimumSize = new System.Drawing.Size(117, 35);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(160, 35);
            this.fromDate.TabIndex = 17;
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
            this.top_panel.TabIndex = 6;
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
            this.logout.Location = new System.Drawing.Point(1055, 18);
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
            this.back.Location = new System.Drawing.Point(16, 18);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.weekly_profit);
            this.panel1.Location = new System.Drawing.Point(345, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 382);
            this.panel1.TabIndex = 7;
            // 
            // weekly_profit
            // 
            this.weekly_profit.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.weekly_profit.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.weekly_profit.Legends.Add(legend1);
            this.weekly_profit.Location = new System.Drawing.Point(32, 3);
            this.weekly_profit.Name = "weekly_profit";
            this.weekly_profit.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Income";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.weekly_profit.Series.Add(series1);
            this.weekly_profit.Size = new System.Drawing.Size(695, 368);
            this.weekly_profit.TabIndex = 0;
            this.weekly_profit.Text = "weekly";
            // 
            // Profits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.sidePanel);
            this.Name = "Profits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profits";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Profits_FormClosing);
            this.sidePanel.ResumeLayout(false);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weekly_profit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private Bunifu.Framework.UI.BunifuGradientPanel top_panel;
        private Bunifu.UI.WinForms.BunifuLabel medicalStore_Label;
        private Bunifu.Framework.UI.BunifuFlatButton logout;
        private Bunifu.Framework.UI.BunifuFlatButton back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart weekly_profit;
        private Bunifu.UI.WinForms.BunifuDatePicker toDate;
        private Bunifu.UI.WinForms.BunifuDatePicker fromDate;
        private Bunifu.Framework.UI.BunifuFlatButton show_chart;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}