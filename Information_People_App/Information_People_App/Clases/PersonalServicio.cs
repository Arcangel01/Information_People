using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_People_App.Clases
{
    class PersonalServicio
    {
        public List<string> elementos = new List<string>();
        private string nombre;
        private string apellidos;
        private string identificacion;
        private string estado_civil;
        private string fecha_incorporacion;
        private int nro_despacho;
        private string seccion;

        public PersonalServicio()
        {
        }

        public string estadoCivil(string NuevoEstado)
        {
            estado_civil = NuevoEstado;
            return "";
        }

        public string trasladoSeccion(string nuevaSeccion)
        {
            seccion = nuevaSeccion;
            return "";
        }

        public bool addPersonaServ(string nombreN, string apellidosN, string id, string estadoC, string incorp, int despacho, string section)
        {
            nombre = nombreN;
            apellidos = apellidosN;
            identificacion = id;
            estado_civil = estadoC;
            fecha_incorporacion = incorp;
            nro_despacho = despacho;
            seccion = section;

            elementos.Add(nombre);
            elementos.Add(apellidos);
            elementos.Add(identificacion);
            elementos.Add(estado_civil);
            elementos.Add(fecha_incorporacion);
            elementos.Add(Convert.ToString(nro_despacho));
            elementos.Add(seccion);

            return true;
        }

        public List<string> listado()
        {
            return elementos.ToList();
        }
    }
}
