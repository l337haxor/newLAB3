<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLAB3
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolTipAverageShipped = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblOutputEmployee3 = New System.Windows.Forms.Label()
        Me.lblOutputEmployee2 = New System.Windows.Forms.Label()
        Me.lblOutputEmployee1 = New System.Windows.Forms.Label()
        Me.txtEmployee1 = New System.Windows.Forms.TextBox()
        Me.txtEmployee2 = New System.Windows.Forms.TextBox()
        Me.txtEmployee3 = New System.Windows.Forms.TextBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(22, 343)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(94, 49)
        Me.btnEnter.TabIndex = 19
        Me.btnEnter.Text = "&Enter"
        Me.ToolTipAverageShipped.SetToolTip(Me.btnEnter, "Click to calculate the semester average.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(141, 343)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(94, 49)
        Me.btnReset.TabIndex = 20
        Me.btnReset.Text = "&Reset"
        Me.ToolTipAverageShipped.SetToolTip(Me.btnReset, "Click to reset the form.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(259, 343)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 49)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "E&xit"
        Me.ToolTipAverageShipped.SetToolTip(Me.btnExit, "Click to exit program.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.ForeColor = System.Drawing.Color.Red
        Me.lblOutput.Location = New System.Drawing.Point(22, 294)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(331, 23)
        Me.lblOutput.TabIndex = 18
        '
        'lblOutputEmployee3
        '
        Me.lblOutputEmployee3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputEmployee3.Location = New System.Drawing.Point(250, 246)
        Me.lblOutputEmployee3.Name = "lblOutputEmployee3"
        Me.lblOutputEmployee3.Size = New System.Drawing.Size(103, 30)
        Me.lblOutputEmployee3.TabIndex = 27
        Me.lblOutputEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutputEmployee2
        '
        Me.lblOutputEmployee2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputEmployee2.Location = New System.Drawing.Point(136, 246)
        Me.lblOutputEmployee2.Name = "lblOutputEmployee2"
        Me.lblOutputEmployee2.Size = New System.Drawing.Size(103, 30)
        Me.lblOutputEmployee2.TabIndex = 26
        Me.lblOutputEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutputEmployee1
        '
        Me.lblOutputEmployee1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputEmployee1.Location = New System.Drawing.Point(22, 246)
        Me.lblOutputEmployee1.Name = "lblOutputEmployee1"
        Me.lblOutputEmployee1.Size = New System.Drawing.Size(103, 30)
        Me.lblOutputEmployee1.TabIndex = 25
        Me.lblOutputEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmployee1
        '
        Me.txtEmployee1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtEmployee1.Location = New System.Drawing.Point(22, 117)
        Me.txtEmployee1.Multiline = True
        Me.txtEmployee1.Name = "txtEmployee1"
        Me.txtEmployee1.ReadOnly = True
        Me.txtEmployee1.Size = New System.Drawing.Size(103, 121)
        Me.txtEmployee1.TabIndex = 28
        '
        'txtEmployee2
        '
        Me.txtEmployee2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtEmployee2.Location = New System.Drawing.Point(136, 117)
        Me.txtEmployee2.Multiline = True
        Me.txtEmployee2.Name = "txtEmployee2"
        Me.txtEmployee2.ReadOnly = True
        Me.txtEmployee2.Size = New System.Drawing.Size(103, 121)
        Me.txtEmployee2.TabIndex = 29
        '
        'txtEmployee3
        '
        Me.txtEmployee3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtEmployee3.Location = New System.Drawing.Point(250, 117)
        Me.txtEmployee3.Multiline = True
        Me.txtEmployee3.Name = "txtEmployee3"
        Me.txtEmployee3.ReadOnly = True
        Me.txtEmployee3.Size = New System.Drawing.Size(103, 121)
        Me.txtEmployee3.TabIndex = 30
        '
        'lblUnits
        '
        Me.lblUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnits.Location = New System.Drawing.Point(19, 63)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(62, 23)
        Me.lblUnits.TabIndex = 31
        Me.lblUnits.Text = "Units:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(76, 67)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(49, 20)
        Me.txtInput.TabIndex = 32
        '
        'lblDay
        '
        Me.lblDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(19, 24)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(106, 23)
        Me.lblDay.TabIndex = 33
        Me.lblDay.Text = "Day:"
        '
        'lblEmployee1
        '
        Me.lblEmployee1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee1.Location = New System.Drawing.Point(32, 94)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(115, 23)
        Me.lblEmployee1.TabIndex = 34
        Me.lblEmployee1.Text = "Employee &1"
        '
        'lblEmployee2
        '
        Me.lblEmployee2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee2.Location = New System.Drawing.Point(151, 94)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(115, 23)
        Me.lblEmployee2.TabIndex = 35
        Me.lblEmployee2.Text = "Employee &2"
        '
        'lblEmployee3
        '
        Me.lblEmployee3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee3.Location = New System.Drawing.Point(264, 94)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(115, 23)
        Me.lblEmployee3.TabIndex = 36
        Me.lblEmployee3.Text = "Employee &3"
        '
        'frmLAB3
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(374, 405)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.txtEmployee3)
        Me.Controls.Add(Me.txtEmployee2)
        Me.Controls.Add(Me.txtEmployee1)
        Me.Controls.Add(Me.lblOutputEmployee3)
        Me.Controls.Add(Me.lblOutputEmployee2)
        Me.Controls.Add(Me.lblOutputEmployee1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblOutput)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLAB3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average units shipped per employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTipAverageShipped As ToolTip
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblOutputEmployee3 As Label
    Friend WithEvents lblOutputEmployee2 As Label
    Friend WithEvents lblOutputEmployee1 As Label
    Friend WithEvents txtEmployee1 As TextBox
    Friend WithEvents txtEmployee2 As TextBox
    Friend WithEvents txtEmployee3 As TextBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblDay As Label
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
End Class
