using System;
using System.IO;
using Microsoft.Win32;

internal class FoldersFind
{
    public static string DotaFind()
    {
        var dotaFolder = String.Empty;
        if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\OvPatch", "DotaFolder", null) != null)
            dotaFolder = (string) Registry.GetValue(@"HKEY_CURRENT_USER\Software\OvPatch", "DotaFolder", null);
        else if (Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Classes\Applications\dota.exe\shell\Open\Command", "",
            null) != null)
            dotaFolder =
                Path.GetDirectoryName(
                    (((string)
                        (Registry.GetValue(
                            @"HKEY_LOCAL_MACHINE\Software\Classes\Applications\dota.exe\shell\open\command", "", "")))
                        .Replace("\" \"%1\"", "")).TrimStart('"'));
        else if (Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Classes\dota2\Shell\Open\Command", "", null) != null)
		{
            dotaFolder = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Classes\dota2\Shell\Open\Command", "", null);
		    dotaFolder = dotaFolder.Remove(dotaFolder.IndexOf("\\game")).TrimStart('"');
		}
        return dotaFolder;
    }

    public static string SteamFind()
    {
        var steamFolder = String.Empty;
        if (Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Classes\steam\shell\open\command", "", null) !=
            null)
            steamFolder = Path.GetDirectoryName(
                (((string)
                    (Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Classes\steam\shell\open\command",
                        "", null))).Replace("\" \"%1\"", "")).TrimStart('"'));
        return steamFolder;
    }

    public static void SaveFolder(string dotaFolder)
    {
        var OvPatchKey = Registry.CurrentUser.CreateSubKey(@"Software\OvPatch");
        var regDotaFolder = OvPatchKey.GetValue("DotaFolder", null);
        if (regDotaFolder == null | regDotaFolder != dotaFolder)
            OvPatchKey.SetValue("DotaFolder", dotaFolder);

        OvPatchKey.Close();
    }
}