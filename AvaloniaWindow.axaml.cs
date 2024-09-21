using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace WindowsFormsApp
{

    public partial class AvaloniaWindow : Window
    {
        public AvaloniaWindow()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}