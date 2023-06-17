Imports Syncfusion.Windows.Forms.Tools

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenuUtama
    Inherits RibbonForm

    'Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RibbonControlUtama = New Syncfusion.Windows.Forms.Tools.RibbonControlAdv()
        Me.MenuMaster = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.ToolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.btnLogin = New System.Windows.Forms.ToolStripButton()
        Me.btnLogout = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.MenuPesanan = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.ToolStripEx2 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.btnPesanan = New System.Windows.Forms.ToolStripButton()
        Me.StatusStripEx1 = New Syncfusion.Windows.Forms.Tools.StatusStripEx()
        Me.StatusStripEx2 = New Syncfusion.Windows.Forms.Tools.StatusStripEx()
        CType(Me.RibbonControlUtama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonControlUtama.SuspendLayout()
        Me.MenuMaster.Panel.SuspendLayout()
        Me.ToolStripEx1.SuspendLayout()
        Me.ToolStripEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'RibbonControlUtama
        '
        Me.RibbonControlUtama.CaptionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibbonControlUtama.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RibbonControlUtama.Header.AddMainItem(MenuMaster)
        Me.RibbonControlUtama.Header.AddMainItem(MenuPesanan)
        Me.RibbonControlUtama.Location = New System.Drawing.Point(1, 0)
        Me.RibbonControlUtama.MenuButtonFont = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RibbonControlUtama.MenuButtonText = ""
        Me.RibbonControlUtama.MenuButtonWidth = 56
        Me.RibbonControlUtama.MenuColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.RibbonControlUtama.Name = "RibbonControlUtama"
        Me.RibbonControlUtama.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed
        '
        'RibbonControlUtama.OfficeMenu
        '
        Me.RibbonControlUtama.OfficeMenu.Name = "OfficeMenu"
        Me.RibbonControlUtama.OfficeMenu.ShowItemToolTips = True
        Me.RibbonControlUtama.OfficeMenu.Size = New System.Drawing.Size(12, 65)
        Me.RibbonControlUtama.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RibbonControlUtama.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None
        Me.RibbonControlUtama.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2010
        Me.RibbonControlUtama.SelectedTab = Me.MenuMaster
        Me.RibbonControlUtama.ShowRibbonDisplayOptionButton = True
        Me.RibbonControlUtama.Size = New System.Drawing.Size(1350, 120)
        Me.RibbonControlUtama.SystemText.QuickAccessDialogDropDownName = "Start menu"
        Me.RibbonControlUtama.SystemText.RenameDisplayLabelText = "&Display Name:"
        Me.RibbonControlUtama.TabIndex = 2
        Me.RibbonControlUtama.Text = "Pesanan"
        Me.RibbonControlUtama.ThemeName = "Office2010"
        Me.RibbonControlUtama.ThemeStyle.MoreCommandsStyle.PropertyGridViewBorderColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.RibbonControlUtama.TitleColor = System.Drawing.Color.Black
        Me.RibbonControlUtama.TitleFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MenuMaster
        '
        Me.MenuMaster.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuMaster.Name = "MenuMaster"
        '
        'RibbonControlUtama.RibbonPanel1
        '
        Me.MenuMaster.Panel.Controls.Add(Me.ToolStripEx1)
        Me.MenuMaster.Panel.Name = "RibbonPanel1"
        Me.MenuMaster.Panel.ScrollPosition = 0
        Me.MenuMaster.Panel.TabIndex = 2
        Me.MenuMaster.Panel.Text = "System"
        Me.MenuMaster.Position = 0
        Me.MenuMaster.Size = New System.Drawing.Size(68, 25)
        Me.MenuMaster.Tag = "1"
        Me.MenuMaster.Text = "System"
        '
        'ToolStripEx1
        '
        Me.ToolStripEx1.AutoSize = False
        Me.ToolStripEx1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStripEx1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripEx1.Image = Nothing
        Me.ToolStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnLogin, Me.btnLogout, Me.btnExit})
        Me.ToolStripEx1.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office2007
        Me.ToolStripEx1.Location = New System.Drawing.Point(0, 1)
        Me.ToolStripEx1.Name = "ToolStripEx1"
        Me.ToolStripEx1.Office12Mode = False
        Me.ToolStripEx1.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.ToolStripEx1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripEx1.Size = New System.Drawing.Size(239, 61)
        Me.ToolStripEx1.TabIndex = 0
        Me.ToolStripEx1.ThemeName = ""
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Image = Global.vbLogin.My.Resources.Resources.kunci
        Me.btnLogin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(57, 37)
        Me.btnLogin.Text = "Login"
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Image = Global.vbLogin.My.Resources.Resources.logout
        Me.btnLogout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(0, 1, 2, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(66, 37)
        Me.btnLogout.Text = "Logout"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.vbLogin.My.Resources.Resources._exit
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(48, 37)
        Me.btnExit.Text = "Exit"
        '
        'MenuPesanan
        '
        Me.MenuPesanan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuPesanan.Name = "MenuPesanan"
        '
        'RibbonControlUtama.RibbonPanel2
        '
        Me.MenuPesanan.Panel.Name = "RibbonPanel2"
        Me.MenuPesanan.Panel.ScrollPosition = 0
        Me.MenuPesanan.Panel.TabIndex = 3
        Me.MenuPesanan.Panel.Text = "Master"
        Me.MenuPesanan.Position = 1
        Me.MenuPesanan.Size = New System.Drawing.Size(66, 25)
        Me.MenuPesanan.Tag = "2"
        Me.MenuPesanan.Text = "Master"
        '
        'ToolStripEx2
        '
        Me.ToolStripEx2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStripEx2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripEx2.Image = Nothing
        Me.ToolStripEx2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPesanan})
        Me.ToolStripEx2.Location = New System.Drawing.Point(0, 1)
        Me.ToolStripEx2.Name = "ToolStripEx2"
        Me.ToolStripEx2.Office12Mode = False
        Me.ToolStripEx2.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.ToolStripEx2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripEx2.Size = New System.Drawing.Size(125, 70)
        Me.ToolStripEx2.TabIndex = 0
        Me.ToolStripEx2.ThemeName = ""
        '
        'btnPesanan
        '
        Me.btnPesanan.AutoSize = False
        Me.btnPesanan.Image = Global.vbLogin.My.Resources.Resources.menu_pesanan_transparan
        Me.btnPesanan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPesanan.Name = "btnPesanan"
        Me.btnPesanan.Size = New System.Drawing.Size(120, 53)
        Me.btnPesanan.Text = "Surat Pesanan"
        Me.btnPesanan.ToolTipText = "Barang Farmasi"
        '
        'StatusStripEx1
        '
        Me.StatusStripEx1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.StatusStripEx1.BeforeTouchSize = New System.Drawing.Size(1338, 22)
        Me.StatusStripEx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStripEx1.Location = New System.Drawing.Point(6, 672)
        Me.StatusStripEx1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusStripEx1.Name = "StatusStripEx1"
        Me.StatusStripEx1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black
        Me.StatusStripEx1.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.StatusStripEx1.Size = New System.Drawing.Size(1338, 22)
        Me.StatusStripEx1.TabIndex = 15
        Me.StatusStripEx1.Text = "Jam"
        Me.StatusStripEx1.ThemeName = "Metro"
        Me.StatusStripEx1.VisualStyle = Syncfusion.Windows.Forms.Tools.StatusStripExStyle.Metro
        '
        'StatusStripEx2
        '
        Me.StatusStripEx2.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusStripEx2.BeforeTouchSize = New System.Drawing.Size(200, 22)
        Me.StatusStripEx2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStripEx2.Location = New System.Drawing.Point(0, 0)
        Me.StatusStripEx2.MetroColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusStripEx2.Name = "StatusStripEx2"
        Me.StatusStripEx2.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black
        Me.StatusStripEx2.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.StatusStripEx2.Size = New System.Drawing.Size(200, 22)
        Me.StatusStripEx2.TabIndex = 0
        Me.StatusStripEx2.Text = "Jam"
        Me.StatusStripEx2.ThemeName = "Metro"
        Me.StatusStripEx2.VisualStyle = Syncfusion.Windows.Forms.Tools.StatusStripExStyle.Metro
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1352, 700)
        Me.Controls.Add(Me.RibbonControlUtama)
        Me.Controls.Add(Me.StatusStripEx1)
        Me.Name = "FormMenuUtama"
        Me.Padding = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Informasi Gudang Farmasi"
        CType(Me.RibbonControlUtama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonControlUtama.ResumeLayout(False)
        Me.RibbonControlUtama.PerformLayout()
        Me.MenuMaster.Panel.ResumeLayout(False)
        Me.ToolStripEx1.ResumeLayout(False)
        Me.ToolStripEx1.PerformLayout()
        Me.ToolStripEx2.ResumeLayout(False)
        Me.ToolStripEx2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControlUtama As Syncfusion.Windows.Forms.Tools.RibbonControlAdv
    Private WithEvents ContextMenuStrip1 As ContextMenuStrip
    Private WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents MenuMaster As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
    Friend WithEvents MenuPesanan As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
    Friend WithEvents ToolStripEx1 As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents btnLogin As ToolStripButton
    Friend WithEvents btnLogout As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents ToolStripEx2 As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents btnPesanan As ToolStripButton
    Friend WithEvents StatusStripEx1 As StatusStripEx
    Friend WithEvents StatusStripEx2 As StatusStripEx
End Class
