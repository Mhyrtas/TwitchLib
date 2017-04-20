using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Internal.Parsing.Parsers
{
    public static class Part
    {
        public static bool parse(TwitchClient instance, string message)
        {
            instance.InvokeUserLeft(message.Split(' ')[2].Replace("#", ""), message.Split('!')[0]);
            return true;
        }
    }
}
