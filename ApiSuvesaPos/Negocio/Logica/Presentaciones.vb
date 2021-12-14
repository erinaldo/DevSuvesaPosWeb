Namespace Logica
    Public Class Presentaciones
        Public Function Buscar(presentacion As String) As List(Of Modelo.presentaciones)
            Dim presentaciones As New List(Of Modelo.presentaciones)
            'valor = Fx.BuscarDatos("Select CodMarca, Marca from Marcas", "Marca", "Buscar Marcas...", Me.SqlConnection.ConnectionString)
            Return presentaciones
        End Function

        Public Sub Crear(presentacion As Modelo.presentaciones)

            'Me.BindingContext(DataSetPresentaciones, "Presentaciones").EndCurrentEdit()
            'Me.DaPresentaciones.Update(DataSetPresentaciones, "Presentaciones")
        End Sub

        Public Sub Editar(presentacion As Modelo.presentaciones)

            'Me.BindingContext(DataSetPresentaciones, "Presentaciones").EndCurrentEdit()
            'Me.DaPresentaciones.Update(DataSetPresentaciones, "Presentaciones")
        End Sub

        Public Sub Eliminar(presentacion As Modelo.presentaciones)
            'valida que no exista productos relacionados

            'Me.BindingContext(Me.DataSetPresentaciones, "Presentaciones").RemoveAt(Me.BindingContext(Me.DataSetPresentaciones, "Presentaciones").Position)
            'Me.BindingContext(Me.DataSetPresentaciones, "Presentaciones").EndCurrentEdit()
            'Registrar()
        End Sub
    End Class

End Namespace
