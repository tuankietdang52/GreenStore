namespace GreenStore.Shared
{
    public class SidebarItem
    {   
        public string Name {get; set;} = "";
        public string Href {get; set;} = "";
        public string IconClass {get; set;} = "";

        public SidebarItem()
        {
            
        }

        public SidebarItem(string name, string href, string iconClass) {
            Name = name;
            Href = href;
            IconClass = iconClass;
        }
    }
}