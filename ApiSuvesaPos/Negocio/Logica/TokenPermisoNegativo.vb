Namespace Logica
    Public Class TokenPermisoNegativo


        Public Function ConsultarToken() As List(Of TokenPermisoNegativo)

            'Private Sub CargarDatos()
            '    Dim dt As New DataTable
            '    cFunciones.Llenar_Tabla_Generico("Select * from viewTokenSolicitados order by Fecha Desc", dt, CadenaConexionSeePOS)
            '    Me.viewDatos.DataSource = dt
            '    Me.viewDatos.Columns("Id").Visible = False
            '    Me.viewDatos.Columns("IdUsuarioSolicita").Visible = False
            '    Me.viewDatos.Columns("Codigo").Visible = False
            '    Me.viewDatos.Columns("fecha").DefaultCellStyle.Format = "t"
            'End Sub

        End Function


        Public Function SolicitarToken(idusuario As String, codigo As Integer)

            'Private Sub SolicitarPermisoVentaNegativo()
            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '    db.AddParametro("@IdUsuarioSolicita", Me.IdUsuario)
            '    db.AddParametro("@Codigo", Me.Codigo)
            '    db.Ejecutar("spSolicitarTokenVentaNegativa")
            'End Sub

        End Function

        Public Function ValidarToken(idusuario As String, codigo As Integer, token As String) As Boolean

            'Private Function ValidaToken() As Boolean
            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '    Dim dt As New DataTable
            '    db.AddParametro("@IdUsuarioSolicita", Me.IdUsuario)
            '    db.AddParametro("@Codigo", Me.Codigo)
            '    db.AddParametro("@Token", Me.txtClave.Text)
            '    dt = db.Ejecutar("spConsultaToken")
            '    If dt.Rows.Count > 0 Then
            '        Return True
            '    Else
            '        Return False
            '    End If
            'End Function

        End Function



    End Class
End Namespace