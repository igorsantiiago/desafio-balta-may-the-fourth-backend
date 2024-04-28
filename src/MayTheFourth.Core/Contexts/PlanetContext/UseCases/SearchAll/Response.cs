﻿using MayTheFourth.Core.Contexts.SharedContext;
using MayTheFourth.Core.Dtos;
using MayTheFourth.Core.Entities;

namespace MayTheFourth.Core.Contexts.PlanetContext.UseCases.SearchAll;

public class Response : SharedContext.UseCases.Response
{
    public Response(string message, int status)
    {
        Message = message; 
        Status = status;
    }

    public Response(string message, ResponseData data)
    {
        Message = message;
        Status = 200;
        Data = data;
    }

    public ResponseData? Data { get; set; }
}

public record ResponseData(PagedList<PlanetSummaryDto> planets);
