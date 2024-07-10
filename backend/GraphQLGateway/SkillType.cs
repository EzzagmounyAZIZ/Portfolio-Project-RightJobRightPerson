
public class SkillType : ObjectType<Skill>
{
    protected override void Configure(IObjectTypeDescriptor<Skill> descriptor)
    {
        descriptor.Field(t => t.ID).Type<IntType>();
        descriptor.Field(t => t.skill).Type<StringType>();
        descriptor.Field(t => t.PersonID).Type<IntType>();
    }
}
