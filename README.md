# Vettvangur project aim
To backport Net5 X509ChainTrustMode.CustomRootTrust feature to Net472
the intent is to allow users to create X509Chain and build with a custom root
Use case: Azure app services

# Vettvangur changes
namespace find replace
using find replace
move linked files to project directory
exclude from project unused code
Work around lesser span support
    .CloneByteArray() -> .Clone() + cast 
        Similar to Net5 CloneByteArray source code
    ToArray since string constructor doesn't yet support spans
refactor C# 8.0 features such as 
    remove all nullable reference code (find replace ? and !)
    inverse switch
    inline static functions

ToLpstrArray
    code inlined from Net5 source and use MemoryMarshal.GetReference in place of GetNonNullRef

## Notes
Can't exclude x509certificate2, need to access internal member pal
proj only includes windows Pal code

Need Net472 for
	SafeNCryptKeyHandle
    Maybe we can go further and grab it's source but this will do for now



# .NET Runtime

[![Build Status](https://dnceng.visualstudio.com/public/_apis/build/status/dotnet/runtime/runtime?branchName=master)](https://dnceng.visualstudio.com/public/_build/latest?definitionId=686&branchName=master)
[![Gitter](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/dotnet/runtime)

This repo contains the code to build the .NET runtime, libraries and shared host (`dotnet`) installers for
all supported platforms, as well as the sources to .NET runtime and libraries.

## What is .NET?

Official Starting Page: https://dotnet.microsoft.com/

* [How to use .NET](https://docs.microsoft.com/dotnet/core/get-started) (with VS, VS Code, command-line CLI)
  * [Install official releases](https://dotnet.microsoft.com/download)
  * [Install daily builds](https://github.com/dotnet/installer#installers-and-binaries)
  * [Documentation](https://docs.microsoft.com/dotnet/core) (Get Started, Tutorials, Porting from .NET Framework, API reference, ...)
    * [Deploying apps](https://docs.microsoft.com/dotnet/core/deploying)
  * [Supported OS versions](https://github.com/dotnet/core/blob/master/os-lifecycle-policy.md)
* [Roadmap](https://github.com/dotnet/core/blob/master/roadmap.md)
* [Releases](https://github.com/dotnet/core/tree/master/release-notes)

## How can I contribute?

We welcome contributions! Many people all over the world have helped make this project better.

* [Contributing](CONTRIBUTING.md) explains what kinds of changes we welcome
- [Workflow Instructions](docs/workflow/README.md) explains how to build and test
* [Get Up and Running on .NET Core](docs/project/dogfooding.md) explains how to get nightly builds of the runtime and its libraries to test them in your own projects.

## Reporting security issues and security bugs

Security issues and bugs should be reported privately, via email, to the Microsoft Security Response Center (MSRC) <secure@microsoft.com>. You should receive a response within 24 hours. If for some reason you do not, please follow up via email to ensure we received your original message. Further information, including the MSRC PGP key, can be found in the [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue).

Also see info about related [Microsoft .NET Core and ASP.NET Core Bug Bounty Program](https://www.microsoft.com/msrc/bounty-dot-net-core).

## Filing issues

This repo should contain issues that are tied to the runtime, the class libraries and frameworks, the installation of the `dotnet` binary (sometimes known as the `muxer`) and installation of the .NET runtime and libraries.

For other issues, please use the following repos:

- For overall .NET SDK issues, file in the [dotnet/sdk](https://github.com/dotnet/sdk) repo
- For ASP.NET issues, file in the [dotnet/aspnetcore](https://github.com/dotnet/aspnetcore) repo.

## Useful Links

* [.NET Core source index](https://source.dot.net) / [.NET Framework source index](https://referencesource.microsoft.com)
* [API Reference docs](https://docs.microsoft.com/dotnet/api/?view=netcore-3.1)
* [.NET API Catalog](http://apisof.net) (incl. APIs from daily builds and API usage info)
* [API docs writing guidelines](https://github.com/dotnet/dotnet-api-docs/wiki) - useful when writing /// comments

## .NET Foundation

.NET Runtime is a [.NET Foundation](https://www.dotnetfoundation.org/projects) project.

There are many .NET related projects on GitHub.

- [.NET home repo](https://github.com/Microsoft/dotnet) - links to 100s of .NET projects, from Microsoft and the community.
- [ASP.NET Core home](https://docs.microsoft.com/aspnet/core/?view=aspnetcore-3.1) - the best place to start learning about ASP.NET Core.

This project has adopted the code of conduct defined by the [Contributor Covenant](http://contributor-covenant.org/) to clarify expected behavior in our community. For more information, see the [.NET Foundation Code of Conduct](http://www.dotnetfoundation.org/code-of-conduct).

General .NET OSS discussions: [.NET Foundation forums](https://forums.dotnetfoundation.org)

## License

.NET (including the runtime repo) is licensed under the [MIT](LICENSE.TXT) license.
