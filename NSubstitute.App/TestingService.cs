using System;
using System.Threading.Tasks;

namespace NSubstitute.App
{
    public interface ITestingService
    {
        Task<string> MethodToTest();
    }

    public class TestingService : ITestingService
    {
        ICommand command;

        public TestingService(ICommand command)
        {
            this.command = command;
        }

        public async Task<string> MethodToTest()
        {
            string result = await command.ExecuteAsync();

            if (result == "executed")
                return "Success!";
            else
                return "Failed!";
        }
    }
}

