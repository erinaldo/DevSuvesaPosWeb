Imports Negocio.Utilidades
Namespace Logica
    Public Class Ubicaciones

        Public Function Buscar() As List(Of Modelo.ubicaciones)
            Dim ubicacion As New List(Of Modelo.ubicaciones)
            'cx.Llenar_Tabla_Generico("Select * from familia", Me.DataSetFamilia1.Familia1, Me.SqlConnection1.ConnectionString)
            Return ubicacion
        End Function

        Public Sub Crear(ubicacion As Modelo.ubicaciones)
            If estaVacio(ubicacion.Descripcion) Then
                'no pasa validacion datos vacios

            End If

            'Me.daubicaciones.Update(Me.DataSet_Ubicaciones1, "Ubicaciones")
            'Me.dasububicacion.Update(Me.DataSet_Ubicaciones1, "SubUbicacion")
            'Trans.Commit()
        End Sub

        Public Sub Editar(ubicacion As Modelo.ubicaciones)
            If estaVacio(ubicacion.Descripcion) Then
                'no pasa validacion datos vacios

            End If

            'Me.daubicaciones.Update(Me.DataSet_Ubicaciones1, "Ubicaciones")
            'Me.dasububicacion.Update(Me.DataSet_Ubicaciones1, "SubUbicacion")
            'Trans.Commit()
        End Sub

        Public Sub Eliminar(ubicacion As Modelo.ubicaciones)
            'valida que no exista productos relacionados

            'Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").RemoveAt(Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").Position)
            'Me.BindingContext(Me.DataSet_Ubicaciones1, "Ubicaciones").EndCurrentEdit()
            'Me.Registrar_Ubicacion()
        End Sub

    End Class

End Namespace
