using InscriptionRightPerson.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InscriptionRightPerson.Resolvers
{
    public class QueryResolver
    {
        private readonly MyDbContext _context;

        public QueryResolver(MyDbContext context)
        {
            _context = context;
        }

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public List<Person> GetPerson()
        {
            try
            {
                var people = _context.People
                    .Include(p => p.Certifications)
                    .Include(p => p.Educations)
                    .Include(p => p.Experiences)
                    .Include(p => p.Languages)
                    .Include(p => p.Skills)
                    .Include(p => p.Interest_Hobbies)
                    .ToList();

                return people;
            }
            catch (Exception ex)
            {
                // Log or handle exception
                return null;
            }

        }
    }
}