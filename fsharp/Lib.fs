module Greet

open System
open System.Runtime.InteropServices
open System.Runtime.CompilerServices

//[<NativeCallable(EntryPoint = "getGreeting", CallingConvention = CallingConvention.StdCall)>]
[<UnmanagedCallersOnly(EntryPoint = "Greet_getGreeting", CallConvs= [| typeof<CallConvCdecl> |])>]
let getGreeting (pName: IntPtr) =
     // UnmanagedCallersOnly methods only accept primitive arguments. The primitive arguments
                // have to be marshalled manually if necessary.
    let name = Marshal.PtrToStringAnsi(pName)
    let res = $"Hello, {name}! Welcome to Spring Boot with F#."
    Marshal.StringToCoTaskMemAnsi(res) 
