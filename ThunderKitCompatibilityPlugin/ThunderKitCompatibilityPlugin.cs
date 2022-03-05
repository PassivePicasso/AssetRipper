using AssetRipper.Library;
using AssetRipper.Library.Configuration;

namespace ThunderKitCompatibilityPlugin
{
	public class ThunderKitCompatibilityPlugin : PluginBase
	{
		public override string Name => "ThunderKitCompatibilityPlugin";

		public override void Initialize()
		{
			CurrentRipper.Settings.ScriptExportMode = ScriptExportMode.TotalDllExport;
			CurrentRipper.OnFinishExporting += CurrentRipper_OnFinishExporting;
		}

		
		private void CurrentRipper_OnFinishExporting()
		{
			var assemblies = CurrentRipper.GameStructure.FileCollection.AssemblyManager.GetAssemblies();
			foreach (var assembly in assemblies)
			{
				var name = assembly.Name;
				var fullName = assembly.FullName;
			}
		}
	}
}