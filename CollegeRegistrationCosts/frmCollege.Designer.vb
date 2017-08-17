<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollege
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picCollege = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.MaskedTextBox()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtNumberOfUnits = New System.Windows.Forms.TextBox()
        Me.grpResidence = New System.Windows.Forms.GroupBox()
        Me.radOnCampus = New System.Windows.Forms.RadioButton()
        Me.radOffCampus = New System.Windows.Forms.RadioButton()
        Me.grpHousingBoard = New System.Windows.Forms.GroupBox()
        Me.radJulianSuites = New System.Windows.Forms.RadioButton()
        Me.radPerceyHall = New System.Windows.Forms.RadioButton()
        Me.radCooperDorm = New System.Windows.Forms.RadioButton()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.cboMajor = New System.Windows.Forms.ComboBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblCosts = New System.Windows.Forms.Label()
        CType(Me.picCollege, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.grpResidence.SuspendLayout()
        Me.grpHousingBoard.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Maroon
        Me.lblHeading.Location = New System.Drawing.Point(22, 45)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(332, 78)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Register for Classes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Raven College"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picCollege
        '
        Me.picCollege.Image = Global.CollegeRegistrationCosts.My.Resources.Resources.College
        Me.picCollege.Location = New System.Drawing.Point(30, 1)
        Me.picCollege.Name = "picCollege"
        Me.picCollege.Size = New System.Drawing.Size(225, 150)
        Me.picCollege.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCollege.TabIndex = 1
        Me.picCollege.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblHeading)
        Me.Panel1.Location = New System.Drawing.Point(252, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(377, 150)
        Me.Panel1.TabIndex = 2
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.ForeColor = System.Drawing.Color.Maroon
        Me.lblStudentID.Location = New System.Drawing.Point(26, 170)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(91, 19)
        Me.lblStudentID.TabIndex = 3
        Me.lblStudentID.Text = "Student ID:"
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.ForeColor = System.Drawing.Color.Maroon
        Me.lblStudentName.Location = New System.Drawing.Point(26, 205)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(115, 19)
        Me.lblStudentName.TabIndex = 4
        Me.lblStudentName.Text = "Student Name:"
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnits.ForeColor = System.Drawing.Color.Maroon
        Me.lblUnits.Location = New System.Drawing.Point(26, 245)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(132, 19)
        Me.lblUnits.TabIndex = 5
        Me.lblUnits.Text = "Number of Units:"
        '
        'txtStudentID
        '
        Me.txtStudentID.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.ForeColor = System.Drawing.Color.Maroon
        Me.txtStudentID.Location = New System.Drawing.Point(180, 167)
        Me.txtStudentID.Mask = "000-00-0000"
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(105, 27)
        Me.txtStudentID.TabIndex = 6
        '
        'txtStudentName
        '
        Me.txtStudentName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentName.ForeColor = System.Drawing.Color.Maroon
        Me.txtStudentName.Location = New System.Drawing.Point(180, 202)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(400, 27)
        Me.txtStudentName.TabIndex = 7
        '
        'txtNumberOfUnits
        '
        Me.txtNumberOfUnits.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfUnits.ForeColor = System.Drawing.Color.Maroon
        Me.txtNumberOfUnits.Location = New System.Drawing.Point(180, 242)
        Me.txtNumberOfUnits.Name = "txtNumberOfUnits"
        Me.txtNumberOfUnits.Size = New System.Drawing.Size(59, 27)
        Me.txtNumberOfUnits.TabIndex = 8
        '
        'grpResidence
        '
        Me.grpResidence.Controls.Add(Me.radOnCampus)
        Me.grpResidence.Controls.Add(Me.radOffCampus)
        Me.grpResidence.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpResidence.ForeColor = System.Drawing.Color.Maroon
        Me.grpResidence.Location = New System.Drawing.Point(31, 285)
        Me.grpResidence.Name = "grpResidence"
        Me.grpResidence.Size = New System.Drawing.Size(127, 100)
        Me.grpResidence.TabIndex = 9
        Me.grpResidence.TabStop = False
        Me.grpResidence.Text = "Residence"
        '
        'radOnCampus
        '
        Me.radOnCampus.AutoSize = True
        Me.radOnCampus.Location = New System.Drawing.Point(7, 57)
        Me.radOnCampus.Name = "radOnCampus"
        Me.radOnCampus.Size = New System.Drawing.Size(111, 23)
        Me.radOnCampus.TabIndex = 1
        Me.radOnCampus.Text = "On-Campus"
        Me.radOnCampus.UseVisualStyleBackColor = True
        '
        'radOffCampus
        '
        Me.radOffCampus.AutoSize = True
        Me.radOffCampus.Checked = True
        Me.radOffCampus.Location = New System.Drawing.Point(7, 27)
        Me.radOffCampus.Name = "radOffCampus"
        Me.radOffCampus.Size = New System.Drawing.Size(112, 23)
        Me.radOffCampus.TabIndex = 0
        Me.radOffCampus.TabStop = True
        Me.radOffCampus.Text = "Off-Campus"
        Me.radOffCampus.UseVisualStyleBackColor = True
        '
        'grpHousingBoard
        '
        Me.grpHousingBoard.Controls.Add(Me.radJulianSuites)
        Me.grpHousingBoard.Controls.Add(Me.radPerceyHall)
        Me.grpHousingBoard.Controls.Add(Me.radCooperDorm)
        Me.grpHousingBoard.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHousingBoard.ForeColor = System.Drawing.Color.Maroon
        Me.grpHousingBoard.Location = New System.Drawing.Point(180, 285)
        Me.grpHousingBoard.Name = "grpHousingBoard"
        Me.grpHousingBoard.Size = New System.Drawing.Size(159, 110)
        Me.grpHousingBoard.TabIndex = 10
        Me.grpHousingBoard.TabStop = False
        Me.grpHousingBoard.Text = "Housing/Board"
        Me.grpHousingBoard.Visible = False
        '
        'radJulianSuites
        '
        Me.radJulianSuites.AutoSize = True
        Me.radJulianSuites.Location = New System.Drawing.Point(7, 85)
        Me.radJulianSuites.Name = "radJulianSuites"
        Me.radJulianSuites.Size = New System.Drawing.Size(115, 23)
        Me.radJulianSuites.TabIndex = 2
        Me.radJulianSuites.Text = "Julian Suites"
        Me.radJulianSuites.UseVisualStyleBackColor = True
        '
        'radPerceyHall
        '
        Me.radPerceyHall.AutoSize = True
        Me.radPerceyHall.Location = New System.Drawing.Point(7, 56)
        Me.radPerceyHall.Name = "radPerceyHall"
        Me.radPerceyHall.Size = New System.Drawing.Size(105, 23)
        Me.radPerceyHall.TabIndex = 1
        Me.radPerceyHall.Text = "Percey Hall"
        Me.radPerceyHall.UseVisualStyleBackColor = True
        '
        'radCooperDorm
        '
        Me.radCooperDorm.AutoSize = True
        Me.radCooperDorm.Location = New System.Drawing.Point(7, 27)
        Me.radCooperDorm.Name = "radCooperDorm"
        Me.radCooperDorm.Size = New System.Drawing.Size(123, 23)
        Me.radCooperDorm.TabIndex = 0
        Me.radCooperDorm.Text = "Cooper Dorm"
        Me.radCooperDorm.UseVisualStyleBackColor = True
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor.ForeColor = System.Drawing.Color.Maroon
        Me.lblMajor.Location = New System.Drawing.Point(345, 285)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(55, 19)
        Me.lblMajor.TabIndex = 11
        Me.lblMajor.Tag = ""
        Me.lblMajor.Text = "Major:"
        '
        'cboMajor
        '
        Me.cboMajor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMajor.ForeColor = System.Drawing.Color.Maroon
        Me.cboMajor.FormattingEnabled = True
        Me.cboMajor.Items.AddRange(New Object() {"Computer Science", "Communications", "Politcal Science", "Business", "Economics", "English", "Psychology", "Nursing", "Chemical Engineering", "Biology"})
        Me.cboMajor.Location = New System.Drawing.Point(406, 282)
        Me.cboMajor.Name = "cboMajor"
        Me.cboMajor.Size = New System.Drawing.Size(174, 27)
        Me.cboMajor.TabIndex = 13
        Me.cboMajor.Text = "Select a Major"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.RosyBrown
        Me.btnCalculate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Maroon
        Me.btnCalculate.Location = New System.Drawing.Point(110, 405)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(160, 40)
        Me.btnCalculate.TabIndex = 14
        Me.btnCalculate.Text = "Calculate Costs"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.RosyBrown
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Maroon
        Me.btnClear.Location = New System.Drawing.Point(355, 405)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(160, 40)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblCosts
        '
        Me.lblCosts.AutoSize = True
        Me.lblCosts.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCosts.ForeColor = System.Drawing.Color.Maroon
        Me.lblCosts.Location = New System.Drawing.Point(176, 460)
        Me.lblCosts.Name = "lblCosts"
        Me.lblCosts.Size = New System.Drawing.Size(273, 19)
        Me.lblCosts.TabIndex = 16
        Me.lblCosts.Text = "Total semester costs are: $XX,XXX.XX"
        Me.lblCosts.Visible = False
        '
        'frmCollege
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(624, 501)
        Me.Controls.Add(Me.lblCosts)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblMajor)
        Me.Controls.Add(Me.cboMajor)
        Me.Controls.Add(Me.grpHousingBoard)
        Me.Controls.Add(Me.grpResidence)
        Me.Controls.Add(Me.txtNumberOfUnits)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picCollege)
        Me.Name = "frmCollege"
        Me.Text = "College Registration Costs"
        CType(Me.picCollege, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpResidence.ResumeLayout(False)
        Me.grpResidence.PerformLayout()
        Me.grpHousingBoard.ResumeLayout(False)
        Me.grpHousingBoard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents picCollege As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblStudentID As System.Windows.Forms.Label
    Friend WithEvents lblStudentName As System.Windows.Forms.Label
    Friend WithEvents lblUnits As System.Windows.Forms.Label
    Friend WithEvents txtStudentID As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents txtNumberOfUnits As System.Windows.Forms.TextBox
    Friend WithEvents grpResidence As System.Windows.Forms.GroupBox
    Friend WithEvents radOnCampus As System.Windows.Forms.RadioButton
    Friend WithEvents radOffCampus As System.Windows.Forms.RadioButton
    Friend WithEvents grpHousingBoard As System.Windows.Forms.GroupBox
    Friend WithEvents radJulianSuites As System.Windows.Forms.RadioButton
    Friend WithEvents radPerceyHall As System.Windows.Forms.RadioButton
    Friend WithEvents radCooperDorm As System.Windows.Forms.RadioButton
    Friend WithEvents lblMajor As System.Windows.Forms.Label
    Friend WithEvents cboMajor As System.Windows.Forms.ComboBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblCosts As System.Windows.Forms.Label

End Class
