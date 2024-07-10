using GraphQLGateway.inscriptionPersonInputType;

namespace GraphQLGateway
{
    public class MutationType : ObjectType<MutationResolver>
    {
        protected override void Configure(IObjectTypeDescriptor<MutationResolver> descriptor)
        {
            descriptor.Field(t => t.CreatePerson(default))
                .Argument("input", a => a.Type<NonNullType<PersonInputType>>())
                .Type<NonNullType<PersonType>>();
        }
    }
}