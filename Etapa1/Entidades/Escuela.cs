//Espacio de nombres, para poder encontrar facilmente los objetos
//en este caso las entidades de la escuela.

namespace CoreEscuela.Entidades{
    class Escuela
    {
        string nombre;
        //Encapsular la variable nombre
        public string Nombre{
            get{return nombre; }
            set{nombre = value; }
        }
        public int AnioCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }

        //Clase 12 del curso de C#
        public TiposEscuela tiposEscuela { get; set; }

        //Clase 18
        public Curso[] cursos { get; set; }

        //Médoto constructor
        // public Escuela(string nombre, int anio){
        //     this.nombre = nombre;
        //     this.AnioCreacion = anio;
        // }
        
        #region Constructores
        //Método constructor escrito de otra forma
        public Escuela(string nombre, int anio) => (this.nombre, this.AnioCreacion)=(nombre, anio);

        //Clase 13
        public Escuela(string nombre, int anio, 
                       TiposEscuela tipo, 
                       string pais="", string Ciudad ="" //parámetros opcionales
                       )
        {
            (this.nombre, this.AnioCreacion)=(nombre, anio);
            this.Pais = pais;
            this.Ciudad = Ciudad;
        }
        #endregion

        

        public override string ToString() {
            return $"Nombre: {nombre}, Tipo: {tiposEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad: {Ciudad}";
        }

    }
}