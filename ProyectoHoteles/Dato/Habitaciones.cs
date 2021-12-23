using ProyectoHoteles.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHoteles.Dato
{
    public class Habitaciones
    {
        public List<Habitacion> Consultar()
        {
            using (HotelesEntities contexto = new HotelesEntities())
            {
                return contexto.Habitacion.AsNoTracking().ToList();
            }
        }
        public void Guardar(Habitacion modelo)
        {
            using (HotelesEntities contexto = new HotelesEntities())
            {
                contexto.Habitacion.Add(modelo);
                contexto.SaveChanges();
            }
        }
    }
}
