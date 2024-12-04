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
        picPayroll = New PictureBox()
        lblCalculator = New Label()
        lblCalculation = New Label()
        lblPay = New Label()
        btnCompute = New Button()
        btnClear = New Button()
        btnExit = New Button()
        txtPay = New TextBox()
        lblFica = New Label()
        lblFederal = New Label()
        lblState = New Label()
        lblIncome = New Label()
        CType(picPayroll, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picPayroll
        ' 
        picPayroll.ErrorImage = CType(resources.GetObject("picPayroll.ErrorImage"), Image)
        picPayroll.Image = CType(resources.GetObject("picPayroll.Image"), Image)
        picPayroll.InitialImage = CType(resources.GetObject("picPayroll.InitialImage"), Image)
        picPayroll.Location = New Point(0, 0)
        picPayroll.Name = "picPayroll"
        picPayroll.Size = New Size(396, 264)
        picPayroll.SizeMode = PictureBoxSizeMode.Zoom
        picPayroll.TabIndex = 0
        picPayroll.TabStop = False
        ' 
        ' lblCalculator
        ' 
        lblCalculator.AutoSize = True
        lblCalculator.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCalculator.Location = New Point(434, 33)
        lblCalculator.Name = "lblCalculator"
        lblCalculator.Size = New Size(298, 35)
        lblCalculator.TabIndex = 1
        lblCalculator.Text = "Payroll Calculator"
        ' 
        ' lblCalculation
        ' 
        lblCalculation.Font = New Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCalculation.Location = New Point(493, 121)
        lblCalculation.Name = "lblCalculation"
        lblCalculation.Size = New Size(182, 68)
        lblCalculation.TabIndex = 2
        lblCalculation.Text = "Paycheck Calculation"
        lblCalculation.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPay
        ' 
        lblPay.AutoSize = True
        lblPay.Font = New Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPay.Location = New Point(257, 277)
        lblPay.Name = "lblPay"
        lblPay.Size = New Size(211, 28)
        lblPay.TabIndex = 3
        lblPay.Text = "Enter Gross Pay: "
        ' 
        ' btnCompute
        ' 
        btnCompute.BackColor = SystemColors.Highlight
        btnCompute.Font = New Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCompute.ForeColor = SystemColors.ButtonHighlight
        btnCompute.Location = New Point(141, 342)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(150, 40)
        btnCompute.TabIndex = 4
        btnCompute.Text = "Compute Taxes"
        btnCompute.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.Highlight
        btnClear.Font = New Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = SystemColors.ButtonHighlight
        btnClear.Location = New Point(347, 342)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(150, 40)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.Highlight
        btnExit.Font = New Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = SystemColors.ButtonHighlight
        btnExit.Location = New Point(558, 342)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(150, 40)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' txtPay
        ' 
        txtPay.Location = New Point(510, 277)
        txtPay.Name = "txtPay"
        txtPay.Size = New Size(125, 27)
        txtPay.TabIndex = 7
        ' 
        ' lblFica
        ' 
        lblFica.AutoSize = True
        lblFica.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFica.Location = New Point(141, 428)
        lblFica.Name = "lblFica"
        lblFica.Size = New Size(62, 21)
        lblFica.TabIndex = 8
        lblFica.Text = "FICA: "
        ' 
        ' lblFederal
        ' 
        lblFederal.AutoSize = True
        lblFederal.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFederal.Location = New Point(322, 428)
        lblFederal.Name = "lblFederal"
        lblFederal.Size = New Size(119, 21)
        lblFederal.TabIndex = 9
        lblFederal.Text = "Federal Tax: "
        ' 
        ' lblState
        ' 
        lblState.AutoSize = True
        lblState.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblState.Location = New Point(547, 428)
        lblState.Name = "lblState"
        lblState.Size = New Size(101, 21)
        lblState.TabIndex = 10
        lblState.Text = "State Tax: "
        ' 
        ' lblIncome
        ' 
        lblIncome.AutoSize = True
        lblIncome.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIncome.Location = New Point(214, 492)
        lblIncome.Name = "lblIncome"
        lblIncome.Size = New Size(243, 24)
        lblIncome.TabIndex = 11
        lblIncome.Text = "Net Paycheck Income: "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(832, 567)
        Controls.Add(lblIncome)
        Controls.Add(lblState)
        Controls.Add(lblFederal)
        Controls.Add(lblFica)
        Controls.Add(txtPay)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCompute)
        Controls.Add(lblPay)
        Controls.Add(lblCalculation)
        Controls.Add(lblCalculator)
        Controls.Add(picPayroll)
        Name = "Form1"
        Text = "Form1"
        CType(picPayroll, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picPayroll As PictureBox
    Friend WithEvents lblCalculator As Label
    Friend WithEvents lblCalculation As Label
    Friend WithEvents lblPay As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtPay As TextBox
    Friend WithEvents lblFica As Label
    Friend WithEvents lblFederal As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblIncome As Label

End Class
