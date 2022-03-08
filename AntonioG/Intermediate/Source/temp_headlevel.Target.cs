using UnrealBuildTool;

public class temp_headlevelTarget : TargetRules
{
	public temp_headlevelTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("temp_headlevel");
	}
}
