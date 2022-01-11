Namespace Logica
    Public Class Marca

        Private db As Datos.Class.Marcas

        Sub New()
            Me.db = New Datos.Class.Marcas
        End Sub

        Public Function Buscar(porDescripcion As Boolean, Filtro As String) As List(Of Datos.Models.Marca)
            Return Me.db.Buscar(porDescripcion, Filtro)
        End Function

        Public Function Crear(bodega As Datos.Models.Marca) As String
            Return Me.db.Crear(bodega)
        End Function

        Public Function Editar(id As Long, bodega As Datos.Models.Marca) As String
            Return Me.db.Editar(id, bodega)
        End Function

        Public Function Eliminar(id As Long) As String
            Return Me.db.Borrar(id)
        End Function

    End Class

End Namespace
