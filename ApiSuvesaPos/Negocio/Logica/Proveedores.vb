Namespace Logica
    Public Class Proveedores

        '***************************************************************
        'hay que cargar monedas
        '*** deberia ser de la case monedas para reutilizar el codigo
        'actualmente se carga la cuanta contable del proveedor pero no se usa.

        Public Function buscarProveedores(nombre As String) As List(Of Modelo.proveedores)
            Dim proveedores As New List(Of Modelo.proveedores)
            'valor = Fx.BuscarDatos("Select CodigoProv,Nombre from Proveedores", "Nombre", "Buscar Proveedor...", Me.SqlConnection1.ConnectionString)
            Return proveedores
        End Function

        Public Function cargarProveedores() As List(Of Modelo.proveedores)
            Dim cuentasBancarias As New List(Of Modelo.proveedores)
            'Me.daProveedores.Fill(DataSet_Proveedores1, "Proveedores")
            Return cuentasBancarias
        End Function

        Public Function cargarCuentasBancarias() As List(Of Modelo.cuentas_bancarias_proveedor)
            Dim cuentasBancarias As New List(Of Modelo.cuentas_bancarias_proveedor)
            'Me.da_cuentas.Fill(Me.DataSet_Proveedores1, "Cuentas_Bancarias_Proveedor")
            Return cuentasBancarias
        End Function

        Public Sub crearProveedor(proveedor As Modelo.proveedores)

            'Try

            '    Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores.ProveedoresCuentas_Bancarias_Proveedor").EndCurrentEdit()
            '    Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores").EndCurrentEdit() 'termino edicion

            '    Me.daProveedores.Update(Me.DataSet_Proveedores1.Proveedores)  'actualizo los provedores
            '    Me.da_cuentas.Update(Me.DataSet_Proveedores1.Cuentas_Bancarias_Proveedor)  'Actualiza las cuentas Bancarias Ingresadas

            '    Me.DataSet_Proveedores1.AcceptChanges()    
            'Catch ex As System.Data.NoNullAllowedException 
            '   Cacha los distintos errores que se pueden dar
            'End Try
        End Sub

        Public Sub editarProveedor(proveedor As Modelo.proveedores)

            'Try

            '    Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores.ProveedoresCuentas_Bancarias_Proveedor").EndCurrentEdit()
            '    Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores").EndCurrentEdit() 'termino edicion

            '    Me.daProveedores.Update(Me.DataSet_Proveedores1.Proveedores)  'actualizo los provedores
            '    Me.da_cuentas.Update(Me.DataSet_Proveedores1.Cuentas_Bancarias_Proveedor)  'Actualiza las cuentas Bancarias Ingresadas

            '    Me.DataSet_Proveedores1.AcceptChanges()    
            'Catch ex As System.Data.NoNullAllowedException 
            '   Cacha los distintos errores que se pueden dar
            'End Try
        End Sub

        Public Sub eliminarProveedor(proveedor As Modelo.proveedores)
            'Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores").RemoveAt(Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores").Position)
            'Me.daProveedores.Update(Me.DataSet_Proveedores1, "Proveedores")
        End Sub

        Public Sub eliminarCuentaBancaria(cuentaBancaria As Modelo.cuentas_bancarias_proveedor)
            'valida que no exista productos relacionados

            'Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores.ProveedoresCuentas_Bancarias_Proveedor").RemoveAt(Me.BindingContext(Me.DataSet_Proveedores1, "Proveedores.ProveedoresCuentas_Bancarias_Proveedor").Position)
            'Me.da_cuentas.Update(Me.DataSet_Proveedores1.Cuentas_Bancarias_Proveedor)
        End Sub

    End Class

End Namespace
