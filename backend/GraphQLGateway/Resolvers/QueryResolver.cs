

public class QueryResolver
{
    private readonly IHttpClientFactory _httpClientFactory;

    public QueryResolver(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<List<Person>> GetPerson()
    {
        var httpClient = _httpClientFactory.CreateClient();
        var response = await httpClient.PostAsJsonAsync("http://localhost:5002/graphql", new
        {
            query = @"
                query {
                  person(where: null, order: null) {
                    id
                    firstName
                    lastName
                    mailAddress
                    phoneNumber
                    linkedIn
                    image
                    address
                    country
                    city
                    website
                    targetTitle
                    professionalSummary
                    password
                    lastConnection
                    certifications {
                      id
                      certificationName
                      dateOfCompletion
                      organization
                      personID
                    }
                    educations {
                      id
                      institutionName
                      fieldOfStudy
                      location
                      type
                      startDate
                      endDate
                      personID
                    }
                    experiences {
                      id
                      companyName
                      position
                      location
                      type
                      startDate
                      endDate
                      companyDescription
                      personID
                    }
                    languages {
                      id
                      langage
                      level
                      personID
                    }
                    skills {
                      id
                      skill
                      personID
                    }
                    interest_Hobbies {
                      id
                      interestAndHobbie
                      personID
                    }
                  }
                }"
        });
        response.EnsureSuccessStatusCode();
        var responseBody = await response.Content.ReadFromJsonAsync<GraphQLResponse<GetPersonResponse>>();
        return responseBody.Data.Person;
    }
}

public class GetPersonResponse
{
    public List<Person> Person { get; set; }
}
