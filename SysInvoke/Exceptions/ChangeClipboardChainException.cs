using System;
using System.Runtime.Serialization;

namespace RabanSoft.SysInvoke.Exceptions {
    public class ChangeClipboardChainException : Exception {
        public ChangeClipboardChainException() {
        }

        public ChangeClipboardChainException(string message) : base(message) {
        }

        public ChangeClipboardChainException(string message, Exception innerException) : base(message, innerException) {
        }

        protected ChangeClipboardChainException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}
