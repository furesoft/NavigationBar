using System;
using System.Globalization;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Markup.Xaml;

namespace MagicBar;

public class CirclePositionConverter : MarkupExtension
{
    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        var ipvt = (IProvideValueTarget)serviceProvider.GetService(typeof(IProvideValueTarget));

        return new Binding(){  };
    }
}