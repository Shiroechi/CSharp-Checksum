# CSharp Checksum [![CodeFactor](https://www.codefactor.io/repository/github/shiroechi/csharp-checksum/badge)](https://www.codefactor.io/repository/github/shiroechi/csharp-checksum)

**NOTICE**
because some mistake when i try github desktop, this repo will archived and i will create new repo for this.

A simple file checksum for windows using [Portable.BouncyCastle](https://github.com/onovotny/bc-csharp) for hash function.

There's a limit to the size of file to hash, you can change it in the aplication setting.

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
* Cancel the currently running hash process

## Getting Started

### Prerequisites
Before build this project you need to add reference:
* [Portable.BouncyCastle](https://www.nuget.org/packages/Portable.BouncyCastle/)

## To do
* Compare file with hash value from text file
* More hash function
* Hash multiple file

## Build with
* [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/)

## Credits
Thanks to [Portable.BouncyCastle](https://github.com/onovotny/bc-csharp)

