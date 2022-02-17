Namespace Logica
    Public Class Empaquetado


        Private db As Datos.Class.Empaquetado

        Sub New()
            Me.db = New Datos.Class.Empaquetado
        End Sub

        Public Function cargarEmpaquetado() As List(Of Datos.Models.Empaquetado)

            'Public Sub cargar()
            '    Timer1.Enabled = True

            '    If cbPantallas.Text = "NINGUNA" Then
            '        Dim marca As Integer = Me.GetQuimicos
            '        If marca > 0 Then
            '            cFunciones.Llenar_Tabla_Generico("select id_venta_detalle, Codarticulo, Descripcion, Cantidad, DATEDIFF(MI, fecha ,GETDATE()) as minutos, cast (0 as bit) as Selección, codmarca, Id_Factura, Num_Factura ,devoluciones,anulado,nota_pantalla from detalle_empaquetado Where codmarca <> " & marca & " order by minutos ", dts, GetSetting("SeeSOFT", "SeePOs", "Conexion"))
            '        Else
            '            cFunciones.Llenar_Tabla_Generico("select id_venta_detalle, Codarticulo, Descripcion, Cantidad, DATEDIFF(MI, fecha ,GETDATE()) as minutos, cast (0 as bit) as Selección, codmarca, Id_Factura, Num_Factura ,devoluciones,anulado,nota_pantalla from detalle_empaquetado order by minutos ", dts, GetSetting("SeeSOFT", "SeePOs", "Conexion"))
            '        End If
            '    Else
            '        Dim marca As Integer = cbPantallas.SelectedValue
            '        cFunciones.Llenar_Tabla_Generico("select id_venta_detalle, Codarticulo, Descripcion, Cantidad, DATEDIFF(MI, fecha ,GETDATE()) as minutos, cast (0 as bit) as Selección, codmarca, Id_Factura, Num_Factura, devoluciones,anulado,nota_pantalla  from detalle_empaquetado where codmarca = " & marca & " order by minutos desc ", dts, GetSetting("SeeSOFT", "SeePOs", "Conexion"))
            '    End If

            '    Me.dgproductos.DataSource = dts
            '    Me.Sonido()

            '    busca_devoluciones()
            '    color_columna()
            '    imagen_nota()
            'End Sub

        End Function

        Public Sub Empaquetar(detalle_empaquetado As List(Of Datos.Models.Empaquetado))

            '    Public Sub procesar()
            '    Dim conec As New Conexion
            '    Dim tiempo As String
            '    Dim empaquetado As String
            '    Dim idventa As String
            '    Dim leyenda As String
            '    Dim factura As String
            '    Try
            '        If verifica_seleccionados() = True Then
            '            frmteclado.ShowDialog()
            '            If frmteclado.conectado = True Then
            '                For i As Integer = 0 To dts.Rows.Count - 1
            '                    If dts.Rows(i).Item("Selección") = True Then
            '                        Dim marca As Integer = cbPantallas.SelectedValue
            '                        Dim quimico As Integer = Me.GetQuimicos

            '                        If marca <> quimico And dts.Rows(i).Item("codmarca") = quimico Then
            '                            dts.Rows(i).Item("Selección") = False
            '                        Else
            '                            idventa = dts.Rows(i).Item("id_venta_detalle")
            '                            tiempo = dts.Rows(i).Item("minutos")
            '                            factura = dts.Rows(i).Item("id_factura")

            '                            tiempo = Pasar_Segundos_a_Horas(tiempo)

            '                            If dts.Rows(i).Item("devoluciones") > 0 Then
            '                                conec.AddNewRecord("empaquetado", "id_venta_detalle,nombre,cedula,fecha,timer,factura, tipo", "'" & idventa & "','" & frmteclado.usu & "','" & frmteclado.ced & "','" & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") & "', '" & tiempo & "' ," & factura & ", 'RE'")
            '                                leyenda = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") & " - " & frmteclado.usu & " Recibio : " & dts.Rows(i).Item("cantidad") & " - " & dts.Rows(i).Item("descripcion")
            '                                conec.UpdateRecords("articulos_ventas_devueltos", "empaquetado = 1", "Consecutivo = " & idventa)
            '                            Else
            '                                conec.AddNewRecord("empaquetado", "id_venta_detalle,nombre,cedula,fecha,timer,factura, tipo", "'" & idventa & "','" & frmteclado.usu & "','" & frmteclado.ced & "','" & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") & "', '" & tiempo & "' ," & factura & ", 'EN'")
            '                                leyenda = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") & " - " & frmteclado.usu & " Empaqueto : " & dts.Rows(i).Item("cantidad") & " - " & dts.Rows(i).Item("descripcion")
            '                                conec.UpdateRecords(Me.TABLA, "empaquetado = 1", "id_venta_detalle = " & idventa)
            '                            End If

            '                            lhistorial.Items.Add(leyenda)
            '                            lhistorial.SelectedItem = leyenda
            '                        End If
            '                    End If
            '                Next
            '            End If
            '            cargar()
            '            Call TiempoEjecutar(tiempo_espera)
            '        End If
            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '    End Try
            'End Sub

        End Sub

    End Class
End Namespace