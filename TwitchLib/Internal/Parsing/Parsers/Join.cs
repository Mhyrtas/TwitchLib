using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Internal.Parsing.Parsers
{
    public static class Join
    {
        public static bool parse(TwitchClient instance, string message)
        {
            instance.InvokeUserJoined(message.Split(' ')[2].Replace("#", ""), message.Split('!')[0]);
            return true;
        }
    }
}
