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
        //METODO BUSCAR
        public Producto Buscar(int codigo)
        {
            if (productInicio != null)
            {
                if (productInicio.codigo != codigo && productUltimo.codigo != codigo)
                {
                    Producto temp = null;

                    if (productUltimo.codigo / 2 > codigo)
                    {
                        temp = productInicio;

                        while (temp.siguiente != null && temp.siguiente.codigo <= codigo)
                        {
                            if (temp.codigo != codigo)
                                temp = temp.siguiente;
                        }
                    }
                    else
                    {
                        temp = productUltimo;

                        while (temp.anterior != null && temp.anterior.codigo >= codigo)
                        {
                            if (temp.codigo != codigo)
                                temp = temp.anterior;
                        }
                    }

                    return temp;
                }
                else
                {
                    if (productInicio.codigo == codigo)
                        return productInicio;
                    else
                        return productUltimo;
                }
            }
            else
                return null;

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
                    if (productUltimo.codigo / 2 > codigo)
                    {
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
        //METODO INSERTAR
        public void Insertar(Producto newProduct, byte posicion)
        {

        }
        private void Insertar(Producto nuevo, Producto temp, int posicion, int cont)
        {

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
