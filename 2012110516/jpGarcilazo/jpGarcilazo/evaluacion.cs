using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpGarcilazo.Entities
{
        public class evaluacion
        {
            List<trabajador> _trabajadores;
            List<plan> _planes;

            public evaluacion()
            {
                _trabajadores = new List<trabajador>();
                _planes = new List<plan>();
               
            }          

            public void evaluacionTrabajador (string idCargo)
            {
                if (_trabajadores.Count == 30)
                    return;


                trabajador _datosTrabajador = _trabajadores.Find(t => t.idCargo == idCargo);

                envioDatos _envioDatos = new Llamada(_datosTrabajador);

                _Llamadas.Add(_llamada);

                Console.WriteLine("La información del trabajador fue enviada por : ", nombreTrabajador);
            }

            public double FinalizarLlamada(string numero)
            {
                Telefono _fonoDestino = _Telefonos.Find(t => t.Numero == numero);

                if (_fonoDestino == null)
                    return 0;

                Llamada _llamada = _Llamadas.Find(ll => ll.Telefono.Numero == _fonoDestino.Numero);

                if (_llamada == null)
                    return 0;

                var duracion = new Reloj().GetTime() - _llamada.Reloj.GetTime();

                double _costoLlamada = duracion * _llamada.Tarifa();

                _Llamadas.Remove(_llamada);

                Console.WriteLine("Llamada Finalizada [{0}]", numero);
                Console.WriteLine("Costo de Llamada [S/ {0}]", _costoLlamada.ToString());
                Console.WriteLine();

                return _costoLlamada;
            }
        }
    }
}
