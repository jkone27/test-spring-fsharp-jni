open System.Runtime.InteropServices
open System

[<Literal>]
let libPath = __SOURCE_DIRECTORY__ + "/bin/Release/net9.0/linux-x64/publish/libgreet.so"

// Define the DllImport attribute to load the function
[<DllImport(libPath, EntryPoint = "Greet_getGreeting", CallingConvention = CallingConvention.Cdecl)>]
extern IntPtr Greet(IntPtr name)

// Test the function
let res = 
    try
        "Me" 
        |> Marshal.StringToCoTaskMemAnsi
        |> Greet 
        |> Marshal.PtrToStringAnsi
        |> Some
    with ex -> 
        printfn $"ERROR: {ex.Message}"
        None

res |> printfn "%A"
