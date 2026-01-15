using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hulisajeDP2
{
    public class LoggerContext : ILogger
    {
        private ILoggingState _state;

        public LoggerContext(ILoggingState initialState)
        {
            _state = initialState;
        }

        public void SetState(ILoggingState newState)
        {
            _state = newState;
        }

        public void Log(string message)
        {
            _state.Log(message);
        }
    }
}
