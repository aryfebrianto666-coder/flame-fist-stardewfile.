using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley.GameData.Weapons;

namespace FlameFist;

public sealed class ModEntry : Mod
{
    public override void Entry(IModHelper helper)
    {
        helper.Events.Content.AssetRequested += OnAssetRequested;
        Monitor.Log("Flame Fist prototype loaded. Custom weapon data will be added when Data/Weapons is requested.", LogLevel.Info);
    }

    private void OnAssetRequested(object? sender, AssetRequestedEventArgs e)
    {
        if (!e.NameWithoutLocale.IsEquivalentTo("Data/Weapons"))
            return;

        e.Edit(asset =>
        {
            var weapons = asset.AsDictionary<string, WeaponData>().Data;
            weapons["Community_FlameFist"] = new WeaponData
            {
                Name = "Flame Fist",
                DisplayName = "Flame Fist",
                Description = "A blazing close-combat weapon. Prototype: currently uses the game's club weapon behavior.",
                Type = 2,
                MinDamage = 100,
                MaxDamage = 100,
                Speed = 10,
                Knockback = 1.0f,
                CanBeLostOnDeath = false
            };
        });
    }
}
