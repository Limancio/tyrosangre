using UnrealBuildTool;

public class tyrosangreServerTarget : TargetRules
{
	public tyrosangreServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("tyrosangre");
	}
}
