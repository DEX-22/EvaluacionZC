Imports EnriqueSaenz___Prueba.Conexion


Public Class Principal


    Dim SQL As New Conexion
    Dim id As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click





        SQL.Insertar(cboxProducto.SelectedValue.ToString, cboxCliente.SelectedValue, cboxUsuario.SelectedValue, txtFecha.Value, txtTotal.Value, txtObservacion.Text, chbxEstado.Checked.ToString())





    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDPAGOSDataSet1.PRODUCTO' Puede moverla o quitarla según sea necesario.
        Me.PRODUCTOTableAdapter1.Fill(Me.BDPAGOSDataSet1.PRODUCTO)

        'TODO: esta línea de código carga datos en la tabla 'BDPAGOS.PAGO' Puede moverla o quitarla según sea necesario.
        Me.PAGOTableAdapter.Fill(Me.BDPAGOS.PAGO)
        'TODO: esta línea de código carga datos en la tabla 'BDPAGOS.USUARIO_CAJA' Puede moverla o quitarla según sea necesario.
        Me.USUARIO_CAJATableAdapter.Fill(Me.BDPAGOS.USUARIO_CAJA)
        'TODO: esta línea de código carga datos en la tabla 'BDPAGOS.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me.BDPAGOS.CLIENTE)

        'TODO: esta línea de código carga datos en la tabla 'BDPAGOS.USUARIO_CAJA' Puede moverla o quitarla según sea necesario.
        Me.USUARIO_CAJATableAdapter.Fill(Me.BDPAGOS.USUARIO_CAJA)
        'TODO: esta línea de código carga datos en la tabla 'BDPAGOS.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me.BDPAGOS.CLIENTE)
        'TODO: esta línea de código carga datos en la tabla 'BDPAGOS.PRODUCTO' Puede moverla o quitarla según sea necesario.


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        SQL.Listar(TablaPagos)





        '     TablaPagos.Columns.Clear()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click



        SQL.Eliminar(id)
        'MsgBox("se eliminó :" + Me.id)
        txtId.Text = ""

        SQL.Listar(TablaPagos)




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        SQL.Modificar(id, cboxProducto.SelectedValue.ToString, cboxCliente.SelectedValue, cboxUsuario.SelectedValue, txtFecha.Value, txtTotal.Value, txtObservacion.Text, chbxEstado.Checked.ToString())
        SQL.Listar(TablaPagos)
        txtId.Text = ""
        cboxCliente.SelectedIndex = 0
        cboxProducto.SelectedIndex = 0
        cboxUsuario.SelectedIndex = 0
        chbxEstado.CheckState = False
        txtTotal.Value = 0
        txtObservacion.Text = ""




    End Sub

    Private Sub TablaPagos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaPagos.CellContentClick


        If e.RowIndex >= 0 Then
            TablaPagos.CurrentCell = TablaPagos.Item(0, e.RowIndex)

            Me.id = TablaPagos.CurrentCell.Value



            txtId.Text = Me.id
        End If
        'TablaPagos.Item(0, e.RowIndex).Value


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Opcion As Integer = cboxOpcion.SelectedIndex + 1
        Dim Dato As String = txtDato.Text

        SQL.Reportes(TablaReportes, Dato, Opcion)



    End Sub
End Class


