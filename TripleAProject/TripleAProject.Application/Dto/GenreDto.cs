using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleAProject.Application.Dto
{
    public record GenreDto(
    Guid Guid,

    [StringLength(255, MinimumLength = 3, ErrorMessage = "Die Länge der Name ist ungültig.")]
    string Name);
}
