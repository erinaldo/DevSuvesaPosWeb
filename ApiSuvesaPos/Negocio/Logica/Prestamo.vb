Namespace Logica
    Public Class Prestamo

        Private db As Datos.Class.Prestamo

        Sub New()
            Me.db = New Datos.Class.Prestamo
        End Sub

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.Prestamo)
            Return Me.db.Buscar(porNombre, Filtro)
            'Datos.Models.Prestamo
            'Datos.Models.Prestamo

            'Public Function buscar(ByVal texto As String, Optional ByVal _ConsultaBoleta As Boolean = False, Optional ByVal _SPrestamo As Boolean = True) As DataTable
            '    Try
            '        conectado()

            '        If _SPrestamo = True Then
            '            cmd = New SqlCommand("Consultar_SPrestamo")
            '        Else
            '            cmd = New SqlCommand("Consultar_Prestamo")
            '        End If

            '        cmd.CommandType = CommandType.StoredProcedure
            '        cmd.Connection = cnn
            '        cmd.Parameters.AddWithValue("@id", texto)
            '        cmd.Parameters.AddWithValue("@ConsultaBoleta", _ConsultaBoleta)
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

        Public Function Crear(prestamo As Datos.Models.Prestamo) As String
            Return Me.db.Crear(prestamo)
            'Public Function insertar(ByVal dts As vprestamo, _IdUsuarioCreo As String, _BoletaProveedor As String, Optional ByVal _SPrestamo As Boolean = True) As Boolean
            '    Try
            '        conectado()
            '        If _SPrestamo = True Then
            '            cmd = New SqlCommand("Insertar_SPrestamo")
            '        Else
            '            cmd = New SqlCommand("Insertar_Prestamo")
            '        End If
            '        cmd.CommandType = CommandType.StoredProcedure
            '        cmd.Connection = cnn
            '        'cmd.Parameters.AddWithValue("@id", dts.gid)
            '        cmd.Parameters.AddWithValue("@boleta", dts.gboleta)
            '        cmd.Parameters.AddWithValue("@destinatario", dts.gdestinatario)
            '        cmd.Parameters.AddWithValue("@nombre_destinatario", dts.gnombre_destinatario)
            '        cmd.Parameters.AddWithValue("@destino", dts.gdestino)
            '        cmd.Parameters.AddWithValue("@nombre_destino", dts.gnombre_destino)
            '        cmd.Parameters.AddWithValue("@transportista", dts.gtransportista)
            '        cmd.Parameters.AddWithValue("@fecha", dts.gfecha)
            '        cmd.Parameters.AddWithValue("@estado", dts.gestado)
            '        cmd.Parameters.AddWithValue("@anulado", dts.ganulado)
            '        cmd.Parameters.AddWithValue("@entrada", dts.gentrada)
            '        cmd.Parameters.AddWithValue("@salida", dts.gsalida)
            '        cmd.Parameters.AddWithValue("@observacion", dts.gobservacion)
            '        cmd.Parameters.AddWithValue("@Id_UsuariCreo", _IdUsuarioCreo)
            '        cmd.Parameters.AddWithValue("@BoletaProveedor", _BoletaProveedor)
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

        End Function

        Public Function Editar(id As Long, prestamo As Datos.Models.Prestamo) As String
            Dim res As String = Me.db.Editar(id, prestamo)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            'Public Function editar(ByVal dts As vprestamo, _IdUsuarioCreo As String, _BoletaProveedor As String, Optional ByVal _SPrestamo As Boolean = True) As Boolean
            '    Try
            '        conectado()

            '        If _SPrestamo = True Then
            '            cmd = New SqlCommand("Modificar_SPrestamo")
            '        Else
            '            cmd = New SqlCommand("Modificar_Prestamo")
            '        End If

            '        cmd.CommandType = CommandType.StoredProcedure
            '        cmd.Connection = cnn
            '        cmd.Parameters.AddWithValue("@boleta", dts.gboleta)
            '        cmd.Parameters.AddWithValue("@destinatario", dts.gdestinatario)
            '        cmd.Parameters.AddWithValue("@nombre_destinatario", dts.gnombre_destinatario)
            '        cmd.Parameters.AddWithValue("@destino", dts.gdestino)
            '        cmd.Parameters.AddWithValue("@nombre_destino", dts.gnombre_destino)
            '        cmd.Parameters.AddWithValue("@transportista", dts.gtransportista)
            '        cmd.Parameters.AddWithValue("@fecha", dts.gfecha)
            '        cmd.Parameters.AddWithValue("@estado", dts.gestado)
            '        cmd.Parameters.AddWithValue("@anulado", dts.ganulado)
            '        cmd.Parameters.AddWithValue("@entrada", dts.gentrada)
            '        cmd.Parameters.AddWithValue("@salida", dts.gsalida)
            '        cmd.Parameters.AddWithValue("@observacion", dts.gobservacion)
            '        cmd.Parameters.AddWithValue("@Id_UsuariCreo", _IdUsuarioCreo)
            '        cmd.Parameters.AddWithValue("@BoletaProveedor", _BoletaProveedor)
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

        End Function

        Public Function Eliminar(id As Long) As String
            Dim res As String = Me.db.Borrar(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            'Public Function eliminar(ByVal dts As vprestamo, Optional ByVal _SPrestamo As Boolean = True) As Boolean
            '    Try
            '        conectado()

            '        If _SPrestamo = True Then
            '            cmd = New SqlCommand("Eliminar_SPrestamo")
            '        Else
            '            cmd = New SqlCommand("Eliminar_Prestamo")
            '        End If

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

        End Function

        Public Sub Entregado()

            'Public Function entregado(ByVal dts As vprestamo) As Boolean
            '    Try
            '        conectado()
            '        cmd = New SqlCommand("entregado_prestamo")
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