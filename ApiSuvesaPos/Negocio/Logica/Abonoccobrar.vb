Namespace Logica
    Public Class Abonoccobrar

        'Public Property AperturaCaja As New Logica.AperturaCaja
        'Public Property Moneda As New Logica.Monedas
        'Public Property Clientes As New Logica.Clientes

        Private db As Datos.Class.AbonosCobros

        Sub New()
            Me.db = New Datos.Class.AbonosCobros
        End Sub

        Public Function Crear(abonoccobrar As Datos.Models.Abonoccobrar) As String

            'como se hacen las transacciones?

            Try

                For Each d As Datos.Models.DetalleAbonoccobrar In abonoccobrar.DetalleAbonoccobrars
                    '
                Next

                Me.db.CrearAbonoCobro(abonoccobrar)
            Catch ex As Exception

            End Try



            'BindingContext(DsRecibos1, "abonoccobrar").EndCurrentEdit()
            'BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").EndCurrentEdit()

            '''llamar al formulario de opciones de pago
            ''Dim Movimiento_Pago_Abonos As New frmMovimientoCajaPagoAbono(usua)
            ''Movimiento_Pago_Abonos.Factura = CDbl(txtNum_Recibo.Text)
            ''Movimiento_Pago_Abonos.fecha = "" & dtFecha.Text
            ''Movimiento_Pago_Abonos.Total = CDbl(txtAbonoGen.Text)
            ''Movimiento_Pago_Abonos.Tipo = "ABO"
            ''Movimiento_Pago_Abonos.codmod = ComboMoneda.SelectedValue
            ''Movimiento_Pago_Abonos.ShowDialog()

            ''If Movimiento_Pago_Abonos.Registra Then

            'For i = 0 To BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Count - 1
            '    BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Position = i
            '    If BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Saldo") = 0 Then
            '        FactTemp = BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Factura")
            '        If (Funciones.UpdateRecords("Ventas", "FacturaCancelado = 1", "Num_Factura =" & FactTemp & " and Tipo = '" & BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Tipo") & "'")) <> "" Then
            '            MsgBox("Problemas al Registrar las facturas como canceladas, reintente hacer el abono", MsgBoxStyle.Critical)
            '            Exit Sub
            '        End If
            '    End If
            'Next


            'Function registrar_Abono(Optional ByVal _ObligaCaja3 As Boolean = False) As Boolean

            '    If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
            '    Trans = SqlConnection1.BeginTransaction
            '    Try

            '        If Me.AplicaCambioenCaja = True Then
            '            If _ObligaCaja3 = True Then
            '                If adAbonos.InsertCommand.CommandText.IndexOf("PreAbonocCobrar") > 0 Then
            '                    adAbonos.InsertCommand.CommandText = adAbonos.InsertCommand.CommandText.Replace("PreAbonocCobrar", "abonoccobrar")
            '                    adAbonos.UpdateCommand.CommandText = adAbonos.InsertCommand.CommandText.Replace("PreAbonocCobrar", "abonoccobrar")
            '                    adAbonos.DeleteCommand.CommandText = adAbonos.InsertCommand.CommandText.Replace("PreAbonocCobrar", "abonoccobrar")

            '                    daDetalle_Abono.InsertCommand.CommandText = daDetalle_Abono.InsertCommand.CommandText.Replace("Detalle_PreAbonocCobrar", "detalle_abonoccobrar")
            '                    daDetalle_Abono.UpdateCommand.CommandText = daDetalle_Abono.InsertCommand.CommandText.Replace("Detalle_PreAbonocCobrar", "detalle_abonoccobrar")
            '                    daDetalle_Abono.DeleteCommand.CommandText = daDetalle_Abono.InsertCommand.CommandText.Replace("Detalle_PreAbonocCobrar", "detalle_abonoccobrar")
            '                End If
            '            Else
            '                If Not adAbonos.InsertCommand.CommandText.IndexOf("PreAbonocCobrar") > 0 Then
            '                    adAbonos.InsertCommand.CommandText = adAbonos.InsertCommand.CommandText.Replace("abonoccobrar", "PreAbonocCobrar")
            '                    adAbonos.UpdateCommand.CommandText = adAbonos.InsertCommand.CommandText.Replace("abonoccobrar", "PreAbonocCobrar")
            '                    adAbonos.DeleteCommand.CommandText = adAbonos.InsertCommand.CommandText.Replace("abonoccobrar", "PreAbonocCobrar")

            '                    daDetalle_Abono.InsertCommand.CommandText = daDetalle_Abono.InsertCommand.CommandText.Replace("detalle_abonoccobrar", "Detalle_PreAbonocCobrar")
            '                    daDetalle_Abono.UpdateCommand.CommandText = daDetalle_Abono.InsertCommand.CommandText.Replace("detalle_abonoccobrar", "Detalle_PreAbonocCobrar")
            '                    daDetalle_Abono.DeleteCommand.CommandText = daDetalle_Abono.InsertCommand.CommandText.Replace("detalle_abonoccobrar", "Detalle_PreAbonocCobrar")
            '                End If
            '            End If
            '        End If


            '        adAbonos.InsertCommand.Transaction = Trans
            '        adAbonos.DeleteCommand.Transaction = Trans
            '        adAbonos.UpdateCommand.Transaction = Trans

            '        daDetalle_Abono.InsertCommand.Transaction = Trans
            '        daDetalle_Abono.DeleteCommand.Transaction = Trans
            '        daDetalle_Abono.UpdateCommand.Transaction = Trans

            '        adAbonos.Update(DsRecibos1, "abonoccobrar")
            '        daDetalle_Abono.Update(DsRecibos1, "detalle_abonoccobrar")

            '        Trans.Commit()
            '        Return True
            '    Catch ex As Exception
            '        Trans.Rollback()
            '        MsgBox(ex.Message)
            '        ToolBar1.Buttons(2).Enabled = True
            '        Return False
            '    End Try
            'End Function


        End Function

        Public Function Buscar(porId As Boolean, Filtro As String) As List(Of Datos.Models.Abonoccobrar)
            Dim datos As New List(Of Datos.Models.Abonoccobrar)
            datos = db.ObtenerAbonocCobrar(porId, Filtro)

            Dim Resultado As New List(Of Datos.Models.Abonoccobrar)
            For Each abono As Datos.Models.Abonoccobrar In datos
                Dim abonoccobrar As New Datos.Models.Abonoccobrar
                abonoccobrar.IdRecibo = abono.IdRecibo
                abonoccobrar.NumRecibo = abono.NumRecibo
                abonoccobrar.CodCliente = abono.CodCliente
                abonoccobrar.NombreCliente = abono.NombreCliente
                abonoccobrar.SaldoCuenta = abono.SaldoCuenta
                abonoccobrar.Monto = abono.Monto
                abonoccobrar.SaldoActual = abono.SaldoActual
                abonoccobrar.Fecha = abono.Fecha
                abonoccobrar.Observaciones = abono.Observaciones
                abonoccobrar.Anula = abono.Anula
                abonoccobrar.CedUsuario = abono.CedUsuario
                abonoccobrar.Contabilizado = abono.Contabilizado
                abonoccobrar.Asiento = abono.Asiento
                abonoccobrar.CodMoneda = abono.CodMoneda
                abonoccobrar.Cheque = abono.Cheque
                abonoccobrar.NumCaja = abono.NumCaja
                abonoccobrar.Banco = abono.Banco
                abonoccobrar.NumApertura = abono.NumApertura
                abonoccobrar.EstadoEnvio = abono.EstadoEnvio
                abonoccobrar.IdSucursal = abono.IdSucursal


                For Each detalle As Datos.Models.DetalleAbonoccobrar In Me.db.ObtenerDetalleAbonoscCobrar(abono.IdRecibo)
                    Dim DetalleAbonoccobrar As New Datos.Models.DetalleAbonoccobrar
                    DetalleAbonoccobrar.Consecutivo = detalle.Consecutivo
                    DetalleAbonoccobrar.IdRecibo = detalle.IdRecibo
                    DetalleAbonoccobrar.Factura = detalle.Factura
                    DetalleAbonoccobrar.Tipo = detalle.Tipo
                    DetalleAbonoccobrar.Fecha = detalle.Fecha
                    DetalleAbonoccobrar.Monto = detalle.Monto
                    DetalleAbonoccobrar.SaldoAnt = detalle.SaldoAnt
                    DetalleAbonoccobrar.Intereses = detalle.Intereses
                    DetalleAbonoccobrar.Abono = detalle.Abono
                    DetalleAbonoccobrar.AbonoSuMoneda = detalle.AbonoSuMoneda
                    DetalleAbonoccobrar.Saldo = detalle.Saldo
                    abonoccobrar.DetalleAbonoccobrars.Add(DetalleAbonoccobrar)
                Next

                Resultado.Add(abonoccobrar)
            Next

            Return Resultado
        End Function

        Public Function Anular(Id As Long) As String
            Dim res As String = Me.db.Anular(Id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If



            '    Function Registrar_Anulacion_Venta() As Boolean
            '    Dim i As Long
            '    Dim Facttem As Double
            '    Dim Funciones As New Conexion
            '    If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction
            '    Try
            '        SqlUpdateCommand1.Transaction = Trans
            '        adAbonos.Update(DsRecibos1, "abonoccobrar")
            '        For i = 0 To BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Count - 1
            '            BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Position = i
            '            Facttem = BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Factura")
            '            Funciones.UpdateRecords("Ventas", "FacturaCancelado = 0", "Num_Factura =" & Facttem & "and Tipo = '" & BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Tipo") & "'")
            '        Next
            '        Funciones.UpdateRecords("OpcionesDePago", "FormaPago = 'ANU'", "(Documento = " & txtNum_Recibo.Text & ") AND (TipoDocumento = 'ABO')")
            '        Trans.Commit()
            '        Return True

            '    Catch ex As Exception
            '        Trans.Rollback()
            '        MsgBox(ex.Message)
            '        ToolBar1.Buttons(3).Enabled = True
            '        Return False
            '    End Try
            'End Function
        End Function

    End Class

End Namespace
