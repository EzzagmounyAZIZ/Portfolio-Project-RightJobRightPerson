using InscriptionRightPerson.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Authentication;
using System.Security.Claims;
using System.Text;

namespace InscriptionRightPerson.Resolvers
{
    public class MutationResolver
    {
        private readonly MyDbContext _context;
        public MutationResolver(MyDbContext context)
        {
            _context = context;
        }



        public async Task<Person> CreatePerson(Person input)
        {


            try
            {

                // Add the input person to the database context
                _context.Add(input);

                // Save changes asynchronously to generate the ID for the person
                await _context.SaveChangesAsync();

                // Return the input person
                return input;
            }
            catch (Exception ex)
            {
                // Include details from the inner exception in the error message
                string errorMessage = "Error creating user: An error occurred while saving the entity changes.";
                if (ex.InnerException != null)
                {
                    errorMessage += " Inner Exception: " + ex.InnerException.Message;
                }

                throw new Exception(errorMessage);
            }
        }
    }
}

/*
        // Method to authenticate a user based on email and password and generate JWT token
        public async Task<string> Authenticate(string email, string password)
        {//SingleOrDefaultAsync
            var user =  _context.People.SingleOrDefault(u => u.MailAddress == email);
            if (user == null || !VerifyPassword(password, user.Password))
            {
                throw new AuthenticationException("Invalid email or password");
            }

            // Generate JWT token
            var token = GenerateJwtToken(user);

            // Return the JWT token
            return token;
        }

        // Method to verify password
        private bool VerifyPassword(string password, string passwordHash)
        {
            // Implement password verification logic here (e.g., using bcrypt or PBKDF2)
            // For demonstration purposes, let's assume simple comparison
            return password == passwordHash;
        }

        // Method to hash password
        private string HashPassword(string password)
        {
            // Implement password hashing logic here (e.g., using bcrypt or PBKDF2)
            // For demonstration purposes, let's assume simple hashing
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password)); // Replace with actual password hashing implementation
        }

        // Method to generate JWT token
        private string GenerateJwtToken(Person user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:SecretKey"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.ID.ToString()),
                    new Claim(ClaimTypes.Email, user.MailAddress)
                }),
                Expires = DateTime.UtcNow.AddHours(1), // Token expires in 1 hour
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
}







        */









/*     // Set the PersonID for each related entity
               foreach (var certification in input.Certifications)
               {
                   certification.PersonID = input.ID.Value;
               }

               foreach (var education in input.Educations)
               {
                   education.PersonID = input.ID.Value;
               }

               foreach (var experience in input.Experiences)
               {
                   experience.PersonID = input.ID.Value;
               }

               foreach (var language in input.Languages)
               {
                   language.PersonID = input.ID.Value;
               }

               foreach (var skill in input.Skills)
               {
                   skill.PersonID = input.ID.Value;
               }

               foreach (var interestHobby in input.Interest_Hobbies)
               {
                   interestHobby.PersonID = input.ID.Value;
               }

               // Add related entities to the context
               _context.Certifications.AddRange(input.Certifications);
               _context.Educations.AddRange(input.Educations);
               _context.Experiences.AddRange(input.Experiences);
               _context.Languages.AddRange(input.Languages);
               _context.Skills.AddRange(input.Skills);
               _context.InterestHobbies.AddRange(input.Interest_Hobbies);

               // Save changes asynchronously to persist related entities with the updated PersonID
               await _context.SaveChangesAsync();
          */
