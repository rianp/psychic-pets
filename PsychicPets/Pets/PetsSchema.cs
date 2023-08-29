using GraphQL.Types;

namespace PsychicPets.Pets;

public class PetsSchema : Schema
{
    public PetsSchema(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        Query = serviceProvider.GetRequiredService<PetsQuery>();
    }
}