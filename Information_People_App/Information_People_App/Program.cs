using Information_People_App.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_People_App
{
    class Program
    {

        static void Main(string[] args)
        {
            Profesor profesor = new Profesor();
            Estudiante estudiante = new Estudiante();
            PersonalServicio personalS = new PersonalServicio();

            Console.WriteLine("Bienvenido al sistema de gestion de la U");
            Console.WriteLine("1. Registrar un empleado de servicio");
            Console.WriteLine("2. Matricular un estudiante a un curso");
            Console.WriteLine("3. Ver profesores");
            Console.WriteLine("4. Imprimir todo");
            //Console.WriteLine
            Console.WriteLine("Escribe una de las opciones");

            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.WriteLine("ingrese el nombre:");
                    string nombreS = Console.ReadLine();
                    Console.WriteLine("ingrese el apellido:");
                    string apellidoS = Console.ReadLine();
                    Console.WriteLine("ingrese la identificacion:");
                    string identificacionS = Console.ReadLine();
                    Console.WriteLine("ingrese el estado civil:");
                    string estado_civilS = Console.ReadLine();
                    Console.WriteLine("ingrese la fecha:");
                    string fechaS = Console.ReadLine();
                    Console.WriteLine("ingrese el numero de despacho:");
                    int despacho = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingrese la seccion:");
                    string seccion = Console.ReadLine();
                    var result = personalS.addPersonaServ(nombreS, apellidoS, identificacionS, estado_civilS, fechaS, despacho, seccion);
                    Console.WriteLine("Agregado correctamente... \n ");
                    break;
                case 2:
                    Console.WriteLine("ingrese el nombre:");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingrese el apellido:");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("ingrese la identificacion:");
                    string identificacion = Console.ReadLine();
                    Console.WriteLine("ingrese el estado civil:");
                    string estado_civil = Console.ReadLine();
                    Console.WriteLine("ingrese el nuevo curso:");
                    string curso = Console.ReadLine();
                    var resultado = estudiante.matriculaCurso(nombre,apellido,identificacion, estado_civil,curso);
                    Console.WriteLine("Agregado correctamente...");
                    if(resultado)
                        estudiante.matriculaCurso(nombre, apellido, identificacion, estado_civil, curso);
                    Console.WriteLine("Agregado correctamente...");
                    break;
                case 3:
                    Console.WriteLine("Ver por tipo de contrato \n 1. Por contrato \n 2. Por nombramiento");
                    int cod = Convert.ToInt32(Console.ReadLine());
                    if(cod == 1)
                    {
                        var profesores = profesor.porContrato();
                        Console.WriteLine(profesores);
                    } else if(cod == 2)
                    {
                        Console.WriteLine("Cuantas horas trabajo el profesor?");
                        int hora = Convert.ToInt32(Console.ReadLine());
                        var profesores = profesor.porNombramiento(hora);
                        Console.WriteLine(profesores);
                    } else
                    {
                        Console.WriteLine("No hay datos!");
                    }
                    break;
                case 4:
                    Console.WriteLine("---Estudiantes---");
                    var est = estudiante.listado();
                    for (int i = 0; i < est.Count; i++)
                    {
                        Console.WriteLine(est[i]);
                    }
                    Console.WriteLine("Personal de servicio");
                    var per = personalS.listado();
                    for (int i = 0; i < per.Count; i++)
                    {
                        Console.WriteLine(per[i]);
                    }
                    Console.WriteLine("---Profesores---");
                    var prof = profesor.porContrato();
                    Console.WriteLine(prof);
                    break;
                default:
                    Console.WriteLine("No elegistes un numero correcto");
                    break;
            }
            Console.ReadKey();
        }

    }
}
