namespace App
{
    partial class CustomerHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.top_panel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.back = new Bunifu.Framework.UI.BunifuFlatButton();
            this.medicalStore_Label = new Bunifu.UI.WinForms.BunifuLabel();
            this.custHistory_table = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.search_tb = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.showAll_bt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custHistory_table)).BeginInit();
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
            this.top_panel.TabIndex = 2;
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
            this.logout.IconZoom = 100D;
            this.logout.IsTab = false;
            this.logout.Location = new System.Drawing.Point(1055, 17);
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
            this.back.IconZoom = 80D;
            this.back.IsTab = false;
            this.back.Location = new System.Drawing.Point(16, 17);
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
            this.medicalStore_Label.Location = new System.Drawing.Point(311, 17);
            this.medicalStore_Label.Name = "medicalStore_Label";
            this.medicalStore_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.medicalStore_Label.Size = new System.Drawing.Size(568, 126);
            this.medicalStore_Label.TabIndex = 14;
            this.medicalStore_Label.Text = "Medical Store";
            this.medicalStore_Label.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.medicalStore_Label.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // custHistory_table
            // 
            this.custHistory_table.AllowCustomTheming = false;
            this.custHistory_table.AllowUserToAddRows = false;
            this.custHistory_table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.custHistory_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.custHistory_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.custHistory_table.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.custHistory_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custHistory_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.custHistory_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custHistory_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.custHistory_table.ColumnHeadersHeight = 40;
            this.custHistory_table.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.custHistory_table.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.custHistory_table.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.custHistory_table.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Thistle;
            this.custHistory_table.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.custHistory_table.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.custHistory_table.CurrentTheme.GridColor = System.Drawing.Color.MediumOrchid;
            this.custHistory_table.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.MediumOrchid;
            this.custHistory_table.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.custHistory_table.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.custHistory_table.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.MediumOrchid;
            this.custHistory_table.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.custHistory_table.CurrentTheme.Name = null;
            this.custHistory_table.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.custHistory_table.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.custHistory_table.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.custHistory_table.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.Lavender;
            this.custHistory_table.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.custHistory_table.DefaultCellStyle = dataGridViewCellStyle3;
            this.custHistory_table.EnableHeadersVisualStyles = false;
            this.custHistory_table.GridColor = System.Drawing.Color.Thistle;
            this.custHistory_table.HeaderBackColor = System.Drawing.Color.MediumOrchid;
            this.custHistory_table.HeaderBgColor = System.Drawing.Color.Empty;
            this.custHistory_table.HeaderForeColor = System.Drawing.Color.White;
            this.custHistory_table.Location = new System.Drawing.Point(169, 310);
            this.custHistory_table.Name = "custHistory_table";
            this.custHistory_table.ReadOnly = true;
            this.custHistory_table.RowHeadersVisible = false;
            this.custHistory_table.RowTemplate.Height = 40;
            this.custHistory_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.custHistory_table.Size = new System.Drawing.Size(862, 282);
            this.custHistory_table.TabIndex = 3;
            this.custHistory_table.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // search_tb
            // 
            this.search_tb.AcceptsReturn = false;
            this.search_tb.AcceptsTab = false;
            this.search_tb.AnimationSpeed = 200;
            this.search_tb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.search_tb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.search_tb.BackColor = System.Drawing.Color.Transparent;
            this.search_tb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_tb.BackgroundImage")));
            this.search_tb.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.search_tb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.search_tb.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.search_tb.BorderColorIdle = System.Drawing.Color.Silver;
            this.search_tb.BorderRadius = 1;
            this.search_tb.BorderThickness = 1;
            this.search_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.search_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_tb.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.search_tb.DefaultText = "";
            this.search_tb.FillColor = System.Drawing.Color.White;
            this.search_tb.HideSelection = true;
            this.search_tb.IconLeft = ((System.Drawing.Image)(resources.GetObject("search_tb.IconLeft")));
            this.search_tb.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.search_tb.IconPadding = 2;
            this.search_tb.IconRight = null;
            this.search_tb.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.search_tb.Lines = new string[0];
            this.search_tb.Location = new System.Drawing.Point(169, 256);
            this.search_tb.MaxLength = 32767;
            this.search_tb.MinimumSize = new System.Drawing.Size(1, 1);
            this.search_tb.Modified = false;
            this.search_tb.Multiline = false;
            this.search_tb.Name = "search_tb";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search_tb.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.search_tb.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search_tb.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search_tb.OnIdleState = stateProperties4;
            this.search_tb.PasswordChar = '\0';
            this.search_tb.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.search_tb.PlaceholderText = "Search";
            this.search_tb.ReadOnly = false;
            this.search_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.search_tb.SelectedText = "";
            this.search_tb.SelectionLength = 0;
            this.search_tb.SelectionStart = 0;
            this.search_tb.ShortcutsEnabled = true;
            this.search_tb.Size = new System.Drawing.Size(735, 35);
            this.search_tb.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.search_tb.TabIndex = 4;
            this.search_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.search_tb.TextMarginBottom = 0;
            this.search_tb.TextMarginLeft = 5;
            this.search_tb.TextMarginTop = 0;
            this.search_tb.TextPlaceholder = "Search";
            this.search_tb.UseSystemPasswordChar = false;
            this.search_tb.WordWrap = true;
            this.search_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_tb_KeyDown);
            // 
            // showAll_bt
            // 
            this.showAll_bt.AllowToggling = false;
            this.showAll_bt.AnimationSpeed = 200;
            this.showAll_bt.AutoGenerateColors = false;
            this.showAll_bt.BackColor = System.Drawing.Color.Transparent;
            this.showAll_bt.BackColor1 = System.Drawing.Color.DarkMagenta;
            this.showAll_bt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showAll_bt.BackgroundImage")));
            this.showAll_bt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.showAll_bt.ButtonText = "Show All";
            this.showAll_bt.ButtonTextMarginLeft = 0;
            this.showAll_bt.ColorContrastOnClick = 45;
            this.showAll_bt.ColorContrastOnHover = 45;
            this.showAll_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.showAll_bt.CustomizableEdges = borderEdges1;
            this.showAll_bt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.showAll_bt.DisabledBorderColor = System.Drawing.Color.Empty;
            this.showAll_bt.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.showAll_bt.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.showAll_bt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.showAll_bt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.showAll_bt.ForeColor = System.Drawing.Color.White;
            this.showAll_bt.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.showAll_bt.IconMarginLeft = 11;
            this.showAll_bt.IconPadding = 10;
            this.showAll_bt.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.showAll_bt.IdleBorderColor = System.Drawing.Color.DarkMagenta;
            this.showAll_bt.IdleBorderRadius = 3;
            this.showAll_bt.IdleBorderThickness = 1;
            this.showAll_bt.IdleFillColor = System.Drawing.Color.DarkMagenta;
            this.showAll_bt.IdleIconLeftImage = null;
            this.showAll_bt.IdleIconRightImage = null;
            this.showAll_bt.IndicateFocus = false;
            this.showAll_bt.Location = new System.Drawing.Point(910, 256);
            this.showAll_bt.Name = "showAll_bt";
            this.showAll_bt.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.showAll_bt.onHoverState.BorderRadius = 3;
            this.showAll_bt.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.showAll_bt.onHoverState.BorderThickness = 1;
            this.showAll_bt.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.showAll_bt.onHoverState.ForeColor = System.Drawing.Color.White;
            this.showAll_bt.onHoverState.IconLeftImage = null;
            this.showAll_bt.onHoverState.IconRightImage = null;
            this.showAll_bt.OnIdleState.BorderColor = System.Drawing.Color.DarkMagenta;
            this.showAll_bt.OnIdleState.BorderRadius = 3;
            this.showAll_bt.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.showAll_bt.OnIdleState.BorderThickness = 1;
            this.showAll_bt.OnIdleState.FillColor = System.Drawing.Color.DarkMagenta;
            this.showAll_bt.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.showAll_bt.OnIdleState.IconLeftImage = null;
            this.showAll_bt.OnIdleState.IconRightImage = null;
            this.showAll_bt.OnPressedState.BorderColor = System.Drawing.Color.Indigo;
            this.showAll_bt.OnPressedState.BorderRadius = 3;
            this.showAll_bt.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.showAll_bt.OnPressedState.BorderThickness = 1;
            this.showAll_bt.OnPressedState.FillColor = System.Drawing.Color.Indigo;
            this.showAll_bt.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.showAll_bt.OnPressedState.IconLeftImage = null;
            this.showAll_bt.OnPressedState.IconRightImage = null;
            this.showAll_bt.Size = new System.Drawing.Size(121, 35);
            this.showAll_bt.TabIndex = 5;
            this.showAll_bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showAll_bt.TextMarginLeft = 0;
            this.showAll_bt.UseDefaultRadiusAndThickness = true;
            this.showAll_bt.Click += new System.EventHandler(this.showAll_bt_Click);
            // 
            // CustomerHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.showAll_bt);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.custHistory_table);
            this.Controls.Add(this.top_panel);
            this.Name = "CustomerHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer History";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerHistory_FormClosing);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custHistory_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel top_panel;
        private Bunifu.UI.WinForms.BunifuDataGridView custHistory_table;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox search_tb;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton showAll_bt;
        private Bunifu.UI.WinForms.BunifuLabel medicalStore_Label;
        private Bunifu.Framework.UI.BunifuFlatButton logout;
        private Bunifu.Framework.UI.BunifuFlatButton back;
    }
}