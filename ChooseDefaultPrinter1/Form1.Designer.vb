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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lstPrinterList = New System.Windows.Forms.ListBox()
        Me.Help = New System.Windows.Forms.Button()
        Me.cmdOpenPrintersFolder = New System.Windows.Forms.Button()
        Me.cmdRefreshPrinterList = New System.Windows.Forms.Button()
        Me.cmdSetDefaultPrinter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(9, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(390, 26)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Choose your printer from the list below:"
        '
        'lstPrinterList
        '
        Me.lstPrinterList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPrinterList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPrinterList.FormattingEnabled = True
        Me.lstPrinterList.ItemHeight = 24
        Me.lstPrinterList.Location = New System.Drawing.Point(14, 38)
        Me.lstPrinterList.Name = "lstPrinterList"
        Me.lstPrinterList.Size = New System.Drawing.Size(475, 220)
        Me.lstPrinterList.TabIndex = 1
        '
        'Help
        '
        Me.Help.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Help.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Help.Image = Global.ChooseDefaultPrinter.My.Resources.Resources.Question_16x
        Me.Help.Location = New System.Drawing.Point(293, 293)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(196, 54)
        Me.Help.TabIndex = 5
        Me.Help.Text = "Help"
        Me.Help.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Help.UseVisualStyleBackColor = True
        '
        'cmdOpenPrintersFolder
        '
        Me.cmdOpenPrintersFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOpenPrintersFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpenPrintersFolder.Image = Global.ChooseDefaultPrinter.My.Resources.Resources.PrintStatusBar1_16x
        Me.cmdOpenPrintersFolder.Location = New System.Drawing.Point(14, 293)
        Me.cmdOpenPrintersFolder.Name = "cmdOpenPrintersFolder"
        Me.cmdOpenPrintersFolder.Size = New System.Drawing.Size(273, 54)
        Me.cmdOpenPrintersFolder.TabIndex = 4
        Me.cmdOpenPrintersFolder.Text = "Open Printers Folder"
        Me.cmdOpenPrintersFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdOpenPrintersFolder.UseVisualStyleBackColor = True
        '
        'cmdRefreshPrinterList
        '
        Me.cmdRefreshPrinterList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdRefreshPrinterList.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefreshPrinterList.Image = Global.ChooseDefaultPrinter.My.Resources.Resources.Refresh_16x
        Me.cmdRefreshPrinterList.Location = New System.Drawing.Point(293, 356)
        Me.cmdRefreshPrinterList.Name = "cmdRefreshPrinterList"
        Me.cmdRefreshPrinterList.Size = New System.Drawing.Size(196, 54)
        Me.cmdRefreshPrinterList.TabIndex = 3
        Me.cmdRefreshPrinterList.Text = "Refresh List"
        Me.cmdRefreshPrinterList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdRefreshPrinterList.UseVisualStyleBackColor = True
        '
        'cmdSetDefaultPrinter
        '
        Me.cmdSetDefaultPrinter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdSetDefaultPrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetDefaultPrinter.Image = Global.ChooseDefaultPrinter.My.Resources.Resources.Checkmark_16x
        Me.cmdSetDefaultPrinter.Location = New System.Drawing.Point(14, 356)
        Me.cmdSetDefaultPrinter.Name = "cmdSetDefaultPrinter"
        Me.cmdSetDefaultPrinter.Size = New System.Drawing.Size(273, 54)
        Me.cmdSetDefaultPrinter.TabIndex = 2
        Me.cmdSetDefaultPrinter.Text = "Set as Default"
        Me.cmdSetDefaultPrinter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdSetDefaultPrinter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Current Default:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 417)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Help)
        Me.Controls.Add(Me.cmdOpenPrintersFolder)
        Me.Controls.Add(Me.cmdRefreshPrinterList)
        Me.Controls.Add(Me.cmdSetDefaultPrinter)
        Me.Controls.Add(Me.lstPrinterList)
        Me.Controls.Add(Me.lblHeader)
        Me.MinimumSize = New System.Drawing.Size(520, 456)
        Me.Name = "frmMain"
        Me.Text = "Default Printer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lstPrinterList As ListBox
    Friend WithEvents cmdSetDefaultPrinter As Button
    Friend WithEvents cmdRefreshPrinterList As Button
    Friend WithEvents Help As Button
    Friend WithEvents cmdOpenPrintersFolder As Button
    Friend WithEvents Label1 As Label
End Class
