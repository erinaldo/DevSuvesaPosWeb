Imports Negocio.Utilidades
Namespace Logica
    Public Class Ubicaciones

        Public Function buscarUbicacion(descripcion As String) As List(Of Modelo.ubicaciones)
            Dim ubicacion As New List(Of Modelo.ubicaciones)
            'Me.daubicaciones.Fill(Me.DataSet_Ubicaciones1, "ubicaciones")
            Return ubicacion
        End Function

        Public Function cargarUbicacion() As List(Of Modelo.ubicaciones)
            Dim ubicacion As New List(Of Modelo.ubicaciones)
            'cx.Llenar_Tabla_Generico("Select * from familia", Me.DataSetFamilia1.Familia1, Me.SqlConnection1.ConnectionString)
            Return ubicacion
        End Function

        Public Function cargarSubUbicacion(codigoUbicacion As Integer) As List(Of Modelo.subUbicacion)
            Dim subUbicacion As New List(Of Modelo.subUbicacion)
            'Me.dasububicacion.Fill(Me.DataSet_Ubicaciones1, "SubUbicacion")
            Return subUbicacion
        End Function

        Public Sub crearUbicacion(ubicacion As Modelo.ubicaciones)
            If estaVacio(ubicacion.Descripcion) Then
                'no pasa validacion datos vacios

            End If

            'Me.daubicaciones.Update(Me.DataSet_Ubicaciones1, "Ubicaciones")
            'Me.dasububicacion.Update(Me.DataSet_Ubicaciones1, "SubUbicacion")
            'Trans.Commit()
        End Sub

        Public Sub editarUbicacion(ubicacion As Modelo.ubicaciones)
            If estaVacio(ubicacion.Descripcion) Then
                'no pasa validacion datos vacios

            End If

            'Me.daubicaciones.Update(Me.DataSet_Ubicaciones1, "Ubicaciones")
            'Me.dasububicacion.Update(Me.DataSet_Ubicaciones1, "SubUbicacion")
            'Trans.Commit()
        End Sub

        Public Sub eliminarUbicacion(ubicacion As Modelo.ubicaciones)
            'valida que no exista productos relacionados

            'Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").RemoveAt(Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").Position)
            'Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").EndCurrentEdit()
            'Me.Registrar_Ubicacion()
        End Sub

    End Class

End Namespace
