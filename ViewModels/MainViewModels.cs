using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiApp8.ViewModels
{
    public partial class MainViewModels : ObservableObject
    {
        public static int index = -1;
        public MainViewModels()
        {
            Items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        [ICommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;
            if (index != -1)
            {
                items[index] = Text;
                index = -1;
                Text = string.Empty;
                return;
            }
            //Add our item
            Items.Add(Text);
            Text = string.Empty;
        }

        [ICommand]
        void Delete(string s)
        {
            if (Items.Contains(s))
            {
                Items.Remove(s);
            }
        }
        [ICommand]
        void Edit(string s)
        {
            if (Items.Contains(s))
            {
                index = Items.IndexOf(s);
                Text = s;
            }
        }
    }
}
