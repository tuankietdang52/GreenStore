using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace GreenStore.Shared.Pagination
{
    public enum Placement
    {
        Start,
        Center,
        End,
    }

    public class PaginationProps
    {
        public required int PageSize { get; set; }

        public required int CurrentPage { get; set; }

        public required int TotalPages { get; set; }

        public Placement Placement { get; set; } = Placement.Start;
    }
}
