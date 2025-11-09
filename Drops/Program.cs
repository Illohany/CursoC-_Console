// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;

String nome = "Illohany ";
const string saudacao = "Bem-vindo";

Console.WriteLine(nome+saudacao);


int num1 = 12;
int num2 = 10;
Console.WriteLine(num1+num2);

Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

int idadeFutura = idade + 10;

Console.WriteLine("Daqui a 10 anos, você terá " + idadeFutura + "anos.");

Console.Write("Digite o preço do produto: ");
double preco = double.Parse(Console.ReadLine());

double desconto = preco * 0.10;
double precoFinal = preco - desconto;
Console.WriteLine("O preço com 10% de desconto é: R$ " + precoFinal);

const double PI = 3.14159;

Console.Write("Digite o raio do círculo: ");
double raio = double.Parse(Console.ReadLine());

double area = PI * raio * raio;

Console.WriteLine("A área do circulo é: " + area);

        int numero = 22;
        double altura = 1.70;
        string nome1 = "Illohany";
        bool aprovado = true;

        Console.WriteLine("Valor: " + numero + " | Tipo: " + numero.GetType());
        Console.WriteLine("Valor: " + altura + " | Tipo: " + altura.GetType());
        Console.WriteLine("Valor: " + nome1 + " | Tipo: " + nome1.GetType());
        Console.WriteLine("Valor: " + aprovado + " | Tipo: " + aprovado.GetType());



























