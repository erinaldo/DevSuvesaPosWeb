Namespace Logica
    Public Class Abono_Apartados


        Private db As Datos.Class.AbonosApartados

        Sub New()
            Me.db = New Datos.Class.AbonosApartados
        End Sub

        Public Function cargarAbonosApartados(porIdApartado As Boolean,
                                              porIdAbonoApartado As Boolean,
                                              id As Integer) As List(Of Modelo.abono_apartados)

            'Private Sub CargarAbonos()
            '    Dim dt As New DataTable
            '    cFunciones.Llenar_Tabla_Generico("select a.Id_abonoapartado, a.Num_Recibo, a.Fecha, case a.Anula when 1 then 0 else ad.Saldo_Ant end as Saldo_Ant, case a.Anula when 1 then 0 else ad.Abono end as Abono, case a.Anula when 1 then 0 else ad.Saldo end as Saldo from " & Me.BaseDatos & ".dbo.Abono_Apartados a inner join " & Me.BaseDatos & ".dbo.Abono_apartadosdetalle ad on a.Id_abonoapartado = ad.Id_abonoapartado where ad.apartado = " & Me.IdApartado, dt, CadenaConexionSeePOS)
            '    Me.viewDatos.DataSource = dt
            '    Me.viewDatos.Columns("Id_abonoapartado").Visible = False

            '    Me.viewDatos.Columns("Fecha").DefaultCellStyle.Format = "d"

            '    Me.viewDatos.Columns("Saldo_Ant").DefaultCellStyle.Format = "N2"
            '    Me.viewDatos.Columns("Saldo_Ant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            '    Me.viewDatos.Columns("Abono").DefaultCellStyle.Format = "N2"
            '    Me.viewDatos.Columns("Abono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            '    Me.viewDatos.Columns("Saldo").DefaultCellStyle.Format = "N2"
            '    Me.viewDatos.Columns("Saldo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            '    Me.TotalAbonos = (From x As DataGridViewRow In Me.viewDatos.Rows Select CDec(x.Cells("Abono").Value)).Sum

            '    Me.txtTotalInicial.Text = Me.TotalApartado.ToString("N2")
            '    Me.txtTotalAbonos.Text = Me.TotalAbonos.ToString("N2")
            '    Me.txtTotalPendiente.Text = CDec(Me.TotalApartado - Me.TotalAbonos).ToString("N2")
            'End Sub

        End Function

        Public Sub generarAbonoApartado(id_apartado As Integer,
                                     montoAbono As Decimal,
                                     id_usuario As String,
                                     ByRef id_abonoApartado As Integer,
                                     ByRef reciboabono As Integer)



            ''abono a partado
            ''trans.SetParametro("@BaseDatos", Me.PuntodeVenta)
            'trans.SetParametro("@IdApartado", Me.Id_Apartado)
            'trans.SetParametro("@MontoAbonoApartado", Me.MontoApartado)
            'trans.SetParametro("@Ced_Usuario", Me.Id_Usuario)
            'trans.AddParametrosSalidaInt("@Id_AbonoApartado", Id_AbonoApartado)
            'trans.AddParametrosSalidaInt("@NumRecibo", ReciboAbono)
            'trans.Ejecutar("Generar_AbonoApartado", Me.Id_AbonoApartado, 3, Me.ReciboAbono, 4)
            'Me.Num_Factura = Me.ReciboAbono

        End Sub

    End Class
End Namespace