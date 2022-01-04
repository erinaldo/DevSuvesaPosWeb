Namespace Logica
    Public Class ActividadEmpresa

        Private db As New DatosFE.Class.ActividadesEmpresas

        Public Function Buscar() As List(Of DatosFE.Models.EmpresaActividade)
            Return db.ObtenerActividadesEmpresas
        End Function

        Public Function Crear(actividad As DatosFE.Models.EmpresaActividade) As String
            Return Me.db.CrearActividadesEmpresas(actividad)
        End Function

        Public Function Borrar(id As Integer) As String
            Return Me.db.BorrarActividadesEmpresas(id)
        End Function

    End Class
End Namespace