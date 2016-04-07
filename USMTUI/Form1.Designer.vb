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
        Me.btnBackupNow = New System.Windows.Forms.Button()
        Me.txtSvrShare = New System.Windows.Forms.TextBox()
        Me.txtFolderName = New System.Windows.Forms.TextBox()
        Me.lblSvrShare = New System.Windows.Forms.Label()
        Me.lblFoldername = New System.Windows.Forms.Label()
        Me.btnVariables = New System.Windows.Forms.Button()
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.lblIs64 = New System.Windows.Forms.Label()
        Me.chbUse64 = New System.Windows.Forms.CheckBox()
        Me.lblCmdToRun = New System.Windows.Forms.Label()
        Me.btnRestoreNow = New System.Windows.Forms.Button()
        Me.btnViewBackupArgs = New System.Windows.Forms.Button()
        Me.btnViewRestoreArgs = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnViewScan = New System.Windows.Forms.Button()
        Me.btnViewLoad = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBackupNow
        '
        Me.btnBackupNow.Enabled = False
        Me.btnBackupNow.Location = New System.Drawing.Point(12, 170)
        Me.btnBackupNow.Name = "btnBackupNow"
        Me.btnBackupNow.Size = New System.Drawing.Size(80, 23)
        Me.btnBackupNow.TabIndex = 0
        Me.btnBackupNow.Text = "Run Backup"
        Me.btnBackupNow.UseVisualStyleBackColor = True
        '
        'txtSvrShare
        '
        Me.txtSvrShare.Location = New System.Drawing.Point(13, 39)
        Me.txtSvrShare.Name = "txtSvrShare"
        Me.txtSvrShare.Size = New System.Drawing.Size(159, 20)
        Me.txtSvrShare.TabIndex = 1
        Me.txtSvrShare.Text = "\\alpha\usmt"
        '
        'txtFolderName
        '
        Me.txtFolderName.Location = New System.Drawing.Point(13, 78)
        Me.txtFolderName.Name = "txtFolderName"
        Me.txtFolderName.Size = New System.Drawing.Size(159, 20)
        Me.txtFolderName.TabIndex = 3
        Me.txtFolderName.Text = "Default"
        '
        'lblSvrShare
        '
        Me.lblSvrShare.AutoSize = True
        Me.lblSvrShare.Location = New System.Drawing.Point(12, 23)
        Me.lblSvrShare.Name = "lblSvrShare"
        Me.lblSvrShare.Size = New System.Drawing.Size(69, 13)
        Me.lblSvrShare.TabIndex = 4
        Me.lblSvrShare.Text = "Server Share"
        '
        'lblFoldername
        '
        Me.lblFoldername.AutoSize = True
        Me.lblFoldername.Location = New System.Drawing.Point(10, 62)
        Me.lblFoldername.Name = "lblFoldername"
        Me.lblFoldername.Size = New System.Drawing.Size(67, 13)
        Me.lblFoldername.TabIndex = 5
        Me.lblFoldername.Text = "Folder Name"
        '
        'btnVariables
        '
        Me.btnVariables.Location = New System.Drawing.Point(12, 104)
        Me.btnVariables.Name = "btnVariables"
        Me.btnVariables.Size = New System.Drawing.Size(80, 23)
        Me.btnVariables.TabIndex = 6
        Me.btnVariables.Text = "Set"
        Me.btnVariables.UseVisualStyleBackColor = True
        '
        'btnValidate
        '
        Me.btnValidate.Enabled = False
        Me.btnValidate.Location = New System.Drawing.Point(92, 104)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(79, 23)
        Me.btnValidate.TabIndex = 7
        Me.btnValidate.Text = "Validate"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'lblIs64
        '
        Me.lblIs64.AutoSize = True
        Me.lblIs64.Location = New System.Drawing.Point(10, 134)
        Me.lblIs64.Name = "lblIs64"
        Me.lblIs64.Size = New System.Drawing.Size(124, 13)
        Me.lblIs64.TabIndex = 8
        Me.lblIs64.Text = "Using 64-bit Executbles?"
        '
        'chbUse64
        '
        Me.chbUse64.AutoSize = True
        Me.chbUse64.Enabled = False
        Me.chbUse64.Location = New System.Drawing.Point(156, 134)
        Me.chbUse64.Name = "chbUse64"
        Me.chbUse64.Size = New System.Drawing.Size(15, 14)
        Me.chbUse64.TabIndex = 9
        Me.chbUse64.UseVisualStyleBackColor = True
        '
        'lblCmdToRun
        '
        Me.lblCmdToRun.AutoSize = True
        Me.lblCmdToRun.Location = New System.Drawing.Point(10, 154)
        Me.lblCmdToRun.Name = "lblCmdToRun"
        Me.lblCmdToRun.Size = New System.Drawing.Size(89, 13)
        Me.lblCmdToRun.TabIndex = 10
        Me.lblCmdToRun.Text = "Command to Run"
        '
        'btnRestoreNow
        '
        Me.btnRestoreNow.Enabled = False
        Me.btnRestoreNow.Location = New System.Drawing.Point(12, 198)
        Me.btnRestoreNow.Name = "btnRestoreNow"
        Me.btnRestoreNow.Size = New System.Drawing.Size(80, 23)
        Me.btnRestoreNow.TabIndex = 11
        Me.btnRestoreNow.Text = "Run Restore"
        Me.btnRestoreNow.UseVisualStyleBackColor = True
        '
        'btnViewBackupArgs
        '
        Me.btnViewBackupArgs.Location = New System.Drawing.Point(92, 170)
        Me.btnViewBackupArgs.Name = "btnViewBackupArgs"
        Me.btnViewBackupArgs.Size = New System.Drawing.Size(80, 23)
        Me.btnViewBackupArgs.TabIndex = 12
        Me.btnViewBackupArgs.Text = "View Code"
        Me.btnViewBackupArgs.UseVisualStyleBackColor = True
        '
        'btnViewRestoreArgs
        '
        Me.btnViewRestoreArgs.Location = New System.Drawing.Point(92, 198)
        Me.btnViewRestoreArgs.Name = "btnViewRestoreArgs"
        Me.btnViewRestoreArgs.Size = New System.Drawing.Size(80, 23)
        Me.btnViewRestoreArgs.TabIndex = 14
        Me.btnViewRestoreArgs.Text = "View Code"
        Me.btnViewRestoreArgs.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(125, 13)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(46, 23)
        Me.btnHelp.TabIndex = 15
        Me.btnHelp.Text = "Help?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnViewScan
        '
        Me.btnViewScan.Enabled = False
        Me.btnViewScan.Location = New System.Drawing.Point(12, 226)
        Me.btnViewScan.Name = "btnViewScan"
        Me.btnViewScan.Size = New System.Drawing.Size(80, 23)
        Me.btnViewScan.TabIndex = 16
        Me.btnViewScan.Text = "Scan Log"
        Me.btnViewScan.UseVisualStyleBackColor = True
        '
        'btnViewLoad
        '
        Me.btnViewLoad.Enabled = False
        Me.btnViewLoad.Location = New System.Drawing.Point(92, 226)
        Me.btnViewLoad.Name = "btnViewLoad"
        Me.btnViewLoad.Size = New System.Drawing.Size(80, 23)
        Me.btnViewLoad.TabIndex = 17
        Me.btnViewLoad.Text = "Load Log"
        Me.btnViewLoad.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 261)
        Me.Controls.Add(Me.btnViewLoad)
        Me.Controls.Add(Me.btnViewScan)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnViewRestoreArgs)
        Me.Controls.Add(Me.btnViewBackupArgs)
        Me.Controls.Add(Me.btnRestoreNow)
        Me.Controls.Add(Me.lblCmdToRun)
        Me.Controls.Add(Me.chbUse64)
        Me.Controls.Add(Me.lblIs64)
        Me.Controls.Add(Me.btnValidate)
        Me.Controls.Add(Me.btnVariables)
        Me.Controls.Add(Me.lblFoldername)
        Me.Controls.Add(Me.lblSvrShare)
        Me.Controls.Add(Me.txtFolderName)
        Me.Controls.Add(Me.txtSvrShare)
        Me.Controls.Add(Me.btnBackupNow)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(200, 300)
        Me.MinimumSize = New System.Drawing.Size(200, 300)
        Me.Name = "frmMain"
        Me.Text = "USMT UI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBackupNow As System.Windows.Forms.Button
    Friend WithEvents txtSvrShare As System.Windows.Forms.TextBox
    Friend WithEvents txtFolderName As System.Windows.Forms.TextBox
    Friend WithEvents lblSvrShare As System.Windows.Forms.Label
    Friend WithEvents lblFoldername As System.Windows.Forms.Label
    Friend WithEvents btnVariables As System.Windows.Forms.Button
    Friend WithEvents btnValidate As System.Windows.Forms.Button
    Friend WithEvents lblIs64 As System.Windows.Forms.Label
    Friend WithEvents chbUse64 As System.Windows.Forms.CheckBox
    Friend WithEvents lblCmdToRun As System.Windows.Forms.Label
    Friend WithEvents btnRestoreNow As System.Windows.Forms.Button
    Friend WithEvents btnViewBackupArgs As System.Windows.Forms.Button
    Friend WithEvents btnViewRestoreArgs As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnViewScan As System.Windows.Forms.Button
    Friend WithEvents btnViewLoad As System.Windows.Forms.Button

End Class
