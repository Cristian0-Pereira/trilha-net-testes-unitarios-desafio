namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        => lista.Where(x => x > 0).ToList();

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        => lista.Contains(numero);

        public List<int> MultiplicarNumerosLista(List<int> lista, int numero)
        => lista.Select(x => x * numero).ToList();

        public int RetornarMaiorNumeroLista(List<int> lista)
        => lista.Max();

        public int RetornarMenorNumeroLista(List<int> lista)
        => lista.Min();
    }
}
