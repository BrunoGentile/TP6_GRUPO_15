using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6_GRUPO_15.clases
{
    public class Productos
    {
       
        //PROPIEDADES 
       private int _Id;
       private string _Nombre_Producto;
       private string _Cant_x_Unidad;
       private decimal _Precio_Unidad;

        //CONSTRUCTORES
        public Productos() 
        {

        }

        public Productos(int Id, string Nombre_Producto, string Cant_x_Unidad, decimal Precio_Unidad)
        {
            _Id = Id;
            _Nombre_Producto = Nombre_Producto;
            _Cant_x_Unidad = Cant_x_Unidad;
            _Precio_Unidad=Precio_Unidad;
        }

        // SETTERS Y GETTERS
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Nombre_Producto
        {
            get { return _Nombre_Producto;}
            set {  _Nombre_Producto = value;}
        }
        public string Cant_x_Unidad
        {
            get { return _Cant_x_Unidad; }
            set { _Cant_x_Unidad = value;}
        }
        public decimal Precio_Unidad
        {
            get { return _Precio_Unidad; }
            set { _Precio_Unidad = value;}
        }
    }
}