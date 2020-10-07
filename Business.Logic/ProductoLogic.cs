using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Logic {
    public class ProductoLogic : BusinessLogic {
        private YaguaronEntities context = new YaguaronEntities();
        public ProductoLogic() {
            }

        public List<producto> GetAll() {
            List<producto> listaProductos = context.productos.ToList();

            return listaProductos;
            }
        public producto GetOne(int id) {
            return context.productos.SingleOrDefault(x => x.id_producto == id);
            }
        public List<producto> GetProductoPorTipo(int id) {
            List<producto> listaVinos = context.productos.Where(x => x.id_tipo == id).ToList();
            return listaVinos;
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
                var producto = new producto() {
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
                producto producto = this.GetOne(id);
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
            producto productoAEliminar = this.GetOne(id);
            if (productoAEliminar != null) {
                context.productos.Remove(productoAEliminar);
                context.SaveChanges();
                }
            }
        }
    }
