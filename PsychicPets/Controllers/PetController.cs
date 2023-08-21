using GraphQL.AspNet.Attributes;
using GraphQL.AspNet.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace PsychicPets.Controllers;

[ApiController]
[Route("[controller]")]

public class PetController : GraphController
{
    [QueryRoot("pet")]
    public Pet GetPet()
    {
        return new Pet
        {
            Id = 3,
            Name = "Snowy Dream"
        };
    }
}



