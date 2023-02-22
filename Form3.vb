Imports System.Data.OleDb
Public Class customer
    Dim dbconn As New OleDbConnection
    Dim adt As New OleDbDataAdapter
    Dim ds As New DataSet

    Dim datatable As New DataTable
    Dim cmd As New OleDbCommand
    Private Sub customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source=..\db_project321.mdb"
        showData() 'show database values in datagridview
        customColumnWidth() ' set custom column width
    End Sub

    Private Sub customColumnWidth() ' set custom column width
        'datagridName.Columns(columnNumber or columnName)
        Dim columnID As DataGridViewColumn = dgvInfo.Columns(0)
        columnID.Width = 40 'set columnwidth
        Dim columncustomer_name As DataGridViewColumn = dgvInfo.Columns(1)
        columncustomer_name.Width = 100 'set columnwidth
    End Sub
    Private Sub showData()
        Dim dbcommand As String
        dbcommand = "SELECT * FROM customer"
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
            If Len(Trim(txtcustomername.Text)) = 0 Then
                MessageBox.Show("Please enter customer_name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtcustomername.Focus()
            ElseIf Len(Trim(txtphonenumber.Text)) = 0 Then
                MessageBox.Show("Please enter phone_number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtphonenumber.Focus()
            ElseIf Len(Trim(txtemail.Text)) = 0 Then
                MessageBox.Show("Please enter email", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtemail.Focus()

            Else
                adt = New OleDbDataAdapter("insert into customer (customer_name,phone_number,email) values ('" & txtcustomername.Text & "', '" & txtphonenumber.Text & "', '" & txtemail.Text & "')", dbconn)
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
        txtcustomername.Text = ""
        txtphonenumber.Text = ""
        txtemail.Text = ""

    End Sub
    Private Sub txtcustomername_TextChanged(sender As Object, e As EventArgs) Handles txtcustomername.TextChanged

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
            If Len(Trim(txtcustomername.Text)) = 0 Then
                MessageBox.Show("Please enter name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtcustomername.Focus()
            ElseIf Len(Trim(txtphonenumber.Text)) = 0 Then
                MessageBox.Show("Please enter number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtphonenumber.Focus()
            ElseIf Len(Trim(txtemail.Text)) = 0 Then
                MessageBox.Show("Please enter email", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtemail.Focus()

            Else

                adt = New OleDbDataAdapter("update customer set customer_name='" & txtcustomername.Text & "', phone_number='" & txtphonenumber.Text & "', email='" & txtemail.Text & "' where customerID=" & txtID.Text & "", dbconn)
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
        dr = MessageBox.Show("delete information?", "delete", MessageBoxButtons.YesNo)
        If dr = DialogResult.No Then
            'NO CONDITION GOES HERE
        Else
            'YES CONDITION GOES HERE
            'Form restriction and validation
            If Len(Trim(txtcustomername.Text)) = 0 Then
                MessageBox.Show("Please enter name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtcustomername.Focus()
            ElseIf Len(Trim(txtphonenumber.Text)) = 0 Then
                MessageBox.Show("Please enter number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtphonenumber.Focus()
            ElseIf Len(Trim(txtemail.Text)) = 0 Then
                MessageBox.Show("Please enter email", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtemail.Focus()

            Else

                adt = New OleDbDataAdapter("delete customer_name='" & txtcustomername.Text & "', phone_number='" & txtphonenumber.Text & "', email='" & txtemail.Text & "' from customer where customerID=" & txtID.Text & "", dbconn)
                adt.Fill(ds)
                ds = New DataSet
                showData() ' refresh data in datagridview
                MsgBox("deleted")
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
            If cboFilter.SelectedItem = "customerID" Then
                Dim dataView As New DataView(datatable)
                dataView.RowFilter = String.Format("customerID = " & txtSearch.Text & "")
                dgvInfo.DataSource = dataView

            ElseIf cboFilter.SelectedItem = "customer_name" Then
                Dim dataView As New DataView(datatable)
                dataView.RowFilter = String.Format("customer_name like '%" & txtSearch.Text & "%'")
                dgvInfo.DataSource = dataView

            ElseIf cboFilter.SelectedItem = "phone_number " Then
                Dim dataView As New DataView(datatable)
                dataView.RowFilter = String.Format("phone_number like '%" & txtSearch.Text & "%'")
                dgvInfo.DataSource = dataView

            ElseIf cboFilter.SelectedItem = "email" Then
                Dim dataView As New DataView(datatable)
                dataView.RowFilter = String.Format("email like '%" & txtSearch.Text & "%'")


            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnFind_Click(sender As Object, e As EventArgs)
        Try
            Dim sql = "select * from customer where customerID like " & txtID.Text & " "
            adt = New OleDbDataAdapter(sql, dbconn)
            cmd = New OleDbCommand(sql)
            adt.Fill(ds, "customer")
            'ds.tables(tableName).rows(rowNumber)(columnNumber).tostring

            txtcustomername.Text = ds.Tables("customer").Rows(0)(1).ToString
            txtphonenumber.Text = ds.Tables("customer").Rows(0)(2).ToString
            txtemail.Text = ds.Tables("customer").Rows(0)(3).ToString

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
        txtcustomername.Text = dgvInfo.Item(1, i).Value.ToString
        txtphonenumber.Text = dgvInfo.Item(2, i).Value.ToString
        txtemail.Text = dgvInfo.Item(3, i).Value.ToString



    End Sub

    Private Sub cboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub
End Class