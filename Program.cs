
Console.Write("Salário por hora: ");
double salarioHora = double.Parse(Console.ReadLine());

Console.Write("Horas trabalhadas: ");
double horasTrabalhadas = double.Parse(Console.ReadLine());

Console.Write("Horas extras: ");
double horasExtras = double.Parse(Console.ReadLine())!;


double salario = CalcularSalario(salarioHora, horasTrabalhadas, horasExtras);


Console.WriteLine("Salário total: R$ " + salario.ToString("F2"));

static double CalcularSalario(double salarioHora, double horasTrabalhadas, double horasExtras)
{
    double pagamentoNormal = salarioHora * horasTrabalhadas;
    double pagamentoExtras = horasExtras * salarioHora * 1.4;
    return pagamentoNormal + pagamentoExtras;
}

