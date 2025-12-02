using Microsoft.AspNetCore.Components;
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

    public class TableAction<TModel>
    {
        public required string Icon { get; set; }
        public required string Text { get; set; }
        public required Action<TModel> OnClick { get; set; }
        public MudBlazor.Color Color { get; set; } = MudBlazor.Color.Primary;
        public MudBlazor.Variant Variant { get; set; } = MudBlazor.Variant.Text;
        public Func<TModel, bool>? IsVisible { get; set; }
    }

    public class TableProps<TModel>
    {
        public required IEnumerable<TableColumn<TModel>> Columns;
        public IEnumerable<TModel> Items { get; set; } = [];
        public bool IsLoading = false;
        public bool IsSelectable = false;
        public ISet<TModel> SelectedItems { get; set; } = new HashSet<TModel>();
        public EventCallback<ISet<TModel>> SelectedItemsChanged { get; set; }
        
        // Actions for each row
        public List<TableAction<TModel>> Actions { get; set; } = new List<TableAction<TModel>>();
        public bool HasActions => Actions != null && Actions.Any();
    }
}