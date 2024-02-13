using UnityEngine;
using Il2Cpp;
using MelonLoader;





namespace EdiblePlantsMod
{
    internal static class EdiblePlantsUtils
    {

        public static bool IsScenePlayable(string scene)
        {
            return !(string.IsNullOrEmpty(scene) || scene.Contains("MainMenu") || scene == "Boot" || scene == "Empty");
        }




    }






}


