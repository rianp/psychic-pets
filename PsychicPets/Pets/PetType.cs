using GraphQL.Types;

namespace PsychicPets.Pets;

public class PetType : ObjectGraphType<Pet>
{
    public PetType()
    {
        Name = "Pet";
        Description = "Pet Type";
        Field(d => d.Id, nullable: false).Description("Pet Id");
        Field(d => d.Name, nullable: true).Description("Pet Name");
    }
}