Namespace Logica
    Public Class Marca


        Public Function Buscar(marca As String) As List(Of Modelo.marca)
            Dim bodega As New List(Of Modelo.marca)
            'valor = Fx.BuscarDatos("Select CodMarca, Marca from Marcas", "Marca", "Buscar Marcas...", Me.SqlConnection.ConnectionString)
            Return bodega
        End Function

        Public Sub Crear(bodega As Modelo.marca)
            'Try
            '    Me.BindingContext(Me.DataSetMarca.Marcas).EndCurrentEdit()
            '    Me.DaMarca.Update(Me.DataSetMarca.Marcas)
            'Catch ex As Exception
            '    System.Windows.Forms.MessageBox.Show(ex.Message)
            'End Try
        End Sub

        Public Sub Editar(bodega As Modelo.marca)
            'Try
            '    Me.BindingContext(Me.DataSetMarca.Marcas).EndCurrentEdit()
            '    Me.DaMarca.Update(Me.DataSetMarca.Marcas)
            'Catch ex As Exception
            '    System.Windows.Forms.MessageBox.Show(ex.Message)
            'End Try
        End Sub

        Public Sub Eliminar(bodega As Modelo.marca)
            'valida que no exista productos relacionados

            'BindingContext(DataSet, Tabla).RemoveAt(BindingContext(DataSet, Tabla).Position)
            'BindingContext(DataSet, Tabla).EndCurrentEdit()
            'Adaptador.Update(DataSet, Tabla)
            'If RecargarAdatador Then Adaptador.Update(DataSet, Tabla)
            'Adaptador.Fill(DataSet, Tabla)
        End Sub

    End Class

End Namespace
