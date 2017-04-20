using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Internal.Parsing.Parsers
{
    public static class Mode
    {
        public static bool parse(TwitchClient instance, string message)
        {
            switch(message.Split(' ')[3])
            {
                case "+o":
                    instance.InvokeModeratorJoined(message.Split(' ')[2].Replace("#", ""), message.Split(' ')[4]);
                    return true;
                case "-o":
                    instance.InvokeModeratorLeft(message.Split(' ')[2].Replace("#", ""), message.Split(' ')[4]);
                    return true;
            }
            return true;
        }
    }
}
