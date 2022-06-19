namespace DependencyInjection
{
    public class Client
    {
        public Client(IService injectedService = null)
        {
            // The constructor injection.
            _iService1 = injectedService;
        }

        private IService _iService1 = null;

        public void UseService()
        {
            _iService1?.MethodToBeUsed();
        }
    }
}
