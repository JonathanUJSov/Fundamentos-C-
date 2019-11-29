using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.PreEscolar, pais:"Colombia");

            // var arregloCursos = new Curso[4] {
            //     new Curso(){Nombre = "101"},
            //     new Curso(){Nombre = "201"},
            //     new Curso(){Nombre = "301"},
            //     new Curso(){Nombre = "401"}
            // };

            // Curso[] arregloCursos1 = {
            //     new Curso(){Nombre = "101"},
            //     new Curso(){Nombre = "201"},
            //     new Curso(){Nombre = "301"},
            //     new Curso(){Nombre = "401"}
            // };

            escuela.cursos = new Curso[] {
                new Curso(){Nombre = "101"},
                new Curso(){Nombre = "201"},
                new Curso(){Nombre = "301"},
                new Curso(){Nombre = "401"}
            };

            // escuela.cursos = null;
            ImprimirCursosEscuela(escuela);
            
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("************************************");
            WriteLine("IMPRIMIENDO LOS CURSOS DE LA ESCUELA");
            WriteLine("************************************");

            if (escuela?.cursos != null) //Si escuela es distinto de null pasa a verificar si escuela.cursos es null
            {                           //si ninguna se cumple pasa a else.
                foreach (var curso in escuela.cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueId}");
                }
            }
            else{
                return; //Devolverse, sin hacer nada.
            }
        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            WriteLine("");
            WriteLine("Imprimiendo por el método");
            for(int i=0; i < arregloCursos.Length;i++){
                WriteLine($"{arregloCursos[i].Nombre}, {arregloCursos[i].UniqueId}");
            }
        }
        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            WriteLine("");
            WriteLine("Imprimiendo por el método ForEach");
            
            foreach (var curso in arregloCursos)
            {
                WriteLine($"{curso.Nombre}, {curso.UniqueId}");
            }
        }
    }
}
