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
        [Slider(10, 250, 240)]
        public int RoseHipCalorie = 170;

        [Name("Rose Hip Vitamin C")]
        [Description("Controls how much Vitamin C Prepared Rose Hips have. [Requies scene reload.]")]
        [Slider(0, 20, 21)]
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
        [Slider(10, 250, 240)]
        public int ReishiCalorie = 200;

        [Name("Reishi Vitamin C")]
        [Description("Controls how much Vitamin C Prepared Reishi has. [Requies scene reload.]")]
        [Slider(0, 20, 21)]
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
        [Slider(10, 100, 90)]
        public int LichenCalorie = 70;

        [Name("Move To Food Category")]
        [Description("Moves Beard Lichen to Food category. [Requies scene reload.]")]
        public bool BL_Food = false;



        [Section("Birch Bark Settings")]

        [Name("Edible Birch Bark")]
        [Description("Enables you to eat Prepared Birch Bark for some calories and Vitamin C. [Requies scene reload.]")]
        public bool EatBark = false;

        [Name("Birch Bark Calories")]
        [Description("Controls how many total calories prepared Birch Bark has. [Requies scene reload.]")]
        [Slider(10, 250, 240)]
        public int BarkCalorie = 130;

        [Name("Birch Bark Vitamin C")]
        [Description("Controls how much Vitamin C Prepared Birch Bark has. [Requies scene reload.]")]
        [Slider(0, 20, 21)]
        public int BarkVC = 5;

        [Name("Move To Food Category")]
        [Description("Moves Prepared Birch Bark to Food category. [Requies scene reload.]")]
        public bool BB_Food = false;


        [Section("Burdock Settings")]

        [Name("Edible Burdock")]
        [Description("Enabled = game default. [Requies scene reload.]")]
        public bool EatBurdock = true;

        [Name("Burdock Calories")]
        [Description("Controls how many total calories Prepared Burdock has. [Requies scene reload.]")]
        [Slider(10, 300, 290)]
        public int BurdockCalorie = 275;

        [Name("Burdock Vitamin C")]
        [Description("Controls how much Vitamin C Prepared Burdock has. [Requies scene reload.]")]
        [Slider(0, 20, 21)]
        public int BurdockVC = 8;

        [Name("Move To Food Category")]
        [Description("Moves Prepared Burdock to Food category. [Requies scene reload.]")]
        public bool BD_Food = false;

        [Section("Reset Settings")]
        [Name("Reset To Default")]
        [Description("Resets all settings to Default. (Confirm required.)")]
        public bool ResetSettings = false;
        protected override void OnChange(FieldInfo field, object? oldValue, object? newValue) => RefreshFields();
        protected override void OnConfirm()
        {
            ApplyReset();
            instance.ResetSettings = false;
            base.OnConfirm();
        }
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
                SetFieldVisible(nameof(BB_Food), false);
            }
            if (EatBurdock == true)
            {
                SetFieldVisible(nameof(BurdockCalorie), true);
                SetFieldVisible(nameof(BurdockVC), true);
                SetFieldVisible(nameof(BD_Food), true);
            }
            else
            {
                SetFieldVisible(nameof(BurdockCalorie), false);
                SetFieldVisible(nameof(BurdockVC), false);
                SetFieldVisible(nameof(BD_Food), false);
            }
        }
        public static void ApplyReset()
        {
            if (instance.ResetSettings == true)
            {
                instance.EatHips = true;
                instance.RoseHipCalorie = 170;
                instance.RoseHipVC = 15;
                instance.RH_Food = false;
                instance.EatReishi = true;
                instance.ReishiCalorie = 200;
                instance.ReishiVC = 7;
                instance.R_Food = false;
                instance.EatLichen = true;
                instance.LichenCalorie = 70;
                instance.BL_Food = false;
                instance.EatBark = false;
                instance.BarkCalorie = 130;
                instance.BarkVC = 5;
                instance.BB_Food = false;
                instance.EatBurdock = true;
                instance.BurdockCalorie = 275;
                instance.BurdockVC = 8;
                instance.BD_Food = false;
                instance.ResetSettings = false;
                instance.RefreshFields();
                instance.RefreshGUI();
            }
        }
    }
}
