using GraphQL;
using GraphQL.Types;
using PsychicPets.EntityFramework;

namespace PsychicPets.Pets
{
    public class PetsMutation : ObjectGraphType
    {
        public PetsMutation()
        {
            Field<PetType>(
                "createPet",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "name"}
                ),
                resolve: context =>
                {
                    var name = context.GetArgument<string>("name");
                    var petsContext = context.RequestServices.GetRequiredService<PetsContext>();
                    var pet = new Pet
                    {
                        Name = name,
                    };
                    petsContext.Pets.Add(pet);
                    petsContext.SaveChanges();
                    return pet;
                }
            );
        }
    }
}