using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

internal class OneClickPatch
{
    public static void PatchApply()
    {
        string[] sDllPath =
        {
            @"\game\dota\bin\win32\client.dll", 
            @"\game\dota\bin\win64\client.dll"
        };

        string[] sEngine2DllPath =
        {
            @"\game\bin\win32\engine2.dll", @"\game\bin\win64\engine2.dll"
        };

        string[] sPanoramaDllPath =
        {
            @"\game\bin\win32\panorama.dll", @"\game\bin\win64\panorama.dll"
        };

        try
        {
            if (Environment.GetCommandLineArgs()[7] == "1")
                Patch.CreateBackup(Environment.GetCommandLineArgs()[1] + sDllPath[int.Parse(Environment.GetCommandLineArgs()[2])]);

            var sClientDllFile = File.ReadAllText(Environment.GetCommandLineArgs()[1] + sDllPath[int.Parse(Environment.GetCommandLineArgs()[2])], Encoding.Default);

            if (Environment.GetCommandLineArgs()[3] == "1")
                Patch.ChangeCameraDistance(ref sClientDllFile, Patch.FindCameraDistance(ref sClientDllFile), Environment.GetCommandLineArgs()[4]);

            if (Environment.GetCommandLineArgs()[5] == "1" | Environment.GetCommandLineArgs()[6] == "1")
            {
                if (Environment.GetCommandLineArgs()[7] == "1")
                {
                Patch.CreateBackup(Environment.GetCommandLineArgs()[1] + sEngine2DllPath[int.Parse(Environment.GetCommandLineArgs()[2])]);
                Patch.CreateBackup(Environment.GetCommandLineArgs()[1] + sPanoramaDllPath[int.Parse(Environment.GetCommandLineArgs()[2])]);
                }

                var sEngine2DllFile = File.ReadAllText(Environment.GetCommandLineArgs()[1] + sEngine2DllPath[int.Parse(Environment.GetCommandLineArgs()[2])], Encoding.Default);
                var sPanoramaDllFile = File.ReadAllText(Environment.GetCommandLineArgs()[1] + sPanoramaDllPath[int.Parse(Environment.GetCommandLineArgs()[2])], Encoding.Default);
                
                if (Environment.GetCommandLineArgs()[5] == "1")
                Patch.UnlockAddons(ref sEngine2DllFile, ref sClientDllFile, ref sPanoramaDllFile, 1 ^ int.Parse(Environment.GetCommandLineArgs()[2]));

                //if (Environment.GetCommandLineArgs()[6] == "1")
                  //  Patch.UnlockSvCheats(ref sEngine2DllFile, 1 ^ int.Parse(Environment.GetCommandLineArgs()[2]));

                File.WriteAllText(Environment.GetCommandLineArgs()[1] + sEngine2DllPath[int.Parse(Environment.GetCommandLineArgs()[2])], sEngine2DllFile, Encoding.Default);
                File.WriteAllText(Environment.GetCommandLineArgs()[1] + sPanoramaDllPath[int.Parse(Environment.GetCommandLineArgs()[2])], sPanoramaDllFile, Encoding.Default);
            }

            File.WriteAllText(Environment.GetCommandLineArgs()[1] + sDllPath[int.Parse(Environment.GetCommandLineArgs()[2])], sClientDllFile, Encoding.Default);
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}