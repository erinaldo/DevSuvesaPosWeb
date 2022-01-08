using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Sucursale
    {
        public Sucursale()
        {
            AbonoApartados = new HashSet<AbonoApartado>();
            Abonoccobrars = new HashSet<Abonoccobrar>();
            Abonocpagars = new HashSet<Abonocpagar>();
            Abonoreintegros = new HashSet<Abonoreintegro>();
            AgenteVenta = new HashSet<AgenteVenta>();
            AjusteInventarios = new HashSet<AjusteInventario>();
            Ajustesccobrars = new HashSet<Ajustesccobrar>();
            Ajustescpagars = new HashSet<Ajustescpagar>();
            Apartados = new HashSet<Apartado>();
            Aperturacajas = new HashSet<Aperturacaja>();
            Areas = new HashSet<Area>();
            ArqueoTarjeta = new HashSet<ArqueoTarjetum>();
            ArticulosComprados = new HashSet<ArticulosComprado>();
            ArticulosComprasDevueltos = new HashSet<ArticulosComprasDevuelto>();
            ArticulosGastos = new HashSet<ArticulosGasto>();
            ArticulosProveedors = new HashSet<ArticulosProveedor>();
            ArticulosRelacionados = new HashSet<ArticulosRelacionado>();
            ArticulosVentasDevueltos = new HashSet<ArticulosVentasDevuelto>();
            ArticulosXProveedors = new HashSet<ArticulosXProveedor>();
            BitacoraBloqueos = new HashSet<BitacoraBloqueo>();
            BitacoraInactivarClientes = new HashSet<BitacoraInactivarCliente>();
            BitacoraReimpresiones = new HashSet<BitacoraReimpresione>();
            BitacoraVersions = new HashSet<BitacoraVersion>();
            Bitacoras = new HashSet<Bitacora>();
            Bodegas = new HashSet<Bodega>();
            CambioInventarios = new HashSet<CambioInventario>();
            Cierrecajas = new HashSet<Cierrecaja>();
            Clientes = new HashSet<Cliente>();
            Codigos = new HashSet<Codigo>();
            Compras = new HashSet<Compra>();
            Configuraciones = new HashSet<Configuracione>();
            ConsecutivoReciboReintegros = new HashSet<ConsecutivoReciboReintegro>();
            Consecutivos = new HashSet<Consecutivo>();
            Cotizacions = new HashSet<Cotizacion>();
            Cupons = new HashSet<Cupon>();
            DevolucionPrestamos = new HashSet<DevolucionPrestamo>();
            DevolucionesCompras = new HashSet<DevolucionesCompra>();
            DevolucionesVenta = new HashSet<DevolucionesVenta>();
            Encargadocompras = new HashSet<Encargadocompra>();
            FichasxUsuarios = new HashSet<FichasxUsuario>();
            GestionCobroBitacoras = new HashSet<GestionCobroBitacora>();
            Logs = new HashSet<Log>();
            MovimientoCajas = new HashSet<MovimientoCaja>();
            MuertesGastos = new HashSet<MuertesGasto>();
            OrdenTrabajos = new HashSet<OrdenTrabajo>();
            Ordencompras = new HashSet<Ordencompra>();
            PedidoBodegas = new HashSet<PedidoBodega>();
            PreAbonocCobrars = new HashSet<PreAbonocCobrar>();
            PreTomaGenerals = new HashSet<PreTomaGeneral>();
            PreTomaProveedors = new HashSet<PreTomaProveedor>();
            PreVenta = new HashSet<PreVenta>();
            PrecioDiferenciados = new HashSet<PrecioDiferenciado>();
            Prestamos = new HashSet<Prestamo>();
            ProveedorMeta = new HashSet<ProveedorMetum>();
            Referenciabancaria = new HashSet<Referenciabancarium>();
            Referenciacomercials = new HashSet<Referenciacomercial>();
            ResumenPuntos = new HashSet<ResumenPunto>();
            Rifas = new HashSet<Rifa>();
            Series = new HashSet<Serie>();
            TomaGenerals = new HashSet<TomaGeneral>();
            TomaProveedors = new HashSet<TomaProveedor>();
            TrasladoPuntoVenta = new HashSet<TrasladoPuntoVentum>();
            Ubicaciones = new HashSet<Ubicacione>();
            Venta = new HashSet<Venta>();
        }

        public int Id { get; set; }
        public string NombreComercial { get; set; }
        public string NombreFiscal { get; set; }
        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Alias { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public virtual ICollection<AbonoApartado> AbonoApartados { get; set; }
        public virtual ICollection<Abonoccobrar> Abonoccobrars { get; set; }
        public virtual ICollection<Abonocpagar> Abonocpagars { get; set; }
        public virtual ICollection<Abonoreintegro> Abonoreintegros { get; set; }
        public virtual ICollection<AgenteVenta> AgenteVenta { get; set; }
        public virtual ICollection<AjusteInventario> AjusteInventarios { get; set; }
        public virtual ICollection<Ajustesccobrar> Ajustesccobrars { get; set; }
        public virtual ICollection<Ajustescpagar> Ajustescpagars { get; set; }
        public virtual ICollection<Apartado> Apartados { get; set; }
        public virtual ICollection<Aperturacaja> Aperturacajas { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<ArqueoTarjetum> ArqueoTarjeta { get; set; }
        public virtual ICollection<ArticulosComprado> ArticulosComprados { get; set; }
        public virtual ICollection<ArticulosComprasDevuelto> ArticulosComprasDevueltos { get; set; }
        public virtual ICollection<ArticulosGasto> ArticulosGastos { get; set; }
        public virtual ICollection<ArticulosProveedor> ArticulosProveedors { get; set; }
        public virtual ICollection<ArticulosRelacionado> ArticulosRelacionados { get; set; }
        public virtual ICollection<ArticulosVentasDevuelto> ArticulosVentasDevueltos { get; set; }
        public virtual ICollection<ArticulosXProveedor> ArticulosXProveedors { get; set; }
        public virtual ICollection<BitacoraBloqueo> BitacoraBloqueos { get; set; }
        public virtual ICollection<BitacoraInactivarCliente> BitacoraInactivarClientes { get; set; }
        public virtual ICollection<BitacoraReimpresione> BitacoraReimpresiones { get; set; }
        public virtual ICollection<BitacoraVersion> BitacoraVersions { get; set; }
        public virtual ICollection<Bitacora> Bitacoras { get; set; }
        public virtual ICollection<Bodega> Bodegas { get; set; }
        public virtual ICollection<CambioInventario> CambioInventarios { get; set; }
        public virtual ICollection<Cierrecaja> Cierrecajas { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Codigo> Codigos { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<Configuracione> Configuraciones { get; set; }
        public virtual ICollection<ConsecutivoReciboReintegro> ConsecutivoReciboReintegros { get; set; }
        public virtual ICollection<Consecutivo> Consecutivos { get; set; }
        public virtual ICollection<Cotizacion> Cotizacions { get; set; }
        public virtual ICollection<Cupon> Cupons { get; set; }
        public virtual ICollection<DevolucionPrestamo> DevolucionPrestamos { get; set; }
        public virtual ICollection<DevolucionesCompra> DevolucionesCompras { get; set; }
        public virtual ICollection<DevolucionesVenta> DevolucionesVenta { get; set; }
        public virtual ICollection<Encargadocompra> Encargadocompras { get; set; }
        public virtual ICollection<FichasxUsuario> FichasxUsuarios { get; set; }
        public virtual ICollection<GestionCobroBitacora> GestionCobroBitacoras { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
        public virtual ICollection<MovimientoCaja> MovimientoCajas { get; set; }
        public virtual ICollection<MuertesGasto> MuertesGastos { get; set; }
        public virtual ICollection<OrdenTrabajo> OrdenTrabajos { get; set; }
        public virtual ICollection<Ordencompra> Ordencompras { get; set; }
        public virtual ICollection<PedidoBodega> PedidoBodegas { get; set; }
        public virtual ICollection<PreAbonocCobrar> PreAbonocCobrars { get; set; }
        public virtual ICollection<PreTomaGeneral> PreTomaGenerals { get; set; }
        public virtual ICollection<PreTomaProveedor> PreTomaProveedors { get; set; }
        public virtual ICollection<PreVenta> PreVenta { get; set; }
        public virtual ICollection<PrecioDiferenciado> PrecioDiferenciados { get; set; }
        public virtual ICollection<Prestamo> Prestamos { get; set; }
        public virtual ICollection<ProveedorMetum> ProveedorMeta { get; set; }
        public virtual ICollection<Referenciabancarium> Referenciabancaria { get; set; }
        public virtual ICollection<Referenciacomercial> Referenciacomercials { get; set; }
        public virtual ICollection<ResumenPunto> ResumenPuntos { get; set; }
        public virtual ICollection<Rifa> Rifas { get; set; }
        public virtual ICollection<Serie> Series { get; set; }
        public virtual ICollection<TomaGeneral> TomaGenerals { get; set; }
        public virtual ICollection<TomaProveedor> TomaProveedors { get; set; }
        public virtual ICollection<TrasladoPuntoVentum> TrasladoPuntoVenta { get; set; }
        public virtual ICollection<Ubicacione> Ubicaciones { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
