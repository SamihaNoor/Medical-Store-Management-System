namespace App
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.top_panel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.medicalStore_Label = new Bunifu.UI.WinForms.BunifuLabel();
            this.profits = new Bunifu.Framework.UI.BunifuTileButton();
            this.sellingPoint = new Bunifu.Framework.UI.BunifuTileButton();
            this.manage_meds = new Bunifu.Framework.UI.BunifuTileButton();
            this.sale = new Bunifu.Framework.UI.BunifuTileButton();
            this.manage_emps = new Bunifu.Framework.UI.BunifuTileButton();
            this.settings = new Bunifu.Framework.UI.BunifuTileButton();
            this.cust_history = new Bunifu.Framework.UI.BunifuTileButton();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("top_panel.BackgroundImage")));
            this.top_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top_panel.Controls.Add(this.pictureBox1);
            this.top_panel.Controls.Add(this.logout);
            this.top_panel.Controls.Add(this.medicalStore_Label);
            this.top_panel.GradientBottomLeft = System.Drawing.Color.White;
            this.top_panel.GradientBottomRight = System.Drawing.Color.White;
            this.top_panel.GradientTopLeft = System.Drawing.Color.DarkMagenta;
            this.top_panel.GradientTopRight = System.Drawing.Color.DarkMagenta;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Quality = 10;
            this.top_panel.Size = new System.Drawing.Size(1200, 200);
            this.top_panel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(522, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 91);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
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
            this.logout.IconZoom = 92D;
            this.logout.IsTab = false;
            this.logout.Location = new System.Drawing.Point(1072, 20);
            this.logout.Name = "logout";
            this.logout.Normalcolor = System.Drawing.Color.Purple;
            this.logout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.logout.OnHoverTextColor = System.Drawing.Color.White;
            this.logout.selected = false;
            this.logout.Size = new System.Drawing.Size(100, 28);
            this.logout.TabIndex = 17;
            this.logout.Text = "Logout";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logout.Textcolor = System.Drawing.Color.White;
            this.logout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // medicalStore_Label
            // 
            this.medicalStore_Label.AutoEllipsis = false;
            this.medicalStore_Label.CursorType = null;
            this.medicalStore_Label.Font = new System.Drawing.Font("Segoe UI", 69.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicalStore_Label.Location = new System.Drawing.Point(314, 40);
            this.medicalStore_Label.Name = "medicalStore_Label";
            this.medicalStore_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.medicalStore_Label.Size = new System.Drawing.Size(568, 126);
            this.medicalStore_Label.TabIndex = 15;
            this.medicalStore_Label.Text = "Medical Store";
            this.medicalStore_Label.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.medicalStore_Label.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // profits
            // 
            this.profits.BackColor = System.Drawing.Color.Purple;
            this.profits.color = System.Drawing.Color.Purple;
            this.profits.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.profits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profits.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profits.ForeColor = System.Drawing.Color.White;
            this.profits.Image = ((System.Drawing.Image)(resources.GetObject("profits.Image")));
            this.profits.ImagePosition = 25;
            this.profits.ImageZoom = 50;
            this.profits.LabelPosition = 51;
            this.profits.LabelText = "Profits";
            this.profits.Location = new System.Drawing.Point(505, 484);
            this.profits.Margin = new System.Windows.Forms.Padding(6);
            this.profits.Name = "profits";
            this.profits.Size = new System.Drawing.Size(166, 151);
            this.profits.TabIndex = 6;
            this.profits.Click += new System.EventHandler(this.profits_Click);
            // 
            // sellingPoint
            // 
            this.sellingPoint.BackColor = System.Drawing.Color.Purple;
            this.sellingPoint.color = System.Drawing.Color.Purple;
            this.sellingPoint.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.sellingPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellingPoint.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellingPoint.ForeColor = System.Drawing.Color.White;
            this.sellingPoint.Image = ((System.Drawing.Image)(resources.GetObject("sellingPoint.Image")));
            this.sellingPoint.ImagePosition = 25;
            this.sellingPoint.ImageZoom = 50;
            this.sellingPoint.LabelPosition = 51;
            this.sellingPoint.LabelText = "SellingPoint";
            this.sellingPoint.Location = new System.Drawing.Point(338, 327);
            this.sellingPoint.Margin = new System.Windows.Forms.Padding(6);
            this.sellingPoint.Name = "sellingPoint";
            this.sellingPoint.Size = new System.Drawing.Size(166, 151);
            this.sellingPoint.TabIndex = 5;
            this.sellingPoint.Click += new System.EventHandler(this.sellingPoint_Click);
            // 
            // manage_meds
            // 
            this.manage_meds.BackColor = System.Drawing.Color.Purple;
            this.manage_meds.color = System.Drawing.Color.Purple;
            this.manage_meds.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.manage_meds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manage_meds.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manage_meds.ForeColor = System.Drawing.Color.White;
            this.manage_meds.Image = ((System.Drawing.Image)(resources.GetObject("manage_meds.Image")));
            this.manage_meds.ImagePosition = 25;
            this.manage_meds.ImageZoom = 50;
            this.manage_meds.LabelPosition = 51;
            this.manage_meds.LabelText = "Medicines";
            this.manage_meds.Location = new System.Drawing.Point(840, 484);
            this.manage_meds.Margin = new System.Windows.Forms.Padding(6);
            this.manage_meds.Name = "manage_meds";
            this.manage_meds.Size = new System.Drawing.Size(166, 151);
            this.manage_meds.TabIndex = 8;
            this.manage_meds.Click += new System.EventHandler(this.manage_meds_Click_1);
            // 
            // sale
            // 
            this.sale.BackColor = System.Drawing.Color.Purple;
            this.sale.color = System.Drawing.Color.Purple;
            this.sale.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.sale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sale.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale.ForeColor = System.Drawing.Color.White;
            this.sale.Image = ((System.Drawing.Image)(resources.GetObject("sale.Image")));
            this.sale.ImagePosition = 25;
            this.sale.ImageZoom = 50;
            this.sale.LabelPosition = 51;
            this.sale.LabelText = "Sales";
            this.sale.Location = new System.Drawing.Point(673, 327);
            this.sale.Margin = new System.Windows.Forms.Padding(6);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(166, 151);
            this.sale.TabIndex = 7;
            this.sale.Click += new System.EventHandler(this.sale_Click);
            // 
            // manage_emps
            // 
            this.manage_emps.BackColor = System.Drawing.Color.Purple;
            this.manage_emps.color = System.Drawing.Color.Purple;
            this.manage_emps.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.manage_emps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manage_emps.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manage_emps.ForeColor = System.Drawing.Color.White;
            this.manage_emps.Image = ((System.Drawing.Image)(resources.GetObject("manage_emps.Image")));
            this.manage_emps.ImagePosition = 25;
            this.manage_emps.ImageZoom = 50;
            this.manage_emps.LabelPosition = 51;
            this.manage_emps.LabelText = "Employees";
            this.manage_emps.Location = new System.Drawing.Point(1006, 327);
            this.manage_emps.Margin = new System.Windows.Forms.Padding(6);
            this.manage_emps.Name = "manage_emps";
            this.manage_emps.Size = new System.Drawing.Size(166, 151);
            this.manage_emps.TabIndex = 9;
            this.manage_emps.Click += new System.EventHandler(this.manage_emps_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.Purple;
            this.settings.color = System.Drawing.Color.Purple;
            this.settings.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings.ForeColor = System.Drawing.Color.White;
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.ImagePosition = 25;
            this.settings.ImageZoom = 50;
            this.settings.LabelPosition = 51;
            this.settings.LabelText = "Settings";
            this.settings.Location = new System.Drawing.Point(8, 327);
            this.settings.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(165, 151);
            this.settings.TabIndex = 11;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // cust_history
            // 
            this.cust_history.BackColor = System.Drawing.Color.Purple;
            this.cust_history.color = System.Drawing.Color.Purple;
            this.cust_history.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cust_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cust_history.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_history.ForeColor = System.Drawing.Color.White;
            this.cust_history.Image = ((System.Drawing.Image)(resources.GetObject("cust_history.Image")));
            this.cust_history.ImagePosition = 25;
            this.cust_history.ImageZoom = 50;
            this.cust_history.LabelPosition = 51;
            this.cust_history.LabelText = "History";
            this.cust_history.Location = new System.Drawing.Point(173, 484);
            this.cust_history.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.cust_history.Name = "cust_history";
            this.cust_history.Size = new System.Drawing.Size(164, 153);
            this.cust_history.TabIndex = 10;
            this.cust_history.Click += new System.EventHandler(this.cust_history_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.cust_history);
            this.Controls.Add(this.manage_emps);
            this.Controls.Add(this.manage_meds);
            this.Controls.Add(this.sale);
            this.Controls.Add(this.profits);
            this.Controls.Add(this.sellingPoint);
            this.Controls.Add(this.top_panel);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel top_panel;
        private Bunifu.Framework.UI.BunifuTileButton profits;
        private Bunifu.Framework.UI.BunifuTileButton sellingPoint;
        private Bunifu.Framework.UI.BunifuTileButton manage_meds;
        private Bunifu.Framework.UI.BunifuTileButton sale;
        private Bunifu.Framework.UI.BunifuTileButton manage_emps;
        private Bunifu.Framework.UI.BunifuTileButton settings;
        private Bunifu.Framework.UI.BunifuTileButton cust_history;
        private Bunifu.UI.WinForms.BunifuLabel medicalStore_Label;
        private Bunifu.Framework.UI.BunifuFlatButton logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        
    }
}