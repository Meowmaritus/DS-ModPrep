<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModPrep
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModPrep))
        Me.txtEXEfile = New System.Windows.Forms.TextBox()
        Me.lblGAFile = New System.Windows.Forms.Label()
        Me.txtInfo = New System.Windows.Forms.RichTextBox()
        Me.progCurFile = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.progOperation = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblProgCurFile = New System.Windows.Forms.Label()
        Me.lblProgOperation = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOpenEXE = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuPatch = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPatchOverwrite = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPatchNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCloseEXE = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOperation = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOperationExtract = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOperationExtractDVDBNDs = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOperationExtractDCXs = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOperationExtractBNDs = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOperationExtractBHDs = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOperationDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOperationDeleteDVDBNDs = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOperationDeleteDCXs = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOperationDeleteBNDs = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOperationDeleteBHDs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuOperationCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkSoulsModdingHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEXEfile
        '
        Me.txtEXEfile.AllowDrop = True
        resources.ApplyResources(Me.txtEXEfile, "txtEXEfile")
        Me.txtEXEfile.Name = "txtEXEfile"
        Me.txtEXEfile.ReadOnly = True
        '
        'lblGAFile
        '
        resources.ApplyResources(Me.lblGAFile, "lblGAFile")
        Me.lblGAFile.Name = "lblGAFile"
        '
        'txtInfo
        '
        Me.txtInfo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txtInfo, "txtInfo")
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ReadOnly = True
        Me.txtInfo.ShortcutsEnabled = False
        Me.txtInfo.ShowSelectionMargin = True
        Me.txtInfo.TabStop = False
        '
        'progCurFile
        '
        resources.ApplyResources(Me.progCurFile, "progCurFile")
        Me.progCurFile.MarqueeAnimationSpeed = 1
        Me.progCurFile.Maximum = 0
        Me.progCurFile.Name = "progCurFile"
        Me.progCurFile.Step = 1
        Me.progCurFile.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'progOperation
        '
        resources.ApplyResources(Me.progOperation, "progOperation")
        Me.progOperation.MarqueeAnimationSpeed = 0
        Me.progOperation.Maximum = 0
        Me.progOperation.Name = "progOperation"
        Me.progOperation.Step = 1
        Me.progOperation.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'lblProgCurFile
        '
        resources.ApplyResources(Me.lblProgCurFile, "lblProgCurFile")
        Me.lblProgCurFile.Name = "lblProgCurFile"
        '
        'lblProgOperation
        '
        resources.ApplyResources(Me.lblProgOperation, "lblProgOperation")
        Me.lblProgOperation.Name = "lblProgOperation"
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtInfo)
        Me.Panel1.Name = "Panel1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.menuOperation, Me.HelpToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuOpenEXE, Me.ToolStripSeparator1, Me.menuPatch, Me.menuCloseEXE, Me.ToolStripSeparator2, Me.menuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        resources.ApplyResources(Me.FileToolStripMenuItem, "FileToolStripMenuItem")
        '
        'menuOpenEXE
        '
        Me.menuOpenEXE.Name = "menuOpenEXE"
        resources.ApplyResources(Me.menuOpenEXE, "menuOpenEXE")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'menuPatch
        '
        Me.menuPatch.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuPatchOverwrite, Me.menuPatchNew})
        Me.menuPatch.Name = "menuPatch"
        resources.ApplyResources(Me.menuPatch, "menuPatch")
        '
        'menuPatchOverwrite
        '
        Me.menuPatchOverwrite.Name = "menuPatchOverwrite"
        resources.ApplyResources(Me.menuPatchOverwrite, "menuPatchOverwrite")
        '
        'menuPatchNew
        '
        Me.menuPatchNew.Checked = True
        Me.menuPatchNew.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuPatchNew.Name = "menuPatchNew"
        resources.ApplyResources(Me.menuPatchNew, "menuPatchNew")
        '
        'menuCloseEXE
        '
        Me.menuCloseEXE.Checked = True
        Me.menuCloseEXE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuCloseEXE.Name = "menuCloseEXE"
        resources.ApplyResources(Me.menuCloseEXE, "menuCloseEXE")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'menuExit
        '
        Me.menuExit.Name = "menuExit"
        resources.ApplyResources(Me.menuExit, "menuExit")
        '
        'menuOperation
        '
        Me.menuOperation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuOperationExtract, Me.menuOperationDelete, Me.ToolStripSeparator3, Me.menuOperationCancel})
        Me.menuOperation.Name = "menuOperation"
        resources.ApplyResources(Me.menuOperation, "menuOperation")
        '
        'menuOperationExtract
        '
        Me.menuOperationExtract.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuOperationExtractDVDBNDs, Me.menuOperationExtractDCXs, Me.menuOperationExtractBNDs, Me.menuOperationExtractBHDs})
        Me.menuOperationExtract.Name = "menuOperationExtract"
        resources.ApplyResources(Me.menuOperationExtract, "menuOperationExtract")
        '
        'menuOperationExtractDVDBNDs
        '
        Me.menuOperationExtractDVDBNDs.Name = "menuOperationExtractDVDBNDs"
        resources.ApplyResources(Me.menuOperationExtractDVDBNDs, "menuOperationExtractDVDBNDs")
        '
        'menuOperationExtractDCXs
        '
        Me.menuOperationExtractDCXs.Name = "menuOperationExtractDCXs"
        resources.ApplyResources(Me.menuOperationExtractDCXs, "menuOperationExtractDCXs")
        '
        'menuOperationExtractBNDs
        '
        Me.menuOperationExtractBNDs.Name = "menuOperationExtractBNDs"
        resources.ApplyResources(Me.menuOperationExtractBNDs, "menuOperationExtractBNDs")
        '
        'menuOperationExtractBHDs
        '
        Me.menuOperationExtractBHDs.Checked = True
        Me.menuOperationExtractBHDs.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuOperationExtractBHDs.Name = "menuOperationExtractBHDs"
        resources.ApplyResources(Me.menuOperationExtractBHDs, "menuOperationExtractBHDs")
        '
        'menuOperationDelete
        '
        Me.menuOperationDelete.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuOperationDeleteDVDBNDs, Me.menuOperationDeleteDCXs, Me.menuOperationDeleteBNDs, Me.menuOperationDeleteBHDs})
        Me.menuOperationDelete.Name = "menuOperationDelete"
        resources.ApplyResources(Me.menuOperationDelete, "menuOperationDelete")
        '
        'menuOperationDeleteDVDBNDs
        '
        resources.ApplyResources(Me.menuOperationDeleteDVDBNDs, "menuOperationDeleteDVDBNDs")
        Me.menuOperationDeleteDVDBNDs.Name = "menuOperationDeleteDVDBNDs"
        '
        'menuOperationDeleteDCXs
        '
        Me.menuOperationDeleteDCXs.Name = "menuOperationDeleteDCXs"
        resources.ApplyResources(Me.menuOperationDeleteDCXs, "menuOperationDeleteDCXs")
        '
        'menuOperationDeleteBNDs
        '
        resources.ApplyResources(Me.menuOperationDeleteBNDs, "menuOperationDeleteBNDs")
        Me.menuOperationDeleteBNDs.Name = "menuOperationDeleteBNDs"
        '
        'menuOperationDeleteBHDs
        '
        resources.ApplyResources(Me.menuOperationDeleteBHDs, "menuOperationDeleteBHDs")
        Me.menuOperationDeleteBHDs.Name = "menuOperationDeleteBHDs"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        '
        'menuOperationCancel
        '
        Me.menuOperationCancel.Checked = True
        Me.menuOperationCancel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuOperationCancel.Name = "menuOperationCancel"
        resources.ApplyResources(Me.menuOperationCancel, "menuOperationCancel")
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DarkSoulsModdingHelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        resources.ApplyResources(Me.HelpToolStripMenuItem, "HelpToolStripMenuItem")
        '
        'DarkSoulsModdingHelpToolStripMenuItem
        '
        Me.DarkSoulsModdingHelpToolStripMenuItem.Checked = True
        Me.DarkSoulsModdingHelpToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DarkSoulsModdingHelpToolStripMenuItem.Name = "DarkSoulsModdingHelpToolStripMenuItem"
        resources.ApplyResources(Me.DarkSoulsModdingHelpToolStripMenuItem, "DarkSoulsModdingHelpToolStripMenuItem")
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        resources.ApplyResources(Me.AboutToolStripMenuItem, "AboutToolStripMenuItem")
        '
        'frmModPrep
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblProgOperation)
        Me.Controls.Add(Me.lblProgCurFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.progOperation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.progCurFile)
        Me.Controls.Add(Me.txtEXEfile)
        Me.Controls.Add(Me.lblGAFile)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmModPrep"
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEXEfile As TextBox
    Friend WithEvents lblGAFile As Label
    Friend WithEvents txtInfo As RichTextBox
    Friend WithEvents progCurFile As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents progOperation As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents lblProgCurFile As Label
    Friend WithEvents lblProgOperation As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuOpenEXE As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents menuPatch As ToolStripMenuItem
    Friend WithEvents menuPatchOverwrite As ToolStripMenuItem
    Friend WithEvents menuPatchNew As ToolStripMenuItem
    Friend WithEvents menuCloseEXE As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents menuExit As ToolStripMenuItem
    Friend WithEvents menuOperation As ToolStripMenuItem
    Friend WithEvents menuOperationExtract As ToolStripMenuItem
    Friend WithEvents menuOperationExtractDVDBNDs As ToolStripMenuItem
    Friend WithEvents menuOperationExtractDCXs As ToolStripMenuItem
    Friend WithEvents menuOperationExtractBNDs As ToolStripMenuItem
    Friend WithEvents menuOperationExtractBHDs As ToolStripMenuItem
    Friend WithEvents menuOperationDelete As ToolStripMenuItem
    Friend WithEvents menuOperationDeleteDVDBNDs As ToolStripMenuItem
    Friend WithEvents menuOperationDeleteDCXs As ToolStripMenuItem
    Friend WithEvents menuOperationDeleteBNDs As ToolStripMenuItem
    Friend WithEvents menuOperationDeleteBHDs As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents menuOperationCancel As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkSoulsModdingHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
