using Avalonia.Markup.Xaml;
using Scarab.ViewModels;

namespace Scarab.Views
{
    public class SettingsView : View<SettingsViewModel>
    {
        public SettingsView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
