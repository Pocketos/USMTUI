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
        version = My.Application.Info.Title
        help = "First, type the server share name without the \.  Then, type a unique folder name for the data.  Click on Set to set or un set the values.  Then Click on Validate to check the values.  The Backup and Restore buttons will enable and can be clicked. "
    End Sub

    'Run Backup button launched the compiled command
    Private Sub btnBackupNow_Click(sender As Object, e As EventArgs) Handles btnBackupNow.Click
        Shell(BackupRunPath, vbNormalFocus)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVariables.Click
        If btnVariables.Text = "Set" Then
            usmtshare = txtSvrShare.Text
            usmtfolder = txtFolderName.Text
            txtFolderName.ReadOnly = True
            txtSvrShare.ReadOnly = True
            FullSvrPath64 = txtSvrShare.Text & "\Filesx64"
            FullSvrPath32 = txtSvrShare.Text & "\Files"
            btnVariables.Text = "Validating..."
            Validateinfo()
        Else
            usmtshare = ""
            usmtfolder = ""
            btnVariables.Text = "Set"
            txtFolderName.ReadOnly = False
            txtSvrShare.ReadOnly = False
            btnBackupNow.Enabled = False
            btnRestoreNow.Enabled = False
            chbUse64.Checked = False
        End If
        

    End Sub

    Private Sub Validateinfo()
        Dim is64 As Boolean
        Dim cpuID As String =
        My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0",
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
                btnVariables.Text = txtFolderName.Text & " settings are valid!"
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

            Else

                MsgBox("64-bit Executables could not validate!")
                txtFolderName.ReadOnly = False
                txtSvrShare.ReadOnly = False
                btnVariables.Text = "Try Again"

            End If

        Else


            If System.IO.Directory.Exists(FullSvrPath32) And txtFolderName.Text <> "" Then

                MsgBox("32-bit Executables validated Successfully!")
                btnVariables.Text = txtFolderName.Text & " settings are valid!"
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

            Else

                MsgBox("32-bit Executables could not validate!")
                txtFolderName.Enabled = True
                txtSvrShare.Enabled = True
                btnVariables.Text = "Try Again"

            End If

        End If
    End Sub

    Private Sub btnViewCode_Click(sender As Object, e As EventArgs) Handles btnViewBackupArgs.Click
        If BackupRunPath = "" Then
            MessageBox.Show("A string has not yet been defined. Please successfully validate a file path to continue.", "View Load Code", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            MessageBox.Show(BackupRunPath)

        End If

    End Sub

    Private Sub btnRestoreNow_Click(sender As Object, e As EventArgs) Handles btnRestoreNow.Click
        Shell(RestoreRunPath, vbNormalFocus)
    End Sub

    Private Sub btnViewRestoreArgs_Click(sender As Object, e As EventArgs) Handles btnViewRestoreArgs.Click
        If RestoreRunPath = "" Then
            MessageBox.Show("A string has not yet been defined. Please successfully validate a file path to continue.", "View Restore Code", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            MessageBox.Show(RestoreRunPath)

        End If
    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructionsToolStripMenuItem.Click
        MessageBox.Show(help, version)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show(My.Application.Info.Version.ToString, "Version")
    End Sub

    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        If Dir(logdir & "\load_log.txt") <> "" Then
            Shell("Notepad.exe " & logdir & "\load_log.txt", vbNormalFocus)
        Else
            MessageBox.Show("Perhaps it does not exist?", "Load Log not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub ScanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScanToolStripMenuItem.Click
        If Dir(logdir & "\scan_log.txt") <> "" Then
            Shell("Notepad.exe " & logdir & "\scan_log.txt", vbNormalFocus)
        Else
            MessageBox.Show("Perhaps it does not exist?", "Scan Log not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnBrowseServerShare_Click_1(sender As Object, e As EventArgs) Handles btnBrowseServerShare.Click
        FolderBrowser.SelectedPath = txtSvrShare.Text.ToString
        If (FolderBrowser.ShowDialog() = DialogResult.OK) Then
            txtSvrShare.Text = FolderBrowser.SelectedPath.ToString
        End If
    End Sub
End Class
