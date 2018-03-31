<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnBackupNow = New System.Windows.Forms.Button()
        Me.txtSvrShare = New System.Windows.Forms.TextBox()
        Me.txtFolderName = New System.Windows.Forms.TextBox()
        Me.lblSvrShare = New System.Windows.Forms.Label()
        Me.lblFoldername = New System.Windows.Forms.Label()
        Me.btnVariables = New System.Windows.Forms.Button()
        Me.lblIs64 = New System.Windows.Forms.Label()
        Me.chbUse64 = New System.Windows.Forms.CheckBox()
        Me.btnRestoreNow = New System.Windows.Forms.Button()
        Me.btnViewBackupArgs = New System.Windows.Forms.Button()
        Me.btnViewRestoreArgs = New System.Windows.Forms.Button()
        Me.MenuStripMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupStep1 = New System.Windows.Forms.GroupBox()
        Me.btnBrowseServerShare = New System.Windows.Forms.Button()
        Me.GroupStep2 = New System.Windows.Forms.GroupBox()
        Me.GroupStep3 = New System.Windows.Forms.GroupBox()
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.MenuStripMain.SuspendLayout()
        Me.GroupStep1.SuspendLayout()
        Me.GroupStep2.SuspendLayout()
        Me.GroupStep3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBackupNow
        '
        Me.btnBackupNow.Enabled = False
        Me.btnBackupNow.Location = New System.Drawing.Point(6, 38)
        Me.btnBackupNow.Name = "btnBackupNow"
        Me.btnBackupNow.Size = New System.Drawing.Size(150, 54)
        Me.btnBackupNow.TabIndex = 0
        Me.btnBackupNow.Text = "Run Backup"
        Me.btnBackupNow.UseVisualStyleBackColor = True
        '
        'txtSvrShare
        '
        Me.txtSvrShare.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSvrShare.Location = New System.Drawing.Point(10, 49)
        Me.txtSvrShare.Name = "txtSvrShare"
        Me.txtSvrShare.Size = New System.Drawing.Size(159, 26)
        Me.txtSvrShare.TabIndex = 1
        Me.txtSvrShare.Text = "\\it-tyler\usmt"
        '
        'txtFolderName
        '
        Me.txtFolderName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolderName.Location = New System.Drawing.Point(10, 133)
        Me.txtFolderName.Name = "txtFolderName"
        Me.txtFolderName.Size = New System.Drawing.Size(159, 30)
        Me.txtFolderName.TabIndex = 3
        Me.txtFolderName.Text = "Default"
        '
        'lblSvrShare
        '
        Me.lblSvrShare.AutoSize = True
        Me.lblSvrShare.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSvrShare.Location = New System.Drawing.Point(6, 26)
        Me.lblSvrShare.Name = "lblSvrShare"
        Me.lblSvrShare.Size = New System.Drawing.Size(102, 20)
        Me.lblSvrShare.TabIndex = 4
        Me.lblSvrShare.Text = "Server Share"
        '
        'lblFoldername
        '
        Me.lblFoldername.AutoSize = True
        Me.lblFoldername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoldername.Location = New System.Drawing.Point(6, 110)
        Me.lblFoldername.Name = "lblFoldername"
        Me.lblFoldername.Size = New System.Drawing.Size(100, 20)
        Me.lblFoldername.TabIndex = 5
        Me.lblFoldername.Text = "Folder Name"
        '
        'btnVariables
        '
        Me.btnVariables.Location = New System.Drawing.Point(8, 38)
        Me.btnVariables.Name = "btnVariables"
        Me.btnVariables.Size = New System.Drawing.Size(236, 126)
        Me.btnVariables.TabIndex = 6
        Me.btnVariables.Text = "Set"
        Me.btnVariables.UseVisualStyleBackColor = True
        '
        'lblIs64
        '
        Me.lblIs64.AutoSize = True
        Me.lblIs64.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIs64.Location = New System.Drawing.Point(7, 80)
        Me.lblIs64.Name = "lblIs64"
        Me.lblIs64.Size = New System.Drawing.Size(164, 17)
        Me.lblIs64.TabIndex = 8
        Me.lblIs64.Text = "Using 64-bit Executbles?"
        '
        'chbUse64
        '
        Me.chbUse64.AutoSize = True
        Me.chbUse64.Enabled = False
        Me.chbUse64.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbUse64.Location = New System.Drawing.Point(175, 83)
        Me.chbUse64.Name = "chbUse64"
        Me.chbUse64.Size = New System.Drawing.Size(15, 14)
        Me.chbUse64.TabIndex = 9
        Me.chbUse64.UseVisualStyleBackColor = True
        '
        'btnRestoreNow
        '
        Me.btnRestoreNow.Enabled = False
        Me.btnRestoreNow.Location = New System.Drawing.Point(6, 110)
        Me.btnRestoreNow.Name = "btnRestoreNow"
        Me.btnRestoreNow.Size = New System.Drawing.Size(150, 54)
        Me.btnRestoreNow.TabIndex = 11
        Me.btnRestoreNow.Text = "Run Restore"
        Me.btnRestoreNow.UseVisualStyleBackColor = True
        '
        'btnViewBackupArgs
        '
        Me.btnViewBackupArgs.Location = New System.Drawing.Point(162, 38)
        Me.btnViewBackupArgs.Name = "btnViewBackupArgs"
        Me.btnViewBackupArgs.Size = New System.Drawing.Size(127, 54)
        Me.btnViewBackupArgs.TabIndex = 12
        Me.btnViewBackupArgs.Text = "View Code"
        Me.btnViewBackupArgs.UseVisualStyleBackColor = True
        '
        'btnViewRestoreArgs
        '
        Me.btnViewRestoreArgs.Location = New System.Drawing.Point(162, 110)
        Me.btnViewRestoreArgs.Name = "btnViewRestoreArgs"
        Me.btnViewRestoreArgs.Size = New System.Drawing.Size(127, 54)
        Me.btnViewRestoreArgs.TabIndex = 14
        Me.btnViewRestoreArgs.Text = "View Code"
        Me.btnViewRestoreArgs.UseVisualStyleBackColor = True
        '
        'MenuStripMain
        '
        Me.MenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.LogsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMain.Name = "MenuStripMain"
        Me.MenuStripMain.Size = New System.Drawing.Size(821, 24)
        Me.MenuStripMain.TabIndex = 18
        Me.MenuStripMain.Text = "MenuStripMain"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogsToolStripMenuItem
        '
        Me.LogsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem, Me.ScanToolStripMenuItem})
        Me.LogsToolStripMenuItem.Name = "LogsToolStripMenuItem"
        Me.LogsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.LogsToolStripMenuItem.Text = "Logs"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.LoadToolStripMenuItem.Text = "Load"
        '
        'ScanToolStripMenuItem
        '
        Me.ScanToolStripMenuItem.Name = "ScanToolStripMenuItem"
        Me.ScanToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.ScanToolStripMenuItem.Text = "Scan"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.InstructionsToolStripMenuItem.Text = "Instructions"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'GroupStep1
        '
        Me.GroupStep1.Controls.Add(Me.btnBrowseServerShare)
        Me.GroupStep1.Controls.Add(Me.lblSvrShare)
        Me.GroupStep1.Controls.Add(Me.txtSvrShare)
        Me.GroupStep1.Controls.Add(Me.lblFoldername)
        Me.GroupStep1.Controls.Add(Me.txtFolderName)
        Me.GroupStep1.Controls.Add(Me.lblIs64)
        Me.GroupStep1.Controls.Add(Me.chbUse64)
        Me.GroupStep1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupStep1.Location = New System.Drawing.Point(12, 27)
        Me.GroupStep1.Name = "GroupStep1"
        Me.GroupStep1.Size = New System.Drawing.Size(209, 179)
        Me.GroupStep1.TabIndex = 19
        Me.GroupStep1.TabStop = False
        Me.GroupStep1.Text = "Step 1"
        '
        'btnBrowseServerShare
        '
        Me.btnBrowseServerShare.BackgroundImage = CType(resources.GetObject("btnBrowseServerShare.BackgroundImage"), System.Drawing.Image)
        Me.btnBrowseServerShare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBrowseServerShare.FlatAppearance.BorderSize = 0
        Me.btnBrowseServerShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseServerShare.Location = New System.Drawing.Point(171, 49)
        Me.btnBrowseServerShare.Name = "btnBrowseServerShare"
        Me.btnBrowseServerShare.Size = New System.Drawing.Size(26, 26)
        Me.btnBrowseServerShare.TabIndex = 23
        Me.btnBrowseServerShare.UseVisualStyleBackColor = True
        '
        'GroupStep2
        '
        Me.GroupStep2.Controls.Add(Me.btnVariables)
        Me.GroupStep2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupStep2.Location = New System.Drawing.Point(239, 27)
        Me.GroupStep2.Name = "GroupStep2"
        Me.GroupStep2.Size = New System.Drawing.Size(252, 179)
        Me.GroupStep2.TabIndex = 20
        Me.GroupStep2.TabStop = False
        Me.GroupStep2.Text = "Step 2"
        '
        'GroupStep3
        '
        Me.GroupStep3.Controls.Add(Me.btnBackupNow)
        Me.GroupStep3.Controls.Add(Me.btnViewBackupArgs)
        Me.GroupStep3.Controls.Add(Me.btnViewRestoreArgs)
        Me.GroupStep3.Controls.Add(Me.btnRestoreNow)
        Me.GroupStep3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupStep3.Location = New System.Drawing.Point(509, 27)
        Me.GroupStep3.Name = "GroupStep3"
        Me.GroupStep3.Size = New System.Drawing.Size(297, 179)
        Me.GroupStep3.TabIndex = 22
        Me.GroupStep3.TabStop = False
        Me.GroupStep3.Text = "Step 3"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 226)
        Me.Controls.Add(Me.GroupStep3)
        Me.Controls.Add(Me.GroupStep2)
        Me.Controls.Add(Me.GroupStep1)
        Me.Controls.Add(Me.MenuStripMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStripMain
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(837, 265)
        Me.MinimumSize = New System.Drawing.Size(837, 265)
        Me.Name = "frmMain"
        Me.Text = "USMT UI"
        Me.MenuStripMain.ResumeLayout(False)
        Me.MenuStripMain.PerformLayout()
        Me.GroupStep1.ResumeLayout(False)
        Me.GroupStep1.PerformLayout()
        Me.GroupStep2.ResumeLayout(False)
        Me.GroupStep3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBackupNow As System.Windows.Forms.Button
    Friend WithEvents txtSvrShare As System.Windows.Forms.TextBox
    Friend WithEvents txtFolderName As System.Windows.Forms.TextBox
    Friend WithEvents lblSvrShare As System.Windows.Forms.Label
    Friend WithEvents lblFoldername As System.Windows.Forms.Label
    Friend WithEvents btnVariables As System.Windows.Forms.Button
    Friend WithEvents lblIs64 As System.Windows.Forms.Label
    Friend WithEvents chbUse64 As System.Windows.Forms.CheckBox
    Friend WithEvents btnRestoreNow As System.Windows.Forms.Button
    Friend WithEvents btnViewBackupArgs As System.Windows.Forms.Button
    Friend WithEvents btnViewRestoreArgs As System.Windows.Forms.Button
    Friend WithEvents MenuStripMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstructionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupStep1 As GroupBox
    Friend WithEvents GroupStep2 As GroupBox
    Friend WithEvents GroupStep3 As GroupBox
    Friend WithEvents FolderBrowser As FolderBrowserDialog
    Friend WithEvents btnBrowseServerShare As Button
End Class
