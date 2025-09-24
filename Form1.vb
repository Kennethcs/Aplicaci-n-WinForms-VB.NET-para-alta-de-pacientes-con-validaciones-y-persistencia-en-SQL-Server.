Imports System.Windows.Markup

Public Class Form1
    Dim conexion As Conexion = New Conexion()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        set_solo_letras(e)
    End Sub

    Private Sub txtPrimerApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrimerApellido.KeyPress
        set_solo_letras(e)
    End Sub

    Private Sub txtSegundoApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSegundoApellido.KeyPress
        set_solo_letras(e)
    End Sub

    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        set_solo_alfanum(e)
    End Sub

    Private Sub cmbTipoID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoID.SelectedIndexChanged
        mskID.Text = ""
        If cmbTipoID.Text = "NACIONAL" Then
            ntipoid = 1
            mskID.Mask = "9-9999-9999"
            SendKeys.Send("{tab}")
        ElseIf cmbTipoID.Text = "DIMEX" Then
            ntipoid = 2
            mskID.Mask = "999999999"
            SendKeys.Send("{tab}")
        ElseIf cmbTipoID.Text = "PASAPORTE" Then
            ntipoid = 3
            mskID.Mask = "AAAAAAAAA"
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtCorreo_LostFocus(sender As Object, e As EventArgs) Handles txtCorreo.LostFocus
        If conexion.validar_correo(sender.Text) Then
            Return
        Else
            MsgBox("FORMATO INCORRECTO")
            txtCorreo.Focus()
        End If
    End Sub

    Private Function validar_campos() As Boolean
        If cmbTipoID.Text = "" Or Not mskID.MaskFull Or txtNombre.Text = "" Or txtPrimerApellido.Text = "" Or txtDireccion.Text = "" Or txtCorreo.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        f = 0
        Dim vtipoid As Integer
        Dim videntificacion, vnombre, vapellido1, vapellido2, vfechaNacimiento, vdireccion, vemail, vfechaAdmision, strsql, valorformateado, valorsinformato As String

        Try
            If validar_campos() = False Then
                MsgBox("DATOS INCOMPLETOS, favor completar.")
                Return
            Else
                'Quitar los guiones
                valorformateado = mskID.Text
                valorsinformato = valorformateado.Replace("-", "")

                'Mover datos de txt a variables
                vnombre = txtNombre.Text
                vapellido1 = txtPrimerApellido.Text
                vapellido2 = txtSegundoApellido.Text
                vfechaNacimiento = dtpFechaNacimiento.Value.ToString("yyyy-MM-dd")
                vdireccion = txtDireccion.Text
                vemail = txtCorreo.Text
                vfechaAdmision = dtpFechaAdmision.Value.ToString("yyyy-MM-dd")
                vtipoid = ntipoid
                videntificacion = valorsinformato

                'Buscar si identificación ya existe
                Dim dt = conexion.valida_id(vtipoid, videntificacion)
                If f = 0 Then
                    MsgBox("Registro existe en la base de datos, no se puede ingresar nuevamente.")
                    Return
                End If

                'Creación del insert
                strsql = "INSERT INTO Paciente (Identificacion, Nombre, Apellido1, Apellido2, FechaNacimiento, Direccion, Email, FechaAdmision) "
                strsql += "VALUES ('" & videntificacion & "','" & vnombre & "','" & vapellido1 & "','" & vapellido2 & "','" & vfechaNacimiento & "','" & vdireccion & "','" & vemail & "','" & vfechaAdmision & "')"
                MsgBox(strsql)

                conexion.inserta_datos(strsql)
                If f = 0 Then
                    MessageBox.Show("Datos almacenados satisfactoriamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Error al insertar los datos", "Datos no guardados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString)
        End Try
    End Sub

    Private Sub LimpiarCampos()
        Dim i As Integer = 0
        mskID.Clear()
        cmbTipoID.Items.Clear()
        txtNombre.Clear()
        txtPrimerApellido.Clear()
        txtSegundoApellido.Clear()
        txtCorreo.Clear()
        txtDireccion.Clear()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub
End Class
