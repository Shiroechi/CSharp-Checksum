# CSharp Checksum [![CodeFactor](https://www.codefactor.io/repository/github/shiroechi/csharp-checksum/badge/master)](https://www.codefactor.io/repository/github/shiroechi/csharp-checksum/overview/master)

A simple file checksum for windows using [Portable.BouncyCastle](https://github.com/onovotny/bc-csharp) for hash function.

there's a limit to the size of file to hash, you can change it in the aplication setting.

**remember the bigger the file size the slower it is**

## Supported hash function
* [SHA-1](https://en.wikipedia.org/wiki/SHA-1)
* [SHA-2](https://en.wikipedia.org/wiki/SHA-2)
* [SHA-3](https://en.wikipedia.org/wiki/SHA-3)
* [Blake2b](https://en.wikipedia.org/wiki/BLAKE_(hash_function))

## Existing Feature
* Hash single file
* Compare file with hash value
* Save hash value to a file
* cancel the currently running hash process

## Getting Started

### Prerequisites
Before build this project you need to add reference:
* [Portable.BouncyCastle](https://www.nuget.org/packages/Portable.BouncyCastle/)

## To do
* Compare file with hash value from text file
* more hash function
* hash multiple file

## Build with
* [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/)

## Credits
Thanks to [Portable.BouncyCastle](https://github.com/onovotny/bc-csharp)

