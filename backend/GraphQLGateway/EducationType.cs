using HotChocolate.Types;

public class EducationType : ObjectType<Education>
{
    protected override void Configure(IObjectTypeDescriptor<Education> descriptor)
    {
        descriptor.Field(t => t.InstitutionName).Type<StringType>();
        descriptor.Field(t => t.FieldOfStudy).Type<StringType>();
        descriptor.Field(t => t.Location).Type<StringType>();
        descriptor.Field(t => t.Type).Type<StringType>();
        descriptor.Field(t => t.StartDate).Type<DateTimeType>();
        descriptor.Field(t => t.EndDate).Type<DateTimeType>();
    }
}
