using GraphQL.Types;
using PsychicPets.EntityFramework;

namespace PsychicPets.Pets;

public class PetsQuery : ObjectGraphType
{
    public PetsQuery()
    {
        Field<ListGraphType<PetType>>("pets", resolve: context => new List<Pet> {
            new Pet { Id = 1, Name = "fluffy" }
        });
        
        Field<ListGraphType<PetType>>("petssFromEF", resolve: context =>
            {
                var petsContext = context.RequestServices.GetRequiredService<PetsContext>();
                return petsContext.Pets.ToList();
            }
        );
    }
}
