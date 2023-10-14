using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
        public class Conductor
        {
        private string _Nombre;
        public string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value;
            }
        }
        private int _Telefono;
        public int Telefono
        {
            get
            {
                return _Telefono;
            }
            set
            {
                _Telefono = value;
            }
        }
        private string _Direccion;
        public string Direccion
        {
            get
            {
                return _Direccion;
            }
            set
            {
                _Direccion = value;
            }
        }


        private int _identificacion;

        public int Identificacion
        {
            get
            {
                return _identificacion;
            }
            set
            {
                _identificacion = value;
            }

        }
        public Conductor (string Nombre, int Telefono, string Direccion,  int Identificacion)
        {
            _Nombre = Nombre;
            _Telefono = Telefono;
            _Direccion= Direccion;
            _identificacion= Identificacion;

        }
    }
}
