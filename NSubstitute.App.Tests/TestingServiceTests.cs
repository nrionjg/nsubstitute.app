using NUnit.Framework;
using System;
using NSubstitute;
using System.Threading.Tasks;

namespace NSubstitute.App.Tests
{
	[TestFixture ()]
	public class TestingServiceTests
	{
        ICommand command;

        ITestingService sut;

        [SetUp]
        public void Setup()
        {
            command = Substitute.For<ICommand>();

            sut = new TestingService(command);
        }

		[Test ()]
        public async void MethodToTest_WithSuccess ()
		{
            string stringToReturn = "executed";
            Task<string> taskToReturn = Task.FromResult(stringToReturn);

            command.ExecuteAsync().Returns(taskToReturn);

            string result = await sut.MethodToTest();

            command.Received(1).ExecuteAsync();

            Assert.AreEqual(result, "Success!");

		}
	}
}

