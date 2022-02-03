Imports Negocio.Utilidades
Namespace Logica
    Public Class Familia

        Private db As Datos.Class.Familia

        Sub New()
            Me.db = New Datos.Class.Familia
        End Sub

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.Familium)

            Return Me.db.Buscar(porNombre, Filtro)
            'Datos.Models.Familium
            'Datos.Models.Familium
        End Function

        Public Function Crear(familia As Datos.Models.Familium) As String
            If estaVacio(familia.Descripcion) Or
                estaVacio(familia.CuentaGra) Or
                estaVacio(familia.CuentaExe) Or
                estaVacio(familia.CuentaCosto) Then
                'no pasa validacion datos vacios
            End If

            Return Me.db.Crear(familia)

            'Me.Adapter_Familias.Update(Me.DataSetFamilia1, "Familia")
            'Me.Adapter_Subfamilias.Update(Me.DataSetFamilia1, "SubFamilias")
            'Trans.Commit()
            'Me.DataSetFamilia1.AcceptChanges()
        End Function

        Public Function Editar(id As Long, familia As Datos.Models.Familium) As String
            If estaVacio(familia.Descripcion) Or
                estaVacio(familia.CuentaGra) Or
                estaVacio(familia.CuentaExe) Or
                estaVacio(familia.CuentaCosto) Then
                'no pasa validacion datos vacios

            End If

            Return Me.db.Editar(id, familia)

            'Me.Adapter_Familias.Update(Me.DataSetFamilia1, "Familia")
            'Me.Adapter_Subfamilias.Update(Me.DataSetFamilia1, "SubFamilias")
            'Trans.Commit()
            'Me.DataSetFamilia1.AcceptChanges()
        End Function

        Public Function Eliminar(id As Long) As String
            'valida que no exista productos relacionados

            Me.db.Borrar(id)

            'Cargo el codigo de la familia al que pertenecen las familias que se eliminaran
            'Dim strCodigoFamilia As String = Me.BindingContext(DataSetFamilia1, "Familia").Current("Codigo")
            'Dim strMensaje As String = conexion.DeleteRecords("SubFamilias", "CodigoFamilia =" & strCodigoFamilia, strModulo)

            'Me.BindingContext(Me.DataSetFamilia1, "Familia").RemoveAt(Me.BindingContext(Me.DataSetFamilia1, "Familia").Position)
            'Me.BindingContext(Me.DataSetFamilia1, "Familia").EndCurrentEdit()
            'Me.Adapter_Familias.Update(Me.DataSetFamilia1, "Familia")
        End Function

    End Class
End Namespace

