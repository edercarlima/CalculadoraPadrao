/* Classe de Visaulização - Serve para input das informações. */
using System;
public class CalculadoraView
{
    public void MostrarResultado(int resultado)
    {
        Console.WriteLine("Resultado: " + resultado);
        Console.WriteLine("Pressione Enter para sair...");
        Console.ReadLine();
    }

    public string ObterOperador()
    {
        char operador;
        Console.Write("Digite o operador (+, -, *, /): ");

        while (!char.TryParse(Console.ReadLine(), out operador) || !OperadorValido(operador))
        {
            Console.WriteLine("Operador inválido. Tente novamente.");
            Console.Write("Digite o operador (+, -, *, /): ");
        }
        return operador.ToString();
    }

    private bool OperadorValido(char operador)
    {
        return operador == '+' || operador == '-' || operador == '*' || operador == '/';
    }

    public int ObterNumero(string numero)
    {   
        int numeroConvertido;
        Console.Write("Digite o " + numero + " número: ");
        
        while (!int.TryParse(Console.ReadLine(), out numeroConvertido))
        {
            Console.WriteLine("Número inválido. Tente novamente.");
            Console.Write("Digite o " + numero + " número: ");
        }

        return numeroConvertido;
    }
}


