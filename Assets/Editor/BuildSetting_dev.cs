using UnityEditor;

public class BuildSetting_dev
{
    public static void PerformBuild()
    {
        BuildPipeline.BuildPlayer(new BuildPlayerOptions
        {
            scenes = new[] {"Assets/Scenes/scene.unity"},
            locationPathName = "Builds/YourBuildName.apk",
            target = BuildTarget.Android,
            options = BuildOptions.None
        });
    }
}
