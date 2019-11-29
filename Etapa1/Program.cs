using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.PreEscolar, pais:"Colombia");

            var arregloCursos = new Curso[4];

            arregloCursos[0] = new Curso(){
                Nombre = "101"
            };


            var curso2 = new Curso(){
                Nombre = "201"
            };

            arregloCursos[1] = curso2;

            arregloCursos[2] = new Curso(){
                Nombre = "301"
            };

            arregloCursos[3] = new Curso{
                                Nombre = "404"
                               };

            Console.WriteLine(escuela);
            System.Console.WriteLine("=====================");
            System.Console.WriteLine($"{arregloCursos[0].Nombre}, {arregloCursos[0].UniqueId}");
            System.Console.WriteLine($"{curso2.Nombre}, {curso2.UniqueId}");
            System.Console.WriteLine($"{arregloCursos[2].Nombre}, {arregloCursos[2].UniqueId}");
            System.Console.WriteLine($"{arregloCursos[3].Nombre}, {arregloCursos[3].UniqueId}");

            ImprimirCursos(arregloCursos);
            
            
        }
        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            Console.WriteLine("");
            Console.WriteLine("Imprimiendo por el método");
            for(int i=0; i < arregloCursos.Length;i++){
                Console.WriteLine($"{arregloCursos[i].Nombre}, {arregloCursos[i].UniqueId}");
            }
            // throw new NotImplementedException();
        }
    }
}
