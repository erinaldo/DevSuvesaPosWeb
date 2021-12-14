Namespace Logica
    Public Class Devoluciones_Ventas

        Public Property Ventas As New Logica.Ventas
        Public Property AperturaCaja As New Logica.AperturaCaja
        'cargar la cls de opcionedepago
        Public Property Moneda As New Logica.Monedas
        Public Property Inventario As New Logica.Inventario 'para verificar si tiene consigancion

        Public Function Buscar() As List(Of Modelo.devoluciones_ventas)
            'identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("SELECT  dbo.devoluciones_ventas.Devolucion, dbo.Ventas.Nombre_Cliente, dbo.devoluciones_ventas.Fecha FROM dbo.devoluciones_ventas INNER JOIN dbo.Ventas ON dbo.devoluciones_ventas.Id_Factura = dbo.Ventas.Id Order by dbo.devoluciones_ventas.Fecha DESC", "Nombre_Cliente", "Fecha", "Buscar Devolución de Venta"))
            'buscando = True
            'If identificador = 0.0 Then ' si se dio en el boton de cancelar
            '    Me.buscando = False
            '    Exit Sub
            'End If

            'Me.LlenarVentas(identificador)
            'Me.llenarVentasOpcionesdePago(Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Id_Factura"))
        End Function

        Public Sub Anular()

            '    Function Anular_Detalle(ByVal Id As Long) As Boolean
            '    '--------------------------------------------------------------------------------------------
            '    ' SE DISPARA DESENCADENADOR QUE REGISTRA EN EL KARDEX LA ANULACION DE LA DEVOLUCION         ' 
            '    ' SE PROCEDE A RECORRER Y ACTUALIZAR LA EXISTENCIA DE INVENTARIO Y A REVERTIR EL CONTADOR   '
            '    ' DE DEVOLUCIONES DE LA TABLA DE VENTAS_DETALLE.                                            '
            '    ' JSA : 31102006 2350                                                                       '
            '    '--------------------------------------------------------------------------------------------
            '    Try
            '        Dim i As Integer
            '        Dim Funciones As New Conexion
            '        For i = 0 To Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Count - 1
            '            Funciones.UpdateRecords("Ventas_Detalle", "Devoluciones = Devoluciones -" & Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Rows(i).Item("Cantidad"), "Id_Factura =" & Id & " AND id_venta_detalle =" & Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Rows(i).Item("id_art_venta"))
            '            '**************************************************************
            '            'JCGA 02 DE AGOSTO 2007, PARA ACTUALIZAR LOS DATOS EN EL INVENTARIO SE ESTABA TOMANDO A LA VARIABLE ID 
            '            'EN VEZ DEL CODIGO DEL ARTICULO.
            '            'dim CodigoArticulo as Long = Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Rows(i).Item("Codigo")
            '            'Funciones.UpdateRecords("Inventario", "Existencia = Existencia -" & Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Rows(i).Item("Cantidad"), "Codigo =" & CodigoArticulo)
            '            '**************************************************************
            '        Next
            '        Return True

            '    Catch ex As SystemException
            '        MsgBox(ex.Message)
            '        Return False
            '    End Try
            'End Function

            'Function Registrar_Anulacion_Devolucion() As Boolean
            '    Try
            '        Dim Funciones As New Conexion
            '        'Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Anulado") = True
            '        'Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").EndCurrentEdit()
            '        'Me.AdapterDevoluciones.Update(Me.DataSetDevolucionVentas1, "devoluciones_ventas")
            '        Funciones.UpdateRecords("devoluciones_ventas", "Anulado = 1", "Devolucion =" & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))

            '        Return True
            '    Catch ex As SystemException
            '        MsgBox(ex.Message)
            '        Me.ToolBar1.Buttons(3).Enabled = True
            '        Return False
            '    End Try
            'End Function

        End Sub

        Public Sub Crear(devoluciones_ventas As Modelo.devoluciones_ventas)

            'If CadenaConexionSeePOS.ToLower.IndexOf("taller") > 0 Then
            '    Me.AdapterOpcionesPago.InsertCommand.CommandText = Me.AdapterOpcionesPago.InsertCommand.CommandText.Replace("OpcionesDePago", "SeePOs.dbo.OpcionesDePago")
            'End If

            'Dim REST As Integer
            'Dim REST2 As Integer
            'Dim NumDevo As Long
            'Dim MontoDevoluciones As Double
            'Me.ToolBarEliminar.Enabled = False
            'Me.MontoDevolucion = Math.Round(CDbl(Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto").ToString), 2)
            'If Me.PasaFirmadoContado(Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Id"), MontoDevolucion) = False Then
            '    Exit Sub
            'End If
            'If Me.MontoDevolucion > 0 Then
            '    Me.esFirmadoContado = False
            'Else
            '    Me.esFirmadoContado = True
            'End If

            ''**********SI HAY ARTICULOS DEVUELTOS***********
            'If Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Count = 0 And TextEdit7.EditValue = 0 Then
            '    MsgBox("Es necesario que almenos exista un item en el area de detalle " & vbCrLf & "para efectuar el registro de la devolución o un monto por concepto de Transporte..")
            '    Exit Sub
            'ElseIf Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Count = 0 And TextEdit7.EditValue <> 0 Then
            '    If MsgBox("Desea proceder a registrar esta devolución sin haber definido detalle y solo por el monto de Transporte ...?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            'End If

            'NumDevo = txtNum_Devo.Text
            ''*****************SI LA VENTA ES DE CREDITO**************
            'If Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Tipo") = "CRE" Or Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Tipo") = "TCR" Or Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Tipo") = "MCR" Then
            '    Dim SaldoFacturaT As Double
            '    Dim codcliente As Double = Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("cod_cliente")
            '    Dim cConexion As New Conexion
            '    SaldoFacturaT = cConexion.SlqExecuteScalar(cConexion.Conectar, "SELECT dbo.SaldoFactura_Monto(GETDATE()," & TextNumero.Text & ",'" & ComboTipo.Text & "', " & codcliente & ", " & Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Total") & ") AS Saldo")

            '    Dim saldo As Decimal = SaldoFacturaT - Math.Round(CDbl(Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto").ToString), 2)
            '    If saldo < 0 Then
            '        Me.MontoDevolucion = (saldo * -1)

            '        Dim frm As New frmOpcionCaja
            '        frm.ShowDialog()
            '        Me.Caja_Factura = frm.Caja
            '        '*****************************************SELECCIONA CAJA **********************************************************
            '        If CajaAbierta(Caja_Factura) = False Then
            '            MsgBox("La caja #" & Caja_Factura & " no esta abierta, no sepuede realizar la operacion!!!", MsgBoxStyle.Exclamation, Text)
            '            Exit Sub
            '        End If

            '    Else
            '        Me.MontoDevolucion = 0
            '    End If

            '    cConexion.DesConectar(cConexion.sQlconexion)
            '    If (BindingContext(DataSetDevolucionVentas1, "Ventas").Current("Tipo") = "CRE" Or BindingContext(DataSetDevolucionVentas1, "Ventas").Current("Tipo") = "TCR") And SaldoFacturaT = 0 Then
            '        MontoDevoluciones = cConexion.SlqExecuteScalar(cConexion.Conectar, "SELECT isnull(SUM(Monto),0) as TotalMonto FROM Devoluciones_Ventas WHERE Id_Factura =" & Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Id") & " AND Anulado = 0")
            '        cConexion.DesConectar(cConexion.sQlconexion)
            '    End If
            '    If Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto") = SaldoFacturaT Then
            '        Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("FacturaCancelado") = True
            '        Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").EndCurrentEdit()
            '    End If
            '    '******************SI LA VENTA NO ES DE CREDITO**************
            'Else
            '    MontoDevoluciones = CConexion.SlqExecuteScalar(CConexion.Conectar, "SELECT ISNULL(SUM(Monto), 0) as TotalMonto FROM Devoluciones_Ventas WHERE Id_Factura =" & Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Id") & " AND Anulado = 0")

            '    If Math.Round(Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Total") - Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto") - MontoDevoluciones, 2) = 0 Then
            '        Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("FacturaCancelado") = True
            '        Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").EndCurrentEdit()
            '    End If
            'End If

            ''******************** SI LA FACTURA ES DE CONTADO O ES DE CREDITO PERO YA SE PAGO ********************
            'If (ComboTipo.Text <> "CRE" And ComboTipo.Text <> "TCR") Or ((ComboTipo.Text = "CRE" Or ComboTipo.Text = "TCR") And CheckBox2.Checked = True) Then
            '    Try
            '        Dim frm As New frmOpcionCaja
            '        frm.ShowDialog()
            '        Me.Caja_Factura = frm.Caja
            '        '*****************************************SELECCIONA CAJA **********************************************************
            '        If CajaAbierta(Caja_Factura) = False Then
            '            MsgBox("La caja #" & Caja_Factura & " no esta abierta, no sepuede realizar la operacion!!!", MsgBoxStyle.Exclamation, Text)
            '            Exit Sub
            '        End If

            '        REST = MsgBox("Deseas devolver la siguiente cantidad --> " & Math.Round(CDbl(Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto").ToString), 2) & " <--", MsgBoxStyle.YesNo, "SeePos")
            '        '**************************************************************************************************************************
            '        If REST = 6 Then

            '            For i As Integer = 0 To Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Count - 1
            '                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Position = i
            '                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Devolucion") = NumDevo
            '            Next
            '            Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").EndCurrentEdit()

            '            'validar que existan articulos por devolver
            '            If Me.TieneSaldo() = False Then
            '                MsgBox("Articulo ya fue devuelto.", MsgBoxStyle.Exclamation, "No se puede realizar la operacion")
            '                Exit Sub
            '            End If
            '            Me.AdapterDevoluciones.Update(Me.DataSetDevolucionVentas1.devoluciones_ventas)

            '            NumDevo = Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion")
            '            '================================================================================
            '            'ARTICULOS VENTAS DEVUELTOS
            '            Me.AdapterDetalleDevolucion.Update(Me.DataSetDevolucionVentas1.articulos_ventas_devueltos)
            '            '================================================================================

            '            Try
            '                '================================================================
            '                'VENTAS
            '                'AdapterVentas.Update(Me.DataSetDevolucionVentas1.Ventas)
            '                '================================================================

            '                '================================================================
            '                'VENTAS DETALLE
            '                AdapterDetalleVentas.Update(Me.DataSetDevolucionVentas1.Ventas_Detalle)
            '                '================================================================
            '            Catch ex As Exception

            '            End Try

            '            If Me.esFirmadoContado = False Then
            '                Me.InsertarOpicion_Pago()
            '            End If

            '            Me.AdapterOpcionesPago.Update(Me.DataSetDevolucionVentas1.OpcionesDePago)
            '            Me.DataSetDevolucionVentas1.AcceptChanges()

            '            Dim dbo As New GestioDatos
            '            If Me.esFirmadoContado = False Then
            '                dbo.Ejecuta("Update devoluciones_ventas set UsuarioRecibio = '" & Me.UsuarioRecibo & "', Caja = " & Me.Caja_Factura & ", Num_Apertura = " & Num_Apertura & " where Devolucion = " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))
            '            End If
            '            dbo.Ejecuta("Update devoluciones_ventas Set NotasDevolucion = '" & Me.NotasDevolucion & "', UsuarioRecibio = '" & Me.UsuarioRecibo & "', MontoDevolucion = " & Me.MontoDevolucion & " where Devolucion = " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))

            '            VolverEstadonormal()
            '            Limpiar()
            '            Me.ToolBarRegistrar.Enabled = False
            '            Me.ToolBarNuevo.Enabled = False
            '            Me.ToolBarBuscar.Enabled = False

            '            Me.ToolBarEliminar.Enabled = False
            '            Me.ToolBarImprimir.Enabled = False
            '            Me.ToolBar1.Buttons(0).Text = "Nuevo" ' cambio los iconos
            '            Me.ToolBar1.Buttons(0).ImageIndex = 0

            '            Me.txtUsuario.Enabled = True
            '            Me.txtUsuario.Focus()

            '            REST2 = MsgBox("La actualización del sistema se ejecutó con éxito" & vbCrLf & "¿ Desea que se imprima el recibo de Devolución?", MsgBoxStyle.YesNo, "Seepos")
            '            If REST2 = 6 Then
            '                imprimir(NumDevo)
            '            End If
            '            Exit Sub
            '        Else
            '            Exit Sub
            '        End If
            '        Me.ToolBarEliminar.Enabled = True

            '    Catch ex As Exception
            '        MsgBox(ex.ToString)
            '    End Try
            'End If

            ''SI LA FACTURA ES DE CREDITO 
            'If (ComboTipo.Text = "CRE" Or ComboTipo.Text = "TCR") And CheckBox2.Checked = False Then
            '    Try
            '        REST = MsgBox("Deseas devolver la siguiente cantidad --> " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto").ToString & "<--", MsgBoxStyle.YesNo, "SeePos")
            '        If REST = 6 Then

            '            Me.AdapterDevoluciones.Update(Me.DataSetDevolucionVentas1.devoluciones_ventas)
            '            NumDevo = Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion")
            '            AdapterDetalleDevolucion.Update(Me.DataSetDevolucionVentas1.articulos_ventas_devueltos)
            '            AdapterVentas.Update(Me.DataSetDevolucionVentas1.Ventas)
            '            AdapterDetalleVentas.Update(Me.DataSetDevolucionVentas1.Ventas_Detalle)

            '            Dim dbo As New GestioDatos
            '            If Me.MontoDevolucion > 0 Then
            '                Me.InsertarOpicion_Pago()
            '                dbo.Ejecuta("Update devoluciones_ventas set Caja = " & IIf(Me.Caja_Factura = 0, 1, Me.Caja_Factura) & ", Num_Apertura = " & Num_Apertura & " where Devolucion = " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))
            '                dbo.Ejecuta("Update devoluciones_ventas Set MontoDevolucion = " & Me.MontoDevolucion & " where Devolucion = " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))
            '            End If

            '            dbo.Ejecuta("Update devoluciones_ventas Set NotasDevolucion = '" & Me.NotasDevolucion & "', UsuarioRecibio = '" & Me.UsuarioRecibo & "' where Devolucion = " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))

            '            Me.AdapterOpcionesPago.Update(Me.DataSetDevolucionVentas1.OpcionesDePago)
            '            Me.DataSetDevolucionVentas1.AcceptChanges()

            '            VolverEstadonormal()
            '            Limpiar()
            '            Me.ToolBarRegistrar.Enabled = False
            '            Me.ToolBarNuevo.Enabled = True
            '            Me.ToolBarBuscar.Enabled = True
            '            Me.ToolBarEliminar.Enabled = False
            '            Me.ToolBarImprimir.Enabled = False
            '            Me.ToolBar1.Buttons(0).Text = "Nuevo" ' cambio los iconos
            '            Me.ToolBar1.Buttons(0).ImageIndex = 0
            '            REST2 = MsgBox("La actualización del sistema se ejecutó con éxito" & vbCrLf & "¿ Desea que se imprima el recibo de Devolución?", MsgBoxStyle.YesNo, "Seepos")
            '            If REST2 = 6 Then
            '                imprimir(NumDevo)
            '            End If
            '        End If
            '    Catch ex As Exception
            '        MsgBox(ex.ToString)
            '    End Try
            'End If
            ''        Else
            ''        MsgBox("Es necesario que almenos exista un item en el area de detalle para efctuar el registro de la devolución")
            ''       End If


        End Sub

    End Class
End Namespace

