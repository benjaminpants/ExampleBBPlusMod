using System;
using BepInEx;
using HarmonyLib;

namespace ExampleMod
{


	[BepInPlugin("mtm101.rulerp.baldiplus.testmod","Test Baldi Plus Mod","1.0.0.0")]
	public class BasePlugin : BaseUnityPlugin
	{
		void Awake()
		{
			Harmony harmony = new Harmony("mtm101.rulerp.baldiplus.testmod");
			harmony.PatchAll();
		}
	}
}
