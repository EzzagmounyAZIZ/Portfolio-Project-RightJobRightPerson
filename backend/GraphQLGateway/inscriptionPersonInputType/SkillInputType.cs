namespace GraphQLGateway.inscriptionPersonInputType
{
    public class SkillInputType : InputObjectType<Skill>
    {
        protected override void Configure(IInputObjectTypeDescriptor<Skill> descriptor)
        {
            descriptor.Field(t => t.skill).Type<StringType>();
        }
    }
}
