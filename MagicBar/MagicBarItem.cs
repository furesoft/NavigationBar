using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Metadata;

namespace MagicBar;

public class MagicBarItem : ListBoxItem
{
    public static readonly StyledProperty<string> TitleProperty =
        AvaloniaProperty.Register<MagicBarItem, string>(nameof(Title));

    public static readonly StyledProperty<Geometry> IconProperty =
        AvaloniaProperty.Register<MagicBarItem, Geometry>(nameof(Icon));

    [Content]
    public string Title
    {
        get => GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public Geometry Icon
    {
        get => GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }
}