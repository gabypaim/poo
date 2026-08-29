namespace ex04verificadoridade
{
    internal class VerificadorIdade
    {
        public string Maioridade(int idade)
        {
            if (idade >= 18)
            {
                return "Maior de idade";
            }
            else
            {
                return "Menor de idade";
            }
        }
    }
}