Module Funcion
    Public ntipoid, f As Integer

    Public Sub set_solo_letras(ByRef ee As System.Windows.Forms.KeyPressEventArgs)
        Dim cadena As String
        cadena = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ"
        If InStr(cadena, ee.KeyChar) Then
            ee.Handled = False
        ElseIf Char.IsControl(ee.KeyChar) Then
            ee.Handled = False
        Else
            ee.Handled = True
        End If
    End Sub

    Public Sub set_solo_alfanum(ByRef ee As System.Windows.Forms.KeyPressEventArgs)
        Dim cadena_alfanum As String
        cadena_alfanum = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ123456789 , ."
        If InStr(cadena_alfanum, ee.KeyChar) Then
            ee.Handled = False
        ElseIf Char.IsControl(ee.KeyChar) Then
            ee.Handled = False
        Else
            ee.Handled = True
        End If
    End Sub
End Module
