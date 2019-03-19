using System;
using System.Runtime.Serialization;

namespace RabanSoft.SysInvoke.Exceptions {
    public class SetWindowsHookExException : Exception {
        public SetWindowsHookExException() {
        }

        public SetWindowsHookExException(string message) : base(message) {
        }

        public SetWindowsHookExException(string message, Exception innerException) : base(message, innerException) {
        }

        protected SetWindowsHookExException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}
