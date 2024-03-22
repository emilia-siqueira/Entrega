using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;
using System.Text.RegularExpressions;
using WebAPIPessoa.Dominio;
using static System.Net.Mime.MediaTypeNames;

namespace WebAPIDesafio.Controllers
{
    public class DesafioController : ControllerBase
    {
 
        [HttpPost("DadosPalindrome")]

        public ActionResult<Palindrome> DadosPalindrome(
            string textoPalindrome)

        {
            string reversoTexto = "";

            Palindrome palindrome = new Palindrome();

            for (int i = textoPalindrome.Length-1; i >=0; i--) //Revertendo a string  
            {
                reversoTexto += textoPalindrome[i].ToString();

            }
            if (reversoTexto == textoPalindrome) // Verifica se a String é um palíndromo, ou não.  
            {
                palindrome.Texto = "A palavra " + textoPalindrome + " é um Palindromo." ;
            }
            else
            {
                palindrome.Texto = "A palavra " + textoPalindrome + " não é um Palindromo.";
            }

            return palindrome;

        }

    }
}
