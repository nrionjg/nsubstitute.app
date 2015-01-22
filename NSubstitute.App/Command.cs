using System;
using System.Threading.Tasks;

namespace NSubstitute.App
{
    public interface ICommand
    {
        Task<string> ExecuteAsync();
    }

    public class Command : ICommand
	{
		public Command ()
		{
		}

		public async Task<string> ExecuteAsync()
		{
            // Simulate an async call
            return await Task.FromResult<string>("executed");
		}
	}
}

