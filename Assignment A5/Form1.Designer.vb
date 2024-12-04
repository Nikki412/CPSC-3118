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
        lblTItle = New Label()
        lblGroupSize = New Label()
        txtSize = New TextBox()
        gbBadgeType = New GroupBox()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        lblRCost = New Label()
        lblTotal = New Label()
        btnCalculate = New Button()
        btnClear = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        gbBadgeType.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-7, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(708, 212)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblTItle
        ' 
        lblTItle.AutoSize = True
        lblTItle.Font = New Font("Comic Sans MS", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTItle.ForeColor = Color.Chocolate
        lblTItle.Location = New Point(49, 212)
        lblTItle.Name = "lblTItle"
        lblTItle.Size = New Size(599, 55)
        lblTItle.TabIndex = 1
        lblTItle.Text = "Comic Convention Registration"
        ' 
        ' lblGroupSize
        ' 
        lblGroupSize.AutoSize = True
        lblGroupSize.Font = New Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGroupSize.ForeColor = Color.Chocolate
        lblGroupSize.Location = New Point(210, 291)
        lblGroupSize.Name = "lblGroupSize"
        lblGroupSize.Size = New Size(153, 26)
        lblGroupSize.TabIndex = 2
        lblGroupSize.Text = "Group Size: "
        ' 
        ' txtSize
        ' 
        txtSize.Font = New Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSize.ForeColor = Color.Chocolate
        txtSize.Location = New Point(402, 283)
        txtSize.Name = "txtSize"
        txtSize.Size = New Size(60, 34)
        txtSize.TabIndex = 3
        txtSize.TextAlign = HorizontalAlignment.Center
        ' 
        ' gbBadgeType
        ' 
        gbBadgeType.BackColor = Color.FromArgb(CByte(69), CByte(185), CByte(214))
        gbBadgeType.Controls.Add(RadioButton3)
        gbBadgeType.Controls.Add(RadioButton2)
        gbBadgeType.Controls.Add(RadioButton1)
        gbBadgeType.Font = New Font("Broadway", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbBadgeType.ForeColor = Color.Chocolate
        gbBadgeType.Location = New Point(99, 336)
        gbBadgeType.Name = "gbBadgeType"
        gbBadgeType.Size = New Size(494, 171)
        gbBadgeType.TabIndex = 4
        gbBadgeType.TabStop = False
        gbBadgeType.Text = "Select Badge Type: "
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Checked = True
        RadioButton3.Location = New Point(41, 130)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(165, 26)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Convention"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(41, 79)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(329, 26)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Convention + Autographs"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(41, 33)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(453, 26)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Convention + Superhero Experience"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' lblRCost
        ' 
        lblRCost.AutoSize = True
        lblRCost.Font = New Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRCost.ForeColor = Color.Chocolate
        lblRCost.Location = New Point(140, 535)
        lblRCost.Name = "lblRCost"
        lblRCost.Size = New Size(230, 26)
        lblRCost.TabIndex = 5
        lblRCost.Text = "Registration Cost: "
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotal.ForeColor = Color.Chocolate
        lblTotal.Location = New Point(449, 535)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(0, 26)
        lblTotal.TabIndex = 6
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.FromArgb(CByte(69), CByte(185), CByte(214))
        btnCalculate.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalculate.Location = New Point(88, 582)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(204, 59)
        btnCalculate.TabIndex = 7
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(69), CByte(185), CByte(214))
        btnClear.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(402, 582)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(204, 59)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(702, 653)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(lblTotal)
        Controls.Add(lblRCost)
        Controls.Add(gbBadgeType)
        Controls.Add(txtSize)
        Controls.Add(lblGroupSize)
        Controls.Add(lblTItle)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        gbBadgeType.ResumeLayout(False)
        gbBadgeType.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTItle As Label
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents txtSize As TextBox
    Friend WithEvents gbBadgeType As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents lblRCost As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button

End Class
