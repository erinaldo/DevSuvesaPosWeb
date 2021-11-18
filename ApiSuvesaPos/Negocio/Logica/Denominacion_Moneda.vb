Namespace Logica
    Public Class Denominacion_Moneda

        Public Property Monedas As Logica.Monedas

        Public Function buscarDenominacion_Moneda() As List(Of Modelo.denominacion_moneda)

            'Me.AdapterDenominacion.Fill(Me.DataSetConfiguracionMoneda1.Denominacion_Moneda)

        End Function

        Public Sub crearDenominacion_Moneda(denominacion_moneda As Modelo.denominacion_moneda)

            'Function Registrar()
            '    Dim resp As Integer

            '    If Validar() Then
            '        resp = MessageBox.Show("¿Deseas Guardar los cambios?", "SeeSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            '        If resp = 6 Then
            '            Try
            '                Me.BindingContext(Me.DataSetConfiguracionMoneda1, "Denominacion_Moneda").Current("Tipo") = ComboBox2.Text
            '                Me.BindingContext(Me.DataSetConfiguracionMoneda1, "Denominacion_Moneda").EndCurrentEdit()
            '                Me.AdapterDenominacion.Update(Me.DataSetConfiguracionMoneda1, "Denominacion_Moneda")
            '                'Para boton Nuevo
            '                Me.ToolBar1.Buttons(0).Text = "Nuevo"
            '                Me.ToolBar1.Buttons(0).ImageIndex = 0
            '                'Para boton Acualizar
            '                Me.ToolBar1.Buttons(3).Enabled = False
            '                'Para boton Editar
            '                Me.ToolBarExcel.Text = "Editar"
            '                Me.ToolBarExcel.ImageIndex = 5
            '                Me.Inabilitar()

            '            Catch eEndEdit As System.Data.NoNullAllowedException
            '                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            '            End Try
            '        End If

            '    Else
            '        MsgBox("Debes Ingresar Campos....", MsgBoxStyle.Information, "Atención...")
            '    End If
            'End Function

        End Sub

        Public Sub editarDenominacion_Moneda(denominacion_moneda As Modelo.denominacion_moneda)

            'Function Registrar()
            '    Dim resp As Integer

            '    If Validar() Then
            '        resp = MessageBox.Show("¿Deseas Guardar los cambios?", "SeeSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            '        If resp = 6 Then
            '            Try
            '                Me.BindingContext(Me.DataSetConfiguracionMoneda1, "Denominacion_Moneda").Current("Tipo") = ComboBox2.Text
            '                Me.BindingContext(Me.DataSetConfiguracionMoneda1, "Denominacion_Moneda").EndCurrentEdit()
            '                Me.AdapterDenominacion.Update(Me.DataSetConfiguracionMoneda1, "Denominacion_Moneda")
            '                'Para boton Nuevo
            '                Me.ToolBar1.Buttons(0).Text = "Nuevo"
            '                Me.ToolBar1.Buttons(0).ImageIndex = 0
            '                'Para boton Acualizar
            '                Me.ToolBar1.Buttons(3).Enabled = False
            '                'Para boton Editar
            '                Me.ToolBarExcel.Text = "Editar"
            '                Me.ToolBarExcel.ImageIndex = 5
            '                Me.Inabilitar()

            '            Catch eEndEdit As System.Data.NoNullAllowedException
            '                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            '            End Try
            '        End If

            '    Else
            '        MsgBox("Debes Ingresar Campos....", MsgBoxStyle.Information, "Atención...")
            '    End If
            'End Function

        End Sub

        Public Sub eliniarDenominacion_Moneda()
            'igual que crear y editar
        End Sub

    End Class
End Namespace