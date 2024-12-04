<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        btnOne = New Button()
        btnTwo = New Button()
        btnThree = New Button()
        btnFour = New Button()
        btnFive = New Button()
        btnExit = New Button()
        lblFrench = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(86, 30)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(324, 46)
        TextBox1.TabIndex = 9
        TextBox1.Text = "Do you know the French words for the numbers 1 through 5?"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(120, 81)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(246, 20)
        TextBox2.TabIndex = 10
        TextBox2.Text = "Click the bottons below to see them."
        ' 
        ' btnOne
        ' 
        btnOne.Location = New Point(86, 128)
        btnOne.Name = "btnOne"
        btnOne.Size = New Size(57, 29)
        btnOne.TabIndex = 2
        btnOne.Text = "1"
        btnOne.UseVisualStyleBackColor = True
        ' 
        ' btnTwo
        ' 
        btnTwo.Location = New Point(149, 128)
        btnTwo.Name = "btnTwo"
        btnTwo.Size = New Size(57, 29)
        btnTwo.TabIndex = 3
        btnTwo.Text = "2"
        btnTwo.UseVisualStyleBackColor = True
        ' 
        ' btnThree
        ' 
        btnThree.Location = New Point(212, 128)
        btnThree.Name = "btnThree"
        btnThree.Size = New Size(57, 29)
        btnThree.TabIndex = 4
        btnThree.Text = "3"
        btnThree.UseVisualStyleBackColor = True
        ' 
        ' btnFour
        ' 
        btnFour.Location = New Point(275, 128)
        btnFour.Name = "btnFour"
        btnFour.Size = New Size(57, 29)
        btnFour.TabIndex = 5
        btnFour.Text = "4"
        btnFour.UseVisualStyleBackColor = True
        ' 
        ' btnFive
        ' 
        btnFive.Location = New Point(338, 128)
        btnFive.Name = "btnFive"
        btnFive.Size = New Size(57, 29)
        btnFive.TabIndex = 6
        btnFive.Text = "5"
        btnFive.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(212, 208)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(57, 29)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblFrench
        ' 
        lblFrench.AutoSize = True
        lblFrench.BackColor = Color.Cyan
        lblFrench.Enabled = False
        lblFrench.Location = New Point(212, 173)
        lblFrench.Name = "lblFrench"
        lblFrench.Size = New Size(53, 20)
        lblFrench.TabIndex = 8
        lblFrench.Text = "Label1"
        lblFrench.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(477, 253)
        Controls.Add(lblFrench)
        Controls.Add(btnExit)
        Controls.Add(btnFive)
        Controls.Add(btnFour)
        Controls.Add(btnThree)
        Controls.Add(btnTwo)
        Controls.Add(btnOne)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        SizeGripStyle = SizeGripStyle.Show
        Text = "French Numbers"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnOne As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFrench As Label

End Class
