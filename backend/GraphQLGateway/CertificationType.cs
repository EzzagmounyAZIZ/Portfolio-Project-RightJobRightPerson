using HotChocolate.Types;

public class CertificationType : ObjectType<Certification>
{
    protected override void Configure(IObjectTypeDescriptor<Certification> descriptor)
    {
        descriptor.Field(t => t.CertificationName).Type<StringType>();
        descriptor.Field(t => t.Organization).Type<StringType>();
        descriptor.Field(t => t.DateOfCompletion).Type<DateTimeType>();
    }
}
