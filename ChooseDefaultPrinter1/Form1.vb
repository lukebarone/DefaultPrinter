Imports System.Drawing.Printing
Public Class frmMain
    Public Shared ReadOnly Property InstalledPrinters As PrinterSettings.StringCollection
    Public DefaultPrinter As String
    Private Declare Auto Function SetDefaultPrinter_API Lib "winspool.drv" Alias "SetDefaultPrinter" _
        (ByVal pszPrinter As String) As Boolean
    Public Shared Sub SetPrinter(ByVal NewDefaultPrinter As String)
        ' The magic sub! Attempts to set the printer. This should be called only after the LetUsManageIt
        '   function returns true, although no error is thrown if it has not been.
        If Not SetDefaultPrinter_API(NewDefaultPrinter) Then
            MessageBox.Show("Could Not set printer")
        End If
    End Sub
    Public Sub LoadPrinters()
        ' Clears the list of printers, and refreshes the list. If there is an exception, display an
        '   error dialog. Then clear any selection.
        lstPrinterList.Items.Clear()
        Dim i As Integer
        Dim pkInstalledPrinters As String
        Try
            For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
                pkInstalledPrinters = PrinterSettings.InstalledPrinters.Item(i)
                lstPrinterList.Items.Add(pkInstalledPrinters)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

        lstPrinterList.ClearSelected()
        cmdSetDefaultPrinter.Enabled = False
    End Sub
    Public Function GetDefaultPrinter() As String
        ' Returns the current Default Printer as a string. If there is an error, return nothing.
        Dim oPS As New System.Drawing.Printing.PrinterSettings
        Dim DefaultPrinterName As String
        Try
            DefaultPrinterName = oPS.PrinterName
            Return DefaultPrinterName
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Capturing Default Printer", MessageBoxButtons.OK)
        Finally
            oPS = Nothing
        End Try
        Return Nothing
    End Function
    Public Function LetUsManageIt() As Boolean
        ' Returns TRUE if we are able to choose the default printer ourself. Returns FALSE on error
        ' Windows 10 wants to manage your default printer, by default. We need to turn off that option
        '   in order to choose a default printer ourself. Based on initial testing, this setting is
        '   not used in previous versions of Windows, so it doesn't hurt to add it.
        Dim RegKey As String = "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Windows"
        Dim RegName As String = "LegacyDefaultPrinterMode"
        If (My.Computer.Registry.GetValue(RegKey, RegName, 1)) Then ' The entry exists, and is correct
            Return True
        Else
            ' Set the Registry Entry to allow us to manage the default printer (Windows 10)
            My.Computer.Registry.SetValue(RegKey, RegName, 1, Microsoft.Win32.RegistryValueKind.DWord)

            ' Re-run the check. If it is now True (the registry write went OK), then we will return True
            If LetUsManageIt Then Return True
        End If

        ' Some sort of error in the Current User context. Don't do anything.
        Return False
    End Function
    Public Sub UpdateDefaultPrinterLabel()
        ' Updates the Default Printer label, and chooses the default printer from the list
        DefaultPrinter = GetDefaultPrinter()
        If DefaultPrinter <> Nothing Then
            lstPrinterList.SelectedItem = DefaultPrinter
            Label1.Text = "Current Default: " & DefaultPrinter
        End If
    End Sub
    Private Sub frmLoad_Load(sender As Object, e As EventArgs) Handles MyBase.Load, cmdRefreshPrinterList.Click
        LoadPrinters()
        UpdateDefaultPrinterLabel()
    End Sub

    Private Sub cmdSetDefaultPrinter_Click(sender As Object, e As EventArgs) Handles cmdSetDefaultPrinter.Click, lstPrinterList.DoubleClick
        ' The magic button! Checks if we are able to manage the printers ourselves; if we can, set the
        '   default printer to what is chosen in the list.
        If LetUsManageIt() Then
            SetPrinter(DefaultPrinter)
        End If
        UpdateDefaultPrinterLabel()
    End Sub

    Private Sub lstPrinterList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPrinterList.SelectedIndexChanged
        ' We only want to enable the "Set Default Printer" button when a new printer is selected.
        If lstPrinterList.SelectedIndex > 0 AndAlso lstPrinterList.SelectedIndex < lstPrinterList.Items.Count - 1 Then
            cmdSetDefaultPrinter.Enabled = True
            DefaultPrinter = lstPrinterList.SelectedItem.ToString
        End If
    End Sub

    Private Sub cmdOpenPrintersFolder_Click(sender As Object, e As EventArgs) Handles cmdOpenPrintersFolder.Click
        ' Opens the "Printers" folder in Explorer. Different from the Devices and Printers folder (Vista
        '   and higher), as it shows every Printer Queue individually.
        Process.Start("C:\Windows\explorer.exe", "shell:::{2227A280-3AEA-1069-A2DE-08002B30309D}")
    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click
        AboutBox1.Show(Me)
    End Sub

End Class
