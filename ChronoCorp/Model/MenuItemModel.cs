using CommunityToolkit.Mvvm.Input;

namespace ChronoCorp.Model
{
    public class MenuItemModel
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public IRelayCommand Command { get; set; }
    }
}
