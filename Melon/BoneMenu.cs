namespace FantasyColiseum.Melon;

internal static class BoneMenu
{
    private static readonly MelonEvent<bool, bool> OnEntryValueChanged = Preferences.Enabled.OnEntryValueChanged;
    private static MenuCategory _menuCategory;
    private static FunctionElement _reloadButton;
    
    public static void Setup()
    {
        MenuCategory mainCat = MenuManager.CreateCategory("Weather Electric", "#6FBDFF");
        _menuCategory = mainCat.CreateCategory("Fantasy Coliseum", "#fec500");
        _menuCategory.CreateBoolPreference("Mod Enabled", Color.white, Preferences.Enabled, Preferences.OwnCategory);
        OnEntryValueChanged.Subscribe(AddReloadButton);
    }
    
    private static void AddReloadButton(bool oldval, bool newval)
    {
        if (Main.LevelBarcode != CommonBarcodes.Maps.FantasyArena) return;
        if (_reloadButton != null) return;
        _reloadButton = _menuCategory.CreateFunctionElement("Reload Level", Color.red, () =>
        {
            SceneStreamer.Reload();
            _menuCategory.Elements.Remove(_reloadButton);
            _reloadButton = null;
        });
    }
}