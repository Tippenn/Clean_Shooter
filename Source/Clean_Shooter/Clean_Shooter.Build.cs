// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Clean_Shooter : ModuleRules
{
	public Clean_Shooter(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Clean_Shooter",
			"Clean_Shooter/Variant_Platforming",
			"Clean_Shooter/Variant_Platforming/Animation",
			"Clean_Shooter/Variant_Combat",
			"Clean_Shooter/Variant_Combat/AI",
			"Clean_Shooter/Variant_Combat/Animation",
			"Clean_Shooter/Variant_Combat/Gameplay",
			"Clean_Shooter/Variant_Combat/Interfaces",
			"Clean_Shooter/Variant_Combat/UI",
			"Clean_Shooter/Variant_SideScrolling",
			"Clean_Shooter/Variant_SideScrolling/AI",
			"Clean_Shooter/Variant_SideScrolling/Gameplay",
			"Clean_Shooter/Variant_SideScrolling/Interfaces",
			"Clean_Shooter/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
