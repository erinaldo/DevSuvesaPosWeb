Namespace Logica
    Public Class Cotizaciones

        Private db As Datos.Class.Cotizacion

        Sub New()
            Me.db = New Datos.Class.Cotizacion
        End Sub

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.Cotizacion)
            Return db.Buscar(porNombre, Filtro)
        End Function

        Public Function Crear(cotizacion As Datos.Models.Cotizacion) As String
            Return Me.db.Crear(cotizacion)
            'Dim Contacto As String = ""
            'Dim frm As New frmContactoCotizacion
            'frm.txtContacto.Text = Me.txtContacto.Text
            'frm.txtTelefono.Text = Me.txtTelefono.Text
            'If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            '    txtTelefono.Text = frm.txtTelefono.Text
            '    Contacto = frm.txtContacto.Text
            'Else
            '    Exit Function
            'End If

            'If Me.ck_confirmada.Checked And Me.txtconfirmadapor.Text = "" Then
            '    MsgBox("Marco la opción de confirmada, por favor ingrese el nombre de la persona con la que confirmo la cotización.", MsgBoxStyle.Critical, "Cotizaciones")
            '    Me.txtconfirmadapor.Focus()
            '    Exit Function
            'Else
            '    BindingContext(DataSet_Cotizaciones21, "Cotizacion").Current("confirmada_por") = Me.txtconfirmadapor.Text
            '    BindingContext(DataSet_Cotizaciones21, "Cotizacion").EndCurrentEdit()
            'End If

            'Function RegistrarVenta() As Boolean

            '    If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            '    Try
            '        Me.SqlInsertCommand1.Transaction = Trans
            '        Me.SqlUpdateCommand1.Transaction = Trans
            '        Me.SqlDeleteCommand1.Transaction = Trans

            '        Me.SqlInsertCommand2.Transaction = Trans
            '        Me.SqlUpdateCommand2.Transaction = Trans
            '        Me.SqlDeleteCommand2.Transaction = Trans

            '        'Me.Adapter_Cotizacion.Update(Me.DataSet_Cotizaciones21, "Cotizacion")
            '        Me.Adapter_Cotizacion.Update(Me.DataSet_Cotizaciones21, "Cotizacion")
            '        Me.Adapter_Cotizacion_Detalle.Update(Me.DataSet_Cotizaciones21, "Cotizacion_Detalle")
            '        Trans.Commit()
            '        Return True


            '    Catch ex As Exception
            '        Trans.Rollback()
            '        MsgBox(ex.Message)
            '        Me.ToolBar1.Buttons(2).Enabled = True
            '        Return False
            '    End Try
            'End Function

        End Function

        Public Function Editar(Id As Long, Cotizacion As Datos.Models.Cotizacion) As String
            Dim res As String = Me.db.Editar(Id, Cotizacion)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

        Public Function Anular(Id As Long) As String
            Dim res As String = Me.db.Anular(Id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

    End Class

End Namespace
