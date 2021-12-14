Namespace Logica
    Public Class Gastos

        Public Property Moneda As New Monedas
        Public Property Proveedores As New Proveedores

        Public Function Buscar(porNombre As Boolean, porFactura As Boolean, filtro As String) As List(Of Modelo.compras)
            '== a busarcompra pero filtrando las compras
            Dim compras As New List(Of Modelo.compras)
            'Dim Fx As New cFunciones

            'identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("Select Id_Compra, (convert(Varchar, convert(Bigint,Factura,0),1) + '-' + TipoCompra)as Factura,Proveedores.nombre,Fecha from compras inner join Proveedores on compras.CodigoProv = Proveedores.CodigoProv Order by Fecha DESC", "nombre", "Fecha", "Buscar Factura de Compra"))

            'buscando = True
            Return compras
        End Function

        Public Sub Crear(gasto As Modelo.compras)

            'If IdGasto = -1 Then
            '    sql = " INSERT INTO Compras (Factura,CodigoProv,SubTotalGravado,SubTotalExento,Descuento,Impuesto" &
            '        " ,TotalFactura, Fecha,Vence,FechaIngreso,Gasto,TipoCompra,Cod_MonedaCompra,TipoCambio,CedulaUsuario) " &
            '        " VALUES (" & txtNumeroFactura.Text & "," & idProveedor(Me.cmbProveedor.SelectedIndex) & "," &
            '        Grabado & "," & exento & "," & TotalDescuento & "," &
            '        TotalImpuesto & "," & Total & ",'" & Me.dtpFecha.Value.Date & "','" &
            '        FechaVence & "','" & Date.Now.Date & "',1,'" & TipoFactura(Me.cmbTipo.SelectedIndex) & "'," & IdMoneda(Me.cmbMoneda.SelectedIndex) & "," & BuscarTipoCambio(IdMoneda(Me.cmbMoneda.SelectedIndex)) & " , '" & Me.Id_Usuario & "' )"
            'Else
            '    sql = "UPDATE Compras SET Factura =" & txtNumeroFactura.Text & ",CodigoProv=" & idProveedor(Me.cmbProveedor.SelectedIndex) & "," &
            '            "SubTotalGravado=" & Grabado & ",SubTotalExento=" & exento & ",Descuento=" & TotalDescuento & "," &
            '            "Impuesto =" & TotalImpuesto & ", TotalFactura=" & Total & ",Fecha ='" & dtpFecha.Value.Date & "'," &
            '            "Vence = '" & FechaVence & "', FechaIngreso='" & dtpFecha.Value.Date & "'" &
            '            ",TipoCompra='" & TipoFactura(Me.cmbTipo.SelectedIndex) & "',Cod_MonedaCompra=" & IdMoneda(Me.cmbMoneda.SelectedIndex) & ", TipoCambio = " & BuscarTipoCambio(IdMoneda(Me.cmbMoneda.SelectedIndex)) & "  WHERE ID_Compra =" & IdGasto
            'End If

            'cnnConexion.ConnectionString = CadenaConexionSeePOS
            'cnnConexion.Open()
            'clsConexion.SlqExecute(cnnConexion, sql)

            'If IdGasto = -1 Then
            '    sql = "Select max(id_compra) from compras where Factura = " & Me.txtNumeroFactura.Text & " and codigoprov = " & idProveedor(Me.cmbProveedor.SelectedIndex) & " and gasto = 1"
            '    rstReader = clsConexion.GetRecorset(cnnConexion, sql)
            '    rstReader.Read()
            '    IdGasto = rstReader(0)
            'End If
            'cnnConexion.Close()

            'AgregarDetalleBD(IdGasto)

            'cnnConexion.ConnectionString = CadenaConexionSeePOS
            'cnnConexion.Open()

            'sql = "DELETE FROM Articulos_Gastos WHERE IDCOMPRA = " & pIdGasto
            'clsConexion.SlqExecute(cnnConexion, sql)


            'For n = 0 To Me.dtsGasto.GastoDetalle.Count - 1
            '    With dtsGasto.GastoDetalle(n)
            '        sql = "INSERT INTO Articulos_Gastos(IdCompra,Descripcion,Base,Costo,Cantidad,Gravado,Exento," &
            '                "Descuento_p,Descuento,Impuesto_p,Impuesto,Total,NuevoCostoBase,CuentaContable)" &
            '                " VALUES(" & pIdGasto & ",'" & .Descripcion &
            '                "'," & .Costo & "," & .Costo & "," & .Cantidad & "," & .Gravado & "," & .Exento &
            '                "," & .Descuento_P & "," & .Descuento & "," & .Impuesto_p & "," & .Impuesto &
            '                "," & .Total & "," & .NuevoCostoBase & ",'" & .CuentaContable & "')"
            '        clsConexion.SlqExecute(cnnConexion, sql)
            '    End With
            'Next
            'cnnConexion.Close()

        End Sub


        Public Sub Editar(gasto As Modelo.compras)

            'If IdGasto = -1 Then
            '    sql = " INSERT INTO Compras (Factura,CodigoProv,SubTotalGravado,SubTotalExento,Descuento,Impuesto" &
            '        " ,TotalFactura, Fecha,Vence,FechaIngreso,Gasto,TipoCompra,Cod_MonedaCompra,TipoCambio,CedulaUsuario) " &
            '        " VALUES (" & txtNumeroFactura.Text & "," & idProveedor(Me.cmbProveedor.SelectedIndex) & "," &
            '        Grabado & "," & exento & "," & TotalDescuento & "," &
            '        TotalImpuesto & "," & Total & ",'" & Me.dtpFecha.Value.Date & "','" &
            '        FechaVence & "','" & Date.Now.Date & "',1,'" & TipoFactura(Me.cmbTipo.SelectedIndex) & "'," & IdMoneda(Me.cmbMoneda.SelectedIndex) & "," & BuscarTipoCambio(IdMoneda(Me.cmbMoneda.SelectedIndex)) & " , '" & Me.Id_Usuario & "' )"
            'Else
            '    sql = "UPDATE Compras SET Factura =" & txtNumeroFactura.Text & ",CodigoProv=" & idProveedor(Me.cmbProveedor.SelectedIndex) & "," &
            '            "SubTotalGravado=" & Grabado & ",SubTotalExento=" & exento & ",Descuento=" & TotalDescuento & "," &
            '            "Impuesto =" & TotalImpuesto & ", TotalFactura=" & Total & ",Fecha ='" & dtpFecha.Value.Date & "'," &
            '            "Vence = '" & FechaVence & "', FechaIngreso='" & dtpFecha.Value.Date & "'" &
            '            ",TipoCompra='" & TipoFactura(Me.cmbTipo.SelectedIndex) & "',Cod_MonedaCompra=" & IdMoneda(Me.cmbMoneda.SelectedIndex) & ", TipoCambio = " & BuscarTipoCambio(IdMoneda(Me.cmbMoneda.SelectedIndex)) & "  WHERE ID_Compra =" & IdGasto
            'End If

            'cnnConexion.ConnectionString = CadenaConexionSeePOS
            'cnnConexion.Open()
            'clsConexion.SlqExecute(cnnConexion, sql)

            'If IdGasto = -1 Then
            '    sql = "Select max(id_compra) from compras where Factura = " & Me.txtNumeroFactura.Text & " and codigoprov = " & idProveedor(Me.cmbProveedor.SelectedIndex) & " and gasto = 1"
            '    rstReader = clsConexion.GetRecorset(cnnConexion, sql)
            '    rstReader.Read()
            '    IdGasto = rstReader(0)
            'End If
            'cnnConexion.Close()

            'AgregarDetalleBD(IdGasto)

            'cnnConexion.ConnectionString = CadenaConexionSeePOS
            'cnnConexion.Open()

            'sql = "DELETE FROM Articulos_Gastos WHERE IDCOMPRA = " & pIdGasto
            'clsConexion.SlqExecute(cnnConexion, sql)


            'For n = 0 To Me.dtsGasto.GastoDetalle.Count - 1
            '    With dtsGasto.GastoDetalle(n)
            '        sql = "INSERT INTO Articulos_Gastos(IdCompra,Descripcion,Base,Costo,Cantidad,Gravado,Exento," &
            '                "Descuento_p,Descuento,Impuesto_p,Impuesto,Total,NuevoCostoBase,CuentaContable)" &
            '                " VALUES(" & pIdGasto & ",'" & .Descripcion &
            '                "'," & .Costo & "," & .Costo & "," & .Cantidad & "," & .Gravado & "," & .Exento &
            '                "," & .Descuento_P & "," & .Descuento & "," & .Impuesto_p & "," & .Impuesto &
            '                "," & .Total & "," & .NuevoCostoBase & ",'" & .CuentaContable & "')"
            '        clsConexion.SlqExecute(cnnConexion, sql)
            '    End With
            'Next
            'cnnConexion.Close()

        End Sub

        Public Sub Eliminar(idcompra As Integer)

            '     Private Sub EliminarBD()
            '    Dim sql As String
            '    Dim clsConexion As New Conexion
            '    Dim cnnConexion As New System.Data.SqlClient.SqlConnection
            '    Dim n As Integer

            '    If IdGasto = -1 Then Exit Sub
            '    If ValidarModificarElimar() = False Then
            '        MsgBox("No se puede eliminar la factura")
            '        Exit Sub
            '    End If

            '    cnnConexion.ConnectionString = CadenaConexionSeePOS
            '    cnnConexion.Open()


            '    If MessageBox.Show("¿Desea eliminar esta Factura de gasto ?", "SeePos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = 6 Then


            '        'Elimnar los detalles
            '        sql = "Delete from Articulos_Gastos where IdCompra=" & IdGasto
            '        clsConexion.SlqExecute(cnnConexion, sql)

            '        'Eliminar la cabezara
            '        sql = "DELETE FROM  Compras where id_compra =" & IdGasto
            '        clsConexion.SlqExecute(cnnConexion, sql)

            '        cnnConexion.Close()

            '        Me.tlbNuevo.Enabled = True
            '        Me.tlbBuscar.Enabled = True
            '        Me.tlbRegistrar.Enabled = False
            '        Me.tlbEliminar.Enabled = False
            '        Me.tlbImprimir.Enabled = False

            '        Me.LimpiarCabezera()
            '        Me.DesactivarCabezera()
            '    End If
            'End Sub

        End Sub

    End Class
End Namespace