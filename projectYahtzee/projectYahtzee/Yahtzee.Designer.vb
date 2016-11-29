<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYahtzee
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(537, 406)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(178, 247)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 1
        Me.btnRoll.Text = "Roll"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'frmYahtzee
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmYahtzee"
        Me.Text = "Yahtzee Project"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnRoll As Button
End Class
