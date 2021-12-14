Namespace Logica
    Public Class Ventas

        Public Property Configuraciones As New Logica.Configuraciones
        Public Property AperturaCaja As New Logica.AperturaCaja
        Public Property PedidoBodega As New Logica.PedidoBodega
        Public Property CartaExoneracion As New Logica.CartaExoneracion
        Public Property Agente_Ventas As New Logica.Agente_Ventas
        Public Property Rifa As New Logica.Rifa
        Public Property Clientes As New Logica.Clientes
        Public Property Moneda As New Logica.Monedas
        Public Property Inventario As New Logica.Inventario
        Public Property Cotizaciones As New Logica.Cotizaciones

        Public Function Obtener(id As Integer) As Modelo.ventas
            'Public Function Obtener_Factura(_IdFactura As String) As DataTable
            '    Dim dt As New DataTable
            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeguridad)
            '    db.AddParametro("@IdFactura", _IdFactura)
            '    db.AddParametro("@BasedeDatos", Me.BasedeDatos)
            '    dt = db.Ejecutar("Obtener_Factura")
            '    Return dt
            'End Function

            'Public Function Obtener_DetallesFactura(_IdFactura As String) As DataTable
            '    Dim dt As New DataTable
            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeguridad)
            '    db.AddParametro("@IdFactura", _IdFactura)
            '    db.AddParametro("@BasedeDatos", Me.BasedeDatos)
            '    dt = db.Ejecutar("Obtener_DetallesFactura")
            '    Return dt
            'End Function
        End Function

        Public Function Buscar(porNombre As Bodega,
                                      porNumFactura As Boolean,
                                      filtro As String,
                                      entreFechas As Boolean,
                                      desde As Date,
                                      hasta As Date) As List(Of Modelo.ventas)


            'Private Sub BuscarDatos(ByVal Descripcion As String)
            '    'Variable que almacenara el campo que por el que se va ha buscar
            '    Dim strCampoFiltro As String = ""
            '    'Evaluo si se desea realizar la busqueda por numero de documento
            '    If strNumeroDocumento Is Nothing Then '#1 'Si no se inicializo la variable numero documento buscara solo por CampoFiltro
            '        DV.RowFilter = CampoFiltro & " lIKE '%" & Descripcion & "%'" & IIf(Me.CkeckBuscaFecha.Checked = True, " AND " & CampoFecha & " >= '" & CType(Fecha1.Value, Date) & "' AND " & CampoFecha & " <= '" & DateAdd(DateInterval.Day, 1, Fecha2.Value) & "'", "")
            '    Else '#1 'Si se inicializo la variable strNumeroDocumento verifico el tipo de busqueda 
            '        If Me.radbNombre.Checked = True Then '#2
            '            strCampoFiltro = CampoFiltro
            '            DV.RowFilter = strCampoFiltro & " lIKE '%" & Descripcion & "%'" & IIf(Me.CkeckBuscaFecha.Checked = True, " AND " & CampoFecha & " >= '" & CType(Fecha1.Value, Date) & "' AND " & CampoFecha & " <= '" & DateAdd(DateInterval.Day, 1, Fecha2.Value) & "'", "")
            '        Else '#2
            '            If Me.radbNumeroFactura.Checked = True Then '#3
            '                strCampoFiltro = strNumeroDocumento
            '                DV.RowFilter = strCampoFiltro & " lIKE '%" & Descripcion & "%'" & IIf(Me.CkeckBuscaFecha.Checked = True, " AND " & CampoFecha & " >= '" & CType(Fecha1.Value, Date) & "' AND " & CampoFecha & " <= '" & DateAdd(DateInterval.Day, 1, Fecha2.Value) & "'", "")
            '            End If '#3
            '        End If '#2
            '    End If '#1
            '    If Me.CheckBox1.Checked = True Then
            '        strCampoFiltro = CampoFiltro
            '        Descripcion = ""
            '        DV.RowFilter = strCampoFiltro & " lIKE '%" & Descripcion & "%'" & IIf(Me.CheckBox1.Checked = True, " AND Factura ='" + Me.TextBox1.Text + "-" + Me.cbxTipo.Text + "'", "")
            '    End If
            'End Sub

        End Function

        Public Sub Crear(ventas As Modelo.ventas)


            'If Me.txtcodigo.Text <> "0" And (Me.txtNombre.Text.ToLower = "cliente de contado" Or Me.txtNombre.Text = "" Or Me.txtNombre.Text.ToLower = "cliente contado") Then
            '    MsgBox("Ingrese el cliente porfavor.", MsgBoxStyle.Exclamation, Text)
            '    Me.lblMensaje.Height = 0
            '    Me.YaEstaFacturando = False
            '    Exit Sub
            'End If

            'If Me.txt_cedula.Text <> "0" And Me.txtCorreoComprobantes.Text <> "" And PV() = True Then
            '    If MsgBox("Desea realizar un tiquete electronico al cliente." & vbCrLf _
            '              & "Los tiquetes electronicos no llegan al correo." & vbCrLf _
            '              & "Desea continuar con el tiquete.", MsgBoxStyle.Question + MsgBoxStyle.YesNo + vbDefaultButton2, "Confirmar Accion!!!") = MsgBoxResult.No Then
            '        Me.lblMensaje.Height = 0
            '        Me.YaEstaFacturando = False
            '        Exit Sub
            '    End If
            'End If

            'If Me.txt_cedula.Text.Length < 9 And PV() = False Then
            '    MsgBox("La identificacion del cliente no es valida", MsgBoxStyle.Exclamation, Text)
            '    Me.lblMensaje.Height = 0
            '    Me.YaEstaFacturando = False
            '    Exit Sub
            'End If

            'If ckFrecuente.Checked = True And btn_cliente_nuevo.Enabled = True Then
            '    MsgBox("Para facturar el cliente frecuente debe estar registrado.", MsgBoxStyle.Exclamation, "El cliente frecuente no esta registrado")
            '    Me.lblMensaje.Height = 0
            '    Me.YaEstaFacturando = False
            '    Exit Sub
            'End If

            'If Me.opApartado.Checked = True And PV() = True Then
            '    MsgBox("Los apartados solo se pueden registrar con F2 o F4", MsgBoxStyle.Exclamation, Text)
            '    Me.lblMensaje.Height = 0
            '    Me.YaEstaFacturando = False
            '    Exit Sub
            'End If

            'If Me.txt_cedula.Text = "0" And PV() = False Then
            '    MsgBox("Debe ingresar la identificacion del cliente", MsgBoxStyle.Exclamation, "La operacion no se puedo procesar.")
            '    Me.lblMensaje.Height = 0
            '    Me.YaEstaFacturando = False
            '    Exit Sub
            'End If

            'If Me.opCredito.Checked = True Then
            '    If Me.PuedeRealizarVentaCredito = False Then
            '        Me.lblMensaje.Height = 0
            '        Me.YaEstaFacturando = False
            '        Exit Sub
            '    End If
            'End If

            'Try
            '    If PV() = True And Me.opApartado.Checked = True Then
            '        MsgBox("Los apartados solo pueden salir con F2 o F4", MsgBoxStyle.Exclamation, Text)
            '        Me.lblMensaje.Height = 0
            '        Me.YaEstaFacturando = False
            '        Exit Sub
            '    End If

            '    Me.ToolBar1.Buttons(2).Enabled = False
            '    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            '    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
            '    Me.QuitaLineasenBlanco()

            '    If Me.ValidaNombreQuimicos(Me.nombre_cliente) = False Then
            '        Me.lblMensaje.Height = 0
            '        Me.YaEstaFacturando = False
            '        Exit Sub
            '    End If

            '    If Me.AplicaCambioenCaja = True And Me.opCredito.Checked = False Then
            '        If Me.Modo = "PreVentas" Then
            '            If Me.EstadoPreventa <> "PreVenta" Then
            '                MsgBox("No se puede registrar la preventa, el estado es " & Me.EstadoPreventa & "", MsgBoxStyle.Exclamation, Me.Text)
            '                Me.lblMensaje.Height = 0
            '                Me.YaEstaFacturando = False
            '                Exit Sub
            '            End If

            '            Dim frm As New frmIngresarNumerodeFicha
            '            frm.IdUsuario = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula_Usuario")
            '            frm.txtNumero.Text = Me.txtFicha.Text
            '            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            '                Me.txtFicha.Text = frm.txtNumero.Text
            '                If PasaValidacionFicha(Me.txtFicha.Text) = False Then
            '                    Me.lblMensaje.Height = 0
            '                    Me.YaEstaFacturando = False
            '                    Exit Sub
            '                End If
            '            Else
            '                Me.lblMensaje.Height = 0
            '                Me.YaEstaFacturando = False
            '                Exit Sub
            '            End If
            '        End If
            '    End If

            '    If buscando = True And Me.AplicaCambioenCaja = False Then
            '        MsgBox("No se puede modificar esta factura, solo reimprimirla", MsgBoxStyle.Information)
            '        Me.lblMensaje.Height = 0
            '        Me.YaEstaFacturando = False
            '        Exit Sub
            '    End If

            '    If Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count = 0 Then 'Si la factura no tiene detalle
            '        MsgBox("No se Puede Registrar una venta si no contiene artículos", MsgBoxStyle.Critical)
            '        Me.ToolBar1.Buttons(2).Enabled = False
            '        BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            '        BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
            '        BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()
            '        txtCod_Articulo.Focus()
            '        Me.lblMensaje.Height = 0
            '        Me.YaEstaFacturando = False
            '        Exit Sub
            '    End If

            '    Me.Revisa_Error_Bodegas_VeterinariaLiberia()
            '    If Me.ValidaPrecio() = False Then
            '        Exit Sub
            '    End If

            '    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
            '    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
            '    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").AddNew()
            '    Me.txtcodigo.Text = codigo_cliente
            '    Me.txtNombre.Text = nombre_cliente

            '    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente") = codigo_cliente
            '    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("nombre_cliente") = nombre_cliente
            '    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("TipoCedula") = Me.cbo_tipo_cliente.Text
            '    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cedula") = txt_cedula.Text
            '    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("EnviadoMH") = False
            '    Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").EndCurrentEdit()

            '    If Me.txtorden.Text.Length < 3 And Me.ObligaOrdenCompra = True And Me.opCredito.Checked = True Then
            '        MsgBox("Debe de ingresar la orden de compra para este cliente", MsgBoxStyle.Exclamation, "Favor Ingresar la orden de compra")
            '        Me.txtorden.Focus()
            '        Me.lblMensaje.Height = 0
            '        Me.YaEstaFacturando = False
            '        Exit Sub
            '    End If

            '    If Me.txtNombre.Text = "" Or txtNombre.Text = "INGRESE EL NOMBRE" Then
            '        MsgBox("Debe de Digitar el Nombre del Cliente, Solicitelo con amabilidad por favor....!", MsgBoxStyle.Information)
            '        Me.lblMensaje.Height = 0
            '        txtNombre.SelectAll()
            '        Me.txtNombre.Focus()
            '        Me.lblMensaje.Height = 0
            '        Me.YaEstaFacturando = False
            '        Exit Sub
            '    End If

            '    If Me.CajaAbierta(BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Num_Caja")) = False Then
            '        MsgBox("La caja no esta abierta, No se puede facturar, pruebe en otra caja!!!", MsgBoxStyle.Exclamation, Text)
            '        Me.lblMensaje.Height = 0
            '        Me.YaEstaFacturando = False
            '        Exit Sub
            '    End If

            '    If Me.ValidaDGT = False Then
            '        MsgBox("Debe ingresar la identificacion del cliente", MsgBoxStyle.Exclamation, Text)
            '        Me.lblMensaje.Height = 0
            '        Exit Sub
            '    End If

            '    If PV() = False Then
            '        Dim dt As New DataTable
            '        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '        dt = db.Ejecutar("Select TipoCliente, Cedula, Nombre, Telefono_01, CorreoComprobante, Direccion From Clientes Where Identificacion = '" & Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente") & "'", CommandType.Text)

            '        If dt.Rows.Count > 0 Then
            '            If Me.PasaFormatoCedula = False Or Me.GetActualizado() = False Then
            '                MsgBox("La informacion del cliente esta incorrecta o desactualizada, Favor Actualizar Datos", MsgBoxStyle.Information, Text)
            '                Dim frm As New frm_cliente_rapido
            '                frm.BanderaActualizar = True
            '                frm.Cod_Cliente = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente")
            '                frm.cbo_tipo_cliente.Text = dt.Rows(0).Item("TipoCliente")
            '                frm.txtCodigo.Text = dt.Rows(0).Item("Cedula")
            '                frm.txtNombre.Text = dt.Rows(0).Item("Nombre")
            '                frm.txtTelefono.Text = dt.Rows(0).Item("Telefono_01")
            '                frm.txt_email.Text = dt.Rows(0).Item("CorreoComprobante")
            '                frm.Txtdireccion.Text = dt.Rows(0).Item("Direccion")
            '                If frm.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            '                    Me.lblMensaje.Height = 0
            '                    Me.YaEstaFacturando = False
            '                    Exit Sub
            '                End If
            '            End If
            '        Else
            '            'debe hacer algo???
            '        End If
            '    End If

            '    Me.PoneTexto()

            '    If PV() = True And Me.opCredito.Checked = True Then
            '        MsgBox("La factura es de credito, precione F2 o F4 para registrarla.", MsgBoxStyle.Exclamation, "No se puede procesar la operacion!!!")
            '        Me.lblMensaje.Height = 0
            '        Me.YaEstaFacturando = False
            '        Exit Sub
            '    End If

            '    'valida que la ficha no este activa para no  repetirla 
            '    If Me.opCredito.Checked = False Then
            '        If PasaValidacionFicha(Me.txtFicha.Text) = False Then
            '            Me.lblMensaje.Height = 0
            '            Me.YaEstaFacturando = False
            '            Exit Sub
            '        End If
            '    End If

            '    If MessageBox.Show("¿Desea Registrar esta Factura?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then 'si no desea guardar la facturacion
            '        Me.ToolBar1.Buttons(2).Enabled = True

            '        txtCod_Articulo.Focus()
            '        Me.lblMensaje.Height = 0
            '        Me.TclCaja = ""
            '        Me.YaEstaFacturando = False
            '        Exit Sub
            '    End If
            '    Dim mascotas As Boolean = Me.Ck_Mascotas.Checked
            '    Dim taller As Boolean = Me.Ck_Taller.Checked

            '    BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Mascotas") = mascotas
            '    BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Taller") = taller

            '    If opCredito.Checked Then
            '        Dim Firma As New Firma
            '        Firma.Encargado = ""
            '        Firma.Cliente = BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Cliente")
            '        Firma.ShowDialog()
            '        If Firma.DialogResult = DialogResult.OK Then
            '            BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Encargado_Compra") = Firma.Encargado
            '        Else
            '            Me.lblMensaje.Height = 0
            '            Me.YaEstaFacturando = False
            '            Exit Sub
            '        End If
            '        Firma.Dispose()
            '    Else
            '        BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Cod_Encargado_Compra") = "NINGUNO"
            '    End If
            '    BindingContext(DataSet_Facturaciones, "Ventas").Current("pagoImpuesto") = impuesto_cliente
            '    BindingContext(DataSet_Facturaciones, "Ventas").EndCurrentEdit()

            '    Verificar_Consecutivos(PV)
            '    If num_fact <> 0 Then
            '        BindingContext(DataSet_Facturaciones, "Ventas").Current("Num_Factura") = num_fact
            '    End If
            '    If tipo_fact <> "" Then
            '        BindingContext(DataSet_Facturaciones, "Ventas").Current("Tipo") = tipo_fact
            '    End If

            '    dtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            '    BindingContext(DataSet_Facturaciones, "Ventas").EndCurrentEdit()

            '    Me.buscar_rifa()
            '    If Me.RegistrarVenta() Then 'se registra en la base de datos then
            '        Me.IngresoIdentificacion = False
            '        buscar_rifa()
            '        Me.GuardarPedido()
            '        Me.DataSet_Facturaciones.AcceptChanges()

            '        Dim id As Long = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Id")
            '        Dim Tipo As String = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Tipo")

            '        If Me.CodigoCupon > 0 Then
            '            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '            db.Ejecutar("Update CuponDetalle Set Id_Factura = " & id & " Where Codigo = " & Me.CodigoCupon, CommandType.Text)
            '        End If

            '        If coti = True Then
            '            If Me.AplicaCambioenCaja = True And opCredito.Checked = False Then
            '                Dim IdCotizacion As String = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Cotizacion")
            '                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '                db.Ejecutar("Update Preventas set IdCotizacion = " & IdCotizacion & " where id = " & id, CommandType.Text)
            '            Else
            '                Dim IdCotizacion As String = Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Cotizacion")
            '                Dim erroren As String = ""
            '                Try
            '                    Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").Current("Venta") = True
            '                    Me.BindingContext(Me.DataSet_Facturaciones, "Cotizacion").EndCurrentEdit()
            '                    Me.Adapter_Coti.Update(Me.DataSet_Facturaciones, "Cotizacion")
            '                Catch ex As Exception
            '                    erroren = "1 "
            '                End Try
            '                Try
            '                    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '                    db.Ejecutar("Update Cotizacion set Venta = 1, EstadoActual = 'Ganada', ObservacionEstado = 'cambio estado automatico por sistema', Id_Factura = " & id & " where Cotizacion = " & IdCotizacion, CommandType.Text)
            '                    coti = False
            '                Catch ex As Exception
            '                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Problemas al actualizar cotizacion " & erroren & " 2")
            '                End Try
            '            End If
            '        End If

            '        If Me.AplicaCambioenCaja = True Then
            '            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '            db.Ejecutar("Update Preventas set Id_FacturaRemplaza = " & Me.IdFacturaRemplaza & ", Ficha = " & Me.txtFicha.Text & ", Frecuente = " & IIf(Me.ckFrecuente.Checked = False, 0, 1) & " where id = " & id, CommandType.Text)
            '            Me.txtFicha.Text = ""
            '        Else
            '            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '            db.Ejecutar("Update ventas set Id_FacturaRemplaza = " & Me.IdFacturaRemplaza & ", Frecuente = " & IIf(Me.ckFrecuente.Checked = False, 0, 1) & " where id = " & id, CommandType.Text)
            '        End If

            '        If Tipo = "CRE" Then
            '            If Me.AplicaCambioenCaja = True Then
            '                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '                db.AddParametro("@IdFactura", id)
            '                db.AddParametro("@PuntodeVenta", Me.GetPuntoVenta)
            '                db.Ejecutar("PreVenta_Factura")
            '            End If
            '        End If

            '        Me.ToolBar1.Buttons(4).Enabled = True
            '        Me.ToolBar1.Buttons(1).Enabled = True


            '        Me.SimpleButton1.Enabled = False
            '        Me.SimpleButton2.Enabled = False

            '        Me.ToolBar1.Buttons(0).Text = "Nuevo"
            '        Me.ToolBar1.Buttons(0).ImageIndex = 0
            '        Me.ToolBar1.Buttons(3).Enabled = False
            '        Me.ToolBar1.Buttons(2).Enabled = False
            '        Me.ToolBar1.Buttons(4).Enabled = False

            '        Me.GroupBox6.Enabled = False
            '        Me.GroupBox3.Enabled = False
            '        Me.txtorden.Enabled = True
            '        Me.Label10.Visible = False
            '        Me.Label11.Visible = False
            '        Me.Label_Costobase.Visible = False
            '        Me.ComboBox1.Enabled = False
            '        Ck_Exonerar.Enabled = False
            '        txtHecho.Text = ""
            '        txtExistencia.Text = "0"
            '        txtExistencia.EditValue = 0
            '        Me.logeado = False

            '        Me.txtUsuario.Enabled = True
            '        Me.txtUsuario.Text = ""
            '        Me.txtNombreUsuario.Text = ""

            '        Me.txtUsuario.Focus()
            '        Me.SimpleButton3.Enabled = False
            '        Me.TxtUtilidad.Text = ""
            '        Ck_Taller.Enabled = False
            '        Ck_Mascotas.Enabled = False
            '        Me.Label41.Visible = False
            '        Me.txtEncargado.Visible = False


            '        MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
            '        txt_cedula.Text = ""
            '        Me.reimprimir = False
            '        Me.YaEstaFacturando = False
            '        'Solo imprime si no esta activado el modo caja o si la opcion de credito esta activa
            '        If Me.AplicaCambioenCaja = False Or Me.opCredito.Checked = True Then
            '            Select Case Me.TclCaja
            '                Case "F2"
            '                    Imprimir(id, PV, 1)
            '                Case "F3"
            '                    Imprimir(id, PV, 1)
            '                Case "F4"
            '                    Imprimir(id, PV, 2)
            '                Case "F5"
            '                    Imprimir(id, PV, 2)
            '            End Select
            '        End If
            '        Me.imprime_cupon = False

            '        If buscando = True Then buscando = False

            '        Me.DataSet_Facturaciones.Ventas_Detalle.Clear()
            '        Me.DataSet_Facturaciones.Ventas.Clear()
            '        DataSet_Facturaciones.Lotes.Clear()
            '        AdapterLotes.Fill(DataSet_Facturaciones, "Lotes")

            '        Me.ToolBar1.Buttons(2).Enabled = True
            '        Me.ToolBar1.Buttons(5).Enabled = False

            '    Else
            '        MsgBox("Error al Registrar", MsgBoxStyle.Critical)
            '        Me.ToolBar1.Buttons(2).Enabled = True
            '        Me.lblMensaje.Height = 0
            '        Me.TclCaja = ""
            '    End If
            '    Me.lblMensaje.Height = 0
            '    Me.TclCaja = ""
            'Catch ex As System.Exception
            '    Me.lblMensaje.Height = 0
            '    Me.TclCaja = ""
            '    Me.ToolBar1.Buttons(2).Enabled = True
            '    MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            'End Try

        End Sub


        'no se edita
        'no se anula

        Public Function saldoFactura()

            '    Public Function Saldo_Facturas(ByVal FacturaNo As Long, ByVal MontoFactura As Double, ByVal TipoCambFact As Double, ByVal id As Long) As Double
            '    Dim cConexion As New Conexion
            '    Dim sqlConexion As New SqlConnection
            '    Dim MontoDevoluciones As Double
            '    Dim MontoAbonos As Double
            '    Dim MontoNCredito As Double
            '    Dim MontoNDebito As Double
            '    Dim InteresCob As Double
            '    Dim Saldo_de_Factura As Double

            '    Try
            '        sqlConexion = cConexion.Conectar
            '        MontoDevoluciones = 0

            '        'Cálcula Devoluciones
            '        MontoDevoluciones = cConexion.SlqExecuteScalar(sqlConexion, "SELECT SUM(Monto) as TotalMonto FROM Devoluciones_Ventas WHERE Id_Factura =" & id & " AND Anulado = 0")
            '        'Cálcula los Abonos
            '        MontoAbonos = cConexion.SlqExecuteScalar(sqlConexion, "select  SUM(detalle_abonoccobrar.Abono_SuMoneda) AS TotalAbono FROM detalle_abonoccobrar INNER JOIN  abonoccobrar ON detalle_abonoccobrar.Id_Recibo = abonoccobrar.Id_Recibo WHERE (detalle_abonoccobrar.Tipo = 'CRE') AND and Factura =" & FacturaNo & " AND abonoccobrar.Anula = 0")

            '        'NOTAS DE CREDITO
            '        MontoNCredito = cConexion.SlqExecuteScalar(sqlConexion, "SELECT  SUM(detalle_ajustesccobrar.Ajuste) AS TotalAjuste FROM detalle_ajustesccobrar INNER JOIN ajustesccobrar ON detalle_ajustesccobrar.Id_AjustecCobrar = ajustesccobrar.ID_Ajuste WHERE (detalle_ajustesccobrar.Tipo = 'CRE') AND Factura =" & FacturaNo & " AND (detalle_ajustesccobrar.Tipo = 'CRE')")

            '        'NOTAS DE DEBITO
            '        cConexion.SlqExecuteScalar(sqlConexion, "SELECT  SUM(detalle_ajustesccobrar.Ajuste) AS TotalAjuste FROM detalle_ajustesccobrar INNER JOIN ajustesccobrar ON detalle_ajustesccobrar.Id_AjustecCobrar = ajustesccobrar.ID_Ajuste WHERE (detalle_ajustesccobrar.Tipo = 'CRE') AND Factura =" & FacturaNo & " AND (detalle_ajustesccobrar.Tipo = 'DEB')")
            '        'Obtener el saldo final de la factura
            '        Saldo_de_Factura = MontoFactura + ((MontoNDebito - MontoNCredito - MontoAbonos) * TipoCambFact)

            '        cConexion.DesConectar(sqlConexion)
            '        Return Saldo_de_Factura

            '    Catch ex As SystemException
            '        MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            '    End Try
            'End Function

        End Function

        Public Function FacturasPendientes(cod_Cliente As Integer) As List(Of Modelo.ventas)
            'Public Shared Function BuscarFacturas(ByVal CodigoCliente As String, Optional ByVal FiltrarIncobrables As Boolean = False) As DataTable

            '    Dim dt As New DataTable
            '    '' Dentro de un Try/Catch por si se produce un error
            '    Try
            '        If FiltrarIncobrables = False Then
            '            Llenar_Tabla_Generico("SELECT Num_Factura as Factura, Fecha, Total, Cod_Moneda, Tipo, Num_Caja, EnProcesoIncobrable, Id From viewFacturaCredito WHERE Cod_Cliente = " & CDec(CodigoCliente) & " and (dbo.SaldoFactura_Monto(GETDATE(), Num_Factura, Tipo, Cod_Cliente, Total) > 1) ORDER BY Fecha DESC", dt)
            '        Else
            '            Llenar_Tabla_Generico("SELECT Num_Factura as Factura, Fecha, Total, Cod_Moneda, Tipo, Num_Caja, EnProcesoIncobrable, Id From viewFacturaCredito WHERE EnProcesoIncobrable = 0 And Cod_Cliente = " & CDec(CodigoCliente) & " and (dbo.SaldoFactura_Monto(GETDATE(), Num_Factura, Tipo, Cod_Cliente, Total) > 1) ORDER BY Fecha DESC", dt)
            '        End If
            '    Catch ex As System.Exception
            '        ' Si hay error, devolvemos un valor nulo.
            '        MsgBox(ex.ToString)
            '        Return Nothing
            '    Finally
            '        ' Por si se produce un error,
            '        ' comprobamos si en realidad el objeto Connection está iniciado,
            '        ' de ser así, lo cerramos.
            '        'If Not cnn Is Nothing Then
            '        'cnn.Close()
            '        'End If
            '    End Try
            '    ' Devolvemos el objeto DataTable con los datos de la consulta
            '    Return dt
            'End Function
        End Function

    End Class
End Namespace
