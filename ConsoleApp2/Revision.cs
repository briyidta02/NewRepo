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
        private string _Registrorevision;
        public string RegistroRevision
        {
            get
            {
                return _Registrorevision;
            }
            set
            {
                _Registrorevision  = value;
            }
        }
    }
}