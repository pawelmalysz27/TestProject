using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Diagnostics;

public class BuildWindows
{
    public static void Build()
    {
        string[] scenes = { "Assets/Scenes/SampleScene.unity" };

        BuildPipeline.BuildPlayer(scenes, "C:\\Users\\pawel\\Builds\\TestProject.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
        ProcessStartInfo start = new ProcessStartInfo("cmd.exe", "/c pause");
        Process.Start(start);
    }
}
