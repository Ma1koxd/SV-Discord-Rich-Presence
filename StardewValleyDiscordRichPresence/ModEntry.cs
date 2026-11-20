using StardewModdingAPI;

namespace StardewValleyDiscordRichPresence;

public class ModEntry : Mod
{
    // SMAPI вызывает Entry один раз при загрузке мода.
    public override void Entry(IModHelper helper)
    {
        Monitor.Log("Привет! Мод работает.", LogLevel.Info);
    }
}