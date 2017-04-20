using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using TwitchLib.Models.Client;

namespace TwitchLib.Internal.Parsing
{
    internal static class Parser
    {
        public static bool Parse(TwitchClient instance, string message)
        {
            switch(message.Split(' ')[1])
            {
                case "JOIN":
                    return Parsers.Join.parse(instance, message);
                case "PART":
                    return Parsers.Part.parse(instance, message);
                case "MODE":
                    return Parsers.Mode.parse(instance, message);
                case "353":
                    return Parsers.Names.parse(instance, message);
                case "CLEARCHAT":
                    return Parsers.Clearchat.parse(instance, message);
                case "USERNOTICE":
                case "HOSTTARGET":
                case "NOTICE":
                case "RECONNECT":
                case "ROOMSTATE":
                case "USERSTATE":
            }
            switch (message.Split(' ')[2])
            {
                case "GLOBALUSERSTATE":
                case "ROOMSTATE":
            }
        }
    }
}
