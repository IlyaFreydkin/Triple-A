using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using TripleAProject.Webapi.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace TripleAProject.Application.Dto
{
    public record MovieRatingDto(
    Guid Guid,

    [Range(1, 5, ErrorMessage = "Range der Rating ist ungültig.")]
    string Value,

    Guid MovieGuid,
    Guid UserGuid) : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var db = validationContext.GetRequiredService<AAAContext>();
            if (!db.Movies.Any(m => m.Guid == MovieGuid))
            {
                yield return new ValidationResult("Author does not exist", new[] { nameof(MovieGuid) });
            }
            if (!db.Users.Any(u => u.Guid == UserGuid))
            {
                yield return new ValidationResult("Author does not exist", new[] { nameof(UserGuid) });
            }
        }
    }
}
