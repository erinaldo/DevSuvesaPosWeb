Namespace Logica
    Public Class Rifa

        Public Property Proveedores As New Logica.Proveedores

        Public Sub Crear(rifa As Modelo.rifa)

            '    Function Registrar()
            '    Try
            '        Me.BindingContext(Me.Dsrifa1.rifa).EndCurrentEdit()
            '        Me.adapte_rifa.Update(Me.Dsrifa1.rifa)
            '        MsgBox("Los datos fueron ingresados correctamente")
            '    Catch ex As Exception
            '        System.Windows.Forms.MessageBox.Show(ex.Message)
            '    End Try
            'End Function

            'Private Sub Guardar_Proveedores(ByVal _IdRifa As String)
            '    Dim db As New GestioDatos()
            '    db.Ejecuta("delete from Rifa_Detalle where IdRifa = " & _IdRifa)

            '    For Each r As DataGridViewRow In Me.viewProveedores.Rows
            '        db.Ejecuta("Insert into Rifa_Detalle(IdRifa,IdProveedor,Nombre) values(" & _IdRifa & ", " & r.Cells(0).Value & ", '" & r.Cells(1).Value & "')")
            '    Next
            'End Sub

        End Sub

        Public Sub Editar(rifa As Modelo.rifa)

            '    Function Registrar()
            '    Try
            '        Me.BindingContext(Me.Dsrifa1.rifa).EndCurrentEdit()
            '        Me.adapte_rifa.Update(Me.Dsrifa1.rifa)
            '        MsgBox("Los datos fueron ingresados correctamente")
            '    Catch ex As Exception
            '        System.Windows.Forms.MessageBox.Show(ex.Message)
            '    End Try
            'End Function

            'Private Sub Guardar_Proveedores(ByVal _IdRifa As String)
            '    Dim db As New GestioDatos()
            '    db.Ejecuta("delete from Rifa_Detalle where IdRifa = " & _IdRifa)

            '    For Each r As DataGridViewRow In Me.viewProveedores.Rows
            '        db.Ejecuta("Insert into Rifa_Detalle(IdRifa,IdProveedor,Nombre) values(" & _IdRifa & ", " & r.Cells(0).Value & ", '" & r.Cells(1).Value & "')")
            '    Next
            'End Sub

        End Sub

        Public Function Buscar(porDescripcion As Boolean,
                                   porId As Boolean,
                                   filtro As String) As List(Of Modelo.rifa)

            'Sub Buscar_rifa()
            '    Try
            '        Dim Fx As New cFunciones
            '        Dim valor As String
            '        Dim pos As Integer
            '        Dim vista As DataView

            '        valor = Fx.BuscarDatos("Select id,descripcion from rifa", "Rifas", "Buscar rifa...", Me.SqlConnection1.ConnectionString)

            '        If valor = "" Then
            '            Exit Sub
            '        Else
            '            vista = Me.Dsrifa1.rifa.DefaultView
            '            vista.Sort = "id"
            '            pos = vista.Find(CDbl(valor))
            '            Me.BindingContext(Me.Dsrifa1, "rifa").Position = pos
            '            Me.Cargar_Proveedores(Me.BindingContext(Me.Dsrifa1, "rifa").Current("Id"))
            '        End If
            '        Me.gp.Enabled = True
            '    Catch ex As SystemException
            '        MsgBox(ex.Message)
            '    End Try

            'End Sub

        End Function

        Public Sub Eliminar(id As Integer)

            'Private Sub Eliminar()
            '    Try
            '        Dim rs As SqlDataReader
            '        If Me.BindingContext(Me.Dsrifa1.rifa).Count > 0 Then

            '            'Evaluo si las subfamilias estan asociadas a un articulo 
            '            Dim strCodigoMarca As String = Me.BindingContext(Me.Dsrifa1, "rifa").Current("CodMarca")
            '            'Habro la conexion 
            '            sqlConexion = CConexion.Conectar(strModulo)
            '            'Realizo la busqueda en la base de datos
            '            rs = CConexion.GetRecorset(sqlConexion, "SELECT id FROM Inventario WHERE CodMarca = '" & strCodigoMarca & "'")
            '            'Evaluo si encontro registros dentro de la tabla inventario
            '            If rs.Read Then
            '                MsgBox("No se puede eliminar esta Marca por que existe articulos en el inventario que pertenecen a esta")
            '                rs.Close()
            '                CConexion.DesConectar(sqlConexion)
            '                Exit Sub
            '            End If
            '            'Si no encontro registros eliminara el registro actual
            '            Me.EliminarDatos(Me.adapte_rifa, Me.Dsrifa1, Me.Dsrifa1.rifa.ToString)
            '        End If
            '        rs.Close()
            '        CConexion.DesConectar(sqlConexion)
            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '    End Try

            'End Sub

        End Sub

    End Class
End Namespace