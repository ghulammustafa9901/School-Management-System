<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewSubjectForm
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
        Me.lab_s_for_class_error = New System.Windows.Forms.Label()
        Me.lab_s_name_error = New System.Windows.Forms.Label()
        Me.btn_s_cancel = New System.Windows.Forms.Button()
        Me.btn_s_add = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_s_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_s_name = New System.Windows.Forms.TextBox()
        Me.combo_s_for_class = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lab_s_for_class_error
        '
        Me.lab_s_for_class_error.AutoSize = True
        Me.lab_s_for_class_error.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lab_s_for_class_error.ForeColor = System.Drawing.Color.Red
        Me.lab_s_for_class_error.Location = New System.Drawing.Point(95, 256)
        Me.lab_s_for_class_error.Name = "lab_s_for_class_error"
        Me.lab_s_for_class_error.Size = New System.Drawing.Size(0, 16)
        Me.lab_s_for_class_error.TabIndex = 148
        '
        'lab_s_name_error
        '
        Me.lab_s_name_error.AutoSize = True
        Me.lab_s_name_error.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lab_s_name_error.ForeColor = System.Drawing.Color.Red
        Me.lab_s_name_error.Location = New System.Drawing.Point(95, 186)
        Me.lab_s_name_error.Name = "lab_s_name_error"
        Me.lab_s_name_error.Size = New System.Drawing.Size(0, 16)
        Me.lab_s_name_error.TabIndex = 150
        '
        'btn_s_cancel
        '
        Me.btn_s_cancel.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_s_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_s_cancel.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btn_s_cancel.FlatAppearance.BorderSize = 2
        Me.btn_s_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btn_s_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btn_s_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_s_cancel.Font = New System.Drawing.Font("Raleway", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_s_cancel.Location = New System.Drawing.Point(98, 341)
        Me.btn_s_cancel.Name = "btn_s_cancel"
        Me.btn_s_cancel.Size = New System.Drawing.Size(270, 35)
        Me.btn_s_cancel.TabIndex = 141
        Me.btn_s_cancel.Text = "Cancel"
        Me.btn_s_cancel.UseVisualStyleBackColor = False
        '
        'btn_s_add
        '
        Me.btn_s_add.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_s_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_s_add.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btn_s_add.FlatAppearance.BorderSize = 2
        Me.btn_s_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btn_s_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btn_s_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_s_add.Font = New System.Drawing.Font("Raleway", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_s_add.Location = New System.Drawing.Point(98, 291)
        Me.btn_s_add.Name = "btn_s_add"
        Me.btn_s_add.Size = New System.Drawing.Size(270, 35)
        Me.btn_s_add.TabIndex = 140
        Me.btn_s_add.Text = "Add Subject"
        Me.btn_s_add.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "For Class"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(94, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 19)
        Me.Label10.TabIndex = 143
        Me.Label10.Text = "Subject ID"
        '
        'txt_s_id
        '
        Me.txt_s_id.Enabled = False
        Me.txt_s_id.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_s_id.Location = New System.Drawing.Point(98, 87)
        Me.txt_s_id.Name = "txt_s_id"
        Me.txt_s_id.Size = New System.Drawing.Size(270, 26)
        Me.txt_s_id.TabIndex = 135
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 19)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "Subject Name"
        '
        'txt_s_name
        '
        Me.txt_s_name.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_s_name.Location = New System.Drawing.Point(98, 156)
        Me.txt_s_name.Name = "txt_s_name"
        Me.txt_s_name.Size = New System.Drawing.Size(270, 26)
        Me.txt_s_name.TabIndex = 136
        '
        'combo_s_for_class
        '
        Me.combo_s_for_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_s_for_class.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_s_for_class.FormattingEnabled = True
        Me.combo_s_for_class.Location = New System.Drawing.Point(98, 227)
        Me.combo_s_for_class.Name = "combo_s_for_class"
        Me.combo_s_for_class.Size = New System.Drawing.Size(270, 27)
        Me.combo_s_for_class.TabIndex = 151
        '
        'AddNewSubjectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(479, 468)
        Me.Controls.Add(Me.combo_s_for_class)
        Me.Controls.Add(Me.lab_s_for_class_error)
        Me.Controls.Add(Me.lab_s_name_error)
        Me.Controls.Add(Me.btn_s_cancel)
        Me.Controls.Add(Me.btn_s_add)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_s_id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_s_name)
        Me.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "AddNewSubjectForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Subject Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lab_s_for_class_error As Label
    Friend WithEvents lab_s_name_error As Label
    Friend WithEvents btn_s_cancel As Button
    Friend WithEvents btn_s_add As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_s_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_s_name As TextBox
    Friend WithEvents combo_s_for_class As ComboBox
End Class
