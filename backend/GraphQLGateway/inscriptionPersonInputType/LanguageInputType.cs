namespace GraphQLGateway.inscriptionPersonInputType
{
    public class LanguageInputType : InputObjectType<Language>
    {
        protected override void Configure(IInputObjectTypeDescriptor<Language> descriptor)
        {
            descriptor.Field(t => t.langage).Type<NonNullType<StringType>>();
            descriptor.Field(t => t.Level).Type<NonNullType<StringType>>();
        }
    }
}
