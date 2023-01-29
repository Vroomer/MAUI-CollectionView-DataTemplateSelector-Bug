namespace MauiApp3;

public class ColorTemplateSelector : DataTemplateSelector
{
    public DataTemplate RedTemplate { get; set; }
    public DataTemplate GreenTemplate { get; set; }
    public DataTemplate BlueTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        switch (((ColorModel)item).Name)
        {
            case "Red": return RedTemplate;
            case "Green": return GreenTemplate;
            case "Blue": return BlueTemplate;
            default: return null;
        }
    }
}