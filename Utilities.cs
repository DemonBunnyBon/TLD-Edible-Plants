using UnityEngine;
using Il2Cpp;
using MelonLoader;





namespace EdiblePlantsMod
{
    internal static class Utilities
    {

        public static Il2CppSystem.Collections.Generic.List<FoodItem.Nutrient> MakeVitaminC(int amount = 10)
        {
            FoodItem.Nutrient vitc = new FoodItem.Nutrient();
            vitc.m_Amount = amount;
            vitc.m_Nutrient = new Il2CppTLD.Gameplay.AssetReferenceNutrientDefinition("13a8bda1e12982e428b7551cc01b01df");
            Il2CppSystem.Collections.Generic.List<FoodItem.Nutrient> list = new Il2CppSystem.Collections.Generic.List<FoodItem.Nutrient>();
            list.Add(vitc);
            return list;
        }


    }






}


