Namespace Logica
    Public Class Devoluciones_Compras

        '*******************OJO cuando marca como cancelada deshabilita el disparador de la tabla 
        'ALTER TABLE Articulos_Comprados DISABLE TRIGGER RegistrarKardexComprasIngreso_Update
        'ALTER TABLE Articulos_Comprados ENABLE TRIGGER RegistrarKardexComprasIngreso_Update

        Private db As Datos.Class.devoluciones_Compras

        Sub New()
            Me.db = New Datos.Class.devoluciones_Compras
        End Sub

        Public Function Crear(devolucionCompra As Datos.Models.DevolucionesCompra) As String
            Return Me.db.Crear(devolucionCompra)
            'Datos.Models.DevolucionesCompra
            'Datos.Models.DevolucionesCompra


            'If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open()
            'If (con.SlqExecute(SqlConnection1, "ALTER TABLE Articulos_Comprados DISABLE TRIGGER RegistrarKardexComprasIngreso_Update")) <> "" Then
            '    MsgBox("Error, intentelo de nuevo", MsgBoxStyle.Critical)
            '    Exit Sub
            'End If
            'Try
            '    '<<<<<<<<<<<<<    
            '    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Monto") = Math.Round(txtExentoT.EditValue + txtGravadoT.EditValue + Me.txtImpVentaT.EditValue, 2)
            '    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Impuesto") = Math.Round(Me.colMonto_Impuesto.SummaryItem.SummaryValue, 2)
            '    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Descuento") = Math.Round(Me.colMonto_Descuento.SummaryItem.SummaryValue, 2)
            '    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("SubTotalExcento") = Math.Round(Me.colSubTotalExcento.SummaryItem.SummaryValue, 2)
            '    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("SubTotalGravado") = Math.Round(Me.colSubtotalGravado.SummaryItem.SummaryValue, 2)
            '    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Nombrepro") = nProveedor
            '    Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Fecha") = dtFecha.Value
            '    '<<<<<<<<<<<<<<
            '    MsgBox("Le será devuelta la siguiente cantidad --> " & Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Monto").ToString & "<--", MsgBoxStyle.OkOnly, "SeePos")

            '    Me.ActualizaLote() 'Llama a la funcion para actualizar Lotes
            '    If RegistrarDevolucion() Then

            '           Me.Adapter_DevCompras.Update(Me.DataSet_DevCompras1, "devoluciones_Compras")
            '           Me.Adapter_Articulos_Compras_Dev.Update(Me.DataSet_DevCompras1, "articulos_Compras_devueltos")
            '           Me.AdapterLotes.Update(Me.DataSet_DevCompras1, "Lotes")

            '        NumDevo = Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").Current("Devolucion")
            '        Me.DataSet_DevCompras1.AcceptChanges()
            '        VolverEstadonormal()
            '        Limpiar()


            '        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '        db.Ejecutar("Update devoluciones_Compras Set NumeroProveedor = '" & NumeroProveedor & "' Where Devolucion = " & NumDevo, CommandType.Text)

            '        Me.ToolBar1.Buttons(0).Text = "Nuevo" ' cambio los iconos
            '        Me.ToolBar1.Buttons(0).ImageIndex = 0
            '        Me.ToolBar1.Buttons(0).Enabled = True
            '        Me.ToolBar1.Buttons(1).Enabled = True
            '        Me.ToolBar1.Buttons(2).Enabled = False
            '        Me.ToolBar1.Buttons(3).Enabled = False
            '        Me.ToolBar1.Buttons(4).Enabled = False
            '        Me.ToolBar1.Buttons(5).Enabled = True
            '        txtUsuario.Enabled = True
            '        ValidText1.Enabled = False
            '        Me.SimpleButton1.Enabled = False
            '        txtUsuario.Text = ""
            '        txtNombreUsuario.Text = ""
            '        ComboTipo.Text = ""
            '        TextNumero.Text = ""
            '        txtNombre.Text = ""
            '        TextMonto.Text = ""
            '        ComboMoneda.Text = ""

            '        REST2 = MsgBox("La actualización del sistema se ejecutó con éxito" & vbCrLf & "¿ Desea que se imprima el recibo de Devolución?", MsgBoxStyle.YesNo, "Seepos")
            '        If REST2 = 6 Then
            '            imprimir(NumDevo)
            '        End If
            '        con.SlqExecute(SqlConnection1, "ALTER TABLE Articulos_Comprados ENABLE TRIGGER RegistrarKardexComprasIngreso_Update")
            '        Me.SqlConnection1.Close()
            '    Else
            '        MsgBox("Problemas al ingresar Devolución de Compras", MsgBoxStyle.Critical)
            '    End If
            'Catch ex As Exception
            '    MsgBox(ex.ToString)
            '    con.SlqExecute(SqlConnection1, "ALTER TABLE Articulos_Comprados ENABLE TRIGGER RegistrarKardexComprasIngreso_Update")
            '    Me.SqlConnection1.Close()
            'End Try

        End Function

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.DevolucionesCompra)
            Return Me.db.Buscar(porNombre, Filtro)
            'identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("SELECT  Devolucion, NombrePro,Fecha FROM devoluciones_Compras Order by Fecha DESC", "NombrePro", "Fecha", "Buscar Devolución de Compra", Me.SqlConnection1.ConnectionString))

            'buscando = True
            'If identificador = 0.0 Then ' si se dio en el boton de cancelar
            '    Me.buscando = False
            '    Exit Sub
            'End If

        End Function

        Public Function Anular(Id As Long) As String

            Dim res As String = Me.db.Anular(Id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If

            '    Function Registrar_Anulacion() As Boolean
            '    Dim i As Long
            '    Dim Funciones As New Conexion
            '    If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            '    Try
            '        'Me.adPlanilla.InsertCommand.Transaction = Trans
            '        'Me.SqlUpdateCommand1.Transaction = Trans
            '        Adapter_DevCompras.UpdateCommand.Transaction = Trans
            '        'Me.adPlanilla.DeleteCommand.Transaction = Trans
            '        'Me.adPlanilla.SelectCommand.Transaction = Trans
            '        Me.BindingContext(Me.DataSet_DevCompras1, "devoluciones_Compras").EndCurrentEdit()
            '        'Me.Adapter_DevCompras.Update(Me.DataSet_DevCompras1, "devoluciones_Compras")

            '        Trans.Commit()
            '        Return True
            '    Catch ex As Exception
            '        Trans.Rollback()
            '        strAnulacion = "1"
            '        MsgBox(ex.Message)
            '        Return False
            '    End Try
            'End Function

        End Function

    End Class

End Namespace
