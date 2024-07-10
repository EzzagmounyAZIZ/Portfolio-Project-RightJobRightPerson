using GraphQLGateway.inscriptionPersonInputType;

namespace GraphQLGateway.inscriptionPersonInputType
{
    public class PersonInputType : InputObjectType<PersonInput>
    {
        protected override void Configure(IInputObjectTypeDescriptor<PersonInput> descriptor)
        {
            descriptor.Field(t => t.FirstName).Type<NonNullType<StringType>>();
            descriptor.Field(t => t.LastName).Type<NonNullType<StringType>>();
            descriptor.Field(t => t.MailAddress).Type<NonNullType<StringType>>();
            descriptor.Field(t => t.PhoneNumber).Type<NonNullType<StringType>>();
            descriptor.Field(t => t.LinkedIn).Type<StringType>();
            descriptor.Field(t => t.Image).Type<StringType>();
            descriptor.Field(t => t.Address).Type<StringType>();
            descriptor.Field(t => t.Country).Type<StringType>();
            descriptor.Field(t => t.City).Type<StringType>();
            descriptor.Field(t => t.Website).Type<StringType>();
            descriptor.Field(t => t.TargetTitle).Type<StringType>();
            descriptor.Field(t => t.ProfessionalSummary).Type<StringType>();
            descriptor.Field(t => t.Password).Type<NonNullType<StringType>>();
            descriptor.Field(t => t.LastConnection).Type<DateTimeType>();
            descriptor.Field(t => t.Certifications).Type<ListType<CertificationInputType>>();
            descriptor.Field(t => t.Educations).Type<ListType<EducationInputType>>();
            descriptor.Field(t => t.Experiences).Type<ListType<ExperienceInputType>>();
            descriptor.Field(t => t.Languages).Type<ListType<LanguageInputType>>();
            descriptor.Field(t => t.Skills).Type<ListType<SkillInputType>>();
            descriptor.Field(t => t.Interest_Hobbies).Type<ListType<InterestHobbieInputType>>();
        }
    }
}

