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

        Public Function obtenerComprasPendientes(codigoProv As String) As List(Of Modelo.compras)

            '    Public Shared Function BuscarFacturas_Proveedor(ByVal CodigoProv As Integer, Optional ByVal Conexion As String = "") As DataTable
            '    Dim cnn As SqlConnection = Nothing
            '    Dim dt As New DataTable
            '    ' Dentro de un Try/Catch por si se produce un error
            '    Try
            '        ' Obtenemos la cadena de conexión adecuada
            '        Dim sConn As String = IIf(Conexion = "", CadenaConexionSeePOS, Conexion)
            '        cnn = New SqlConnection(sConn)
            '        cnn.Open()
            '        ' Creamos el comando para la consulta
            '        Dim cmd As SqlCommand = New SqlCommand
            '        Dim sel As String =
            '    "SELECT Factura, Fecha, TotalFactura, Cod_MonedaCompra FROM compras WHERE (FacturaCancelado = 0) AND (TipoCompra = 'CRE') AND (CodigoProv = " & CodigoProv & ")" ' AND (dbo.SaldoFacturaCompra(GETDATE(), Factura, CodigoProv) <> 0)"
            '        cmd.CommandText = sel
            '        cmd.Connection = cnn
            '        cmd.CommandType = CommandType.Text
            '        cmd.CommandTimeout = 90
            '        ' Los parámetros usados en la cadena de la consulta 
            '        cmd.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.Int))
            '        cmd.Parameters("@Codigo").Value = CodigoProv
            '        ' Creamos el dataAdapter y asignamos el comando de selección
            '        Dim da As New SqlDataAdapter
            '        da.SelectCommand = cmd
            '        ' Llenamos la tabla

            '        da.Fill(dt)

            '    Catch ex As System.Exception
            '        ' Si hay error, devolvemos un valor nulo.
            '        MsgBox(ex.ToString)
            '        Return Nothing
            '    Finally
            '        ' Por si se produce un error,
            '        ' comprobamos si en realidad el objeto Connection está iniciado,
            '        ' de ser así, lo cerramos.
            '        If Not cnn Is Nothing Then
            '            cnn.Close()
            '        End If
            '    End Try

            '    Return dt ' Devolvemos el objeto DataTable con los datos de la consulta
            'End Function

        End Function

    End Class

End Namespace
