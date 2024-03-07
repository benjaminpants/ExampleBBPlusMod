using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using HarmonyLib;

namespace ExampleMod
{
	[HarmonyPatch(typeof(Baldi))]
	[HarmonyPatch("CaughtPlayer")]
	class BaldiNoKillPatch
	{
		static bool Prefix()
		{
			return false;
		}
	}
}
