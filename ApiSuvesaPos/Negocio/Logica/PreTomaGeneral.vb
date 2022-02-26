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
            Dim res As String = Me.db.Editar(id, pretoma)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.PreTomaGeneral)
            Return Me.db.Buscar(porNombre, Filtro)
        End Function

    End Class
End Namespace

