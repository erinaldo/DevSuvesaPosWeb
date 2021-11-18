Namespace Logica
    Public Class CierraCaja

        'cargar cls de usuarios
        'cargar cls de opcionesdepago
        Public Property Moneda As New Logica.Monedas
        Public Property ArqueoCajas As New Logica.ArqueoCajas

        Public Function buscarCiereCaja() As List(Of Modelo.cierrecaja)

            'Dim cFunciones As New cFunciones
            'Apertura = "0"
            'Dim CierreNumero As String = cFunciones.Buscar_X_Descripcion_Fecha("SELECT CAST(NumeroCierre AS varchar) AS Cierre, Nombre, Fecha FROM cierrecaja Order by NumeroCierre Desc", "Nombre", "Fecha", "Buscando Cierre de Caja...")

            'If CierreNumero = Nothing Then
            '    Exit Sub
            'End If

        End Function

        Public Sub anularCierreCaja(idCiere As Integer)

            'Private Sub Anular()
            '    Dim resp As Integer
            '    If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction
            '    Dim myCommand1 As SqlCommand = SqlConnection1.CreateCommand()
            '    Dim myCommand2 As SqlCommand = SqlConnection1.CreateCommand()

            '    resp = MessageBox.Show("¿Deseas Anular este Cierre?", "SeeSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            '    If resp = 6 Then
            '        myCommand1.CommandText = "UPDATE CierreCaja SET Anulado =  1 WHERE NumeroCierre = " & BindingContext(Me.DataSetCierreCaja1, "CierreCaja").Current("NumeroCierre")
            '        myCommand2.CommandText = "UPDATE aperturacaja SET Estado = '" & "M" & "' WHERE NApertura = " & BindingContext(Me.DataSetCierreCaja1, "CierreCaja").Current("Apertura")
            '        myCommand1.Transaction = Trans
            '        myCommand2.Transaction = Trans
            '        myCommand1.ExecuteNonQuery()
            '        myCommand2.ExecuteNonQuery()
            '        Trans.Commit()
            '        MsgBox("Datos Anulados Correctamente....", MsgBoxStyle.Information, "Atención...")
            '        lblanulado.Visible = True
            '    End If
            'End Sub

        End Sub

        Public Sub crearCierreCaja(cierrecaja As Modelo.cierrecaja)

            'Private Function Registar() As Boolean
            '    If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction
            '    Try
            '        SqlInsertCommand1.Transaction = Trans
            '        SqlUpdateCommand1.Transaction = Trans
            '        SqlInsertCommand2.Transaction = Trans
            '        SqlUpdateCommand2.Transaction = Trans
            '        SqlInsertCommand3.Transaction = Trans
            '        SqlUpdateCommand3.Transaction = Trans
            '        AdapterCierre.Update(Me.DataSetCierreCaja1.cierrecaja)
            '        Apertura = Me.DataSetCierreCaja1.cierrecaja.Rows(0).Item("Apertura")
            '        AdapterCierreTarjeta.Update(Me.DataSetCierreCaja1.CierreCaja_DetTarj)
            '        AdapterCierreMonto.Update(Me.DataSetCierreCaja1.CierreCaja_DetMon)
            '        Trans.Commit()
            '        Return True

            '    Catch eEndEdit As System.Exception
            '        Trans.Rollback()
            '        System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            '        Return False
            '    End Try
            'End Function

            'Private Function CambiarEstadoApertura() As Boolean
            '    If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction

            '    Try
            '        Dim myCommand2 As SqlCommand = SqlConnection1.CreateCommand()
            '        myCommand2.CommandText = "UPDATE aperturacaja SET Estado = '" & "C" & "' WHERE NApertura = " & BindingContext(Me.DataSetCierreCaja1, "cierrecaja").Current("Apertura")
            '        myCommand2.Transaction = Trans
            '        myCommand2.ExecuteNonQuery()
            '        Trans.Commit()
            '        Return True

            '    Catch eEndEdit As System.Exception
            '        Trans.Rollback()
            '        System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            '        Return False
            '    End Try
            'End Function

        End Sub

    End Class
End Namespace