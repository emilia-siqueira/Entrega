using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;
using System.Text.RegularExpressions;
using WebAPIDesafio.Dominio;
using static System.Net.Mime.MediaTypeNames;

namespace WebAPIDesafio.Controllers
{
    public class DesafioController : ControllerBase
    {
 
        [HttpPost("DadosPalindrome")]

        public ActionResult<Palindrome> DadosPalindrome(
            string textoPalindrome)

        {
            
            Palindrome palindrome = new Palindrome();

            palindrome.Texto = textoPalindrome;
            palindrome.Palindromo = palindrome.AvaliarPalindrome(textoPalindrome);
           palindrome.CriarArquivo(textoPalindrome);

            return palindrome;

        }

    }
}
