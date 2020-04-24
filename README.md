[![Project Icon](./Assets/logo.png)](https://ediweave.net/)

[![Nuget Package](https://img.shields.io/nuget/v/EdiWeave.Framework.svg?maxAge=86400&style=flat-square)](https://www.nuget.org/packages/EdiWeave.Framework/) 
[![Build status](https://img.shields.io/appveyor/ci/Silvenga/ediweave.svg?maxAge=86400&style=flat-square)](https://ci.appveyor.com/project/Silvenga/ediweave)

> An **open source** framework that empowers developers and businesses interested in enabling their software systems with EDI capabilities and can be integrated into your business applications.
> \- Originally from EdiFrabric

EdiWeave is a hard-fork of the now closed-source library EdiFabric. It mirror'ed the last state of the EdiFabric repository before the company EdiFabric took it down.

Supported frameworks:
- .NET Framework 4.5
- .NET Standard 1.6
- .NET Standard 2.0
- .NET Core 1.1

## Download it!

### 8.0 Branch (Current)
```
Install-Package EdiWeave.Framework
```

### 7.3 Branch (Legacy)
```
Install-Package EdiWeave.Framework -Version 7.3.3
```

## Migrating from EdiFabric

In most cases, upgrading from EdiFabric to EdiWeave is easy! This project attempts to maintain API compatibility with EdiFabric when possible (at least for the known future). Existing class based definitions (and XML based ones, if using the Legacy branch) should be fully compatible.

First uninstall EdiFabric:

```
Uninstall-Package EdiFabric.Framework
```

Then install EdiWeave:

```
Install-Package EdiWeave.Framework
```

Then simply find and replace the strings `EdiFabric` with `EdiWeave`.

**Note**: If you are using the latest version of the existing class-based definitions, please find and remove the `Id` property as well as the attributes adorning it. Failure to do so will cause parsing errors.
