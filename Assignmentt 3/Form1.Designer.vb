<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBurgers
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
        lblHeading = New Label()
        picPrime = New PictureBox()
        picVeggie = New PictureBox()
        btnPrime = New Button()
        btnSelectMeal = New Button()
        Button1 = New Button()
        lblInstructions = New Label()
        lblConfirmation = New Label()
        btnExit = New Button()
        CType(picPrime, ComponentModel.ISupportInitialize).BeginInit()
        CType(picVeggie, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.Font = New Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(230, 9)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(350, 33)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Farm Burger Specials"
        lblHeading.TextAlign = ContentAlignment.TopCenter
        ' 
        ' picPrime
        ' 
        picPrime.Location = New Point(92, 68)
        picPrime.Name = "picPrime"
        picPrime.Size = New Size(260, 250)
        picPrime.TabIndex = 1
        picPrime.TabStop = False
        ' 
        ' picVeggie
        ' 
        picVeggie.Location = New Point(461, 68)
        picVeggie.Name = "picVeggie"
        picVeggie.Size = New Size(260, 250)
        picVeggie.TabIndex = 2
        picVeggie.TabStop = False
        ' 
        ' btnPrime
        ' 
        btnPrime.Location = New Point(152, 345)
        btnPrime.Name = "btnPrime"
        btnPrime.Size = New Size(128, 35)
        btnPrime.TabIndex = 3
        btnPrime.Text = "Prime Beef"
        btnPrime.UseVisualStyleBackColor = True
        ' 
        ' btnSelectMeal
        ' 
        btnSelectMeal.Location = New Point(345, 345)
        btnSelectMeal.Name = "btnSelectMeal"
        btnSelectMeal.Size = New Size(128, 35)
        btnSelectMeal.TabIndex = 4
        btnSelectMeal.Text = "Select Meal"
        btnSelectMeal.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(526, 345)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 35)
        Button1.TabIndex = 5
        Button1.Text = "Veggie"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblInstructions
        ' 
        lblInstructions.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblInstructions.Location = New Point(230, 412)
        lblInstructions.Name = "lblInstructions"
        lblInstructions.Size = New Size(360, 18)
        lblInstructions.TabIndex = 6
        lblInstructions.Text = "Choose a burger and then click the Select Meal button"
        ' 
        ' lblConfirmation
        ' 
        lblConfirmation.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblConfirmation.Location = New Point(321, 439)
        lblConfirmation.Name = "lblConfirmation"
        lblConfirmation.Size = New Size(172, 18)
        lblConfirmation.TabIndex = 7
        lblConfirmation.Text = "Enjoy your burger special"
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(345, 477)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(128, 35)
        btnExit.TabIndex = 8
        btnExit.Text = "Exit Window"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmBurgers
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(782, 543)
        Controls.Add(btnExit)
        Controls.Add(lblConfirmation)
        Controls.Add(lblInstructions)
        Controls.Add(Button1)
        Controls.Add(btnSelectMeal)
        Controls.Add(btnPrime)
        Controls.Add(picVeggie)
        Controls.Add(picPrime)
        Controls.Add(lblHeading)
        Name = "frmBurgers"
        Text = "Burger Specials"
        CType(picPrime, ComponentModel.ISupportInitialize).EndInit()
        CType(picVeggie, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picPrime As PictureBox
    Friend WithEvents picVeggie As PictureBox
    Friend WithEvents btnPrime As Button
    Friend WithEvents btnSelectMeal As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents btnExit As Button

End Class
