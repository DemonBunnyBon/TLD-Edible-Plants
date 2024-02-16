using ModSettings;

namespace EdiblePlantsMod
{
    internal class Settings : JsonModSettings
    {
        internal static Settings instance = new Settings();

        [Section("Rose Hips Settings")]

        [Name("Edible Rose Hips")]
        [Description("Enables you to eat Prepared Rose Hips for some calories and Vitamin C. [Requies scene reload.]")]
        public bool EatHips = true;

        [Name("Rose Hip Calories")]
        [Description("Controls how many total calories Prepared Rose Hips have. [Requies scene reload.]")]
        [Slider(10f, 250f, 25)]
        public float RoseHipCalorie = 170f;

        [Name("Rose Hip Vitamin C")]
        [Description("Controls how much Vitamin C Prepared Rose Hips have. [Requies scene reload.]")]
        [Slider(0, 20, 1)]
        public int RoseHipVC = 15;

        [Name("Move To Food Category")]
        [Description("Moves Prepared Rose Hips to Food category. [Requies scene reload.]")]
        public bool RH_Food = false;

        [Section("Reishi Settings")]

        [Name("Edible Reishi")]
        [Description("Enables you to eat Prepared Reishi for some calories and Vitamin C. [Requies scene reload.]")]
        public bool EatReishi = true;

        [Name("Reishi Calories")]
        [Description("Controls how many total calories prepared Reishi has. [Requies scene reload.]")]
        [Slider(10f, 250f, 25)]
        public float ReishiCalorie = 200f;

        [Name("Reishi Vitamin C")]
        [Description("Controls how much Vitamin C Prepared Reishi has. [Requies scene reload.]")]
        [Slider(0, 20, 1)]
        public int ReishiVC = 7;

        [Name("Move To Food Category")]
        [Description("Moves Prepared Reishi to Food category. [Requies scene reload.]")]
        public bool R_Food = false;



        [Section("Beard Lichen Settings")]

        [Name("Edible Beard Lichen")]
        [Description("Enables you to eat Beard Lichen for some calories. [Requies scene reload.]")]
        public bool EatLichen = true;

        [Name("Beard Lichen Calories")]
        [Description("Controls how many total calories Beard Lichen has. [Requies scene reload.]")]
        [Slider(10f, 100f, 10)]
        public float LichenCalorie = 70f;

        [Name("Move To Food Category")]
        [Description("Moves Beard Lichen to Food category. [Requies scene reload.]")]
        public bool BL_Food = false;



        [Section("Birch Bark Settings")]

        [Name("Edible Birch Bark")]
        [Description("Enables you to eat Prepared Birch Bark for some calories and Vitamin C. [Requies scene reload.]")]
        public bool EatBark = false;

        [Name("Birch Bark Calories")]
        [Description("Controls how many total calories prepared Birch Bark has. [Requies scene reload.]")]
        [Slider(10f, 250f, 25)]
        public float BarkCalorie = 130f;

        [Name("Birch Bark Vitamin C")]
        [Description("Controls how much Vitamin C Prepared Birch Bark has. [Requies scene reload.]")]
        [Slider(0, 20, 1)]
        public int BarkVC = 5;

        [Name("Move To Food Category")]
        [Description("Moves Prepared Birch Bark to Food category. [Requies scene reload.]")]
        public bool BB_Food = false;

        protected override void OnChange(FieldInfo field, object? oldValue, object? newValue) => RefreshFields();
        internal static void OnLoad()
        {
            instance.RefreshFields();
        }
        internal void RefreshFields()
        {
            if (EatHips == true)
            {
                SetFieldVisible(nameof(RoseHipCalorie), true);
                SetFieldVisible(nameof(RoseHipVC), true);
                SetFieldVisible(nameof(RH_Food), true); 
            }
            else
            {
                SetFieldVisible(nameof(RoseHipCalorie), false);
                SetFieldVisible(nameof(RoseHipVC), false);
                SetFieldVisible(nameof(RH_Food), false);
            }

            if (EatLichen == true)
            {
                SetFieldVisible(nameof(LichenCalorie), true);
                SetFieldVisible(nameof(BL_Food), true);
            }
            else
            {
                SetFieldVisible(nameof(LichenCalorie), false);
                SetFieldVisible(nameof(BL_Food), false);
            }
            if (EatReishi == true)
            {
                SetFieldVisible(nameof(ReishiCalorie), true);
                SetFieldVisible(nameof(ReishiVC), true);
                SetFieldVisible(nameof(R_Food), true);
            }
            else
            {
                SetFieldVisible(nameof(ReishiCalorie), false);
                SetFieldVisible(nameof(ReishiVC), false);
                SetFieldVisible(nameof(R_Food), false);
            }
            if (EatBark == true)
            {
                SetFieldVisible(nameof(BarkCalorie), true);
                SetFieldVisible(nameof(BarkVC), true);
                SetFieldVisible(nameof(BB_Food), true);
            }
            else
            {
                SetFieldVisible(nameof(BarkCalorie), false);
                SetFieldVisible(nameof(BarkVC), false);
                SetFieldVisible(nameof(BB_Food), false) ;
            }
        }

    }
}
