Namespace Logica
    Public Class Abonocpagar

        '************************************************ saldo

        '************************
        'carga info del usuario y permisos
        Public Property Moneda As Logica.Monedas
        Public Property Bancos As Logica.Bancos

        Public Sub crearAbonocpagar(abonocpagar As Modelo.abonocpagar)

            '********************
            'validacion
            'Private Function VerificaRecibo() As Boolean
            '    Dim Cx As New Conexion
            '    Dim id As String
            '    Try
            '        id = Cx.SlqExecuteScalar(Cx.Conectar(), "SELECT Id_Abonocpagar FROM Abonocpagar WHERE Cod_Proveedor = " & txtCodigo.Text & " AND Recibo = '" & txtNum_Recibo.Text & "'")
            '        If id Is Nothing Then
            '            Return True
            '        Else
            '            MsgBox("El número de recibo ya existe para el proveedor!", MsgBoxStyle.Critical, "LcPymes")
            '            Return False
            '        End If
            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        Return False
            '    Finally
            '        Cx.DesConectar(Cx.sQlconexion)
            '    End Try
            'End Function




            'If VerificaRecibo() = False Then
            '    Exit Function
            'End If

            'BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").CancelCurrentEdit()
            'documento = Me.TextBox1.Text
            'num_cuenta = Me.ComboBoxCuentaBancaria.SelectedValue
            'numero = cx.SlqExecuteScalar(cx.Conectar("Bancos"), "Select Num_Cheque, Id_CuentaBancaria FROM Cheques where Num_Cheque = " & documento & " AND Id_CuentaBancaria=" & num_cuenta & " and tipo = '" & Me.ComboBoxTipoPago.Text & "'")

            'If numero Then
            '    MsgBox("El Número de Cheque ya esta ingresado, favor revisar", MsgBoxStyle.Information, "Atención ...")
            '    Exit Function
            'End If

            'If VerificarExistenciaDocumento(Me.TextBox1.Text, Me.ComboBoxTipoPago.Text, Me.ComboBoxCuentaBancaria.Text) = True Then
            '    MsgBox("No se puede registrar este abono por que ya ha sigo registrado.", MsgBoxStyle.Information, "Atención..")
            '    Exit Function
            'End If

            'Dim trans As OBSoluciones.SQL.Transaccion
            'Dim Id_AbonocPagar As Long = 0
            'Dim strSQL As String = ""
            'Try
            '    Id_AbonocPagar = 0
            '    trans = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)

            '    For i = 0 To Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Count - 1
            '        Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Position = i
            '        If Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Saldo_Actual") = 0 Then
            '            FactTemp = Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Factura")
            '            strSQL = "Update Compras set FacturaCancelado = 1 Where Factura =" & FactTemp & " and TipoCompra = 'CRE' and codigoProv = " & Me.txtCodigo.Text & ""
            '            trans.Ejecutar(strSQL, CommandType.Text)
            '        End If
            '    Next i

            '    Me.BindingContext(DataSetAbonosProveedor, "abonocpagar").EndCurrentEdit()
            '    Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("CuentaBancaria") = Me.ComboBoxCuentaBancaria.Text
            '    Tipo = Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("TipoDocumento")
            '    Me.BindingContext(DataSetAbonosProveedor, "abonocpagar").EndCurrentEdit()
            '    Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").EndCurrentEdit()

            '    strSQL = "INSERT INTO [dbo].[abonocpagar] ([Documento],[TipoDocumento],[CuentaBancaria],[Codigo_banco],[Saldo_Cuenta],[Monto],[Saldo_Actual],[Fecha],[Contabilizado],[Recibo],[Cedula_Usuario],[Cod_Proveedor],[Anulado],[cod_Moneda],[TipoCambio],[MontoLetras],[CuentaDestino],[FechaEntrada],[Observaciones]) "
            '    strSQL += "VALUES (@Documento,@TipoDocumento,@CuentaBancaria,@Codigo_banco,@Saldo_Cuenta,@Monto,@Saldo_Actual,@Fecha,@Contabilizado,@Recibo,@Cedula_Usuario,@Cod_Proveedor,@Anulado,@cod_Moneda,@TipoCambio,@MontoLetras,@CuentaDestino,@FechaEntrada,@Observaciones)"

            '    trans.AddParametrosSalidaInt("@Id_Abonocpagar", Id_AbonocPagar)
            '    trans.SetParametro("@Documento", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Documento"))
            '    trans.SetParametro("@TipoDocumento", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("TipoDocumento"))
            '    trans.SetParametro("@CuentaBancaria", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("CuentaBancaria"))
            '    trans.SetParametro("@Codigo_banco", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Codigo_banco"))
            '    trans.SetParametro("@Saldo_Cuenta", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Saldo_Cuenta"))
            '    trans.SetParametro("@Monto", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Monto"))
            '    trans.SetParametro("@Saldo_Actual", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Saldo_Actual"))
            '    trans.SetParametro("@Fecha", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Fecha"))
            '    trans.SetParametro("@Contabilizado", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Contabilizado"))
            '    trans.SetParametro("@Recibo", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Recibo"))
            '    trans.SetParametro("@Cedula_Usuario", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Cedula_Usuario"))
            '    trans.SetParametro("@Cod_Proveedor", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Cod_Proveedor"))
            '    trans.SetParametro("@Anulado", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Anulado"))
            '    trans.SetParametro("@cod_Moneda", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("cod_Moneda"))
            '    trans.SetParametro("@TipoCambio", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("TipoCambio"))
            '    trans.SetParametro("@MontoLetras", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("MontoLetras"))
            '    trans.SetParametro("@CuentaDestino", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("CuentaDestino"))
            '    trans.SetParametro("@FechaEntrada", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("FechaEntrada"))
            '    trans.SetParametro("@Observaciones", Me.BindingContext(Me.DataSetAbonosProveedor, "abonocpagar").Current("Observaciones"))
            '    trans.Ejecutar("guardar_abonocpagar", CommandType.StoredProcedure, 0, Id_AbonocPagar)

            '    For index As Integer = 0 To Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Count - 1
            '        Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Position = index
            '        strSQL = "INSERT INTO detalle_abonocpagar (Factura, Cod_Proveedor, MontoFactura, Saldo_Ant, Abono, Abono_SuMoneda, Saldo_Actual, Id_Abonocpagar, Id_Compra) "
            '        strSQL += " VALUES (@Factura, @Cod_Proveedor, @MontoFactura, @Saldo_Ant, @Abono, @Abono_SuMoneda, @Saldo_Actual, @Id_Abonocpagar, @Id_Compra)"
            '        trans.SetParametro("@Factura", Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Factura"))
            '        trans.SetParametro("@Cod_Proveedor", Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Cod_Proveedor"))
            '        trans.SetParametro("@MontoFactura", Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("MontoFactura"))
            '        trans.SetParametro("@Saldo_Ant", Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Saldo_Actual"))
            '        trans.SetParametro("@Abono", Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Abono"))
            '        trans.SetParametro("@Abono_SuMoneda", Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Abono_SuMoneda"))
            '        trans.SetParametro("@Saldo_Actual", Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Saldo_Actual"))
            '        trans.SetParametro("@Id_Abonocpagar", Id_AbonocPagar)
            '        trans.SetParametro("@Id_Compra", Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Id_Compra"))
            '        trans.Ejecutar(strSQL, CommandType.Text)
            '    Next

            '    trans.Commit()

            '    Me.DataSetAbonosProveedor.abonocpagar.AcceptChanges()
            '    Me.DataSetAbonosProveedor.detalle_abonocpagar.Clear()
            '    Me.DataSetAbonosProveedor.abonocpagar.Clear()

            '    Me.ToolBar1.Buttons(1).Enabled = True

            '    Me.ToolBar1.Buttons(0).Text = "Nuevo"
            '    Me.ToolBar1.Buttons(0).ImageIndex = 0

            '    MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
            '    Dim ConexionProve As String
            '    ConexionProve = CadenaConexionSeePOS()
            '    Dim abono As New Abonos_Proveedor(usua, ConexionProve)
            '    abono.MdiParent = Me.MdiParent
            '    abono.Show()
            '    Me.Close()
            '    If Tipo = "CHEQUE" Then
            '        If MessageBox.Show("¿Desea imprimir el cheque?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            '            numero = cx.SlqExecuteScalar(cx.Conectar("Bancos"), "Select Id_Cheque FROM Cheques where Num_Cheque = " & documento & " AND Id_CuentaBancaria=" & num_cuenta)
            '            imprimir(Id_AbonocPagar)
            '        End If
            '    End If
            'Catch ex As Exception
            '    trans.Rollback()
            '    MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
            'End Try
        End Sub

        Public Function buscarAbonocpagar(porProveedor As Boolean,
                                          porCheque As Boolean,
                                          filtro As String,
                                          porFecha As Boolean,
                                          desde As Date,
                                          hasta As Date) As List(Of Modelo.abonocpagar)
            'identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("SELECT abonocpagar.Id_Abonocpagar AS Consecutivo, cast(abonocpagar.Recibo as varchar) as Recibo, ISNULL(Proveedores.Nombre, 'Proveedor Eliminado') AS Proveedor, abonocpagar.Fecha, cast(abonocpagar.Documento as varchar ) as Cheque FROM abonocpagar LEFT OUTER JOIN Proveedores ON abonocpagar.Cod_Proveedor = Proveedores.CodigoProv ORDER BY abonocpagar.Fecha DESC", "Proveedor", "Fecha", "Buscar Pagos a Proveedor", SqlConnection1.ConnectionString))
            'buscando = True
            'If identificador = 0.0 Then ' si se dio en el boton de cancelar
            '    Me.buscando = False
            '    Exit Sub
            'End If
        End Function

        Public Function obtenerAbonocpagar(id_Abonocpagar As String) As Modelo.abonocpagar


            ''CARGA EL ABONO SELECCIONADO
            'Fx.Cargar_Tabla_Generico(Me.adAbonos, "Select * from abonocpagar where Id_Abonocpagar =" & Id, SqlConnection1.ConnectionString)
            'Me.adAbonos.Fill(Me.DataSetAbonosProveedor.abonocpagar)

            'Dim ii As Integer
            'For ii = 0 To Me.DataSetAbonosProveedor.abonocpagar.Count - 1
            '    If Me.BindingContext(Me.DataSetAbonosProveedor.abonocpagar).Current("Anulado") = True Then
            '        Me.CheckBox2.Checked = True
            '    End If
            'Next

            'Fx.Cargar_Tabla_Generico(Me.daDetalle_Abono, "SELECT * FROM detalle_abonocpagar WHERE Id_Abonocpagar = " & Id, SqlConnection1.ConnectionString)
            'Me.daDetalle_Abono.Fill(Me.DataSetAbonosProveedor, "detalle_abonocpagar")

            'Fx.Cargar_Tabla_Generico(Me.Adapter_Proveedor, "SELECT * from proveedores where codigoProv  =" & BindingContext(DataSetAbonosProveedor, "abonocpagar").Current("Cod_Proveedor"), SqlConnection1.ConnectionString)
            'Me.Adapter_Proveedor.Fill(Me.DataSetAbonosProveedor, "Proveedores")
            'txtNombre.Text = BindingContext(DataSetAbonosProveedor, "Proveedores").Current("Nombre")

            'Fx.Cargar_Tabla_Generico(Me.Adapter_Cuenta_Proveedor, "SELECT * FROM Cuentas_Bancarias_Proveedor WHERE CodigoProv = " & BindingContext(DataSetAbonosProveedor, "abonocpagar").Current("Cod_Proveedor"), SqlConnection1.ConnectionString)
            'Me.Adapter_Cuenta_Proveedor.Fill(Me.DataSetAbonosProveedor, "Cuentas_Bancarias_Proveedor")
            'ComboBoxCuentaBancariaDestino.SelectedValue = BindingContext(DataSetAbonosProveedor, "abonocpagar").Current("CuentaDestino")

        End Function

        Public Sub anulaAbonocpagar(id_Abonocpagar As String, eliminaCheque As Boolean)

            '    Function Registrar_Anulacion_Venta() As Boolean
            '    Dim i As Long
            '    Dim Facttem As Double
            '    Dim Funciones As New Conexion
            '    If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            '    Try
            '        Me.SqlUpdateCommand1.Transaction = Trans
            '        Me.adAbonos.Update(Me.DataSetAbonosProveedor, "abonocpagar")
            '        For i = 0 To Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Count - 1
            '            Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Position = i

            '            Facttem = Me.BindingContext(DataSetAbonosProveedor, "abonocpagar.abonocpagardetalle_abonocpagar").Current("Factura")
            '            Funciones.UpdateRecords("Compras", "FacturaCancelado = 0", "Factura =" & Facttem & "and TipoCompra = 'CRE'", strModulo)

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

            'elimina el cheque para que pueda volver a ingresarlo en caso de tener que volver a digitar
            '***** aunque deberia de preguntar porque puede ocupar el cheque nulo
            'Private Sub anula(ByVal _num_cheque As String)
            '    Try
            '        Dim cls As New Anulacheque
            '        cls.EliminarCheque(_num_cheque, True, Me.ComboBoxCuentaBancaria.Text, ComboBoxCuentaBancaria.SelectedValue)
            '    Catch ex As Exception
            '        MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al anular el cheque")
            '    End Try
            'End Sub

        End Sub


    End Class

End Namespace
