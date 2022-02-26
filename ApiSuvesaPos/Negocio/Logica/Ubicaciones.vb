Imports Negocio.Utilidades
Namespace Logica
    Public Class Ubicaciones

        Private db As Datos.Class.Ubicaciones

        Sub New()
            Me.db = New Datos.Class.Ubicaciones
        End Sub

        Public Function Buscar(pornombre As Boolean, filtro As String) As List(Of Datos.Models.Ubicacione)
            Return Me.db.Buscar(pornombre, filtro)
        End Function

        Public Function Crear(ubicacion As Datos.Models.Ubicacione) As String
            Return Me.db.Crear(ubicacion)
        End Function

        Public Function Editar(id As Decimal, ubicacion As Datos.Models.Ubicacione) As String
            Dim res As String = Me.db.Editar(id, ubicacion)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

        Public Function Eliminar(id As Decimal) As String
            Dim res As String = Me.db.Borrar(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

    End Class

End Namespace
