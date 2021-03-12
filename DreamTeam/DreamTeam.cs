using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;
using Reactor;
using XenoCore;
using XenoCore.Utils;

namespace DreamTeam {
	[BepInPlugin(Id)]
	[BepInProcess(Globals.PROCESS)]
	[BepInDependency(ReactorPlugin.Id)]
	[BepInDependency(XenoPlugin.Id)]
	// ReSharper disable once ClassNeverInstantiated.Global
	public class DreamTeam : BasePlugin {
		public const string Id = "com.mishin870.dreamteam";
		public static readonly string Version = "1.0.0";

		public Harmony Harmony { get; } = new Harmony(Id);

		public override void Load() {
			Harmony.PatchAll();
			
			VersionsList.Add("DreamTeam", Version, true);

			ServerUtils.AddRegion("LocalHost", "127.0.0.1");
			ServerUtils.AddRegion("InternalDreams", "13.69.244.214");
			ServerUtils.AddRegion("AmongDreams", "40.114.236.130");
			
			ServerUtils.AddLocalServer("LocalHost", "127.0.0.1");
			ServerUtils.AddLocalServer("Михаил", "26.35.19.189");
			ServerUtils.AddLocalServer("медичка", "26.71.226.160");
			ServerUtils.AddLocalServer("Gera", "26.37.40.219");
			ServerUtils.AddLocalServer("Белка", "26.91.123.129");
			ServerUtils.AddLocalServer("Гроза", "26.91.137.125");
			ServerUtils.AddLocalServer("Moon359", "26.102.69.175");
			ServerUtils.AddLocalServer("ALFox", "26.71.226.220");
		}
	}
}