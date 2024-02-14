using ModSettings;

namespace EdiblePlantsMod
{
    internal class Settings : JsonModSettings
    {
        internal static Settings instance = new Settings();

        [Section("Rose Hips Settings")]

        [Name("Edible Rose Hips")]
        [Description("Enables you to eat Prepared Rose Hips for some calories and Vitamin C. (Requires scene reload, disabling requires game restart.)")]
        public bool EatHips = true;

        [Name("Rose Hip Calories")]
        [Description("Controls how many total calories Prepared Rose Hips have. (Requies scene reload)")]
        [Slider(10f, 250f, 25)]
        public float RoseHipCalorie = 170f;

        [Name("Rose Hip Vitamin C")]
        [Description("Controls how much Vitamin C Prepared Rose Hips have. (Requies scene reload)")]
        [Slider(0, 20, 1)]
        public int RoseHipVC = 15;


        [Section("Reishi Settings")]

        [Name("Edible Reishi")]
        [Description("Enables you to eat Prepared Reishi for some calories and Vitamin C. (Requires scene reload, disabling requires game restart.)")]
        public bool EatReishi = true;

        [Name("Reishi Calories")]
        [Description("Controls how many total calories prepared Reishi has. (Requies scene reload)")]
        [Slider(10f, 250f, 25)]
        public float ReishiCalorie = 200f;

        [Name("Reishi Vitamin C")]
        [Description("Controls how much Vitamin C Prepared Reishi has. (Requies scene reload)")]
        [Slider(0, 20, 1)]
        public int ReishiVC = 7;



        [Section("Beard Lichen Settings")]

        [Name("Edible Beard Lichen")]
        [Description("Enables you to eat Beard Lichen for some calories. (Requires scene reload, disabling requires game restart.)")]
        public bool EatLichen = true;

        [Name("Beard Lichen Calories")]
        [Description("Controls how many total calories Beard Lichen has. (Requies scene reload)")]
        [Slider(10f, 100f, 10)]
        public float LichenCalorie = 70f;



        [Section("Birch Bark Settings")]

        [Name("Edible Birch Bark")]
        [Description("Enables you to eat Prepared Birch Bark for some calories and Vitamin C. (Requires scene reload, disabling requires game restart.)")]
        public bool EatBark = false;

        [Name("Birch Bark Calories")]
        [Description("Controls how many total calories prepared Birch Bark has. (Requies scene reload)")]
        [Slider(10f, 250f, 25)]
        public float BarkCalorie = 130f;

        [Name("Birch Bark Vitamin C")]
        [Description("Controls how much Vitamin C Prepared Birch Bark has. (Requies scene reload)")]
        [Slider(0, 20, 1)]
        public int BarkVC = 5;

    }
}
