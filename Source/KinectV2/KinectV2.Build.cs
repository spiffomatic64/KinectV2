//------------------------------------------------------------------------------
// 
//     The Kinect for Windows APIs used here are preliminary and subject to change
// 
//------------------------------------------------------------------------------
using System.IO;

namespace UnrealBuildTool.Rules
{
    using System.IO;

    public class KinectV2 : ModuleRules
    {
        //public KinectV2(TargetInfo Target)
        public KinectV2(ReadOnlyTargetRules Target) : base(Target)
        {
           
            PublicIncludePaths.AddRange(
                new string[] {
                    "KinectV2/Public"
					// ... add public include paths required here ...
				}
                );

            PrivateIncludePaths.AddRange(
                new string[] {
					"KinectV2/Private",
                  
					// ... add other private include paths required here ...
				}
                );

            PublicDependencyModuleNames.AddRange(
                new string[]
				{
                   	
                    "CoreUObject",				
                    "Core",
                    "Engine",
                    "InputDevice",
                    //"MSSpeech",
                    "InputCore",
                    "K4WLib",
                    //"AnimGraphRuntime", "UnrealEd", "KismetWidgets", "KismetCompiler", "BlueprintGraph", "GraphEditor", "Kismet"
                    // "Slate"
					// ... add other public dependencies that you statically link with here ...
                    //"Core", "CoreUObject", "InputCore", "Slate", "Engine", "AssetTools", "UnrealEd", // for FAssetEditorManager "KismetWidgets", "KismetCompiler", "BlueprintGraph", "GraphEditor", "Kismet", // for FWorkflowCentricApplication "PropertyEditor", "EditorStyle", "Slate", "SlateCore", "Sequencer", "DetailCustomizations", "Settings", "RenderCore",
				}
                );

            PrivateDependencyModuleNames.AddRange(
                new string[]
				{ 
                    "CoreUObject",
					"Core",
                    "Engine",
                    "InputDevice",
					// ... add private dependencies that you statically link with here ...
				}
                );





            //AddThirdPartyPrivateStaticDependencies(Target, "K4WLib");
			AddEngineThirdPartyPrivateStaticDependencies(Target, new string[]{"K4WLib"});
        }
    }
}