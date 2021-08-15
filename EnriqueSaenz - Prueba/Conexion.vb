Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class Conexion

    Dim Server As String
    Dim NombreBD As String
    Dim Usuario As String
    Dim Password As String
    Dim CadenaConexion As String
    Dim Consulta As SqlCommand
    Dim Conexion As SqlConnection
    Dim SqlDataAdapter As SqlDataAdapter
    Dim DataSet As New DataSet
    Dim DataTable As New DataTable


    Public Sub Conectar()

        Server = "192.168.0.22"
        NombreBD = "BDPAGOS"
        Usuario = "sa"
        Password = "123servidorASD"
        CadenaConexion = "Data Source=" & Server & ";Initial Catalog=" & NombreBD & ";Persist Security Info=True;User ID=" & Usuario & ";Password=" & Password

        Conexion = New SqlConnection(CadenaConexion)



    End Sub

    Public Sub Listar(Tabla As DataGridView)

        DataTable = New DataTable


        Conectar()
        Me.Conexion.Open()

        SqlDataAdapter = New SqlDataAdapter("EXEC SP_CRUD_PAGO 0,'',0,0,'',0,'',0,'R'", Conexion)
        SqlDataAdapter.Fill(DataTable)
        Tabla.DataSource = DataTable

        Me.Conexion.Close()



    End Sub
    Public Sub Insertar(producto As String, cliente As Integer, usuario As Integer, fecha As Date, total As Decimal, observacion As String, estado As Boolean)
        Conectar()
        Dim Status As Integer
        If estado Then
            Status = 1
        Else
            Status = 0
        End If
        Consulta = New SqlCommand("EXEC SP_CRUD_PAGO 0,'" & producto & "'," & cliente & "," & usuario & ",'" & fecha & "'," & total & ",'" & observacion & "'," & Status & ",'C'", Me.Conexion)
        Conexion.Open()
        Consulta.ExecuteNonQuery()
        MsgBox("Se registró con exito")
        '-------------



    End Sub
    Public Sub Modificar(id As Integer, producto As String, cliente As Integer, usuario As Integer, fecha As Date, total As Decimal, observacion As String, estado As Boolean)
        Conectar()
        Dim Status As Integer
        If estado Then
            Status = 1
        Else
            Status = 0
        End If
        Consulta = New SqlCommand("EXEC SP_CRUD_PAGO " & id & ",'" & producto & "'," & cliente & "," & usuario & ",'" & fecha & "'," & total & ",'" & observacion & "'," & Status & ",'U'", Me.Conexion)
        Conexion.Open()
        Consulta.ExecuteNonQuery()
        MsgBox("Se modificó con exito")
    End Sub
    Public Sub Eliminar(id As Integer)
        Conectar()


        Consulta = New SqlCommand("EXEC SP_CRUD_PAGO " & id & ",'',0,0,'',0,'',0,'D'", Me.Conexion)
        Conexion.Open()
        Consulta.ExecuteNonQuery()
        MsgBox("Se eliminó con exito")
    End Sub
    Public Sub Reportes(Tabla As DataGridView, Dato As String, Opcion As Integer)

        DataTable = New DataTable


        Conectar()
        Me.Conexion.Open()


        If Opcion = 1 Then
            SqlDataAdapter = New SqlDataAdapter("EXEC SP_REPORT_PAGO " & Dato & ",'',''," & Opcion, Conexion)

        ElseIf Opcion = 2 Then
            SqlDataAdapter = New SqlDataAdapter("EXEC SP_REPORT_PAGO ''," & Dato & ",''," & Opcion, Conexion)

        ElseIf Opcion = 3 Then
            SqlDataAdapter = New SqlDataAdapter("EXEC SP_REPORT_PAGO '',''," & Dato & "," & Opcion, Conexion)

        End If




        SqlDataAdapter.Fill(DataTable)
        Tabla.DataSource = DataTable

        Me.Conexion.Close()





    End Sub




End Class
