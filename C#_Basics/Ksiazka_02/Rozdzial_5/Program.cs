//255 poczatek nowego 5 rozdziału
/*.NET Standard*/

/*

Wersje środowiska i C#
Kompilator C# automatycznie wybiera wersję języka na podstawie środowiska docelowego
projektu:
• Dla.NET 5 wybiera C# 9.
• Dla .NET Core 3.x, Xamarin i .NET Standard 2.1 wybiera C# 8.
• Dla .NET Core 2.x, .NET Framework i .NET Standard 2.0 oraz wcześniejszych wybiera C# 7.3.*/

//ASP.NET Core do witryn internetowych, REST API,
//WIndows Desktop

// od strony 268  platforma .NET
/*
 > SINGLETON
To register a service as a Singleton in .NET Core, use the AddSingleton method:
<services.AddSingleton<ILoggingService, LoggingService>();>
example: a logging services -> all components in application uses the same instance, facilitating centralized logging and resource sharing

 > SCOPED
Scoped lifetime creates a new instance of a service for each scope or logical operation within an application
To register a service as Scoped, use the AddScoped method:
<services.AddScoped<IDatabaseService, DatabaseService>();>
example:  when handling a web request, you may have a service that interacts with a database. In this scenario, using Scoped lifetime ensures that each request gets its own instance of the service, avoiding conflicts between multiple requests.

 > TRANSIENT
 Transient lifetime creates a new instance of a service every time it is requested
To register a service as Transient, use the AddTransient method:
<services.AddTransient<IUtilityService, UtilityService>();>
example: simple calculation services

summary:
Singleton
Use Singleton when you have stateless services or shared resources that need to be accessed consistently across the application.
Be cautious when using Singleton with services that maintain mutable state, as concurrent access can lead to unexpected behavior or race conditions.
Scoped
Use Scoped when you have stateful services or resources that need to be shared within a specific context, such as a web request or unit of work.
Scoped instances help ensure that each request or operation gets its own isolated instance, preventing interference between different contexts.
Transient
Use Transient for lightweight and stateless services that don’t maintain any internal state or shared resources.
Transient instances are suitable for services that perform simple calculations, generate random numbers, or provide general utility functions.
*/