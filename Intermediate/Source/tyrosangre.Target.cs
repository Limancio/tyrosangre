using UnrealBuildTool;

public class tyrosangreTarget : TargetRules
{
	public tyrosangreTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("tyrosangre");
	}
}
