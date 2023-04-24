using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Eliminar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDataDocument doc = new XmlDataDocument();
            string ruta = "C:\\ruta\\PRUEBA2.xml";

            doc.Load(ruta);

            XmlNode Empleado = doc.DocumentElement;
            XmlNodeList listaEmpleado = doc.SelectNodes("Empleados/persona");

            foreach (XmlNode item in listaEmpleado) {
                if (item.SelectSingleNode("id").InnerText == "44") {

                    XmlNode nodoOld = item;
                    Empleado.RemoveChild(nodoOld);
                }
            }
            doc.Save(ruta);
        }


    }
}
/*
//<?xml version="1.0" encoding="UTF-8"?>
< Empleados >
  < EMPRESA >
    < id > 44 </ id >
  </ EMPRESA >
  < persona >
    < id > 44 </ id >
  </ empleados >
  < persona >
    < id > 44 </ id >
  </ persona >
</ Empleados >
*/
