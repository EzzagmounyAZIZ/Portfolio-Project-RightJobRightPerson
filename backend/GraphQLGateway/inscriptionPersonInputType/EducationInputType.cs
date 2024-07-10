namespace GraphQLGateway.inscriptionPersonInputType
{
    public class EducationInputType : InputObjectType<Education>
    {
        protected override void Configure(IInputObjectTypeDescriptor<Education> descriptor)
        {
            descriptor.Field(t => t.InstitutionName).Type<NonNullType<StringType>>();
            descriptor.Field(t => t.FieldOfStudy).Type<NonNullType<StringType>>();
            descriptor.Field(t => t.Location).Type<NonNullType<StringType>>();
            descriptor.Field(t => t.Type).Type<NonNullType<StringType>>();
            descriptor.Field(t => t.StartDate).Type<NonNullType<DateType>>();
            descriptor.Field(t => t.EndDate).Type<NonNullType<DateType>>();
        }
    }
}
