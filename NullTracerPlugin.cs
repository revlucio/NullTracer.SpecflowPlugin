using MinTracer.SpecflowPlugin;
using TechTalk.SpecFlow.Plugins;
using TechTalk.SpecFlow.Tracing;

[assembly: RuntimePlugin(typeof(NullTracerPlugin))]
 namespace MinTracer.SpecflowPlugin
 {
     public class NullTracerPlugin : IRuntimePlugin
     {
         public void Initialize(RuntimePluginEvents runtimePluginEvents, RuntimePluginParameters runtimePluginParameters)
         {
             runtimePluginEvents.CustomizeTestThreadDependencies += (sender, args) =>
             {
                 args.ObjectContainer.RegisterTypeAs<CustomTracer.SpecflowPlugin.NullTracer, ITestTracer>();
             };
         }
     }
 }
