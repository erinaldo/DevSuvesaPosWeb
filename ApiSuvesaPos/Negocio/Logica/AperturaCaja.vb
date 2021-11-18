Namespace Logica
    Public Class AperturaCaja

        'cargar la cls de usuarios
        'cargar la cls de cantidad de cajas
        Public Property Moneda As New Logica.Monedas
        Public Property Denominacion_Moneda As New Logica.Denominacion_Moneda

        Public Sub crarAperturaCaja(aperturacaja As Modelo.aperturacaja)

            'Private Function Valida() As Boolean
            '    Try
            '        'Catidad Ingresada
            '        Dim tot As Decimal = 0
            '        'Total Detalle\Tope
            '        Dim dtt As Decimal = 0
            '        'Recorrera el DenominacionesApertura
            '        Dim a As DataRow
            '        'Recorrera el Adapter TotalTope
            '        Dim b As DataRow

            '        Dim s As String = Me.BindingContext(DataSetAperturaCaja1.aperturacaja).Current("NApertura")
            '        Dim id As String = ""

            '        'Recorrera los datos en la tabla moneda del adaptador que contiene los datos de moneda
            '        Dim m As DataRow

            '        For Each b In Me.DataSetAperturaCaja1.Tables("Apertura_Total_Tope").Rows
            '            If s = b("NApertura") Then
            '                Dim codm As String = b("CodMoneda")
            '                '==============================================================
            '                For Each m In Me.DataSetAperturaCaja1.Tables("moneda").Rows
            '                    If m("CodMoneda") = codm Then
            '                        dtt += b("Monto_Tope") * m("ValorVenta")
            '                        Exit For
            '                    End If
            '                Next
            '                '==============================================================
            '            End If
            '        Next

            '        For Each a In Me.DataSetAperturaCaja1.Tables("Denominacion_Moneda").Rows ' "aperturacaja.aperturacajaDenominacionesAperturas")
            '            Dim codm As String = a("CodMoneda")
            '            '================================================================
            '            For Each m In Me.DataSetAperturaCaja1.Tables("moneda").Rows
            '                If m("CodMoneda") = codm Then
            '                    tot += a("Total") * m("ValorVenta")
            '                    Exit For
            '                End If
            '            Next
            '            '================================================================
            '        Next

            '        'Evaluo si los datos que hay en detalle total\Tope coinciden con  los de detalle de denominacion
            '        If tot <> dtt Then
            '            MsgBox("Ingrese el detalle de las denominaciones correctamente", MsgBoxStyle.Exclamation, "Mensaje")
            '            Return False
            '        End If
            '        Return True

            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        Return False
            '    End Try
            'End Function



            'Function RegistarApertura() As Boolean
            '    If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            '    Try
            '        'Apertura
            '        Me.AdapterAperturaCaja.InsertCommand.Transaction = Trans
            '        Me.AdapterAperturaCaja.UpdateCommand.Transaction = Trans
            '        Me.AdapterAperturaCaja.DeleteCommand.Transaction = Trans
            '        Me.AdapterAperturaCaja.SelectCommand.Transaction = Trans
            '        'Denominaciones
            '        Me.AdapterDenominacionesApertura.InsertCommand.Transaction = Trans
            '        Me.AdapterDenominacionesApertura.UpdateCommand.Transaction = Trans
            '        Me.AdapterDenominacionesApertura.DeleteCommand.Transaction = Trans
            '        Me.AdapterDenominacionesApertura.SelectCommand.Transaction = Trans
            '        'Tope
            '        Me.AdapterAperturaTotalTope.InsertCommand.Transaction = Trans
            '        Me.AdapterAperturaTotalTope.UpdateCommand.Transaction = Trans
            '        Me.AdapterAperturaTotalTope.DeleteCommand.Transaction = Trans
            '        Me.AdapterAperturaTotalTope.SelectCommand.Transaction = Trans

            '        Me.AdapterAperturaCaja.Update(Me.DataSetAperturaCaja1.aperturacaja)
            '        Me.AdapterDenominacionesApertura.Update(Me.DataSetAperturaCaja1.Apertura_Denominaciones)
            '        Me.AdapterAperturaTotalTope.Update(Me.DataSetAperturaCaja1.Apertura_Total_Tope)
            '        Me.DataSetAperturaCaja1.AcceptChanges()

            '        Trans.Commit()
            '        Return True
            '    Catch ex As Exception
            '        Trans.Rollback()
            '        MsgBox(ex.Message, MsgBoxStyle.Critical)
            '    End Try
            'End Function
        End Sub

        Public Sub editarAperturaCaja(aperturacaja As Modelo.aperturacaja)

            'Private Function Valida() As Boolean
            '    Try
            '        'Catidad Ingresada
            '        Dim tot As Decimal = 0
            '        'Total Detalle\Tope
            '        Dim dtt As Decimal = 0
            '        'Recorrera el DenominacionesApertura
            '        Dim a As DataRow
            '        'Recorrera el Adapter TotalTope
            '        Dim b As DataRow

            '        Dim s As String = Me.BindingContext(DataSetAperturaCaja1.aperturacaja).Current("NApertura")
            '        Dim id As String = ""

            '        'Recorrera los datos en la tabla moneda del adaptador que contiene los datos de moneda
            '        Dim m As DataRow

            '        For Each b In Me.DataSetAperturaCaja1.Tables("Apertura_Total_Tope").Rows
            '            If s = b("NApertura") Then
            '                Dim codm As String = b("CodMoneda")
            '                '==============================================================
            '                For Each m In Me.DataSetAperturaCaja1.Tables("moneda").Rows
            '                    If m("CodMoneda") = codm Then
            '                        dtt += b("Monto_Tope") * m("ValorVenta")
            '                        Exit For
            '                    End If
            '                Next
            '                '==============================================================
            '            End If
            '        Next

            '        For Each a In Me.DataSetAperturaCaja1.Tables("Denominacion_Moneda").Rows ' "aperturacaja.aperturacajaDenominacionesAperturas")
            '            Dim codm As String = a("CodMoneda")
            '            '================================================================
            '            For Each m In Me.DataSetAperturaCaja1.Tables("moneda").Rows
            '                If m("CodMoneda") = codm Then
            '                    tot += a("Total") * m("ValorVenta")
            '                    Exit For
            '                End If
            '            Next
            '            '================================================================
            '        Next

            '        'Evaluo si los datos que hay en detalle total\Tope coinciden con  los de detalle de denominacion
            '        If tot <> dtt Then
            '            MsgBox("Ingrese el detalle de las denominaciones correctamente", MsgBoxStyle.Exclamation, "Mensaje")
            '            Return False
            '        End If
            '        Return True

            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        Return False
            '    End Try
            'End Function



            'Function RegistarApertura() As Boolean
            '    If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            '    Try
            '        'Apertura
            '        Me.AdapterAperturaCaja.InsertCommand.Transaction = Trans
            '        Me.AdapterAperturaCaja.UpdateCommand.Transaction = Trans
            '        Me.AdapterAperturaCaja.DeleteCommand.Transaction = Trans
            '        Me.AdapterAperturaCaja.SelectCommand.Transaction = Trans
            '        'Denominaciones
            '        Me.AdapterDenominacionesApertura.InsertCommand.Transaction = Trans
            '        Me.AdapterDenominacionesApertura.UpdateCommand.Transaction = Trans
            '        Me.AdapterDenominacionesApertura.DeleteCommand.Transaction = Trans
            '        Me.AdapterDenominacionesApertura.SelectCommand.Transaction = Trans
            '        'Tope
            '        Me.AdapterAperturaTotalTope.InsertCommand.Transaction = Trans
            '        Me.AdapterAperturaTotalTope.UpdateCommand.Transaction = Trans
            '        Me.AdapterAperturaTotalTope.DeleteCommand.Transaction = Trans
            '        Me.AdapterAperturaTotalTope.SelectCommand.Transaction = Trans

            '        Me.AdapterAperturaCaja.Update(Me.DataSetAperturaCaja1.aperturacaja)
            '        Me.AdapterDenominacionesApertura.Update(Me.DataSetAperturaCaja1.Apertura_Denominaciones)
            '        Me.AdapterAperturaTotalTope.Update(Me.DataSetAperturaCaja1.Apertura_Total_Tope)
            '        Me.DataSetAperturaCaja1.AcceptChanges()

            '        Trans.Commit()
            '        Return True
            '    Catch ex As Exception
            '        Trans.Rollback()
            '        MsgBox(ex.Message, MsgBoxStyle.Critical)
            '    End Try
            'End Function
        End Sub

        Public Sub anularAperturaCaja()

            'Function Anular_Apertura()
            '    If MessageBox.Show("¿Desea anular la Apertura de caja?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            '        Me.RadioButton1.Checked = True
            '        Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja").Current("Estado") = "C"
            '        Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja").EndCurrentEdit()
            '        RegistarApertura()
            '        MsgBox("Apertura Anulada", MsgBoxStyle.Information)
            '        Me.Limpiar()
            '    End If
            'End Function

        End Sub

        Public Function buscarAperturaCaja(nombre As String,
                                           filtrarActivas As Boolean,
                                           entreFechas As Boolean,
                                           desde As Date,
                                           hasta As Date) As List(Of Modelo.aperturacaja)
            'Private Sub BuscarAperturas()
            '    Dim Fx As New cFunciones
            '    Dim Apertura As String

            '    Apertura = Fx.Buscar_X_Descripcion_Fecha("SELECT NApertura AS Apertura, Nombre, Fecha, num_caja as Caja FROM aperturacaja Order by NApertura Desc", "Nombre", "Fecha", "Buscar Apertura de Caja", Me.SqlConnection1.ConnectionString)
            '    If Apertura <> "" Then
            '        Me.DataSetAperturaCaja1.Apertura_Denominaciones.Clear()
            '        Me.DataSetAperturaCaja1.Apertura_Total_Tope.Clear()
            '        Me.DataSetAperturaCaja1.aperturacaja.Clear()
            '        CargarApertura(Apertura)
            '        CargarTope(Apertura)
            '        CargarDenominacion(Apertura)
            '        Me.ToolBar1.Buttons(4).Enabled = True
            '        Me.ToolBar1.Buttons(2).Enabled = False
            '        Me.ToolBar1.Buttons(3).Enabled = True
            '        Me.GridControl2.Enabled = False
            '        Me.GridControl3.Enabled = False
            '        Me.GridControl1.Enabled = True
            '        Me.GroupBox2.Enabled = True
            '        Me.GroupBox5.Enabled = True
            '        Me.GroupBox3.Enabled = False
            '    End If
            'End Sub
        End Function

        Public Function cargarAperturaCaja(numapertura As Integer) As Modelo.aperturacaja

            'Function CargarApertura(ByVal Numapertura As String)
            '            Dim cnn As SqlConnection = Nothing

            '            ' Dentro de un Try/Catch por si se produce un error
            '            Try
            '                Dim sConn As String = CadenaConexionSeePOS
            '                cnn = New SqlConnection(sConn)
            '                cnn.Open()
            '                ' Creamos el comando para la consulta
            '                Dim cmd As SqlCommand = New SqlCommand
            '                Dim sel As String = "SELECT * FROM aperturacaja" &
            '            " where NApertura  = @Id"
            '                cmd.CommandText = sel
            '                cmd.Connection = cnn
            '                cmd.CommandType = CommandType.Text
            '                cmd.CommandTimeout = 90
            '                cmd.Parameters.Add(New SqlParameter("@Id", SqlDbType.BigInt))
            '                cmd.Parameters("@Id").Value = Numapertura
            '                Dim da As New SqlDataAdapter
            '                da.SelectCommand = cmd
            '                da.Fill(Me.DataSetAperturaCaja1.aperturacaja)
            '            Catch ex As System.Exception
            '                MsgBox(ex.ToString)
            '            Finally
            '                If Not cnn Is Nothing Then
            '                    cnn.Close()
            '                End If
            '            End Try
            '        End Function


            '        Function CargarDenominacion(ByVal Numapertura As String)
            '            Dim cnn As SqlConnection = Nothing

            '            ' Dentro de un Try/Catch por si se produce un error
            '            Try
            '                Dim sConn As String = CadenaConexionSeePOS
            '                cnn = New SqlConnection(sConn)
            '                cnn.Open()
            '                ' Creamos el comando para la consulta
            '                Dim cmd As SqlCommand = New SqlCommand
            '                Dim sel As String = "SELECT * FROM Apertura_Denominaciones" &
            '            " where Id_Apertura  = @Id"
            '                cmd.CommandText = sel
            '                cmd.Connection = cnn
            '                cmd.CommandType = CommandType.Text
            '                cmd.CommandTimeout = 90
            '                cmd.Parameters.Add(New SqlParameter("@Id", SqlDbType.BigInt))
            '                cmd.Parameters("@Id").Value = Numapertura
            '                Dim da As New SqlDataAdapter
            '                da.SelectCommand = cmd
            '                da.Fill(Me.DataSetAperturaCaja1.Apertura_Denominaciones)

            '                For I As Integer = 0 To Me.DataSetAperturaCaja1.Denominacion_Moneda.Count - 1
            '                    Me.DataSetAperturaCaja1.Denominacion_Moneda.Rows(I).Item("Total") = Me.DataSetAperturaCaja1.Apertura_Denominaciones.Rows(I).Item("Monto")
            '                    Me.DataSetAperturaCaja1.Denominacion_Moneda.Rows(I).Item("Cantidad") = Me.DataSetAperturaCaja1.Apertura_Denominaciones.Rows(I).Item("Cantidad")
            '                Next
            '                CalcularTotales()

            '            Catch ex As System.Exception
            '                MsgBox(ex.ToString)
            '            Finally
            '                If Not cnn Is Nothing Then
            '                    cnn.Close()
            '                End If
            '            End Try
            '        End Function

            '        Function CargarTope(ByVal Numapertura As String)
            '            Dim cnn As SqlConnection = Nothing

            '            ' Dentro de un Try/Catch por si se produce un error
            '            Try
            '                Dim sConn As String = CadenaConexionSeePOS
            '                cnn = New SqlConnection(sConn)
            '                cnn.Open()
            '                ' Creamos el comando para la consulta
            '                Dim cmd As SqlCommand = New SqlCommand
            '                Dim sel As String = "SELECT * FROM Apertura_Total_Tope" &
            '            " where NApertura  = @Id"
            '                cmd.CommandText = sel
            '                cmd.Connection = cnn
            '                cmd.CommandType = CommandType.Text
            '                cmd.CommandTimeout = 90
            '                cmd.Parameters.Add(New SqlParameter("@Id", SqlDbType.BigInt))
            '                cmd.Parameters("@Id").Value = Numapertura
            '                Dim da As New SqlDataAdapter
            '                da.SelectCommand = cmd
            '                da.Fill(Me.DataSetAperturaCaja1.Apertura_Total_Tope)
            '            Catch ex As System.Exception
            '                MsgBox(ex.ToString)
            '            Finally
            '                If Not cnn Is Nothing Then
            '                    cnn.Close()
            '                End If
            '            End Try
            '        End Function

        End Function


    End Class
End Namespace