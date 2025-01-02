# Try invoke F# from springboot

## 1 - compile and publish some sample F# code to AOT  

see the code in `Lib.fs` and tested via `Test.fsx` to verify the assembly exposes the function, 

a pre-test can be run via 

```
nm -D /lib/libgreet.so | grep greet
```


If the function is exported, you'll see something like:

`00000000000012f0 T greet`
T indicates the function is in the text (code) section, meaning it's a defined function.
U would indicate an undefined symbol (i.e., the function is not defined in this library).

## 2 - invoke via JNA in springboot inside a controller

using JNA in java we provide an interface to do native invocation, see `GreetLibrary.java` and then we invoke such in `GreetingController.java`

### Folder Structure

```cli
├── fsharp
│   ├── bin
│   ├── Greet.fsproj
│   ├── Lib.fs
│   ├── obj
│   └── Test.fsx
├── lib
│   ├── libgreet.so
│   └── libgreet.so.dbg
├── Readme.md
└── spring
    ├── HELP.md
    ├── mvnw
    ├── mvnw.cmd
    ├── pom.xml
    ├── src
    └── target
```