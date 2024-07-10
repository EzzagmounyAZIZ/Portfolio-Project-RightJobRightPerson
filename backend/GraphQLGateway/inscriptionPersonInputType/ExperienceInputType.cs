namespace GraphQLGateway.inscriptionPersonInputType
{
    public class ExperienceInputType : InputObjectType<Experience>
    {
        protected override void Configure(IInputObjectTypeDescriptor<Experience> descriptor)
        {
            descriptor.Field(t => t.CompanyName).Type<NonNullType<StringType>>();
            descriptor.Field(t => t.Position).Type<NonNullType<StringType>>();
            descriptor.Field(t => t.Location).Type<NonNullType<StringType>>();
            descriptor.Field(t => t.Type).Type<NonNullType<StringType>>();
            descriptor.Field(t => t.StartDate).Type<NonNullType<DateType>>();
            descriptor.Field(t => t.EndDate).Type<NonNullType<DateType>>();
            descriptor.Field(t => t.CompanyDescription).Type<NonNullType<StringType>>();
        }
    }
}
