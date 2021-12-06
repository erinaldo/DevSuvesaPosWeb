Namespace Logica
    Public Class Perfil_x_Modulo

        Public Sub crearPerfil_x_modulo()

            'Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").EndCurrentEdit()

            'Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").AddNew()
            'Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").CancelCurrentEdit()
            'Me.AdapterPerfilModulo.Update(Me.DataSetPerfilUsuario1, "Perfil_x_Modulo")

        End Sub

        Public Sub editarPerfil_x_modulo()

            'Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").EndCurrentEdit()

            'Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").AddNew()
            'Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil.PerfilPerfil_x_Modulo").CancelCurrentEdit()
            'Me.AdapterPerfilModulo.Update(Me.DataSetPerfilUsuario1, "Perfil_x_Modulo")

        End Sub

        Public Sub eliminarPerfil_x_Modulo()

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
End Namespace