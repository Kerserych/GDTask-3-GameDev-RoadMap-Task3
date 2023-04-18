Console.WriteLine("Введите A B и С");
string[] mas = Console.ReadLine().Split(' ');
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i].Contains('.') == true)
    {
        mas[i] = mas[i].Replace('.', ',');
    }
}
double res = heron(Convert.ToDouble(mas[0]), Convert.ToDouble(mas[1]), Convert.ToDouble(mas[2]));
Console.WriteLine(res);


double heron(double a, double b, double c)
{
    double s = (a + b + c) / 2;
    return Math.Round((Math.Sqrt(s * (s - a) * (s - b) * (s - c))), 2);
}