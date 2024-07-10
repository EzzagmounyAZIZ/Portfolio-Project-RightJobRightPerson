using HotChocolate.Types;

public class ExperienceType : ObjectType<Experience>
{
    protected override void Configure(IObjectTypeDescriptor<Experience> descriptor)
    {
        descriptor.Field(t => t.CompanyName).Type<StringType>();
        descriptor.Field(t => t.Position).Type<StringType>();
        descriptor.Field(t => t.Location).Type<StringType>();
        descriptor.Field(t => t.Type).Type<StringType>();
        descriptor.Field(t => t.StartDate).Type<DateTimeType>();
        descriptor.Field(t => t.EndDate).Type<DateTimeType>();
        descriptor.Field(t => t.CompanyDescription).Type<StringType>();
    }
}
