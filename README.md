# Interface between R and .NET

Repo contains sample [Windows Forms app](https://github.com/MikhailArkhipov/RTVS-cs/blob/master/ApiTest/RHostApiTestForm.cs) 
that demostrate use of the R-to-.NET interface. The API based on [R Tools for Visual Studio](https://github.com/Microsoft/RTVS) components.

1. Runs R out of process. R crash will not bring down your application.
2. Supports multiple R session with multiple interpreters
3. R code calls are asynchronous and non-blocking.
4. Support for remote connections (like in RTVS 1.0+) will be added in the future

The followig operations are supported:

1. Arbitrary R expression evaluation.
2. Data transfer between R and .NET (basic types, lists, data frames) 
3. R function calls passing arguments in .NET types.
4. Plotting into an image with specify resolution and DPI setting.
5. Capturing R console output.


API [Source code](https://github.com/Microsoft/RTVS/tree/master/src/Host/API/Impl) and
[Test code](https://github.com/Microsoft/RTVS/tree/master/src/Host/API/Test)

NuGet [package]()

