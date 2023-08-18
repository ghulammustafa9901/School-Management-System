<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewClassForm
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
        Me.txt_c_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_c_duration = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_c_max_student = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_c_fees = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_c_add = New System.Windows.Forms.Button()
        Me.btn_c_cancel = New System.Windows.Forms.Button()
        Me.lab_c_name_error = New System.Windows.Forms.Label()
        Me.lab_c_duration_error = New System.Windows.Forms.Label()
        Me.lab_c_fees_error = New System.Windows.Forms.Label()
        Me.lab_c_max_student_error = New System.Windows.Forms.Label()
        Me.txt_c_id = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_c_name
        '
        Me.txt_c_name.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_c_name.Location = New System.Drawing.Point(98, 141)
        Me.txt_c_name.Name = "txt_c_name"
        Me.txt_c_name.Size = New System.Drawing.Size(270, 26)
        Me.txt_c_name.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Class Name"
        '
        'txt_c_duration
        '
        Me.txt_c_duration.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_c_duration.Location = New System.Drawing.Point(98, 213)
        Me.txt_c_duration.Name = "txt_c_duration"
        Me.txt_c_duration.Size = New System.Drawing.Size(270, 26)
        Me.txt_c_duration.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 19)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Class Duration"
        '
        'txt_c_max_student
        '
        Me.txt_c_max_student.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_c_max_student.Location = New System.Drawing.Point(98, 360)
        Me.txt_c_max_student.Name = "txt_c_max_student"
        Me.txt_c_max_student.Size = New System.Drawing.Size(270, 26)
        Me.txt_c_max_student.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(94, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 19)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "Class Max Student"
        '
        'txt_c_fees
        '
        Me.txt_c_fees.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_c_fees.Location = New System.Drawing.Point(98, 288)
        Me.txt_c_fees.Name = "txt_c_fees"
        Me.txt_c_fees.Size = New System.Drawing.Size(270, 26)
        Me.txt_c_fees.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(94, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 19)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "Class Fees"
        '
        'btn_c_add
        '
        Me.btn_c_add.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_c_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_c_add.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btn_c_add.FlatAppearance.BorderSize = 2
        Me.btn_c_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btn_c_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btn_c_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_c_add.Font = New System.Drawing.Font("Raleway", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_c_add.Location = New System.Drawing.Point(98, 416)
        Me.btn_c_add.Name = "btn_c_add"
        Me.btn_c_add.Size = New System.Drawing.Size(270, 35)
        Me.btn_c_add.TabIndex = 9
        Me.btn_c_add.Text = "Add Class"
        Me.btn_c_add.UseVisualStyleBackColor = False
        '
        'btn_c_cancel
        '
        Me.btn_c_cancel.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_c_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_c_cancel.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btn_c_cancel.FlatAppearance.BorderSize = 2
        Me.btn_c_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btn_c_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btn_c_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_c_cancel.Font = New System.Drawing.Font("Raleway", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_c_cancel.Location = New System.Drawing.Point(98, 466)
        Me.btn_c_cancel.Name = "btn_c_cancel"
        Me.btn_c_cancel.Size = New System.Drawing.Size(270, 35)
        Me.btn_c_cancel.TabIndex = 10
        Me.btn_c_cancel.Text = "Cancel"
        Me.btn_c_cancel.UseVisualStyleBackColor = False
        '
        'lab_c_name_error
        '
        Me.lab_c_name_error.AutoSize = True
        Me.lab_c_name_error.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lab_c_name_error.ForeColor = System.Drawing.Color.Red
        Me.lab_c_name_error.Location = New System.Drawing.Point(95, 171)
        Me.lab_c_name_error.Name = "lab_c_name_error"
        Me.lab_c_name_error.Size = New System.Drawing.Size(0, 16)
        Me.lab_c_name_error.TabIndex = 134
        '
        'lab_c_duration_error
        '
        Me.lab_c_duration_error.AutoSize = True
        Me.lab_c_duration_error.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lab_c_duration_error.ForeColor = System.Drawing.Color.Red
        Me.lab_c_duration_error.Location = New System.Drawing.Point(95, 241)
        Me.lab_c_duration_error.Name = "lab_c_duration_error"
        Me.lab_c_duration_error.Size = New System.Drawing.Size(0, 16)
        Me.lab_c_duration_error.TabIndex = 134
        '
        'lab_c_fees_error
        '
        Me.lab_c_fees_error.AutoSize = True
        Me.lab_c_fees_error.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lab_c_fees_error.ForeColor = System.Drawing.Color.Red
        Me.lab_c_fees_error.Location = New System.Drawing.Point(95, 316)
        Me.lab_c_fees_error.Name = "lab_c_fees_error"
        Me.lab_c_fees_error.Size = New System.Drawing.Size(0, 16)
        Me.lab_c_fees_error.TabIndex = 134
        '
        'lab_c_max_student_error
        '
        Me.lab_c_max_student_error.AutoSize = True
        Me.lab_c_max_student_error.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lab_c_max_student_error.ForeColor = System.Drawing.Color.Red
        Me.lab_c_max_student_error.Location = New System.Drawing.Point(95, 388)
        Me.lab_c_max_student_error.Name = "lab_c_max_student_error"
        Me.lab_c_max_student_error.Size = New System.Drawing.Size(0, 16)
        Me.lab_c_max_student_error.TabIndex = 134
        '
        'txt_c_id
        '
        Me.txt_c_id.Enabled = False
        Me.txt_c_id.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_c_id.Location = New System.Drawing.Point(98, 72)
        Me.txt_c_id.Name = "txt_c_id"
        Me.txt_c_id.ReadOnly = True
        Me.txt_c_id.Size = New System.Drawing.Size(270, 26)
        Me.txt_c_id.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(94, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Class ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(95, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 16)
        Me.Label6.TabIndex = 134
        '
        'AddNewClassForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(479, 560)
        Me.Controls.Add(Me.lab_c_max_student_error)
        Me.Controls.Add(Me.lab_c_fees_error)
        Me.Controls.Add(Me.lab_c_duration_error)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lab_c_name_error)
        Me.Controls.Add(Me.btn_c_cancel)
        Me.Controls.Add(Me.btn_c_add)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_c_max_student)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_c_fees)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_c_duration)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_c_id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_c_name)
        Me.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "AddNewClassForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Class Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_c_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_c_duration As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_c_max_student As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_c_fees As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_c_add As Button
    Friend WithEvents btn_c_cancel As Button
    Friend WithEvents lab_c_name_error As Label
    Friend WithEvents lab_c_fees_error As Label
    Friend WithEvents lab_c_max_student_error As Label
    Friend WithEvents lab_c_duration_error As Label
    Friend WithEvents txt_c_id As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
