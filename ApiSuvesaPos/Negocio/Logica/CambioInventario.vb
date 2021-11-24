Namespace Logica
    Public Class CambioInventario

        Public Property Inventario As New Logica.Inventario

        Public Function cargarCambioInventario() As List(Of Modelo.cambioinventario)

            'Dim strSQL As String = "select * from viewCambiosInventario Where aplicado = 0"
            'Dim dt As New DataTable
            'cFunciones.Llenar_Tabla_Generico(strSQL, dt, CadenaConexionSeePOS)
            'Me.viewCambios.DataSource = dt

        End Function

        Public Sub crearCambioInventario(cambioinventario As Modelo.cambioinventario)

            'Public Sub GuardarCambio()
            '    'guarda el cambio
            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '    db.AddParametro("@IdUsuario", Me.IdUsuario)
            '    db.AddParametro("@Fecha", Date.Now)
            '    db.AddParametro("@CodigoFacturado", Me.CodigoFacturo)
            '    db.AddParametro("@CantidadFacturado", Me.txtCantidadFacturado.Text)
            '    db.AddParametro("@CodigoEntregado", Me.CodigoEntrego)
            '    db.AddParametro("@CantidadEntregado", Me.txtCantidadEntegado.Text)
            '    db.AddParametro("@Diferencia", CDec(Me.txtDiferencia.Text))
            '    db.AddParametro("@Aplicado", False)
            '    db.Ejecutar("insert into CAmbioInventario(IdUsuario,Fecha,CodigoFacturado,CantidadFacturado,CodigoEntregado,CantidadEntregado,Diferencia,Aplicado) Values(@IdUsuario,@Fecha,@CodigoFacturado,@CantidadFacturado,@CodigoEntregado,@CantidadEntregado,@Diferencia,@Aplicado)", CommandType.Text)
            '    Me.Close()
            'End Sub

        End Sub

        Public Sub aplicarCambiosInventario(cambios As List(Of Modelo.cambioinventario))

            'Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '    For Each row As DataGridViewRow In Me.viewCambios.Rows
            '        If row.Cells("Aplicado").Value = True Then
            '            db.AddParametro("@Id", row.Cells("Id").Value)
            '            db.Ejecutar("AplicarCambioInventario")
            '        End If
            '    Next
            '    Me.Close()
            'End Sub

        End Sub

        Public Sub eliminarCambiosInventario(id As Integer)



        End Sub

    End Class
End Namespace