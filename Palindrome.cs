using System.Text.Json;

namespace WebAPIDesafio.Dominio
{
    public class Palindrome
    {
        private string texto;
        public string Texto { get => texto; set => texto = value; }
        public string Palindromo { get; set; }
        public string Ocorrencias_caracteres { get; set; }

        public String AvaliarPalindrome(string textoPalindrome)


        {
            string reversoTexto = "";
            for (int i = textoPalindrome.Length-1; i >=0; i--) //Revertendo a string  
            {
                reversoTexto += textoPalindrome[i].ToString();

            }
            if (reversoTexto == textoPalindrome) // Verifica se a String é um palíndromo, ou não.  
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }

        public void CriarArquivo (string textoPalindrome)

        {
            string caminho = @"C:\Desafio\palindrome.json";
            string diretorio = Path.GetDirectoryName(caminho);
            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }

            var listaPalindrome = new List<Palindrome>();

            Palindrome palindrome = new Palindrome();
            palindrome.texto=textoPalindrome;
            palindrome.Palindromo = AvaliarPalindrome(textoPalindrome);
            listaPalindrome.Add(palindrome);

            string jsonPalindromes = JsonSerializer.Serialize(listaPalindrome, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(caminho, jsonPalindromes);
            Console.WriteLine(jsonPalindromes);
            Console.WriteLine($"O Arquivo JSON de Palindromes foi craido com sucesso no caminho {caminho}");


        }
    }
}
