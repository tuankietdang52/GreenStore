using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenStore.Shared.Table
{
    public class TableColumn<TModel> {
        public required string Header { get; set; }
        public required Func<TModel, object?> ValueSelector { get; set; }
        public Func<TModel, object?>? SortSelector { get; set; }
    }

    public class TableProps<TModel>
    {
        public required IEnumerable<TableColumn<TModel>> Columns;
        public IEnumerable<TModel> Items { get; set; } = [];
        public bool IsLoading = false;
        public bool IsSelectable = false;
    }
}
