using HotChocolate.Types;

public class PersonType : ObjectType<Person>
{
    protected override void Configure(IObjectTypeDescriptor<Person> descriptor)
    {
        descriptor.Field(t => t.ID).Type<IntType>();
        descriptor.Field(t => t.FirstName).Type<StringType>();
        descriptor.Field(t => t.LastName).Type<StringType>();
        descriptor.Field(t => t.MailAddress).Type<StringType>();
        descriptor.Field(t => t.PhoneNumber).Type<StringType>();
        descriptor.Field(t => t.LinkedIn).Type<StringType>();
        descriptor.Field(t => t.Image).Type<StringType>();
        descriptor.Field(t => t.Address).Type<StringType>();
        descriptor.Field(t => t.Country).Type<StringType>();
        descriptor.Field(t => t.City).Type<StringType>();
        descriptor.Field(t => t.Website).Type<StringType>();
        descriptor.Field(t => t.TargetTitle).Type<StringType>();
        descriptor.Field(t => t.ProfessionalSummary).Type<StringType>();
        descriptor.Field(t => t.Password).Type<StringType>();
        descriptor.Field(t => t.LastConnection).Type<DateTimeType>();

        // Nested objects
        descriptor.Field(t => t.Certifications).Type<ListType<CertificationType>>();
        descriptor.Field(t => t.Educations).Type<ListType<EducationType>>();
        descriptor.Field(t => t.Experiences).Type<ListType<ExperienceType>>();
        descriptor.Field(t => t.Languages).Type<ListType<LanguageType>>();
        descriptor.Field(t => t.Skills).Type<ListType<SkillType>>();
        descriptor.Field(t => t.Interest_Hobbies).Type<ListType<InterestHobbieType>>();
    }
}

// Define other nested types similarly, e.g., CertificationType, EducationType, etc.
