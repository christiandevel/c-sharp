using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
  public class Escuela
  {

      public string UniqueId { get; private set; } = Guid.NewGuid().ToString();
      string nombre;

      public string Nombre { 
        get { return nombre; }
        set { nombre = value.ToUpper(); }
      }

      public int AñoDeCreacion { get; set; }
      public string Pais { get; set; }
      public string Ciudad { get; set; }


      public TiposEscuela TipoEscuela { get; set; }

      public List<Curso> Cursos { get; set; }

      

      public Escuela( string nombre, int año ) => (Nombre, AñoDeCreacion) = (nombre, año);

      public Escuela( string nombre, int año, TiposEscuela tipo, string pais = "", string ciudad = "" ) {
        (Nombre, AñoDeCreacion, TipoEscuela) = (nombre, año, tipo);
        Pais = pais;
        Ciudad = ciudad;
      }

      public override string ToString()
      {
        string newLine = System.Environment.NewLine;
        return $"Nombre: {Nombre}, Tipo: {TipoEscuela} {newLine} Pais: {Pais}, Ciudad: {Ciudad}";
      }

  }
}