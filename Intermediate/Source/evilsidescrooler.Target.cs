using UnrealBuildTool;

public class evilsidescroolerTarget : TargetRules
{
	public evilsidescroolerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("evilsidescrooler");
	}
}
