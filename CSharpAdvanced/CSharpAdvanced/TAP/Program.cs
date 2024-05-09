using System;
using System.Threading;
using System.Threading.Tasks;

namespace TAP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Background threads still working only when there is a foreground thread is working, whrn the foreground(main thread) is finished,
            //all backgroundthreads will terminated immediately
            //Console.WriteLine("Main Thread id: " + Environment.CurrentManagedThreadId);
            /*All codes before await goes in the caller thread 
             * All codes after await goes in another thread 
             * Main thread starts and call ProcessBatch1 first and execute all lines before await synchronously 
             * When reach await Task.Delay(1); ==> it makes some operations
             * 1- Stops the code in ProcessBatch1 until Task.Delay(1); is completed
             * 2- return the controller to the main thread 
             * 3- so it can continouing in executing the rest of code so it will call ProcessBatch2 and make the same things
             * 4- when Task.Delay(1); is completed the code after await  starts to run
             * So await blocks the code which it runs in but doesn't block the main thread, and it block its code untils the task after await is finished.
             * in our case the task after await is Task.Delay(1); so after 1ms of blocking the code after await starts
             * The delay isn't the reason of blocking the code of ProcessBatch1 and 2, but await is the reason and it follows by any Task, 
             * and when this task is completed the code continue. in our case we choose the task after await is Task.Delay(time) , so after that time the task is 
             * completed the code continue.
             * So await block the thread it operates and return the controller to the main thread.
             * So if i put await in the main thread it will block the main thread untill the task after it is completed 
             *  ================================================================================================================
             * await  ProcessBatch1(cts.Token); ==> it will block the main thread until ProcessBatch1 is comploeted, so ProcessBatch2 will start after completing 
             * ProcessBatch1 ======> so it will operate as Synchronously
             * =================================================================================================================
             *             var task1 = ProcessBatch1(cts.Token);
             *             await task1;
             *             await ProcessBatch2(cts.Token);
             *             
             *             when starting a task without await then await it, it will stop executing the other line until it comploted not stopping the operating task.
             * ================================================================================================================             
             *             var task1 = ProcessBatch1(cts.Token);
             *             var task2 = ProcessBatch2(cts.Token);
             *             await task1;
             *             await task2;
             *             Console.WriteLine("Please enter you name: ");
             *             var name = Console.ReadLine();
             *              Console.WriteLine($"Welcome, {name}");
             *              Console.ReadKey();
             *             
             *             task1 and task2 will start without await so it will start in executing parallel because there is await Task.Delay(10); in their body, so the controller
             *             will return to the main thread to executing the next.  
             *             and then await task1 and task2 ==> make the main thread stops until the two tasks are finished, so the Welcome page will 
             *             execute after the two tasks are completed.
             * ================================================================================================================
             *              Continuation ==> When i need to make a task starts after a specific task is completed
             *              var task1 = ProcessBatch1(cts.Token);
             *              var task2 = await task1.ContinueWith(async t => await ProcessBatch2(cts.Token));
             *              await task2; to make the welcome page wait for completing task2
             * ================================================================================================================
             * Cancellation ==> must call it in main cts.Cancel(); , and must write the line 
             *              cancellationToken.ThrowIfCancellationRequested(); 
             *              instead of 
             *               if (cancellationToken.IsCancellationRequested)
             *                   return;
             *              in the body of the function
             *              
             *            
            */

            var cts = new CancellationTokenSource();

            // ================================= Task 1 and 2 is executing in the same time =============

            var task1 = ProcessBatch1(cts.Token);
            var task2 = ProcessBatch2(cts.Token);
            cts.Cancel();
            try
            {
                await task1;
            }
            catch (OperationCanceledException e) { }
            await Task.Delay(100);
            Console.WriteLine("Task1 status is: " + task1.Status);
            try
            {
                await task2;
            }
            catch (OperationCanceledException e) { }
            //await Task.WhenAll(task1, task2); // When all tasks are completed it will execurte the Welcome page,  equal await task1; await task2;
            //await Task.WhenAny(task1, task2);// When any of them is completed it will execute the Welcome page.

            // ================================== Continuation ======================================

            //var task1 = ProcessBatch1(cts.Token);
            //var task2 = await task1.ContinueWith(async t => await ProcessBatch2(cts.Token));
            //await task2;

            // ================================== Welcome Page ======================================

            Console.WriteLine("Please enter you name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Welcome, {name}");
            Console.ReadKey();
        }
        private static object _lock = new();
        private static async Task<int> ProcessBatch1(CancellationToken cancellationToken)
        {
            //Any code before await is executed synchronously in calller thread which called this function
            // Console.WriteLine("Batch1 before delay Thread id: " + Environment.CurrentManagedThreadId);
            //await Task1 ==> stop the code until Task1 has finished and return the control to the main thread 

            //Console.WriteLine("Batch1 after delay Thread id: " + Environment.CurrentManagedThreadId);
            for (var i = 1; i <= 100; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Task.Delay(1);
                //if (cancellationToken.IsCancellationRequested)
                //    return;
                lock (_lock)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            return 100;
        }
        private static async Task ProcessBatch2(CancellationToken cancellationToken)
        {
            //Console.WriteLine("Batch2 before delay Thread id: " + Environment.CurrentManagedThreadId);

            // Console.WriteLine("Batch2 after delay Thread id: " + Environment.CurrentManagedThreadId);
            for (var i = 101; i <= 200; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Task.Delay(1);
                //if (cancellationToken.IsCancellationRequested)
                //    return ;
                lock (_lock)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
