<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassDetailForm
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Me.combo_c_name = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_c_duration = New System.Windows.Forms.TextBox()
        Me.txt_c_fees = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_c_max_student = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_c_pre_student = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_c_id = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.LV_s_reg_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LV_s_roll_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LV_s_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LV_s_gender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LV_s_DOA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'combo_c_name
        '
        Me.combo_c_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_c_name.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_c_name.FormattingEnabled = True
        Me.combo_c_name.Location = New System.Drawing.Point(516, 44)
        Me.combo_c_name.Name = "combo_c_name"
        Me.combo_c_name.Size = New System.Drawing.Size(285, 27)
        Me.combo_c_name.TabIndex = 1245
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(79, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Class ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(512, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 19)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Class Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(79, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 19)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Class Duration"
        '
        'txt_c_duration
        '
        Me.txt_c_duration.Enabled = False
        Me.txt_c_duration.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_c_duration.Location = New System.Drawing.Point(83, 109)
        Me.txt_c_duration.Name = "txt_c_duration"
        Me.txt_c_duration.ReadOnly = True
        Me.txt_c_duration.Size = New System.Drawing.Size(285, 26)
        Me.txt_c_duration.TabIndex = 3
        '
        'txt_c_fees
        '
        Me.txt_c_fees.Enabled = False
        Me.txt_c_fees.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_c_fees.Location = New System.Drawing.Point(516, 108)
        Me.txt_c_fees.Name = "txt_c_fees"
        Me.txt_c_fees.ReadOnly = True
        Me.txt_c_fees.Size = New System.Drawing.Size(285, 26)
        Me.txt_c_fees.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(512, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 19)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Class Fees"
        '
        'txt_c_max_student
        '
        Me.txt_c_max_student.Enabled = False
        Me.txt_c_max_student.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_c_max_student.Location = New System.Drawing.Point(83, 180)
        Me.txt_c_max_student.Name = "txt_c_max_student"
        Me.txt_c_max_student.ReadOnly = True
        Me.txt_c_max_student.Size = New System.Drawing.Size(285, 26)
        Me.txt_c_max_student.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(79, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 19)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Class Max Student"
        '
        'txt_c_pre_student
        '
        Me.txt_c_pre_student.Enabled = False
        Me.txt_c_pre_student.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_c_pre_student.Location = New System.Drawing.Point(516, 179)
        Me.txt_c_pre_student.Name = "txt_c_pre_student"
        Me.txt_c_pre_student.ReadOnly = True
        Me.txt_c_pre_student.Size = New System.Drawing.Size(285, 26)
        Me.txt_c_pre_student.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(512, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 19)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Class Present Student"
        '
        'txt_c_id
        '
        Me.txt_c_id.Enabled = False
        Me.txt_c_id.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_c_id.Location = New System.Drawing.Point(83, 45)
        Me.txt_c_id.Name = "txt_c_id"
        Me.txt_c_id.ReadOnly = True
        Me.txt_c_id.Size = New System.Drawing.Size(285, 26)
        Me.txt_c_id.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.LV_s_reg_no, Me.LV_s_roll_no, Me.LV_s_name, Me.LV_s_gender, Me.LV_s_DOA})
        Me.ListView1.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListView1.Location = New System.Drawing.Point(83, 228)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListView1.Size = New System.Drawing.Size(718, 305)
        Me.ListView1.TabIndex = 54
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'LV_s_reg_no
        '
        Me.LV_s_reg_no.Text = "Reg No"
        Me.LV_s_reg_no.Width = 90
        '
        'LV_s_roll_no
        '
        Me.LV_s_roll_no.Text = "Roll No"
        Me.LV_s_roll_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.LV_s_roll_no.Width = 90
        '
        'LV_s_name
        '
        Me.LV_s_name.Text = "Name"
        Me.LV_s_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.LV_s_name.Width = 200
        '
        'LV_s_gender
        '
        Me.LV_s_gender.Text = "Gender"
        Me.LV_s_gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.LV_s_gender.Width = 90
        '
        'LV_s_DOA
        '
        Me.LV_s_DOA.Text = "Date of Add"
        Me.LV_s_DOA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.LV_s_DOA.Width = 200
        '
        'ClassDetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_c_pre_student)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_c_fees)
        Me.Controls.Add(Me.txt_c_max_student)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_c_id)
        Me.Controls.Add(Me.txt_c_duration)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.combo_c_name)
        Me.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "ClassDetailForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Class Detail Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents combo_c_name As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_c_duration As System.Windows.Forms.TextBox
    Friend WithEvents txt_c_fees As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_c_max_student As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_c_pre_student As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_c_id As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents LV_s_reg_no As System.Windows.Forms.ColumnHeader
    Friend WithEvents LV_s_roll_no As System.Windows.Forms.ColumnHeader
    Friend WithEvents LV_s_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents LV_s_gender As System.Windows.Forms.ColumnHeader
    Friend WithEvents LV_s_DOA As System.Windows.Forms.ColumnHeader
End Class
