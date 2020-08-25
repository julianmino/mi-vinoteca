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
        public void Alta(string nombre, string productor, double precio,
            int stock, double vol_alcohol, double ml, double? ibu,
            int? año, int? añejamiento) {
            try {
                var producto = new producto() {
                    nombre = nombre,
                    productor = productor,
                    precio = precio,
                    stock = stock,                    
                    vol_alcohol = vol_alcohol,
                    ibu = ibu,
                    ml = ml,
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
        public void Modificacion(int id, string nombre, string productor, double precio,
            int stock, double vol_alcohol,double ml, double? ibu,
            int? año, int? añejamiento) {
            try {                
                producto producto = this.GetOne(id);
                    {
                    producto.nombre = nombre;
                    producto.productor = productor;
                    producto.precio = precio;
                    producto.stock = stock;                    
                    producto.vol_alcohol = vol_alcohol;
                    producto.ibu = ibu;
                    producto.ml = ml;
                    producto.añejamiento = añejamiento;
                    producto.año = año;
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
