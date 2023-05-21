using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    /// <summary> 
    /// Classe de salutation des utilisateurs
    /// </summary>
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly ILogger<HelloController> _logger;

        /// <summary></summary>
        public HelloController(ILogger<HelloController> logger)
        {
            _logger = logger;
        }

        /// <summary> 
        /// Méthode Hello User 
        /// </summary> 
        /// <param name="firstname">Instance <see cref="string"/> avec le nom de l'utilisateur</param> 
        /// <returns>Instance <see cref="string"/> "Hello <paramref name="firstname"/>!"; sinon, <c>null</c></returns> 
        /// <exception cref="System.ArgumentException">
        /// <paramref name="firstname"/> est <c>null</c> ou vide.
        /// </exception>
        [HttpGet("HelloWorld")]
        public IActionResult HelloWorld(string ?firstname)
        {
            if (string.IsNullOrWhiteSpace(firstname))
            {
                string error = "Aucun nom n'a été renseigné";
                return BadRequest(new { error });
                //throw new ArgumentException(message: "Aucun nom n'a été renseigné");
            }

            string message = $"Hello {firstname}!";
            return Ok(new { message });
        }
    }
}