﻿using MayTheFourth.Core.Entities;

namespace MayTheFourth.Core.Interfaces.Repositories;

public interface IPlanetRepository
{
    Task<bool> AnyAsync(string name, double gravity);
    Task<List<Planet>?> GetAllAsync();
    Task SaveAsync(Planet planet, CancellationToken cancellationToken);
}
