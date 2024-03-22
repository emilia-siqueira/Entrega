namespace WebAPIPessoa.Dominio
{
    public class Palindrome
    {
        private string texto;

        public string Texto { get => texto; set => texto = value; }
        public Palindrome(string texto)
        {
            this.texto=texto;
        }

        public Palindrome()
        {
        }
    }
}
