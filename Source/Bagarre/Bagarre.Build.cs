// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Bagarre : ModuleRules
{
	public Bagarre(ReadOnlyTargetRules Target) : base(Target)
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
			"Bagarre",
			"Bagarre/Variant_Platforming",
			"Bagarre/Variant_Platforming/Animation",
			"Bagarre/Variant_Combat",
			"Bagarre/Variant_Combat/AI",
			"Bagarre/Variant_Combat/Animation",
			"Bagarre/Variant_Combat/Gameplay",
			"Bagarre/Variant_Combat/Interfaces",
			"Bagarre/Variant_Combat/UI",
			"Bagarre/Variant_SideScrolling",
			"Bagarre/Variant_SideScrolling/AI",
			"Bagarre/Variant_SideScrolling/Gameplay",
			"Bagarre/Variant_SideScrolling/Interfaces",
			"Bagarre/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
