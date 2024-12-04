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
        cboMonth = New ComboBox()
        lblSavings = New Label()
        btnStatistics = New Button()
        lblMonthySavings = New Label()
        lblSigSavings = New Label()
        lblBestMonth = New Label()
        lblAverageSavings = New Label()
        lblResults = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(368, 307)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(374, 32)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(310, 105)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Smart Home Electric Savings"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cboMonth
        ' 
        cboMonth.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cboMonth.FormattingEnabled = True
        cboMonth.Location = New Point(447, 169)
        cboMonth.Name = "cboMonth"
        cboMonth.Size = New Size(151, 26)
        cboMonth.TabIndex = 2
        cboMonth.Text = "Select Month:"
        ' 
        ' lblSavings
        ' 
        lblSavings.AutoSize = True
        lblSavings.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSavings.Location = New Point(158, 333)
        lblSavings.Name = "lblSavings"
        lblSavings.Size = New Size(251, 24)
        lblSavings.TabIndex = 3
        lblSavings.Text = "The electric savings for "
        lblSavings.Visible = False
        ' 
        ' btnStatistics
        ' 
        btnStatistics.BackColor = Color.RoyalBlue
        btnStatistics.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStatistics.ForeColor = SystemColors.Window
        btnStatistics.Location = New Point(227, 375)
        btnStatistics.Name = "btnStatistics"
        btnStatistics.Size = New Size(225, 51)
        btnStatistics.TabIndex = 4
        btnStatistics.Text = "Display Statistics"
        btnStatistics.UseVisualStyleBackColor = False
        ' 
        ' lblMonthySavings
        ' 
        lblMonthySavings.AutoSize = True
        lblMonthySavings.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMonthySavings.Location = New Point(122, 451)
        lblMonthySavings.Name = "lblMonthySavings"
        lblMonthySavings.Size = New Size(313, 24)
        lblMonthySavings.TabIndex = 5
        lblMonthySavings.Text = "The average monthy savings: "
        lblMonthySavings.Visible = False
        ' 
        ' lblSigSavings
        ' 
        lblSigSavings.AutoSize = True
        lblSigSavings.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSigSavings.Location = New Point(173, 498)
        lblSigSavings.Name = "lblSigSavings"
        lblSigSavings.Size = New Size(425, 24)
        lblSigSavings.TabIndex = 6
        lblSigSavings.Text = "had the most significant monthly savings"
        lblSigSavings.Visible = False
        ' 
        ' lblBestMonth
        ' 
        lblBestMonth.AutoSize = True
        lblBestMonth.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBestMonth.Location = New Point(63, 498)
        lblBestMonth.Name = "lblBestMonth"
        lblBestMonth.Size = New Size(0, 24)
        lblBestMonth.TabIndex = 7
        lblBestMonth.Visible = False
        ' 
        ' lblAverageSavings
        ' 
        lblAverageSavings.AutoSize = True
        lblAverageSavings.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAverageSavings.Location = New Point(429, 451)
        lblAverageSavings.Name = "lblAverageSavings"
        lblAverageSavings.Size = New Size(77, 24)
        lblAverageSavings.TabIndex = 8
        lblAverageSavings.Text = "Label6"
        lblAverageSavings.Visible = False
        ' 
        ' lblResults
        ' 
        lblResults.AutoSize = True
        lblResults.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResults.Location = New Point(401, 333)
        lblResults.Name = "lblResults"
        lblResults.Size = New Size(77, 24)
        lblResults.TabIndex = 9
        lblResults.Text = "Label7"
        lblResults.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Bisque
        ClientSize = New Size(682, 553)
        Controls.Add(lblResults)
        Controls.Add(lblAverageSavings)
        Controls.Add(lblBestMonth)
        Controls.Add(lblSigSavings)
        Controls.Add(lblMonthySavings)
        Controls.Add(btnStatistics)
        Controls.Add(lblSavings)
        Controls.Add(cboMonth)
        Controls.Add(lblTitle)
        Controls.Add(PictureBox1)
        Name = "Form1"
        SizeGripStyle = SizeGripStyle.Show
        Text = "Smart Home Application"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents lblSavings As Label
    Friend WithEvents btnStatistics As Button
    Friend WithEvents lblMonthySavings As Label
    Friend WithEvents lblSigSavings As Label
    Friend WithEvents lblBestMonth As Label
    Friend WithEvents lblAverageSavings As Label
    Friend WithEvents lblResults As Label

End Class
