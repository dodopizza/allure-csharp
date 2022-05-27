using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Allure.Commons.Storage
{
	internal class AllureStorage
	{
		private readonly StepKeyLocator stepKeyLocator;

		private readonly ConcurrentDictionary<string, LinkedList<string>> stepContextLocal = new();

		public AllureStorage(StepKeyLocator stepKeyLocator)
		{
			this.stepKeyLocator = stepKeyLocator;
		}

		private LinkedList<string> stepContext => stepContextLocal.GetOrAdd(stepKeyLocator.Locator(), new LinkedList<string>());

		private readonly ConcurrentDictionary<string, object> storage = new ConcurrentDictionary<string, object>();

		public T Get<T>(string uuid)
		{
			return (T) storage[uuid];
		}

		public T Put<T>(string uuid, T item)
		{
			return (T) storage.GetOrAdd(uuid, item);
		}

		public T Remove<T>(string uuid)
		{
			storage.TryRemove(uuid, out var value);
			return (T) value;
		}

		public void ClearStepContext()
		{
			stepContext.Clear();
		}

		public void StartStep(string uuid)
		{
			stepContext.AddFirst(uuid);
		}

		public void StopStep()
		{
			stepContext.RemoveFirst();
		}

		public string GetRootStep()
		{
			return stepContext.Last?.Value;
		}

		public string GetCurrentStep()
		{
			return stepContext.First?.Value;
		}

		public void AddStep(string parentUuid, string uuid, StepResult stepResult)
		{
			Put(uuid, stepResult);
			Get<ExecutableItem>(parentUuid).steps.Add(stepResult);
		}
	}
}