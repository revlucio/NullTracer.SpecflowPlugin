using System;
using NullTracer.SpecflowPlugin;
using TechTalk.SpecFlow.Plugins;
using TechTalk.SpecFlow.Tracing;

[assembly: RuntimePlugin(typeof(NullTracerPlugin))]
 namespace NullTracer.SpecflowPlugin
 {
     public class NullTracerPlugin : IRuntimePlugin
     {
         public void Initialize(RuntimePluginEvents runtimePluginEvents, RuntimePluginParameters runtimePluginParameters)
         {
             if (Environment.GetEnvironmentVariable("DisableNullTracer") != "true")
             {
                 runtimePluginEvents.CustomizeTestThreadDependencies += (sender, args) =>
                 {
                     args.ObjectContainer.RegisterTypeAs<NullTracer, ITestTracer>();
                 };
             }
         }
     }
 }