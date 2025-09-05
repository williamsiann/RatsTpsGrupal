// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TPGrupalProg : ModuleRules
{
	public TPGrupalProg(ReadOnlyTargetRules Target) : base(Target)
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
			"TPGrupalProg",
			"TPGrupalProg/Variant_Platforming",
			"TPGrupalProg/Variant_Platforming/Animation",
			"TPGrupalProg/Variant_Combat",
			"TPGrupalProg/Variant_Combat/AI",
			"TPGrupalProg/Variant_Combat/Animation",
			"TPGrupalProg/Variant_Combat/Gameplay",
			"TPGrupalProg/Variant_Combat/Interfaces",
			"TPGrupalProg/Variant_Combat/UI",
			"TPGrupalProg/Variant_SideScrolling",
			"TPGrupalProg/Variant_SideScrolling/AI",
			"TPGrupalProg/Variant_SideScrolling/Gameplay",
			"TPGrupalProg/Variant_SideScrolling/Interfaces",
			"TPGrupalProg/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
