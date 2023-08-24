using GraphQL.Types;
using PsychicPets.EntityFramework;

namespace PsychicPets.Pets;

public class PetsQuery : ObjectGraphType
{
    public PetsQuery()
    {
        Field<ListGraphType<PetType>>("pets", resolve: context =>
            {
                var petsContext = context.RequestServices.GetRequiredService<PetsContext>();
                return petsContext.Pets.ToList();
            }
        );
    }
}
