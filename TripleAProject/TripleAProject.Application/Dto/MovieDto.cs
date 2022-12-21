using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using TripleAProject.Webapi.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace TripleAProject.Application.Dto
{
    public record MovieDto(
    Guid Guid,

    [StringLength(255, MinimumLength = 3, ErrorMessage = "Die Länge der Titel ist ungültig.")]
    string Title,
    [StringLength(255, MinimumLength = 3, ErrorMessage = "Die Länge der Link ist ungültig.")]
    string Link,

    Guid GenreGuid) : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var db = validationContext.GetRequiredService<AAAContext>();
            if (!db.Movies.Any(g => g.Guid == GenreGuid))
            {
                yield return new ValidationResult("Author does not exist", new[] { nameof(GenreGuid) });
            }
        }
    }
}
