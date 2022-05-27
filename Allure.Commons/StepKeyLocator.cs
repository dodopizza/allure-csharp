using System;
using System.Threading;

namespace Allure.Commons;

public class StepKeyLocator
{
	internal Func<string> Locator { get; set; }

	public StepKeyLocator() : this(() => Thread.CurrentThread.ManagedThreadId.ToString())
	{
	}

	private StepKeyLocator(Func<string> locator)
	{
		Locator = locator;
	}
}