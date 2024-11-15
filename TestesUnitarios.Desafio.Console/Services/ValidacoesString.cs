namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesString
    {
        public int RetornarQuantidadeCaracteres(string texto)
        => texto.Length;

        public bool ContemCaractere(string texto, string textoProcurado)
        => texto.Contains(textoProcurado);

        public bool TextoTerminaCom(string texto, string textoProcurado)
        => texto.EndsWith(textoProcurado);
    }
}