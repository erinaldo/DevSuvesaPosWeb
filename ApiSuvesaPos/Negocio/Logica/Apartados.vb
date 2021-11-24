Namespace Logica
    Public Class Apartados


        Public Function cargarApartadosPendientes(porNombre As Boolean,
                                                  porNumero As Boolean,
                                                  filtro As String) As List(Of Modelo.apartados)

            'Private Sub CargarApartados()
            '    Dim strSQL As String = "select * from viewapartadosactivos "
            '    If Me.txtBuscar.Text <> "" Then
            '        If Me.opNombre.Checked = True Then
            '            strSQL += "Where Cliente like '%" & Me.txtBuscar.Text & "%'"
            '        End If
            '        If Me.opApartado.Checked = True Then
            '            strSQL += "Where Apartado = '" & Me.txtBuscar.Text & "'"
            '        End If
            '    End If

            '    Dim dt As New DataTable
            '    cFunciones.Llenar_Tabla_Generico(strSQL, dt, CadenaConexionSeePOS)
            '    Me.viewApartados.DataSource = dt
            '    If Me.viewApartados.Rows.Count > 0 Then
            '        Me.viewApartados.Columns("Total").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
            '        Me.viewApartados.Columns("Total").DefaultCellStyle.Format = "N2"

            '        Me.viewApartados.Columns("Saldo").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
            '        Me.viewApartados.Columns("Saldo").DefaultCellStyle.Format = "N2"

            '        Me.viewApartados.Columns("Fecha").DefaultCellStyle.Format = "d"
            '    End If
            'End Sub

        End Function

    End Class
End Namespace