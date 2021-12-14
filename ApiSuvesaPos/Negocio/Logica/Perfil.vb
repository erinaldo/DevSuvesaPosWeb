Public Class Perfil

    Public Function Buscar() As List(Of Modelo.perfil)

        'Me.AdapterPerfil.Fill(Me.DataSetPerfilUsuario1.Perfil)

    End Function


    Public Sub Crear()

        'Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").EndCurrentEdit()
        'Me.AdapterPerfil.Update(Me.DataSetPerfilUsuario1, "Perfil")

    End Sub

    Public Sub Editar()

        'Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").EndCurrentEdit()
        'Me.AdapterPerfil.Update(Me.DataSetPerfilUsuario1, "Perfil")

    End Sub

    Public Sub Eliminar()

        'Public Sub EliminarDatos(ByRef Adaptador As System.Data.SqlClient.SqlDataAdapter, ByRef DataSet As DataSet, ByRef Tabla As String, Optional ByVal RecargarAdatador As Boolean = True)
        '    Dim resp As Integer

        '    If MsgBox("Desea eliminar el registrto actual...", MsgBoxStyle.YesNo, "Atención...") = MsgBoxResult.Yes Then
        '        Try
        '            BindingContext(DataSet, Tabla).RemoveAt(BindingContext(DataSet, Tabla).Position)
        '            BindingContext(DataSet, Tabla).EndCurrentEdit()
        '            Adaptador.Update(DataSet, Tabla)
        '            If RecargarAdatador Then Adaptador.Update(DataSet, Tabla)
        '            Adaptador.Fill(DataSet, Tabla)

        '            MsgBox("Los datos se eliminaron satisfactoriamente", MsgBoxStyle.Information)

        '        Catch eEndEdit As System.Data.NoNullAllowedException
        '            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        '        End Try
        '    End If
        'End Sub

    End Sub

End Class
