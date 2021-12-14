Namespace Logica
    Public Class Bodega

        Public Function Buscar() As List(Of Modelo.bodega)
            Dim bodega As New List(Of Modelo.bodega)
            'X = Me.SqlDataAdapterBodegas.Fill(Me.DataSetBodegas, "Bodegas")
            Return bodega
        End Function

        Public Function cargarInventario() As List(Of Modelo.inventario)
            Dim inventario As New List(Of Modelo.inventario)
            ' If X <> 0 Then Me.SqlDataAdapterInventario.Fill(Me.DataSetBodegas, "Inventario")
            Return inventario
        End Function

        Public Sub Crear(bodega As Modelo.bodega)
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

        Public Sub Editar(bodega As Modelo.bodega)
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

        Public Sub Eliminar(bodega As Modelo.bodega)
            'valida que no exista productos relacionados

            'BindingContext(DataSet, Tabla).RemoveAt(BindingContext(DataSet, Tabla).Position)
            'BindingContext(DataSet, Tabla).EndCurrentEdit()
            'Adaptador.Update(DataSet, Tabla)
            'If RecargarAdatador Then Adaptador.Update(DataSet, Tabla)
            'Adaptador.Fill(DataSet, Tabla)
        End Sub


    End Class
End Namespace

