<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewFeesForm
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
        Me.lab_f_id_error = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_f_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lab_f_date_add_error = New System.Windows.Forms.Label()
        Me.txt_f_title = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_f_amount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lab_f_title_error = New System.Windows.Forms.Label()
        Me.lab_f_amount_error = New System.Windows.Forms.Label()
        Me.date_f_add = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lab_f_for_class_error = New System.Windows.Forms.Label()
        Me.txt_f_description = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lab_f_description = New System.Windows.Forms.Label()
        Me.combo_f_for_class = New System.Windows.Forms.ComboBox()
        Me.btn_f_cancel = New System.Windows.Forms.Button()
        Me.btn_f_add = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lab_f_id_error
        '
        Me.lab_f_id_error.AutoSize = True
        Me.lab_f_id_error.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lab_f_id_error.ForeColor = System.Drawing.Color.Red
        Me.lab_f_id_error.Location = New System.Drawing.Point(70, 88)
        Me.lab_f_id_error.Name = "lab_f_id_error"
        Me.lab_f_id_error.Size = New System.Drawing.Size(0, 16)
        Me.lab_f_id_error.TabIndex = 137
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 19)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "Fees ID"
        '
        'txt_f_id
        '
        Me.txt_f_id.Enabled = False
        Me.txt_f_id.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_f_id.Location = New System.Drawing.Point(73, 58)
        Me.txt_f_id.Name = "txt_f_id"
        Me.txt_f_id.Size = New System.Drawing.Size(270, 26)
        Me.txt_f_id.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(395, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 19)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Fees Add Date"
        '
        'lab_f_date_add_error
        '
        Me.lab_f_date_add_error.AutoSize = True
        Me.lab_f_date_add_error.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lab_f_date_add_error.ForeColor = System.Drawing.Color.Red
        Me.lab_f_date_add_error.Location = New System.Drawing.Point(396, 88)
        Me.lab_f_date_add_error.Name = "lab_f_date_add_error"
        Me.lab_f_date_add_error.Size = New System.Drawing.Size(0, 16)
        Me.lab_f_date_add_error.TabIndex = 137
        '
        'txt_f_title
        '
        Me.txt_f_title.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_f_title.Location = New System.Drawing.Point(73, 132)
        Me.txt_f_title.Name = "txt_f_title"
        Me.txt_f_title.Size = New System.Drawing.Size(270, 26)
        Me.txt_f_title.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 19)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Fees Title"
        '
        'txt_f_amount
        '
        Me.txt_f_amount.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_f_amount.Location = New System.Drawing.Point(399, 132)
        Me.txt_f_amount.Name = "txt_f_amount"
        Me.txt_f_amount.Size = New System.Drawing.Size(270, 26)
        Me.txt_f_amount.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(395, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 19)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "Fees Amount"
        '
        'lab_f_title_error
        '
        Me.lab_f_title_error.AutoSize = True
        Me.lab_f_title_error.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lab_f_title_error.ForeColor = System.Drawing.Color.Red
        Me.lab_f_title_error.Location = New System.Drawing.Point(70, 162)
        Me.lab_f_title_error.Name = "lab_f_title_error"
        Me.lab_f_title_error.Size = New System.Drawing.Size(0, 16)
        Me.lab_f_title_error.TabIndex = 137
        '
        'lab_f_amount_error
        '
        Me.lab_f_amount_error.AutoSize = True
        Me.lab_f_amount_error.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lab_f_amount_error.ForeColor = System.Drawing.Color.Red
        Me.lab_f_amount_error.Location = New System.Drawing.Point(396, 162)
        Me.lab_f_amount_error.Name = "lab_f_amount_error"
        Me.lab_f_amount_error.Size = New System.Drawing.Size(0, 16)
        Me.lab_f_amount_error.TabIndex = 137
        '
        'date_f_add
        '
        Me.date_f_add.Location = New System.Drawing.Point(399, 58)
        Me.date_f_add.Name = "date_f_add"
        Me.date_f_add.Size = New System.Drawing.Size(270, 23)
        Me.date_f_add.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(69, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 19)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "For Class"
        '
        'lab_f_for_class_error
        '
        Me.lab_f_for_class_error.AutoSize = True
        Me.lab_f_for_class_error.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lab_f_for_class_error.ForeColor = System.Drawing.Color.Red
        Me.lab_f_for_class_error.Location = New System.Drawing.Point(70, 239)
        Me.lab_f_for_class_error.Name = "lab_f_for_class_error"
        Me.lab_f_for_class_error.Size = New System.Drawing.Size(0, 16)
        Me.lab_f_for_class_error.TabIndex = 137
        '
        'txt_f_description
        '
        Me.txt_f_description.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_f_description.Location = New System.Drawing.Point(73, 289)
        Me.txt_f_description.Multiline = True
        Me.txt_f_description.Name = "txt_f_description"
        Me.txt_f_description.Size = New System.Drawing.Size(596, 94)
        Me.txt_f_description.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(69, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 19)
        Me.Label6.TabIndex = 136
        Me.Label6.Text = "Fees Description "
        '
        'lab_f_description
        '
        Me.lab_f_description.AutoSize = True
        Me.lab_f_description.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lab_f_description.ForeColor = System.Drawing.Color.Red
        Me.lab_f_description.Location = New System.Drawing.Point(70, 386)
        Me.lab_f_description.Name = "lab_f_description"
        Me.lab_f_description.Size = New System.Drawing.Size(0, 16)
        Me.lab_f_description.TabIndex = 137
        '
        'combo_f_for_class
        '
        Me.combo_f_for_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_f_for_class.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_f_for_class.FormattingEnabled = True
        Me.combo_f_for_class.Location = New System.Drawing.Point(73, 207)
        Me.combo_f_for_class.Name = "combo_f_for_class"
        Me.combo_f_for_class.Size = New System.Drawing.Size(270, 27)
        Me.combo_f_for_class.TabIndex = 5
        '
        'btn_f_cancel
        '
        Me.btn_f_cancel.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_f_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_f_cancel.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btn_f_cancel.FlatAppearance.BorderSize = 3
        Me.btn_f_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_f_cancel.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_f_cancel.Location = New System.Drawing.Point(555, 421)
        Me.btn_f_cancel.Name = "btn_f_cancel"
        Me.btn_f_cancel.Size = New System.Drawing.Size(114, 37)
        Me.btn_f_cancel.TabIndex = 8
        Me.btn_f_cancel.Text = "Cancel"
        Me.btn_f_cancel.UseVisualStyleBackColor = False
        '
        'btn_f_add
        '
        Me.btn_f_add.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_f_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_f_add.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btn_f_add.FlatAppearance.BorderSize = 3
        Me.btn_f_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_f_add.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_f_add.Location = New System.Drawing.Point(399, 421)
        Me.btn_f_add.Name = "btn_f_add"
        Me.btn_f_add.Size = New System.Drawing.Size(132, 37)
        Me.btn_f_add.TabIndex = 7
        Me.btn_f_add.Text = "Add Fees"
        Me.btn_f_add.UseVisualStyleBackColor = False
        '
        'AddNewFeesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(743, 500)
        Me.Controls.Add(Me.btn_f_cancel)
        Me.Controls.Add(Me.btn_f_add)
        Me.Controls.Add(Me.combo_f_for_class)
        Me.Controls.Add(Me.date_f_add)
        Me.Controls.Add(Me.lab_f_amount_error)
        Me.Controls.Add(Me.lab_f_date_add_error)
        Me.Controls.Add(Me.lab_f_description)
        Me.Controls.Add(Me.lab_f_for_class_error)
        Me.Controls.Add(Me.lab_f_title_error)
        Me.Controls.Add(Me.lab_f_id_error)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_f_amount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_f_description)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_f_title)
        Me.Controls.Add(Me.txt_f_id)
        Me.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "AddNewFeesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Fees Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lab_f_id_error As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_f_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lab_f_date_add_error As Label
    Friend WithEvents txt_f_title As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_f_amount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lab_f_title_error As Label
    Friend WithEvents lab_f_amount_error As Label
    Friend WithEvents date_f_add As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents lab_f_for_class_error As Label
    Friend WithEvents txt_f_description As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lab_f_description As Label
    Friend WithEvents combo_f_for_class As ComboBox
    Friend WithEvents btn_f_cancel As Button
    Friend WithEvents btn_f_add As Button
End Class
