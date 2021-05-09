namespace App
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.top_panel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.back = new Bunifu.Framework.UI.BunifuFlatButton();
            this.medicalStore_Label = new Bunifu.UI.WinForms.BunifuLabel();
            this.changePassword_Panel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.curShowPass = new Bunifu.UI.WinForms.BunifuImageButton();
            this.newShowPass = new Bunifu.UI.WinForms.BunifuImageButton();
            this.confirm_bt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.newPassword_tb = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.currentPassword_tb = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.top_panel.SuspendLayout();
            this.changePassword_Panel.SuspendLayout();
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
            this.logout.IconZoom = 90D;
            this.logout.IsTab = false;
            this.logout.Location = new System.Drawing.Point(1060, 18);
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
            this.back.Location = new System.Drawing.Point(21, 18);
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
            // changePassword_Panel
            // 
            this.changePassword_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changePassword_Panel.BackgroundImage")));
            this.changePassword_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changePassword_Panel.Controls.Add(this.curShowPass);
            this.changePassword_Panel.Controls.Add(this.newShowPass);
            this.changePassword_Panel.Controls.Add(this.confirm_bt);
            this.changePassword_Panel.Controls.Add(this.newPassword_tb);
            this.changePassword_Panel.Controls.Add(this.currentPassword_tb);
            this.changePassword_Panel.GradientBottomLeft = System.Drawing.Color.White;
            this.changePassword_Panel.GradientBottomRight = System.Drawing.Color.White;
            this.changePassword_Panel.GradientTopLeft = System.Drawing.Color.Thistle;
            this.changePassword_Panel.GradientTopRight = System.Drawing.Color.Thistle;
            this.changePassword_Panel.Location = new System.Drawing.Point(433, 305);
            this.changePassword_Panel.Name = "changePassword_Panel";
            this.changePassword_Panel.Quality = 10;
            this.changePassword_Panel.Size = new System.Drawing.Size(348, 213);
            this.changePassword_Panel.TabIndex = 3;
            // 
            // curShowPass
            // 
            this.curShowPass.ActiveImage = null;
            this.curShowPass.AllowAnimations = true;
            this.curShowPass.AllowBuffering = false;
            this.curShowPass.AllowZooming = true;
            this.curShowPass.BackColor = System.Drawing.Color.White;
            this.curShowPass.ErrorImage = ((System.Drawing.Image)(resources.GetObject("curShowPass.ErrorImage")));
            this.curShowPass.FadeWhenInactive = false;
            this.curShowPass.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.curShowPass.Image = ((System.Drawing.Image)(resources.GetObject("curShowPass.Image")));
            this.curShowPass.ImageActive = null;
            this.curShowPass.ImageLocation = null;
            this.curShowPass.ImageMargin = 0;
            this.curShowPass.ImageSize = new System.Drawing.Size(30, 26);
            this.curShowPass.ImageZoomSize = new System.Drawing.Size(30, 26);
            this.curShowPass.InitialImage = ((System.Drawing.Image)(resources.GetObject("curShowPass.InitialImage")));
            this.curShowPass.Location = new System.Drawing.Point(237, 36);
            this.curShowPass.Name = "curShowPass";
            this.curShowPass.Rotation = 0;
            this.curShowPass.ShowActiveImage = true;
            this.curShowPass.ShowCursorChanges = true;
            this.curShowPass.ShowImageBorders = true;
            this.curShowPass.ShowSizeMarkers = false;
            this.curShowPass.Size = new System.Drawing.Size(30, 26);
            this.curShowPass.TabIndex = 6;
            this.curShowPass.ToolTipText = "";
            this.curShowPass.WaitOnLoad = false;
            this.curShowPass.Zoom = 0;
            this.curShowPass.ZoomSpeed = 10;
            this.curShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.curShowPass_MouseDown);
            this.curShowPass.MouseLeave += new System.EventHandler(this.curShowPass_MouseLeave);
            // 
            // newShowPass
            // 
            this.newShowPass.ActiveImage = null;
            this.newShowPass.AllowAnimations = true;
            this.newShowPass.AllowBuffering = false;
            this.newShowPass.AllowZooming = true;
            this.newShowPass.BackColor = System.Drawing.Color.White;
            this.newShowPass.ErrorImage = ((System.Drawing.Image)(resources.GetObject("newShowPass.ErrorImage")));
            this.newShowPass.FadeWhenInactive = false;
            this.newShowPass.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.newShowPass.Image = ((System.Drawing.Image)(resources.GetObject("newShowPass.Image")));
            this.newShowPass.ImageActive = null;
            this.newShowPass.ImageLocation = null;
            this.newShowPass.ImageMargin = 0;
            this.newShowPass.ImageSize = new System.Drawing.Size(30, 26);
            this.newShowPass.ImageZoomSize = new System.Drawing.Size(30, 26);
            this.newShowPass.InitialImage = ((System.Drawing.Image)(resources.GetObject("newShowPass.InitialImage")));
            this.newShowPass.Location = new System.Drawing.Point(237, 96);
            this.newShowPass.Name = "newShowPass";
            this.newShowPass.Rotation = 0;
            this.newShowPass.ShowActiveImage = true;
            this.newShowPass.ShowCursorChanges = true;
            this.newShowPass.ShowImageBorders = true;
            this.newShowPass.ShowSizeMarkers = false;
            this.newShowPass.Size = new System.Drawing.Size(30, 26);
            this.newShowPass.TabIndex = 5;
            this.newShowPass.ToolTipText = "";
            this.newShowPass.WaitOnLoad = false;
            this.newShowPass.Zoom = 0;
            this.newShowPass.ZoomSpeed = 10;
            this.newShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newShowPass_MouseDown);
            this.newShowPass.MouseLeave += new System.EventHandler(this.newShowPass_MouseLeave);
            // 
            // confirm_bt
            // 
            this.confirm_bt.AllowToggling = false;
            this.confirm_bt.AnimationSpeed = 200;
            this.confirm_bt.AutoGenerateColors = false;
            this.confirm_bt.BackColor = System.Drawing.Color.Transparent;
            this.confirm_bt.BackColor1 = System.Drawing.Color.DarkMagenta;
            this.confirm_bt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirm_bt.BackgroundImage")));
            this.confirm_bt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.confirm_bt.ButtonText = "Confirm";
            this.confirm_bt.ButtonTextMarginLeft = 0;
            this.confirm_bt.ColorContrastOnClick = 45;
            this.confirm_bt.ColorContrastOnHover = 45;
            this.confirm_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.confirm_bt.CustomizableEdges = borderEdges1;
            this.confirm_bt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.confirm_bt.DisabledBorderColor = System.Drawing.Color.Empty;
            this.confirm_bt.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.confirm_bt.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.confirm_bt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.confirm_bt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.confirm_bt.ForeColor = System.Drawing.Color.White;
            this.confirm_bt.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.confirm_bt.IconMarginLeft = 11;
            this.confirm_bt.IconPadding = 10;
            this.confirm_bt.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.confirm_bt.IdleBorderColor = System.Drawing.Color.DarkMagenta;
            this.confirm_bt.IdleBorderRadius = 3;
            this.confirm_bt.IdleBorderThickness = 1;
            this.confirm_bt.IdleFillColor = System.Drawing.Color.DarkMagenta;
            this.confirm_bt.IdleIconLeftImage = null;
            this.confirm_bt.IdleIconRightImage = null;
            this.confirm_bt.IndicateFocus = false;
            this.confirm_bt.Location = new System.Drawing.Point(75, 148);
            this.confirm_bt.Name = "confirm_bt";
            this.confirm_bt.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.confirm_bt.onHoverState.BorderRadius = 3;
            this.confirm_bt.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.confirm_bt.onHoverState.BorderThickness = 1;
            this.confirm_bt.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.confirm_bt.onHoverState.ForeColor = System.Drawing.Color.White;
            this.confirm_bt.onHoverState.IconLeftImage = null;
            this.confirm_bt.onHoverState.IconRightImage = null;
            this.confirm_bt.OnIdleState.BorderColor = System.Drawing.Color.DarkMagenta;
            this.confirm_bt.OnIdleState.BorderRadius = 3;
            this.confirm_bt.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.confirm_bt.OnIdleState.BorderThickness = 1;
            this.confirm_bt.OnIdleState.FillColor = System.Drawing.Color.DarkMagenta;
            this.confirm_bt.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.confirm_bt.OnIdleState.IconLeftImage = null;
            this.confirm_bt.OnIdleState.IconRightImage = null;
            this.confirm_bt.OnPressedState.BorderColor = System.Drawing.Color.Indigo;
            this.confirm_bt.OnPressedState.BorderRadius = 3;
            this.confirm_bt.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.confirm_bt.OnPressedState.BorderThickness = 1;
            this.confirm_bt.OnPressedState.FillColor = System.Drawing.Color.Indigo;
            this.confirm_bt.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.confirm_bt.OnPressedState.IconLeftImage = null;
            this.confirm_bt.OnPressedState.IconRightImage = null;
            this.confirm_bt.Size = new System.Drawing.Size(200, 27);
            this.confirm_bt.TabIndex = 2;
            this.confirm_bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirm_bt.TextMarginLeft = 0;
            this.confirm_bt.UseDefaultRadiusAndThickness = true;
            this.confirm_bt.Click += new System.EventHandler(this.confirm_bt_Click);
            // 
            // newPassword_tb
            // 
            this.newPassword_tb.AcceptsReturn = false;
            this.newPassword_tb.AcceptsTab = false;
            this.newPassword_tb.AnimationSpeed = 200;
            this.newPassword_tb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.newPassword_tb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.newPassword_tb.BackColor = System.Drawing.Color.Transparent;
            this.newPassword_tb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newPassword_tb.BackgroundImage")));
            this.newPassword_tb.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.newPassword_tb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.newPassword_tb.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.newPassword_tb.BorderColorIdle = System.Drawing.Color.Silver;
            this.newPassword_tb.BorderRadius = 1;
            this.newPassword_tb.BorderThickness = 1;
            this.newPassword_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.newPassword_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPassword_tb.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.newPassword_tb.DefaultText = "";
            this.newPassword_tb.FillColor = System.Drawing.Color.White;
            this.newPassword_tb.HideSelection = true;
            this.newPassword_tb.IconLeft = null;
            this.newPassword_tb.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.newPassword_tb.IconPadding = 10;
            this.newPassword_tb.IconRight = null;
            this.newPassword_tb.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.newPassword_tb.Lines = new string[0];
            this.newPassword_tb.Location = new System.Drawing.Point(75, 91);
            this.newPassword_tb.MaxLength = 32767;
            this.newPassword_tb.MinimumSize = new System.Drawing.Size(1, 1);
            this.newPassword_tb.Modified = false;
            this.newPassword_tb.Multiline = false;
            this.newPassword_tb.Name = "newPassword_tb";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.newPassword_tb.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.newPassword_tb.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.newPassword_tb.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.newPassword_tb.OnIdleState = stateProperties4;
            this.newPassword_tb.PasswordChar = '\0';
            this.newPassword_tb.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.newPassword_tb.PlaceholderText = "New Password";
            this.newPassword_tb.ReadOnly = false;
            this.newPassword_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.newPassword_tb.SelectedText = "";
            this.newPassword_tb.SelectionLength = 0;
            this.newPassword_tb.SelectionStart = 0;
            this.newPassword_tb.ShortcutsEnabled = true;
            this.newPassword_tb.Size = new System.Drawing.Size(200, 35);
            this.newPassword_tb.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.newPassword_tb.TabIndex = 1;
            this.newPassword_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.newPassword_tb.TextMarginBottom = 0;
            this.newPassword_tb.TextMarginLeft = 5;
            this.newPassword_tb.TextMarginTop = 0;
            this.newPassword_tb.TextPlaceholder = "New Password";
            this.newPassword_tb.UseSystemPasswordChar = false;
            this.newPassword_tb.WordWrap = true;
            this.newPassword_tb.TextChanged += new System.EventHandler(this.newPassword_tb_TextChanged);
            // 
            // currentPassword_tb
            // 
            this.currentPassword_tb.AcceptsReturn = false;
            this.currentPassword_tb.AcceptsTab = false;
            this.currentPassword_tb.AnimationSpeed = 200;
            this.currentPassword_tb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.currentPassword_tb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.currentPassword_tb.BackColor = System.Drawing.Color.Transparent;
            this.currentPassword_tb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("currentPassword_tb.BackgroundImage")));
            this.currentPassword_tb.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.currentPassword_tb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.currentPassword_tb.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.currentPassword_tb.BorderColorIdle = System.Drawing.Color.Silver;
            this.currentPassword_tb.BorderRadius = 1;
            this.currentPassword_tb.BorderThickness = 1;
            this.currentPassword_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.currentPassword_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.currentPassword_tb.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.currentPassword_tb.DefaultText = "";
            this.currentPassword_tb.FillColor = System.Drawing.Color.White;
            this.currentPassword_tb.HideSelection = true;
            this.currentPassword_tb.IconLeft = null;
            this.currentPassword_tb.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.currentPassword_tb.IconPadding = 10;
            this.currentPassword_tb.IconRight = null;
            this.currentPassword_tb.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.currentPassword_tb.Lines = new string[0];
            this.currentPassword_tb.Location = new System.Drawing.Point(75, 31);
            this.currentPassword_tb.MaxLength = 32767;
            this.currentPassword_tb.MinimumSize = new System.Drawing.Size(1, 1);
            this.currentPassword_tb.Modified = false;
            this.currentPassword_tb.Multiline = false;
            this.currentPassword_tb.Name = "currentPassword_tb";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.currentPassword_tb.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.currentPassword_tb.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.currentPassword_tb.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.currentPassword_tb.OnIdleState = stateProperties8;
            this.currentPassword_tb.PasswordChar = '\0';
            this.currentPassword_tb.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.currentPassword_tb.PlaceholderText = "Current Password";
            this.currentPassword_tb.ReadOnly = false;
            this.currentPassword_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.currentPassword_tb.SelectedText = "";
            this.currentPassword_tb.SelectionLength = 0;
            this.currentPassword_tb.SelectionStart = 0;
            this.currentPassword_tb.ShortcutsEnabled = true;
            this.currentPassword_tb.Size = new System.Drawing.Size(200, 35);
            this.currentPassword_tb.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.currentPassword_tb.TabIndex = 0;
            this.currentPassword_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.currentPassword_tb.TextMarginBottom = 0;
            this.currentPassword_tb.TextMarginLeft = 5;
            this.currentPassword_tb.TextMarginTop = 0;
            this.currentPassword_tb.TextPlaceholder = "Current Password";
            this.currentPassword_tb.UseSystemPasswordChar = false;
            this.currentPassword_tb.WordWrap = true;
            this.currentPassword_tb.TextChanged += new System.EventHandler(this.currentPassword_tb_TextChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.changePassword_Panel);
            this.Controls.Add(this.top_panel);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.changePassword_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel top_panel;
        private Bunifu.Framework.UI.BunifuGradientPanel changePassword_Panel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton confirm_bt;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox newPassword_tb;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox currentPassword_tb;
        private Bunifu.UI.WinForms.BunifuLabel medicalStore_Label;
        private Bunifu.Framework.UI.BunifuFlatButton logout;
        private Bunifu.Framework.UI.BunifuFlatButton back;
        private Bunifu.UI.WinForms.BunifuImageButton curShowPass;
        private Bunifu.UI.WinForms.BunifuImageButton newShowPass;
    }
}