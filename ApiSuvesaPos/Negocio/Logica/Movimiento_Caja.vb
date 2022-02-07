Namespace Logica
    Public Class Movimiento_Caja

        Private db As Datos.Class.Movimiento_Caja

        Public Function Crear(movimiento_caja As Datos.Models.MovimientoCaja) As String

            Return Me.db.Crear(movimiento_caja)

            'Datos.Models.MovimientoCaja
            'Datos.Models.MovimientoCaja

            'Sub Registrar()
            '    Try
            '        If MsgBox("¿Desea Registrar el Movimiento de Caja?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '            Me.BindingContext(Me.DataSet_MovimientoCaja1, "Movimiento_Caja").EndCurrentEdit()
            '            Me.Adapter_MovimientoCaja.Update(Me.DataSet_MovimientoCaja1, "Movimiento_Caja")
            '            MsgBox("Datos Ingresados Satisfactoriamente", MsgBoxStyle.Information)

            '            LabelId.Text = IdMovimiento()
            '            'open_cashdrawer()
            '            If MsgBox("¿Desea imprimir el Movimiento de Caja?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '                Me.imprimir()
            '            End If
            '            Me.DataSet_MovimientoCaja1.Movimiento_Caja.Clear()
            '            Me.ToolBar1.Buttons(0).Text = "Nuevo"
            '            Me.ToolBar1.Buttons(0).ImageIndex = 0

            '            GroupBox1.Enabled = False
            '            ComboBo_Moneda.Enabled = False
            '            Calc_Monto.Enabled = False
            '            Text_Observaciones.Enabled = False
            '        End If

            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        MsgBox("Error al Ingresar Los datos, intentelo de nuevo", MsgBoxStyle.Critical)
            '    End Try
            'End Sub

        End Function

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.MovimientoCaja)
            Return Me.db.Buscar(porNombre, Filtro)
            'identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("SELECT Id, Monto, Observaciones, Fecha FROM Movimiento_Caja Order by Fecha Desc ", "Observaciones", "Fecha", "Buscar Movimiento de Caja"))
            'buscando = True
            'If identificador = 0.0 Then ' si se dio en el boton de cancelar
            '    buscando = False
            '    Exit Sub
            'End If
            'Fx.Cargar_Tabla_Generico(Me.Adapter_MovimientoCaja, "SELECT * FROM Movimiento_Caja WHERE (Id =" & identificador & " )")
            'Me.Adapter_MovimientoCaja.Fill(Me.DataSet_MovimientoCaja1, "Movimiento_Caja")

        End Function

        Public Function Anular(id As Integer) As String
            Return "algo"
            'Sub Anular()
            '    Try
            '        If MsgBox("Desea Anular este Movimiento de Caja", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '            Me.Check_Anulado.Checked = True
            '            Me.BindingContext(Me.DataSet_MovimientoCaja1, "Movimiento_Caja").EndCurrentEdit()
            '            Me.Adapter_MovimientoCaja.Update(Me.DataSet_MovimientoCaja1, "Movimiento_Caja")
            '            MsgBox("Factura Anulada Satisfactoriamente", MsgBoxStyle.Information)
            '        End If

            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        MsgBox("Problemas al Anular la Factura, intentelo de nuevo", MsgBoxStyle.Critical)
            '    End Try
            'End Sub

        End Function

    End Class
End Namespace