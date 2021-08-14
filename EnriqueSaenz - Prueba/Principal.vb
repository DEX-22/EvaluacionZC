Imports EnriqueSaenz___Prueba.Conexion
Imports EnriqueSaenz___Prueba.Pagos


Public Class Principal


    Dim SQL As New Conexion
    Dim id As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click





        SQL.Insertar(cboxProducto.SelectedValue.ToString, cboxCliente.SelectedValue, cboxUsuario.SelectedValue, txtFecha.Value, txtTotal.Value, txtObservacion.Text, chbxEstado.Checked.ToString())





    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDPAGOS.USUARIO_CAJA' Puede moverla o quitarla según sea necesario.
        Me.USUARIO_CAJATableAdapter.Fill(Me.BDPAGOS.USUARIO_CAJA)
        'TODO: esta línea de código carga datos en la tabla 'BDPAGOS.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me.BDPAGOS.CLIENTE)
        'TODO: esta línea de código carga datos en la tabla 'BDPAGOS.PRODUCTO' Puede moverla o quitarla según sea necesario.
        Me.PRODUCTOTableAdapter.Fill(Me.BDPAGOS.PRODUCTO)
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


        MsgBox("se eliminó :" + id)
        'SQL.Eliminar(id)
        '  SQL.Listar(TablaPagos)




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        SQL.Modificar(id, cboxProducto.SelectedValue.ToString, cboxCliente.SelectedValue, cboxUsuario.SelectedValue, txtFecha.Value, txtTotal.Value, txtObservacion.Text, chbxEstado.Checked.ToString())





    End Sub

    Private Sub TablaPagos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaPagos.CellContentClick


        txtId.Text = TablaPagos.Item(0, e.RowIndex).Value


    End Sub
End Class


