Imports System.Data.OleDb
Public Class cellphone
    Dim dbconn As New OleDbConnection
    Dim adt As New OleDbDataAdapter
    Dim ds As New DataSet

    Dim datatable As New DataTable
    Dim cmd As New OleDbCommand
    Private Sub cellphone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source=..\db_project321.mdb"
        showData() 'show database values in datagridview
        customColumnWidth() ' set custom column width
    End Sub
    Private Sub customColumnWidth() ' set custom column width
        'datagridName.Columns(columnNumber or columnName)
        Dim columnID As DataGridViewColumn = dgvInfo.Columns(0)
        columnID.Width = 40 'set columnwidth
        Dim columnmodel As DataGridViewColumn = dgvInfo.Columns(1)
        columnmodel.Width = 100 'set columnwidth
    End Sub
    Private Sub showData()
        Dim dbcommand As String
        dbcommand = "SELECT * FROM cellphone"
        adt = New OleDbDataAdapter(dbcommand, dbconn)
        datatable = New DataTable
        adt.Fill(datatable)
        dgvInfo.DataSource = datatable
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Confirm dialogBox
        Dim dr As DialogResult
        dr = MessageBox.Show("Save information?", "Save", MessageBoxButtons.YesNo)
        If dr = DialogResult.No Then
            'NO CONDITION GOES HERE
        Else
            'YES CONDITION GOES HERE
            'Form restriction and validation
            If Len(Trim(txtmodel.Text)) = 0 Then
                MessageBox.Show("Please enter model", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtmodel.Focus()
            ElseIf Len(Trim(txtserial.Text)) = 0 Then
                MessageBox.Show("Please enter serial number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtserial.Focus()
            ElseIf Len(Trim(txtbrand.Text)) = 0 Then
                MessageBox.Show("Please enter brand", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtbrand.Focus()
            ElseIf Len(Trim(txtsim.Text)) = 0 Then
                MessageBox.Show("Please enter number of sims", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtsim.Focus()
            ElseIf Len(Trim(txtos.Text)) = 0 Then
                MessageBox.Show("Please enter operating system", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtos.Focus()
            ElseIf Len(Trim(txtdes.Text)) = 0 Then
                MessageBox.Show("Please enter description", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtdes.Focus()
            ElseIf Len(Trim(txtcell.Text)) = 0 Then
                MessageBox.Show("Please enter cellphone date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtcell.Focus()
            Else
                adt = New OleDbDataAdapter("insert into cellphone (model,serial_number,brand,number_of_sim_cards,operating_system,description,cellphone_date) values ('" & txtmodel.Text & "', '" & txtserial.Text & "', '" & txtbrand.Text & "', '" & txtsim.Text & "', '" & txtos.Text & "', '" & txtdes.Text & "', '" & txtcell.Text & "')", dbconn)
                adt.Fill(ds)
                ds = New DataSet
                showData() ' refresh data in datagridview
                MsgBox("Saved")
                clearText() 'clear all text
            End If
        End If
    End Sub
    Sub clearText() 'clear all text
        txtID.Text = ""
        txtmodel.Text = ""
        txtserial.Text = ""
        txtbrand.Text = ""
        txtsim.Text = ""
        txtos.Text = ""
        txtdes.Text = ""
        txtcell.Text = ""

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Confirm dialogBox
        Dim dr As DialogResult
        dr = MessageBox.Show("Update information?", "Save", MessageBoxButtons.YesNo)
        If dr = DialogResult.No Then
            'NO CONDITION GOES HERE
        Else
            'YES CONDITION GOES HERE
            'Form restriction and validation
            If Len(Trim(txtmodel.Text)) = 0 Then
                MessageBox.Show("Please enter model", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtmodel.Focus()
            ElseIf Len(Trim(txtserial.Text)) = 0 Then
                MessageBox.Show("Please enter serial number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtserial.Focus()
            ElseIf Len(Trim(txtbrand.Text)) = 0 Then
                MessageBox.Show("Please enter brand", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtbrand.Focus()
            ElseIf Len(Trim(txtsim.Text)) = 0 Then
                MessageBox.Show("Please enter number of sims", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtsim.Focus()
            ElseIf Len(Trim(txtos.Text)) = 0 Then
                MessageBox.Show("Please enter operating system", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtos.Focus()
            ElseIf Len(Trim(txtdes.Text)) = 0 Then
                MessageBox.Show("Please enter description", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtdes.Focus()
            ElseIf Len(Trim(txtcell.Text)) = 0 Then
                MessageBox.Show("Please enter cellphone date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtcell.Focus()
            Else

                adt = New OleDbDataAdapter("update cellphone set model='" & txtmodel.Text & "', serial_number='" & txtserial.Text & "', brand='" & txtbrand.Text & "', number_of_sim_cards='" & txtsim.Text & "', operating_system='" & txtos.Text & "', description='" & txtdes.Text & "', cellphone_date='" & txtcell.Text & "' where cellphoneid=" & txtID.Text & "", dbconn)
                adt.Fill(ds)
                ds = New DataSet
                showData() ' refresh data in datagridview
                MsgBox("Updated")
                clearText() 'clear all text
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Confirm dialogBox
        Dim dr As DialogResult
        dr = MessageBox.Show("Delete information?", "Delete", MessageBoxButtons.YesNo)
        If dr = DialogResult.No Then
            'NO CONDITION GOES HERE
        Else
            'YES CONDITION GOES HERE
            'Form restriction and validation
            If Len(Trim(txtmodel.Text)) = 0 Then
                MessageBox.Show("Please enter model", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtmodel.Focus()
            ElseIf Len(Trim(txtserial.Text)) = 0 Then
                MessageBox.Show("Please enter serial number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtserial.Focus()
            ElseIf Len(Trim(txtbrand.Text)) = 0 Then
                MessageBox.Show("Please enter brand", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtbrand.Focus()
            ElseIf Len(Trim(txtsim.Text)) = 0 Then
                MessageBox.Show("Please enter number of sims", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtsim.Focus()
            ElseIf Len(Trim(txtos.Text)) = 0 Then
                MessageBox.Show("Please enter operating system", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtos.Focus()
            ElseIf Len(Trim(txtdes.Text)) = 0 Then
                MessageBox.Show("Please enter description", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtdes.Focus()
            ElseIf Len(Trim(txtcell.Text)) = 0 Then
                MessageBox.Show("Please enter cellphone date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtcell.Focus()
            Else

                adt = New OleDbDataAdapter("delete  model='" & txtmodel.Text & "', serial_number='" & txtserial.Text & "', brand='" & txtbrand.Text & "', number_of_sim_cards='" & txtsim.Text & "', operating_system='" & txtos.Text & "', description='" & txtdes.Text & "', cellphone_date='" & txtcell.Text & "' from cellphone where cellphoneid=" & txtID.Text & "", dbconn)
                adt.Fill(ds)
                ds = New DataSet
                showData() ' refresh data in datagridview
                MsgBox("Deleted")
                clearText() 'clear all text
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Confirm dialogBox
        Dim dr As DialogResult
        dr = MessageBox.Show("Clear text?", "Clear", MessageBoxButtons.YesNo)
        If dr = DialogResult.No Then
            'NO CONDITION GOES HERE
        Else
            'YES CONDITION GOES HERE
            clearText() 'clear all text
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If cboFilter.SelectedItem = "cellphoneid" Then
                Dim dataView As New DataView(datatable)
                dataView.RowFilter = String.Format("cellphoneid = " & txtSearch.Text & "")
                dgvInfo.DataSource = dataView

            ElseIf cboFilter.SelectedItem = "model" Then
                Dim dataView As New DataView(datatable)
                dataView.RowFilter = String.Format("model like '%" & txtSearch.Text & "%'")
                dgvInfo.DataSource = dataView

            ElseIf cboFilter.SelectedItem = "serial_number " Then
                Dim dataView As New DataView(datatable)
                dataView.RowFilter = String.Format("serial_number like '%" & txtSearch.Text & "%'")
                dgvInfo.DataSource = dataView

            ElseIf cboFilter.SelectedItem = "brand" Then
                Dim dataView As New DataView(datatable)
                dataView.RowFilter = String.Format("brand like '%" & txtSearch.Text & "%'")
                dgvInfo.DataSource = dataView
            ElseIf cboFilter.SelectedItem = "number_of_sim_cards" Then
                Dim dataView As New DataView(datatable)
                dataView.RowFilter = String.Format("number_of_sim_cards like '%" & txtSearch.Text & "%'")
                dgvInfo.DataSource = dataView
            ElseIf cboFilter.SelectedItem = "operating_system" Then
                Dim dataView As New DataView(datatable)
                dataView.RowFilter = String.Format("operating_system like '%" & txtSearch.Text & "%'")
                dgvInfo.DataSource = dataView
            ElseIf cboFilter.SelectedItem = "description" Then
                Dim dataView As New DataView(datatable)
                dataView.RowFilter = String.Format("description like '%" & txtSearch.Text & "%'")
                dgvInfo.DataSource = dataView
            ElseIf cboFilter.SelectedItem = "cellphone_date" Then
                Dim dataView As New DataView(datatable)
                dataView.RowFilter = String.Format("cellphone_date like '%" & txtSearch.Text & "%'")
                dgvInfo.DataSource = dataView
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs)
        Try
            Dim sql = "select * from cellphone where cellphoneid like " & txtID.Text & " "
            adt = New OleDbDataAdapter(sql, dbconn)
            cmd = New OleDbCommand(sql)
            adt.Fill(ds, "cellphone")
            'ds.tables(tableName).rows(rowNumber)(columnNumber).tostring

            txtmodel.Text = ds.Tables("cellphone").Rows(0)(1).ToString
            txtserial.Text = ds.Tables("cellphone").Rows(0)(2).ToString
            txtbrand.Text = ds.Tables("cellphone").Rows(0)(3).ToString
            txtsim.Text = ds.Tables("cellphone").Rows(0)(4).ToString
            txtos.Text = ds.Tables("cellphone").Rows(0)(5).ToString
            txtdes.Text = ds.Tables("cellphone").Rows(0)(6).ToString
            txtcell.Text = ds.Tables("cellphone").Rows(0)(7).ToString
            ds = New DataSet
        Catch ex As Exception
            MsgBox("No items match your search", MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub dgvInfo_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInfo.CellClick
        Dim i As Integer
        i = dgvInfo.CurrentRow.Index
        'txtName = datagridName.Item(columnName or columnNumber, rowNumber).value.tostring
        txtID.Text = dgvInfo.Item(0, i).Value.ToString
        txtmodel.Text = dgvInfo.Item(1, i).Value.ToString
        txtserial.Text = dgvInfo.Item(2, i).Value.ToString
        txtbrand.Text = dgvInfo.Item(3, i).Value.ToString
        txtsim.Text = dgvInfo.Item(4, i).Value.ToString
        txtos.Text = dgvInfo.Item(5, i).Value.ToString
        txtdes.Text = dgvInfo.Item(6, i).Value.ToString
        txtcell.Text = dgvInfo.Item(7, i).Value.ToString


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MainMenu.Show()

        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub
End Class