using UnrealBuildTool;

public class tyrosangreEditorTarget : TargetRules
{
	public tyrosangreEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("tyrosangre");
	}
}
