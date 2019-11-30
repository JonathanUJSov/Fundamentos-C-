using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.PreEscolar, pais:"Colombia");

            //Implementación de Colecciones
            escuela.cursos = new List<Curso>(){
                new Curso(){Nombre = "101"},
                new Curso(){Nombre = "201"},
                new Curso(){Nombre = "301"},
                new Curso(){Nombre = "401"}
            };
            // System.Collections.Generic.Queue //Colas
            escuela.cursos.Add(new Curso{Nombre = "102", Jornada=TiposJornada.mañana});
            escuela.cursos.Add(new Curso{Nombre = "202", Jornada=TiposJornada.mañana});
            escuela.cursos.Add(new Curso{Nombre = "302", Jornada=TiposJornada.tarde});
            escuela.cursos.Add(new Curso{Nombre = "402", Jornada=TiposJornada.noche});

            var cursos2 = new List<Curso>(){ //Generando otra colección
                new Curso(){Nombre = "103", Jornada = TiposJornada.mañana},
                new Curso(){Nombre = "203", Jornada = TiposJornada.noche},
                new Curso(){Nombre = "303", Jornada = TiposJornada.tarde},
                new Curso(){Nombre = "403", Jornada = TiposJornada.noche}
            };

            Curso temp = new Curso{Nombre = "101 - Vacacional", Jornada = TiposJornada.noche};
            escuela.cursos.AddRange(cursos2); //Agregar el objeto cursos2
            escuela.cursos.Add(temp);
            // escuela.cursos.Clear(); //Quitar todos lo elementos
            // escuela.cursos = null;
            ImprimirCursosEscuela(escuela);
            // WriteLine("Curso-Hash" + temp.GetHashCode()); //Obtener el Hascode de la colección, número que 
                                                             //todos los objetos tienen
            Predicate<Curso> miAlgoritmo = Predicado; //Delegado que debe recibir el tipo de dato, utilizado 
                                                     //para remover un elemento en específico, en este caso,
                                                     //el que tenga nombre = "301"
            escuela.cursos.RemoveAll(miAlgoritmo);  //Llama a la función por cada elemento de la colección
            escuela.cursos.Remove(temp);
            ImprimirCursosEscuela(escuela);
            
        }

        private static bool Predicado(Curso obj)
        {
            return obj.Nombre == "301";
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
