Namespace Logica
    Public Class PreTomaProveedor

        Private db As Datos.Class.PreTomaProveedor

        Sub New()
            Me.db = New Datos.Class.PreTomaProveedor
        End Sub

        Public Function Crear(pretoma As Datos.Models.PreTomaProveedor) As String
            Return Me.db.Crear(pretoma)
        End Function

        Public Function Editar(id As Decimal, pretoma As Datos.Models.PreTomaProveedor) As String
            Return Me.db.Editar(id, pretoma)
        End Function

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.PreTomaProveedor)
            Return Me.db.Buscar(porNombre, Filtro)
        End Function

    End Class
End Namespace

