Namespace Logica
    Public Class Ajustesccobrar

        'Public Property Ventas As New Logica.Ventas
        'Public Property Clientes As New Logica.Clientes
        'Public Property Moneda As New Logica.Monedas

        Private db As Datos.Class.AjustesCobrar

        Sub New()
            Me.db = New Datos.Class.AjustesCobrar
        End Sub

        Public Function Crear(ajustesccobrar As Datos.Models.Ajustesccobrar) As String

            Try

                For Each d As Datos.Models.DetalleAjustesccobrar In ajustesccobrar.DetalleAjustesccobrars

                Next

                Return Me.db.CrearAjusteCobro(ajustesccobrar)

            Catch ex As Exception

            End Try

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

        End Function

        Public Function Buscar(porId As Boolean, filtro As String) As List(Of Datos.Models.Ajustesccobrar)

            Return Me.db.ObtenerAjusteCobro(porId, filtro)

            'identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("Select ID_Ajuste, AjusteNo, Nombre_Cliente, Fecha from ajustesccobrar Order by Fecha DESC", "Nombre_Cliente", "Fecha", "Buscar Ajuste de Cuenta"))
            'buscando = True
            'If identificador = 0.0 Then ' si se dio en el boton de cancelar
            '    buscando = False
            '    Exit Sub
            'End If

            'LlenarVentas(identificador)

        End Function

        Public Sub Anular()
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
