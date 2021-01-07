
using CoreEscuela;
using CoreEscuela.Entidades;
using CoreEscuela.util;

using static System.Console;

namespace Etapa1
{
  class Program
  {
    static void Main(string[] args)
    {

      var engine = new EscuelaEngine();
      engine.Inicializar();

      imprimirCursoEscuela(engine.Escuela);
      Printer.DibujarLinea(15);

    }

    private static void imprimirCursoEscuela(Escuela escuela)
    {
      WriteLine("|----- Cursos de Nuestra Escuela -----|");
      if (escuela.Cursos == null)
      {
        WriteLine("Aun no tenemos cursos Registrados, Pronto");
      }
      else
      {
        foreach (var curso in escuela.Cursos)
        {
          WriteLine($"Nombre => {curso.Nombre} | ID => {curso.UniquedId} | Jornada => {curso.Jornada}");
        }
      }
    }

  }
}
