# Mnemonic

A .NET library for generating the exact same kind of mnemonics
that Docker does.  
I'm happy to add additional word lists if anyone 
wants to contribute.

## Usage

```csharp
using Mnemonic;

// Generates a mnemonic, i.e. "agitated-davinci"
string name = Mnemonic.Generate();
```

## Building

We're using [Cake](https://github.com/cake-build/cake) as a 
[dotnet tool](https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools) 
for building. So make sure that you've restored Cake by running 
the following in the repository root:

```
> dotnet tool restore
```

After that, running the build is as easy as writing:

```
> dotnet cake
```

## Copyright

Copyright Patrik Svensson