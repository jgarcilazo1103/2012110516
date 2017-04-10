using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpGarcilazo.Entities
{
    public class tipoTrabajador : trabajador
    {
        string _nombreCargo;
        string _idCargo;

        public string idCargo
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string nombreCargo
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string nombreTrabajador
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public trabajador()
        {
            _idCargo = idCargo;
        }

       
    }
}
