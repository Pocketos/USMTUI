Public Class frmMain

    'Global Variables
    Dim version As String
    Dim help As String
    Dim usmtshare As String
    Dim usmtfolder As String
    Dim FullSvrPath64 As String
    Dim FullSvrPath32 As String

    'Path For Backups
    Dim BackupRunPath As String

    'Path for Restores
    Dim RestoreRunPath As String

    'Declare varables as arguments for the final execuatable command
    Dim xmldir As String
    Dim configdir As String
    Dim logdir As String
    Dim filelogdir As String
    Dim args As String
    Dim RestoreArgs As String

    
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Declares some Global Variable values
        version = "A 05"
        help = "First, type the server share name without the \.  Then, type a unique folder name for the data.  Click on Set to set or un set the values.  Then Click on Validate to check the values.  The Backup and Restore buttons will enable and can be clicked. "



    End Sub
    'Run Backup button launched the compiled command
    Private Sub btnBackupNow_Click(sender As Object, e As EventArgs) Handles btnBackupNow.Click
        Shell(BackupRunPath, vbNormalFocus)
    End Sub

    Private Sub txtvrInput_TextChanged(sender As Object, e As EventArgs) Handles txtSvrShare.TextChanged

    End Sub

    Private Sub txtInputBelow_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSvrAddress_TextChanged(sender As Object, e As EventArgs) Handles txtFolderName.TextChanged

    End Sub

    Private Sub lblSvrShare_Click(sender As Object, e As EventArgs) Handles lblSvrShare.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVariables.Click
        If btnVariables.Text = "Set" Then
            usmtshare = txtSvrShare.Text
            usmtfolder = txtFolderName.Text
            txtFolderName.ReadOnly = True
            txtSvrShare.ReadOnly = True
            FullSvrPath64 = txtSvrShare.Text & "\Filesx64"
            FullSvrPath32 = txtSvrShare.Text & "\Files"
            btnValidate.Enabled = True
            btnVariables.Text = "Reset"
        Else
            usmtshare = ""
            usmtfolder = ""
            btnVariables.Text = "Set"
            btnValidate.Enabled = False
            txtFolderName.ReadOnly = False
            txtSvrShare.ReadOnly = False
            btnBackupNow.Enabled = False
            btnRestoreNow.Enabled = False
            chbUse64.Checked = False
        End If
        

    End Sub

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Dim is64 As Boolean
        Dim cpuID As String = _
        My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0", _
            "Identifier", "n/a")
        '
        'Get all chars from the beginning of the string until the first space is detected.
        cpuID = cpuID.Substring(0, cpuID.IndexOf(" "))

        If LCase(cpuID).Contains("amd64") OrElse LCase(cpuID).Contains("intel64") Then

            is64 = True
            chbUse64.Checked = True

        Else

            is64 = False
            chbUse64.Checked = False

        End If

        If is64 = True Then

            If System.IO.Directory.Exists(FullSvrPath64) And txtFolderName.Text <> "" Then

                MsgBox("64-bit Executables validated Successfully!")
                btnBackupNow.Enabled = True
                btnRestoreNow.Enabled = True

                'Generate the variables being passed to the executable
                xmldir = txtSvrShare.Text & "\Filesx64"
                configdir = txtSvrShare.Text & "\Filesx64"
                filelogdir = txtSvrShare.Text & "\data\" & txtFolderName.Text & "\Logs"
                logdir = txtSvrShare.Text & "\data\" & txtFolderName.Text & "\Logs"
                args = txtSvrShare.Text & "\data\" & txtFolderName.Text & " /i:" & xmldir & "\migapp.xml /i:" & xmldir & "\miguser.xml /i:" & xmldir & "\custom.xml /config:" & configdir & "\config.xml /uel:90 /c /v:13 /listfiles:" & filelogdir & "\scan_files.txt /l:" & logdir & "\scan_log.txt"
                RestoreArgs = txtSvrShare.Text & "\data\" & txtFolderName.Text & " /i:" & xmldir & "\migapp.xml /i:" & xmldir & "\miguser.xml /i:" & xmldir & "\custom.xml /config:" & configdir & "\config.xml /lac /uel:90 /v:13 /c /l:" & logdir & "\load_log.txt"
                BackupRunPath = "cmd /c " & txtSvrShare.Text & "\Filesx64\scanstate.exe " & args
                RestoreRunPath = "cmd /c " & txtSvrShare.Text & "\Filesx64\loadstate.exe " & RestoreArgs
                btnViewLoad.Enabled = True
                btnViewScan.Enabled = True
                lblCmdToRun.Text = "Ready to Run"

            Else

                MsgBox("64-bit Executables could not validate!")
                txtFolderName.ReadOnly = False
                txtSvrShare.ReadOnly = False

            End If

        Else


            If System.IO.Directory.Exists(FullSvrPath32) And txtFolderName.Text <> "" Then

                MsgBox("32-bit Executables validated Successfully!")
                btnBackupNow.Enabled = True
                btnRestoreNow.Enabled = True

                'Generate the variables being passed to the executable
                xmldir = txtSvrShare.Text & "\Files"
                configdir = txtSvrShare.Text & "\Files"
                filelogdir = txtSvrShare.Text & "\data\" & txtFolderName.Text & "\Logs"
                logdir = txtSvrShare.Text & "\data\" & txtFolderName.Text & "\Logs"
                args = txtSvrShare.Text & "\data\" & txtFolderName.Text & " /i:" & xmldir & "\migapp.xml /i:" & xmldir & "\miguser.xml /i:" & xmldir & "\custom.xml /config:" & configdir & "\config.xml /uel:90 /c /v:13 /listfiles:" & filelogdir & "\scan_files.txt /l:" & logdir & "\scan_log.txt"
                RestoreArgs = txtSvrShare.Text & "\data\" & txtFolderName.Text & " /i:" & xmldir & "\migapp.xml /i:" & xmldir & "\miguser.xml /i:" & xmldir & "\custom.xml /config:" & configdir & "\config.xml /lac /uel:90 /v:13 /c /l:" & logdir & "\load_log.txt"
                BackupRunPath = "cmd /c " & txtSvrShare.Text & "\Files\scanstate.exe " & args
                RestoreRunPath = "cmd /c " & txtSvrShare.Text & "\Files\loadstate.exe " & RestoreArgs
                btnViewLoad.Enabled = True
                btnViewScan.Enabled = True
                lblCmdToRun.Text = "Ready to Run"


            Else

                MsgBox("32-bit Executables could not validate!")
                txtFolderName.Enabled = True
                txtSvrShare.Enabled = True

            End If

        End If
    End Sub

    Private Sub chbUse64_CheckedChanged(sender As Object, e As EventArgs) Handles chbUse64.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCmdToRun.Click

    End Sub

    Private Sub lblVersion_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnViewCode_Click(sender As Object, e As EventArgs) Handles btnViewBackupArgs.Click
        If BackupRunPath = "" Then
            MessageBox.Show("A string has not yet been defined,  Please successfully validate a file path to continue.")
        Else
            MessageBox.Show(BackupRunPath)

        End If

    End Sub

    Private Sub btnRestoreNow_Click(sender As Object, e As EventArgs) Handles btnRestoreNow.Click
        Shell(RestoreRunPath, vbNormalFocus)
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MessageBox.Show(help, version)
    End Sub

    Private Sub btnViewRestoreArgs_Click(sender As Object, e As EventArgs) Handles btnViewRestoreArgs.Click
        If RestoreRunPath = "" Then
            MessageBox.Show("A string has not yet been defined,  Please successfully validate a file path to continue.")
        Else
            MessageBox.Show(RestoreRunPath)

        End If
    End Sub

    Private Sub btnViewLog_Click(sender As Object, e As EventArgs) Handles btnViewScan.Click
        If Dir(logdir & "\scan_log.txt") <> "" Then
            Shell("Notepad.exe " & logdir & "\scan_log.txt", vbNormalFocus)
        Else
            MessageBox.Show("File not found.  Perhaps it does not exist?")
        End If
    End Sub

    Private Sub btnViewLoad_Click(sender As Object, e As EventArgs) Handles btnViewLoad.Click
        If Dir(logdir & "\load_log.txt") <> "" Then
            Shell("Notepad.exe " & logdir & "\load_log.txt", vbNormalFocus)
        Else
            MessageBox.Show("File not found.  Perhaps it does not exist?")
        End If
    End Sub

End Class
