using System;
using System.Runtime.Serialization;

namespace RabanSoft.SysInvoke.Exceptions {
    public class HookProcException : Exception {
        public HookProcException() {
        }

        public HookProcException(string message) : base(message) {
        }

        public HookProcException(string message, Exception innerException) : base(message, innerException) {
        }

        protected HookProcException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}
