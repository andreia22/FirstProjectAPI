using Microsoft.AspNetCore.Mvc;

namespace FirstProjectAPI.Controllers
{
    
    
        [Route("api/people")]
        [ApiController]
        public class PeopleController : ControllerBase
        {
            private readonly ILogger<PeopleController> _logger;

            public PeopleController(ILogger<PeopleController> logger)
            {
                _logger = logger;
            }

            [HttpGet]
            public People Get()
            {
                _logger.LogInformation("Método Get People invocado com sucesso!");
                var people = new People
                {
                    
                    Id = Random.Shared.Next(-20, 55),
                    Name = "Nome",
                    Email = "email@email.com",
                    Password = ""
                };

                return people;
            }

        }
 }

