Namespace Logica
    Public Class Presentaciones


        Private db As Datos.Class.Presentaciones

        Sub New()
            Me.db = New Datos.Class.Presentaciones
        End Sub

        Public Function Buscar(porDescripcion As Boolean, Filtro As String) As List(Of Datos.Models.Presentacione)
            Return Me.db.Buscar(porDescripcion, Filtro)
        End Function

        Public Function Crear(presentacion As Datos.Models.Presentacione) As String
            Return Me.db.Crear(presentacion)
        End Function

        Public Function Editar(id As Long, presentacion As Datos.Models.Presentacione) As String
            Return Me.db.Editar(id, presentacion)
        End Function

        Public Function Eliminar(id As Long) As String
            Return Me.db.Borrar(id)
        End Function
    End Class

End Namespace
