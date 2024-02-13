using ModSettings;

namespace EdiblePlantsMod
{
    internal class Settings : JsonModSettings
    {
        internal static Settings instance = new Settings();

        [Section("Edible Plants Settings")]

        [Name("Edible Rose Hips")]
        [Description("Enables you to eat Prepared Rose Hips for some calories. (Requires scene reload, disabling requires game restart.)")]
        public bool EatHips = true;

        [Name("Edible Reishi")]
        [Description("Enables you to eat Prepared Reishi for some calories. (Requires scene reload, disabling requires game restart.)")]
        public bool EatReishi = true;

        [Name("Edible Birch Bark")]
        [Description("Enables you to eat Prepared Birch Bark for some calories. (Requires scene reload, disabling requires game restart.)")]
        public bool EatBark = false;

    }
}
