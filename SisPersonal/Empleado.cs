namespace EspacioEmpleado
{
    public enum Cargos
    {
        Auxiliar = 0,
        Administrativo = 1,
        Ingeniero = 2,
        Especialista = 3,
        Ivestigador = 4
    }
    public class Empleado
    {
        private string Nombre;
        private string Apellido;
        private DateTime FechaDeNacimiento;
        private char EstadoCivil;
        private DateTime FechaIngresoEnEmpresa;
        private double SueldoBasico;
        private Cargos Cargo;

        public string NombreCompleto
        {
            get => Nombre + " " + Apellido;
        }

        public char Estado
        {
            get => EstadoCivil;
        }

        public double Sueldo
        {
            get => SueldoBasico;
        }
        public string CargoDescripcion
        {
            get => Cargo.ToString();
        }

        public Empleado(string nom, string ape, DateTime nac, char estadoCivil, DateTime ingreso, double sueldoBase, Cargos cargo)
        {
            Nombre = nom;
            Apellido = ape;
            FechaDeNacimiento = nac;
            EstadoCivil = estadoCivil;
            FechaIngresoEnEmpresa = ingreso;
            SueldoBasico = sueldoBase;
            Cargo = cargo;
        }

        public int AntiguedadEmpleado()
        {
            DateTime Hoy = DateTime.Now;
            int antiguedad = Hoy.Year - FechaIngresoEnEmpresa.Year;
            if ((Hoy.Year > FechaIngresoEnEmpresa.Year && Hoy.Month < FechaIngresoEnEmpresa.Month) || (Hoy.Year > FechaIngresoEnEmpresa.Year && Hoy.Month == FechaIngresoEnEmpresa.Month && Hoy.Day < FechaIngresoEnEmpresa.Day))
            {
                antiguedad--;
            }
            return antiguedad;
        }

        public int EdadEmpleado()
        {
            DateTime hoy = DateTime.Now;
            int edad = hoy.Year - FechaDeNacimiento.Year;
            if ((hoy.Year > FechaDeNacimiento.Year && hoy.Month < FechaDeNacimiento.Month) || (hoy.Year > FechaDeNacimiento.Year && hoy.Month == FechaDeNacimiento.Month && hoy.Day < FechaDeNacimiento.Day))
            {
                edad--;
            }
            return edad;
        }

        public int AniosFaltantesParaJubilarse()
        {
            int anios = 0;
            int edad = EdadEmpleado();
            if (edad < 65)
            {
                return 65 - edad;
            }
            return 0;
        }

        public double SalarioEmpleado()
        {
            double adicional = 0;
            int antiguedad = AntiguedadEmpleado();

            if (antiguedad < 20)
            {
                adicional = SueldoBasico * (antiguedad * 0.01);
            }
            else
            {
                adicional = SueldoBasico * 0.25;
            }

            if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
            {
                adicional *= 1.50;
            }

            if (EstadoCivil == 'c')
            {
                adicional += 150000;
            }
            return SueldoBasico + adicional;
        }
    }
}