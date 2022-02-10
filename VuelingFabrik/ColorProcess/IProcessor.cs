namespace DesignPatterns.Patterns.ChainOfResponsibility
{
    public interface IProcessor
    {
        void Process(object request);
    }
}
