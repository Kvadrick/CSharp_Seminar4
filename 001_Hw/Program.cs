Console.WriteLine("Введите число A");
double A = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите степень B");
int B = Convert.ToInt32(Console.ReadLine());

double C = 1;

for (int i = 1; i <= B; i++)
{
    C = C * A;
}

Console.WriteLine(C);