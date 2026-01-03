using Il2CppTLD.Gear;

namespace EdiblePlantsMod;

[HarmonyPatch(typeof(GearItem),nameof(GearItem.Awake))]
internal static class PatchPlantGearItems
{
	public static void Postfix(ref GearItem __instance)
	{
		if (__instance.name.Contains("GEAR_RosehipsPrepared"))
		{
			if (Settings.instance.EatHips)
			{
				FoodItem fi = __instance.gameObject.AddComponent<FoodItem>();
				__instance.m_FoodItem = fi;
				fi.m_IsNatural = true;
				fi.m_HarvestedByPlayer = true;
				fi.m_TimeToEatSeconds = 2f;
				fi.m_CaloriesTotal = Settings.instance.RoseHipCalorie;
				fi.m_CaloriesRemaining = Settings.instance.RoseHipCalorie;
				fi.m_EatingAudio = "Play_EatingCattail";
				fi.m_ChanceFoodPoisoningLowCondition = 40f;
				fi.m_ChanceFoodPoisoningRuined = 100f;
				fi.m_Nutrients = Utilities.MakeVitaminC(Settings.instance.RoseHipVC);
			}

			if (Settings.instance.RH_Food)
			{
				__instance.GearItemData.m_Type = GearType.Food;
			}

		}
		if (__instance.name.Contains("GEAR_ReishiPrepared"))
		{
			if (Settings.instance.EatReishi)
			{
				FoodItem fi = __instance.gameObject.AddComponent<FoodItem>();
				__instance.m_FoodItem = fi;
				fi.m_IsNatural = true;
				fi.m_HarvestedByPlayer = true;
				fi.m_TimeToEatSeconds = 2.5f;
				fi.m_CaloriesTotal = Settings.instance.ReishiCalorie;
				fi.m_CaloriesRemaining = Settings.instance.ReishiCalorie;
				fi.m_EatingAudio = "Play_EatingCattail";
				fi.m_ChanceFoodPoisoningLowCondition = 35f;
				fi.m_ChanceFoodPoisoningRuined = 80f;
				fi.m_Nutrients = Utilities.MakeVitaminC(Settings.instance.ReishiVC);
			}

			if (Settings.instance.R_Food)
			{
				__instance.GearItemData.m_Type = GearType.Food;
			}

		}
		if (__instance.name.Contains("GEAR_BirchbarkPrepared"))
		{
			if (Settings.instance.EatBark)
			{
				FoodItem fi = __instance.gameObject.AddComponent<FoodItem>();
				__instance.m_FoodItem = fi;
				fi.m_IsNatural = true;
				fi.m_HarvestedByPlayer = true;
				fi.m_TimeToEatSeconds = 3f;
				fi.m_CaloriesTotal = Settings.instance.BarkCalorie;
				fi.m_CaloriesRemaining = Settings.instance.BarkCalorie;
				fi.m_EatingAudio = "Play_EatingCrunchy";
				fi.m_ChanceFoodPoisoningLowCondition = 40f;
				fi.m_ChanceFoodPoisoningRuined = 75f;
				fi.m_Nutrients = Utilities.MakeVitaminC(Settings.instance.BarkVC);
			}
			
			if (Settings.instance.BB_Food)
			{
					__instance.GearItemData.m_Type = GearType.Food;
			}

		}
		if (__instance.name.Contains("GEAR_OldMansBeardHarvested"))
		{
			if (Settings.instance.EatLichen)
			{
				FoodItem fi = __instance.gameObject.AddComponent<FoodItem>();
				__instance.m_FoodItem = fi;
				fi.m_IsNatural = true;
				fi.m_HarvestedByPlayer = true;
				fi.m_TimeToEatSeconds = 1.25f;
				fi.m_CaloriesTotal = Settings.instance.LichenCalorie;
				fi.m_CaloriesRemaining = Settings.instance.LichenCalorie;
				fi.m_EatingAudio = "Play_EatingCattail";
				fi.m_ChanceFoodPoisoningLowCondition = 25f;
				fi.m_ChanceFoodPoisoningRuined = 75f;
				fi.m_Nutrients = new Il2CppSystem.Collections.Generic.List<FoodItem.Nutrient>();
			}

			if (Settings.instance.BL_Food)
			{
				__instance.GearItemData.m_Type = GearType.Food;
			}

		}
		if (__instance.name.Contains("GEAR_BurdockPrepared"))
		{
			if (Settings.instance.BD_Food)
			{
				__instance.GearItemData.m_Type = GearType.Food;
			}

		}
	}
}

