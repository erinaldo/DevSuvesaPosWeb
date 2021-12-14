Namespace Logica
    Public Class Clientes_frecuentes

        Public Sub Anular()

            'Function Registrar_Anulacion_cliente(ByVal Anular As Boolean) As Boolean
            '    Dim Cx As New Conexion
            '    Try
            '        If Anular = True Then
            '            Cx.UpdateRecords("Clientes_frecuentes", "Anulado = 1", "Identificacion = " & BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").Current("Identificacion"), "SeePos")
            '        Else
            '            Cx.UpdateRecords("Clientes_frecuentes", "Anulado = 0", "Identificacion = " & BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").Current("Identificacion"), "SeePos")
            '        End If

            '        Return True

            '    Catch ex As Exception
            '        MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            '        Me.ToolBar1.Buttons(3).Enabled = True
            '        Return False
            '    End Try
            'End Function

        End Sub

        Public Sub Eliminar(identificacion As Integer)

            'Me.BindingContext(Me.DataSetClienteFrecuente1, "Bitacora").EndCurrentEdit()

            'Me.BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").RemoveAt(Me.BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").Position)
            'Me.BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").EndCurrentEdit()

            'Eliminando = True


            'If Me.RegistrarCliente Then
            '    MessageBox.Show("El cliente fue Eliminado Satisfactoriamente", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Me.DataSetClienteFrecuente1.Clientes_frecuentes.Clear()
            'End If

        End Sub

        Public Sub Crear(cliente_frecuente As Modelo.clientes_frecuentes)

            'BindingContext(DataSetClienteFrecuente1, "Clientes_frecuentes").EndCurrentEdit()


            'If Me.RegistrarCliente() Then 'se registra en la base de datos then
            '    Me.DataSetClienteFrecuente1.AcceptChanges()

            '    Me.DataSetClienteFrecuente1.Clientes_frecuentes.Clear()

        End Sub

        Public Sub Editar(cliente_frecuente As Clientes_frecuentes)

            'BindingContext(DataSetClienteFrecuente1, "Clientes_frecuentes").EndCurrentEdit()


            'If Me.RegistrarCliente() Then 'se registra en la base de datos then
            '    Me.DataSetClienteFrecuente1.AcceptChanges()

            '    Me.DataSetClienteFrecuente1.Clientes_frecuentes.Clear()

        End Sub

        Public Function Buscar(porNombre As Boolean,
                                      porCedula As Boolean,
                                      filtro As String) As List(Of Modelo.clientes_frecuentes)

            'Dim cFunciones As New cFunciones
            'Me.Cod_Cliente_Buscar = cFunciones.BuscarDatosClientes("select identificacion as Identificación,nombre as Nombre from Clientes_frecuentes", "Nombre")

            'If Cod_Cliente_Buscar = 0 Then Exit Sub
            'Me.BindingContext(Me.DataSetClienteFrecuente1, "Clientes_frecuentes").CancelCurrentEdit()

            'If nuevo Then nuevo = False
            'LlenarCliente(Cod_Cliente_Buscar)

        End Function

    End Class
End Namespace