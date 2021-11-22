Namespace Logica
    Public Class TemperaturaCamara



        Public Function cargarTemperaturaCamara(entreFechas As Boolean,
                                                desde As Date,
                                                hasta As Date)

            'Private Sub CargarRegistrosTemperatura()
            '    Dim dt As New DataTable
            '    cFunciones.Llenar_Tabla_Generico("Select * from viewTemperaturaCamara order by fecha desc", dt, CadenaConexionSeePOS)
            '    Me.viewDatos.DataSource = dt
            '    Me.viewDatos.Columns("Id").Visible = False
            '    Me.viewDatos.Columns("Id_Usuario").Visible = False
            '    Me.viewDatos.Columns("Fecha").DefaultCellStyle.Format = "dd/MM/yyyy"
            '    Me.viewDatos.Columns("Fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '    Me.viewDatos.Columns("Temperatura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            'End Sub

        End Function

        Public Sub crearTermperaturaCamara(temperaturacamara As Modelo.temperaturacamara)

            'Private Sub AgregarNuevoRegistro()
            '    Dim Fecha As Date
            '    Dim Id_Usuario As String
            '    Dim Temperatura As String

            '    Fecha = Me.dtpFecha.Value
            '    Id_Usuario = Me.Id_UsuarioCreo
            '    Temperatura = Me.txtTemperatura.Text

            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '    If Me.Id_RegistroTemperaturaCamara = 0 Then
            '        If Me.PasaValidaRegistro = True Then
            '            db.Ejecutar("Insert into temperaturacamara(Fecha,Id_Usuario,Temperatura, Horario) Values('" & Fecha & "','" & Id_Usuario & "','" & Temperatura & "', '" & Me.cboHorario.Text & "')", CommandType.Text)
            '        End If
            '    Else
            '        db.Ejecutar("Update temperaturacamara set fecha = '" & Fecha & "', Temperatura = '" & Temperatura & "' Where Id = " & Me.Id_RegistroTemperaturaCamara, CommandType.Text)
            '    End If
            '    Me.CargarRegistrosTemperatura()
            'End Sub

        End Sub

        Public Sub editarTermperaturaCamara(temperaturacamara As Modelo.temperaturacamara)

            'Private Sub AgregarNuevoRegistro()
            '    Dim Fecha As Date
            '    Dim Id_Usuario As String
            '    Dim Temperatura As String

            '    Fecha = Me.dtpFecha.Value
            '    Id_Usuario = Me.Id_UsuarioCreo
            '    Temperatura = Me.txtTemperatura.Text

            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '    If Me.Id_RegistroTemperaturaCamara = 0 Then
            '        If Me.PasaValidaRegistro = True Then
            '            db.Ejecutar("Insert into temperaturacamara(Fecha,Id_Usuario,Temperatura, Horario) Values('" & Fecha & "','" & Id_Usuario & "','" & Temperatura & "', '" & Me.cboHorario.Text & "')", CommandType.Text)
            '        End If
            '    Else
            '        db.Ejecutar("Update temperaturacamara set fecha = '" & Fecha & "', Temperatura = '" & Temperatura & "' Where Id = " & Me.Id_RegistroTemperaturaCamara, CommandType.Text)
            '    End If
            '    Me.CargarRegistrosTemperatura()
            'End Sub

        End Sub

    End Class
End Namespace