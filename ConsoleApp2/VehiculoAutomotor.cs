using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class VehiculoAutomotor
    {
        private TipodeVehiculo _tipodeVehiculo;

        public string Tipodevehiculo
        {
            get
            {
                return _marca;
            }
            set
            {
                _marca = value;
            }
        }
        private string _marca;
        public string Marca
        {
            get
            {
                return _marca;
            }
            set
            {
                _marca = value;
            }
        }
        private int _alineamiento;
        public int alineamiento
        {
            get
            {
                return _alineamiento;
            }
            set
            {
                _alineamiento = value;
            }
        }
        private string _Velocidad;
        public string Velocidad
        {
            get
            {
                return _Velocidad;
            }
            set
            {
                _Velocidad = value;
            }
        }
        private string _Color;
        public string color
        {
            get
            {
                return _Color;
            }
            set
            {
                _Color = value;
            }
        }
        private string _Tipo;
        public string Tipo
        {
            get
            {
                return _Tipo;
            }
            set
            {
                _Tipo = value;
            }
        }
        private int _Modelo;
        internal string Id;

        public int Modelo
        {
            get
            {
                return _Modelo;
            }
            set
            {
                _Modelo = value;
            }
        }
        private int _Recorridos;
       
        public int Recorridos
        {
            get
            {
                return _Recorridos;
            }
            set
            {
                _Recorridos = value;
            }
        }

        public VehiculoAutomotor(string Marca, int alineamiento, string Velocidad, string color, string Tipo, int Modelo, int Recorridos)
        {
            _marca = Marca;
            _alineamiento = alineamiento;
            _Velocidad = Velocidad;
            _Color = color;
            _Tipo = Tipo;
            _Modelo = Modelo;
            _Recorridos = Recorridos;

        }
    }
}
