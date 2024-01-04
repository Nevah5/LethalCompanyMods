using System;
using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.Mono;
using HarmonyLib;

namespace all_my_fellas_radio;

[BepInPlugin("dev.nevah5.mods.lethal-company.all-my-fellas-radio", "AllMyFellasRadio", "1.0.0")]
public class Plugin : BaseUnityPlugin
{
    private static Plugin Instance;
    
    private const string Guid = "dev.nevah5.mods.lethal-company.all-my-fellas-radio";

    private const string Name = "AllMyFellasRadio";

    private const string Version = "1.0.0";
    
    private void Awake()
    {
        Instance = this;
        var harmony = new Harmony(Guid);
        harmony.PatchAll();
        Logger.LogInfo($"Plugin {Name} is loaded!");
    }

    #region logging
    internal static void LogDebug(string message) => Instance.Log(message, LogLevel.Debug);
    internal static void LogInfo(string message) => Instance.Log(message, LogLevel.Info);
    internal static void LogWarning(string message) => Instance.Log(message, LogLevel.Warning);
    internal static void LogError(string message) => Instance.Log(message, LogLevel.Error);
    internal static void LogError(Exception ex) => Instance.Log($"{ex.Message}\n{ex.StackTrace}", LogLevel.Error);
    private void Log(string message, LogLevel logLevel) => Logger.Log(logLevel, message);
    #endregion
}
