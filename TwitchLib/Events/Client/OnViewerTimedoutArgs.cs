﻿using System;

namespace TwitchLib.Events.Client
{
    /// <summary>Args representing a user was timed out event.</summary>
    public class OnUserTimedoutArgs : EventArgs
    {
        /// <summary>Channel that had timeout event.</summary>
        public string Channel;
        /// <summary>Viewer that was timedout.</summary>
        public string Username;
        /// <summary>Duration of timeout IN SECONDS.</summary>
        public TimeSpan TimeoutDuration;
        /// <summary>Reason for timeout, if it was provided.</summary>
        public string TimeoutReason;
    }
}
