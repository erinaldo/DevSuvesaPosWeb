Namespace Logica
    Public Class ArqueoCajas

        'cargar cls de tipotarjeta  
        Public Property AperturaCaja As New Logica.AperturaCaja
        Public Property Moneda As New Logica.Monedas
        Public Property Denominacion_Moneda As New Logica.Denominacion_Moneda

        Public Function buscarArqueoCajas() As List(Of Modelo.arqueocajas)

            'Dim cFunciones As New cFunciones
            'Dim Id_ArqueoCaja As String = cFunciones.Buscar_X_Descripcion_Fecha("select cast(Id as varchar) as Arqueo, Cajero,Fecha from ArqueoCajas Order by Id Desc", "Cajero", "Fecha", "Arqueo Caja ....")

            'If Id_ArqueoCaja = Nothing Then

            'Else
            '    Cargar(Id_ArqueoCaja)

        End Function
        Public Function cargarArqueoCajas(idarqueo As Integer) As Modelo.arqueocajas

            'Function Cargar(ByVal IdArqueo As String)
            '    Try
            '        Dim cFunciones As New cFunciones
            '        Me.DataSetArqueo1.ArqueoEfectivo.Clear()
            '        Me.DataSetArqueo1.ArqueoTarjeta.Clear()
            '        Me.DataSetArqueo1.ArqueoCajas.Clear()

            '        cFunciones.Llenar_Tabla_Generico("Select * from ArqueoCajas Where Id = " & IdArqueo, Me.DataSetArqueo1.ArqueoCajas)
            '        cFunciones.Llenar_Tabla_Generico("Select * from ArqueoTarjeta Where Id_Arqueo = " & IdArqueo, Me.DataSetArqueo1.ArqueoTarjeta)
            '        cFunciones.Llenar_Tabla_Generico("Select * from ArqueoEfectivo Where Id_Arqueo = " & IdArqueo, Me.DataSetArqueo1.ArqueoEfectivo)
            '        Me.Cargando()
            '        Return True

            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        Return False
            '    End Try
            'End Function

        End Function
        Public Sub crearArqueoCajas(arqueocajas As Modelo.arqueocajas)

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
        Public Sub editarArqueoCajas(arqueocajas As Modelo.arqueocajas)

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
        Public Sub anularArqueoCajas(idarqueo As Integer)

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