using System;
using TechTalk.SpecFlow;

namespace RobinsOfgemYahooAutomationTest.SpecFlowContext
{
    public class Context
    {
        public static void Set(ScenarioContext scenarioContext, string key, object value)
        {
            if (scenarioContext.ContainsKey(key))
            {
                scenarioContext.Set(value, key);
            }
            else
            {
                scenarioContext.Add(key, value);
            }
        }

        public static T Get<T>(ScenarioContext scenarioContext, string key)
        {
            return (T)scenarioContext.Get<T>(key);
        }

        public static void Remove(ScenarioContext scenarioContext, string key)
        {
            scenarioContext.Remove(key);
        }
    }
}
