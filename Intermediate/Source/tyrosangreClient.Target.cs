using UnrealBuildTool;

public class tyrosangreClientTarget : TargetRules
{
	public tyrosangreClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("tyrosangre");
	}
}
