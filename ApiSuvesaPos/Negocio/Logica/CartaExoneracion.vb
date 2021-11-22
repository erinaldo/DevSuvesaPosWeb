Namespace Logica
    Public Class CartaExoneracion

        'cargar tiposexoneracion
        Public Property Clientes As New Logica.Clientes

        Public Sub crearCartaExoneracion(cartaexoneracion As Modelo.cartaexoneracion)

            'Private Sub AgregarCarta()
            '    If Me.txtPorcentajeCompra.Text <> "" Then
            '        If IsNumeric(Me.txtPorcentajeCompra.Text) Then
            '            Dim PorcentajeCompra As Decimal = CDec(Me.txtPorcentajeCompra.Text)
            '            If PorcentajeCompra > 1 And PorcentajeCompra <= 13 Then

            '                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '                If Me.Id = 0 Then
            '                    db.AddParametro("@Identificacion", Me.txtCodCliente.Text)
            '                    db.AddParametro("@IdTipoExoneracion", Me.cboExoneracion.SelectedValue)
            '                    db.AddParametro("@NumeroDocumento", Me.txtNumeroDocumento.Text)
            '                    db.AddParametro("@FechaEmision", Me.dtpFechaEmison.Value)
            '                    db.AddParametro("@FechaVence", Me.dtpFechaVence.Value)
            '                    db.AddParametro("@PorcentajeCompra", Me.txtPorcentajeCompra.Text)
            '                    db.AddParametro("@Impuesto", Me.txtIV.Text)
            '                    db.AddParametro("@Nota", Me.txtNotas.Text)
            '                    db.Ejecutar("Insert into CartaExoneracion([Identificacion],[IdTipoExoneracion],[NumeroDocumento],[FechaEmision],[FechaVence],[PorcentajeCompra],[Impuesto], [Nota]) Values(@Identificacion, @IdTipoExoneracion, @NumeroDocumento, @FechaEmision, @FechaVence, @PorcentajeCompra, @Impuesto, @Nota)", CommandType.Text)
            '                Else
            '                    db.AddParametro("@Identificacion", Me.txtCodCliente.Text)
            '                    db.AddParametro("@IdTipoExoneracion", Me.cboExoneracion.SelectedValue)
            '                    db.AddParametro("@NumeroDocumento", Me.txtNumeroDocumento.Text)
            '                    db.AddParametro("@FechaEmision", Me.dtpFechaEmison.Value)
            '                    db.AddParametro("@FechaVence", Me.dtpFechaVence.Value)
            '                    db.AddParametro("@PorcentajeCompra", Me.txtPorcentajeCompra.Text)
            '                    db.AddParametro("@Impuesto", Me.txtIV.Text)
            '                    db.AddParametro("@Nota", Me.txtNotas.Text)
            '                    db.Ejecutar("Update CartaExoneracion Set [Identificacion] = @Identificacion, [IdTipoExoneracion] = @IdTipoExoneracion, [NumeroDocumento] = @NumeroDocumento, [FechaEmision] = @FechaEmision, [FechaVence] = @FechaVence, [PorcentajeCompra] = @PorcentajeCompra ,[Impuesto] = @Impuesto, [Nota] = @Nota Where Id =  " & Me.Id, CommandType.Text)
            '                End If
            '                Me.CargarCartasCliente(Me.txtCodCliente.Text)
            '                Me.Limpiar()
            '            Else
            '                MsgBox("Porcentaje Exoneracion invalido.", MsgBoxStyle.Exclamation, Text)
            '                Me.txtPorcentajeCompra.Focus()
            '            End If
            '        Else
            '            MsgBox("Porcentaje Exoneracion invalido.", MsgBoxStyle.Exclamation, Text)
            '            Me.txtPorcentajeCompra.Focus()
            '        End If
            '    Else
            '        MsgBox("Porcentaje Exoneracion invalido.", MsgBoxStyle.Exclamation, Text)
            '        Me.txtPorcentajeCompra.Focus()
            '    End If
            'End Sub

        End Sub

        Public Sub editarCartaExoneracion(cartaexoneracion As Modelo.cartaexoneracion)
            'igual que crear
        End Sub

        Public Sub eliminarCartaExoneracion(id As Integer)

            'Private Sub EliminarCarta()
            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '    db.AddParametro("@Id", Me.Id)
            '    db.Ejecutar("Delete from CartaExoneracion Where Id = @Id", CommandType.Text)
            '    Me.CargarCartasCliente(Me.txtCodCliente.Text)
            '    Me.Limpiar()
            'End Sub

        End Sub

    End Class
End Namespace