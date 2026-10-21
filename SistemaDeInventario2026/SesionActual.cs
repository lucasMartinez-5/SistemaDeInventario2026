using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeInventario2026
{
    public class SesionActual
    {
        // pauscodusu del usuario que inició sesión.
        public static string CodigoUsuario = "";

        // causnomlog del usuario que inició sesión.
        public static string NombreUsuario = "";

        // causrolusu del usuario que inició sesión: "administrador" o "cajero".
        public static string Rol = "";

        // Claves de las secciones del panel izquierdo (evita errores de tipeo).
        public const string SECCION_INVERSION = "inversion";   // Gestión de Inversión y Proveedores
        public const string SECCION_INVENTARIO = "inventario"; // Inventario
        public const string SECCION_BUSQUEDA = "busqueda";     // Búsqueda Avanzada
        public const string SECCION_VENTAS = "ventas";         // Punto de Venta
        public const string SECCION_USUARIOS = "usuarios";     // Administración de Usuarios

        // Único lugar donde se define qué puede ver cada rol.
        public static bool PuedeAcceder(string seccion)
        {
            switch (Rol)
            {
                case "Administrador":
                    return true; // todas las secciones
                case "cajero":
                    return seccion != SECCION_USUARIOS; // todas excepto Administración de Usuarios
                default:
                    return false; // rol desconocido o sin sesión: nada
            }
        }

        public static void CerrarSesion()
        {
            CodigoUsuario = "";
            NombreUsuario = "";
            Rol = "";
        }
    }
}
