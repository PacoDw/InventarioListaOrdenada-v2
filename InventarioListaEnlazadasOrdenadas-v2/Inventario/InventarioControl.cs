using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class InventarioControl
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //ATRIBUTOS DE LA CLASE
        private Producto productInicio;
        private Producto productUltimo;
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR DE LA CLASE INVENTARIOCONTROL
        public InventarioControl()
        {
            this.productInicio = null;
            this.productUltimo = null;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO AGREGAR 
        public void Agregar(Producto productoNuevo)
        {
            if (productInicio == null)
            {
                productInicio = productoNuevo;
                productUltimo = productoNuevo;
            }
            else if (productoNuevo.codigo < productInicio.codigo)   //Si el producto nuevo es menor que el producto del inicio se recorre
            {
                productInicio.anterior = productoNuevo;
                productoNuevo.siguiente = productInicio;
                productInicio = productoNuevo;

            }
            else if (productoNuevo.codigo != productInicio.codigo)
                Agregar(productInicio, productoNuevo);
        }

        private void Agregar(Producto temp, Producto nuevo)
        {
            //Si el producto siguiente es igual a null y el codigo del producto nuevo es diferente
            //al siguiente codigo, quiere decir que no es un codigo repetido y se agrega
            if (temp.siguiente != null && nuevo.codigo != temp.siguiente.codigo)
            {
                if (nuevo.codigo < temp.siguiente.codigo)
                {
                    nuevo.anterior = temp.siguiente.anterior;
                    temp.siguiente.anterior = nuevo;

                    nuevo.siguiente = temp.siguiente;
                    temp.siguiente = nuevo;
                }
                else
                {
                    Agregar(temp.siguiente, nuevo);
                }
            }
            else if (temp.siguiente == null)
            {
                if (nuevo.codigo != temp.codigo)
                    nuevo.anterior = temp;
                temp.siguiente = nuevo;
                productUltimo = nuevo;
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO BORRAR 
        public void Borrar(int codigo)
        {
            if (productInicio != null)
            {
                if (productInicio.codigo != codigo && productUltimo.codigo != codigo)
                {
                    Producto temp = null;
                    if (productUltimo.codigo / 2 > codigo) //Divido el entre dos para ver que tan cercano esta el producto de cada mitad
                    {                                      //si esta mas de la mitad lo busco de adelante hacia atras, si esta mas cercas del inicio empiezo por este mismo
                        temp = productInicio;

                        while (temp.siguiente != null && temp.siguiente.codigo <= codigo)
                        {
                            if (temp.siguiente.codigo == codigo)
                            {
                                temp.siguiente = temp.siguiente.siguiente;
                                temp.siguiente.anterior = temp;
                            }
                            else
                                temp = temp.siguiente;
                        }
                    }
                    else
                    {
                        temp = productUltimo;

                        while (temp.anterior != null && temp.anterior.codigo >= codigo)
                        {
                            if (temp.anterior.codigo == codigo)
                            {
                                temp.anterior = temp.anterior.anterior;
                                temp.anterior.siguiente = temp;
                            }
                            else
                                temp = temp.anterior;
                        }
                    }
                }
                else
                {
                    if (productInicio.codigo == codigo)
                    {
                        productInicio = productInicio.siguiente;
                        productInicio.anterior = null;
                    }
                    else if (productUltimo.codigo == codigo)
                    {
                        productUltimo = productUltimo.anterior;
                        productUltimo.siguiente = null;
                    }
                }
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO BUSCAR
        public Producto Buscar(int codigo)
        {
            Producto temp = null;
            bool inicio = true;

            if (productInicio != null)
            {

                if (productInicio.codigo == codigo)
                    temp = productInicio;
                else if (productUltimo.codigo == codigo)
                    temp = productUltimo;
                else
                {
                    if (productUltimo.codigo / 2 > codigo)
                        temp = productInicio;
                    else
                    {
                        temp = productUltimo;
                        inicio = false;
                    }
                    temp = Buscar(temp, codigo, inicio);
                }
            }
            return temp;
        }

        private Producto Buscar(Producto temp, int codigo, bool inicio)
        {
            Producto aux = null;
            if (inicio)
            {
                if (temp.siguiente != null && temp.siguiente.codigo <= codigo)
                {
                    if (temp.codigo != codigo)
                        Buscar(temp.siguiente, codigo, inicio);
                    else
                        aux = temp;
                }
            }
            else
            {
                if (temp.anterior != null && temp.anterior.codigo >= codigo)
                {
                    if (temp.codigo != codigo)
                        Buscar(temp.anterior, codigo, inicio);
                    else
                        aux = temp;
                }
            }
            return temp;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO INSERTAR
        public void Insertar(Producto newProduct, byte posicion)
        {
            Producto temp = null;
            int contador = 1;

            if(productInicio != null)
            {
                temp = productInicio;

                if (posicion == contador)
                {
                    newProduct.siguiente = productInicio;
                    productInicio.anterior = newProduct;
                    productInicio = newProduct;
                }
                else
                    Insertar(newProduct, temp, posicion, contador);
            }


        }
        private void Insertar(Producto nuevo, Producto temp, int posicion, int cont)
        {
            if (cont == posicion-1 || temp.siguiente == null)
            {
                if(temp.siguiente != null)
                {
                    nuevo.siguiente = temp.siguiente;
                    temp.siguiente = nuevo;
                    nuevo.anterior = temp;
                    nuevo.siguiente.anterior = nuevo;
                }
                else
                {
                    temp.siguiente = nuevo;
                    nuevo.anterior = temp;
                    productUltimo = nuevo;
                }
            }
            else
            {
                cont++;
                Insertar(nuevo, temp.siguiente, posicion, cont);
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO AGREGAR INICIO
        public void agregarInicio(Producto nuevo)
        {
            if (productInicio != null)
            {
                nuevo.siguiente = productInicio;
                productInicio.anterior = nuevo;
            }
            productInicio = nuevo;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO ELIMINAR PRIMERO
        public void eliminarPrimero()
        {
            if(productInicio != null)
            {
                if (productInicio.siguiente != null && productUltimo.anterior != null)
                {
                    productInicio = productInicio.siguiente;
                    productInicio.anterior.siguiente = null;
                    productInicio.anterior = null;
                }
                else
                    productInicio = productUltimo = null;
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO ELIMINAR ULTIMO
        public void eliminarUltimo()
        {
            if(productUltimo != null)
            {
                if (productInicio.siguiente != null && productUltimo.anterior != null)
                {
                    productUltimo = productUltimo.anterior;
                    productUltimo.siguiente.anterior = null;
                    productUltimo.siguiente = null;
                }
                else
                    productInicio = productUltimo = null;
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO REPORTE
        public string Reporte()
        {
            string reporte = string.Empty;

            if (productInicio != null)
            {
                Producto temp = productInicio;

                while (temp != null)
                {
                    reporte += temp.ToString();

                    temp = temp.siguiente;
                }
            }
            else
                reporte = "No se encontro ningun reporte";

            return reporte;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO REPORTE INVERSO
        public string reporteInverso()
        {
            string reporte = string.Empty;

            if (productUltimo != null)
            {
                Producto temp = productUltimo;

                while (temp != null)
                {
                    reporte += temp.ToString();
                    temp = temp.anterior;
                }
            }
            else
                reporte = "No se encontro ningun reporte";

            return reporte;
        }
    }
}
