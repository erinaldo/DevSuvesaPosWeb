'***************************************************************************************************************
'Clase para generar los xml para la version 4.3 de facturacion electronica
'@utor
'       ing. Rolando Obando Rojas
'
'Fecha Inicio : 04/06/2019 
'***************************************************************************************************************
Imports System.IO
Imports System.Xml
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.ComponentModel

Namespace OBSoluciones
    Namespace ComprobantesElectronicos
        Public Class GeneraXML_43
            Private xml As XmlTextWriter
            Private UbicacionXMLFacturas As String = "C:/Facturas"
            Private UbicacionXMLCompras As String = "C:/Compras"

            Public Fac As New DatosFE.Models.ObtenerFacturas43
            Public FacDet As New List(Of DatosFE.Models.ObtenerDetalleFactura43)
            Public Dev As New DatosFE.Models.ObtenerDevolucion43
            Public DevDet As New List(Of DatosFE.Models.ObtenerDetallesDevolucion43)
            Public Msg As New DatosFE.Models.GetMensajeXml43

            Public Event DocumentoGenerado(ByVal _xml As String, ByVal _IdDocumento As String, _TipoDocumento As String)
            Public Event setError(ByVal _msg As String)
            Public Event setDifMontos(_IdFactura As String)
            'CONSTRUCTOR DE LA CLASE
            Sub New()
                If Directory.Exists(Me.UbicacionXMLFacturas) = False Then Directory.CreateDirectory(Me.UbicacionXMLFacturas)
            End Sub
            'METODOS PARA AGREGAR ELEMENTOS AL XML
            Private Sub AgregarElementoManual(ByVal _TituloXml As String, ByVal _Valor As String)
                If _Valor <> "" Then
                    Me.xml.WriteStartElement(_TituloXml)
                    Me.xml.WriteString(_Valor)
                    Me.xml.WriteEndElement()
                End If
            End Sub
            Private Sub AgregarElemento(ByVal _TituloXml As String, ByVal _Valor As String)
                Me.xml.WriteStartElement(_TituloXml)
                Me.xml.WriteString(_Valor)
                Me.xml.WriteEndElement()
            End Sub
            Private Sub AgregarElemento(ByVal _TituloXml As String, ByVal _Valor As String, _SubAtributo As String, _ValorSubAtributo As String)
                Me.xml.WriteStartElement(_TituloXml)
                Me.xml.WriteAttributeString(_SubAtributo, _ValorSubAtributo)
                Me.xml.WriteString(_Valor)
                Me.xml.WriteEndElement()
            End Sub
            Private Sub CargarDatosFactura(ByVal _IdFactura As String)
                Dim cls As New DatosFE.Class.Vistas
                Me.Fac = cls.ObtenerFacturas43(_IdFactura).FirstOrDefault
                Me.FacDet = cls.ObtenerDetalleFacturas43(_IdFactura)
            End Sub
            Private Sub CargarDatosDevolucion(ByVal _IdDevolucion As String)
                Dim cls As New DatosFE.Class.Vistas
                Me.Dev = cls.ObtenerDevolucionVenta43(_IdDevolucion).FirstOrDefault
                Me.DevDet = cls.ObtenerDetalleDevolucionVenta43(_IdDevolucion)
            End Sub
            Private Sub CargarDatosMensaje(ByVal _IdMensaje As String)
                Dim cls As New DatosFE.Class.Vistas
                Me.Msg = cls.GetMensajePorId43(_IdMensaje).FirstOrDefault
            End Sub
            Private Function NumeroRandom() As String
                Dim Generator As System.Random = New System.Random()
                Return CStr(Generator.Next(0, 99999999).ToString).PadLeft(8, "0")
            End Function
            Private Function ObtenerClave(ByVal _Cons As String) As String
                Dim Clave As String = ""
                Try
                    Dim Pais As String = Fac.CodigoPaisEmisor
                    Dim Fecha() As String = CDate(Fac.Fecha).ToShortDateString.Split("/")
                    Dim Cedula As String = Fac.NumeroEmisor.ToString.Replace("-", "")
                    Clave = Pais + Fecha(0) + Fecha(1).PadLeft(2, "0") + Fecha(2).Substring(2, 2) + Cedula.PadLeft(12, "0") + _Cons + CStr(1) + Me.NumeroRandom
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
                Return Clave
            End Function
            'GENERA XML FACTURA
            Public Function GeneraXMLFactura(ByVal _IdFactura As String) As Boolean
                Dim consecutivo As String = ""
                Dim clave As String = ""
                Me.CargarDatosFactura(_IdFactura)

                Dim TotalServGravados, TotalServExentos As Decimal

                Dim SubTotal, Descuento, Impuesto, Total As Decimal
                TotalServGravados = 0
                TotalServExentos = 0
                SubTotal = 0
                Descuento = 0
                Impuesto = 0
                Total = 0

                Try

                    consecutivo = Fac.NumeroConsecutivo
                    clave = Fac.Clave

                    Dim TotalComprobante, TotalImpreso, DifTotales As Decimal
                    TotalComprobante = 0
                    TotalImpreso = 0
                    DifTotales = 0

                    TotalComprobante = Fac.TotalComprobante
                    TotalImpreso = TotalComprobante 'dtsEncabezado.TotalImpreso
                    DifTotales = Math.Abs(TotalComprobante - TotalImpreso)

                    If DifTotales > 50 Then
                        RaiseEvent setDifMontos(_IdFactura)
                        Return False
                    End If

                    Me.UbicacionXMLFacturas = "C:/Facturas"
                    Me.UbicacionXMLFacturas += "/" & consecutivo
                    If Directory.Exists(Me.UbicacionXMLFacturas) = False Then Directory.CreateDirectory(Me.UbicacionXMLFacturas)
                    Me.xml = New XmlTextWriter(UbicacionXMLFacturas & "/" & consecutivo & "_00_SF.xml", System.Text.Encoding.UTF8)
                    Me.xml.WriteStartDocument(True)
                    Me.xml.Formatting = Formatting.Indented
                    Me.xml.Indentation = 2
                    Me.xml.WriteStartElement("FacturaElectronica") '                                    FACTURA ELECTRONICA     *********************************
                    Me.xml.WriteAttributeString("xmlns", "https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/facturaElectronica")
                    Me.xml.WriteAttributeString("xmlns:ns2", "http://www.w3.org/2000/09/xmldsig#")
                    Me.xml.WriteAttributeString("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance")
                    Me.xml.WriteAttributeString("xsi:schemaLocation", "https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/facturaElectronicahttps://www.hacienda.go.cr/ATV/ComprobanteElectronico/docs/esquemas/2016/v4.3/FacturaElectronica_V4.3.xsd")
                    Me.AgregarElementoManual("Clave", clave) '                                              clave
                    Me.AgregarElemento("CodigoActividad", Me.Fac.CodigoActividad) '                              codigo actividad
                    Me.AgregarElementoManual("NumeroConsecutivo", consecutivo) '                            consecutivo
                    Me.AgregarElemento("FechaEmision", Me.Fac.FechaEmision) '                                    fecha emision
                    Me.xml.WriteStartElement("Emisor") '                                                EMISOR                  *********************************
                    Me.AgregarElemento("Nombre", Me.Fac.NombreEmisor) '                                         nombre
                    Me.xml.WriteStartElement("Identificacion") '                                        IDENTIFICACION          *********************************
                    Me.AgregarElemento("Tipo", Me.Fac.TipoEmisor) '                                             tipo
                    Me.AgregarElemento("Numero", Me.Fac.NumeroEmisor) '                                         numero
                    Me.xml.WriteEndElement() '                                                          //IDENTIFICACION        *********************************
                    Me.xml.WriteStartElement("Ubicacion") '                                             UBICACION               *********************************
                    Me.AgregarElemento("Provincia", Me.Fac.ProvinciaEmisor) '                                   provincia
                    Me.AgregarElemento("Canton", Me.Fac.CantonEmisor) '                                         canton
                    Me.AgregarElemento("Distrito", Me.Fac.DistritoEmisor) '                                     distrito
                    Me.AgregarElemento("OtrasSenas", Me.Fac.OtrasSenasEmisor) '                                 otras señas
                    Me.xml.WriteEndElement() '                                                          //UBICACION             *********************************
                    Me.xml.WriteStartElement("Telefono") '                                              TELEFONO                *********************************
                    Me.AgregarElemento("CodigoPais", Me.Fac.CodigoPaisEmisor) '                                 codigo pais
                    Me.AgregarElemento("NumTelefono", Me.Fac.NumTelefonoEmisor) '                               num telefono
                    Me.xml.WriteEndElement() '                                                          //TELEFONO              *********************************
                    Me.AgregarElemento("CorreoElectronico", Me.Fac.CorreoElectronicoEmisor) '                   correoelctronico
                    Me.xml.WriteEndElement() '                                                          //EMISOR                *********************************
                    Me.xml.WriteStartElement("Receptor") '                                              RECEPTOR                *********************************
                    Me.AgregarElemento("Nombre", Me.Fac.NombreReceptor) '                                       nombre
                    Me.xml.WriteStartElement("Identificacion") '                                        IDENTIFICACION          *********************************
                    Me.AgregarElemento("Tipo", Me.Fac.TipoReceptor) '                                           tipo
                    Me.AgregarElemento("Numero", Me.Fac.NumeroReceptor) '                                       numero
                    Me.xml.WriteEndElement() '                                                          //IDENTIFICACION        *********************************
                    'Me.AgregarElemento("CorreoElectronico", "CorreoElectronico_Receptor") '                 correoelctronico
                    Me.xml.WriteEndElement() '                                                          //RECEPTOR              *********************************
                    Me.AgregarElemento("CondicionVenta", Me.Fac.CondicionVenta) '                                condiconventa
                    Me.AgregarElemento("PlazoCredito", Me.Fac.PlazoCredito) '                                    plazocredito
                    Me.AgregarElemento("MedioPago", Me.Fac.MedioPago) '                                          mediopago
                    Me.xml.WriteStartElement("DetalleServicio") '                                       DETALLESERVICOS         *********************************
                    Dim i As Integer = 0
                    For Each Detalle As DatosFE.Models.ObtenerDetalleFactura43 In Me.FacDet
                        Me.xml.WriteStartElement("LineaDetalle") '                                      LINEADETALLE            ********************************* 
                        Me.AgregarElementoManual("NumeroLinea", i + 1) : i += 1 '                                    numerolinea
                        Me.AgregarElemento("Codigo", Detalle.Cabys)
                        Me.xml.WriteStartElement("CodigoComercial") '                                            CODIGO                  *********************************
                        Me.AgregarElemento("Tipo", Detalle.Tipo) '                                             tipo
                        Me.AgregarElemento("Codigo", Detalle.Codigo) '                                         codigo
                        Me.xml.WriteEndElement() '                                                      //CODIGO                *********************************
                        Me.AgregarElemento("Cantidad", Detalle.Cantidad) '                                     cantidad
                        Me.AgregarElemento("UnidadMedida", Detalle.UnidadMedida) '                             unidadmedida
                        Me.AgregarElemento("Detalle", Detalle.Detalle) '                                       detalle
                        Me.AgregarElemento("PrecioUnitario", Detalle.PrecioUnitario) '                         preciounitario
                        Me.AgregarElemento("MontoTotal", Detalle.MontoTotal) '                                 montototal
                        If Detalle.MontoDescuento > 0 Then
                            Me.xml.WriteStartElement("Descuento")
                            Me.AgregarElemento("MontoDescuento", Detalle.MontoDescuento) '                         montodescuento                        
                            Me.AgregarElemento("NaturalezaDescuento", Detalle.NaturalezaDescuento) '               naturalezadescuento
                            Me.xml.WriteEndElement()
                        End If
                        Me.AgregarElemento("SubTotal", Detalle.SubTotal) '                                     subtotal
                        If Detalle.TarifaImpuesto > 0 Then
                            Me.xml.WriteStartElement("Impuesto") '                                          IMPUESTO                *********************************
                            Me.AgregarElemento("Codigo", Detalle.CodigoImpuesto) '                                codigo
                            Me.AgregarElemento("CodigoTarifa", Detalle.CodigoTarifa) '                             codigotarifa
                            Me.AgregarElemento("Tarifa", Detalle.TarifaImpuesto) '                                tarifa
                            Me.AgregarElemento("Monto", Detalle.MontoImpuesto) '                                  monto
                            If Detalle.MontoImpuestoExoneracion > 1 And Detalle.NumeroDocumentoExoneracion <> "" Then
                                Me.xml.WriteStartElement("Exoneracion") '                                   EXONERACION             *********************************
                                Me.AgregarElemento("TipoDocumento", Detalle.TipoDocumentoExoneracion) '           tipodocumento
                                Me.AgregarElemento("NumeroDocumento", Detalle.NumeroDocumentoExoneracion) '       numerodocumento
                                Me.AgregarElemento("NombreInstitucion", Detalle.NombreInstitucionExoneracion) '   nombreinstitucion
                                Me.AgregarElemento("FechaEmision", Detalle.FechaEmisionExoneracion) '             fechaemision
                                Me.AgregarElemento("PorcentajeExoneracion", Detalle.PorcentajeCompraExoneracion) '     porcentajecompra
                                Me.AgregarElemento("MontoExoneracion", Detalle.MontoImpuestoExoneracion) '           montoimpuesto
                                Me.xml.WriteEndElement() '                                                  //EXONERACION           *********************************
                            End If
                            Me.xml.WriteEndElement() '                                                      //IMPUESTO              *********************************
                            If Detalle.MontoImpuestoExoneracion > 1 And Detalle.NumeroDocumentoExoneracion <> "" Then
                                Me.AgregarElemento("ImpuestoNeto", Detalle.ImpuestoNeto) '                       impuesto neto
                            End If
                        End If
                        Me.AgregarElemento("MontoTotalLinea", Detalle.MontoTotalLinea) '                       montototallinea
                        Me.xml.WriteEndElement() '                                                      //LINEADETALLE          *********************************

                        If CDec(Detalle.MontoImpuesto) > 0 Then
                            TotalServGravados += CDec(Detalle.SubTotal)
                            TotalServExentos += 0
                        Else
                            TotalServGravados += 0
                            TotalServExentos += CDec(Detalle.SubTotal)
                        End If
                        SubTotal += CDec(Detalle.SubTotal)
                        Descuento += CDec(Detalle.MontoDescuento)
                        Impuesto += CDec(Detalle.MontoImpuesto)
                        Total += CDec(Detalle.MontoTotalLinea)

                        'Dim TotalMercanciasGravadas, TotalMercanciasExentas As Decimal
                        'Dim TotalGravado, TotalExento As Decimal
                        'Dim TotalVenta, TotalDescuentos, TotalVentaNeta, TotalImpuesto, TotalComprobante As Decimal
                    Next
                    Me.xml.WriteEndElement() '                                                          //DETALLESERVICOS       *********************************
                    Me.xml.WriteStartElement("ResumenFactura") '                                        RESUMENFACTURA          *********************************
                    Me.xml.WriteStartElement("CodigoTipoMoneda") '                                      CODIGOTIPOMONEDA
                    Me.AgregarElemento("CodigoMoneda", Me.Fac.CodigoMoneda) '                                    codigomoneda
                    Me.AgregarElemento("TipoCambio", Me.Fac.TipoCambio) '                                        tipocambio
                    Me.xml.WriteEndElement() '                                                           //CODIGOTIPOMONEDA
                    Me.AgregarElemento("TotalServGravados", Me.Fac.TotalServGravados) '                          totalservgravados
                    Me.AgregarElemento("TotalServExentos", Me.Fac.TotalServExentos) '                            totalservexento
                    Me.AgregarElemento("TotalServExonerado", Me.Fac.TotalServExonerado) '                        totalservexonerado
                    Me.AgregarElemento("TotalMercanciasGravadas", Me.Fac.TotalMercanciasGravadas) '              totalmercanciasgravadas
                    Me.AgregarElemento("TotalMercanciasExentas", Me.Fac.TotalMercanciasExentas) '                totalmercanciasexenta
                    Me.AgregarElemento("TotalMercExonerada", Me.Fac.TotalMercExonerada) '                        totalmercexonerada
                    Me.AgregarElemento("TotalGravado", Me.Fac.TotalGravado) '                                    totalgravado
                    Me.AgregarElemento("TotalExento", Me.Fac.TotalExento) '                                      totalexento
                    Me.AgregarElemento("TotalExonerado", Me.Fac.TotalExonerado) '                                totalexonerado
                    Me.AgregarElemento("TotalVenta", Me.Fac.TotalVenta) '                                        totalventa
                    Me.AgregarElemento("TotalDescuentos", Me.Fac.TotalDescuentos) '  c                            totaldescuento
                    Me.AgregarElemento("TotalVentaNeta", Me.Fac.TotalVentaNeta) '                                totalventaneta
                    Me.AgregarElemento("TotalImpuesto", Me.Fac.TotalImpuesto) '                                  totalimpuesto
                    Me.AgregarElemento("TotalComprobante", Me.Fac.TotalComprobante) '                            totalcomprobante
                    Me.xml.WriteEndElement() '                                                          //RESUMENFACTURA        *********************************

                    Dim OrdenCompra As String = Me.Fac.OrdenCompra

                    If Me.Fac.NumeroReceptor = "4000042139" Then
                        'las pegas del ice
                        If OrdenCompra <> "" Then
                            Me.xml.WriteStartElement("InformacionReferencia")
                            Me.AgregarElementoManual("TipoDoc", "99")
                            Me.AgregarElementoManual("Numero", CStr("MM-" & OrdenCompra.Replace("MM-", "")))
                            Me.AgregarElementoManual("FechaEmision", Me.Fac.FechaEmision)
                            Me.AgregarElementoManual("Codigo", "99")
                            Me.AgregarElementoManual("Razon", "ICE")
                            Me.xml.WriteEndElement()
                        Else
                            'No se envia a tributacion porque no tiene orden de compra, asi se puede agregar y luego enviar.
                            Return False
                        End If
                    Else
                        If OrdenCompra <> "" And OrdenCompra <> "0" Then
                            Me.xml.WriteStartElement("Otros") '                                                 Otros                   *********************************
                            Me.AgregarElemento("OtroTexto", Me.Fac.OrdenCompra, "codigo", "WMNumeroOrden") '             OrdenCompra
                            Me.xml.WriteEndElement() '                                                          //Otros                 *********************************
                        End If
                    End If

                    'Me.xml.WriteStartElement("Normativa") '                                             NORMATIVA              *********************************
                    'Me.AgregarElemento("NumeroResolucion", "NumeroResolucion") '                            numeroresolucion
                    'Me.AgregarElemento("FechaResolucion", "FechaResolucion") '                              fecharesolucion
                    'Me.xml.WriteEndElement() '                                                          //NORMATIVA            *********************************

                    Me.xml.WriteEndElement() '                                                          //FACTURA ELECTRONICA   *********************************
                    Me.xml.WriteEndDocument()
                    Me.xml.Close()
                    Me.xml.Dispose()
                    Me.xml = Nothing
                    Dim xmlElectronica As New Xml.XmlDocument
                    xmlElectronica.Load(UbicacionXMLFacturas & "/" & consecutivo & "_00_SF.xml")
                    'xmlElectronica.PreserveWhitespace = True
                    Dim resultado As String = xmlElectronica.OuterXml
                    xmlElectronica = Nothing
                    RaiseEvent DocumentoGenerado(resultado, _IdFactura, "FACTURA")
                    Return True
                Catch ex As Exception
                    RaiseEvent setError(ex.Message)
                    Return False
                End Try
            End Function
            'GENERA XML TIQUETE CAJA
            Public Function GeneraXMLTiquete(ByVal _IdFactura As String) As Boolean
                Try
                    Dim consecutivo As String = ""
                    Dim clave As String = ""
                    Me.CargarDatosFactura(_IdFactura)

                    'consecutivo = dtsEncabezado.Rows(0).Item("Consecutivo")
                    'clave = Me.ObtenerClave(consecutivo)

                    consecutivo = Fac.NumeroConsecutivo
                    clave = Fac.Clave

                    Me.UbicacionXMLFacturas = "C:/Facturas"
                    Me.UbicacionXMLFacturas += "/" & consecutivo
                    If Directory.Exists(Me.UbicacionXMLFacturas) = False Then Directory.CreateDirectory(Me.UbicacionXMLFacturas)
                    Me.xml = New XmlTextWriter(UbicacionXMLFacturas & "/" & consecutivo & "_00_SF.xml", System.Text.Encoding.UTF8)
                    Me.xml.WriteStartDocument(True)
                    Me.xml.Formatting = Formatting.Indented
                    Me.xml.Indentation = 2
                    Me.xml.WriteStartElement("TiqueteElectronico") '                                    FACTURA ELECTRONICA     *********************************
                    Me.xml.WriteAttributeString("xmlns", "https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/tiqueteElectronico")
                    Me.xml.WriteAttributeString("xmlns:ns2", "http://www.w3.org/2000/09/xmldsig#")
                    Me.xml.WriteAttributeString("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance")
                    'Me.xml.WriteAttributeString("xsi:schemaLocation", "https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/facturaElectronicahttps://www.hacienda.go.cr/ATV/ComprobanteElectronico/docs/esquemas/2016/v4.3/FacturaElectronica_V4.3.xsd")
                    Me.AgregarElementoManual("Clave", clave) '                                              clave
                    Me.AgregarElemento("CodigoActividad", Me.Fac.CodigoActividad) '                              codigoactividad
                    Me.AgregarElementoManual("NumeroConsecutivo", consecutivo) '                            consecutivo
                    Me.AgregarElemento("FechaEmision", Me.Fac.FechaEmision) '                                    fecha emision
                    Me.xml.WriteStartElement("Emisor") '                                                EMISOR                  *********************************
                    Me.AgregarElemento("Nombre", Me.Fac.NombreEmisor) '                                         nombre
                    Me.xml.WriteStartElement("Identificacion") '                                        IDENTIFICACION          *********************************
                    Me.AgregarElemento("Tipo", Me.Fac.TipoEmisor) '                                             tipo
                    Me.AgregarElemento("Numero", Me.Fac.NumeroEmisor) '                                         numero
                    Me.xml.WriteEndElement() '                                                          //IDENTIFICACION        *********************************
                    Me.AgregarElemento("NombreComercial", Me.Fac.NombreEmisor) '                                         nombre
                    Me.xml.WriteStartElement("Ubicacion") '                                             UBICACION               *********************************
                    Me.AgregarElemento("Provincia", Me.Fac.ProvinciaEmisor) '                                   provincia
                    Me.AgregarElemento("Canton", Me.Fac.CantonEmisor) '                                         canton
                    Me.AgregarElemento("Distrito", Me.Fac.DistritoEmisor) '                                     distrito
                    Me.AgregarElemento("OtrasSenas", Me.Fac.OtrasSenasEmisor) '                                 otras señas
                    Me.xml.WriteEndElement() '                                                          //UBICACION             *********************************
                    Me.xml.WriteStartElement("Telefono") '                                              TELEFONO                *********************************
                    Me.AgregarElemento("CodigoPais", Me.Fac.CodigoPaisEmisor) '                                 codigo pais
                    Me.AgregarElemento("NumTelefono", Me.Fac.NumTelefonoEmisor) '                               num telefono
                    Me.xml.WriteEndElement() '                                                          //TELEFONO              *********************************
                    Me.AgregarElemento("CorreoElectronico", Me.Fac.CorreoElectronicoEmisor) '                   correoelctronico
                    Me.xml.WriteEndElement() '                                                          //EMISOR                *********************************
                    Me.AgregarElemento("CondicionVenta", Me.Fac.CondicionVenta) '                                condiconventa
                    Me.AgregarElemento("MedioPago", Me.Fac.MedioPago) '                                          mediopago
                    Me.xml.WriteStartElement("DetalleServicio") '                                       DETALLESERVICOS         *********************************
                    Dim i As Integer = 0
                    For Each Detalle As DatosFE.Models.ObtenerDetalleFactura43 In Me.FacDet
                        Me.xml.WriteStartElement("LineaDetalle") '                                      LINEADETALLE            ********************************* 
                        Me.AgregarElementoManual("NumeroLinea", i + 1) : i += 1 '                                    numerolinea
                        Me.AgregarElemento("Codigo", Detalle.Cabys)
                        Me.xml.WriteStartElement("CodigoComercial") '                                            CODIGO                  *********************************
                        Me.AgregarElemento("Tipo", Detalle.Tipo) '                                             tipo
                        Me.AgregarElemento("Codigo", Detalle.Codigo) '                                         codigo
                        Me.xml.WriteEndElement() '                                                      //CODIGO                *********************************
                        Me.AgregarElemento("Cantidad", Detalle.Cantidad) '                                     cantidad
                        Me.AgregarElemento("UnidadMedida", Detalle.UnidadMedida) '                             unidadmedida
                        Me.AgregarElemento("Detalle", Detalle.Detalle) '                                       detalle
                        Me.AgregarElemento("PrecioUnitario", Detalle.PrecioUnitario) '                         preciounitario
                        Me.AgregarElemento("MontoTotal", Detalle.MontoTotal) '                                 montototal
                        If CDec(Detalle.MontoDescuento) > 0 Then
                            Me.xml.WriteStartElement("Descuento")
                            Me.AgregarElemento("MontoDescuento", Detalle.MontoDescuento) '                         montodescuento
                            Me.AgregarElemento("NaturalezaDescuento", Detalle.NaturalezaDescuento) '               naturalezadescuento
                            Me.xml.WriteEndElement()
                        End If
                        Me.AgregarElemento("SubTotal", Detalle.SubTotal) '                                     subtotal
                        If CDec(Detalle.TarifaImpuesto) > 0 Then
                            Me.xml.WriteStartElement("Impuesto") '                                          IMPUESTO                *********************************
                            Me.AgregarElemento("Codigo", Detalle.CodigoImpuesto) '                                codigo
                            Me.AgregarElemento("CodigoTarifa", Detalle.CodigoTarifa) '                             coditotarifa
                            Me.AgregarElemento("Tarifa", Detalle.TarifaImpuesto) '                                tarifa
                            Me.AgregarElemento("Monto", Detalle.MontoImpuesto) '                                  monto
                            Me.xml.WriteEndElement() '                                                      //IMPUESTO              *********************************
                        End If
                        Me.AgregarElemento("MontoTotalLinea", Detalle.MontoTotalLinea) '                       montototallinea
                        Me.xml.WriteEndElement() '                                                      //LINEADETALLE          *********************************
                    Next
                    Me.xml.WriteEndElement() '                                                          //DETALLESERVICOS       *********************************
                    Me.xml.WriteStartElement("ResumenFactura") '                                        RESUMENFACTURA          *********************************
                    Me.xml.WriteStartElement("CodigoTipoMoneda") '                                      CODIGOTIPOMONEDA
                    Me.AgregarElemento("CodigoMoneda", Me.Fac.CodigoMoneda) '                                    codigomoneda
                    Me.AgregarElemento("TipoCambio", Me.Fac.TipoCambio) '                                        tipocambio
                    Me.xml.WriteEndElement() '                                                           //CODIGOTIPOMONEDA
                    Me.AgregarElemento("TotalServGravados", Me.Fac.TotalServGravados) '                          totalservgravados
                    Me.AgregarElemento("TotalServExentos", Me.Fac.TotalServExentos) '                            totalservexento
                    Me.AgregarElemento("TotalMercanciasGravadas", Me.Fac.TotalMercanciasGravadas) '              totalmercanciasgravadas
                    Me.AgregarElemento("TotalMercanciasExentas", Me.Fac.TotalMercanciasExentas) '                totalmercanciasexenta
                    Me.AgregarElemento("TotalGravado", Me.Fac.TotalGravado) '                                    totalgravado
                    Me.AgregarElemento("TotalExento", Me.Fac.TotalExento) '                                      totalexento
                    Me.AgregarElemento("TotalVenta", Me.Fac.TotalVenta) '                                        totalventa
                    Me.AgregarElemento("TotalDescuentos", Me.Fac.TotalDescuentos) '                              totaldescuento
                    Me.AgregarElemento("TotalVentaNeta", Me.Fac.TotalVentaNeta) '                                totalventaneta
                    Me.AgregarElemento("TotalImpuesto", Me.Fac.TotalImpuesto) '                                  totalimpuesto
                    Me.AgregarElemento("TotalComprobante", Me.Fac.TotalComprobante) '                            totalcomprobante
                    Me.xml.WriteEndElement() '                                                          //RESUMENFACTURA        *********************************
                    'Me.xml.WriteStartElement("Normativa") '                                             NORMATIVA               *********************************
                    'Me.AgregarElemento("NumeroResolucion", "NumeroResolucion") '                            numeroresolucion
                    'Me.AgregarElemento("FechaResolucion", "FechaResolucion") '                              fecharesolucion
                    'Me.xml.WriteEndElement() '                                                          //NORMATIVA             *********************************
                    Me.xml.WriteEndElement() '                                                          //FACTURA ELECTRONICA   *********************************
                    Me.xml.WriteEndDocument()
                    Me.xml.Close()
                    Me.xml.Dispose()
                    Me.xml = Nothing
                    Dim xmlElectronica As New Xml.XmlDocument
                    xmlElectronica.Load(UbicacionXMLFacturas & "/" & consecutivo & "_00_SF.xml")
                    'xmlElectronica.PreserveWhitespace = True
                    Dim resultado As String = xmlElectronica.OuterXml
                    xmlElectronica = Nothing
                    RaiseEvent DocumentoGenerado(resultado, _IdFactura, "TIQUETE")
                    Return True
                Catch ex As Exception
                    RaiseEvent setError(ex.Message)
                    Return False
                End Try
            End Function
            'GENERA XML NOTA CREDITO POR DEVOLUCION
            Public Function GeneraXMLDevoluciones(ByVal _IdDevolucion As String) As Boolean
                Try
                    Dim consecutivo As String = ""
                    Dim clave As String = ""
                    Me.CargarDatosDevolucion(_IdDevolucion)
                    consecutivo = Me.Fac.Consecutivo
                    clave = Me.ObtenerClave(consecutivo)
                    Me.UbicacionXMLFacturas = "C:/Facturas"
                    Me.UbicacionXMLFacturas += "/" & consecutivo
                    If Directory.Exists(Me.UbicacionXMLFacturas) = False Then Directory.CreateDirectory(Me.UbicacionXMLFacturas)
                    Me.xml = New XmlTextWriter(UbicacionXMLFacturas & "/" & consecutivo & "_00_SF.xml", System.Text.Encoding.UTF8)
                    Me.xml.WriteStartDocument(True)
                    Me.xml.Formatting = Formatting.Indented
                    Me.xml.Indentation = 2
                    Me.xml.WriteStartElement("NotaCreditoElectronica") '                                    FACTURA ELECTRONICA     *********************************
                    Me.xml.WriteAttributeString("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance")
                    Me.xml.WriteAttributeString("xmlns:xsd", "http://www.w3.org/2001/XMLSchema")
                    Me.xml.WriteAttributeString("xmlns", "https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/notaCreditoElectronica")
                    Me.AgregarElementoManual("Clave", clave) '                                              clave
                    Me.AgregarElemento("CodigoActividad", Me.Dev.CodigoActividad) '                              codigo actividad
                    Me.AgregarElementoManual("NumeroConsecutivo", consecutivo) '                            consecutivo
                    Me.AgregarElemento("FechaEmision", Me.Dev.FechaEmision) '                                    fecha emision
                    Me.xml.WriteStartElement("Emisor") '                                                EMISOR                  *********************************
                    Me.AgregarElemento("Nombre", Me.Dev.NombreEmisor) '                                         nombre
                    Me.xml.WriteStartElement("Identificacion") '                                        IDENTIFICACION          *********************************
                    Me.AgregarElemento("Tipo", Me.Dev.TipoEmisor) '                                             tipo
                    Me.AgregarElemento("Numero", Me.Dev.NumeroEmisor) '                                         numero
                    Me.xml.WriteEndElement() '                                                          //IDENTIFICACION        *********************************
                    Me.xml.WriteStartElement("Ubicacion") '                                             UBICACION               *********************************
                    Me.AgregarElemento("Provincia", Me.Dev.ProvinciaEmisor) '                                   provincia
                    Me.AgregarElemento("Canton", Me.Dev.CantonEmisor) '                                         canton
                    Me.AgregarElemento("Distrito", Me.Dev.DistritoEmisor) '                                     distrito
                    Me.AgregarElemento("OtrasSenas", Me.Dev.OtrasSenasEmisor) '                                 otras señas
                    Me.xml.WriteEndElement() '                                                          //UBICACION             *********************************
                    Me.xml.WriteStartElement("Telefono") '                                              TELEFONO                *********************************
                    Me.AgregarElemento("CodigoPais", Me.Dev.CodigoPaisEmisor) '                                 codigo pais
                    Me.AgregarElemento("NumTelefono", Me.Dev.NumTelefonoEmisor) '                               num telefono
                    Me.xml.WriteEndElement() '                                                          //TELEFONO              *********************************
                    Me.AgregarElemento("CorreoElectronico", Me.Dev.CorreoElectronicoEmisor) '                   correoelctronico
                    Me.xml.WriteEndElement() '                                                          //EMISOR                *********************************

                    If Me.Dev.TipoFactura = "CON" Or Me.Dev.TipoFactura = "CRE" Then
                        Me.xml.WriteStartElement("Receptor") '                                              RECEPTOR                *********************************
                        Me.AgregarElemento("Nombre", Me.Dev.NombreReceptor) '                                       nombre
                        Me.xml.WriteStartElement("Identificacion") '                                        IDENTIFICACION          *********************************
                        Me.AgregarElemento("Tipo", Me.Dev.TipoReceptor) '                                           tipo
                        Me.AgregarElemento("Numero", Me.Dev.NumeroReceptor) '                                       numero
                        Me.xml.WriteEndElement() '                                                          //IDENTIFICACION        *********************************
                        Me.xml.WriteEndElement() '                                                          //RECEPTOR              *********************************
                    End If

                    Me.AgregarElemento("CondicionVenta", Me.Dev.CondicionVenta) '                                condiconventa
                    Me.AgregarElemento("MedioPago", Me.Dev.MedioPago) '                                          mediopago
                    Me.xml.WriteStartElement("DetalleServicio") '                                       DETALLESERVICOS         *********************************
                    Dim i As Integer = 0
                    For Each Detalle As DatosFE.Models.ObtenerDetallesDevolucion43 In Me.DevDet
                        Me.xml.WriteStartElement("LineaDetalle") '                                      LINEADETALLE            ********************************* 
                        Me.AgregarElementoManual("NumeroLinea", i + 1) : i += 1 '                                    numerolinea
                        Me.AgregarElemento("Codigo", Detalle.Cabys)
                        Me.xml.WriteStartElement("CodigoComercial") '                                   CODIGO                  *********************************
                        Me.AgregarElemento("Tipo", Detalle.Tipo) '                                             tipo
                        Me.AgregarElemento("Codigo", Detalle.Codigo) '                                         codigo
                        Me.xml.WriteEndElement() '                                                      //CODIGO                *********************************
                        Me.AgregarElemento("Cantidad", Detalle.Cantidad) '                                     cantidad
                        Me.AgregarElemento("UnidadMedida", Detalle.UnidadMedida) '                             unidadmedida
                        Me.AgregarElemento("Detalle", Detalle.Detalle) '                                       detalle
                        Me.AgregarElemento("PrecioUnitario", Detalle.PrecioUnitario) '                         preciounitario
                        Me.AgregarElemento("MontoTotal", Detalle.MontoTotal) '                                 montototal
                        If Detalle.MontoDescuento > 0 Then
                            Me.xml.WriteStartElement("Descuento")
                            Me.AgregarElemento("MontoDescuento", Detalle.MontoDescuento) '                     montodescuento
                            Me.AgregarElemento("NaturalezaDescuento", Detalle.NaturalezaDescuento) '           naturalezadescuento
                            Me.xml.WriteEndElement()
                        End If
                        Me.AgregarElemento("SubTotal", Detalle.SubTotal) '                                     subtotal
                        If CDec(Detalle.TarifaImpuesto) > 0 Then
                            Me.xml.WriteStartElement("Impuesto") '                                          IMPUESTO                *********************************
                            Me.AgregarElemento("Codigo", Detalle.CodigoImpuesto) '                                codigo
                            Me.AgregarElemento("CodigoTarifa", Detalle.CodigoTarifa) '                                codigo
                            Me.AgregarElemento("Tarifa", Detalle.TarifaImpuesto) '                                tarifa
                            Me.AgregarElemento("Monto", Detalle.MontoImpuesto) '                                  monto
                            If Detalle.PorcentajeCompraExoneracion >= 1 Then
                                Me.xml.WriteStartElement("Exoneracion") '                                   EXONERACION             *********************************
                                Me.AgregarElemento("TipoDocumento", Detalle.TipoDocumentoExoneracion) '           tipodocumento
                                Me.AgregarElemento("NumeroDocumento", Detalle.NumeroDocumentoExoneracion) '       numerodocumento
                                Me.AgregarElemento("NombreInstitucion", Detalle.NombreInstitucionExoneracion) '   nombreinstitucion
                                Me.AgregarElemento("FechaEmision", Detalle.FechaEmisionExoneracion) '             fechaemision
                                Me.AgregarElemento("PorcentajeExoneracion", Detalle.PorcentajeCompraExoneracion) '     porcentajecompra
                                Me.AgregarElemento("MontoExoneracion", Detalle.MontoImpuestoExoneracion) '           montoimpuesto
                                Me.xml.WriteEndElement() '                                                  //EXONERACION           *********************************
                            End If
                            Me.xml.WriteEndElement() '                                                      //IMPUESTO              *********************************
                            If Detalle.MontoImpuestoExoneracion > 1 Then
                                Me.AgregarElemento("ImpuestoNeto", Detalle.ImpuestoNeto) '                         impuesto neto
                            End If
                        End If
                        Me.AgregarElemento("MontoTotalLinea", Detalle.MontoTotalLinea) '                       montototallinea
                        Me.xml.WriteEndElement() '                                                      //LINEADETALLE          *********************************
                    Next
                    Me.xml.WriteEndElement() '                                                          //DETALLESERVICOS       *********************************
                    Me.xml.WriteStartElement("ResumenFactura") '                                        RESUMENFACTURA          *********************************
                    Me.xml.WriteStartElement("CodigoTipoMoneda") '                                      CODIGOTIPOMONEDA
                    Me.AgregarElemento("CodigoMoneda", Me.Dev.CodigoMoneda) '                                    codigomoneda
                    Me.AgregarElemento("TipoCambio", Me.Dev.TipoCambio) '                                        tipocambio
                    Me.xml.WriteEndElement()
                    Me.AgregarElemento("TotalServGravados", Me.Dev.TotalServGravados) '                          totalservgravados
                    Me.AgregarElemento("TotalServExentos", Me.Dev.TotalServExentos) '                            totalservexento
                    Me.AgregarElemento("TotalServExonerado", Me.Dev.TotalServExonerado) '                        totalservexonerado
                    Me.AgregarElemento("TotalMercanciasGravadas", Me.Dev.TotalMercanciasGravadas) '              totalmercanciasgravadas
                    Me.AgregarElemento("TotalMercanciasExentas", Me.Dev.TotalMercanciasExentas) '                totalmercanciasexenta
                    Me.AgregarElemento("TotalMercExonerada", Me.Dev.TotalMercExonerada) '                        totalmercexonerada
                    Me.AgregarElemento("TotalGravado", Me.Dev.TotalGravado) '                                    totalgravado
                    Me.AgregarElemento("TotalExento", Me.Dev.TotalExento) '                                      totalexento
                    Me.AgregarElemento("TotalExonerado", Me.Dev.TotalExonerado) '                                totalexonerado
                    Me.AgregarElemento("TotalVenta", Me.Dev.TotalVenta) '                                        totalventa
                    Me.AgregarElemento("TotalDescuentos", Me.Dev.TotalDescuentos) '                              totaldescuento
                    Me.AgregarElemento("TotalVentaNeta", Me.Dev.TotalVentaNeta) '                                totalventaneta
                    Me.AgregarElemento("TotalImpuesto", Me.Dev.TotalImpuesto) '                                  totalimpuesto
                    Me.AgregarElemento("TotalComprobante", Me.Dev.TotalComprobante) '                            totalcomprobante
                    Me.xml.WriteEndElement() '                                                          //RESUMENFACTURA        *********************************
                    Me.xml.WriteStartElement("InformacionReferencia") '                                 INFORMACIONREFERENCIA   *********************************
                    Me.AgregarElemento("TipoDoc", Me.Dev.TipoDocReferencia) '                                   tipodoc
                    Me.AgregarElemento("Numero", Me.Dev.NumeroReferencia) '                                     numero
                    Me.AgregarElemento("FechaEmision", Me.Dev.FechaEmisionReferencia) '                         fechaemision
                    Me.AgregarElemento("Codigo", Me.Dev.CodigoReferencia) '                                     codigo
                    Me.AgregarElemento("Razon", Me.Dev.RazonReferencia) '                                       razon
                    Me.xml.WriteEndElement() '                                                          //INFORMACIONREFERENCIA *********************************
                    'Me.xml.WriteStartElement("Normativa") '                                             NORMATIVA               *********************************
                    'Me.AgregarElemento("NumeroResolucion", "NumeroResolucion") '                            numeroresolucion
                    'Me.AgregarElemento("FechaResolucion", "FechaResolucion") '                              fecharesolucion
                    'Me.xml.WriteEndElement() '                                                          //NORMATIVA             *********************************
                    Me.xml.WriteEndElement() '                                                          //FACTURA ELECTRONICA   *********************************
                    Me.xml.WriteEndDocument()
                    Me.xml.Close()
                    Me.xml.Dispose()
                    Me.xml = Nothing
                    Dim xmlElectronica As New Xml.XmlDocument
                    'xmlElectronica.PreserveWhitespace = True
                    xmlElectronica.Load(UbicacionXMLFacturas & "/" & consecutivo & "_00_SF.xml")
                    Dim resultado As String = xmlElectronica.OuterXml
                    xmlElectronica = Nothing
                    RaiseEvent DocumentoGenerado(resultado, _IdDevolucion, "DEVOLUCION")
                    Return True
                Catch ex As Exception
                    RaiseEvent setError(ex.Message)
                    Return False
                End Try
            End Function
            Public Function GeneraXMLMensajeReceptor(_IdMensaje As String) As Boolean
                Try
                    Me.CargarDatosMensaje(_IdMensaje)
                    Dim consecutivo As String = Msg.NumeroConsecutivoReceptor
                    Me.UbicacionXMLCompras = "C:/Compras"
                    Me.UbicacionXMLCompras += "/" & consecutivo
                    If Directory.Exists(Me.UbicacionXMLCompras) = False Then Directory.CreateDirectory(Me.UbicacionXMLCompras)
                    Me.xml = New XmlTextWriter(Me.UbicacionXMLCompras & "/" & consecutivo & "_00_SF.xml", System.Text.Encoding.UTF8)
                    Me.xml.WriteStartDocument(True)
                    Me.xml.Formatting = Formatting.Indented
                    Me.xml.Indentation = 2
                    Me.xml.WriteStartElement("MensajeReceptor")

                    Me.xml.WriteAttributeString("xmlns", "https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/mensajeReceptor")
                    Me.xml.WriteAttributeString("xmlns:xsd", "http://www.w3.org/2001/XMLSchema")
                    Me.xml.WriteAttributeString("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance")
                    Me.xml.WriteAttributeString("xsi:schemaLocation", "https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/mensajeReceptor https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.3/mensajeReceptor.xsd")

                    Me.AgregarElemento("Clave", Msg.Clave)
                    Me.AgregarElemento("NumeroCedulaEmisor", Msg.NumeroCedulaEmisor)
                    Me.AgregarElemento("FechaEmisionDoc", Msg.FechaEmisionDoc)
                    Me.AgregarElemento("Mensaje", Msg.Mensaje)
                    If Msg.Mensaje = "3" Then
                        Me.AgregarElemento("DetalleMensaje", Msg.DetalleMensaje) ' si es de rechazo debo de detallar porque
                    End If
                    Me.AgregarElemento("CodigoActividad", Msg.CodigoActividad) ' el codigo de la actividad
                    Me.AgregarElemento("CondicionImpuesto", Msg.CondicionImpuesto) '
                    If Msg.Mensaje = "1" Then
                        If Me.Msg.CondicionImpuesto <> "05" Then
                            Me.AgregarElemento("MontoTotalImpuestoAcreditar", Msg.MontoTotalImpuestoAcreditar)
                            Me.AgregarElemento("MontoTotalDeGastoAplicable", Msg.MontoTotalDeGastoAplicable)
                        End If
                    End If
                    Me.AgregarElemento("MontoTotalImpuesto", Msg.MontoTotalImpuesto)
                    Me.AgregarElemento("TotalFactura", Msg.TotalFactura)
                    Me.AgregarElemento("NumeroCedulaReceptor", Msg.NumeroCedulaReceptor)
                    Me.AgregarElemento("NumeroConsecutivoReceptor", Msg.NumeroConsecutivoReceptor)
                    Me.xml.WriteEndDocument()
                    Me.xml.Close()
                    Me.xml.Dispose()
                    Me.xml = Nothing

                    Dim xmlElectronica As New Xml.XmlDocument
                    xmlElectronica.Load(Me.UbicacionXMLCompras & "/" & consecutivo & "_00_SF.xml")
                    'xmlElectronica.PreserveWhitespace = True
                    Dim resultado As String = xmlElectronica.OuterXml
                    xmlElectronica = Nothing
                    RaiseEvent DocumentoGenerado(resultado, _IdMensaje, "MENSAJERECEPTOR")
                    Return True
                Catch ex As Exception
                    RaiseEvent setError(ex.Message)
                    Return False
                End Try
            End Function
        End Class
    End Namespace
End Namespace
