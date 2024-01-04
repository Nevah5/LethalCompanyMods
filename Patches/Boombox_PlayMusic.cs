// namespace all_my_fellas_radio.Patches;
// using HarmonyLib;
//
// [HarmonyPatch(typeof(BoomboxItem), "StartMusic")]
// public class BoomboxItem_StartMusic
// {
//     static void Postfix(BoomboxItem __instance, bool startMusic)
//     {
//         if (startMusic) Plugin.LogInfo($"Playing {__instance.boomboxAudio.clip.name}");
//     }
// }