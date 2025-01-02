# Try invoke F# from springboot

1 - compile and publish to AOT  

2 - invoke via JNA in springboot inside a controller

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