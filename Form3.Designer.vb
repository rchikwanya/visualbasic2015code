<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtcustomername = New System.Windows.Forms.TextBox()
        Me.dgvInfo = New System.Windows.Forms.DataGridView()
        Me.txtphonenumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(119, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BackColor = System.Drawing.SystemColors.Window
        Me.txtSearch.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(207, 165)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(230, 26)
        Me.txtSearch.TabIndex = 80
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(548, 175)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(501, 32)
        Me.btnClear.TabIndex = 79
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(548, 129)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(501, 32)
        Me.btnDelete.TabIndex = 78
        Me.btnDelete.Text = "remove"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUpdate.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(548, 93)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(501, 32)
        Me.btnUpdate.TabIndex = 77
        Me.btnUpdate.Text = "edit"
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSave.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(554, 49)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(501, 32)
        Me.btnSave.TabIndex = 76
        Me.btnSave.Text = "add"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtcustomername
        '
        Me.txtcustomername.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustomername.Location = New System.Drawing.Point(398, 52)
        Me.txtcustomername.MaxLength = 64
        Me.txtcustomername.Name = "txtcustomername"
        Me.txtcustomername.Size = New System.Drawing.Size(139, 27)
        Me.txtcustomername.TabIndex = 60
        '
        'dgvInfo
        '
        Me.dgvInfo.AllowUserToAddRows = False
        Me.dgvInfo.AllowUserToDeleteRows = False
        Me.dgvInfo.AllowUserToResizeRows = False
        Me.dgvInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInfo.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInfo.Location = New System.Drawing.Point(2, 253)
        Me.dgvInfo.Name = "dgvInfo"
        Me.dgvInfo.ReadOnly = True
        Me.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInfo.Size = New System.Drawing.Size(1063, 369)
        Me.dgvInfo.TabIndex = 63
        Me.dgvInfo.TabStop = False
        '
        'txtphonenumber
        '
        Me.txtphonenumber.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphonenumber.Location = New System.Drawing.Point(106, 93)
        Me.txtphonenumber.MaxLength = 64
        Me.txtphonenumber.Name = "txtphonenumber"
        Me.txtphonenumber.Size = New System.Drawing.Size(139, 27)
        Me.txtphonenumber.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Customer ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(310, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Email"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(106, 48)
        Me.txtID.MaxLength = 16
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(139, 27)
        Me.txtID.TabIndex = 59
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(398, 104)
        Me.txtemail.MaxLength = 255
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(139, 27)
        Me.txtemail.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(310, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Customer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Phone number"
        '
        'customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 622)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtcustomername)
        Me.Controls.Add(Me.dgvInfo)
        Me.Controls.Add(Me.txtphonenumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "customer"
        Me.Text = "customer"
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtcustomername As TextBox
    Friend WithEvents dgvInfo As DataGridView
    Friend WithEvents txtphonenumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
