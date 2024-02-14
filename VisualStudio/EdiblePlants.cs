using EdiblePlantsMod;
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

		public override void OnUpdate()
		{

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

				//MelonLogger.Msg("Rose hip eating enabled.");
            }
			else
			{
                //MelonLogger.Msg("Rose hip eating disabled.");
            }

			gear = GearItem.LoadGearItemPrefab("GEAR_ReishiPrepared").gameObject;

			if (Settings.instance.EatReishi == true) //Reishi
			{
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
                //MelonLogger.Msg("Reishi eating disabled.");
            }

			gear = GearItem.LoadGearItemPrefab("GEAR_BirchbarkPrepared").gameObject;

			if (Settings.instance.EatBark == true) //Bark
			{

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
				//MelonLogger.Msg("Bark eating disabled.");
			}

			gear = GearItem.LoadGearItemPrefab("GEAR_OldMansBeardHarvested").gameObject;

			if (Settings.instance.EatLichen == true) //Bark
			{

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
				//MelonLogger.Msg("Lichen eating disabled.")
			}






		}
	}
}