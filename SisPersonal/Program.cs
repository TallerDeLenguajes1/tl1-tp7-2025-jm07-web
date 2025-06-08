// See https://aka.ms/new-console-template for more information
using EspacioEmpleado;

Empleado trabajador = new Empleado("Juan", "Castro", new DateTime(2004, 7, 31), 's', new DateTime(2024, 8, 24), 700000, Cargos.Ingeniero);

int antiguedad = trabajador.AntiguedadEmpleado();
Console.WriteLine("Antiguedad: " + antiguedad);
int edad = trabajador.EdadEmpleado();
Console.WriteLine("Edad: " + edad);
int anios = trabajador.AniosFaltantesParaJubilarse();
Console.WriteLine("Anios faltantes para su jubilacion: " + anios);



