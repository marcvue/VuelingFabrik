using System;
using System.Linq.Expressions;
using VuelingFabrik.Domain.Specs;

namespace DesignPatterns.Patterns.ChainOfResponsibility
{
    public class Handler : IHandler
    {
        private readonly ISpecification _specification;
        private readonly IProcessor _processor;
        private readonly IHandler _nextHandler;

        public Handler(ISpecification specification, IProcessor processor, IHandler nextHandler)
        {
            _specification = specification;
            _processor = processor;
            _nextHandler = nextHandler;
        }

        public Handler(Expression<Func<object, bool>> expression, Action<object> action, IHandler nextHandler)
        {
            _specification = new GenericSpecification(expression);
            _processor = new GenericProcessor(action);
            _nextHandler = nextHandler;
        }

        public void Handle(object request)
        {
            if (_specification.IsSatisfiedBy(request))
            {
                _processor.Process(request);
            }
            else
            {
                _nextHandler?.Handle(request);
            }
        }
    }
}
