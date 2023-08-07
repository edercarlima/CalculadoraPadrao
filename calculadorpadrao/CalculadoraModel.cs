/* Classe Model- Serve receber os operadores. */
public class CalculadoraModel
{
    public int Calcular(int num1, int num2, string operador)
    {
        switch (operador)
        {
            case "+":
                return num1 + num2;
            case "-":
                return num1 - num2;
            case "*":
                return num1 * num2;
            case "/":
                return num1 / num2;
            default:
                throw new ArgumentException("Operador inválido");
        }
    }
}
