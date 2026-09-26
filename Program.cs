Console.WriteLine("Atidade Calcular a área e semiperímetro do triangulo!");

Console.WriteLine("Digite o valor do lado 1:");
double lado1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor do lado 2:");
double lado2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor do lado 3:");
double lado3 = Convert.ToDouble(Console.ReadLine());

double p = (lado1 + lado2 + lado3) / 2;
double area = Math.Sqrt(p * (p - lado1) * (p - lado2) * (p - lado3) );
Console.WriteLine($"Area do triangulo: {area:N2}");

Console.WriteLine("O valor do semiperimetro é: ");
Console.WriteLine($"Semiperimetro do triangulo: {p:N2}");

