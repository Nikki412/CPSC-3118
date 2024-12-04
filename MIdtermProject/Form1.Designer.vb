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
        lblResults = New Label()
        btnSave = New Button()
        btnClear = New Button()
        lstSaved = New ListBox()
        btnClearLst = New Button()
        btnFile = New Button()
        TextBox1 = New TextBox()
        lblSaved = New Label()
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
        grpBox.Location = New Point(313, 207)
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
        btnConvert.Location = New Point(313, 350)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(183, 39)
        btnConvert.TabIndex = 5
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' lblResults
        ' 
        lblResults.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResults.Location = New Point(313, 409)
        lblResults.Name = "lblResults"
        lblResults.Size = New Size(359, 32)
        lblResults.TabIndex = 8
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(313, 453)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(183, 39)
        btnSave.TabIndex = 9
        btnSave.Text = "Save Results"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(313, 510)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(183, 39)
        btnClear.TabIndex = 10
        btnClear.Text = "Clear Results"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lstSaved
        ' 
        lstSaved.FormattingEnabled = True
        lstSaved.Location = New Point(12, 240)
        lstSaved.Name = "lstSaved"
        lstSaved.Size = New Size(262, 304)
        lstSaved.TabIndex = 11
        ' 
        ' btnClearLst
        ' 
        btnClearLst.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClearLst.Location = New Point(12, 568)
        btnClearLst.Name = "btnClearLst"
        btnClearLst.Size = New Size(120, 35)
        btnClearLst.TabIndex = 12
        btnClearLst.Text = "Clear List"
        btnClearLst.UseVisualStyleBackColor = True
        ' 
        ' btnFile
        ' 
        btnFile.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFile.Location = New Point(154, 568)
        btnFile.Name = "btnFile"
        btnFile.Size = New Size(120, 35)
        btnFile.TabIndex = 13
        btnFile.Text = "Save to File"
        btnFile.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(313, 586)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(0, 27)
        TextBox1.TabIndex = 14
        ' 
        ' lblSaved
        ' 
        lblSaved.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSaved.Location = New Point(319, 593)
        lblSaved.Name = "lblSaved"
        lblSaved.Size = New Size(451, 32)
        lblSaved.TabIndex = 15
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumPurple
        ClientSize = New Size(782, 653)
        Controls.Add(lblSaved)
        Controls.Add(TextBox1)
        Controls.Add(btnFile)
        Controls.Add(btnClearLst)
        Controls.Add(lstSaved)
        Controls.Add(btnClear)
        Controls.Add(btnSave)
        Controls.Add(lblResults)
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
    Friend WithEvents lblResults As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lstSaved As ListBox
    Friend WithEvents btnClearLst As Button
    Friend WithEvents btnFile As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblSaved As Label

End Class
