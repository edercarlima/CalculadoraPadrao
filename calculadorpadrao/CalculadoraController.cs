/* Classe Model- Serve receber os operadores. */
public class CalculadoraController
{
    private CalculadoraView view;
    private CalculadoraModel model;

    public CalculadoraController()
    {
        view = new CalculadoraView();
        model = new CalculadoraModel();
    }

    public void ExecutarCalculadora()
    {
        int num1 = view.ObterNumero("primeiro");
        string operador = view.ObterOperador();
        int num2 = view.ObterNumero("segundo");

        int resultado = model.Calcular(num1, num2, operador);

        view.MostrarResultado(resultado);
    }
}
