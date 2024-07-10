namespace GraphQLGateway.inscriptionPersonInputType
{
    public class CertificationInputType : InputObjectType<Certification>
    {
        protected override void Configure(IInputObjectTypeDescriptor<Certification> descriptor)
        {
            descriptor.Field(t => t.CertificationName).Type<NonNullType<StringType>>();
            descriptor.Field(t => t.Organization).Type<NonNullType<StringType>>();
            descriptor.Field(t => t.DateOfCompletion).Type<NonNullType<DateType>>();
        }
    }
}
