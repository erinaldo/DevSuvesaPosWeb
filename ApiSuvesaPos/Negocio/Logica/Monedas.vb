Namespace Logica
    Public Class Monedas
        '****************************************************************************
        'Para el sistema siempre el codigo 1 = colones y el codigo 2 = dolares

        Public Function Buscar(monedaNombre As String) As List(Of Modelo.moneda)
            Dim moneda As New List(Of Modelo.moneda)
            'valor = Fx.BuscarDatos("Select CodMarca, Marca from Marcas", "Marca", "Buscar Marcas...", Me.SqlConnection.ConnectionString)
            Return moneda
        End Function

        Public Sub Crear(moneda As Modelo.moneda)
            'Try
            '    BindingContext(DataSet, Tabla).EndCurrentEdit()
            '    Adaptador.Update(DataSet, Tabla)
            '    If RecargarAdatador Then Adaptador.Fill(DataSet, Tabla)
            '    If ActivarNuevo Then ToolBar1.Buttons(0).Text = "Nuevo" : ToolBar1.Buttons(0).ImageIndex = 0
            '    If VerMsg Then MsgBox("Los datos se actualizaron satisfactoriamente...", MsgBoxStyle.Information, "Atención...")
            'Catch eEndEdit As System.Exception
            '    System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            'End Try
        End Sub

        Public Sub Editar(moneda As Modelo.moneda)
            'Try
            '    BindingContext(DataSet, Tabla).EndCurrentEdit()
            '    Adaptador.Update(DataSet, Tabla)
            '    If RecargarAdatador Then Adaptador.Fill(DataSet, Tabla)
            '    If ActivarNuevo Then ToolBar1.Buttons(0).Text = "Nuevo" : ToolBar1.Buttons(0).ImageIndex = 0
            '    If VerMsg Then MsgBox("Los datos se actualizaron satisfactoriamente...", MsgBoxStyle.Information, "Atención...")
            'Catch eEndEdit As System.Exception
            '    System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            'End Try
        End Sub

        Public Sub Eliminar(moneda As Modelo.moneda)

            'BindingContext(DataSet, Tabla).RemoveAt(BindingContext(DataSet, Tabla).Position)
            'BindingContext(DataSet, Tabla).EndCurrentEdit()
            'Adaptador.Update(DataSet, Tabla)
            'If RecargarAdatador Then Adaptador.Update(DataSet, Tabla)
            'Adaptador.Fill(DataSet, Tabla)
        End Sub



    End Class

End Namespace
