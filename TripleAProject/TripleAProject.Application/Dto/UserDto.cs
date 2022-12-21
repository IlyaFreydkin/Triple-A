using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using TripleAProject.Webapi.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using TripleAProject.Webapi.Model;

namespace TripleAProject.Application.Dto
{
    public record UserDto(
    Guid Guid,

    [StringLength(255, MinimumLength = 3, ErrorMessage = "Die Länge der Name ist ungültig.")]
    string Name,
    [StringLength(20, MinimumLength = 3, ErrorMessage = "Die Länge der Password ist ungültig.")]
    string Password,
    [StringLength(255, MinimumLength = 3, ErrorMessage = "Die Länge der Email ist ungültig.")]
    [EmailAddress]
    string Email,
    [Range(0, 1, ErrorMessage = "Range der Userrole ist ungültig")]
    Userrole Role);
}

