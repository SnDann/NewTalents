
public class Calculadora
{
    private List<string> _historico = new List<string>();
    private string _data;

    public Calculadora(string data)
    {
        _data = data;
    }

    public int somar(int val1, int val2)
    {
        _historico.Add($"{val1} + {val2} = {val1 + val2}");
        return val1 + val2;
    }

    public int multiplicar(int val1, int val2)
    {
        _historico.Add($"{val1} * {val2} = {val1 * val2}");
        return val1 * val2;
    }

    public int dividir(int val1, int val2)
    {
        if (val2 == 0) throw new DivideByZeroException();
        _historico.Add($"{val1} / {val2} = {val1 / val2}");
        return val1 / val2;
    }

    public int subtrair(int val1, int val2)
    {
        _historico.Add($"{val1} - {val2} = {val1 - val2}");
        return val1 - val2;
    }

    public List<string> historico()
    {
        return _historico;
    }
}
