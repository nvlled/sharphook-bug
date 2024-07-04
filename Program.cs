using SharpHook.Native;
// See https://aka.ms/new-console-template for more information


UioHook.SetDispatchProc((ref UioHookEvent data, nint _) =>
{
    Console.WriteLine("event: {0} {1}", data.Time, data.Type);
}, IntPtr.Zero);


UioHook.Run();