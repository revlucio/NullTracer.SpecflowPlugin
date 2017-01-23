using System;
using System.Collections.Generic;
using System.Globalization;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Bindings;
using TechTalk.SpecFlow.Bindings.Reflection;
using TechTalk.SpecFlow.Tracing;

namespace CustomTracer.SpecflowPlugin
{
    public class NullTracer : ITestTracer
    {
        public void TraceStep(StepInstance stepInstance, bool showAdditionalArguments)
        {
        }

        public void TraceWarning(string text)
        {
        }

        public void TraceStepDone(BindingMatch match, object[] arguments, TimeSpan duration)
        {
        }

        public void TraceStepSkipped()
        {
        }

        public void TraceStepPending(BindingMatch match, object[] arguments)
        {
        }

        public void TraceBindingError(BindingException ex)
        {
        }

        public void TraceError(Exception ex)
        {
        }

        public void TraceNoMatchingStepDefinition(StepInstance stepInstance, ProgrammingLanguage targetLanguage, CultureInfo bindingCulture, List<BindingMatch> matchesWithoutScopeCheck)
        {
        }

        public void TraceDuration(TimeSpan elapsed, IBindingMethod method, object[] arguments)
        {
        }

        public void TraceDuration(TimeSpan elapsed, string text)
        {
        }
    }
}
