Namespace Logica
    Public Class Compras


        '**************** actualmente los lotes no se usan porque no sirven pero se quiere
        Public Property Moneda As New Monedas
        Public Property Proveedores As New Proveedores
        Public Property Inventario As New Inventario


        Public Sub eliminarCompra(compra As Modelo.compras)


            'Dim Transaccion As SqlTransaction
            'Try

            '    ToolBar1.Buttons(2).Enabled = False
            '    If SqlConnection.State <> SqlConnection.State.Open Then SqlConnection.Open()
            '    Transaccion = SqlConnection.BeginTransaction
            '    'Se crea la transaccion & se asigna a los commandos
            '    AdapterCompras.UpdateCommand.Transaction = Transaccion
            '    AdapterCompras.DeleteCommand.Transaction = Transaccion

            '    'Transacciones en Articulos comprados 
            '    AdapterArticulos_Comprados.UpdateCommand.Transaction = Transaccion
            '    AdapterArticulos_Comprados.DeleteCommand.Transaction = Transaccion

            '    'Transacciones en Lotes 
            '    Me.AdapterLotes.UpdateCommand.Transaction = Transaccion
            '    Me.AdapterLotes.DeleteCommand.Transaction = Transaccion

            '    BindingContext(DataSetCompras, "compras").RemoveAt(BindingContext(DataSetCompras, "compras").Position)
            '    BindingContext(DataSetCompras, "compras").EndCurrentEdit()

            '    Me.AdapterLotes.Update(DataSetCompras, "Lotes")
            '    AdapterArticulos_Comprados.Update(DataSetCompras, "articulos_comprados")
            '    AdapterCompras.Update(DataSetCompras, "compras")

            '    Transaccion.Commit()
            '    MsgBox("Los datos se Eliminaron satisfactoriamente...", MsgBoxStyle.Information, "Atención...")
            '    DataSetCompras.articulos_comprados.Clear()
            '    DataSetCompras.Lotes.Clear()
            '    DataSetCompras.compras.Clear()
            '    DataSetCompras.detalle_ordencompra.Clear()
            '    ComboBoxProvedor.Text = ""
            '    TxtTotalFactura.Text = "0.00"
            '    ToolBar1.Buttons(2).Enabled = True
            '    txtClave.Text = ""
            '    TxtNombreUsuario.Text = ""
            '    txtClave.Focus()
            '    txtClave.Enabled = False
            '    GroupBox1.Enabled = False
            '    GroupBoxOpcionesCompras.Enabled = False
            '    GroupBoxDetalleArticulo.Enabled = False
            '    ComboMonedaCompra.Enabled = True
            '    Importando = False
            '    Finalizado_Importacion = False
            '    'ErrorProvider.Dispose()

            'Catch ex As Exception
            '    Transaccion.Rollback()
            '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Alerta...")
            'End Try
        End Sub

        Public Sub crearCompra(compra As Modelo.compras)
            '

            'Dim Transaccion As SqlTransaction
            'Try
            '    If SqlConnection.State <> SqlConnection.State.Open Then SqlConnection.Open()

            '    Transaccion = SqlConnection.BeginTransaction
            '    Calcular_Totales_Compras()
            '    BindingContext(DataSetCompras, "compras").EndCurrentEdit()

            '    AdapterCompras.UpdateCommand.Transaction = Transaccion
            '    AdapterCompras.InsertCommand.Transaction = Transaccion
            '    AdapterCompras.DeleteCommand.Transaction = Transaccion

            '    AdapterLotes.UpdateCommand.Transaction = Transaccion
            '    AdapterLotes.DeleteCommand.Transaction = Transaccion
            '    AdapterLotes.InsertCommand.Transaction = Transaccion

            '    AdapterArticulos_Comprados.UpdateCommand.Transaction = Transaccion
            '    AdapterArticulos_Comprados.DeleteCommand.Transaction = Transaccion
            '    AdapterArticulos_Comprados.InsertCommand.Transaction = Transaccion

            '    '-----------------------------------------------------------------------------------
            '    'Inicia Transacción....

            '    pbuscar = TxtFacturaCompraN.Text
            '    txtComboTipoF = ComboTipoF.Text

            '    AdapterCompras.Update(DataSetCompras.compras)
            '    'AdapterLotes.Update(DataSetCompras.Lotes)
            '    AdapterArticulos_Comprados.Update(DataSetCompras.articulos_comprados)
            '    '-----------------------------------------------------------------------------------
            '    Transaccion.Commit()

            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '    Dim IdCompra As String = BindingContext(DataSetCompras, "Compras").Current("Id_Compra")

            '    For Each r As Lote In Me.Lotes
            '        If r.Id > 0 Then
            '            'db.Ejecutar("", CommandType.Text)
            '        Else
            '            db.Ejecutar("Insert into ControlLotes(IdReferencia, Lote, Barras, Vence, Codigo, Cantidad, Actual) Values(" & IdCompra & ", '" & r.Lote & "', '" & r.Barras & "', '" & r.Vence & "', " & r.Codigo & ", " & r.Cantidad & ", " & r.Cantidad & ")", CommandType.Text)
            '            'db.Ejecutar("Update Inventario Set Barras = '" & r.Barras & "' Where Codigo = " & r.Codigo, CommandType.Text)
            '        End If
            '    Next

            '    Dim dtLotes As New DataTable
            '    Me.Lotes.Clear()
            '    cFunciones.Llenar_Tabla_Generico("Select c.Id, c.Lote, c.Vence, c.Codigo, i.Descripcion, CAST(i.PresentaCant as nvarchar) + ' ' + p.Presentaciones as Presentacion , c.Barras, c.Cantidad from ControlLotes c inner join Inventario i on c.Codigo = i.Codigo inner join Presentaciones p on i.CodPresentacion = p.CodPres Where c.IdReferencia = " & IdCompra, dtLotes, CadenaConexionSeePOS)
            '    For Each r As DataRow In dtLotes.Rows
            '        Me.Lotes.Add(New Lote(r.Item("Id"), r.Item("Lote"), r.Item("Vence"), r.Item("Codigo"), r.Item("Descripcion"), r.Item("Presentacion"), r.Item("Barras"), r.Item("Cantidad"), r.Item("Cantidad")))
            '    Next

            '    MsgBox("Los datos se actualiazaron satisfactoriamente...", MsgBoxStyle.Information, "Atención...")
            '    Return True
            'Catch ex As Exception
            '    Transaccion.Rollback()
            '    'If Err.Number = 5 Then
            '    '    MsgBox("Esta Factura ya existe!", MsgBoxStyle.Information)
            '    '    ToolBar1.Buttons(2).Enabled = True
            '    '    Return False
            '    '    Exit Try
            '    'End If
            '    MsgBox(ex.ToString, MsgBoxStyle.Information)
            '    ToolBar1.Buttons(2).Enabled = True
            '    Return False
            'End Try
        End Sub

        Public Sub editarCompra(compra As Modelo.compras)
            '

            'Dim Transaccion As SqlTransaction
            'Try
            '    If SqlConnection.State <> SqlConnection.State.Open Then SqlConnection.Open()

            '    Transaccion = SqlConnection.BeginTransaction
            '    Calcular_Totales_Compras()
            '    BindingContext(DataSetCompras, "compras").EndCurrentEdit()

            '    AdapterCompras.UpdateCommand.Transaction = Transaccion
            '    AdapterCompras.InsertCommand.Transaction = Transaccion
            '    AdapterCompras.DeleteCommand.Transaction = Transaccion

            '    AdapterLotes.UpdateCommand.Transaction = Transaccion
            '    AdapterLotes.DeleteCommand.Transaction = Transaccion
            '    AdapterLotes.InsertCommand.Transaction = Transaccion

            '    AdapterArticulos_Comprados.UpdateCommand.Transaction = Transaccion
            '    AdapterArticulos_Comprados.DeleteCommand.Transaction = Transaccion
            '    AdapterArticulos_Comprados.InsertCommand.Transaction = Transaccion

            '    '-----------------------------------------------------------------------------------
            '    'Inicia Transacción....

            '    pbuscar = TxtFacturaCompraN.Text
            '    txtComboTipoF = ComboTipoF.Text

            '    AdapterCompras.Update(DataSetCompras.compras)
            '    'AdapterLotes.Update(DataSetCompras.Lotes)
            '    AdapterArticulos_Comprados.Update(DataSetCompras.articulos_comprados)
            '    '-----------------------------------------------------------------------------------
            '    Transaccion.Commit()

            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '    Dim IdCompra As String = BindingContext(DataSetCompras, "Compras").Current("Id_Compra")

            '    For Each r As Lote In Me.Lotes
            '        If r.Id > 0 Then
            '            'db.Ejecutar("", CommandType.Text)
            '        Else
            '            db.Ejecutar("Insert into ControlLotes(IdReferencia, Lote, Barras, Vence, Codigo, Cantidad, Actual) Values(" & IdCompra & ", '" & r.Lote & "', '" & r.Barras & "', '" & r.Vence & "', " & r.Codigo & ", " & r.Cantidad & ", " & r.Cantidad & ")", CommandType.Text)
            '            'db.Ejecutar("Update Inventario Set Barras = '" & r.Barras & "' Where Codigo = " & r.Codigo, CommandType.Text)
            '        End If
            '    Next

            '    Dim dtLotes As New DataTable
            '    Me.Lotes.Clear()
            '    cFunciones.Llenar_Tabla_Generico("Select c.Id, c.Lote, c.Vence, c.Codigo, i.Descripcion, CAST(i.PresentaCant as nvarchar) + ' ' + p.Presentaciones as Presentacion , c.Barras, c.Cantidad from ControlLotes c inner join Inventario i on c.Codigo = i.Codigo inner join Presentaciones p on i.CodPresentacion = p.CodPres Where c.IdReferencia = " & IdCompra, dtLotes, CadenaConexionSeePOS)
            '    For Each r As DataRow In dtLotes.Rows
            '        Me.Lotes.Add(New Lote(r.Item("Id"), r.Item("Lote"), r.Item("Vence"), r.Item("Codigo"), r.Item("Descripcion"), r.Item("Presentacion"), r.Item("Barras"), r.Item("Cantidad"), r.Item("Cantidad")))
            '    Next

            '    MsgBox("Los datos se actualiazaron satisfactoriamente...", MsgBoxStyle.Information, "Atención...")
            '    Return True
            'Catch ex As Exception
            '    Transaccion.Rollback()
            '    'If Err.Number = 5 Then
            '    '    MsgBox("Esta Factura ya existe!", MsgBoxStyle.Information)
            '    '    ToolBar1.Buttons(2).Enabled = True
            '    '    Return False
            '    '    Exit Try
            '    'End If
            '    MsgBox(ex.ToString, MsgBoxStyle.Information)
            '    ToolBar1.Buttons(2).Enabled = True
            '    Return False
            'End Try
        End Sub

        Public Function buscarCompra(porNombre As Boolean, porFactura As Boolean, filtro As String) As List(Of Modelo.compras)
            '== a busargasto pero filtrando los gastos

            Dim compras As New List(Of Modelo.compras)
            'Dim Fx As New cFunciones

            'identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("Select Id_Compra, (convert(Varchar, convert(Bigint,Factura,0),1) + '-' + TipoCompra)as Factura,Proveedores.nombre,Fecha from compras inner join Proveedores on compras.CodigoProv = Proveedores.CodigoProv Order by Fecha DESC", "nombre", "Fecha", "Buscar Factura de Compra"))

            'buscando = True
            Return compras
        End Function


    End Class
End Namespace

