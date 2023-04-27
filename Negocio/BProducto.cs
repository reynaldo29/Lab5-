using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class BProducto
    {
        DProducto datos = new DProducto();

        public List<Producto> Mostrar(string Nombre)
        {
           var productos= datos.Mostrar();
           var resultado =productos.Where(i =>i.Nombre == Nombre || string.IsNullOrEmpty(Nombre)).ToList();
           return resultado;        
        }

        public void Insertar(Producto producto)
        {
            try
            {
                var productos = datos.Mostrar();
                var max = productos.Select(x=>x.IdProducto).Max();
                producto.IdProducto = max+1;

                datos.Insertar2(producto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizar(Producto producto)
        {
            try
            {
                
                datos.Actualizar(producto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar(Producto producto)
        {
            try
            {

                datos.Eliminar(producto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
