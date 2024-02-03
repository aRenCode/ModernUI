using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernUI.MVVM.Model
{
    class BotManager
    {
        public static Bot bot = new Bot();

        public static void SetBoth(string token, string twitchName) { bot.Token = token; bot.TwitchName = twitchName; }

        public static void SetToken(string token) {bot.Token = token; }

        public static void SetTwitchName(string twichName) { bot.TwitchName = twichName; }
        public static void ChangeToken(string newToken) => bot.Token = newToken;

        public static string GetToken() =>  bot.Token;

        public static void ChangeTwitchName(string newName) => bot.TwitchName = newName;

        public static string GetTwitchName() => bot.TwitchName;
    }
}
