using BepInEx;
using BepInEx.Unity.Mono;

namespace all_my_fellas_radio;

[BepInPlugin("dev.nevah5.mods.lethal-company.all-my-fellas-radio", "AllMyFellasRadio", "1.0.0")]
public class Plugin : BaseUnityPlugin
{
    private void Awake()
    {
        // Plugin startup logic
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
    }
}
