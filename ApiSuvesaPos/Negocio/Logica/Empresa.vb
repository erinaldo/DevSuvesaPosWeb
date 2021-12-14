Namespace Logica
    Public Class Empresa

        Public Function Buscar(filtro As String) As List(Of Modelo.empresa)

            'Public Function buscar(ByVal texto As String) As DataTable
            '    Try
            '        conectado()
            '        cmd = New SqlCommand("Consultar_empresa")
            '        cmd.CommandType = CommandType.StoredProcedure
            '        cmd.Connection = cnn
            '        cmd.Parameters.AddWithValue("@id", texto)
            '        If cmd.ExecuteNonQuery Then
            '            Dim dt As New DataTable
            '            Dim da As New SqlDataAdapter(cmd)
            '            da.Fill(dt)
            '            Return dt
            '        Else
            '            Return Nothing
            '        End If
            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        Return Nothing
            '    Finally
            '        desconectado()
            '    End Try
            'End Function

        End Function

        Public Sub Crear(empresa As Modelo.empresa)

            'Public Function insertar(ByVal dts As vempresa) As Boolean
            '    Try
            '        conectado()
            '        cmd = New SqlCommand("Insertar_empresa")
            '        cmd.CommandType = CommandType.StoredProcedure
            '        cmd.Connection = cnn
            '        'cmd.Parameters.AddWithValue("@id", dts.gid)
            '        cmd.Parameters.AddWithValue("@empresa", dts.gdescripcion)

            '        If cmd.ExecuteNonQuery Then
            '            Return True
            '        Else
            '            Return False
            '        End If

            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        Return False
            '    Finally
            '        desconectado()
            '    End Try
            'End Function

        End Sub

        Public Sub Editar(empresa As Modelo.empresa)

            'Public Function editar(ByVal dts As vempresa) As Boolean
            '    Try
            '        conectado()
            '        cmd = New SqlCommand("Modificar_empresa")
            '        cmd.CommandType = CommandType.StoredProcedure
            '        cmd.Connection = cnn
            '        cmd.Parameters.AddWithValue("@id", dts.gid)
            '        cmd.Parameters.AddWithValue("@empresa", dts.gdescripcion)
            '        If cmd.ExecuteNonQuery Then
            '            Return True
            '        Else
            '            Return False
            '        End If
            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        Return False
            '    Finally
            '        desconectado()
            '    End Try
            'End Function

        End Sub

        Public Sub Eliminar(id As Integer)

            'Public Function eliminar(ByVal dts As vempresa) As Boolean
            '    Try
            '        conectado()
            '        cmd = New SqlCommand("Eliminar_empresa")
            '        cmd.CommandType = CommandType.StoredProcedure
            '        cmd.Connection = cnn
            '        cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = dts.gid
            '        If cmd.ExecuteNonQuery Then
            '            Return True
            '        Else
            '            Return False
            '        End If

            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        Return False
            '    Finally
            '        desconectado()
            '    End Try

            'End Function

        End Sub

    End Class
End Namespace