/* Task Run*/
Console.WriteLine("// Use Task.Run to start a task that computes the sum of numbers");

int[] numbers = Enumerable.Range(0, 10).ToArray();

// Use Task.Run to start a task that computes the sum of numbers
Task<long> task1 = Task.Run(() =>
{
    long total = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        total += numbers[i];
    }
    return total;
});

Console.WriteLine("Doing some other work...");

// Await the task to retrieve the result
long result = await task1;
Console.WriteLine($"Sum is {result}");
Console.WriteLine("__");

/* Task Factory */
Console.WriteLine("// Sample of creating a task with Task Factory Start New with cancellation");
// Sample of creating a task with Task Factory Start New with cancellation
var cancellationTokenSource = new CancellationTokenSource();
Task longRunningTask = Task.Factory.StartNew(() =>
{
    // This code will run in a separate thread
    // Check for cancellation request frequently so the task can be stopped
    for (int i = 0; i < 100; i++)
    {
        if (cancellationTokenSource.Token.IsCancellationRequested)
        {
            break;
        }
        Console.WriteLine($"Iteration {i}");
        Thread.Sleep(1000);
    }
}, cancellationTokenSource.Token);

// Let's run the task for 5 seconds and then cancel it
Thread.Sleep(5000);
cancellationTokenSource.Cancel();
Console.WriteLine("__");

/* await*/
Console.WriteLine("// Run a Task and await for its completion");
// Run a Task and await for its completion
async Task DoJustMagicAsync()
{
    await Task.Run(() =>
    {
        Console.WriteLine("Doing magic asynchronously!");
        // Simulate a long running task
        Thread.Sleep(2000);
    });
    Console.WriteLine("Magic done!");
}
DoJustMagicAsync();
Console.WriteLine("__");

/* async*/
Console.WriteLine("// Example of Task.Run Async");
// Example of Task.Run Async
async Task ComplexCalculationAsync()
{
    // Create a task to run asynchronously
    await Task.Run(() =>
    {
        // Simulate a complex calculation
        for (int i = 0; i < int.MaxValue; i++)
        {
            var calculatedValue = Math.Sqrt(i);
        }
        Console.WriteLine("Finished the complex calculation!");
    });
}
await ComplexCalculationAsync();
Console.WriteLine("__");

/*parallel execution*/
Console.WriteLine("parallel case execution");
int[] data = Enumerable.Range(0, 10).ToArray();

// Transform the data in parallel
Parallel.For(0, data.Length, i =>
{
    // This calculation takes place in parallel
    data[i] = PerformExpensiveCalculation(data[i]);
});

// Here's our (hypothetical) expensive calculation
int PerformExpensiveCalculation(int value)
{
    return value * value;
}
Console.WriteLine("__");

/*When you’re dealing with CPU-bound operations like computations, parallelizing can distribute the work across multiple cores. On the other hand, when dealing with IO-bound operations (like reading/writing to disk or network requests), parallelizing such tasks allows your program to progress with other tasks while waiting for these operations to complete.*/

/*IO-bound operations (like reading/writing to disk or network requests)*/
Console.WriteLine("multiple files download in parallel");
// Let's assume we have a list of file URLs we need to download
List<string> fileUrls = GetFileUrls();

// We'll use HttpClient to download the files
HttpClient client = new HttpClient();

// Download all files in parallel
Parallel.ForEach(fileUrls, async url =>
{
    byte[] data = await client.GetByteArrayAsync(url);
    // Save the file locally
});

// Hypothetical GetFileUrls
List<string> GetFileUrls() => new List<string> { /* urls here */ };
Console.WriteLine("__");

Console.WriteLine("task start()");
/*When you call Task.Start, you’re telling the runtime to start executing the task.*/
// Declare the tasks
Task[] tasks = new Task[10];

// Initialize and start the tasks
for (var i = 0; i < 10; i++)
{
    int taskNum = i; // To avoid closure on the loop variable
    tasks[i] = new Task(() =>
    {
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine($"Task {taskNum} complete!");
    });
}

// Now, let’s start our tasks
foreach (var t in tasks)
{
    t.Start();
}

// And wait for all of them to complete
Task.WaitAll(tasks);
Console.WriteLine("__");

/*example of using await with Task.Run*/
Console.WriteLine("example of using await with Task.Run");
// Simulate a long running task within Task.Run and use await keyword
Task task = Task.Run(() =>
{
    for (int i = 0; i < 5; i++)
    {
        Thread.Sleep(2000); 
        Console.WriteLine($"Done with the part {i} of the task!");
    }
});
await task;
Console.WriteLine("All parts of the task are done, and now the main thread is free to do other things!");
Console.WriteLine("__");

/*Start Task and Await Methods*/
Console.WriteLine("Start Task and Await Methods");
Task task3 = new Task(() =>
{
    // Simulate a task that takes 2 seconds.
    Thread.Sleep(2000);
    Console.WriteLine("Task has completed!");
});

Console.WriteLine("Starting the task...");
task3.Start();
Console.WriteLine("Waiting for the task to finish...");
await task; // Await the completion of the task
Console.WriteLine("Task is complete!");
Console.WriteLine("__");
/*create a new task that simulates a time-consuming task, just like in our previous scenario. After it starts by using Start(), the rest of the code doesn’t wait for it to complete until await is reached. Once there, the method where this block of code is located will pause until the task completes. This effectively frees up the main thread while waiting for the task to finish.*/

Console.WriteLine("multiple async tasks | task delay");
// This example represent multiple asynchronous tasks
List<Task> tasks2 = new List<Task>();
for (int i = 0; i < 5; i++)
{
    int taskNum = i;  
    tasks2.Add(Task.Run(async () =>
    {       
        await Task.Delay(1000); // Simulate a long-running task
        Console.WriteLine($"Task {taskNum} completed!");
    }));
};
Console.WriteLine("Waiting for all tasks to complete...");
await Task.WhenAll(tasks);
Console.WriteLine("All tasks completed!"); //<= after all tasks are completed
Console.WriteLine("__");