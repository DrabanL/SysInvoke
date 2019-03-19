using System;
using System.Runtime.Serialization;

namespace RabanSoft.SysInvoke.Exceptions {
    public class SetClipboardViewerException : Exception {
        public SetClipboardViewerException() {
        }

        public SetClipboardViewerException(string message) : base(message) {
        }

        public SetClipboardViewerException(string message, Exception innerException) : base(message, innerException) {
        }

        protected SetClipboardViewerException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}
