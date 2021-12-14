Imports Negocio.Utilidades
Namespace Logica
    Public Class Familia

        Public Function Buscar(descripcion As String) As List(Of Modelo.familias)
            Dim familia As New List(Of Modelo.familias)
            'valor = Fx.BuscarDatos("Select Codigo,Descripcion From Familia", "Descripcion", "Buscar Familia...", Me.SqlConnection1.ConnectionString)
            Return familia
        End Function

        Public Sub Crear(familia As Modelo.familias)
            If estaVacio(familia.Descripcion) Or
                estaVacio(familia.CuentaGra) Or
                estaVacio(familia.CuentaExe) Or
                estaVacio(familia.CuentaCosto) Then
                'no pasa validacion datos vacios

            End If

            'Me.Adapter_Familias.Update(Me.DataSetFamilia1, "Familia")
            'Me.Adapter_Subfamilias.Update(Me.DataSetFamilia1, "SubFamilias")
            'Trans.Commit()
            'Me.DataSetFamilia1.AcceptChanges()
        End Sub

        Public Sub Editar(familia As Modelo.familias)
            If estaVacio(familia.Descripcion) Or
                estaVacio(familia.CuentaGra) Or
                estaVacio(familia.CuentaExe) Or
                estaVacio(familia.CuentaCosto) Then
                'no pasa validacion datos vacios

            End If

            'Me.Adapter_Familias.Update(Me.DataSetFamilia1, "Familia")
            'Me.Adapter_Subfamilias.Update(Me.DataSetFamilia1, "SubFamilias")
            'Trans.Commit()
            'Me.DataSetFamilia1.AcceptChanges()
        End Sub

        Public Sub Eliminar(familia As Modelo.familias)
            'valida que no exista productos relacionados

            'Cargo el codigo de la familia al que pertenecen las familias que se eliminaran
            'Dim strCodigoFamilia As String = Me.BindingContext(DataSetFamilia1, "Familia").Current("Codigo")
            'Dim strMensaje As String = conexion.DeleteRecords("SubFamilias", "CodigoFamilia =" & strCodigoFamilia, strModulo)

            'Me.BindingContext(Me.DataSetFamilia1, "Familia").RemoveAt(Me.BindingContext(Me.DataSetFamilia1, "Familia").Position)
            'Me.BindingContext(Me.DataSetFamilia1, "Familia").EndCurrentEdit()
            'Me.Adapter_Familias.Update(Me.DataSetFamilia1, "Familia")
        End Sub

    End Class
End Namespace

