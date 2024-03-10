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
        lblTitle = New Label()
        PictureBox1 = New PictureBox()
        lblDescription = New Label()
        txtInput = New TextBox()
        grpBox = New GroupBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        btnConvert = New Button()
        btnClear = New Button()
        btnExit = New Button()
        lblResults = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        grpBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(331, 35)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(277, 50)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Converter App"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(0, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(274, 211)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' lblDescription
        ' 
        lblDescription.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDescription.Location = New Point(313, 122)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(234, 68)
        lblDescription.TabIndex = 2
        lblDescription.Text = "Enter a value and choose a conversion"
        lblDescription.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtInput
        ' 
        txtInput.BackColor = Color.Indigo
        txtInput.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtInput.ForeColor = SystemColors.Window
        txtInput.Location = New Point(595, 138)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(119, 38)
        txtInput.TabIndex = 3
        txtInput.TextAlign = HorizontalAlignment.Center
        ' 
        ' grpBox
        ' 
        grpBox.BackColor = Color.Indigo
        grpBox.Controls.Add(RadioButton2)
        grpBox.Controls.Add(RadioButton1)
        grpBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpBox.ForeColor = SystemColors.Window
        grpBox.Location = New Point(405, 257)
        grpBox.Name = "grpBox"
        grpBox.Size = New Size(250, 125)
        grpBox.TabIndex = 4
        grpBox.TabStop = False
        grpBox.Text = "Convert Measurement"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(6, 71)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(191, 32)
        RadioButton2.TabIndex = 1
        RadioButton2.Text = "Meters to Inches"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Checked = True
        RadioButton1.Location = New Point(6, 33)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(191, 32)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Inches to Meters"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' btnConvert
        ' 
        btnConvert.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConvert.Location = New Point(23, 478)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(230, 70)
        btnConvert.TabIndex = 5
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(287, 478)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(230, 70)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(541, 478)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(230, 70)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblResults
        ' 
        lblResults.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResults.Location = New Point(370, 406)
        lblResults.Name = "lblResults"
        lblResults.Size = New Size(359, 32)
        lblResults.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumPurple
        ClientSize = New Size(800, 553)
        Controls.Add(lblResults)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnConvert)
        Controls.Add(grpBox)
        Controls.Add(txtInput)
        Controls.Add(lblDescription)
        Controls.Add(PictureBox1)
        Controls.Add(lblTitle)
        Name = "Form1"
        Text = "Building Plans Conversion"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        grpBox.ResumeLayout(False)
        grpBox.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents grpBox As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblResults As Label

End Class
