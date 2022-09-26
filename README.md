# assisstive-memory-MR

After you clone and before you open the Unity project, you will need to restore MRTK3 and Vuforia packages:

1) Download the latest Mixed Reality Feature Tool https://learn.microsoft.com/en-us/windows/mixed-reality/develop/unity/welcome-to-mr-feature-tool
2) Open it and you will see the Mixed Reality Feautre Tool for Unity starting page; click Start
3) In Project Path, locate the Unity project then click Restore Features
4) After a moment, you may close the Microsoft Mixed Reality Feature Tool
5) Download Vuforia Engine 10.10 for Unity (this requires a Vuforia developer account) https://developer.vuforia.com/downloads/sdk
6) Open the Unity project using Unity version 2021.3.5f1
7) If the project opened in Safe Mode, you may Exit Safe Mode
8) Go to Assets -> Import Package -> Custom Package... and locate the Vuforia *.unitypacakge that you downloaded
9) Go to Window -> Package Manager and click the + icon
10) Select Add package from tarball...
11) Navigate to \AssistiveMemoryMR.Unity\Assets\Editor\Migration and select com.ptc.vuforia.engine-10.10.2.tgz
12) Unity will resolve packages for several minutes
13) Open the Unity scene named "Memory" inside \AssistiveMemoryMR.Unity\Assets\Scenes
14) You may build this scene to your HoloLens 2

NOTE: You may need to setup your Vuforia configuration to include an App License Key. Go to Window -> Vuforia Configuration to make any changes based on the Vuforia developer account you are using.
