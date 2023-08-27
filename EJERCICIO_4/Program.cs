Console.WriteLine("Ingrese el número de alumnos de la sección A, B y C respectivamente");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int C = int.Parse(Console.ReadLine());

int horas = (A + B + C * 6) / 60;
int minutos = A % 5 + B % 8 + C % 6;

Console.WriteLine(horas + " horas y " + minutos + " minutos");
