using System;
using System.Runtime.Serialization;

namespace RabanSoft.SysInvoke.Exceptions {
    public class GetModuleHandleException : Exception {
        public GetModuleHandleException() {
        }

        public GetModuleHandleException(string message) : base(message) {
        }

        public GetModuleHandleException(string message, Exception innerException) : base(message, innerException) {
        }

        protected GetModuleHandleException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}
