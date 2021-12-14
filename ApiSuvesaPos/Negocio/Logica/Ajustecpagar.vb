Namespace Logica
    Public Class Ajustecpagar

        '***************************************************************saldo
        Public Property Proveedor As New Logica.Proveedores
        Public Property Moneda As New Logica.Monedas

        Public Function Buscar(porNombreProveedor As Bodega,
                                           porNumeroAjuste As Boolean,
                                           porId As Boolean,
                                           filtro As String,
                                           porFecha As Boolean,
                                           desde As Date,
                                           hasta As Date) As List(Of Modelo.ajustescpagar)

            'identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("Select cast(ID_Ajuste as varchar) as Numero , Nombre_Proveedor, Fecha from ajustescpagar Order by Fecha DESC", "Nombre_Proveedor", "Fecha", "Buscar Ajuste de Cuenta", Me.SqlConnection1.ConnectionString))
            'buscando = True
            'If identificador = 0.0 Then ' si se dio en el boton de cancelar
            '    Me.buscando = False
            '    Exit Sub
            'End If

        End Function


        Public Sub Crear(ajustecpagar As Modelo.ajustescpagar)

            'Valida
            'If Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Count = 0 Then
            '    MsgBox("No se puede registrar un ajuste sin detalle", MsgBoxStyle.Critical)
            '    Me.ToolBar1.Buttons(2).Enabled = False
            '    Exit Function
            'End If


            'For i = 0 To Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Count - 1
            '    Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Position = i
            '    If Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Current("Saldo_Ajustado") = 0 Then
            '        FactTemp = Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Current("Factura")
            '        Proveedor = Me.BindingContext(DsAjustePagar, "Ajustescpagar").Current("Cod_Proveedor")
            '        Funciones.UpdateRecords("Compras", " FacturaCancelado = 1 ", " Factura =" & FactTemp & "AND TipoCompra ='CRE' and CodigoProv =" & Proveedor, "SeePos")
            '    End If
            'Next i
            'txtNum_Ajuste.Text = Numero_de_Ajuste()
            'Me.BindingContext(DsAjustePagar, "ajustescpagar").EndCurrentEdit()
            'Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").EndCurrentEdit()


            'Me.daAjustecPagar.InsertCommand.Transaction = Trans
            'Me.daAjustecPagar.UpdateCommand.Transaction = Trans
            'Me.daAjustecPagar.DeleteCommand.Transaction = Trans

            'Me.daDetallecPagar.InsertCommand.Transaction = Trans
            'Me.daDetallecPagar.UpdateCommand.Transaction = Trans
            'Me.daDetallecPagar.DeleteCommand.Transaction = Trans

            'Me.daAjustecPagar.Update(Me.DsAjustePagar, "Ajustescpagar")
            'Me.daDetallecPagar.Update(Me.DsAjustePagar, "Detalle_AjustescPagar")

        End Sub

        Public Sub Anular()


            '        Function Registrar_Anulacion_Ajuste() As Boolean
            '    Dim i As Long
            '    Dim Facttem As Double
            '    Dim Funciones As New Conexion
            '    If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            '    Try
            '        Me.daAjustecPagar.UpdateCommand.Transaction = Trans

            '        Me.daAjustecPagar.Update(Me.DsAjustePagar, "Ajustescpagar")
            '        For i = 0 To Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Count - 1
            '            Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Position = i
            '            Facttem = Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Current("Factura")
            '            Funciones.UpdateRecords("Compras", "FacturaCancelado = 0", "Factura =" & Facttem & "AND TIPOCOMPRA ='CRE'", strModulos)
            '        Next i
            '        Trans.Commit()
            '        Return True
            '    Catch ex As Exception
            '        Trans.Rollback()
            '        MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            '        Me.ToolBar1.Buttons(3).Enabled = True
            '        Return False
            '    End Try
            'End Function

        End Sub

    End Class

End Namespace
