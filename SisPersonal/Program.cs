// See https://aka.ms/new-console-template for more information
using EspacioEmpleado;

Empleado[] trabajadores = new Empleado[3]; 
trabajadores[0] = new Empleado("Juan", "Castro", new DateTime(2004, 7, 31), 's', new DateTime(2024, 4, 24), 700000, Cargos.Ingeniero);
trabajadores[1] = new Empleado("Ana", "Romero", new DateTime(1981, 9, 9), 'c', new DateTime(2010, 2, 12), 650000, Cargos.Especialista);
trabajadores[2] = new Empleado("Lucas", "Juarez", new DateTime(1999, 4, 8), 's', new DateTime(2020, 8, 17), 500000, Cargos.Administrativo);

double totalSalarios = 0;
foreach (Empleado emp in trabajadores)
{
    totalSalarios += emp.SalarioEmpleado();
}
Console.WriteLine("Monto total: " + totalSalarios);

/*int antiguedad = trabajador.AntiguedadEmpleado();
Console.WriteLine("Antiguedad: " + antiguedad);

int edad = trabajador.EdadEmpleado();
Console.WriteLine("Edad: " + edad);

int anios = trabajador.AniosFaltantesParaJubilarse();
Console.WriteLine("Anios faltantes para su jubilacion: " + anios);

double salario = trabajador.SalarioEmpleado();
Console.WriteLine("Salario final: " + salario);*/


