using System;
using System.Collections.Specialized;
using Avalonia.Controls;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;

namespace MagicBar;

public class MagicBar : ListBox
{
    protected override Type StyleKeyOverride => typeof(MagicBar);

    private Grid? partCircle;
    private ItemsPresenter? partPresenter;

    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        partCircle = e.NameScope.Find<Grid>("PART_Circle");
        partPresenter = e.NameScope.Find<ItemsPresenter>("PART_Presenter");

        SelectionChanged += OnSelectionChanged;
        Items.CollectionChanged += ItemsOnCollectionChanged;
    }

    private void ItemsOnCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        this.Width = Items.Count * 100;
        this.InvalidateMeasure();
        this.InvalidateArrange();
        this.InvalidateVisual();
    }

    private void OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        Canvas.SetLeft(partCircle, SelectedIndex * 80);
    }
}