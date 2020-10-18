using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Logic {
    public class ProductoLogic : BusinessLogic {
      
        public ProductoLogic() {
            }

        public List<productos> GetAll() {
            List<productos> listaProductos = context.productos.ToList();

            return listaProductos;
            }
        public productos GetOne(int id) {
            return context.productos.SingleOrDefault(x => x.id_producto == id);
            }
        public List<productos> GetProductoPorTipo(int id) {
            List<productos> lista = context.productos.Where(x => x.id_tipo == id).ToList();
            return lista;
            }

        public void Alta(string nombre, int id_productor, double precio,
            int stock, double vol_alcohol, double ml, double? ibu,
            int? año, int? añejamiento,int id_tipo) {
            if (ibu == 0) {
                ibu = null;
                }
            if (año == 0){
                año = null;
                }
            if (añejamiento == 0) {
                año = null;
                }
            try {
                var producto = new productos() {
                    nombre = nombre,
                    id_productor = id_productor,
                    precio = precio,
                    stock = stock,
                    vol_alcohol = vol_alcohol,
                    ml = ml,
                    id_tipo = id_tipo,
                    ibu = ibu,
                    añejamiento = añejamiento,
                    año = año,
                };
                context.productos.Add(producto);
                context.Entry(producto).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();                
                }
            catch (Exception Ex) {
                throw Ex;                
                }
            }
        public void Modificacion(int id, string nombre, int id_productor, double precio,
            int stock, double vol_alcohol,double ml, double? ibu,
            int? año, int? añejamiento,int id_tipo) {
            if (ibu == 0) {
                ibu = null;
                }
            if (año == 0) {
                año = null;
                }
            if (añejamiento == 0) {
                año = null;
                }
            try {                
                productos producto = this.GetOne(id);
                    {
                    producto.nombre = nombre;
                    producto.id_productor = id_productor;
                    producto.precio = precio;
                    producto.stock = stock;                    
                    producto.vol_alcohol = vol_alcohol;
                    producto.ibu = ibu;
                    producto.ml = ml;
                    producto.añejamiento = añejamiento;
                    producto.año = año;
                    producto.id_tipo = id_tipo;
                    };
                context.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                }
            catch (Exception Ex) {
                Console.WriteLine(Ex.InnerException?.Message);
                }
            }

        public void Baja(int id) {
            productos productoAEliminar = this.GetOne(id);
            if (productoAEliminar != null) {
                context.productos.Remove(productoAEliminar);
                context.SaveChanges();
                }
            }

        public productores GetProductorEspecifico(int id)
        {
            productores prod = context.productores.Where(x => x.id_productor == id).SingleOrDefault();
            return prod;
        }

        public int GetIdProductorPorNombre(string nombre)
        {
            productores prod = context.productores.Where(x => x.nombre == nombre).SingleOrDefault();
            return prod.id_productor;
        }

        public string[] GetProductoresDeTipo(string tipo)
        {
            var productores = from p in context.productos
                                        join t in context.tipo_producto
                                        on p.id_tipo equals t.id_tipo
                                        join prod in context.productores
                                        on p.id_productor equals prod.id_productor
                                        where t.descripcion == tipo
                                        select prod.nombre;
            return productores.ToArray();
        }

        public List<productos> GetProductosDeProductor(int id_productor)
        {
            List<productos> productos = context.productos.Where(x => x.id_productor == id_productor).ToList();
            return productos;
        }

    }
}
