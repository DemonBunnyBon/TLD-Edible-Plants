using EdiblePlantsMod;
using Il2Cpp;
using Il2CppRewired.Utils;
using Il2CppTLD.BigCarry;
using Il2CppTLD.Gear;
using System.Runtime.InteropServices;


namespace EdiblePlantsMod
{
	public class EdiblePlants : MelonMod
	{
		public override void OnInitializeMelon()
		{
			MelonLoader.MelonLogger.Msg(System.ConsoleColor.Yellow, "Gonna munch on some rose hips...");
            MelonLoader.MelonLogger.Msg(System.ConsoleColor.Green, "Hi, Edible Plants is enabled!");
			Settings.instance.AddToModSettings("Edible Plants");
			Settings.OnLoad();
		}
		private static bool Done;
		public static bool SceneLoaded;

		public override void OnSceneWasLoaded(int buildIndex, string sceneName) //When scene is loaded
		{
			if(EdiblePlantsUtils.IsScenePlayable(sceneName))  //Checks if it's not a menu scene
			{
				SceneLoaded = true;

				ChangeItemProperties();
			}


		}



		private static void ChangeItemProperties()
		{


			GameObject gear;
			FoodItem.Nutrient vitc = new FoodItem.Nutrient();
			vitc.m_Amount = 10;
			vitc.m_Nutrient = new Il2CppTLD.Gameplay.AssetReferenceNutrientDefinition("13a8bda1e12982e428b7551cc01b01df");


			//Fiddling with stuff
			gear = GearItem.LoadGearItemPrefab("GEAR_RosehipsPrepared").gameObject;

			if (Settings.instance.EatHips == true) //Rosehips
			{
				if (Settings.instance.RH_Food == true)
				{
					gear.GetComponent<GearItem>().GearItemData.m_Type = GearType.Food;
				}
				else
				{
					gear.GetComponent<GearItem>().GearItemData.m_Type = GearType.FirstAid;
				}
				gear.AddComponent<FoodItem>();

				gear.GetComponent<FoodItem>().m_IsNatural = true;
				gear.GetComponent<FoodItem>().m_HarvestedByPlayer = true;
				gear.GetComponent<FoodItem>().m_TimeToEatSeconds = 2.25f;
				gear.GetComponent<FoodItem>().m_CaloriesTotal = Settings.instance.RoseHipCalorie;
				gear.GetComponent<FoodItem>().m_CaloriesRemaining = Settings.instance.RoseHipCalorie;
				gear.GetComponent<FoodItem>().m_EatingAudio = "Play_EatingCattail";
				gear.GetComponent<FoodItem>().m_ChanceFoodPoisoningLowCondition = 40f;
				gear.GetComponent<FoodItem>().m_ChanceFoodPoisoningRuined = 100f;
				gear.GetComponent<FoodItem>().m_Nutrients = new Il2CppSystem.Collections.Generic.List<FoodItem.Nutrient>();
				vitc.m_Amount = Settings.instance.RoseHipVC;
				gear.GetComponent<FoodItem>().m_Nutrients.Add(vitc);

			}
			else
			{
				GameManager.DestroyImmediate(gear.GetComponent<FoodItem>());
				gear.GetComponent<GearItem>().GearItemData.m_Type = GearType.FirstAid;
			}

			gear = GearItem.LoadGearItemPrefab("GEAR_ReishiPrepared").gameObject;

			if (Settings.instance.EatReishi == true) //Reishi
			{

				if (Settings.instance.R_Food == true)
				{
					gear.GetComponent<GearItem>().GearItemData.m_Type = GearType.Food;
				}
				else
				{
					gear.GetComponent<GearItem>().GearItemData.m_Type = GearType.FirstAid;
				}


				gear.AddComponent<FoodItem>();
				gear.GetComponent<FoodItem>().m_IsNatural = true;
				gear.GetComponent<FoodItem>().m_HarvestedByPlayer = true;
				gear.GetComponent<FoodItem>().m_TimeToEatSeconds = 2.5f;
				gear.GetComponent<FoodItem>().m_CaloriesTotal = Settings.instance.ReishiCalorie;
				gear.GetComponent<FoodItem>().m_CaloriesRemaining = Settings.instance.ReishiCalorie;
				gear.GetComponent<FoodItem>().m_EatingAudio = "Play_EatingCattail";
				gear.GetComponent<FoodItem>().m_ChanceFoodPoisoningLowCondition = 60f;
				gear.GetComponent<FoodItem>().m_ChanceFoodPoisoningRuined = 100f;
				gear.GetComponent<FoodItem>().m_Nutrients = new Il2CppSystem.Collections.Generic.List<FoodItem.Nutrient>();
				vitc.m_Amount = Settings.instance.ReishiVC;
				gear.GetComponent<FoodItem>().m_Nutrients.Add(vitc);
				// MelonLogger.Msg("Reishi eating enabled.");
			}
			else
			{
				GameManager.DestroyImmediate(gear.GetComponent<FoodItem>());
				gear.GetComponent<GearItem>().GearItemData.m_Type = GearType.FirstAid;
			}

			gear = GearItem.LoadGearItemPrefab("GEAR_BirchbarkPrepared").gameObject;

			if (Settings.instance.EatBark == true) //Bark
			{
				if (Settings.instance.BB_Food == true)
				{
					gear.GetComponent<GearItem>().GearItemData.m_Type = GearType.Food;
				}
				else
				{
					gear.GetComponent<GearItem>().GearItemData.m_Type = GearType.FirstAid;
				}

				gear.AddComponent<FoodItem>();
				gear.GetComponent<FoodItem>().m_IsNatural = true;
				gear.GetComponent<FoodItem>().m_HarvestedByPlayer = true;
				gear.GetComponent<FoodItem>().m_TimeToEatSeconds = 3.25f;
				gear.GetComponent<FoodItem>().m_CaloriesTotal = Settings.instance.BarkCalorie;
				gear.GetComponent<FoodItem>().m_CaloriesRemaining = Settings.instance.BarkCalorie;
				gear.GetComponent<FoodItem>().m_EatingAudio = "Play_EatingCrunchy";
				gear.GetComponent<FoodItem>().m_ChanceFoodPoisoningLowCondition = 25f;
				gear.GetComponent<FoodItem>().m_ChanceFoodPoisoningRuined = 75f;
				gear.GetComponent<FoodItem>().m_Nutrients = new Il2CppSystem.Collections.Generic.List<FoodItem.Nutrient>();
				vitc.m_Amount = Settings.instance.BarkVC;
				gear.GetComponent<FoodItem>().m_Nutrients.Add(vitc);
				//MelonLogger.Msg("Bark eating enabled.");
			}
			else
			{
				GameManager.DestroyImmediate(gear.GetComponent<FoodItem>());
				gear.GetComponent<GearItem>().GearItemData.m_Type = GearType.FirstAid;
			}

			gear = GearItem.LoadGearItemPrefab("GEAR_OldMansBeardHarvested").gameObject;

			if (Settings.instance.EatLichen == true) //Lichen
			{
				if (Settings.instance.BL_Food == true)
				{
					gear.GetComponent<GearItem>().GearItemData.m_Type = GearType.Food;
				}
				else
				{
					gear.GetComponent<GearItem>().GearItemData.m_Type = GearType.Material;
				}

				gear.AddComponent<FoodItem>();
				gear.GetComponent<FoodItem>().m_IsNatural = true;
				gear.GetComponent<FoodItem>().m_HarvestedByPlayer = true;
				gear.GetComponent<FoodItem>().m_TimeToEatSeconds = 2.15f;
				gear.GetComponent<FoodItem>().m_CaloriesTotal = Settings.instance.LichenCalorie;
				gear.GetComponent<FoodItem>().m_CaloriesRemaining = Settings.instance.LichenCalorie;
				gear.GetComponent<FoodItem>().m_EatingAudio = "Play_EatingCattail";
				gear.GetComponent<FoodItem>().m_ChanceFoodPoisoningLowCondition = 25f;
				gear.GetComponent<FoodItem>().m_ChanceFoodPoisoningRuined = 75f;


				//MelonLogger.Msg("Lichen eating enabled.");
			}
			else
			{
				GameManager.DestroyImmediate(gear.GetComponent<FoodItem>());
				gear.GetComponent<GearItem>().GearItemData.m_Type = GearType.Material;
			}

            gear = GearItem.LoadGearItemPrefab("GEAR_BurdockPrepared").gameObject;

            if (Settings.instance.EatBurdock == true) //Burdock
            {
                if (Settings.instance.BD_Food == true)
                {
                    gear.GetComponent<GearItem>().GearItemData.m_Type = GearType.Food;
                }
                else
                {
                    gear.GetComponent<GearItem>().GearItemData.m_Type = GearType.Material;
                }

                gear.AddComponent<FoodItem>();
                gear.GetComponent<FoodItem>().m_IsNatural = true;
                gear.GetComponent<FoodItem>().m_HarvestedByPlayer = true;
                gear.GetComponent<FoodItem>().m_TimeToEatSeconds = 2.15f;
                gear.GetComponent<FoodItem>().m_CaloriesTotal = Settings.instance.BurdockCalorie;
				gear.GetComponent<FoodItem>().m_CaloriesRemaining = Settings.instance.BurdockCalorie;
                gear.GetComponent<FoodItem>().m_Nutrients = new Il2CppSystem.Collections.Generic.List<FoodItem.Nutrient>();
                vitc.m_Amount = Settings.instance.BurdockVC;
				gear.GetComponent<FoodItem>().m_Nutrients.Add(vitc);
                gear.GetComponent<FoodItem>().m_EatingAudio = "Play_EatingBurdock";
                gear.GetComponent<FoodItem>().m_ChanceFoodPoisoningLowCondition = 25f;
                gear.GetComponent<FoodItem>().m_ChanceFoodPoisoningRuined = 75f;


                //MelonLogger.Msg("Burdock eating enabled.");
            }
			else
            {
                GameManager.DestroyImmediate(gear.GetComponent<FoodItem>());
                gear.GetComponent<GearItem>().GearItemData.m_Type = GearType.FirstAid;
            }


        }
	}
}
