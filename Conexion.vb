Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Conexion
    Public conexion As SqlConnection = New SqlConnection("Data source= HARAKIRI; Initial Catalog= PARCIALII; Trusted_connection= Yes")
    Public comando As SqlCommand
    Public da As SqlDataAdapter
    Public ds As DataSet = New DataSet()
    Public builder As SqlCommandBuilder

    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("CONEXION EXITOSA")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString)
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function validar_correo(ByRef e As String) As Boolean
        Try
            Return Regex.IsMatch(e.Trim, "^[0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9}$")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    Public Function inserta_datos(ByVal datos As String) As Boolean
        Try
            conexion.Open()
            comando = New SqlCommand(datos, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            f = 0
            Return True
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString)
            f = 1
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function valida_id(ByVal vtipoid As String, ByVal videntificacion As String) As DataTable
        Dim dt = New DataTable()
        consultar("SELECT * FROM Paciente WHERE PacienteID= " & vtipoid.ToString() & " AND Identificacion= '" & videntificacion & "'", "Paciente")
        If ds.Tables("Paciente").Rows.Count > 0 Then
            f = 0
        Else
            f = 1
        End If

        da.Fill(dt)
        Return dt
    End Function

    Public Sub consultar(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        builder = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub
End Class
