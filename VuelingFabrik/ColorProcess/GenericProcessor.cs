using System;

namespace DesignPatterns.Patterns.ChainOfResponsibility
{
    public class GenericProcessor : IProcessor
    {
        private readonly Action<object> _action;

        public GenericProcessor(Action<object> action)
        {
            _action = action;
        }

        public void Process(object request)
        {
            _action.Invoke(request);
        }
    }
}
