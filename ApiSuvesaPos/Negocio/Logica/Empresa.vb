Namespace Logica
    Public Class Empresa

        Private db As Datos.Class.Empresa

        Sub New()
            Me.db = New Datos.Class.Empresa
        End Sub

        Public Function Buscar(porNombre As Boolean, filtro As String) As List(Of Datos.Models.Empresa)
            Return Me.db.Buscar(porNombre, filtro)
        End Function

        Public Function Crear(empresa As Datos.Models.Empresa) As String
            Return Me.db.Crear(empresa)
        End Function

        Public Function Editar(id As Long, empresa As Datos.Models.Empresa) As String
            Return Me.db.Editar(id, empresa)
        End Function

        Public Function Eliminar(id As Long) As String
            Return Me.db.Borrar(id)
        End Function

    End Class
End Namespace