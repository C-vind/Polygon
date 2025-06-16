<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPoly
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
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.LblCoor = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.LblColor = New System.Windows.Forms.Label()
        Me.BtnColor = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.LBoxPoly = New System.Windows.Forms.ListBox()
        Me.GBoxPoly = New System.Windows.Forms.GroupBox()
        Me.GBoxPoint = New System.Windows.Forms.GroupBox()
        Me.LBoxPoint = New System.Windows.Forms.ListBox()
        Me.BtnDelPoly = New System.Windows.Forms.Button()
        Me.BtnDelPoint = New System.Windows.Forms.Button()
        Me.RBtnPolyL = New System.Windows.Forms.RadioButton()
        Me.RBtnPoly = New System.Windows.Forms.RadioButton()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GBoxSize = New System.Windows.Forms.GroupBox()
        Me.RBtnFive = New System.Windows.Forms.RadioButton()
        Me.RBtnFour = New System.Windows.Forms.RadioButton()
        Me.RBtnThree = New System.Windows.Forms.RadioButton()
        Me.RBtnTwo = New System.Windows.Forms.RadioButton()
        Me.RBtnOne = New System.Windows.Forms.RadioButton()
        Me.BtnUnselect = New System.Windows.Forms.Button()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBoxPoly.SuspendLayout()
        Me.GBoxPoint.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GBoxSize.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicBox
        '
        Me.PicBox.BackColor = System.Drawing.SystemColors.HighlightText
        Me.PicBox.Location = New System.Drawing.Point(0, 23)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(570, 410)
        Me.PicBox.TabIndex = 0
        Me.PicBox.TabStop = False
        '
        'LblCoor
        '
        Me.LblCoor.AutoSize = True
        Me.LblCoor.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.LblCoor.Location = New System.Drawing.Point(3, 440)
        Me.LblCoor.Name = "LblCoor"
        Me.LblCoor.Size = New System.Drawing.Size(44, 13)
        Me.LblCoor.TabIndex = 1
        Me.LblCoor.Text = "( x , y ) :"
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnClear.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnClear.Location = New System.Drawing.Point(658, 27)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(69, 23)
        Me.BtnClear.TabIndex = 2
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'LblColor
        '
        Me.LblColor.AutoSize = True
        Me.LblColor.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.LblColor.Location = New System.Drawing.Point(579, 32)
        Me.LblColor.Name = "LblColor"
        Me.LblColor.Size = New System.Drawing.Size(40, 13)
        Me.LblColor.TabIndex = 3
        Me.LblColor.Text = "Color : "
        '
        'BtnColor
        '
        Me.BtnColor.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BtnColor.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnColor.Location = New System.Drawing.Point(619, 27)
        Me.BtnColor.Name = "BtnColor"
        Me.BtnColor.Size = New System.Drawing.Size(30, 23)
        Me.BtnColor.TabIndex = 4
        Me.BtnColor.UseVisualStyleBackColor = False
        '
        'LBoxPoly
        '
        Me.LBoxPoly.BackColor = System.Drawing.SystemColors.WindowText
        Me.LBoxPoly.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.LBoxPoly.FormattingEnabled = True
        Me.LBoxPoly.Location = New System.Drawing.Point(6, 19)
        Me.LBoxPoly.Name = "LBoxPoly"
        Me.LBoxPoly.Size = New System.Drawing.Size(94, 121)
        Me.LBoxPoly.TabIndex = 5
        '
        'GBoxPoly
        '
        Me.GBoxPoly.Controls.Add(Me.LBoxPoly)
        Me.GBoxPoly.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.GBoxPoly.Location = New System.Drawing.Point(582, 86)
        Me.GBoxPoly.Name = "GBoxPoly"
        Me.GBoxPoly.Size = New System.Drawing.Size(106, 148)
        Me.GBoxPoly.TabIndex = 6
        Me.GBoxPoly.TabStop = False
        Me.GBoxPoly.Text = "List Polygon"
        '
        'GBoxPoint
        '
        Me.GBoxPoint.Controls.Add(Me.LBoxPoint)
        Me.GBoxPoint.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.GBoxPoint.Location = New System.Drawing.Point(700, 86)
        Me.GBoxPoint.Name = "GBoxPoint"
        Me.GBoxPoint.Size = New System.Drawing.Size(143, 148)
        Me.GBoxPoint.TabIndex = 7
        Me.GBoxPoint.TabStop = False
        Me.GBoxPoint.Text = "List Point"
        '
        'LBoxPoint
        '
        Me.LBoxPoint.BackColor = System.Drawing.SystemColors.WindowText
        Me.LBoxPoint.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.LBoxPoint.FormattingEnabled = True
        Me.LBoxPoint.Location = New System.Drawing.Point(6, 19)
        Me.LBoxPoint.Name = "LBoxPoint"
        Me.LBoxPoint.Size = New System.Drawing.Size(131, 121)
        Me.LBoxPoint.TabIndex = 5
        '
        'BtnDelPoly
        '
        Me.BtnDelPoly.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnDelPoly.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnDelPoly.Location = New System.Drawing.Point(588, 243)
        Me.BtnDelPoly.Name = "BtnDelPoly"
        Me.BtnDelPoly.Size = New System.Drawing.Size(94, 23)
        Me.BtnDelPoly.TabIndex = 8
        Me.BtnDelPoly.Text = "Delete Polygon"
        Me.BtnDelPoly.UseVisualStyleBackColor = False
        '
        'BtnDelPoint
        '
        Me.BtnDelPoint.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnDelPoint.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnDelPoint.Location = New System.Drawing.Point(725, 243)
        Me.BtnDelPoint.Name = "BtnDelPoint"
        Me.BtnDelPoint.Size = New System.Drawing.Size(94, 23)
        Me.BtnDelPoint.TabIndex = 9
        Me.BtnDelPoint.Text = "Delete Point"
        Me.BtnDelPoint.UseVisualStyleBackColor = False
        '
        'RBtnPolyL
        '
        Me.RBtnPolyL.AutoSize = True
        Me.RBtnPolyL.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.RBtnPolyL.Location = New System.Drawing.Point(700, 61)
        Me.RBtnPolyL.Name = "RBtnPolyL"
        Me.RBtnPolyL.Size = New System.Drawing.Size(61, 17)
        Me.RBtnPolyL.TabIndex = 11
        Me.RBtnPolyL.TabStop = True
        Me.RBtnPolyL.Text = "Polyline"
        Me.RBtnPolyL.UseVisualStyleBackColor = True
        '
        'RBtnPoly
        '
        Me.RBtnPoly.AutoSize = True
        Me.RBtnPoly.Checked = True
        Me.RBtnPoly.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.RBtnPoly.Location = New System.Drawing.Point(582, 61)
        Me.RBtnPoly.Name = "RBtnPoly"
        Me.RBtnPoly.Size = New System.Drawing.Size(63, 17)
        Me.RBtnPoly.TabIndex = 10
        Me.RBtnPoly.TabStop = True
        Me.RBtnPoly.Text = "Polygon"
        Me.RBtnPoly.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnAdd.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnAdd.Location = New System.Drawing.Point(588, 275)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(94, 23)
        Me.BtnAdd.TabIndex = 12
        Me.BtnAdd.Text = "Add Point"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnEdit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnEdit.Location = New System.Drawing.Point(725, 275)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(94, 23)
        Me.BtnEdit.TabIndex = 13
        Me.BtnEdit.Text = "Edit Point"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.WindowText
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(854, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.LoadToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoadToolStripMenuItem.Text = "&Load"
        '
        'GBoxSize
        '
        Me.GBoxSize.Controls.Add(Me.RBtnFive)
        Me.GBoxSize.Controls.Add(Me.RBtnFour)
        Me.GBoxSize.Controls.Add(Me.RBtnThree)
        Me.GBoxSize.Controls.Add(Me.RBtnTwo)
        Me.GBoxSize.Controls.Add(Me.RBtnOne)
        Me.GBoxSize.ForeColor = System.Drawing.Color.White
        Me.GBoxSize.Location = New System.Drawing.Point(611, 308)
        Me.GBoxSize.Name = "GBoxSize"
        Me.GBoxSize.Size = New System.Drawing.Size(191, 39)
        Me.GBoxSize.TabIndex = 15
        Me.GBoxSize.TabStop = False
        Me.GBoxSize.Text = "Width"
        '
        'RBtnFive
        '
        Me.RBtnFive.AutoSize = True
        Me.RBtnFive.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.RBtnFive.Location = New System.Drawing.Point(154, 16)
        Me.RBtnFive.Name = "RBtnFive"
        Me.RBtnFive.Size = New System.Drawing.Size(31, 17)
        Me.RBtnFive.TabIndex = 19
        Me.RBtnFive.TabStop = True
        Me.RBtnFive.Text = "5"
        Me.RBtnFive.UseVisualStyleBackColor = True
        '
        'RBtnFour
        '
        Me.RBtnFour.AutoSize = True
        Me.RBtnFour.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.RBtnFour.Location = New System.Drawing.Point(117, 16)
        Me.RBtnFour.Name = "RBtnFour"
        Me.RBtnFour.Size = New System.Drawing.Size(31, 17)
        Me.RBtnFour.TabIndex = 18
        Me.RBtnFour.TabStop = True
        Me.RBtnFour.Text = "4"
        Me.RBtnFour.UseVisualStyleBackColor = True
        '
        'RBtnThree
        '
        Me.RBtnThree.AutoSize = True
        Me.RBtnThree.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.RBtnThree.Location = New System.Drawing.Point(80, 16)
        Me.RBtnThree.Name = "RBtnThree"
        Me.RBtnThree.Size = New System.Drawing.Size(31, 17)
        Me.RBtnThree.TabIndex = 17
        Me.RBtnThree.TabStop = True
        Me.RBtnThree.Text = "3"
        Me.RBtnThree.UseVisualStyleBackColor = True
        '
        'RBtnTwo
        '
        Me.RBtnTwo.AutoSize = True
        Me.RBtnTwo.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.RBtnTwo.Location = New System.Drawing.Point(43, 16)
        Me.RBtnTwo.Name = "RBtnTwo"
        Me.RBtnTwo.Size = New System.Drawing.Size(31, 17)
        Me.RBtnTwo.TabIndex = 16
        Me.RBtnTwo.TabStop = True
        Me.RBtnTwo.Text = "2"
        Me.RBtnTwo.UseVisualStyleBackColor = True
        '
        'RBtnOne
        '
        Me.RBtnOne.AutoSize = True
        Me.RBtnOne.Checked = True
        Me.RBtnOne.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.RBtnOne.Location = New System.Drawing.Point(6, 16)
        Me.RBtnOne.Name = "RBtnOne"
        Me.RBtnOne.Size = New System.Drawing.Size(31, 17)
        Me.RBtnOne.TabIndex = 16
        Me.RBtnOne.TabStop = True
        Me.RBtnOne.Text = "1"
        Me.RBtnOne.UseVisualStyleBackColor = True
        '
        'BtnUnselect
        '
        Me.BtnUnselect.BackColor = System.Drawing.SystemColors.WindowText
        Me.BtnUnselect.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnUnselect.Location = New System.Drawing.Point(735, 27)
        Me.BtnUnselect.Name = "BtnUnselect"
        Me.BtnUnselect.Size = New System.Drawing.Size(102, 23)
        Me.BtnUnselect.TabIndex = 16
        Me.BtnUnselect.Text = "Unselect List"
        Me.BtnUnselect.UseVisualStyleBackColor = False
        '
        'FormPoly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowText
        Me.ClientSize = New System.Drawing.Size(854, 461)
        Me.Controls.Add(Me.BtnUnselect)
        Me.Controls.Add(Me.GBoxSize)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.RBtnPolyL)
        Me.Controls.Add(Me.RBtnPoly)
        Me.Controls.Add(Me.BtnDelPoint)
        Me.Controls.Add(Me.BtnDelPoly)
        Me.Controls.Add(Me.GBoxPoint)
        Me.Controls.Add(Me.GBoxPoly)
        Me.Controls.Add(Me.BtnColor)
        Me.Controls.Add(Me.LblColor)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.LblCoor)
        Me.Controls.Add(Me.PicBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormPoly"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreatePolygon"
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBoxPoly.ResumeLayout(False)
        Me.GBoxPoint.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GBoxSize.ResumeLayout(False)
        Me.GBoxSize.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicBox As PictureBox
    Friend WithEvents LblCoor As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents LblColor As Label
    Friend WithEvents BtnColor As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents LBoxPoly As ListBox
    Friend WithEvents GBoxPoly As GroupBox
    Friend WithEvents GBoxPoint As GroupBox
    Friend WithEvents LBoxPoint As ListBox
    Friend WithEvents BtnDelPoly As Button
    Friend WithEvents BtnDelPoint As Button
    Friend WithEvents RBtnPolyL As RadioButton
    Friend WithEvents RBtnPoly As RadioButton
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GBoxSize As GroupBox
    Friend WithEvents RBtnFive As RadioButton
    Friend WithEvents RBtnFour As RadioButton
    Friend WithEvents RBtnThree As RadioButton
    Friend WithEvents RBtnTwo As RadioButton
    Friend WithEvents RBtnOne As RadioButton
    Friend WithEvents BtnUnselect As Button
End Class
