using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class MutationResolver
{
    private readonly IHttpClientFactory _httpClientFactory;

    public MutationResolver(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<Person> CreatePerson(Person input)
    {
        try
        {
            var httpClient = _httpClientFactory.CreateClient();

            // Define the GraphQL mutation
            var response = await httpClient.PostAsJsonAsync("http://localhost:5002/graphql", new
            {
                query = @"
                    mutation CreatePerson($input: Person!) {
                        createPerson(input: $input) {
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
                                organization
                                dateOfCompletion
                            }
                            educations {
                                id
                                institutionName
                                fieldOfStudy
                                location
                                type
                                startDate
                                endDate
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
                            }
                            languages {
                                id
                                langage
                                level
                            }
                            skills {
                                id
                                skill
                            }
                            interest_Hobbies {
                                id
                                interestAndHobbie
                            }
                        }
                    }",
                variables = new { input }
            });

            response.EnsureSuccessStatusCode();

            // Deserialize the response
            var responseBody = await response.Content.ReadFromJsonAsync<GraphQLResponse<CreatePersonResponse>>();
            return responseBody.Data.CreatePerson;
        }
        catch (Exception ex)
        {
            // Log or handle exceptions as needed
            throw new Exception("Error creating person through GraphQL client: " + ex.Message, ex);
        }
    }
}

public class CreatePersonResponse
{
    public Person CreatePerson { get; set; }
}

public class GraphQLResponse<T>
{
    public T Data { get; set; }
}
