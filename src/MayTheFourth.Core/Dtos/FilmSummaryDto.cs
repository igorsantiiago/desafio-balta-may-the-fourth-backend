﻿using MayTheFourth.Core.Entities;

namespace MayTheFourth.Core.Dtos;

public class FilmSummaryDto
{
    public FilmSummaryDto() { }
    public FilmSummaryDto(Film film)
    {
        Id = film.Id;
        Title = film.Title;
        EpisodeId = film.EpisodeId;
        Director = film.Director;
        ReleaseDate = film.ReleaseDate;
    }

    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int EpisodeId { get; set; }
    public string Director { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
}