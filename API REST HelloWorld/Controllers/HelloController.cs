using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    /// <summary> 
    /// Classe de salutation des utilisateurs
    /// </summary>
    [ApiController]
    public class HelloController : ControllerBase
    {
        /// <summary> 
        /// Méthode salutation d'un utilisateur 
        /// </summary> 
        /// <param name="firstname">Instance <see cref="string"/> avec le nom de l'utilisateur</param> 
        /// <returns>Instance <see cref="Object"/> "Hello <paramref name="firstname"/>!"; sinon, message d'erreur</returns> 
        /// <response code="200">Ok<response>
        /// <response code="400">Bad Request<response>
        [HttpGet("HelloWorld")]
        public IActionResult HelloWorld(string ?firstname)
        {
            if (string.IsNullOrWhiteSpace(firstname))
            {
                string error = "Aucun nom n'a été renseigné";
                //le message retour est converti en Object JSON
                return BadRequest(new { error });
            }

            string message = $"Hello {firstname}!";
            //le message retour est converti en Object JSON
            return Ok(new { message });
        }
    }
}
