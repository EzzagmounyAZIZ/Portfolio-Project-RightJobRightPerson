namespace GraphQLGateway.inscriptionPersonInputType
{
    public class InterestHobbieInputType : InputObjectType<Interest_Hobbie>
    {
        protected override void Configure(IInputObjectTypeDescriptor<Interest_Hobbie> descriptor)
        {
            descriptor.Field(t => t.interestAndHobbie).Type<NonNullType<StringType>>();
        }
    }
}
