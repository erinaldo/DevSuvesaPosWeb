Namespace Logica
    Public Class PreTomaGeneral

        Private db As Datos.Class.PreTomaGeneral

        Sub New()
            Me.db = New Datos.Class.PreTomaGeneral
        End Sub

        Public Function Crear(pretoma As Datos.Models.PreTomaGeneral) As String
            Return Me.db.Crear(pretoma)
        End Function

        Public Function Editar(id As Decimal, pretoma As Datos.Models.PreTomaGeneral) As String
            Return Me.db.Editar(id, pretoma)
        End Function

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.PreTomaGeneral)
            Return Me.db.Buscar(porNombre, Filtro)
        End Function

    End Class
End Namespace

