namespace DesignPatterns.Patterns.ChainOfResponsibility
{
    public interface IHandler
    {
        void Handle(object request);
    }
}
