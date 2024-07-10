using HotChocolate.Types;

public class QueryType : ObjectType<QueryResolver>
{
    protected override void Configure(IObjectTypeDescriptor<QueryResolver> descriptor)
    {
        descriptor.Field(t => t.GetPerson()).Name("getPerson");
    }
}
