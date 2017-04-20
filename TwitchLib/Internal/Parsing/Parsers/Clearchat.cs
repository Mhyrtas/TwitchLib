using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Internal.Parsing.Parsers
{
    public static class Clearchat
    {
        public static bool parse(TwitchClient instance, string message)
        {
            string channel = message.Split(' ')[3].Replace("#", "");
            if(message.Split('=')[0].Split('-')[1] == "duration")
            {
                int seconds = int.Parse(message.Split(';')[0].Split('=')[1]);
                TimeSpan timeoutDuration = TimeSpan.FromSeconds(seconds);
            } else
            {

            }
            return true;
        }
    }
}
