Namespace Logica
    Public Class Ajustesccobrar

        Public Property Ventas As New Logica.Ventas
        Public Property Clientes As New Logica.Clientes
        Public Property Moneda As New Logica.Monedas

        Public Sub crearAjustesccobrar(ajustesccobrar As Modelo.ajustesccobrar)

            'For i = 0 To BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Count - 1
            '    BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Position = i
            '    If BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Current("Saldo_Ajustado") = 0 Then
            '        FactTemp = BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Current("Factura")
            '        Funciones.UpdateRecords("Ventas", "FacturaCancelado = 1", "Num_Factura =" & FactTemp & "AND TIPO ='" & BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Current("Tipo") & "'")
            '    End If
            'Next

            'txtNum_Ajuste.Text = Numero_de_Ajuste()
            'BindingContext(AjusteCxC1, "ajustesccobrar").EndCurrentEdit()
            'daAjuste.Update(AjusteCxC1, "ajustesccobrar")
            'daDetalleAjuste.Update(AjusteCxC1, "detalle_ajustesccobrar")

        End Sub

        Public Function buscarAjustesccobrar(porNombre As Boolean,
                                             porNuAjuste As Boolean,
                                             filtro As String,
                                             entreFechas As Boolean,
                                             desde As Date,
                                             hasta As Date) As List(Of Modelo.ajustesccobrar)

            'identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("Select ID_Ajuste, AjusteNo, Nombre_Cliente, Fecha from ajustesccobrar Order by Fecha DESC", "Nombre_Cliente", "Fecha", "Buscar Ajuste de Cuenta"))
            'buscando = True
            'If identificador = 0.0 Then ' si se dio en el boton de cancelar
            '    buscando = False
            '    Exit Sub
            'End If

            'LlenarVentas(identificador)

        End Function

        Public Sub anularAjustesccobrar()
            'Function Registrar_Anulacion_Ajuste() As Boolean
            '    Dim i As Long
            '    Dim Facttem As Double
            '    Dim Funciones As New Conexion
            '    If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction
            '    Try
            '        SqlUpdateCommand1.Transaction = Trans
            '        daAjuste.Update(AjusteCxC1, "ajustesccobrar")
            '        For i = 0 To BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Count - 1
            '            BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Position = i
            '            Facttem = BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Current("Factura")
            '            Funciones.UpdateRecords("Ventas", "FacturaCancelado = 0", "Num_Factura =" & Facttem & "AND TIPO ='" & BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Current("Tipo") & "'")
            '        Next
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
