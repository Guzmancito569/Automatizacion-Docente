// See https://aka.ms/new-console-template for more information

int cantidad, presentes = 0, ausentes = 0;
int asistencias = 0;

Console.WriteLine("Ingrese la cantidad de maestros a registrar: ");
cantidad = int.Parse(Console.ReadLine());

string[] nombreDocente = new string[cantidad];
string[] asignatura = new string[cantidad];
string[] turno = new string[cantidad];

for (int i = 0; i < cantidad; i++)
{
    Console.Clear();
    Console.WriteLine("Ingrese su nombre: ");
    nombreDocente[i] = Console.ReadLine();

    Console.WriteLine("Ingrese su asignatura: ");
    asignatura[i] = Console.ReadLine();

    Console.WriteLine("Ingrese el turno: ");
    turno[i] = Console.ReadLine();

    Console.WriteLine("Eliga la opcion del estado de la asistencia del docente: \n1. Presente \n2. Ausente");
    asistencias = int.Parse(Console.ReadLine());

    if (asistencias == 1) {
        presentes++;
    } else if (asistencias == 2) {
        ausentes++;
    }
}

bool validacion = asistencias is not 2 and not 1;
if (validacion) {
    Console.WriteLine("Esta opcion no existe");
} else {
    Console.WriteLine("La cantidad de maestros presentes son: " + presentes);
    Console.WriteLine("La cantidad de maestros ausentes son: " + ausentes);
}