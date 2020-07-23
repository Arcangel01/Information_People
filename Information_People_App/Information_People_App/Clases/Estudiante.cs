using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_People_App.Clases
{
    class Estudiante
    {
        public List<string> elementos = new List<string>();
        private string nombre { get; set; }
        private string apellidos;
        private string identificacion;
        private string estado_civil;
        private string curso_matriculado;


        public Estudiante()
        {
        }

        //public string estadoCivil(string NuevoEstado)
        //{
        //    try
        //    {
        //        estado_civil = NuevoEstado;
        //    } catch(Exception ex)
        //    {
        //        return ex.Message;
        //    }
        //}

        public Boolean matriculaCurso(string nombreN, string apellidosN, string id, string estadoC, string nuevo_curso_matriculado)
        {
            try
            {
                nombre = nombreN;
                apellidos = apellidosN;
                identificacion = id;
                estado_civil = estadoC;
                curso_matriculado = nuevo_curso_matriculado;
                elementos.Add(nombre);
                elementos.Add(apellidos);
                elementos.Add(identificacion);
                elementos.Add(estado_civil);
                elementos.Add(curso_matriculado);
         
                return true;

            } catch(Exception ex)
            {
                return false;
            }
        }

        public List<string> listado()
        {
            return elementos.ToList();
        }
    }
}
