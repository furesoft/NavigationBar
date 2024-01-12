using System;
using System.Collections.Specialized;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;

namespace MagicBar;

public class MagicBar : ListBox
{
    protected override Type StyleKeyOverride => typeof(MagicBar);

    private ItemsPresenter? partPresenter;

    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        partPresenter = e.NameScope.Find<ItemsPresenter>("PART_Presenter");
    }
}