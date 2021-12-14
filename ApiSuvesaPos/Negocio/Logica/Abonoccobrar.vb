Namespace Logica
    Public Class Abonoccobrar

        Public Property AperturaCaja As New Logica.AperturaCaja
        Public Property Moneda As New Logica.Monedas
        Public Property Clientes As New Logica.Clientes

        Public Sub Crear(abonoccobrar As Modelo.abonoccobrar)

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


        End Sub

        Public Function Buscar() As List(Of Modelo.abonoccobrar)

            'identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha5C("SELECT abonoccobrar.Id_Recibo, abonoccobrar.Num_Recibo as Recibo , abonoccobrar.Nombre_Cliente AS Nombre_Cliente, abonoccobrar.Fecha,  abonoccobrar.Monto FROM abonoccobrar INNER JOIN  Moneda ON abonoccobrar.Cod_Moneda = Moneda.CodMoneda ORDER BY abonoccobrar.Fecha DESC", "Nombre_Cliente", "Fecha", "Buscar Recibo de Dinero"))
            'buscando = True
            'If identificador = 0.0 Then ' si se dio en el boton de cancelar
            '    buscando = False
            '    Exit Sub
            'End If

        End Function

        Public Sub Anular()
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
        End Sub

    End Class

End Namespace
