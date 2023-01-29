namespace MauiApp3;

public static class Counter
{
    public static int ModelInstanceCounter => _modelInstanceCounter = _modelInstanceCounter += 1;
    private static int _modelInstanceCounter = 0;
    
    public static int ViewInstanceCounter => _viewInstanceCounter = _viewInstanceCounter += 1;
    private static int _viewInstanceCounter = 0;
}
