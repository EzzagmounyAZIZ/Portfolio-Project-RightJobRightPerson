using HotChocolate.Types;

public class LanguageType : ObjectType<Language>
{
    protected override void Configure(IObjectTypeDescriptor<Language> descriptor)
    {
        descriptor.Field(t => t.langage).Type<StringType>();
        descriptor.Field(t => t.Level).Type<StringType>();
    }
}
