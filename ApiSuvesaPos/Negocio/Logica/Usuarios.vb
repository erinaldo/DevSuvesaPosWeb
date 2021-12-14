Namespace Logica
    Public Class Usuarios

        Public Property Perfil_x_Usuario As New Logica.Perfil_x_Usuario

        Public Function obtenerUsuarios() As List(Of Modelo.usuarios)

            'Me.AdapterUsuario.Fill(Me.DatasetUsuario1.Usuarios)

        End Function

        Public Function Buscar() As List(Of Modelo.usuarios)

            'Id = funcion.BuscarDatos("SELECT Id_Usuario,Nombre FROM Usuarios", "Nombre", "Buscar Usuario ...", Me.SqlConnection1.ConnectionString)
            'cedula = Id
            'LlenarUsuario(Id)

        End Function

        Public Sub Crear(usuario As Modelo.usuarios)

            '    Function Registra()
            '    Try

            '        Me.BindingContext(Me.DatasetUsuario1, "Usuarios").EndCurrentEdit()
            '        Me.AdapterUsuario.Update(Me.DatasetUsuario1.Usuarios)

            '        Me.BindingContext(Me.DatasetUsuario1, "Perfil_x_Usuario").EndCurrentEdit()
            '        Me.AdapterPerfilxUsuario.Update(Me.DatasetUsuario1.Perfil_x_Usuario)

            '        Me.BindingContext(Me.DatasetUsuario1, "Perfil").EndCurrentEdit()
            '        Me.AdapterPerfil.Update(Me.DatasetUsuario1.Perfil)

            '        Me.GridControl1.Refresh()
            '        Me.DatasetUsuario1.GetChanges()

            '        Activar_desactivar_Campos(False)

            '        DataNavigator1.Enabled = True

            '        'toolBar
            '        Me.ToolBarNuevo.Text = "Nuevo"
            '        Me.ToolBarNuevo.ImageIndex = 0
            '        Me.ToolBarBuscar.Text = "Editar"
            '        Me.ToolBarBuscar.ImageIndex = 9
            '        Me.ToolBarBuscar.Enabled = True
            '        Me.ToolBarNuevo.Enabled = True
            '        Me.ToolBarRegistrar.Enabled = False
            '        Me.ToolBarEliminar.Enabled = True

            '    Catch ex As SystemException
            '        Dim mesg As String = "Problemas al Registrar un Usuario." & vbCrLf &
            '                         "Intente Iniciar el formulario Otra vez, " & vbCrLf &
            '                         "si el problema persiste comuniquelo al 'Administrador del Sistema'" & vbCrLf &
            '                         "'" & ex.Message & "'"
            '        MsgBox(mesg, MsgBoxStyle.Critical, "Atención")
            '    End Try

            'End Function

        End Sub

        Public Sub Editar(usuario As Modelo.usuarios)

            '    Function Registra()
            '    Try

            '        Me.BindingContext(Me.DatasetUsuario1, "Usuarios").EndCurrentEdit()
            '        Me.AdapterUsuario.Update(Me.DatasetUsuario1.Usuarios)

            '        Me.BindingContext(Me.DatasetUsuario1, "Perfil_x_Usuario").EndCurrentEdit()
            '        Me.AdapterPerfilxUsuario.Update(Me.DatasetUsuario1.Perfil_x_Usuario)

            '        Me.BindingContext(Me.DatasetUsuario1, "Perfil").EndCurrentEdit()
            '        Me.AdapterPerfil.Update(Me.DatasetUsuario1.Perfil)

            '        Me.GridControl1.Refresh()
            '        Me.DatasetUsuario1.GetChanges()

            '        Activar_desactivar_Campos(False)

            '        DataNavigator1.Enabled = True

            '        'toolBar
            '        Me.ToolBarNuevo.Text = "Nuevo"
            '        Me.ToolBarNuevo.ImageIndex = 0
            '        Me.ToolBarBuscar.Text = "Editar"
            '        Me.ToolBarBuscar.ImageIndex = 9
            '        Me.ToolBarBuscar.Enabled = True
            '        Me.ToolBarNuevo.Enabled = True
            '        Me.ToolBarRegistrar.Enabled = False
            '        Me.ToolBarEliminar.Enabled = True

            '    Catch ex As SystemException
            '        Dim mesg As String = "Problemas al Registrar un Usuario." & vbCrLf &
            '                         "Intente Iniciar el formulario Otra vez, " & vbCrLf &
            '                         "si el problema persiste comuniquelo al 'Administrador del Sistema'" & vbCrLf &
            '                         "'" & ex.Message & "'"
            '        MsgBox(mesg, MsgBoxStyle.Critical, "Atención")
            '    End Try

            'End Function

        End Sub

    End Class
End Namespace