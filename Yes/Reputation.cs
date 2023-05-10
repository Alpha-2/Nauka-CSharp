using System;

namespace ObiektoweProgramowanieCSharp
{
    class Reputation
    {
        public Reputation(string userReplyArgs)
        {
            reply = userReplyArgs;
        }
        public string reply;
        public static bool IsEnabled = true;
    }
}
