using Plugin.Common;
using System.Reflection;
using System.Runtime.Loader;

class PluginLoadContext : AssemblyLoadContext
{
    AssemblyDependencyResolver _resolver;

    public PluginLoadContext(string pluginPath, bool collectible)

    : base(name: Path.GetFileName(pluginPath), collectible)
    {
        _resolver = new AssemblyDependencyResolver(pluginPath);
    }

    protected override Assembly Load(AssemblyName assemblyName)
    {
        if (assemblyName.Name == typeof(ITextPlugin).Assembly.GetName().Name)
        {
            return null;
        }

        string target = _resolver.ResolveAssemblyToPath(assemblyName);
        if (target != null)
        {
            return LoadFromAssemblyPath(target);
        }
        return null;
    }

    protected override IntPtr LoadUnmanagedDll(string unmanagedDllName)
    {
        string path = _resolver.ResolveUnmanagedDllToPath(unmanagedDllName);
        return path == null
                            ? IntPtr.Zero
                            : LoadUnmanagedDllFromPath(path);
    }
}

class Program
{
    const bool UseCollectibleContexts = true;
    //const bool UseCollectibleContexts = false;

    static void Main()
    {
        //when usecollectiblecontextx = false
        //foreach (var context in AssemblyLoadContext.All)
        //{
        //    Console.WriteLine($"Kontekst: {context.GetType().Name} {context.Name}");
        //    foreach (var assembly in context.Assemblies)
        //        Console.WriteLine($" Zestaw: {assembly.FullName}");
        //}
        const string captializer = @"Z:\Tester\c#\Trial_projects\C#_Basics\PluginDemo\Capitalizer\bin\Debug\net8.0\Capitalizer.dll";

        Console.WriteLine(TransformText("big apple ", captializer));

        ////    const string pluralizer = @"C:\source\PluginDemo\"
        ////                                + @"Pluralizer\bin\Debug\netcoreapp3.0\Pluralizer.dll";

        ////    Console.WriteLine(TransformText("big apple", pluralizer));
    }

    static string TransformText(string text, string pluginPath)
    {
        var alc = new PluginLoadContext(pluginPath, UseCollectibleContexts);
        try
        {
            Assembly assem = alc.LoadFromAssemblyPath(pluginPath);
            Type pluginType = assem.ExportedTypes.Single(t => typeof(ITextPlugin).IsAssignableFrom(t));

            //  egzemplarz ITextPlugin
            var plugin = (ITextPlugin)Activator.CreateInstance(pluginType);

            // wywołanie metody TransformText
            return plugin.TransformText(text);
        }
        finally
        {
            if (UseCollectibleContexts) alc.Unload(); // usuwa ALC
        }
    }
}