Namespace Logica
    Public Class ArqueoCajas

        Private db As Datos.Class.ArqueosCajas

        Sub New()
            db = New Datos.Class.ArqueosCajas
        End Sub

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.ArqueoCaja)
            Dim datos As New List(Of Datos.Models.ArqueoCaja)
            datos = Me.db.ObtenerArqueosCajas(porNombre, Filtro)

            Dim Resultado As New List(Of Datos.Models.ArqueoCaja)
            For Each arq As Datos.Models.ArqueoCaja In datos
                Dim Arqueo As New Datos.Models.ArqueoCaja
                Arqueo.Id = arq.Id
                Arqueo.EfectivoColones = arq.EfectivoColones
                Arqueo.EfectivoDolares = arq.EfectivoDolares
                Arqueo.TarjetaColones = arq.TarjetaColones
                Arqueo.TarjetaDolares = arq.TarjetaDolares
                Arqueo.Cheques = arq.Cheques
                Arqueo.ChequesDol = arq.ChequesDol
                Arqueo.DepositoCol = arq.DepositoCol
                Arqueo.DepositoDol = arq.DepositoDol
                Arqueo.Total = arq.Total
                Arqueo.IdApertura = arq.IdApertura
                Arqueo.Fecha = arq.Fecha
                Arqueo.Cajero = arq.Cajero
                Arqueo.Anulado = arq.Anulado
                Arqueo.TipoCambioD = arq.TipoCambioD
                Arqueo.Observaciones = arq.Observaciones
                Arqueo.TarjetaSistema = arq.TarjetaSistema
                Arqueo.OtrasTarjetas = arq.OtrasTarjetas


                For Each det As Datos.Models.ArqueoEfectivo In Me.db.ObtenerArqueosEfectivo(Arqueo.Id)
                    Dim Detalle As New Datos.Models.ArqueoEfectivo
                    Detalle.Id = det.Id
                    Detalle.IdArqueo = det.IdArqueo
                    Detalle.IdDenominacion = det.IdDenominacion
                    Detalle.Monto = det.Monto
                    Detalle.Cantidad = det.Cantidad

                    Arqueo.ArqueoEfectivos.Add(Detalle)
                Next

                For Each det As Datos.Models.ArqueoDeposito In Me.db.ObtenerArqueosDeposito(Arqueo.Id)
                    Dim Detalle As New Datos.Models.ArqueoDeposito
                    Detalle.Id = det.Id
                    Detalle.IdArqueo = det.IdArqueo
                    Detalle.Banco = det.Banco
                    Detalle.Cuenta = det.Cuenta
                    Detalle.Moneda = det.Moneda
                    Detalle.Numero = det.Numero
                    Detalle.Monto = det.Monto
                    Detalle.IdApertura = det.IdApertura
                    Detalle.Tipo = det.Tipo

                    Arqueo.ArqueoDepositos.Add(Detalle)
                Next

                For Each det As Datos.Models.ArqueoTarjetum In Me.db.ObtenerArqueosTarjeta(Arqueo.Id)
                    Dim Detalle As New Datos.Models.ArqueoTarjetum
                    Detalle.Id = det.Id
                    Detalle.IdArqueo = det.IdArqueo
                    Detalle.IdTarjeta = det.IdTarjeta
                    Detalle.Monto = det.Monto

                    Arqueo.ArqueoTarjeta.Add(Detalle)
                Next

                Resultado.Add(Arqueo)
            Next

            Return Resultado

        End Function
        Public Sub Crear(arqueocajas As Modelo.arqueocajas)

            'Function ValidarApertura(ByVal IdArqueo As String) As Boolean
            '    Try
            '        Dim dta As New DataTable
            '        Dim cf As New cFunciones
            '        cf.Llenar_Tabla_Generico("SELECT     dbo.aperturacaja.Estado, dbo.ArqueoCajas.Id, dbo.aperturacaja.NApertura " &
            '                            " FROM         dbo.ArqueoCajas INNER JOIN" &
            '                            " dbo.aperturacaja ON dbo.ArqueoCajas.IdApertura = dbo.aperturacaja.NApertura " &
            '                            " WHERE     (dbo.ArqueoCajas.Id = " & IdArqueo & ")", dta)
            '        If dta.Rows(0).Item("Estado") = "C" Then
            '            MsgBox("El número de Apertura " & dta.Rows(0).Item("NApertura") & " Tiene un Cierre(" & dta.Rows(0).Item("Estado") & ") hecho", MsgBoxStyle.Information, "Atención...")
            '            Return False
            '        End If
            '        Return True
            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        Return False
            '    End Try
            'End Function

            'Function Registrar()
            '    Try
            '        Dim resp As Integer
            '        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            '        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            '        Dim myCommand1 As SqlCommand = SqlConnection1.CreateCommand()

            '        Dim myCommandArqueoTarjeta As SqlCommand = SqlConnection1.CreateCommand()
            '        Dim myCommandArqueoEfectivo As SqlCommand = SqlConnection1.CreateCommand()

            '        If Validar() Then
            '            resp = MsgBox("¿Deseas Guardar los cambios?", MsgBoxStyle.YesNo, "SeeSoft")
            '            If resp = 6 Then
            '                Try
            '                    Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("IdApertura") = NApertura
            '                    Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("Fecha") = Date.Today.ToShortDateString
            '                    Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("Anulado") = 0
            '                    Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("TipoCambioD") = 0
            '                    Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("Cajero") = txtNombreUsuario.Text
            '                    Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").EndCurrentEdit()
            '                    CargarDatos()

            '                    Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").EndCurrentEdit()
            '                    Me.AdapterEfectivo.InsertCommand.Transaction = Trans
            '                    Me.AdapterTarjetas.InsertCommand.Transaction = Trans
            '                    Me.AdapterArqueodeCaja.InsertCommand.Transaction = Trans

            '                    Me.AdapterEfectivo.UpdateCommand.Transaction = Trans
            '                    Me.AdapterTarjetas.UpdateCommand.Transaction = Trans
            '                    Me.AdapterArqueodeCaja.UpdateCommand.Transaction = Trans

            '                    If Me.ToolBarRegistrar.Text = "Actualizar" Then
            '                        myCommandArqueoTarjeta.CommandText = "DELETE ArqueoTarjeta WHERE Id_Arqueo = " & BindingContext(DataSetArqueo1, "ArqueoCajas").Current("Id")
            '                        myCommandArqueoTarjeta.Transaction = Trans
            '                        myCommandArqueoTarjeta.ExecuteNonQuery()

            '                        myCommandArqueoEfectivo.CommandText = "DELETE arqueoEfectivo WHERE Id_Arqueo = " & BindingContext(DataSetArqueo1, "ArqueoCajas").Current("Id")
            '                        myCommandArqueoEfectivo.Transaction = Trans
            '                        myCommandArqueoEfectivo.ExecuteNonQuery()
            '                    End If

            '                    evaluarArqueoTarjetas()
            '                    Me.AdapterArqueodeCaja.Update(Me.DataSetArqueo1, "ArqueoCajas")
            '                    Me.AdapterEfectivo.Update(Me.DataSetArqueo1, "ArqueoEfectivo")
            '                    Me.AdapterTarjetas.Update(Me.DataSetArqueo1, "ArqueoTarjeta")

            '                    myCommand1.CommandText = "UPDATE aperturacaja SET Estado = '" & "M" & "' WHERE NApertura = " & NApertura
            '                    myCommand1.Transaction = Trans
            '                    myCommand1.ExecuteNonQuery()
            '                    Trans.Commit()
            '                    Me.lblCaja.Text = ""
            '                    'Para boton Nuevo
            '                    Me.ToolBarNuevo.Text = "Nuevo"
            '                    Me.ToolBarNuevo.ImageIndex = 0
            '                    'Para boton Acualizar
            '                    Me.ToolBarRegistrar.Enabled = False
            '                    Me.ToolBarEliminar.ImageIndex = 5

            '                    Dim cConexion As New Conexion
            '                    Dim sqlConexionC As New SqlConnection
            '                    sqlConexionC = cConexion.Conectar
            '                    cConexion.SlqExecute(sqlConexionC, "Update ArqueoCajas set TipoCambioD=" & TipoCambioDolar & " where idApertura=" & NApertura)
            '                    cConexion.DesConectar(sqlConexionC)
            '                    sqlConexionC = Nothing
            '                    cConexion = Nothing

            '                    Me.Inhabilitar()
            '                    MsgBox("Datos Ingresados Satisfactoriamente....", MsgBoxStyle.Information, "Atención...")

            '                    If (MsgBox("Desea Imprimir el reporte de Arqueo ", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
            '                        Imprimir()
            '                    End If

            '                Catch eEndEdit As System.Data.NoNullAllowedException
            '                    System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            '                End Try
            '            Else
            '                Me.BindingContext(Me.DataSetArqueo1.ArqueoCajas).CancelCurrentEdit()
            '                Me.DataSetArqueo1.RejectChanges()
            '                'Para boton Nuevo
            '                Me.ToolBar1.Buttons(0).Text = "Nuevo"
            '                Me.ToolBar1.Buttons(0).ImageIndex = 0
            '                'Para boton Acualizar
            '                Me.ToolBarEliminar.Text = "Editar"
            '                Me.ToolBarEliminar.ImageIndex = 5
            '                Me.Inhabilitar()
            '            End If
            '        Else
            '            MsgBox("Debes Ingresar Campos....", MsgBoxStyle.Information, "Atención...")
            '        End If

            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '    End Try
            'End Function

        End Sub
        Public Sub Editar(arqueocajas As Modelo.arqueocajas)

            'Function ValidarApertura(ByVal IdArqueo As String) As Boolean
            '    Try
            '        Dim dta As New DataTable
            '        Dim cf As New cFunciones
            '        cf.Llenar_Tabla_Generico("SELECT     dbo.aperturacaja.Estado, dbo.ArqueoCajas.Id, dbo.aperturacaja.NApertura " &
            '                            " FROM         dbo.ArqueoCajas INNER JOIN" &
            '                            " dbo.aperturacaja ON dbo.ArqueoCajas.IdApertura = dbo.aperturacaja.NApertura " &
            '                            " WHERE     (dbo.ArqueoCajas.Id = " & IdArqueo & ")", dta)
            '        If dta.Rows(0).Item("Estado") = "C" Then
            '            MsgBox("El número de Apertura " & dta.Rows(0).Item("NApertura") & " Tiene un Cierre(" & dta.Rows(0).Item("Estado") & ") hecho", MsgBoxStyle.Information, "Atención...")
            '            Return False
            '        End If
            '        Return True
            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        Return False
            '    End Try
            'End Function

            'Function Registrar()
            '    Try
            '        Dim resp As Integer
            '        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            '        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            '        Dim myCommand1 As SqlCommand = SqlConnection1.CreateCommand()

            '        Dim myCommandArqueoTarjeta As SqlCommand = SqlConnection1.CreateCommand()
            '        Dim myCommandArqueoEfectivo As SqlCommand = SqlConnection1.CreateCommand()

            '        If Validar() Then
            '            resp = MsgBox("¿Deseas Guardar los cambios?", MsgBoxStyle.YesNo, "SeeSoft")
            '            If resp = 6 Then
            '                Try
            '                    Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("IdApertura") = NApertura
            '                    Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("Fecha") = Date.Today.ToShortDateString
            '                    Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("Anulado") = 0
            '                    Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("TipoCambioD") = 0
            '                    Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("Cajero") = txtNombreUsuario.Text
            '                    Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").EndCurrentEdit()
            '                    CargarDatos()

            '                    Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").EndCurrentEdit()
            '                    Me.AdapterEfectivo.InsertCommand.Transaction = Trans
            '                    Me.AdapterTarjetas.InsertCommand.Transaction = Trans
            '                    Me.AdapterArqueodeCaja.InsertCommand.Transaction = Trans

            '                    Me.AdapterEfectivo.UpdateCommand.Transaction = Trans
            '                    Me.AdapterTarjetas.UpdateCommand.Transaction = Trans
            '                    Me.AdapterArqueodeCaja.UpdateCommand.Transaction = Trans

            '                    If Me.ToolBarRegistrar.Text = "Actualizar" Then
            '                        myCommandArqueoTarjeta.CommandText = "DELETE ArqueoTarjeta WHERE Id_Arqueo = " & BindingContext(DataSetArqueo1, "ArqueoCajas").Current("Id")
            '                        myCommandArqueoTarjeta.Transaction = Trans
            '                        myCommandArqueoTarjeta.ExecuteNonQuery()

            '                        myCommandArqueoEfectivo.CommandText = "DELETE arqueoEfectivo WHERE Id_Arqueo = " & BindingContext(DataSetArqueo1, "ArqueoCajas").Current("Id")
            '                        myCommandArqueoEfectivo.Transaction = Trans
            '                        myCommandArqueoEfectivo.ExecuteNonQuery()
            '                    End If

            '                    evaluarArqueoTarjetas()
            '                    Me.AdapterArqueodeCaja.Update(Me.DataSetArqueo1, "ArqueoCajas")
            '                    Me.AdapterEfectivo.Update(Me.DataSetArqueo1, "ArqueoEfectivo")
            '                    Me.AdapterTarjetas.Update(Me.DataSetArqueo1, "ArqueoTarjeta")

            '                    myCommand1.CommandText = "UPDATE aperturacaja SET Estado = '" & "M" & "' WHERE NApertura = " & NApertura
            '                    myCommand1.Transaction = Trans
            '                    myCommand1.ExecuteNonQuery()
            '                    Trans.Commit()
            '                    Me.lblCaja.Text = ""
            '                    'Para boton Nuevo
            '                    Me.ToolBarNuevo.Text = "Nuevo"
            '                    Me.ToolBarNuevo.ImageIndex = 0
            '                    'Para boton Acualizar
            '                    Me.ToolBarRegistrar.Enabled = False
            '                    Me.ToolBarEliminar.ImageIndex = 5

            '                    Dim cConexion As New Conexion
            '                    Dim sqlConexionC As New SqlConnection
            '                    sqlConexionC = cConexion.Conectar
            '                    cConexion.SlqExecute(sqlConexionC, "Update ArqueoCajas set TipoCambioD=" & TipoCambioDolar & " where idApertura=" & NApertura)
            '                    cConexion.DesConectar(sqlConexionC)
            '                    sqlConexionC = Nothing
            '                    cConexion = Nothing

            '                    Me.Inhabilitar()
            '                    MsgBox("Datos Ingresados Satisfactoriamente....", MsgBoxStyle.Information, "Atención...")

            '                    If (MsgBox("Desea Imprimir el reporte de Arqueo ", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
            '                        Imprimir()
            '                    End If

            '                Catch eEndEdit As System.Data.NoNullAllowedException
            '                    System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            '                End Try
            '            Else
            '                Me.BindingContext(Me.DataSetArqueo1.ArqueoCajas).CancelCurrentEdit()
            '                Me.DataSetArqueo1.RejectChanges()
            '                'Para boton Nuevo
            '                Me.ToolBar1.Buttons(0).Text = "Nuevo"
            '                Me.ToolBar1.Buttons(0).ImageIndex = 0
            '                'Para boton Acualizar
            '                Me.ToolBarEliminar.Text = "Editar"
            '                Me.ToolBarEliminar.ImageIndex = 5
            '                Me.Inhabilitar()
            '            End If
            '        Else
            '            MsgBox("Debes Ingresar Campos....", MsgBoxStyle.Information, "Atención...")
            '        End If

            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '    End Try
            'End Function

        End Sub
        Public Sub Anular(idarqueo As Integer)

            'Function Anular()
            '    Try
            '        Dim resp As Integer
            '        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            '        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            '        Dim myCommand1 As SqlCommand = SqlConnection1.CreateCommand()
            '        Dim myCommand2 As SqlCommand = SqlConnection1.CreateCommand()

            '        resp = MessageBox.Show("¿Deseas Anular el Arqueo?", "SeeSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            '        If resp = 6 Then
            '            myCommand2.CommandText = "UPDATE aperturacaja SET Estado = '" & "A" & "' WHERE NApertura = " & Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("IdApertura")
            '            myCommand2.Transaction = Trans
            '            myCommand2.ExecuteNonQuery()

            '            myCommand1.CommandText = "UPDATE ArqueoCajas SET Anulado =  1 WHERE Id = " & Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("Id")
            '            myCommand1.Transaction = Trans
            '            myCommand1.ExecuteNonQuery()

            '            Me.BindingContext(Me.DataSetArqueo1, "ArqueoCajas").Current("IdApertura") = NApertura
            '            Trans.Commit()

            '            MsgBox("Datos Anulados Correctamente....", MsgBoxStyle.Information, "Atención...")
            '            Label7.Visible = True
            '            Me.Inhabilitar()
            '        End If

            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '    End Try
            'End Function

        End Sub

    End Class
End Namespace