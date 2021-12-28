using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Datos.Models
{
    public partial class SeePOSContext : DbContext
    {
        public SeePOSContext()
        {
        }

        public SeePOSContext(DbContextOptions<SeePOSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbonoApartado> AbonoApartados { get; set; }
        public virtual DbSet<AbonoApartadosdetalle> AbonoApartadosdetalles { get; set; }
        public virtual DbSet<Abonoccobrar> Abonoccobrars { get; set; }
        public virtual DbSet<Abonocpagar> Abonocpagars { get; set; }
        public virtual DbSet<Abonoreintegro> Abonoreintegros { get; set; }
        public virtual DbSet<Abtemporal> Abtemporals { get; set; }
        public virtual DbSet<Accion> Accions { get; set; }
        public virtual DbSet<ActividadEmpresa> ActividadEmpresas { get; set; }
        public virtual DbSet<Actividade> Actividades { get; set; }
        public virtual DbSet<AdelantoVenta> AdelantoVentas { get; set; }
        public virtual DbSet<AdelantoVentasDetalle> AdelantoVentasDetalles { get; set; }
        public virtual DbSet<AgenteVenta> AgenteVentas { get; set; }
        public virtual DbSet<AjusteInventario> AjusteInventarios { get; set; }
        public virtual DbSet<AjusteInventarioDetalle> AjusteInventarioDetalles { get; set; }
        public virtual DbSet<Ajustesccobrar> Ajustesccobrars { get; set; }
        public virtual DbSet<Ajustescpagar> Ajustescpagars { get; set; }
        public virtual DbSet<Allcaby> Allcabys { get; set; }
        public virtual DbSet<Apartado> Apartados { get; set; }
        public virtual DbSet<ApartadoDetalle> ApartadoDetalles { get; set; }
        public virtual DbSet<AperturaDenominacione> AperturaDenominaciones { get; set; }
        public virtual DbSet<AperturaTotalTope> AperturaTotalTopes { get; set; }
        public virtual DbSet<Aperturacaja> Aperturacajas { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<AreaArticulo> AreaArticulos { get; set; }
        public virtual DbSet<AreaEncargado> AreaEncargados { get; set; }
        public virtual DbSet<ArqueoCaja> ArqueoCajas { get; set; }
        public virtual DbSet<ArqueoDeposito> ArqueoDepositos { get; set; }
        public virtual DbSet<ArqueoEfectivo> ArqueoEfectivos { get; set; }
        public virtual DbSet<ArqueoTarjetum> ArqueoTarjeta { get; set; }
        public virtual DbSet<ArticulosComprado> ArticulosComprados { get; set; }
        public virtual DbSet<ArticulosComprasDevuelto> ArticulosComprasDevueltos { get; set; }
        public virtual DbSet<ArticulosGasto> ArticulosGastos { get; set; }
        public virtual DbSet<ArticulosProveedor> ArticulosProveedors { get; set; }
        public virtual DbSet<ArticulosRelacionado> ArticulosRelacionados { get; set; }
        public virtual DbSet<ArticulosVentasDevuelto> ArticulosVentasDevueltos { get; set; }
        public virtual DbSet<ArticulosXProveedor> ArticulosXProveedors { get; set; }
        public virtual DbSet<ArticulosXUltimoProveedor> ArticulosXUltimoProveedors { get; set; }
        public virtual DbSet<AutorizacionAdelanto> AutorizacionAdelantos { get; set; }
        public virtual DbSet<AutorizacionVentum> AutorizacionVenta { get; set; }
        public virtual DbSet<Bitacora> Bitacoras { get; set; }
        public virtual DbSet<BitacoraBloqueo> BitacoraBloqueos { get; set; }
        public virtual DbSet<BitacoraEstadoCotizacion> BitacoraEstadoCotizacions { get; set; }
        public virtual DbSet<BitacoraInactivarCliente> BitacoraInactivarClientes { get; set; }
        public virtual DbSet<BitacoraReimpresione> BitacoraReimpresiones { get; set; }
        public virtual DbSet<BitacoraVersion> BitacoraVersions { get; set; }
        public virtual DbSet<Bodega> Bodegas { get; set; }
        public virtual DbSet<CabysProveedore> CabysProveedores { get; set; }
        public virtual DbSet<Cabystemp> Cabystemps { get; set; }
        public virtual DbSet<CajasCantidad> CajasCantidads { get; set; }
        public virtual DbSet<CambioInventario> CambioInventarios { get; set; }
        public virtual DbSet<CartaExoneracion> CartaExoneracions { get; set; }
        public virtual DbSet<CategoriaAccion> CategoriaAccions { get; set; }
        public virtual DbSet<Cheque> Cheques { get; set; }
        public virtual DbSet<ChequesDetalle> ChequesDetalles { get; set; }
        public virtual DbSet<CierreCajaDetMon> CierreCajaDetMons { get; set; }
        public virtual DbSet<CierreCajaDetTarj> CierreCajaDetTarjs { get; set; }
        public virtual DbSet<CierreOrdenTrabajo> CierreOrdenTrabajos { get; set; }
        public virtual DbSet<Cierrecaja> Cierrecajas { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<ClienteCApartado> ClienteCApartados { get; set; }
        public virtual DbSet<ClientesApp> ClientesApps { get; set; }
        public virtual DbSet<ClientesFrecuente> ClientesFrecuentes { get; set; }
        public virtual DbSet<Codigo> Codigos { get; set; }
        public virtual DbSet<Compra> Compras { get; set; }
        public virtual DbSet<CondicionImpuesto> CondicionImpuestos { get; set; }
        public virtual DbSet<Configuracione> Configuraciones { get; set; }
        public virtual DbSet<Consecutivo> Consecutivos { get; set; }
        public virtual DbSet<ConsecutivoReciboReintegro> ConsecutivoReciboReintegros { get; set; }
        public virtual DbSet<ControlLote> ControlLotes { get; set; }
        public virtual DbSet<Correo> Correos { get; set; }
        public virtual DbSet<CostoDevolucione> CostoDevoluciones { get; set; }
        public virtual DbSet<CostoFactura> CostoFacturas { get; set; }
        public virtual DbSet<Cotizacion> Cotizacions { get; set; }
        public virtual DbSet<CotizacionDetalle> CotizacionDetalles { get; set; }
        public virtual DbSet<Credomatic> Credomatics { get; set; }
        public virtual DbSet<CuentasBancariasProveedor> CuentasBancariasProveedors { get; set; }
        public virtual DbSet<Cupon> Cupons { get; set; }
        public virtual DbSet<CuponDetalle> CuponDetalles { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DenominacionMonedum> DenominacionMoneda { get; set; }
        public virtual DbSet<Descuento> Descuentos { get; set; }
        public virtual DbSet<DescuentoProgramado> DescuentoProgramados { get; set; }
        public virtual DbSet<DetalleAbonoccobrar> DetalleAbonoccobrars { get; set; }
        public virtual DbSet<DetalleAbonocpagar> DetalleAbonocpagars { get; set; }
        public virtual DbSet<DetalleAjustescPagar> DetalleAjustescPagars { get; set; }
        public virtual DbSet<DetalleAjustesccobrar> DetalleAjustesccobrars { get; set; }
        public virtual DbSet<DetalleCierrecaja> DetalleCierrecajas { get; set; }
        public virtual DbSet<DetalleDetalle> DetalleDetalles { get; set; }
        public virtual DbSet<DetalleEmpaquetado> DetalleEmpaquetados { get; set; }
        public virtual DbSet<DetalleOrdencompra> DetalleOrdencompras { get; set; }
        public virtual DbSet<DetallePagoCaja> DetallePagoCajas { get; set; }
        public virtual DbSet<DetallePreAbonocCobrar> DetallePreAbonocCobrars { get; set; }
        public virtual DbSet<DetallePrestamo> DetallePrestamos { get; set; }
        public virtual DbSet<DevolucionPrestamo> DevolucionPrestamos { get; set; }
        public virtual DbSet<DevolucionesCompra> DevolucionesCompras { get; set; }
        public virtual DbSet<DevolucionesVenta> DevolucionesVentas { get; set; }
        public virtual DbSet<Emisor> Emisors { get; set; }
        public virtual DbSet<Empaquetado> Empaquetados { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Encargadocompra> Encargadocompras { get; set; }
        public virtual DbSet<EstadoCotizacion> EstadoCotizacions { get; set; }
        public virtual DbSet<ExepcionFirmadocontado> ExepcionFirmadocontados { get; set; }
        public virtual DbSet<Familium> Familia { get; set; }
        public virtual DbSet<FechaMovimientoOpcionesPago> FechaMovimientoOpcionesPagos { get; set; }
        public virtual DbSet<FichasxUsuario> FichasxUsuarios { get; set; }
        public virtual DbSet<FormatoDeCompra> FormatoDeCompras { get; set; }
        public virtual DbSet<Gasto> Gastos { get; set; }
        public virtual DbSet<Gasto1> Gastos1 { get; set; }
        public virtual DbSet<GestionCobroBitacora> GestionCobroBitacoras { get; set; }
        public virtual DbSet<HistorialPrestamo> HistorialPrestamos { get; set; }
        public virtual DbSet<HistoricoSerie> HistoricoSeries { get; set; }
        public virtual DbSet<HojaCxC> HojaCxCs { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<Impuesto> Impuestos { get; set; }
        public virtual DbSet<Inven> Invens { get; set; }
        public virtual DbSet<Inventario> Inventarios { get; set; }
        public virtual DbSet<InventarioGeneral> InventarioGenerals { get; set; }
        public virtual DbSet<InventarioInicial> InventarioInicials { get; set; }
        public virtual DbSet<Kardex> Kardices { get; set; }
        public virtual DbSet<KardexCompra> KardexCompras { get; set; }
        public virtual DbSet<KardexConsignacion> KardexConsignacions { get; set; }
        public virtual DbSet<KardexDevolucionCompra> KardexDevolucionCompras { get; set; }
        public virtual DbSet<KardexDevolucionVentum> KardexDevolucionVenta { get; set; }
        public virtual DbSet<KardexPrestamo> KardexPrestamos { get; set; }
        public virtual DbSet<KardexVario> KardexVarios { get; set; }
        public virtual DbSet<KardexVenta> KardexVentas { get; set; }
        public virtual DbSet<Kcompra> Kcompras { get; set; }
        public virtual DbSet<KdevolucionCompra> KdevolucionCompras { get; set; }
        public virtual DbSet<KdevolucionVenta> KdevolucionVentas { get; set; }
        public virtual DbSet<Kvario> Kvarios { get; set; }
        public virtual DbSet<Kventa> Kventas { get; set; }
        public virtual DbSet<ListadoProducto> ListadoProductos { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<MensajeReceptor> MensajeReceptors { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<MovimientoArticuloVenta> MovimientoArticuloVentas { get; set; }
        public virtual DbSet<MovimientoArticulosCompra> MovimientoArticulosCompras { get; set; }
        public virtual DbSet<MovimientoCaja> MovimientoCajas { get; set; }
        public virtual DbSet<MovimientoClienteSaldo> MovimientoClienteSaldos { get; set; }
        public virtual DbSet<MovimientoCuentaCliente> MovimientoCuentaClientes { get; set; }
        public virtual DbSet<MovimientoCuentaProveedor> MovimientoCuentaProveedors { get; set; }
        public virtual DbSet<MovimientosBodega> MovimientosBodegas { get; set; }
        public virtual DbSet<MovimientosBodegaDetalle> MovimientosBodegaDetalles { get; set; }
        public virtual DbSet<MuertesGasto> MuertesGastos { get; set; }
        public virtual DbSet<MuertesGastosDetalle> MuertesGastosDetalles { get; set; }
        public virtual DbSet<NoMag> NoMags { get; set; }
        public virtual DbSet<OpcionesDePago> OpcionesDePagos { get; set; }
        public virtual DbSet<OpcionesDePagoDevolucione> OpcionesDePagoDevoluciones { get; set; }
        public virtual DbSet<OpcionesDePagoDveDva> OpcionesDePagoDveDvas { get; set; }
        public virtual DbSet<OpcionesDePagoSinCredito> OpcionesDePagoSinCreditos { get; set; }
        public virtual DbSet<OpcionesDePagoSinDve> OpcionesDePagoSinDves { get; set; }
        public virtual DbSet<OrdenCompraAutomática> OrdenCompraAutomáticas { get; set; }
        public virtual DbSet<OrdenTrabajo> OrdenTrabajos { get; set; }
        public virtual DbSet<Ordencompra> Ordencompras { get; set; }
        public virtual DbSet<PagosDuplicado> PagosDuplicados { get; set; }
        public virtual DbSet<PedidoBodega> PedidoBodegas { get; set; }
        public virtual DbSet<Permiso> Permisos { get; set; }
        public virtual DbSet<PreAbonocCobrar> PreAbonocCobrars { get; set; }
        public virtual DbSet<PreTomaGeneral> PreTomaGenerals { get; set; }
        public virtual DbSet<PreTomaGeneralDetalle> PreTomaGeneralDetalles { get; set; }
        public virtual DbSet<PreTomaProveedor> PreTomaProveedors { get; set; }
        public virtual DbSet<PreTomaProveedorDetalle> PreTomaProveedorDetalles { get; set; }
        public virtual DbSet<PreVenta> PreVentas { get; set; }
        public virtual DbSet<PreVentasDetalle> PreVentasDetalles { get; set; }
        public virtual DbSet<PrecioDiferenciado> PrecioDiferenciados { get; set; }
        public virtual DbSet<Presentacione> Presentaciones { get; set; }
        public virtual DbSet<Prestamo> Prestamos { get; set; }
        public virtual DbSet<ProdEmpaquetado> ProdEmpaquetados { get; set; }
        public virtual DbSet<ProductosWeb> ProductosWebs { get; set; }
        public virtual DbSet<Proveedore> Proveedores { get; set; }
        public virtual DbSet<Referenciabancarium> Referenciabancaria { get; set; }
        public virtual DbSet<Referenciacomercial> Referenciacomercials { get; set; }
        public virtual DbSet<RegistroAnulacione> RegistroAnulaciones { get; set; }
        public virtual DbSet<RegistroPermisoAjuste> RegistroPermisoAjustes { get; set; }
        public virtual DbSet<RegistroPermisohabilitar> RegistroPermisohabilitars { get; set; }
        public virtual DbSet<ReporteDescuento> ReporteDescuentos { get; set; }
        public virtual DbSet<ReporteFacturaVentum> ReporteFacturaVenta { get; set; }
        public virtual DbSet<ReporteGerencialInventario> ReporteGerencialInventarios { get; set; }
        public virtual DbSet<ReporteGerencialInventario1> ReporteGerencialInventarios1 { get; set; }
        public virtual DbSet<ReporteMovimientosXFecha> ReporteMovimientosXFechas { get; set; }
        public virtual DbSet<ReporteVentasD1512016> ReporteVentasD1512016s { get; set; }
        public virtual DbSet<ResumenPunto> ResumenPuntos { get; set; }
        public virtual DbSet<Rifa> Rifas { get; set; }
        public virtual DbSet<RifaDetalle> RifaDetalles { get; set; }
        public virtual DbSet<SaldoApartado> SaldoApartados { get; set; }
        public virtual DbSet<Serie> Series { get; set; }
        public virtual DbSet<ServidorFtp> ServidorFtps { get; set; }
        public virtual DbSet<Solicitud> Solicituds { get; set; }
        public virtual DbSet<Solicituddetalle> Solicituddetalles { get; set; }
        public virtual DbSet<Sprestamo> Sprestamos { get; set; }
        public virtual DbSet<SubFamilia> SubFamilias { get; set; }
        public virtual DbSet<SubUbicacion> SubUbicacions { get; set; }
        public virtual DbSet<Sucursale> Sucursales { get; set; }
        public virtual DbSet<TemBodega> TemBodegas { get; set; }
        public virtual DbSet<TemBodegasConsignada> TemBodegasConsignadas { get; set; }
        public virtual DbSet<Temp1> Temp1s { get; set; }
        public virtual DbSet<Tempcaby> Tempcabys { get; set; }
        public virtual DbSet<TemperaturaCamara> TemperaturaCamaras { get; set; }
        public virtual DbSet<TipoExoneracion> TipoExoneracions { get; set; }
        public virtual DbSet<TipoTarjetum> TipoTarjeta { get; set; }
        public virtual DbSet<Toma1> Toma1s { get; set; }
        public virtual DbSet<TomaGeneral> TomaGenerals { get; set; }
        public virtual DbSet<TomaGeneralDetalle> TomaGeneralDetalles { get; set; }
        public virtual DbSet<TomaProveedor> TomaProveedors { get; set; }
        public virtual DbSet<TomaProveedorDetalle> TomaProveedorDetalles { get; set; }
        public virtual DbSet<TrasladoPuntoVentaDetalle> TrasladoPuntoVentaDetalles { get; set; }
        public virtual DbSet<TrasladoPuntoVentum> TrasladoPuntoVenta { get; set; }
        public virtual DbSet<Ubicacione> Ubicaciones { get; set; }
        public virtual DbSet<UltimoAbonoapartado> UltimoAbonoapartados { get; set; }
        public virtual DbSet<UltimoRecibo> UltimoRecibos { get; set; }
        public virtual DbSet<ValidaFirmadocontado> ValidaFirmadocontados { get; set; }
        public virtual DbSet<Variable> Variables { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<VentasContado> VentasContados { get; set; }
        public virtual DbSet<VentasCredito> VentasCreditos { get; set; }
        public virtual DbSet<VentasDetalle> VentasDetalles { get; set; }
        public virtual DbSet<VentasDetalleLote> VentasDetalleLotes { get; set; }
        public virtual DbSet<VentasFiscale> VentasFiscales { get; set; }
        public virtual DbSet<VentasRangoFactura> VentasRangoFacturas { get; set; }
        public virtual DbSet<VentasTaller> VentasTallers { get; set; }
        public virtual DbSet<ViewAdelantosAutorizado> ViewAdelantosAutorizados { get; set; }
        public virtual DbSet<ViewApartadosActivo> ViewApartadosActivos { get; set; }
        public virtual DbSet<ViewArea> ViewAreas { get; set; }
        public virtual DbSet<ViewArticulosDescuento> ViewArticulosDescuentos { get; set; }
        public virtual DbSet<ViewArticulosPromocion> ViewArticulosPromocions { get; set; }
        public virtual DbSet<ViewCajasBloqueada> ViewCajasBloqueadas { get; set; }
        public virtual DbSet<ViewCartaExoneracion> ViewCartaExoneracions { get; set; }
        public virtual DbSet<ViewComprasDevolucionesAnuale> ViewComprasDevolucionesAnuales { get; set; }
        public virtual DbSet<ViewControlLote> ViewControlLotes { get; set; }
        public virtual DbSet<ViewCostoArticulo> ViewCostoArticulos { get; set; }
        public virtual DbSet<ViewDepositosCaja> ViewDepositosCajas { get; set; }
        public virtual DbSet<ViewDescuento> ViewDescuentos { get; set; }
        public virtual DbSet<ViewDevolucione> ViewDevoluciones { get; set; }
        public virtual DbSet<ViewEmpresasInterna> ViewEmpresasInternas { get; set; }
        public virtual DbSet<ViewEstadoCotizacion> ViewEstadoCotizacions { get; set; }
        public virtual DbSet<ViewFacturaCredito> ViewFacturaCreditos { get; set; }
        public virtual DbSet<ViewFacturasPendientesPagada> ViewFacturasPendientesPagadas { get; set; }
        public virtual DbSet<ViewFacturasRepetida> ViewFacturasRepetidas { get; set; }
        public virtual DbSet<ViewImpresoGeneralLote> ViewImpresoGeneralLotes { get; set; }
        public virtual DbSet<ViewImpuesto> ViewImpuestos { get; set; }
        public virtual DbSet<ViewListaMag> ViewListaMags { get; set; }
        public virtual DbSet<ViewMensajeReceptor> ViewMensajeReceptors { get; set; }
        public virtual DbSet<ViewPrestamo> ViewPrestamos { get; set; }
        public virtual DbSet<ViewProductosPunto> ViewProductosPuntos { get; set; }
        public virtual DbSet<ViewReporteDevolucione> ViewReporteDevoluciones { get; set; }
        public virtual DbSet<ViewSaldosCero> ViewSaldosCeros { get; set; }
        public virtual DbSet<ViewSeriesDisponible> ViewSeriesDisponibles { get; set; }
        public virtual DbSet<ViewSubtotalDetalle> ViewSubtotalDetalles { get; set; }
        public virtual DbSet<ViewSubtotalesDevolucione> ViewSubtotalesDevoluciones { get; set; }
        public virtual DbSet<ViewSubtotalesDevoluciones43> ViewSubtotalesDevoluciones43s { get; set; }
        public virtual DbSet<ViewSubtotalesFactura> ViewSubtotalesFacturas { get; set; }
        public virtual DbSet<ViewSubtotalesFactura43> ViewSubtotalesFactura43s { get; set; }
        public virtual DbSet<ViewTomaGeneral> ViewTomaGenerals { get; set; }
        public virtual DbSet<ViewUltimaCompra> ViewUltimaCompras { get; set; }
        public virtual DbSet<ViewUtilidadArticulo> ViewUtilidadArticulos { get; set; }
        public virtual DbSet<ViewVentasAgente> ViewVentasAgentes { get; set; }
        public virtual DbSet<ViewVentasDevolucionesAnuale> ViewVentasDevolucionesAnuales { get; set; }
        public virtual DbSet<ViewVentasHora> ViewVentasHoras { get; set; }
        public virtual DbSet<ViewVentasHuber> ViewVentasHubers { get; set; }
        public virtual DbSet<VistaAbono> VistaAbonos { get; set; }
        public virtual DbSet<VistaArmamento> VistaArmamentos { get; set; }
        public virtual DbSet<VistaComprasCredito> VistaComprasCreditos { get; set; }
        public virtual DbSet<VistaFactura> VistaFacturas { get; set; }
        public virtual DbSet<VistaGeneradorBarra> VistaGeneradorBarras { get; set; }
        public virtual DbSet<VistaInventarioCostoReal> VistaInventarioCostoReals { get; set; }
        public virtual DbSet<VistaKardexMovimiento> VistaKardexMovimientos { get; set; }
        public virtual DbSet<VistaOrdenCAutoXProveedor> VistaOrdenCAutoXProveedors { get; set; }
        public virtual DbSet<VistaPecesCompra> VistaPecesCompras { get; set; }
        public virtual DbSet<VistaPrestamosInventario> VistaPrestamosInventarios { get; set; }
        public virtual DbSet<VistaProductosCotizadosXCliente> VistaProductosCotizadosXClientes { get; set; }
        public virtual DbSet<VistaProductosOrganico> VistaProductosOrganicos { get; set; }
        public virtual DbSet<VistaQuimico> VistaQuimicos { get; set; }
        public virtual DbSet<VistaReporteInventarioGrafico> VistaReporteInventarioGraficos { get; set; }
        public virtual DbSet<VistaTiendum> VistaTienda { get; set; }
        public virtual DbSet<VistaVentaDetalle> VistaVentaDetalles { get; set; }
        public virtual DbSet<VistaVentaMaquinarium> VistaVentaMaquinaria { get; set; }
        public virtual DbSet<VistaVentasClinica> VistaVentasClinicas { get; set; }
        public virtual DbSet<VistaVentasMascota> VistaVentasMascotas { get; set; }
        public virtual DbSet<VistaVentasPece> VistaVentasPeces { get; set; }
        public virtual DbSet<VistaVentasTaller> VistaVentasTallers { get; set; }
        public virtual DbSet<Vistasiningresar> Vistasiningresars { get; set; }
        public virtual DbSet<VwReporteLote> VwReporteLotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ALBERTO-PC\\QSOFT2017; Database=SeePOS; User=sa; Password=QsoftMSDEsa2005;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<AbonoApartado>(entity =>
            {
                entity.HasKey(e => e.IdAbonoapartado);

                entity.ToTable("Abono_Apartados");

                entity.Property(e => e.IdAbonoapartado).HasColumnName("Id_abonoapartado");

                entity.Property(e => e.CedUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Ced_Usuario")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumRecibo).HasColumnName("Num_Recibo");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SaldoActual).HasColumnName("Saldo_Actual");

                entity.Property(e => e.SaldoCuenta).HasColumnName("Saldo_Cuenta");
            });

            modelBuilder.Entity<AbonoApartadosdetalle>(entity =>
            {
                entity.HasKey(e => e.IdDetalleabono);

                entity.ToTable("Abono_apartadosdetalle");

                entity.Property(e => e.IdDetalleabono).HasColumnName("id_detalleabono");

                entity.Property(e => e.AbonoSuMoneda).HasColumnName("Abono_SuMoneda");

                entity.Property(e => e.Apartado).HasColumnName("apartado");

                entity.Property(e => e.IdAbonoapartado).HasColumnName("Id_abonoapartado");

                entity.Property(e => e.SaldoAnt).HasColumnName("Saldo_Ant");

                entity.HasOne(d => d.ApartadoNavigation)
                    .WithMany(p => p.AbonoApartadosdetalles)
                    .HasForeignKey(d => d.Apartado)
                    .HasConstraintName("FK_Abono_apartadosdetalle_Apartados");

                entity.HasOne(d => d.IdAbonoapartadoNavigation)
                    .WithMany(p => p.AbonoApartadosdetalles)
                    .HasForeignKey(d => d.IdAbonoapartado)
                    .HasConstraintName("FK_Abono_apartadosdetalle_Abono_Apartados");
            });

            modelBuilder.Entity<Abonoccobrar>(entity =>
            {
                entity.HasKey(e => e.IdRecibo);

                entity.ToTable("abonoccobrar");

                entity.Property(e => e.IdRecibo).HasColumnName("Id_Recibo");

                entity.Property(e => e.Banco)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("banco");

                entity.Property(e => e.CedUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Ced_Usuario")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cheque)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.EstadoEnvio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumApertura)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Num_Apertura");

                entity.Property(e => e.NumCaja).HasColumnName("Num_Caja");

                entity.Property(e => e.NumRecibo).HasColumnName("Num_Recibo");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SaldoActual).HasColumnName("Saldo_Actual");

                entity.Property(e => e.SaldoCuenta).HasColumnName("Saldo_Cuenta");
            });

            modelBuilder.Entity<Abonocpagar>(entity =>
            {
                entity.HasKey(e => e.IdAbonocpagar);

                entity.ToTable("abonocpagar");

                entity.HasIndex(e => new { e.Documento, e.TipoDocumento, e.CuentaBancaria }, "IX_abonocpagar_Control_Duplicado_Documento")
                    .IsUnique();

                entity.Property(e => e.IdAbonocpagar).HasColumnName("Id_Abonocpagar");

                entity.Property(e => e.CedulaUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_Usuario")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodMoneda).HasColumnName("cod_Moneda");

                entity.Property(e => e.CodProveedor).HasColumnName("Cod_Proveedor");

                entity.Property(e => e.CodigoBanco)
                    .HasColumnName("Codigo_banco")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CuentaBancaria)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaEntrada)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.MontoLetras)
                    .IsRequired()
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('--')");

                entity.Property(e => e.Recibo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SaldoActual).HasColumnName("Saldo_Actual");

                entity.Property(e => e.SaldoCuenta).HasColumnName("Saldo_Cuenta");

                entity.Property(e => e.TipoCambio).HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodProveedorNavigation)
                    .WithMany(p => p.Abonocpagars)
                    .HasForeignKey(d => d.CodProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_abonocpagar_Proveedores");
            });

            modelBuilder.Entity<Abonoreintegro>(entity =>
            {
                entity.HasKey(e => e.IdAbono);

                entity.ToTable("abonoreintegro");

                entity.Property(e => e.IdAbono)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdFactura)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Factura");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.NumApertura).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Recibo).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Abtemporal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("abtemporal");

                entity.Property(e => e.Barras)
                    .HasMaxLength(255)
                    .HasColumnName("barras");

                entity.Property(e => e.Cabys)
                    .HasMaxLength(255)
                    .HasColumnName("cabys");
            });

            modelBuilder.Entity<Accion>(entity =>
            {
                entity.ToTable("accion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Anulada).HasColumnName("anulada");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("date")
                    .HasColumnName("fecha_fin");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("fecha_inicio");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("nombre");

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("observacion");
            });

            modelBuilder.Entity<ActividadEmpresa>(entity =>
            {
                entity.ToTable("ActividadEmpresa");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Actividad)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IdActividad).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Actividade>(entity =>
            {
                entity.ToTable("actividades");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Actividad)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<AdelantoVenta>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.NumFactura, e.Tipo, e.NumCaja }, "IX_AdelantoVentas")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Agente).HasColumnName("agente");

                entity.Property(e => e.Apartado).HasColumnName("apartado");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000000000')");

                entity.Property(e => e.CedulaUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_Usuario");

                entity.Property(e => e.ClaveMh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ClaveMH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodAgente).HasColumnName("cod_agente");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodEncargadoCompra)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Encargado_Compra");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.ConsecutivoMh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ConsecutivoMH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContabilizadoCventa).HasColumnName("ContabilizadoCVenta");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EnviadoMh).HasColumnName("EnviadoMH");

                entity.Property(e => e.EstadoMh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EstadoMH")
                    .HasDefaultValueSql("('pendiente')");

                entity.Property(e => e.ExcluirCxC).HasColumnName("excluirCxC");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.ImpVenta).HasColumnName("Imp_Venta");

                entity.Property(e => e.MonedaNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Moneda_Nombre");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumApertura).HasColumnName("Num_Apertura");

                entity.Property(e => e.NumCaja)
                    .HasColumnName("Num_Caja")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Orden)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PagoComision).HasColumnName("Pago_Comision");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");

                entity.Property(e => e.TipoCedula)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('FISICA')");

                entity.Property(e => e.Vence).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<AdelantoVentasDetalle>(entity =>
            {
                entity.HasKey(e => e.IdVentaDetalle);

                entity.ToTable("AdelantoVentas_Detalle");

                entity.Property(e => e.IdVentaDetalle).HasColumnName("id_venta_detalle");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodMonedaVenta)
                    .HasColumnName("Cod_MonedaVenta")
                    .HasDefaultValueSql("((500))");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Disminuye).HasDefaultValueSql("((0))");

                entity.Property(e => e.Empaquetado).HasColumnName("empaquetado");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.IdBodega)
                    .HasColumnName("id_bodega")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");

                entity.Property(e => e.IdTipoExoneracion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Lote)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxDescuento).HasColumnName("Max_Descuento");

                entity.Property(e => e.MontoDescuento).HasColumnName("Monto_Descuento");

                entity.Property(e => e.MontoImpuesto).HasColumnName("Monto_Impuesto");

                entity.Property(e => e.NotaPantalla)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nota_pantalla")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.NumeroDocumento)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumeroEntrega).HasColumnName("Numero_Entrega");

                entity.Property(e => e.PorcentajeCompra).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PrecioBase).HasColumnName("Precio_Base");

                entity.Property(e => e.PrecioCosto).HasColumnName("Precio_Costo");

                entity.Property(e => e.PrecioFlete).HasColumnName("Precio_Flete");

                entity.Property(e => e.PrecioOtros).HasColumnName("Precio_Otros");

                entity.Property(e => e.PrecioUnit).HasColumnName("Precio_Unit");

                entity.Property(e => e.Regalias)
                    .HasColumnName("regalias")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoCambioValorCompra)
                    .HasColumnName("Tipo_Cambio_ValorCompra")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.AdelantoVentasDetalles)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdelantoVentas_Detalle_Inventario");

                entity.HasOne(d => d.IdFacturaNavigation)
                    .WithMany(p => p.AdelantoVentasDetalles)
                    .HasForeignKey(d => d.IdFactura)
                    .HasConstraintName("FK_AdelantoVentas_Detalle_Ventas");
            });

            modelBuilder.Entity<AgenteVenta>(entity =>
            {
                entity.ToTable("agente_ventas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Anulado).HasColumnName("anulado");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cedula");

                entity.Property(e => e.Correo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.Property(e => e.TipoPrecio)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AjusteInventario>(entity =>
            {
                entity.HasKey(e => e.Consecutivo);

                entity.ToTable("AjusteInventario");

                entity.Property(e => e.Asiento).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Contabilizado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");
            });

            modelBuilder.Entity<AjusteInventarioDetalle>(entity =>
            {
                entity.HasKey(e => e.Consecutivo);

                entity.ToTable("AjusteInventario_Detalle");

                entity.Property(e => e.CodArticulo).HasColumnName("Cod_Articulo");

                entity.Property(e => e.CodArticulo1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CodArticulo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ConsAjuste).HasColumnName("Cons_Ajuste");

                entity.Property(e => e.CuentaContable)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cuenta_contable")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cuentacontable1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CUENTACONTABLE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DescArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Desc_Articulo");

                entity.Property(e => e.Descripcioncuentacontable)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCIONCUENTACONTABLE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gasto).HasColumnName("gasto");

                entity.Property(e => e.Muerte).HasColumnName("muerte");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("observacion")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.CodArticuloNavigation)
                    .WithMany(p => p.AjusteInventarioDetalles)
                    .HasForeignKey(d => d.CodArticulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AjusteInventario_Detalle_Inventario");

                entity.HasOne(d => d.ConsAjusteNavigation)
                    .WithMany(p => p.AjusteInventarioDetalles)
                    .HasForeignKey(d => d.ConsAjuste)
                    .HasConstraintName("FK_AjusteInventario_Detalle_AjusteInventario");
            });

            modelBuilder.Entity<Ajustesccobrar>(entity =>
            {
                entity.HasKey(e => e.IdAjuste);

                entity.ToTable("ajustesccobrar");

                entity.Property(e => e.IdAjuste).HasColumnName("ID_Ajuste");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.CodUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Usuario");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SaldoAct).HasColumnName("Saldo_Act");

                entity.Property(e => e.SaldoPrev).HasColumnName("Saldo_Prev");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Ajustescpagar>(entity =>
            {
                entity.HasKey(e => e.IdAjuste);

                entity.ToTable("Ajustescpagar");

                entity.Property(e => e.IdAjuste).HasColumnName("ID_Ajuste");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.CodProveedor).HasColumnName("Cod_Proveedor");

                entity.Property(e => e.CodUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Usuario");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaEntrada)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.NombreProveedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Proveedor");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaldoAct).HasColumnName("Saldo_Act");

                entity.Property(e => e.SaldoPrev).HasColumnName("Saldo_Prev");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.CodProveedorNavigation)
                    .WithMany(p => p.Ajustescpagars)
                    .HasForeignKey(d => d.CodProveedor)
                    .HasConstraintName("FK_Ajustescpagar_Proveedores");
            });

            modelBuilder.Entity<Allcaby>(entity =>
            {
                entity.ToTable("allcabys");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Barras)
                    .HasMaxLength(255)
                    .HasColumnName("barras");

                entity.Property(e => e.Cabys).HasColumnName("cabys");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Apartado>(entity =>
            {
                entity.HasKey(e => e.IdApartado);

                entity.Property(e => e.IdApartado).HasColumnName("Id_Apartado");

                entity.Property(e => e.Cedulausuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodMoneda)
                    .HasColumnName("Cod_Moneda")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.ImpVenta).HasColumnName("Imp_Venta");

                entity.Property(e => e.Nombrecliente)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");

                entity.Property(e => e.Vence)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ApartadoDetalle>(entity =>
            {
                entity.HasKey(e => e.IdDetalle);

                entity.ToTable("Apartado_detalle");

                entity.Property(e => e.IdDetalle).HasColumnName("Id_detalle");

                entity.Property(e => e.CodArticulo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod_articulo");

                entity.Property(e => e.CodMonedaVenta).HasColumnName("Cod_MonedaVenta");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdApartado).HasColumnName("Id_Apartado");

                entity.Property(e => e.MaxDescuento).HasColumnName("Max_Descuento");

                entity.Property(e => e.MontoDescuento).HasColumnName("Monto_descuento");

                entity.Property(e => e.MontoImpuesto).HasColumnName("Monto_Impuesto");

                entity.Property(e => e.PrecioBase).HasColumnName("Precio_Base");

                entity.Property(e => e.PrecioCosto).HasColumnName("Precio_Costo");

                entity.Property(e => e.PrecioFlete).HasColumnName("Precio_Flete");

                entity.Property(e => e.PrecioOtros).HasColumnName("Precio_Otros");

                entity.Property(e => e.PrecioUnit).HasColumnName("Precio_Unit");

                entity.Property(e => e.TipoCambioValorCompra).HasColumnName("Tipo_Cambio_ValorCompra");

                entity.HasOne(d => d.IdApartadoNavigation)
                    .WithMany(p => p.ApartadoDetalles)
                    .HasForeignKey(d => d.IdApartado)
                    .HasConstraintName("FK_Apartado_detalle_Apartados");
            });

            modelBuilder.Entity<AperturaDenominacione>(entity =>
            {
                entity.ToTable("Apertura_Denominaciones");

                entity.Property(e => e.IdApertura).HasColumnName("Id_Apertura");

                entity.Property(e => e.IdDenominacion).HasColumnName("Id_Denominacion");
            });

            modelBuilder.Entity<AperturaTotalTope>(entity =>
            {
                entity.HasKey(e => e.IdTotalTope);

                entity.ToTable("Apertura_Total_Tope");

                entity.Property(e => e.IdTotalTope).HasColumnName("id_total_tope");

                entity.Property(e => e.MonedaNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MontoTope).HasColumnName("Monto_Tope");

                entity.Property(e => e.Napertura).HasColumnName("NApertura");

                entity.HasOne(d => d.NaperturaNavigation)
                    .WithMany(p => p.AperturaTotalTopes)
                    .HasForeignKey(d => d.Napertura)
                    .HasConstraintName("FK_Apertura_Total_Tope_aperturacaja");
            });

            modelBuilder.Entity<Aperturacaja>(entity =>
            {
                entity.HasKey(e => e.Napertura);

                entity.ToTable("aperturacaja");

                entity.Property(e => e.Napertura).HasColumnName("NApertura");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumCaja).HasColumnName("Num_Caja");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasKey(e => e.IdArea);

                entity.ToTable("Area");

                entity.Property(e => e.IdArea)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<AreaArticulo>(entity =>
            {
                entity.HasKey(e => e.IdAreaArticulo);

                entity.ToTable("AreaArticulo");

                entity.Property(e => e.IdAreaArticulo)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Codigo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdArea).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<AreaEncargado>(entity =>
            {
                entity.HasKey(e => e.IdAreaEncargado);

                entity.ToTable("AreaEncargado");

                entity.Property(e => e.IdAreaEncargado)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdArea).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ArqueoCaja>(entity =>
            {
                entity.Property(e => e.Cajero)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('--')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('--')");
            });

            modelBuilder.Entity<ArqueoDeposito>(entity =>
            {
                entity.ToTable("ArqueoDeposito");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Banco)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cuenta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdApertura).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdArqueo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Deposito')");
            });

            modelBuilder.Entity<ArqueoEfectivo>(entity =>
            {
                entity.ToTable("ArqueoEfectivo");

                entity.Property(e => e.IdArqueo).HasColumnName("Id_Arqueo");

                entity.Property(e => e.IdDenominacion).HasColumnName("Id_Denominacion");
            });

            modelBuilder.Entity<ArqueoTarjetum>(entity =>
            {
                entity.Property(e => e.IdArqueo).HasColumnName("Id_Arqueo");

                entity.Property(e => e.IdTarjeta).HasColumnName("Id_Tarjeta");
            });

            modelBuilder.Entity<ArticulosComprado>(entity =>
            {
                entity.HasKey(e => e.IdArticuloComprados);

                entity.ToTable("articulos_comprados");

                entity.Property(e => e.IdArticuloComprados).HasColumnName("Id_ArticuloComprados");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodArticuloBonificacion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodCabys)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DescuentoP).HasColumnName("Descuento_P");

                entity.Property(e => e.ImpuestoP).HasColumnName("Impuesto_P");

                entity.Property(e => e.Lote)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MontoFlete).HasColumnName("Monto_Flete");

                entity.Property(e => e.PrecioA).HasColumnName("Precio_A");

                entity.Property(e => e.PrecioB).HasColumnName("Precio_B");

                entity.Property(e => e.PrecioC).HasColumnName("Precio_C");

                entity.Property(e => e.PrecioD).HasColumnName("Precio_D");

                entity.HasOne(d => d.IdCompraNavigation)
                    .WithMany(p => p.ArticulosComprados)
                    .HasForeignKey(d => d.IdCompra)
                    .HasConstraintName("FK_articulos_comprados_compras");
            });

            modelBuilder.Entity<ArticulosComprasDevuelto>(entity =>
            {
                entity.HasKey(e => e.Consecutivo);

                entity.ToTable("articulos_Compras_devueltos");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MontoDescuento).HasColumnName("Monto_Descuento");

                entity.Property(e => e.MontoImpuesto).HasColumnName("Monto_Impuesto");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecioBase).HasColumnName("Precio_Base");

                entity.Property(e => e.PrecioCosto).HasColumnName("Precio_Costo");

                entity.Property(e => e.PrecioFlete).HasColumnName("Precio_Flete");

                entity.Property(e => e.PrecioOtros).HasColumnName("Precio_Otros");

                entity.HasOne(d => d.DevolucionNavigation)
                    .WithMany(p => p.ArticulosComprasDevueltos)
                    .HasForeignKey(d => d.Devolucion)
                    .HasConstraintName("FK_articulos_Compras_devueltos_devoluciones_Compras");
            });

            modelBuilder.Entity<ArticulosGasto>(entity =>
            {
                entity.HasKey(e => e.IdArticuloComprados);

                entity.ToTable("Articulos_Gastos");

                entity.Property(e => e.IdArticuloComprados).HasColumnName("Id_ArticuloComprados");

                entity.Property(e => e.CuentaContable)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DescTipoCompra)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescuentoP).HasColumnName("Descuento_P");

                entity.Property(e => e.ImpuestoP).HasColumnName("Impuesto_P");

                entity.Property(e => e.MontoFlete).HasColumnName("Monto_Flete");

                entity.HasOne(d => d.IdCompraNavigation)
                    .WithMany(p => p.ArticulosGastos)
                    .HasForeignKey(d => d.IdCompra)
                    .HasConstraintName("FK_Articulos_Gastos_compras");
            });

            modelBuilder.Entity<ArticulosProveedor>(entity =>
            {
                entity.ToTable("articulos_proveedor");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CantidadxPresentacion)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("CANTIDADxPRESENTACION")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CEDULA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoProveedor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CODIGO_PROVEEDOR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdArticulo)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ID_ARTICULO");
            });

            modelBuilder.Entity<ArticulosRelacionado>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.Codigo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodigoPrincipal).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ArticulosVentasDevuelto>(entity =>
            {
                entity.HasKey(e => e.Consecutivo);

                entity.ToTable("articulos_ventas_devueltos");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Devuelto).HasColumnName("devuelto");

                entity.Property(e => e.Empaquetado).HasColumnName("empaquetado");

                entity.Property(e => e.IdArtVenta).HasColumnName("Id_Art_Venta");

                entity.Property(e => e.IdArticuloV)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("id_articulo_V")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MontoDescuento).HasColumnName("Monto_Descuento");

                entity.Property(e => e.MontoImpuesto).HasColumnName("Monto_Impuesto");

                entity.Property(e => e.PrecioBase).HasColumnName("Precio_Base");

                entity.Property(e => e.PrecioCosto).HasColumnName("Precio_Costo");

                entity.Property(e => e.PrecioFlete).HasColumnName("Precio_Flete");

                entity.Property(e => e.PrecioOtros).HasColumnName("Precio_Otros");

                entity.Property(e => e.PrecioUnit).HasColumnName("Precio_Unit");

                entity.Property(e => e.Recibido).HasColumnName("recibido");

                entity.HasOne(d => d.DevolucionNavigation)
                    .WithMany(p => p.ArticulosVentasDevueltos)
                    .HasForeignKey(d => d.Devolucion)
                    .HasConstraintName("FK_articulos_ventas_devueltos_devoluciones_ventas");
            });

            modelBuilder.Entity<ArticulosXProveedor>(entity =>
            {
                entity.HasKey(e => new { e.CodigoArticulo, e.CodigoProveedor });

                entity.ToTable("Articulos x Proveedor");

                entity.Property(e => e.FechaUltimaCompra)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ArticulosXUltimoProveedor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Articulos_X_Ultimo_Proveedor");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutorizacionAdelanto>(entity =>
            {
                entity.ToTable("AutorizacionAdelanto");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CedulaRetira)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Cedula_Retira");

                entity.Property(e => e.FechaFacturacion).HasColumnType("datetime");

                entity.Property(e => e.IdAdelanto)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Adelanto");

                entity.Property(e => e.IdAdmin)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Id_Admin");

                entity.Property(e => e.IdCajero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Id_Cajero");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.NombreRetira)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Nombre_Retira");
            });

            modelBuilder.Entity<AutorizacionVentum>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CedulaRetira)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Cedula_Retira");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.IdAdmin)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Id_Admin");

                entity.Property(e => e.IdApertura).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdCajero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Id_Cajero");

                entity.Property(e => e.IdFactura)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Factura");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.NombreRetira)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Nombre_Retira");

                entity.Property(e => e.NumRecibo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TelefonoRetira)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Telefono_Retira")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Bitacora>(entity =>
            {
                entity.HasKey(e => e.Secuencia);

                entity.ToTable("Bitacora");

                entity.Property(e => e.Accion)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CampoClave)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Campo_Clave")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DescripcionCampo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InSucursal).HasColumnName("inSucursal");

                entity.Property(e => e.Tabla)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<BitacoraBloqueo>(entity =>
            {
                entity.ToTable("bitacora_bloqueos");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Ini)
                    .HasColumnType("datetime")
                    .HasColumnName("ini");

                entity.Property(e => e.Obs)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("obs");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<BitacoraEstadoCotizacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BitacoraEstadoCotizacion");

                entity.Property(e => e.Cotizacion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<BitacoraInactivarCliente>(entity =>
            {
                entity.ToTable("BitacoraInactivarCliente");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<BitacoraReimpresione>(entity =>
            {
                entity.ToTable("Bitacora_reimpresiones");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("cedula");

                entity.Property(e => e.Factura).HasColumnName("factura");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<BitacoraVersion>(entity =>
            {
                entity.ToTable("BitacoraVersion");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Pc)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("PC");
            });

            modelBuilder.Entity<Bodega>(entity =>
            {
                entity.HasKey(e => e.IdBodega);

                entity.Property(e => e.IdBodega).HasColumnName("ID_Bodega");

                entity.Property(e => e.Bloqueada)
                    .HasColumnName("bloqueada")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.NombreBodega)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Bodega")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CabysProveedore>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Cabys)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Consecutivo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<Cabystemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cabystemp");

                entity.Property(e => e.Barra)
                    .HasMaxLength(50)
                    .HasColumnName("barra");

                entity.Property(e => e.Cabys)
                    .HasMaxLength(50)
                    .HasColumnName("cabys");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<CajasCantidad>(entity =>
            {
                entity.HasKey(e => e.IdCaja);

                entity.ToTable("Cajas_Cantidad");

                entity.Property(e => e.IdCaja).HasColumnName("id_Caja");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.NumApertura).HasColumnName("Num_Apertura");

                entity.Property(e => e.NumCaja).HasColumnName("Num_Caja");
            });

            modelBuilder.Entity<CambioInventario>(entity =>
            {
                entity.ToTable("CambioInventario");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodigoEntregado).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodigoFacturado).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CartaExoneracion>(entity =>
            {
                entity.ToTable("CartaExoneracion");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaVence).HasColumnType("datetime");

                entity.Property(e => e.Nota)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumeroDocumento)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CategoriaAccion>(entity =>
            {
                entity.ToTable("categoria_accion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("categoria");
            });

            modelBuilder.Entity<Cheque>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Cheque");

                entity.Property(e => e.CedUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Ced_Usuario");

                entity.Property(e => e.Facturas).HasMaxLength(255);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdCheque).HasColumnName("Id_Cheque");

                entity.Property(e => e.MontoLetras)
                    .IsRequired()
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Portador)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChequesDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Cheques_Detalle");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.IdCheque)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id_Cheque");

                entity.Property(e => e.NombreCuenta)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cuenta");
            });

            modelBuilder.Entity<CierreCajaDetMon>(entity =>
            {
                entity.HasKey(e => e.IdDetaMoneda)
                    .HasName("PK_CiereCaja_DetMoneda");

                entity.ToTable("CierreCaja_DetMon");

                entity.Property(e => e.IdDetaMoneda).HasColumnName("Id_DetaMoneda");

                entity.Property(e => e.IdCierreCaja).HasColumnName("Id_CierreCaja");

                entity.Property(e => e.IdMoneda).HasColumnName("Id_Moneda");

                entity.HasOne(d => d.IdCierreCajaNavigation)
                    .WithMany(p => p.CierreCajaDetMons)
                    .HasForeignKey(d => d.IdCierreCaja)
                    .HasConstraintName("FK_CierreCaja_DetMon_cierrecaja");
            });

            modelBuilder.Entity<CierreCajaDetTarj>(entity =>
            {
                entity.HasKey(e => e.IdDetalleTarjeta);

                entity.ToTable("CierreCaja_DetTarj");

                entity.Property(e => e.IdDetalleTarjeta).HasColumnName("Id_DetalleTarjeta");

                entity.Property(e => e.IdCierreCaja).HasColumnName("Id_CierreCaja");

                entity.Property(e => e.IdTipoTarjeta).HasColumnName("Id_TipoTarjeta");

                entity.HasOne(d => d.IdCierreCajaNavigation)
                    .WithMany(p => p.CierreCajaDetTarjs)
                    .HasForeignKey(d => d.IdCierreCaja)
                    .HasConstraintName("FK_CierreCaja_DetTarj_cierrecaja");
            });

            modelBuilder.Entity<CierreOrdenTrabajo>(entity =>
            {
                entity.HasKey(e => e.IdCierre);

                entity.ToTable("CierreOrdenTrabajo");

                entity.Property(e => e.IdCierre)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdOrden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Cierrecaja>(entity =>
            {
                entity.HasKey(e => e.NumeroCierre);

                entity.ToTable("cierrecaja");

                entity.Property(e => e.Cajera)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Identificacion);

                entity.Property(e => e.Identificacion)
                    .ValueGeneratedNever()
                    .HasColumnName("identificacion");

                entity.Property(e => e.Abierto)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("abierto")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.Agente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("agente")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cedula")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClienteMoroso).HasColumnName("Cliente_Moroso");

                entity.Property(e => e.CodMonedaCredito).HasDefaultValueSql("((1))");

                entity.Property(e => e.CorreoComprobante)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CorreoRecibo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Descuento).HasColumnName("descuento");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("direccion")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("e_mail")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("empresa")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.Fax01)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("fax_01")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fax02)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("fax_02")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdTipoExoneracion)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Impuesto).HasColumnName("impuesto");

                entity.Property(e => e.Mag).HasColumnName("MAG");

                entity.Property(e => e.MaxCredito).HasColumnName("max_credito");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nombre")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nombreusuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreusuario")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Notificar).HasColumnName("notificar");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("observaciones")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PlazoCredito).HasColumnName("Plazo_credito");

                entity.Property(e => e.Sinrestriccion)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sinrestriccion")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.Telefono01)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Telefono_01")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telefono02)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("telefono_02")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TipoCedula)
                    .HasMaxLength(50)
                    .HasColumnName("tipo_cedula");

                entity.Property(e => e.TipoCliente)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'FISICA')");

                entity.Property(e => e.Tipoprecio).HasColumnName("tipoprecio");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ClienteCApartado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Cliente_cApartados");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cedula");

                entity.Property(e => e.Identificacion).HasColumnName("identificacion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<ClientesApp>(entity =>
            {
                entity.ToTable("ClientesApp");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(900)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ClientesFrecuente>(entity =>
            {
                entity.HasKey(e => e.Identificacion);

                entity.ToTable("Clientes_frecuentes");

                entity.Property(e => e.Identificacion)
                    .ValueGeneratedNever()
                    .HasColumnName("identificacion");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cedula");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("e_mail");

                entity.Property(e => e.Esempresa).HasColumnName("esempresa");

                entity.Property(e => e.Fax01)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("fax_01");

                entity.Property(e => e.Fax02)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("fax_02");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Nombreusuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreusuario");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.Telefono01)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Telefono_01");

                entity.Property(e => e.Telefono02)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("telefono_02");

                entity.Property(e => e.TipoCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('FISICA')");

                entity.Property(e => e.Tipoprecio).HasColumnName("tipoprecio");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<Codigo>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodAlterno1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Cod_Alterno1");

                entity.Property(e => e.CodAlterno2)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Cod_Alterno2");

                entity.Property(e => e.Codigo1).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Codigo2).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Descripcion1)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Descripcion2)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IdPuntoVenta1).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdPuntoVenta2).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => e.IdCompra);

                entity.ToTable("compras");

                entity.HasIndex(e => new { e.Factura, e.CodigoProv, e.TipoCompra }, "IX_compras")
                    .IsUnique();

                entity.Property(e => e.IdCompra).HasColumnName("Id_Compra");

                entity.Property(e => e.CedulaUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaveDgt)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ClaveDGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodMonedaCompra).HasColumnName("Cod_MonedaCompra");

                entity.Property(e => e.CodigoActividad)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Compra1).HasColumnName("Compra");

                entity.Property(e => e.ConsecutivoDgt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ConsecutivoDGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EnviadoDgt).HasColumnName("EnviadoDGT");

                entity.Property(e => e.EstadoDgt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EstadoDGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fec).HasColumnName("FEC");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.MotivoGasto)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumOrden).HasColumnName("num_orden");

                entity.Property(e => e.NumTrans)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TipoCompra)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.Vence).HasColumnType("datetime");

                entity.HasOne(d => d.CodigoProvNavigation)
                    .WithMany(p => p.Compras)
                    .HasForeignKey(d => d.CodigoProv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_compras_Proveedores");
            });

            modelBuilder.Entity<CondicionImpuesto>(entity =>
            {
                entity.HasKey(e => e.IdCondicion);

                entity.ToTable("CondicionImpuesto");

                entity.Property(e => e.IdCondicion)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Condicion)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Configuracione>(entity =>
            {
                entity.HasKey(e => e.Cedula);

                entity.ToTable("configuraciones");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EditarNombre).HasColumnName("editar_nombre");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Empresa1)
                    .HasMaxLength(150)
                    .HasColumnName("empresa1");

                entity.Property(e => e.Empresa2)
                    .HasMaxLength(150)
                    .HasColumnName("empresa2");

                entity.Property(e => e.Empresa3)
                    .HasMaxLength(150)
                    .HasColumnName("empresa3");

                entity.Property(e => e.Fax01)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Fax_01")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fax02)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Fax_02")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Frase)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ImpVenta).HasColumnName("Imp_Venta");

                entity.Property(e => e.ImprimeContadoPve).HasColumnName("ImprimeContadoPVE");

                entity.Property(e => e.ImprimirEnFacturaPersonalizada).HasColumnName("Imprimir_en_Factura_Personalizada");

                entity.Property(e => e.Logo).HasColumnType("image");

                entity.Property(e => e.Regalias).HasColumnName("regalias");

                entity.Property(e => e.SoloPve).HasColumnName("SoloPVE");

                entity.Property(e => e.Tel01)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tel_01")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tel02)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tel_02")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Consecutivo>(entity =>
            {
                entity.HasKey(e => e.Consecutivo1);

                entity.Property(e => e.Consecutivo1)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Consecutivo");
            });

            modelBuilder.Entity<ConsecutivoReciboReintegro>(entity =>
            {
                entity.HasKey(e => e.Recibo);

                entity.ToTable("ConsecutivoReciboReintegro");

                entity.Property(e => e.Recibo)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ControlLote>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Barras)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.Lote)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Vence).HasColumnType("datetime");
            });

            modelBuilder.Entity<Correo>(entity =>
            {
                entity.HasKey(e => e.DireccionCorreo);

                entity.ToTable("correo");

                entity.Property(e => e.DireccionCorreo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("direccion_correo");

                entity.Property(e => e.Asunto)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("asunto");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("clave");

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("mensaje");
            });

            modelBuilder.Entity<CostoDevolucione>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Costo_Devoluciones");
            });

            modelBuilder.Entity<CostoFactura>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Costo_Factura");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            });

            modelBuilder.Entity<Cotizacion>(entity =>
            {
                entity.HasKey(e => e.Cotizacion1);

                entity.ToTable("Cotizacion");

                entity.Property(e => e.Cotizacion1).HasColumnName("Cotizacion");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CedulaCliente)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Cod_Cliente");

                entity.Property(e => e.Confirmada).HasColumnName("confirmada");

                entity.Property(e => e.ConfirmadaPor)
                    .HasMaxLength(150)
                    .HasColumnName("confirmada_por");

                entity.Property(e => e.Contacto)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoActual)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Pendiente de envio')");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdFactura)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Factura");

                entity.Property(e => e.IdSucursal)
                    .HasMaxLength(10)
                    .HasColumnName("idSucursal")
                    .IsFixedLength(true);

                entity.Property(e => e.ImpVenta).HasColumnName("Imp_Venta");

                entity.Property(e => e.MonedaNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.ObservacionEstado)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("Tipo_Cambio")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoCedula)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CotizacionDetalle>(entity =>
            {
                entity.HasKey(e => e.Numero);

                entity.ToTable("Cotizacion_Detalle");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodMonedaVenta)
                    .HasColumnName("Cod_MonedaVenta")
                    .HasDefaultValueSql("((500))");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MaxDescuento).HasColumnName("Max_Descuento");

                entity.Property(e => e.MontoDescuento).HasColumnName("Monto_Descuento");

                entity.Property(e => e.MontoImpuesto).HasColumnName("Monto_Impuesto");

                entity.Property(e => e.PrecioBase).HasColumnName("Precio_Base");

                entity.Property(e => e.PrecioCosto).HasColumnName("Precio_Costo");

                entity.Property(e => e.PrecioFlete).HasColumnName("Precio_Flete");

                entity.Property(e => e.PrecioOtros).HasColumnName("Precio_Otros");

                entity.Property(e => e.PrecioUnit).HasColumnName("Precio_Unit");

                entity.Property(e => e.SubFamilia)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambioValorCompra)
                    .HasColumnName("Tipo_Cambio_ValorCompra")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.CotizacionDetalles)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cotizacion_Detalle_Inventario");

                entity.HasOne(d => d.CotizacionNavigation)
                    .WithMany(p => p.CotizacionDetalles)
                    .HasForeignKey(d => d.Cotizacion)
                    .HasConstraintName("FK_Cotizacion_Detalle_Cotizacion");
            });

            modelBuilder.Entity<Credomatic>(entity =>
            {
                entity.ToTable("Credomatic");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<CuentasBancariasProveedor>(entity =>
            {
                entity.HasKey(e => e.IdCuenta);

                entity.ToTable("Cuentas_Bancarias_Proveedor");

                entity.Property(e => e.IdCuenta).HasColumnName("Id_Cuenta");

                entity.Property(e => e.Banco)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MonedaNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumCuenta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Num_Cuenta");

                entity.Property(e => e.TipoCuenta)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoProvNavigation)
                    .WithMany(p => p.CuentasBancariasProveedors)
                    .HasForeignKey(d => d.CodigoProv)
                    .HasConstraintName("FK_Cuentas_Bancarias_Proveedor_Proveedores");
            });

            modelBuilder.Entity<Cupon>(entity =>
            {
                entity.HasKey(e => e.IdCupon);

                entity.ToTable("Cupon");

                entity.Property(e => e.IdCupon)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CantidadCupones).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Descuento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Desde).HasColumnType("datetime");

                entity.Property(e => e.Hasta).HasColumnType("datetime");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");
            });

            modelBuilder.Entity<CuponDetalle>(entity =>
            {
                entity.HasKey(e => e.IdCuponDetalle);

                entity.ToTable("CuponDetalle");

                entity.Property(e => e.IdCuponDetalle)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Codigo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdCupon)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.IdFactura)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Factura");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("customer");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BirthDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Birth_Date");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Country)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("First_Name")
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Last_Name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DenominacionMonedum>(entity =>
            {
                entity.ToTable("Denominacion_Moneda");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Descuento>(entity =>
            {
                entity.HasKey(e => e.IdDescuento);

                entity.Property(e => e.IdDescuento)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ContactoConfirmo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Descuento1).HasColumnName("Descuento");

                entity.Property(e => e.Desde).HasColumnType("datetime");

                entity.Property(e => e.Hasta).HasColumnType("datetime");

                entity.Property(e => e.IdProveedor).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");
            });

            modelBuilder.Entity<DescuentoProgramado>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodProveedor).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<DetalleAbonoccobrar>(entity =>
            {
                entity.HasKey(e => e.Consecutivo);

                entity.ToTable("detalle_abonoccobrar");

                entity.Property(e => e.AbonoSuMoneda).HasColumnName("Abono_SuMoneda");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdRecibo).HasColumnName("Id_Recibo");

                entity.Property(e => e.SaldoAnt).HasColumnName("Saldo_Ant");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdReciboNavigation)
                    .WithMany(p => p.DetalleAbonoccobrars)
                    .HasForeignKey(d => d.IdRecibo)
                    .HasConstraintName("FK_detalle_abonoccobrar_abonoccobrar");
            });

            modelBuilder.Entity<DetalleAbonocpagar>(entity =>
            {
                entity.HasKey(e => e.IdDetalleAbonocpagar);

                entity.ToTable("detalle_abonocpagar");

                entity.Property(e => e.IdDetalleAbonocpagar).HasColumnName("Id_Detalle_abonocpagar");

                entity.Property(e => e.AbonoSuMoneda).HasColumnName("Abono_SuMoneda");

                entity.Property(e => e.CodProveedor).HasColumnName("Cod_Proveedor");

                entity.Property(e => e.IdAbonocpagar).HasColumnName("Id_Abonocpagar");

                entity.Property(e => e.IdCompra).HasColumnName("Id_Compra");

                entity.Property(e => e.SaldoActual).HasColumnName("Saldo_Actual");

                entity.Property(e => e.SaldoAnt).HasColumnName("Saldo_Ant");

                entity.HasOne(d => d.IdAbonocpagarNavigation)
                    .WithMany(p => p.DetalleAbonocpagars)
                    .HasForeignKey(d => d.IdAbonocpagar)
                    .HasConstraintName("FK_detalle_abonocpagar_abonocpagar");
            });

            modelBuilder.Entity<DetalleAjustescPagar>(entity =>
            {
                entity.HasKey(e => e.IdDetalleAjustecPagar)
                    .HasName("PK_Detalle_AjustecPagar");

                entity.ToTable("Detalle_AjustescPagar");

                entity.Property(e => e.IdDetalleAjustecPagar).HasColumnName("Id_DetalleAjustecPagar");

                entity.Property(e => e.AjusteSuMoneda).HasColumnName("Ajuste_SuMoneda");

                entity.Property(e => e.CuentaContable)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCuentaContable)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.IdAjustecPagar).HasColumnName("Id_AjustecPagar");

                entity.Property(e => e.IdCompra).HasColumnName("ID_Compra");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaldoAjustado).HasColumnName("Saldo_Ajustado");

                entity.Property(e => e.SaldoAnt).HasColumnName("Saldo_Ant");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoNota)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAjustecPagarNavigation)
                    .WithMany(p => p.DetalleAjustescPagars)
                    .HasForeignKey(d => d.IdAjustecPagar)
                    .HasConstraintName("FK_Detalle_AjustescPagar_Ajustescpagar");
            });

            modelBuilder.Entity<DetalleAjustesccobrar>(entity =>
            {
                entity.HasKey(e => e.IdDetalleAjustecCobrar);

                entity.ToTable("detalle_ajustesccobrar");

                entity.Property(e => e.IdDetalleAjustecCobrar).HasColumnName("Id_DetalleAjustecCobrar");

                entity.Property(e => e.AjusteSuMoneda).HasColumnName("Ajuste_SuMoneda");

                entity.Property(e => e.CuentaContable)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdAjustecCobrar).HasColumnName("Id_AjustecCobrar");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SaldoAjustado).HasColumnName("Saldo_Ajustado");

                entity.Property(e => e.SaldoAnt).HasColumnName("Saldo_Ant");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TipoNota)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdAjustecCobrarNavigation)
                    .WithMany(p => p.DetalleAjustesccobrars)
                    .HasForeignKey(d => d.IdAjustecCobrar)
                    .HasConstraintName("FK_detalle_ajustesccobrar_ajustesccobrar");
            });

            modelBuilder.Entity<DetalleCierrecaja>(entity =>
            {
                entity.ToTable("Detalle_Cierrecaja");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumCierre).HasColumnName("Num_cierre");
            });

            modelBuilder.Entity<DetalleDetalle>(entity =>
            {
                entity.ToTable("DetalleDetalle");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Codigo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdVentaDetalle).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DetalleEmpaquetado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("detalle_empaquetado");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Empaquetado).HasColumnName("empaquetado");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");

                entity.Property(e => e.IdVentaDetalle).HasColumnName("id_venta_detalle");

                entity.Property(e => e.NotaPantalla)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nota_pantalla");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.Pantalla).HasColumnName("pantalla");
            });

            modelBuilder.Entity<DetalleOrdencompra>(entity =>
            {
                entity.ToTable("detalle_ordencompra");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExistActual).HasColumnName("Exist_Actual");

                entity.Property(e => e.Impuesto).HasColumnName("impuesto");

                entity.Property(e => e.MontoFlete).HasColumnName("Monto_Flete");

                entity.Property(e => e.PorcDescuento).HasColumnName("Porc_Descuento");

                entity.Property(e => e.PorcImpuesto).HasColumnName("Porc_Impuesto");

                entity.HasOne(d => d.OrdenNavigation)
                    .WithMany(p => p.DetalleOrdencompras)
                    .HasForeignKey(d => d.Orden)
                    .HasConstraintName("FK_detalle_ordencompra_ordencompra");
            });

            modelBuilder.Entity<DetallePagoCaja>(entity =>
            {
                entity.ToTable("Detalle_pago_caja");

                entity.Property(e => e.Documento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormaPago)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdOdp).HasColumnName("Id_ODP");

                entity.Property(e => e.Referencia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenciaDoc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReferenciaTipo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoFactura)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdOdpNavigation)
                    .WithMany(p => p.DetallePagoCajas)
                    .HasForeignKey(d => d.IdOdp)
                    .HasConstraintName("FK_Detalle_pago_caja_OpcionesDePago");
            });

            modelBuilder.Entity<DetallePreAbonocCobrar>(entity =>
            {
                entity.HasKey(e => e.Consecutivo);

                entity.ToTable("Detalle_PreAbonocCobrar");

                entity.Property(e => e.AbonoSuMoneda).HasColumnName("Abono_SuMoneda");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdRecibo).HasColumnName("Id_Recibo");

                entity.Property(e => e.SaldoAnt).HasColumnName("Saldo_Ant");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdReciboNavigation)
                    .WithMany(p => p.DetallePreAbonocCobrars)
                    .HasForeignKey(d => d.IdRecibo)
                    .HasConstraintName("FK_Detalle_PreAbonocCobrar_PreAbonocCobrar");
            });

            modelBuilder.Entity<DetallePrestamo>(entity =>
            {
                entity.ToTable("detalle_prestamo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Devuelto).HasColumnName("devuelto");

                entity.Property(e => e.Entregado).HasColumnName("entregado");

                entity.Property(e => e.IdPrestamo).HasColumnName("ID_prestamo");

                entity.Property(e => e.Precio).HasColumnName("precio");
            });

            modelBuilder.Entity<DevolucionPrestamo>(entity =>
            {
                entity.ToTable("Devolucion_prestamo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Anulado).HasColumnName("anulado");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdDetallePrestamo).HasColumnName("id_detalle_prestamo");

                entity.Property(e => e.IdPrestamo).HasColumnName("id_prestamo");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");
            });

            modelBuilder.Entity<DevolucionesCompra>(entity =>
            {
                entity.HasKey(e => e.Devolucion);

                entity.ToTable("devoluciones_Compras");

                entity.Property(e => e.CedulaUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_Usuario");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaEntrada)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFacturaCompra).HasColumnName("Id_Factura_Compra");

                entity.Property(e => e.IdSucusarl).HasColumnName("idSucusarl");

                entity.Property(e => e.NombrePro)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SaldoAntFact).HasColumnName("SaldoAnt_Fact");
            });

            modelBuilder.Entity<DevolucionesVenta>(entity =>
            {
                entity.HasKey(e => e.Devolucion);

                entity.ToTable("devoluciones_ventas");

                entity.Property(e => e.Caja)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("caja");

                entity.Property(e => e.CedulaUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_Usuario");

                entity.Property(e => e.Clavedgt)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CLAVEDGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.Consecutivo).HasColumnName("CONSECUTIVO");

                entity.Property(e => e.Consecutivodgt)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CONSECUTIVODGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Enviadodgt).HasColumnName("ENVIADODGT");

                entity.Property(e => e.Estadodgt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ESTADODGT")
                    .HasDefaultValueSql("('pendiente')");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.NotasDevolucion)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumApertura)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Num_Apertura");

                entity.Property(e => e.SaldoAntFact).HasColumnName("SaldoAnt_Fact");

                entity.Property(e => e.UsuarioRecibio)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Emisor>(entity =>
            {
                entity.HasKey(e => e.Identificacion);

                entity.ToTable("emisor");

                entity.Property(e => e.Identificacion)
                    .ValueGeneratedNever()
                    .HasColumnName("identificacion");

                entity.Property(e => e.Barrio)
                    .HasMaxLength(50)
                    .HasColumnName("barrio");

                entity.Property(e => e.Canton)
                    .HasMaxLength(50)
                    .HasColumnName("canton");

                entity.Property(e => e.CodigoPais)
                    .HasMaxLength(10)
                    .HasColumnName("codigo_pais")
                    .IsFixedLength(true);

                entity.Property(e => e.Distrito)
                    .HasMaxLength(50)
                    .HasColumnName("distrito");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Fax)
                    .HasMaxLength(10)
                    .HasColumnName("fax")
                    .IsFixedLength(true);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NombreComercial)
                    .HasMaxLength(150)
                    .HasColumnName("nombre_comercial");

                entity.Property(e => e.NumeroTelefono)
                    .HasMaxLength(10)
                    .HasColumnName("numero_telefono")
                    .IsFixedLength(true);

                entity.Property(e => e.Otrassenas)
                    .HasMaxLength(50)
                    .HasColumnName("otrassenas");

                entity.Property(e => e.Provincia)
                    .HasMaxLength(50)
                    .HasColumnName("provincia");

                entity.Property(e => e.Tipo).HasColumnName("tipo");
            });

            modelBuilder.Entity<Empaquetado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Empaquetado");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("cedula");

                entity.Property(e => e.Factura).HasColumnName("factura");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdVentaDetalle).HasColumnName("id_venta_detalle");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Timer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("timer");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.Cedula);

                entity.ToTable("empleado");

                entity.Property(e => e.Cedula)
                    .ValueGeneratedNever()
                    .HasColumnName("cedula");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("codigo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("date")
                    .HasColumnName("fecha_ingreso");

                entity.Property(e => e.FechaSalida)
                    .HasColumnType("date")
                    .HasColumnName("fecha_salida");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("nombre");

                entity.Property(e => e.Puesto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("puesto");

                entity.Property(e => e.Salario).HasColumnName("salario");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.ToTable("empresa");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Actual).HasColumnName("actual");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('0000000000')")
                    .IsFixedLength(true);

                entity.Property(e => e.Empresa1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("empresa");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");
            });

            modelBuilder.Entity<Encargadocompra>(entity =>
            {
                entity.HasKey(e => e.Identificacion);

                entity.ToTable("encargadocompras");

                entity.Property(e => e.Identificacion)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Encargadocompras)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_encargadocompras_Clientes");
            });

            modelBuilder.Entity<EstadoCotizacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EstadoCotizacion");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<ExepcionFirmadocontado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EXEPCION_FIRMADOCONTADO");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(100)
                    .HasColumnName("CEDULA");

                entity.Property(e => e.IdExepcionFirmadocontado)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ID_EXEPCION_FIRMADOCONTADO");

                entity.Property(e => e.IdValidaFirmadocontado)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ID_VALIDA_FIRMADOCONTADO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<Familium>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.CuentaCosto)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CuentaExe)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CuentaGra)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCosto)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('--')");

                entity.Property(e => e.DescripcionExe)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('--')");

                entity.Property(e => e.DescripcionGra)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('--')");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<FechaMovimientoOpcionesPago>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Fecha_Movimiento_OpcionesPago");

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<FichasxUsuario>(entity =>
            {
                entity.ToTable("FichasxUsuario");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EnMostrador).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FormatoDeCompra>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("formato de compras");

                entity.Property(e => e.Barras)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gasto>(entity =>
            {
                entity.ToTable("gasto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Gasto1>(entity =>
            {
                entity.ToTable("gastos");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Anulado).HasColumnName("anulado");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("cedula");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("codigo")
                    .IsFixedLength(true);

                entity.Property(e => e.CodigoArt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("codigo_art");

                entity.Property(e => e.Costo).HasColumnName("costo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Existencia).HasColumnName("existencia");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.Idbodega).HasColumnName("idbodega");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("observaciones");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<GestionCobroBitacora>(entity =>
            {
                entity.ToTable("GestionCobro_Bitacora");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Etapa).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdFactura)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Factura");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<HistorialPrestamo>(entity =>
            {
                entity.ToTable("historial_prestamos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Accion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("accion");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdPrestamo).HasColumnName("id_prestamo");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<HistoricoSerie>(entity =>
            {
                entity.ToTable("HistoricoSerie");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Boleta).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdSerie).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<HojaCxC>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HojaCxC");

                entity.Property(e => e.CedulaUsuario).HasColumnName("Cedula_Usuario");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodEncargadoCompra)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Encargado_Compra");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.ContabilizadoCventa).HasColumnName("ContabilizadoCVenta");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.ImpVenta).HasColumnName("Imp_Venta");

                entity.Property(e => e.MonedaNombre)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Moneda_Nombre");

                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumApertura).HasColumnName("Num_Apertura");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PagoComision).HasColumnName("Pago_Comision");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");

                entity.Property(e => e.Vence).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Holiday");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Impuesto>(entity =>
            {
                entity.HasKey(e => e.IdImpuesto);

                entity.Property(e => e.IdImpuesto)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id_Impuesto");

                entity.Property(e => e.CodigoImpuesto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Codigo_Impuesto");

                entity.Property(e => e.CodigoTarifa)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Codigo_Tarifa");

                entity.Property(e => e.Impuesto1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Impuesto");

                entity.Property(e => e.Simbolo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Inven>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Inven");

                entity.Property(e => e.Barras)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("Inventario");

                entity.HasIndex(e => e.Barras, "IX_Inventario");

                entity.HasIndex(e => e.Descripcion, "nc_BuscarporDescripcion");

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Armamento).HasColumnName("armamento");

                entity.Property(e => e.Barras)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Barras2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("barras2");

                entity.Property(e => e.Barras3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("barras3");

                entity.Property(e => e.Bloqueado)
                    .HasColumnName("bloqueado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Bonificado).HasColumnName("bonificado");

                entity.Property(e => e.CantidadDescarga).HasDefaultValueSql("((0))");

                entity.Property(e => e.Clinica)
                    .HasColumnName("clinica")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Articulo")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodPresentOtro).HasColumnName("Cod_PresentOtro");

                entity.Property(e => e.CodPresentacion).HasDefaultValueSql("('')");

                entity.Property(e => e.Codcabys)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("CODCABYS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodigoDescarga)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DescargaOtro).HasDefaultValueSql("((0))");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Encargado)
                    .HasMaxLength(50)
                    .HasColumnName("encargado");

                entity.Property(e => e.FechaActualizacion).HasColumnType("date");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdBodega).HasColumnName("Id_Bodega");

                entity.Property(e => e.IdImpuesto)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Impuesto");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Iventa).HasColumnName("IVenta");

                entity.Property(e => e.Mag).HasColumnName("MAG");

                entity.Property(e => e.Maquinaria).HasColumnName("maquinaria");

                entity.Property(e => e.Mascotas).HasColumnName("mascotas");

                entity.Property(e => e.MaxBodega).HasColumnName("MAX_Bodega");

                entity.Property(e => e.MaxComision).HasColumnName("Max_Comision");

                entity.Property(e => e.MaxDescuento).HasColumnName("Max_Descuento");

                entity.Property(e => e.MaxInventario).HasColumnName("MAX_Inventario");

                entity.Property(e => e.Muestra)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.Pantalla)
                    .HasColumnName("pantalla")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Peces).HasColumnName("peces");

                entity.Property(e => e.PrecioA).HasColumnName("Precio_A");

                entity.Property(e => e.PrecioB).HasColumnName("Precio_B");

                entity.Property(e => e.PrecioC).HasColumnName("Precio_C");

                entity.Property(e => e.PrecioD).HasColumnName("Precio_D");

                entity.Property(e => e.PrecioPromo).HasColumnName("Precio_Promo");

                entity.Property(e => e.PrecioSugerido).HasColumnName("Precio_Sugerido");

                entity.Property(e => e.Prestamo)
                    .HasColumnName("prestamo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductosOrganicos).HasColumnName("productos_organicos");

                entity.Property(e => e.Promo3x1).HasColumnName("promo3x1");

                entity.Property(e => e.PromoActiva).HasColumnName("Promo_Activa");

                entity.Property(e => e.PromoCon).HasColumnName("PromoCON");

                entity.Property(e => e.PromoCre).HasColumnName("PromoCRE");

                entity.Property(e => e.PromoFinaliza)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Promo_Finaliza")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PromoInicio)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Promo_Inicio")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Receta).HasColumnName("receta");

                entity.Property(e => e.Rifa).HasColumnName("rifa");

                entity.Property(e => e.Serie).HasColumnName("serie");

                entity.Property(e => e.SubFamilia)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SubUbicacion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SugeridoIv).HasColumnName("SugeridoIV");

                entity.Property(e => e.Taller).HasColumnName("taller");

                entity.Property(e => e.Tienda).HasColumnName("tienda");
            });

            modelBuilder.Entity<InventarioGeneral>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("InventarioGeneral");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Articulo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Presentaciones)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prestamo).HasColumnName("prestamo");
            });

            modelBuilder.Entity<InventarioInicial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Inventario_Inicial");

                entity.Property(e => e.Codigo).HasMaxLength(255);

                entity.Property(e => e.Descripcion).HasMaxLength(255);
            });

            modelBuilder.Entity<Kardex>(entity =>
            {
                entity.HasKey(e => e.Consecutivo);

                entity.ToTable("Kardex");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.CodProveedor).HasColumnName("Cod_Proveedor");

                entity.Property(e => e.CostoMov).HasColumnName("Costo_Mov");

                entity.Property(e => e.CostoUnit).HasColumnName("Costo_Unit");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExistAct).HasColumnName("Exist_Act");

                entity.Property(e => e.ExistActBod).HasColumnName("Exist_ActBod");

                entity.Property(e => e.ExistAnt).HasColumnName("Exist_Ant");

                entity.Property(e => e.ExistAntBod).HasColumnName("Exist_AntBod");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");
            });

            modelBuilder.Entity<KardexCompra>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KardexCompras");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.CodProveedor).HasColumnName("Cod_Proveedor");

                entity.Property(e => e.CostoMov).HasColumnName("Costo_Mov");

                entity.Property(e => e.CostoUnit).HasColumnName("Costo_Unit");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExistAct).HasColumnName("Exist_Act");

                entity.Property(e => e.ExistAnt).HasColumnName("Exist_Ant");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");
            });

            modelBuilder.Entity<KardexConsignacion>(entity =>
            {
                entity.HasKey(e => e.Consecutivo);

                entity.ToTable("KardexConsignacion");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.CodProveedor).HasColumnName("Cod_Proveedor");

                entity.Property(e => e.CostoMov).HasColumnName("Costo_Mov");

                entity.Property(e => e.CostoUnit).HasColumnName("Costo_Unit");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExistAct).HasColumnName("Exist_Act");

                entity.Property(e => e.ExistActBod).HasColumnName("Exist_ActBod");

                entity.Property(e => e.ExistAnt).HasColumnName("Exist_Ant");

                entity.Property(e => e.ExistAntBod).HasColumnName("Exist_AntBod");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");
            });

            modelBuilder.Entity<KardexDevolucionCompra>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KardexDevolucionCompras");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.CodProveedor).HasColumnName("Cod_Proveedor");

                entity.Property(e => e.CostoMov).HasColumnName("Costo_Mov");

                entity.Property(e => e.CostoUnit).HasColumnName("Costo_Unit");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExistAct).HasColumnName("Exist_Act");

                entity.Property(e => e.ExistAnt).HasColumnName("Exist_Ant");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");
            });

            modelBuilder.Entity<KardexDevolucionVentum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KardexDevolucionVenta");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.CodProveedor).HasColumnName("Cod_Proveedor");

                entity.Property(e => e.CostoMov).HasColumnName("Costo_Mov");

                entity.Property(e => e.CostoUnit).HasColumnName("Costo_Unit");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExistAct).HasColumnName("Exist_Act");

                entity.Property(e => e.ExistAnt).HasColumnName("Exist_Ant");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");
            });

            modelBuilder.Entity<KardexPrestamo>(entity =>
            {
                entity.ToTable("kardex_prestamo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Actual).HasColumnName("actual");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CantidadAnt).HasColumnName("cantidad_ant");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .HasColumnName("codigo");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdPrestamo).HasColumnName("id_prestamo");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");
            });

            modelBuilder.Entity<KardexVario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KardexVarios");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.CodProveedor).HasColumnName("Cod_Proveedor");

                entity.Property(e => e.Consecutivo).ValueGeneratedOnAdd();

                entity.Property(e => e.CostoMov).HasColumnName("Costo_Mov");

                entity.Property(e => e.CostoUnit).HasColumnName("Costo_Unit");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExistAct).HasColumnName("Exist_Act");

                entity.Property(e => e.ExistAnt).HasColumnName("Exist_Ant");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");
            });

            modelBuilder.Entity<KardexVenta>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KardexVentas");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.CodProveedor).HasColumnName("Cod_Proveedor");

                entity.Property(e => e.CostoMov).HasColumnName("Costo_Mov");

                entity.Property(e => e.CostoUnit).HasColumnName("Costo_Unit");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExistAct).HasColumnName("Exist_Act");

                entity.Property(e => e.ExistAnt).HasColumnName("Exist_Ant");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");
            });

            modelBuilder.Entity<Kcompra>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KCompras");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.CodProveedor).HasColumnName("Cod_Proveedor");

                entity.Property(e => e.Consecutivo).ValueGeneratedOnAdd();

                entity.Property(e => e.CostoMov).HasColumnName("Costo_Mov");

                entity.Property(e => e.CostoUnit).HasColumnName("Costo_Unit");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExistAct).HasColumnName("Exist_Act");

                entity.Property(e => e.ExistAnt).HasColumnName("Exist_Ant");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");
            });

            modelBuilder.Entity<KdevolucionCompra>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KDevolucionCompras");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.CodProveedor).HasColumnName("Cod_Proveedor");

                entity.Property(e => e.Consecutivo).ValueGeneratedOnAdd();

                entity.Property(e => e.CostoMov).HasColumnName("Costo_Mov");

                entity.Property(e => e.CostoUnit).HasColumnName("Costo_Unit");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExistAct).HasColumnName("Exist_Act");

                entity.Property(e => e.ExistAnt).HasColumnName("Exist_Ant");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");
            });

            modelBuilder.Entity<KdevolucionVenta>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KDevolucionVentas");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.CodProveedor).HasColumnName("Cod_Proveedor");

                entity.Property(e => e.Consecutivo).ValueGeneratedOnAdd();

                entity.Property(e => e.CostoMov).HasColumnName("Costo_Mov");

                entity.Property(e => e.CostoUnit).HasColumnName("Costo_Unit");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExistAct).HasColumnName("Exist_Act");

                entity.Property(e => e.ExistAnt).HasColumnName("Exist_Ant");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");
            });

            modelBuilder.Entity<Kvario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KVarios");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.CodProveedor).HasColumnName("Cod_Proveedor");

                entity.Property(e => e.Consecutivo).ValueGeneratedOnAdd();

                entity.Property(e => e.CostoMov).HasColumnName("Costo_Mov");

                entity.Property(e => e.CostoUnit).HasColumnName("Costo_Unit");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExistAct).HasColumnName("Exist_Act");

                entity.Property(e => e.ExistAnt).HasColumnName("Exist_Ant");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");
            });

            modelBuilder.Entity<Kventa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KVentas");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.CodProveedor).HasColumnName("Cod_Proveedor");

                entity.Property(e => e.Consecutivo).ValueGeneratedOnAdd();

                entity.Property(e => e.CostoMov).HasColumnName("Costo_Mov");

                entity.Property(e => e.CostoUnit).HasColumnName("Costo_Unit");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExistAct).HasColumnName("Exist_Act");

                entity.Property(e => e.ExistAnt).HasColumnName("Exist_Ant");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");
            });

            modelBuilder.Entity<ListadoProducto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("listado_productos");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Expr1)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubFamilia)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("Log");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Autorizacion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CodigoRespueta)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DescripcionRespuesta)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Factura).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdApertura).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdTransaccion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NumeroTarjeta)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Referencia)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Tags)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TipoTransaccion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TituloTag)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.CodMarca);

                entity.Property(e => e.Marca1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Marca");
            });

            modelBuilder.Entity<MensajeReceptor>(entity =>
            {
                entity.ToTable("MensajeReceptor");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoActividad)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CondicionImpuesto)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Consecutivo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DetalleMensaje)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('pendiente')");

                entity.Property(e => e.FechaComprobante).HasColumnType("datetime");

                entity.Property(e => e.FechaEmisionDoc).HasColumnType("datetime");

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'CRC')");

                entity.Property(e => e.NumeroCedulaEmisor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pdf)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PDF")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<MovimientoArticuloVenta>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MovimientoArticuloVentas");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(260)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.PrecioUnit).HasColumnName("Precio_Unit");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MovimientoArticulosCompra>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MovimientoArticulosCompra");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdCompra).HasColumnName("Id_Compra");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCompra)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MovimientoCaja>(entity =>
            {
                entity.ToTable("Movimiento_Caja");

                entity.Property(e => e.Entrada)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MovimientoClienteSaldo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MovimientoClienteSaldo");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.TipoDoc)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MovimientoCuentaCliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MovimientoCuentaCliente");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.TipoDoc)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MovimientoCuentaProveedor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MovimientoCuentaProveedor");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.TipoDoc)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MovimientosBodega>(entity =>
            {
                entity.HasKey(e => e.BoletaMovimiento);

                entity.ToTable("MovimientosBodega");

                entity.Property(e => e.BoletaMovimiento).HasColumnName("Boleta_Movimiento");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaEntrada)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.Referencia)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.BodegaNavigation)
                    .WithMany(p => p.MovimientosBodegas)
                    .HasForeignKey(d => d.Bodega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovimientosBodega_Bodegas");
            });

            modelBuilder.Entity<MovimientosBodegaDetalle>(entity =>
            {
                entity.HasKey(e => e.IdDetalle)
                    .HasName("PK_Bodegas_DetalleMovimiento");

                entity.ToTable("MovimientosBodega_Detalle");

                entity.Property(e => e.IdDetalle).HasColumnName("Id_Detalle");

                entity.Property(e => e.BoletaMovimiento).HasColumnName("Boleta_Movimiento");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExistVeteForzada).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExistenciaForzada).HasDefaultValueSql("((0))");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoEntrada)
                    .IsRequired()
                    .HasColumnName("Tipo_Entrada")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoSalida).HasColumnName("Tipo_Salida");

                entity.HasOne(d => d.BoletaMovimientoNavigation)
                    .WithMany(p => p.MovimientosBodegaDetalles)
                    .HasForeignKey(d => d.BoletaMovimiento)
                    .HasConstraintName("FK_MovimientoBodega_Detalle_MovimientosBodega");
            });

            modelBuilder.Entity<MuertesGasto>(entity =>
            {
                entity.HasKey(e => e.Consecutivo);

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");
            });

            modelBuilder.Entity<MuertesGastosDetalle>(entity =>
            {
                entity.HasKey(e => e.Consecutivo);

                entity.ToTable("MuertesGastos_Detalle");

                entity.Property(e => e.CodArticulo).HasColumnName("Cod_Articulo");

                entity.Property(e => e.CodArticulo1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CodArticulo");

                entity.Property(e => e.ConsAjuste).HasColumnName("Cons_Ajuste");

                entity.Property(e => e.CuentaContable)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cuenta_contable");

                entity.Property(e => e.Cuentacontable1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CUENTACONTABLE");

                entity.Property(e => e.DescArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Desc_Articulo");

                entity.Property(e => e.Descripcioncuentacontable)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCIONCUENTACONTABLE");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("observacion");
            });

            modelBuilder.Entity<NoMag>(entity =>
            {
                entity.ToTable("NoMAG");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OpcionesDePago>(entity =>
            {
                entity.ToTable("OpcionesDePago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FormaPago)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombremoneda)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpcionesDePagoDevolucione>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OpcionesDePagoDevoluciones");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FormaPago)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombremoneda)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpcionesDePagoDveDva>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OpcionesDePagoDVE_DVA");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FormaPago)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombremoneda)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpcionesDePagoSinCredito>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OpcionesDePagoSinCredito");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FormaPago)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombremoneda)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpcionesDePagoSinDve>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OpcionesDePagoSinDVE");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FormaPago)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombremoneda)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdenCompraAutomática>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Orden_Compra_Automática");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MontoFlete).HasColumnName("Monto_Flete");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PorcDescuento).HasColumnName("Porc_Descuento");

                entity.Property(e => e.PorcImpuesto).HasColumnName("Porc_Impuesto");
            });

            modelBuilder.Entity<OrdenTrabajo>(entity =>
            {
                entity.HasKey(e => e.IdOrden);

                entity.ToTable("OrdenTrabajo");

                entity.Property(e => e.IdOrden)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Serie).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TrabajoSolicitados)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Ordencompra>(entity =>
            {
                entity.HasKey(e => e.Orden);

                entity.ToTable("ordencompra");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.Contado).HasColumnName("contado");

                entity.Property(e => e.Credito).HasColumnName("credito");

                entity.Property(e => e.Diascredito).HasColumnName("diascredito");

                entity.Property(e => e.Entregar)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("entregar");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PagosDuplicado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PagosDuplicados");
            });

            modelBuilder.Entity<PedidoBodega>(entity =>
            {
                entity.HasKey(e => e.IdPedido);

                entity.ToTable("PedidoBodega");

                entity.Property(e => e.IdPedido)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Codigo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Consecutivo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaPedido).HasColumnType("datetime");

                entity.Property(e => e.FechaRecibido)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.IdUsuarioPidio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdUsuarioRecibio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdUsuarioSolicitud)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Proveedor).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Permiso>(entity =>
            {
                entity.ToTable("permisos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("clave");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<PreAbonocCobrar>(entity =>
            {
                entity.HasKey(e => e.IdRecibo);

                entity.ToTable("PreAbonocCobrar");

                entity.Property(e => e.IdRecibo).HasColumnName("Id_Recibo");

                entity.Property(e => e.Banco)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("banco")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CedUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Ced_Usuario")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cheque)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('PreAbono')");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumCaja).HasColumnName("Num_Caja");

                entity.Property(e => e.NumRecibo).HasColumnName("Num_Recibo");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SaldoActual).HasColumnName("Saldo_Actual");

                entity.Property(e => e.SaldoCuenta).HasColumnName("Saldo_Cuenta");
            });

            modelBuilder.Entity<PreTomaGeneral>(entity =>
            {
                entity.HasKey(e => e.IdPreToma);

                entity.ToTable("PreTomaGeneral");

                entity.Property(e => e.IdPreToma)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Encargado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<PreTomaGeneralDetalle>(entity =>
            {
                entity.HasKey(e => e.IdPreTomaDetalle);

                entity.ToTable("PreTomaGeneralDetalle");

                entity.Property(e => e.IdPreTomaDetalle)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Barras)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Cod_Articulo");

                entity.Property(e => e.Codigo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IdPreToma).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<PreTomaProveedor>(entity =>
            {
                entity.ToTable("PreTomaProveedor");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodigoProv).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuarioCreo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Id_UsuarioCreo");
            });

            modelBuilder.Entity<PreTomaProveedorDetalle>(entity =>
            {
                entity.ToTable("PreTomaProveedorDetalle");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Codigo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Descripicon)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdPreTomaProveedor)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_PreTomaProveedor");
            });

            modelBuilder.Entity<PreVenta>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Agente).HasColumnName("agente");

                entity.Property(e => e.Apartado).HasColumnName("apartado");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000000000')");

                entity.Property(e => e.CedulaUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_Usuario");

                entity.Property(e => e.ClaveMh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ClaveMH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodAgente).HasColumnName("cod_agente");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodEncargadoCompra)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Encargado_Compra");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.ConsecutivoMh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ConsecutivoMH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContabilizadoCventa).HasColumnName("ContabilizadoCVenta");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EnviadoMh).HasColumnName("EnviadoMH");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PreVenta')");

                entity.Property(e => e.EstadoMh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EstadoMH")
                    .HasDefaultValueSql("('pendiente')");

                entity.Property(e => e.ExcluirCxC).HasColumnName("excluirCxC");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdCotizacion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdFactura).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdFacturaRemplaza)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_FacturaRemplaza");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.ImpVenta).HasColumnName("Imp_Venta");

                entity.Property(e => e.MonedaNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Moneda_Nombre");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumApertura).HasColumnName("Num_Apertura");

                entity.Property(e => e.NumCaja)
                    .HasColumnName("Num_Caja")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Orden)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PagoComision).HasColumnName("Pago_Comision");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");

                entity.Property(e => e.TipoCedula)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('FISICA')");

                entity.Property(e => e.Vence).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<PreVentasDetalle>(entity =>
            {
                entity.HasKey(e => e.IdVentaDetalle);

                entity.ToTable("PreVentas_Detalle");

                entity.Property(e => e.IdVentaDetalle).HasColumnName("id_venta_detalle");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodMonedaVenta)
                    .HasColumnName("Cod_MonedaVenta")
                    .HasDefaultValueSql("((500))");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Disminuye).HasDefaultValueSql("((0))");

                entity.Property(e => e.Empaquetado).HasColumnName("empaquetado");

                entity.Property(e => e.Entregados).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.IdBodega)
                    .HasColumnName("id_bodega")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");

                entity.Property(e => e.IdSerie).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdTipoExoneracion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Lote)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxDescuento).HasColumnName("Max_Descuento");

                entity.Property(e => e.MontoDescuento).HasColumnName("Monto_Descuento");

                entity.Property(e => e.MontoImpuesto).HasColumnName("Monto_Impuesto");

                entity.Property(e => e.NotaPantalla)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nota_pantalla")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.NumeroDocumento)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumeroEntrega).HasColumnName("Numero_Entrega");

                entity.Property(e => e.PorcentajeCompra).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PrecioBase).HasColumnName("Precio_Base");

                entity.Property(e => e.PrecioCosto).HasColumnName("Precio_Costo");

                entity.Property(e => e.PrecioFlete).HasColumnName("Precio_Flete");

                entity.Property(e => e.PrecioOtros).HasColumnName("Precio_Otros");

                entity.Property(e => e.PrecioUnit).HasColumnName("Precio_Unit");

                entity.Property(e => e.Regalias)
                    .HasColumnName("regalias")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoCambioValorCompra)
                    .HasColumnName("Tipo_Cambio_ValorCompra")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdFacturaNavigation)
                    .WithMany(p => p.PreVentasDetalles)
                    .HasForeignKey(d => d.IdFactura)
                    .HasConstraintName("FK_PreVentas_Detalle_Ventas");
            });

            modelBuilder.Entity<PrecioDiferenciado>(entity =>
            {
                entity.ToTable("PrecioDiferenciado");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodProveedor).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdAgente).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Presentacione>(entity =>
            {
                entity.HasKey(e => e.CodPres);

                entity.Property(e => e.Mh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Presentaciones)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prestamo>(entity =>
            {
                entity.ToTable("Prestamo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Anulado).HasColumnName("anulado");

                entity.Property(e => e.Boleta)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("boleta")
                    .IsFixedLength(true);

                entity.Property(e => e.BoletaProveedor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.Destinatario).HasColumnName("destinatario");

                entity.Property(e => e.Destino).HasColumnName("destino");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.IdUsuariCreo)
                    .IsRequired()
                    .HasMaxLength(75)
                    .HasColumnName("Id_UsuariCreo")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreDestinatario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nombre_destinatario");

                entity.Property(e => e.NombreDestino)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nombre_destino");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(350)
                    .HasColumnName("observacion");

                entity.Property(e => e.Transportista)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("transportista")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ProdEmpaquetado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("prod_Empaquetado");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("cedula");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdVentaDetalle).HasColumnName("id_venta_detalle");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<ProductosWeb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProductosWeb");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("categoria");

                entity.Property(e => e.CodigoCategoria).HasColumnName("codigoCategoria");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(340)
                    .HasColumnName("descripcion");

                entity.Property(e => e.DescuentoPromo).HasColumnName("descuentoPromo");

                entity.Property(e => e.Espesificaciones)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("espesificaciones");

                entity.Property(e => e.Existencia).HasColumnName("existencia");

                entity.Property(e => e.Imagen)
                    .IsRequired()
                    .HasMaxLength(33)
                    .IsUnicode(false)
                    .HasColumnName("imagen");

                entity.Property(e => e.Mag).HasColumnName("MAG");

                entity.Property(e => e.PrecioIva).HasColumnName("precioIVA");

                entity.Property(e => e.PrecioIvamag).HasColumnName("precioIVAMAG");

                entity.Property(e => e.PrecioIvapromo).HasColumnName("precioIVAPromo");

                entity.Property(e => e.PrecioIvapromoMag).HasColumnName("precioIVAPromoMAG");

                entity.Property(e => e.Promo).HasColumnName("promo");
            });

            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.HasKey(e => e.CodigoProv);

                entity.Property(e => e.CodigoProv).ValueGeneratedNever();

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoActividad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Contacto)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CorreoElectronico)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CuentaContable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCuentaContable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fax1)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fax2)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fec).HasColumnName("FEC");

                entity.Property(e => e.IdCanton)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Canton");

                entity.Property(e => e.IdDistrito)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Distrito");

                entity.Property(e => e.IdProvincia)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Provincia");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OtrasSenas)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telefono1)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telefono2)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TelefonoCont)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Telefono_Cont")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TipoProveedor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UtilidadFija).HasColumnName("Utilidad_Fija");

                entity.Property(e => e.UtilidadInventario).HasColumnName("Utilidad_Inventario");
            });

            modelBuilder.Entity<Referenciabancarium>(entity =>
            {
                entity.ToTable("referenciabancaria");

                entity.Property(e => e.Banco)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cuenta)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Sucursal)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Referenciabancaria)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_referenciabancaria_Clientes");
            });

            modelBuilder.Entity<Referenciacomercial>(entity =>
            {
                entity.ToTable("referenciacomercial");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Referenciacomercials)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_referenciacomercial_Clientes");
            });

            modelBuilder.Entity<RegistroAnulacione>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("registro_anulaciones");

                entity.Property(e => e.Administrador)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CedulaUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("cedula_usuario");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdFactura)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_factura");

                entity.Property(e => e.Justificacion).HasColumnName("justificacion");
            });

            modelBuilder.Entity<RegistroPermisoAjuste>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("registro_PermisoAjuste");

                entity.Property(e => e.Administrador)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CedulaUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("cedula_usuario");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdMovimiento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_Movimiento");
            });

            modelBuilder.Entity<RegistroPermisohabilitar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("registro_Permisohabilitar");

                entity.Property(e => e.Administrador)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CedulaUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("cedula_usuario");

                entity.Property(e => e.Codigo)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("codigo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");
            });

            modelBuilder.Entity<ReporteDescuento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("reporte_descuentos");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.NumCaja).HasColumnName("Num_Caja");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReporteFacturaVentum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ReporteFacturaVenta");

                entity.Property(e => e.Agente).HasColumnName("agente");

                entity.Property(e => e.Apartado).HasColumnName("apartado");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CedulaUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_Usuario");

                entity.Property(e => e.ClaveMh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ClaveMH");

                entity.Property(e => e.ClaveReenvio)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CodAgente).HasColumnName("cod_agente");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodEncargadoCompra)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Encargado_Compra");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.CodMonedaVenta).HasColumnName("Cod_MonedaVenta");

                entity.Property(e => e.ConsecutivoMh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ConsecutivoMH");

                entity.Property(e => e.ConsecutivoReenvio)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ContabilizadoCventa).HasColumnName("ContabilizadoCVenta");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EnviadoMh).HasColumnName("EnviadoMH");

                entity.Property(e => e.EstadoMh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EstadoMH");

                entity.Property(e => e.Etapa).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExcluirCxC).HasColumnName("excluirCxC");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaArchivo).HasColumnType("datetime");

                entity.Property(e => e.FechaEtapa).HasColumnType("datetime");

                entity.Property(e => e.IdAdelanto)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Adelanto");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");

                entity.Property(e => e.IdFacturaRemplaza)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_FacturaRemplaza");

                entity.Property(e => e.IdVentaDetalle).HasColumnName("id_venta_detalle");

                entity.Property(e => e.ImpVenta).HasColumnName("Imp_Venta");

                entity.Property(e => e.Lote)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MaxDescuento).HasColumnName("Max_Descuento");

                entity.Property(e => e.MonedaNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Moneda_Nombre");

                entity.Property(e => e.MontoDescuento).HasColumnName("Monto_Descuento");

                entity.Property(e => e.MontoImpuesto).HasColumnName("Monto_Impuesto");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumApertura).HasColumnName("Num_Apertura");

                entity.Property(e => e.NumCaja).HasColumnName("Num_Caja");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.NumeroEntrega).HasColumnName("Numero_Entrega");

                entity.Property(e => e.NumeroReenvio).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Orden)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PagoComision).HasColumnName("Pago_Comision");

                entity.Property(e => e.PrecioBase).HasColumnName("Precio_Base");

                entity.Property(e => e.PrecioCosto).HasColumnName("Precio_Costo");

                entity.Property(e => e.PrecioFlete).HasColumnName("Precio_Flete");

                entity.Property(e => e.PrecioOtros).HasColumnName("Precio_Otros");

                entity.Property(e => e.PrecioUnit).HasColumnName("Precio_Unit");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");

                entity.Property(e => e.TipoCambioValorCompra).HasColumnName("Tipo_Cambio_ValorCompra");

                entity.Property(e => e.TipoCedula)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioArchivo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Vence).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ReporteGerencialInventario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Reporte_Gerencial_Inventarios");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaxDescuento).HasColumnName("Max_Descuento");

                entity.Property(e => e.Presentaciones)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Proveedores)
                    .HasMaxLength(283)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicaciones)
                    .IsRequired()
                    .HasMaxLength(401)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReporteGerencialInventario1>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("ReporteGerencialInventario");

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Presentacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UltimaCompra)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UltimaVenta)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReporteMovimientosXFecha>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ReporteMovimientos_X_Fecha");

                entity.Property(e => e.DescuentoDev).HasColumnName("Descuento_Dev");

                entity.Property(e => e.DescuentoVentas).HasColumnName("Descuento_Ventas");

                entity.Property(e => e.ExcentoDev).HasColumnName("Excento_Dev");

                entity.Property(e => e.ExentoVentas).HasColumnName("Exento_Ventas");

                entity.Property(e => e.FechaX).HasColumnType("datetime");

                entity.Property(e => e.GravadaDev).HasColumnName("Gravada_Dev");

                entity.Property(e => e.GravadaVentas).HasColumnName("Gravada_Ventas");

                entity.Property(e => e.ImpuestoDev).HasColumnName("Impuesto_Dev");

                entity.Property(e => e.ImpuestoVentas).HasColumnName("Impuesto_Ventas");

                entity.Property(e => e.NumCaja)
                    .HasColumnType("numeric(19, 0)")
                    .HasColumnName("Num_Caja");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");

                entity.Property(e => e.TipoMov)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDev).HasColumnName("Total_Dev");

                entity.Property(e => e.TotalVentas).HasColumnName("Total_Ventas");

                entity.Property(e => e.TransporteDev).HasColumnName("Transporte_Dev");

                entity.Property(e => e.TransporteVentas).HasColumnName("Transporte_Ventas");
            });

            modelBuilder.Entity<ReporteVentasD1512016>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ReporteVentas_D151-2016");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cedula");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.ImpVenta).HasColumnName("Imp_Venta");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ResumenPunto>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdFactura)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Factura");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IsCierre).HasColumnName("isCierre");

                entity.Property(e => e.IsEmpaque).HasColumnName("isEmpaque");

                entity.Property(e => e.IsVenta)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsVentaMascota).HasColumnName("isVentaMascota");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumFactura)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Num_Factura");
            });

            modelBuilder.Entity<Rifa>(entity =>
            {
                entity.ToTable("rifa");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Anulada).HasColumnName("anulada");

                entity.Property(e => e.CantMin).HasColumnName("cant_min");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("descripcion");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("date")
                    .HasColumnName("fecha_fin");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("fecha_inicio");

                entity.Property(e => e.Finalizada).HasColumnName("finalizada");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");
            });

            modelBuilder.Entity<RifaDetalle>(entity =>
            {
                entity.HasKey(e => e.IdRifaDetalle);

                entity.ToTable("Rifa_Detalle");

                entity.Property(e => e.IdRifaDetalle)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdProveedor).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdRifa).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SaldoApartado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SaldoApartados");

                entity.Property(e => e.IdApartado)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id_Apartado");

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");
            });

            modelBuilder.Entity<Serie>(entity =>
            {
                entity.ToTable("Serie");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Codigo)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("codigo");

                entity.Property(e => e.Factura)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("factura");

                entity.Property(e => e.Serie1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("serie")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Vendido).HasColumnName("vendido");
            });

            modelBuilder.Entity<ServidorFtp>(entity =>
            {
                entity.ToTable("ServidorFTP");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClavePublica)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocalHost)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TieneFtp).HasColumnName("TieneFTP");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioPublico)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Solicitud>(entity =>
            {
                entity.HasKey(e => e.Idsolicitud);

                entity.ToTable("Solicitud");

                entity.Property(e => e.Idsolicitud)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("idsolicitud");

                entity.Property(e => e.Anulado).HasColumnName("anulado");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.IdUsuariocreo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("id_usuariocreo");
            });

            modelBuilder.Entity<Solicituddetalle>(entity =>
            {
                entity.HasKey(e => e.Idsolicituddetalle);

                entity.ToTable("solicituddetalle");

                entity.Property(e => e.Idsolicituddetalle)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idsolicituddetalle");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("cod_articulo");

                entity.Property(e => e.Codigo)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("codigo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Empaquetadoanulacion).HasColumnName("empaquetadoanulacion");

                entity.Property(e => e.Empaquetadosolicitud).HasColumnName("empaquetadosolicitud");

                entity.Property(e => e.Idsolicitud)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("idsolicitud");

                entity.Property(e => e.Nota)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("nota");
            });

            modelBuilder.Entity<Sprestamo>(entity =>
            {
                entity.ToTable("SPrestamo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Anulado).HasColumnName("anulado");

                entity.Property(e => e.Boleta)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("boleta")
                    .IsFixedLength(true);

                entity.Property(e => e.BoletaProveedor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.Destinatario).HasColumnName("destinatario");

                entity.Property(e => e.Destino).HasColumnName("destino");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdUsuariCreo)
                    .IsRequired()
                    .HasMaxLength(75)
                    .HasColumnName("Id_UsuariCreo")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreDestinatario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nombre_destinatario");

                entity.Property(e => e.NombreDestino)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nombre_destino");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(350)
                    .HasColumnName("observacion");

                entity.Property(e => e.Transportista)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("transportista")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SubFamilia>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoFamiliaNavigation)
                    .WithMany(p => p.SubFamilia)
                    .HasForeignKey(d => d.CodigoFamilia)
                    .HasConstraintName("FK_SubFamilias_Familia");
            });

            modelBuilder.Entity<SubUbicacion>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("SubUbicacion");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodSubUbicacion).HasColumnName("Cod_SubUbicacion");

                entity.Property(e => e.CodUbicacion).HasColumnName("Cod_Ubicacion");

                entity.Property(e => e.DescripcionD)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.CodUbicacionNavigation)
                    .WithMany(p => p.SubUbicacions)
                    .HasForeignKey(d => d.CodUbicacion)
                    .HasConstraintName("FK_SubUbicacion_Ubicaciones");
            });

            modelBuilder.Entity<Sucursale>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion).IsRequired();

                entity.Property(e => e.NombreComercial)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NombreFiscal)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TemBodega>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tem_Bodegas");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BirthDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Birth_Date");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Country)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("First_Name")
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Last_Name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TemBodegasConsignada>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tem_BodegasConsignadas");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BirthDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Birth_Date");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Country)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("First_Name")
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Last_Name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Temp1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Temp1");

                entity.Property(e => e.CodArticulo).HasColumnName("Cod_Articulo");

                entity.Property(e => e.CodArticulo1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CodArticulo");

                entity.Property(e => e.DescArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Desc_Articulo");

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tempcaby>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempcabys");

                entity.Property(e => e.Barras)
                    .HasMaxLength(50)
                    .HasColumnName("barras");

                entity.Property(e => e.Cabys)
                    .HasMaxLength(50)
                    .HasColumnName("cabys");
            });

            modelBuilder.Entity<TemperaturaCamara>(entity =>
            {
                entity.ToTable("TemperaturaCamara");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Horario)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('AM')")
                    .IsFixedLength(true);

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .HasColumnName("Id_Usuario");

                entity.Property(e => e.Temperatura)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TipoExoneracion>(entity =>
            {
                entity.HasKey(e => e.IdTipoExoneracion);

                entity.ToTable("TipoExoneracion");

                entity.Property(e => e.IdTipoExoneracion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoExoneracion1)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("TipoExoneracion");
            });

            modelBuilder.Entity<TipoTarjetum>(entity =>
            {
                entity.Property(e => e.CuentaComision)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('--')");

                entity.Property(e => e.CuentaContable)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('--')");

                entity.Property(e => e.CuentaCxc)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("CuentaCXC")
                    .HasDefaultValueSql("('--')");

                entity.Property(e => e.CuentaIv)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("CuentaIV")
                    .HasDefaultValueSql("('--')");

                entity.Property(e => e.Moneda).HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('--')");

                entity.Property(e => e.NombreComision)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('--')");

                entity.Property(e => e.NombreCuenta)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('--')");

                entity.Property(e => e.NombreCxc)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NombreCXC")
                    .HasDefaultValueSql("('--')");

                entity.Property(e => e.NombreIv)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NombreIV")
                    .HasDefaultValueSql("('--')");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('--')");
            });

            modelBuilder.Entity<Toma1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TOMA1");

                entity.Property(e => e.CodArticulo).HasColumnName("Cod_Articulo");

                entity.Property(e => e.CodArticulo1).HasColumnName("CodArticulo");

                entity.Property(e => e.DescArticulo)
                    .HasMaxLength(255)
                    .HasColumnName("Desc_Articulo");
            });

            modelBuilder.Entity<TomaGeneral>(entity =>
            {
                entity.HasKey(e => e.IdToma);

                entity.ToTable("TomaGeneral");

                entity.Property(e => e.IdToma)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.NumeroAjuste).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TomaGeneralDetalle>(entity =>
            {
                entity.HasKey(e => e.IdTomaDetalle);

                entity.ToTable("TomaGeneralDetalle");

                entity.Property(e => e.IdTomaDetalle)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Barras)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Cod_Articulo");

                entity.Property(e => e.Codigo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IdToma).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TomaProveedor>(entity =>
            {
                entity.ToTable("TomaProveedor");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodigoProv).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.IdUsuarioCreo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Id_UsuarioCreo");
            });

            modelBuilder.Entity<TomaProveedorDetalle>(entity =>
            {
                entity.ToTable("TomaProveedorDetalle");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Codigo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Descripicon)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTomaProveedor)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_TomaProveedor");
            });

            modelBuilder.Entity<TrasladoPuntoVentaDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TrasladoPuntoVenta_Detalle");

                entity.Property(e => e.Codigo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdTrasladoPuntoVenta)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_TrasladoPuntoVenta");
            });

            modelBuilder.Entity<TrasladoPuntoVentum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdPuentoVentaDestino)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_PuentoVentaDestino");

                entity.Property(e => e.IdPuntoVentaOrigen)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_PuntoVentaOrigen");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.IdUsuarioCreo)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Id_UsuarioCreo");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ubicacione>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Activa)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UltimoAbonoapartado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UltimoAbonoapartados");

                entity.Property(e => e.Apartado).HasColumnName("apartado");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdAbonoapartado).HasColumnName("Id_abonoapartado");
            });

            modelBuilder.Entity<UltimoRecibo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UltimoRecibo");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdRecibo).HasColumnName("Id_Recibo");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ValidaFirmadocontado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VALIDA_FIRMADOCONTADO");

                entity.Property(e => e.Contado).HasColumnName("CONTADO");

                entity.Property(e => e.ExigeNombre).HasColumnName("EXIGE_NOMBRE");

                entity.Property(e => e.IdValidaFirmadocontado)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ID_VALIDA_FIRMADOCONTADO");

                entity.Property(e => e.MaximoAutoriza)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("MAXIMO_AUTORIZA");

                entity.Property(e => e.MaximoCliente)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("MAXIMO_CLIENTE");

                entity.Property(e => e.MaximoRetira)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("MAXIMO_RETIRA");

                entity.Property(e => e.MontoMaximo)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("MONTO_MAXIMO");

                entity.Property(e => e.Pve).HasColumnName("PVE");
            });

            modelBuilder.Entity<Variable>(entity =>
            {
                entity.ToTable("Variable");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Variable1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Variable");
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.NumFactura, e.Tipo, e.NumCaja }, "IX_Ventas")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.Fecha, e.Tipo }, "indexviewfacturascredito");

                entity.Property(e => e.Agente).HasColumnName("agente");

                entity.Property(e => e.Apartado).HasColumnName("apartado");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000000000')");

                entity.Property(e => e.CedulaUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_Usuario");

                entity.Property(e => e.ClaveMh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ClaveMH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaveReenvio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodAgente).HasColumnName("cod_agente");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodEncargadoCompra)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Encargado_Compra");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.ConsecutivoMh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ConsecutivoMH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ConsecutivoReenvio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContabilizadoCventa).HasColumnName("ContabilizadoCVenta");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EnviadoMh).HasColumnName("EnviadoMH");

                entity.Property(e => e.EstadoMh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EstadoMH")
                    .HasDefaultValueSql("('pendiente')");

                entity.Property(e => e.Etapa).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExcluirCxC).HasColumnName("excluirCxC");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaArchivo).HasColumnType("datetime");

                entity.Property(e => e.FechaEtapa).HasColumnType("datetime");

                entity.Property(e => e.IdAdelanto)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Adelanto");

                entity.Property(e => e.IdFacturaRemplaza)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_FacturaRemplaza");

                entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");

                entity.Property(e => e.ImpVenta).HasColumnName("Imp_Venta");

                entity.Property(e => e.MonedaNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Moneda_Nombre");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumApertura).HasColumnName("Num_Apertura");

                entity.Property(e => e.NumCaja)
                    .HasColumnName("Num_Caja")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.NumeroReenvio).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Orden)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PagoComision).HasColumnName("Pago_Comision");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");

                entity.Property(e => e.TipoCedula)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('FISICA')");

                entity.Property(e => e.UsuarioArchivo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Vence).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<VentasContado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VentasContado");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumApertura).HasColumnName("Num_Apertura");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VentasCredito>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VentasCredito");

                entity.Property(e => e.CedulaUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_Usuario");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.Expr1)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumApertura).HasColumnName("Num_Apertura");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");
            });

            modelBuilder.Entity<VentasDetalle>(entity =>
            {
                entity.HasKey(e => e.IdVentaDetalle);

                entity.ToTable("Ventas_Detalle");

                entity.HasIndex(e => e.Codigo, "ncBuscarporCodigo");

                entity.HasIndex(e => e.IdFactura, "nc_BuscarxId_Factura");

                entity.Property(e => e.IdVentaDetalle).HasColumnName("id_venta_detalle");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodMonedaVenta)
                    .HasColumnName("Cod_MonedaVenta")
                    .HasDefaultValueSql("((500))");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Disminuye).HasDefaultValueSql("((0))");

                entity.Property(e => e.Empaquetado).HasColumnName("empaquetado");

                entity.Property(e => e.Entregado)
                    .HasColumnName("entregado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Entregados).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.IdBodega)
                    .HasColumnName("id_bodega")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");

                entity.Property(e => e.IdImpuesto)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Impuesto");

                entity.Property(e => e.IdSerie).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdTipoExoneracion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Lote)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxDescuento).HasColumnName("Max_Descuento");

                entity.Property(e => e.MontoDescuento).HasColumnName("Monto_Descuento");

                entity.Property(e => e.MontoImpuesto).HasColumnName("Monto_Impuesto");

                entity.Property(e => e.NotaPantalla)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nota_pantalla")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.NumeroDocumento)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumeroEntrega).HasColumnName("Numero_Entrega");

                entity.Property(e => e.PrecioBase).HasColumnName("Precio_Base");

                entity.Property(e => e.PrecioCosto).HasColumnName("Precio_Costo");

                entity.Property(e => e.PrecioFlete).HasColumnName("Precio_Flete");

                entity.Property(e => e.PrecioOtros).HasColumnName("Precio_Otros");

                entity.Property(e => e.PrecioUnit).HasColumnName("Precio_Unit");

                entity.Property(e => e.Regalias)
                    .HasColumnName("regalias")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoCambioValorCompra)
                    .HasColumnName("Tipo_Cambio_ValorCompra")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.VentasDetalles)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ventas_Detalle_Inventario");

                entity.HasOne(d => d.IdFacturaNavigation)
                    .WithMany(p => p.VentasDetalles)
                    .HasForeignKey(d => d.IdFactura)
                    .HasConstraintName("FK_Ventas_Detalle_Ventas");
            });

            modelBuilder.Entity<VentasDetalleLote>(entity =>
            {
                entity.HasKey(e => e.IdVentaDetalleLote);

                entity.ToTable("Ventas_Detalle_Lote");

                entity.Property(e => e.IdVentaDetalleLote)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_venta_detalle_lote");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.IdLote)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_lote");

                entity.Property(e => e.IdVentaDetalle)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id_venta_detalle");
            });

            modelBuilder.Entity<VentasFiscale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Ventas_Fiscales");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cedula");

                entity.Property(e => e.DescuentoDev).HasColumnName("Descuento_Dev");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.ImpVenta).HasColumnName("Imp_Venta");

                entity.Property(e => e.ImpuestoDev).HasColumnName("Impuesto_Dev");

                entity.Property(e => e.MontoDev).HasColumnName("Monto_Dev");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumCaja).HasColumnName("Num_Caja");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.SubTotalExcentoDev).HasColumnName("SubTotalExcento_Dev");

                entity.Property(e => e.SubTotalGravadoDev).HasColumnName("SubTotalGravado_Dev");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");

                entity.Property(e => e.TransporteDev).HasColumnName("Transporte_Dev");
            });

            modelBuilder.Entity<VentasRangoFactura>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VentasRangoFacturas");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ImpVenta).HasColumnName("Imp_Venta");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VentasTaller>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Ventas_Taller");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ImpVenta).HasColumnName("Imp_Venta");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumCaja).HasColumnName("Num_Caja");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");
            });

            modelBuilder.Entity<ViewAdelantosAutorizado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewAdelantosAutorizados");

                entity.Property(e => e.Agente).HasColumnName("agente");

                entity.Property(e => e.Apartado).HasColumnName("apartado");

                entity.Property(e => e.BasedeDatos)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Cedula)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CedulaUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_Usuario");

                entity.Property(e => e.ClaveMh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ClaveMH");

                entity.Property(e => e.CodAgente).HasColumnName("cod_agente");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodEncargadoCompra)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Encargado_Compra");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.ConsecutivoMh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ConsecutivoMH");

                entity.Property(e => e.ContabilizadoCventa).HasColumnName("ContabilizadoCVenta");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EnviadoMh).HasColumnName("EnviadoMH");

                entity.Property(e => e.EstadoMh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EstadoMH");

                entity.Property(e => e.ExcluirCxC).HasColumnName("excluirCxC");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ImpVenta).HasColumnName("Imp_Venta");

                entity.Property(e => e.MonedaNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Moneda_Nombre");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumApertura).HasColumnName("Num_Apertura");

                entity.Property(e => e.NumCaja).HasColumnName("Num_Caja");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Orden)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PagoComision).HasColumnName("Pago_Comision");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");

                entity.Property(e => e.TipoCedula)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vence).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ViewApartadosActivo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewApartadosActivos");

                entity.Property(e => e.Apartado).ValueGeneratedOnAdd();

                entity.Property(e => e.BaseDatos)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewAreas");

                entity.Property(e => e.Articulo).HasMaxLength(340);

                entity.Property(e => e.Barras)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Articulo");

                entity.Property(e => e.Codigo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IdArea).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ViewArticulosDescuento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewArticulosDescuentos");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Factura)
                    .HasMaxLength(38)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.MontoDescuento).HasColumnName("Monto_Descuento");

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewArticulosPromocion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewArticulosPromocion");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Articulo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLimite).HasColumnType("smalldatetime");

                entity.Property(e => e.PrecioA).HasColumnName("Precio_A");

                entity.Property(e => e.PrecioPromo).HasColumnName("Precio_Promo");
            });

            modelBuilder.Entity<ViewCajasBloqueada>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewCajasBloqueadas");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Napertura)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NApertura");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumCaja).HasColumnName("Num_Caja");
            });

            modelBuilder.Entity<ViewCartaExoneracion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewCartaExoneracion");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaVence).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Nota)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NumeroDocumento)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TipoExoneracion)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<ViewComprasDevolucionesAnuale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewComprasDevolucionesAnuales");
            });

            modelBuilder.Entity<ViewControlLote>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewControlLote");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Articulo");

                entity.Property(e => e.Descripcion).HasMaxLength(339);

                entity.Property(e => e.IdBodega).HasColumnName("Id_Bodega");

                entity.Property(e => e.Lote)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PrecioA).HasColumnName("Precio_A");

                entity.Property(e => e.Vence).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewCostoArticulo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewCostoArticulo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Presentacion).HasMaxLength(308);
            });

            modelBuilder.Entity<ViewDepositosCaja>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewDepositosCaja");

                entity.Property(e => e.Banco)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cuenta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdApertura).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDescuento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewDescuentos");

                entity.Property(e => e.ContactoConfirmo).HasMaxLength(255);

                entity.Property(e => e.Desde).HasColumnType("datetime");

                entity.Property(e => e.Hasta).HasColumnType("datetime");

                entity.Property(e => e.IdDescuento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdProveedor).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDevolucione>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewDevoluciones");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            });

            modelBuilder.Entity<ViewEmpresasInterna>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewEmpresasInternas");

                entity.Property(e => e.Abierto)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("abierto")
                    .IsFixedLength(true);

                entity.Property(e => e.Agente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("agente");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cedula");

                entity.Property(e => e.ClienteMoroso).HasColumnName("Cliente_Moroso");

                entity.Property(e => e.CorreoComprobante)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Descuento).HasColumnName("descuento");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("e_mail");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("empresa")
                    .IsFixedLength(true);

                entity.Property(e => e.Fax01)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("fax_01");

                entity.Property(e => e.Fax02)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("fax_02");

                entity.Property(e => e.IdTipoExoneracion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Identificacion).HasColumnName("identificacion");

                entity.Property(e => e.Impuesto).HasColumnName("impuesto");

                entity.Property(e => e.MaxCredito).HasColumnName("max_credito");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Nombreusuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreusuario");

                entity.Property(e => e.Notificar).HasColumnName("notificar");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.PlazoCredito).HasColumnName("Plazo_credito");

                entity.Property(e => e.Sinrestriccion)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sinrestriccion")
                    .IsFixedLength(true);

                entity.Property(e => e.Telefono01)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Telefono_01");

                entity.Property(e => e.Telefono02)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("telefono_02");

                entity.Property(e => e.TipoCedula)
                    .HasMaxLength(50)
                    .HasColumnName("tipo_cedula");

                entity.Property(e => e.TipoCliente)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Tipoprecio).HasColumnName("tipoprecio");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<ViewEstadoCotizacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewEstadoCotizacion");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CodCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Cod_Cliente");

                entity.Property(e => e.Confirmada).HasColumnName("confirmada");

                entity.Property(e => e.ConfirmadaPor)
                    .HasMaxLength(150)
                    .HasColumnName("confirmada_por");

                entity.Property(e => e.Contacto)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoActual)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.ImpVenta).HasColumnName("Imp_Venta");

                entity.Property(e => e.MonedaNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.ObservacionEstado)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");
            });

            modelBuilder.Entity<ViewFacturaCredito>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewFacturaCredito");

                entity.Property(e => e.Agente).HasColumnName("agente");

                entity.Property(e => e.Apartado).HasColumnName("apartado");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CedulaUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_Usuario");

                entity.Property(e => e.ClaveMh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ClaveMH");

                entity.Property(e => e.CodAgente).HasColumnName("cod_agente");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodEncargadoCompra)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Encargado_Compra");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.ConsecutivoMh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ConsecutivoMH");

                entity.Property(e => e.ContabilizadoCventa).HasColumnName("ContabilizadoCVenta");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EnviadoMh).HasColumnName("EnviadoMH");

                entity.Property(e => e.EstadoMh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EstadoMH");

                entity.Property(e => e.ExcluirCxC).HasColumnName("excluirCxC");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IdAdelanto)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Adelanto");

                entity.Property(e => e.ImpVenta).HasColumnName("Imp_Venta");

                entity.Property(e => e.MonedaNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Moneda_Nombre");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumApertura).HasColumnName("Num_Apertura");

                entity.Property(e => e.NumCaja).HasColumnName("Num_Caja");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Orden)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PagoComision).HasColumnName("Pago_Comision");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");

                entity.Property(e => e.TipoCedula)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vence).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ViewFacturasPendientesPagada>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewFacturasPendientesPagadas");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdApertura).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdFactura)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Factura");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewFacturasRepetida>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewFacturasRepetidas");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewImpresoGeneralLote>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewImpresoGeneralLote");

                entity.Property(e => e.Barras)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Articulo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Lote)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Presentacion).HasMaxLength(81);

                entity.Property(e => e.Vence).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewImpuesto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewImpuestos");

                entity.Property(e => e.CodigoImpuesto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Codigo_Impuesto");

                entity.Property(e => e.CodigoTarifa)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Codigo_Tarifa");

                entity.Property(e => e.IdImpuesto)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id_Impuesto");

                entity.Property(e => e.Impuesto)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Simbolo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViewListaMag>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewListaMAG");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Articulo");

                entity.Property(e => e.Descripcion).HasMaxLength(340);

                entity.Property(e => e.Iventa).HasColumnName("IVenta");
            });

            modelBuilder.Entity<ViewMensajeReceptor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewMensajeReceptor");

                entity.Property(e => e.CedulaEmisor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreEmisor)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<ViewPrestamo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewPrestamos");

                entity.Property(e => e.Boleta)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("boleta")
                    .IsFixedLength(true);

                entity.Property(e => e.BoletaProveedor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Articulo");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Destinatario).HasColumnName("destinatario");

                entity.Property(e => e.Destino).HasColumnName("destino");

                entity.Property(e => e.Devuelto).HasColumnName("devuelto");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.NombreDestinatario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nombre_destinatario");

                entity.Property(e => e.NombreDestino)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nombre_destino");

                entity.Property(e => e.Precio).HasColumnName("precio");
            });

            modelBuilder.Entity<ViewProductosPunto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewProductosPuntos");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Articulo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewReporteDevolucione>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewReporteDevoluciones");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Articulo");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDevolucion).HasColumnType("datetime");

                entity.Property(e => e.FechaFactura).HasColumnType("datetime");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewSaldosCero>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSaldosCero");

                entity.Property(e => e.IdCompra)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id_Compra");
            });

            modelBuilder.Entity<ViewSeriesDisponible>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSeriesDisponibles");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Articulo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Series).HasMaxLength(255);
            });

            modelBuilder.Entity<ViewSubtotalDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSubtotalDetalle");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            });

            modelBuilder.Entity<ViewSubtotalesDevolucione>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSubtotalesDevoluciones");
            });

            modelBuilder.Entity<ViewSubtotalesDevoluciones43>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSubtotalesDevoluciones43");
            });

            modelBuilder.Entity<ViewSubtotalesFactura>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSubtotalesFactura");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            });

            modelBuilder.Entity<ViewSubtotalesFactura43>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSubtotalesFactura43");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            });

            modelBuilder.Entity<ViewTomaGeneral>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewTomaGeneral");

                entity.Property(e => e.Barras)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Articulo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SubUbicacion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewUltimaCompra>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewUltimaCompra");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UltimaFecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewUtilidadArticulo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewUtilidadArticulo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Presentacion).HasMaxLength(308);
            });

            modelBuilder.Entity<ViewVentasAgente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewVentasAgente");

                entity.Property(e => e.Agente).HasColumnName("agente");

                entity.Property(e => e.Apartado).HasColumnName("apartado");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CedulaUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_Usuario");

                entity.Property(e => e.ClaveMh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ClaveMH");

                entity.Property(e => e.CodAgente).HasColumnName("cod_agente");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.CodEncargadoCompra)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Encargado_Compra");

                entity.Property(e => e.CodMoneda).HasColumnName("Cod_Moneda");

                entity.Property(e => e.ConsecutivoMh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ConsecutivoMH");

                entity.Property(e => e.ContabilizadoCventa).HasColumnName("ContabilizadoCVenta");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EnviadoMh).HasColumnName("EnviadoMH");

                entity.Property(e => e.EstadoMh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EstadoMH");

                entity.Property(e => e.ExcluirCxC).HasColumnName("excluirCxC");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdAdelanto)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_Adelanto");

                entity.Property(e => e.ImpVenta).HasColumnName("Imp_Venta");

                entity.Property(e => e.MonedaNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Moneda_Nombre");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumApertura).HasColumnName("Num_Apertura");

                entity.Property(e => e.NumCaja).HasColumnName("Num_Caja");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Orden)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PagoComision).HasColumnName("Pago_Comision");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnName("Tipo_Cambio");

                entity.Property(e => e.TipoCedula)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vence).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ViewVentasDevolucionesAnuale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewVentasDevolucionesAnuales");
            });

            modelBuilder.Entity<ViewVentasHora>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewVentasHora");

                entity.Property(e => e.Dia).HasColumnType("datetime");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Hora)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewVentasHuber>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewVentasHuber");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");
            });

            modelBuilder.Entity<VistaAbono>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vista_abonos");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdRecibo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id_Recibo");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumCaja).HasColumnName("Num_Caja");

                entity.Property(e => e.NumRecibo).HasColumnName("Num_Recibo");

                entity.Property(e => e.SaldoActual).HasColumnName("Saldo_Actual");

                entity.Property(e => e.SaldoCuenta).HasColumnName("Saldo_Cuenta");
            });

            modelBuilder.Entity<VistaArmamento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vista_armamento");

                entity.Property(e => e.Armamento).HasColumnName("armamento");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.PrecioUnit).HasColumnName("Precio_Unit");
            });

            modelBuilder.Entity<VistaComprasCredito>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vista_Compras_Credito");

                entity.Property(e => e.CedulaUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveDgt)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ClaveDGT");

                entity.Property(e => e.CodMonedaCompra).HasColumnName("Cod_MonedaCompra");

                entity.Property(e => e.CodigoActividad)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ConsecutivoDgt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ConsecutivoDGT");

                entity.Property(e => e.EnviadoDgt).HasColumnName("EnviadoDGT");

                entity.Property(e => e.EstadoDgt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EstadoDGT");

                entity.Property(e => e.Fec).HasColumnName("FEC");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.IdCompra)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id_Compra");

                entity.Property(e => e.MotivoGasto)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumOrden).HasColumnName("num_orden");

                entity.Property(e => e.NumTrans)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoCompra)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Vence).HasColumnType("datetime");
            });

            modelBuilder.Entity<VistaFactura>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vista_facturas");

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ImpVenta).HasColumnName("Imp_Venta");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumCaja).HasColumnName("Num_Caja");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VistaGeneradorBarra>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vista_Generador_Barras");

                entity.Property(e => e.CodBarrasArticulo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSubFam)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSubFamilia)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VistaInventarioCostoReal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vista_inventario_costo_real");

                entity.Property(e => e.CantidadComprada).HasColumnName("cantidad_comprada");

                entity.Property(e => e.CantidadVendida).HasColumnName("cantidad_vendida");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Articulo");

                entity.Property(e => e.CodPresentOtro).HasColumnName("Cod_PresentOtro");

                entity.Property(e => e.CodigoDescarga)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CostoReal).HasColumnName("costo_real");

                entity.Property(e => e.DescargaDeOtro).HasColumnName("Descarga_de_otro");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioA).HasColumnName("Precio_A");
            });

            modelBuilder.Entity<VistaKardexMovimiento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vista_kardex_movimientos");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Dias).HasColumnName("dias");

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<VistaOrdenCAutoXProveedor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vista_OrdenC_Auto_X_Proveedor");

                entity.Property(e => e.CodigoUbicacion).HasColumnName("Codigo_Ubicacion");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExistActual).HasColumnName("Exist_Actual");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.PorcImpuesto).HasColumnName("Porc_Impuesto");

                entity.Property(e => e.SubUbicacion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VistaPecesCompra>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vista_peces_compra");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdCompra).HasColumnName("Id_Compra");

                entity.Property(e => e.IdCompra1).HasColumnName("IdCompra");

                entity.Property(e => e.Peces).HasColumnName("peces");

                entity.Property(e => e.PrecioA).HasColumnName("Precio_A");
            });

            modelBuilder.Entity<VistaPrestamosInventario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vista_prestamos_inventario");

                entity.Property(e => e.Anulado).HasColumnName("anulado");

                entity.Property(e => e.Boleta)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("boleta")
                    .IsFixedLength(true);

                entity.Property(e => e.BoletaProveedor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Articulo");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Destinatario).HasColumnName("destinatario");

                entity.Property(e => e.Destino).HasColumnName("destino");

                entity.Property(e => e.Devuelto).HasColumnName("devuelto");

                entity.Property(e => e.Entregado).HasColumnName("entregado");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NombreDestinatario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nombre_destinatario");

                entity.Property(e => e.NombreDestino)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nombre_destino");
            });

            modelBuilder.Entity<VistaProductosCotizadosXCliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vista_productos_cotizados_x_cliente");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Cod_Cliente");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<VistaProductosOrganico>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vista_productos_organicos");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.PrecioUnit).HasColumnName("Precio_Unit");

                entity.Property(e => e.ProductosOrganicos).HasColumnName("productos_organicos");
            });

            modelBuilder.Entity<VistaQuimico>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vista_quimicos");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.PrecioUnit).HasColumnName("Precio_Unit");

                entity.Property(e => e.Tienda).HasColumnName("tienda");
            });

            modelBuilder.Entity<VistaReporteInventarioGrafico>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vista_reporte_inventario_grafico");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodCliente).HasColumnName("Cod_Cliente");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");
            });

            modelBuilder.Entity<VistaTiendum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vista_tienda");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.PrecioUnit).HasColumnName("Precio_Unit");

                entity.Property(e => e.Tienda).HasColumnName("tienda");
            });

            modelBuilder.Entity<VistaVentaDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vista_venta_detalle");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.PrecioBase).HasColumnName("Precio_Base");

                entity.Property(e => e.PrecioCosto).HasColumnName("Precio_Costo");

                entity.Property(e => e.PrecioUnit).HasColumnName("Precio_Unit");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VistaVentaMaquinarium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vista_venta_maquinaria");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");

                entity.Property(e => e.Maquinaria).HasColumnName("maquinaria");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.PrecioUnit).HasColumnName("Precio_Unit");
            });

            modelBuilder.Entity<VistaVentasClinica>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vista_Ventas_clinica");

                entity.Property(e => e.Clinica).HasColumnName("clinica");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.PrecioUnit).HasColumnName("Precio_Unit");
            });

            modelBuilder.Entity<VistaVentasMascota>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vista_ventas_mascotas");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");

                entity.Property(e => e.Mascotas).HasColumnName("mascotas");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.PrecioUnit).HasColumnName("Precio_Unit");
            });

            modelBuilder.Entity<VistaVentasPece>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vista_ventas_peces");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.Peces).HasColumnName("peces");

                entity.Property(e => e.PrecioUnit).HasColumnName("Precio_Unit");
            });

            modelBuilder.Entity<VistaVentasTaller>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vista_ventas_taller");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.PrecioUnit).HasColumnName("Precio_Unit");

                entity.Property(e => e.Taller).HasColumnName("taller");
            });

            modelBuilder.Entity<Vistasiningresar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VISTASININGRESAR");

                entity.Property(e => e.BodegaId).HasColumnName("bodega_id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.IdArticuloComprados).HasColumnName("Id_ArticuloComprados");
            });

            modelBuilder.Entity<VwReporteLote>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Reporte_Lote");

                entity.Property(e => e.CantInicial).HasColumnName("Cant_Inicial");

                entity.Property(e => e.CodArticulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Articulo");

                entity.Property(e => e.CodInterno).HasColumnName("Cod_Interno");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(341)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Vencimiento).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
