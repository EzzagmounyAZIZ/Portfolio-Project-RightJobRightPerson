using HotChocolate.Types;

public class InterestHobbieType : ObjectType<Interest_Hobbie>
{
    protected override void Configure(IObjectTypeDescriptor<Interest_Hobbie> descriptor)
    {
        descriptor.Field(t => t.interestAndHobbie).Type<StringType>();
    }
}
