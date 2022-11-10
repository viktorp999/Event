using System;

namespace Event
{
    public class ProcessEventArgs : EventArgs
    {
        public bool IsSuccessful { get; set; }
        public DateTime CompletionDate { get; set; }
    }
}
