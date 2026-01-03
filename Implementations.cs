using EdiblePlantsMod;
using Il2Cpp;
using Il2CppNodeCanvas.Tasks.Actions;
using Il2CppRewired.Utils;
using Il2CppTLD.BigCarry;
using Il2CppTLD.Gear;
using System.Runtime.InteropServices;
using Il2CppVLB;


namespace EdiblePlantsMod
{
	public class Implementations : MelonMod
	{
		public override void OnInitializeMelon()
		{
			Settings.instance.AddToModSettings("Edible Plants");
			Settings.OnLoad();
		}

	}
}