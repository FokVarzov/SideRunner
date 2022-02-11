// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SideRunner : ModuleRules
{
	public SideRunner(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });

		if (Target.Platform == UnrealTargetPlatform.Android)
		{
			PublicAdditionalLibraries.AddRange(new string[] { System.IO.Path.Combine(ModuleDirectory, "ThirdParty", "pugi", "pugixml.lib") });
		}
		else if (Target.Platform == UnrealTargetPlatform.IOS)
		{
			PublicAdditionalLibraries.AddRange(new string[] { System.IO.Path.Combine(ModuleDirectory, "ThirdParty", "pugi", "libpugixml.a") });
		}
	}
}
