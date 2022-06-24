using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Dictionary_Extensions
{
    public static class DateTimeExtensions
    {
        public static string MesEmExtensoPtBR(this DateTime dataNascimento)
        {
            return $"Nasceu em {dataNascimento.ToString("MMMM", CultureInfo.GetCultureInfo("pt-BR"))}";
        }

        public static DateTime DataEmPtBR (this string data)
        {
            return DateTime.Parse(data, CultureInfo.GetCultureInfo("pt-BR"));
        }
    }
}
