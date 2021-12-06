Namespace Logica
    Public Class Cotizaciones

        Public Property Inventario As New Logica.Inventario
        Public Property Clientes As New Logica.Clientes
        Public Property Moneda As New Logica.Monedas

        Public Function buscarCotizacion(porNombre As Boolean,
                                         porNumero As Boolean,
                                         filtro As String,
                                         entreFechas As Boolean,
                                         desde As Date,
                                         hasta As Date) As List(Of Modelo.cotizacion)
            'identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("Select Cotizacion, Fecha, Nombre_Cliente AS Cliente, Total as [Total Cotización] from Cotizacion Order by Fecha DESC", "Cliente", "Fecha", "Buscar Cotizacion"))
            ''buscando = True
            'If identificador = 0.0 Then ' si se dio en el boton de cancelar
            '    '   Me.buscando = False
            '    Exit Sub
            'End If
        End Function

        Public Function obtenerCotizacion() As Modelo.cotizacion
            '    Function LlenarVentas(ByVal Id As Double)
            '    Me.CargarTelefono(Id)
            '    Dim cnnv As SqlConnection = Nothing
            '    Dim dt As New DataTable
            '    '
            '    ' Dentro de un Try/Catch por si se produce un error
            '    Try
            '        '''''''''LLENAR VENTAS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '        ' Obtenemos la cadena de conexión adecuada
            '        Dim sConn As String = CadenaConexionSeePOS()
            '        cnnv = New SqlConnection(sConn)
            '        cnnv.Open()
            '        ' Creamos el comando para la consulta
            '        Dim cmdv As SqlCommand = New SqlCommand
            '        Dim sel As String = "SELECT * FROM Cotizacion WHERE (Cotizacion = @Id_Factura) "

            '        cmdv.CommandText = sel
            '        cmdv.Connection = cnnv
            '        cmdv.CommandType = CommandType.Text
            '        cmdv.CommandTimeout = 90
            '        ' Los parámetros usados en la cadena de la consulta 
            '        cmdv.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))

            '        cmdv.Parameters("@Id_Factura").Value = Id

            '        ' Creamos el dataAdapter y asignamos el comando de selección
            '        Dim dv As New SqlDataAdapter
            '        dv.SelectCommand = cmdv
            '        ' Llenamos la tabla
            '        dv.Fill(Me.DataSet_Cotizaciones21, "Cotizacion")


            '        '''''''''LLENAR VENTAS DETALLES''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '        ' Obtenemos la cadena de conexión adecuada
            '        'Dim sConn As String = CadenaConexionSeePOS
            '        'cnn = New SqlConnection(sConn)
            '        'cnn.Open()

            '        ' Creamos el comando para la consulta
            '        Dim cmd As SqlCommand = New SqlCommand
            '        sel = "SELECT * FROM Cotizacion_Detalle WHERE (Cotizacion = @Id_Factura) "

            '        cmd.CommandText = sel
            '        cmd.Connection = cnnv
            '        cmd.CommandType = CommandType.Text
            '        cmd.CommandTimeout = 90
            '        ' Los parámetros usados en la cadena de la consulta 
            '        cmd.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))

            '        cmd.Parameters("@Id_Factura").Value = Id

            '        ' Creamos el dataAdapter y asignamos el comando de selección
            '        Dim da As New SqlDataAdapter
            '        da.SelectCommand = cmd
            '        ' Llenamos la tabla
            '        da.Fill(Me.DataSet_Cotizaciones21.Cotizacion_Detalle)


            '    Catch ex As System.Exception
            '        ' Si hay error, devolvemos un valor nulo.
            '        MsgBox(ex.ToString)
            '    Finally
            '        ' Por si se produce un error,
            '        ' comprobamos si en realidad el objeto Connection está iniciado,
            '        ' de ser así, lo cerramos.
            '        If Not cnnv Is Nothing Then
            '            cnnv.Close()
            '        End If
            '    End Try
            'End Function
        End Function

        Public Sub crearCotizacion(cotizacion As Modelo.cotizacion)

            'Dim Contacto As String = ""
            'Dim frm As New frmContactoCotizacion
            'frm.txtContacto.Text = Me.txtContacto.Text
            'frm.txtTelefono.Text = Me.txtTelefono.Text
            'If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            '    txtTelefono.Text = frm.txtTelefono.Text
            '    Contacto = frm.txtContacto.Text
            'Else
            '    Exit Function
            'End If

            'If Me.ck_confirmada.Checked And Me.txtconfirmadapor.Text = "" Then
            '    MsgBox("Marco la opción de confirmada, por favor ingrese el nombre de la persona con la que confirmo la cotización.", MsgBoxStyle.Critical, "Cotizaciones")
            '    Me.txtconfirmadapor.Focus()
            '    Exit Function
            'Else
            '    BindingContext(DataSet_Cotizaciones21, "Cotizacion").Current("confirmada_por") = Me.txtconfirmadapor.Text
            '    BindingContext(DataSet_Cotizaciones21, "Cotizacion").EndCurrentEdit()
            'End If

            'Function RegistrarVenta() As Boolean

            '    If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            '    Try
            '        Me.SqlInsertCommand1.Transaction = Trans
            '        Me.SqlUpdateCommand1.Transaction = Trans
            '        Me.SqlDeleteCommand1.Transaction = Trans

            '        Me.SqlInsertCommand2.Transaction = Trans
            '        Me.SqlUpdateCommand2.Transaction = Trans
            '        Me.SqlDeleteCommand2.Transaction = Trans

            '        'Me.Adapter_Cotizacion.Update(Me.DataSet_Cotizaciones21, "Cotizacion")
            '        Me.Adapter_Cotizacion.Update(Me.DataSet_Cotizaciones21, "Cotizacion")
            '        Me.Adapter_Cotizacion_Detalle.Update(Me.DataSet_Cotizaciones21, "Cotizacion_Detalle")
            '        Trans.Commit()
            '        Return True


            '    Catch ex As Exception
            '        Trans.Rollback()
            '        MsgBox(ex.Message)
            '        Me.ToolBar1.Buttons(2).Enabled = True
            '        Return False
            '    End Try
            'End Function

        End Sub

        Public Sub editarCotzacion(cotizacion As Modelo.cotizacion)
            'igual que el de crear
        End Sub

        Public Sub anularCotizacion()
            'Function Registrar_Anulacion_Venta() As Boolean

            '    If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            '    Try

            '        Me.SqlUpdateCommand1.Transaction = Trans

            '        Me.Adapter_Cotizacion.Update(Me.DataSet_Cotizaciones21, "Cotizacion")

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
