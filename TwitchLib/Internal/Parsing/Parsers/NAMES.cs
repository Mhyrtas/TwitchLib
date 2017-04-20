using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Internal.Parsing.Parsers
{
    public static class Names
    {
        public static bool parse(TwitchClient instance, string message)
        {
            string channel = message.Split(' ')[4].Replace("#", "");
            string players = message.Replace($"{message.Split(' ')[0]} 353 {message.Split(' ')[2]} = #{channel} :", "");
            instance.InvokeExistingUsersDetected(channel, players.Split(' ').ToList());
            return true;
        }
    }
}
