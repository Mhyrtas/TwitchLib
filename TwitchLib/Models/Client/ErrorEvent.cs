namespace TwitchLib.Models.Client
{
    #region using directives
    using System;
    #endregion
    /// <summary>Class representing the error that the websocket encountered.</summary>
    public class ErrorEvent
    {
        /// <summary>Exception object representing the error.</summary>
        public Exception Exception { get; internal set; }
    }
}
