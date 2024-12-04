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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        lblTitle = New Label()
        lblStore = New Label()
        GroupBox1 = New GroupBox()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        GroupBox2 = New GroupBox()
        RadioButton7 = New RadioButton()
        RadioButton6 = New RadioButton()
        lblLoyalty = New Label()
        txtPoints = New TextBox()
        btnCalculate = New Button()
        btnClear = New Button()
        lblPay = New Label()
        lblResults = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(355, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(415, 271)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(100, 12)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(114, 28)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Catering"
        ' 
        ' lblStore
        ' 
        lblStore.AutoSize = True
        lblStore.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStore.Location = New Point(90, 40)
        lblStore.Name = "lblStore"
        lblStore.Size = New Size(106, 23)
        lblStore.TabIndex = 2
        lblStore.Text = "Star Market"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.PapayaWhip
        GroupBox1.Controls.Add(RadioButton5)
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Location = New Point(28, 109)
        GroupBox1.Margin = New Padding(0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(0)
        GroupBox1.Size = New Size(302, 208)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton5.Location = New Point(20, 165)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(137, 21)
        RadioButton5.TabIndex = 8
        RadioButton5.TabStop = True
        RadioButton5.Text = "Fruit $29.99"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton4.Location = New Point(20, 130)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(254, 21)
        RadioButton4.TabIndex = 7
        RadioButton4.TabStop = True
        RadioButton4.Text = "Sausage and Chesse $49.99"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton3.Location = New Point(20, 95)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(146, 21)
        RadioButton3.TabIndex = 6
        RadioButton3.TabStop = True
        RadioButton3.Text = "Veggie $29.99"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton2.Location = New Point(20, 60)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(218, 21)
        RadioButton2.TabIndex = 5
        RadioButton2.TabStop = True
        RadioButton2.Text = "Pinwheel Wraps $59.99"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.Checked = True
        RadioButton1.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(20, 25)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(220, 20)
        RadioButton1.TabIndex = 5
        RadioButton1.TabStop = True
        RadioButton1.Text = "Gourmet Cheese $49.99"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.PapayaWhip
        GroupBox2.Controls.Add(RadioButton7)
        GroupBox2.Controls.Add(RadioButton6)
        GroupBox2.Location = New Point(80, 360)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(204, 77)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        ' 
        ' RadioButton7
        ' 
        RadioButton7.AutoSize = True
        RadioButton7.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton7.Location = New Point(20, 47)
        RadioButton7.Name = "RadioButton7"
        RadioButton7.Size = New Size(164, 21)
        RadioButton7.TabIndex = 6
        RadioButton7.TabStop = True
        RadioButton7.Text = "Pay upon Pickup"
        RadioButton7.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Checked = True
        RadioButton6.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton6.Location = New Point(20, 16)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(92, 21)
        RadioButton6.TabIndex = 5
        RadioButton6.TabStop = True
        RadioButton6.Text = "Pre-Pay"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' lblLoyalty
        ' 
        lblLoyalty.AutoSize = True
        lblLoyalty.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLoyalty.Location = New Point(430, 297)
        lblLoyalty.Name = "lblLoyalty"
        lblLoyalty.Size = New Size(99, 20)
        lblLoyalty.TabIndex = 5
        lblLoyalty.Text = "Loyalty Points "
        ' 
        ' txtPoints
        ' 
        txtPoints.Location = New Point(596, 297)
        txtPoints.Name = "txtPoints"
        txtPoints.Size = New Size(54, 27)
        txtPoints.TabIndex = 6
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.NavajoWhite
        btnCalculate.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCalculate.Location = New Point(417, 399)
        btnCalculate.Margin = New Padding(0)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(94, 29)
        btnCalculate.TabIndex = 0
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.NavajoWhite
        btnClear.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(580, 399)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' lblPay
        ' 
        lblPay.AutoSize = True
        lblPay.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPay.Location = New Point(28, 485)
        lblPay.Name = "lblPay"
        lblPay.Size = New Size(97, 17)
        lblPay.TabIndex = 9
        lblPay.Text = "Please Pay: "
        ' 
        ' lblResults
        ' 
        lblResults.AutoSize = True
        lblResults.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblResults.Location = New Point(125, 485)
        lblResults.Name = "lblResults"
        lblResults.Size = New Size(0, 17)
        lblResults.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.NavajoWhite
        ClientSize = New Size(832, 553)
        Controls.Add(lblResults)
        Controls.Add(lblPay)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(txtPoints)
        Controls.Add(lblLoyalty)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(lblStore)
        Controls.Add(lblTitle)
        Controls.Add(PictureBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Catering"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblStore As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents lblLoyalty As Label
    Friend WithEvents txtPoints As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblPay As Label
    Friend WithEvents lblResults As Label

End Class
