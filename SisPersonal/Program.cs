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

int masProximo = trabajadores[0].AniosFaltantesParaJubilarse();
int aniosFaltantes, indice = 0;
for (int i = 0; i < 3; i++)
{
    aniosFaltantes = trabajadores[i].AniosFaltantesParaJubilarse();
    if (aniosFaltantes < masProximo)
    {
        masProximo = aniosFaltantes;
        indice = i;
    }
}

Console.WriteLine("\nEmpleado mas proximo a jubilarse: ");
Console.WriteLine(" Nombre completo: " + trabajadores[indice].NombreCompleto);
Console.WriteLine(" Edad: " + trabajadores[indice].EdadEmpleado());
Console.WriteLine(" Estado civil: " + trabajadores[indice].Estado);
Console.WriteLine(" Cargo: " + trabajadores[indice].CargoDescripcion);
Console.WriteLine(" Antiguedad: " + trabajadores[indice].AntiguedadEmpleado());
Console.WriteLine(" Anios faltantes para su jubilacion: " + trabajadores[indice].AniosFaltantesParaJubilarse());
Console.WriteLine(" Salario base: " + trabajadores[indice].Sueldo);
Console.WriteLine(" Salario final: " + trabajadores[indice].SalarioEmpleado());


