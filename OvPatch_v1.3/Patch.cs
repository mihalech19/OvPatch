using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

internal class Patch
{
    public static bool AddOverrideVpk(string steamDir)
    {
        try
        {
            var launchOptions = new Regex("\"570\"\n*\\s*[{]([^{}]*)[}]");
            foreach (var dir in Directory.GetDirectories(steamDir + @"\userdata"))
            {
                var file = File.ReadAllText(dir + @"\config\localconfig.vdf", Encoding.Default);
                var lConfig = launchOptions.Match(file).Value;
                if (lConfig != String.Empty & lConfig.IndexOf("-addon JS") == -1)
                {
                    var iter = lConfig.IndexOf("LaunchOptions");
                    if (iter != -1)
                        lConfig = lConfig.Insert(lConfig.LastIndexOf("\"", lConfig.IndexOf("\n", iter)),
                            " -addon JS");
                    else
                        lConfig = lConfig.Insert(lConfig.IndexOf("{") + 1,
                            "\n\t\t\t\t\t\t\"LaunchOptions\" \t\"-addon JS\"");

                    file = file.Replace(launchOptions.Match(file).Value, lConfig);
                    File.WriteAllText(dir + @"\config\localconfig.vdf", file, Encoding.Default);
                }
            }

            return true;
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    public static Match FindCameraDistance(ref string sClientDll)
    {
        var findCamDistance = new Regex(@"[1][0-9][0-9][0-9]");
        var cameraDistance = findCamDistance.Match(sClientDll, sClientDll.IndexOf("dota_camera_dev_fake_team_spec"), 8000);
        return cameraDistance;
    }

    public static void ChangeCameraDistance(ref string sClientDll, Match cameraDistance, string newCameraDistance)
    {
        try
        {
            sClientDll = sClientDll.Remove(cameraDistance.Index, 4);
            sClientDll = sClientDll.Insert(cameraDistance.Index, newCameraDistance);
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    public static void UnlockAddons(ref string sEngine2Dll, ref string sClientDll, int iBitsOS)
    {
//--------------------------------------------engine2.dll x32-------------------------------------------------------------------------------
        byte[] sigEngine32Addons = new byte[] { 0xFF, 0xD2, 0x84, 0xC0, 0x74, 0x3B };
        byte[] sigEngine32AddonsCracked = new byte[] { 0xFF, 0xD2, 0x84, 0xC0, 0x90, 0x90 };
        byte[] sigEngine32Addons2 = new byte[] { 0xFF, 0x90, 0x84, 0x00, 0x00, 0x00, 0x8B, 0x0D, 0xD0, 0xB4, 0x42, 0x41 };
        byte[] sigEngine32AddonsCracked2 = new byte[] { 0xFF, 0x90, 0x84, 0x00, 0x00, 0x00, 0xEB, 0x1A, 0x90, 0x90, 0x90, 0x90 };
//--------------------------------------------client.dll x32-------------------------------------------------------------------------------
        byte[] sigClient32Addons = new byte[] { 0xFF, 0x90, 0xBC, 0x00, 0x00, 0x00, 0x85, 0xC0, 0x74, 0x25 };
        byte[] sigClient32AddonsCracked = new byte[] { 0xFF, 0x90, 0xBC, 0x00, 0x00, 0x00, 0x85, 0xC0, 0xEB, 0x25 };
//--------------------------------------------engine2.dll x64-------------------------------------------------------------------------------
        byte[] sigEngine64Addons = new byte[] { 0xFF, 0x92, 0xA0, 0x00, 0x00, 0x00, 0x84, 0xC0, 0x74, 0x5D };
        byte[] sigEngine64AddonsCracked = new byte[] { 0xFF, 0x92, 0xA0, 0x00, 0x00, 0x00, 0x84, 0xC0, 0x90, 0x90 };
        byte[] sigEngine64Addons2 = new byte[] { 0xFF, 0x90, 0x08, 0x01, 0x00, 0x00, 0x48, 0x8B, 0x0D, 0x56, 0x79, 0x3E, 0x00, };
        byte[] sigEngine64AddonsCracked2 = new byte[] { 0xFF, 0x90, 0x08, 0x01, 0x00, 0x00, 0xEB, 0x34, 0x90, 0x90, 0x90, 0x90, 0x90 };
//--------------------------------------------client.dll x64-------------------------------------------------------------------------------
        byte[] sigClient64Addons = new byte[] { 0xFF, 0x90, 0x78, 0x01, 0x00, 0x00, 0x48, 0x85, 0xC0, 0x74, 0x2F };
        byte[] sigClient64AddonsCracked = new byte[] { 0xFF, 0x90, 0x78, 0x01, 0x00, 0x00, 0x48, 0x85, 0xC0, 0xEB, 0x2F };
//-----------------------------------------------------------------------------------------------------------------------------------------
        
        switch(iBitsOS)
        {
            case 0:
                Patch.SigReplace(ref sEngine2Dll, sigEngine64Addons, sigEngine64AddonsCracked);
                Patch.SigReplace(ref sEngine2Dll, sigEngine64Addons2, sigEngine64AddonsCracked2);
                Patch.SigReplace(ref sClientDll, sigClient64Addons, sigClient64AddonsCracked);
                break;

            case 1:
                Patch.SigReplace(ref sEngine2Dll, sigEngine32Addons, sigEngine32AddonsCracked);
                Patch.SigReplace(ref sEngine2Dll, sigEngine32Addons2, sigEngine32AddonsCracked2);
                Patch.SigReplace(ref sClientDll, sigClient32Addons, sigClient32AddonsCracked);
                break;
        }
    }

    public static void UnlockSvCheats(ref string sEngine2Dll, int iBitsOS)
    {
        byte[] sigEngine64SvCheats = new byte[] { 0xFF, 0x90, 0x80, 0x00, 0x00, 0x00, 0x84, 0xC0, 0x74, 0x2C };
        byte[] sigEngine64SvCheatsCracked = new byte[] { 0xFF, 0x90, 0x80, 0x00, 0x00, 0x00, 0x84, 0xC0, 0xEB, 0x2C };

        byte[] sigEngine32SvCheats = new byte[] { 0xF3, 0x0F, 0x11, 0x45, 0x08, 0xFF, 0xD0, 0x84, 0xC0, 0x74, 0x2E };
        byte[] sigEngine32SvCheatsCracked = new byte[] { 0xF3, 0x0F, 0x11, 0x45, 0x08, 0xFF, 0xD0, 0x84, 0xC0, 0xEB, 0x2E };
        
        switch (iBitsOS)
        {
            case 0:
                Patch.SigReplace(ref sEngine2Dll, sigEngine64SvCheats, sigEngine64SvCheatsCracked);
                break;
            case 1:
                Patch.SigReplace(ref sEngine2Dll, sigEngine32SvCheats, sigEngine32SvCheatsCracked);
                break;
        }
    }
    public static void SigReplace(ref string sDllFile, byte[] bSig, byte[] bSigCracked)
    {
        Encoding enc = Encoding.Default;

        try
        {
             sDllFile = sDllFile.Replace(enc.GetString(bSig), enc.GetString(bSigCracked));
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static void CloseSteamProcesses()
    {
        try
        {
            var steamProcesses = Process.GetProcessesByName("steam");
            if (steamProcesses.Count() > 0)
            {
                if (MessageBox.Show("To add launch options Steam must be closed\nClose Steam?", "Steam Close",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (var steamProcess in steamProcesses)
                    {
                        steamProcess.Kill();
                    }
                }
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static void DeleteMuteMessage(string dotaFolder)
    {


    }

    public static void CreateBackup(string clientDllPath)
    {
        try
        {
            File.Copy(clientDllPath, clientDllPath + ".bak", true);
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}