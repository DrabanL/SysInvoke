using System;
using System.Runtime.Serialization;

namespace RabanSoft.SysInvoke.Exceptions {
    public class UnhookWindowsHookExException : Exception {
        public UnhookWindowsHookExException() {
        }

        public UnhookWindowsHookExException(string message) : base(message) {
        }

        public UnhookWindowsHookExException(string message, Exception innerException) : base(message, innerException) {
        }

        protected UnhookWindowsHookExException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}
