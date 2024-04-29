﻿using MayTheFourth.Core.Contexts.SharedContext;
using MayTheFourth.Core.Entities;
using MayTheFourth.Core.Interfaces.Repositories;

namespace MayTheFourth.Tests.Repositories
{
    public class FakePersonRepository : IPersonRepository
    {
        public List<Person> people = new List<Person>()
        {
            new Person(){ Name = "Obi-Wan Kenobi", BirthYear = "57BBY"},
            new Person(){ Name = "Anakin Skywalker", BirthYear = "41.9BBY"},
            new Person(){ Name = "Chewbacca", BirthYear = "200BBY"},
            new Person(){ Name = "Han Solo", BirthYear = "29BBY"},
            new Person(){ Name = "Yoda", BirthYear = "896BBY"},

        };

        public Task<bool> AnyAsync(string name, string birthYear)
        {
            if (string.Equals(name, people[0].Name) && birthYear.Equals(people[0].BirthYear))
                return Task.FromResult(true);

            return Task.FromResult(false);
        }

        public Task<bool> AnyAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountItemsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Person>?> GetAllAsync()
        {
            await Task.Delay(1000);
            return people;
        }

        public Task<PagedList<Person>> GetAllAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<Person?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Person?> GetBySlugAsync(string slug, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Person?> GetByUrlAsync(string url, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(Person person, CancellationToken cancellationToken)
        {
            if (person is null)
                return Task.FromResult(false);

            return Task.FromResult(true);
        }

        public Task UpdateAsync(Person person, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
