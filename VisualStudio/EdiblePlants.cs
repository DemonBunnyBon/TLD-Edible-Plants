using EdiblePlantsMod;


namespace EdiblePlantsMod
{
	public class EdiblePlants : MelonMod
	{
		public override void OnInitializeMelon()
		{
			MelonLogger.Msg("Gonna munch on some rose hips...");
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
				//FoodItem.Nutrient vitamin = new FoodItem.Nutrient();
				//vitamin.m_Amount = 10;
				//vitamin.m_Nutrient = new Il2CppTLD.Gameplay.AssetReferenceNutrientDefinition("13a8bda1e12982e428b7551cc01b01df");

                //Fiddling with stuff
                gear = GearItem.LoadGearItemPrefab("GEAR_RosehipsPrepared").gameObject;

			if (Settings.instance.EatHips == true) //Rosehips
			{
				gear.AddComponent<FoodItem>();
				gear.GetComponent<FoodItem>().m_IsNatural = true;
				gear.GetComponent<FoodItem>().m_HarvestedByPlayer = true;
				gear.GetComponent<FoodItem>().m_TimeToEatSeconds = 2f;
				gear.GetComponent<FoodItem>().m_CaloriesTotal = 165f;
				gear.GetComponent<FoodItem>().m_CaloriesRemaining = 165f;
				gear.GetComponent<FoodItem>().m_EatingAudio = "Play_EatingCattail";
				gear.GetComponent<FoodItem>().m_ChanceFoodPoisoningLowCondition = 40f;
				gear.GetComponent<FoodItem>().m_ChanceFoodPoisoningRuined = 100f;
				//vitamin.m_Amount = 15;
				//gear.GetComponent<FoodItem>().m_Nutrients.Add(vitamin);
                MelonLogger.Msg("Rose hip eating enabled.");
            }
			else
			{
                MelonLogger.Msg("Rose hip eating disabled.");
            }

			gear = GearItem.LoadGearItemPrefab("GEAR_ReishiPrepared").gameObject;

			if (Settings.instance.EatReishi == true) //Reishi
			{
				gear.AddComponent<FoodItem>();
				gear.GetComponent<FoodItem>().m_IsNatural = true;
				gear.GetComponent<FoodItem>().m_HarvestedByPlayer = true;
				gear.GetComponent<FoodItem>().m_TimeToEatSeconds = 2f;
				gear.GetComponent<FoodItem>().m_CaloriesTotal = 200f;
				gear.GetComponent<FoodItem>().m_CaloriesRemaining = 200f;
				gear.GetComponent<FoodItem>().m_EatingAudio = "Play_EatingCattail";
				gear.GetComponent<FoodItem>().m_ChanceFoodPoisoningLowCondition = 60f;
				gear.GetComponent<FoodItem>().m_ChanceFoodPoisoningRuined = 100f;
				//vitamin.m_Amount = 7;
				//gear.GetComponent<FoodItem>().m_Nutrients.Add(vitamin);
                MelonLogger.Msg("Reishi eating enabled.");
            }
			else
			{
                MelonLogger.Msg("Reishi eating disabled.");
            }

			gear = GearItem.LoadGearItemPrefab("GEAR_BirchbarkPrepared").gameObject;

			if (Settings.instance.EatBark == true) //Bark
			{
				gear.AddComponent<FoodItem>();
				gear.GetComponent<FoodItem>().m_IsNatural = true;
				gear.GetComponent<FoodItem>().m_HarvestedByPlayer = true;
				gear.GetComponent<FoodItem>().m_TimeToEatSeconds = 3f;
				gear.GetComponent<FoodItem>().m_CaloriesTotal = 135f;
				gear.GetComponent<FoodItem>().m_CaloriesRemaining = 135f;
				gear.GetComponent<FoodItem>().m_EatingAudio = "Play_EatingCrunchy";
				gear.GetComponent<FoodItem>().m_ChanceFoodPoisoningLowCondition = 25f;
				gear.GetComponent<FoodItem>().m_ChanceFoodPoisoningRuined = 75f;
				//vitamin.m_Amount = 9;
				//gear.GetComponent<FoodItem>().m_Nutrients.Add(vitamin);
                MelonLogger.Msg("Bark eating enabled.");
            }
			else
			{
                MelonLogger.Msg("Bark eating disabled.");
            }






		}
	}
}