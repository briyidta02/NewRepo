namespace ConsoleApp2
{
  public class Revision
    {
        private string _Descripcionvehiculo;
        public string DescripcionVehiculo
        {
            get
            {
                return _Descripcionvehiculo;
            }
            set
            {
              _Descripcionvehiculo = value;
            }
        }
        
        
        private DateTime _Fecharevision;
        public DateTime FechaRevision
        {
            get
            {
                return _Fecharevision;
            }
            set
            {
                _Fecharevision = value;
            }
        }
        public Revision (string DescripcionVehiculo, DateTime FechaRevision)
        {
            _Descripcionvehiculo = DescripcionVehiculo;
            _Fecharevision = FechaRevision;



        }
    }
}