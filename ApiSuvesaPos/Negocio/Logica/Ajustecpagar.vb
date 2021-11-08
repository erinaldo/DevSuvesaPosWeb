Namespace Logica
    Public Class Ajustecpagar

        '***************************************************************saldo
        Public Property Proveedor As New Logica.Proveedores
        Public Property Moneda As New Logica.Monedas

        Public Function buscarAjustecpagar(porNombreProveedor As Bodega,
                                           porNumeroAjuste As Boolean,
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

        Public Function cargarAjustecpagar(id_AjustecPagar As String) As Modelo.ajustescpagar


            'Dim cnnv As SqlConnection = Nothing
            'Dim dt As New DataTable
            'Dim cConexion As New Conexion
            'Dim IdRec As Long
            ''Dentro de un Try/Catch por si se produce un error
            'Try
            '    Dim Fx As New cFunciones
            '    Fx.Llenar_Tabla_Generico("SELECT * FROM ajustescpagar WHERE ID_Ajuste = " & Id, Me.DsAjustePagar.Ajustescpagar, SqlConnection1.ConnectionString)
            '    Fx.Llenar_Tabla_Generico("SELECT * FROM detalle_ajustescpagar WHERE Id_AjustecPagar = " & Id, Me.DsAjustePagar.Detalle_AjustescPagar, SqlConnection1.ConnectionString)


            'Catch ex As System.Exception
            '    ' Si hay error, devolvemos un valor nulo.
            '    MsgBox(ex.ToString)
            'Finally
            '    ' Por si se produce un error,
            '    ' comprobamos si en realidad el objeto Connection está iniciado,
            '    ' de ser así, lo cerramos.
            '    If Not cnnv Is Nothing Then
            '        cnnv.Close()
            '    End If
            'End Try

        End Function

        Public Sub crearAjustecPagar(ajustecpagar As Modelo.ajustescpagar)

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

        Public Sub anularAjustecpagar()


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
