# CSharp Checksum
A simple file checksum for windows using [Portable.BouncyCastle](https://github.com/onovotny/bc-csharp) for hash function.

there's a limit to the size of file to hash, you can change it in the [code](https://github.com/Shiroechi/CSharp-Checksum/blob/3a5ef69f0385abc0363187a3f9918714ff77578c/Source/Forms/ChecksumForm.cs#L8).

**remember the bigger the file size the slower it is**

## Supported hash function
* [SHA-1](https://en.wikipedia.org/wiki/SHA-1)
* [SHA-2](https://en.wikipedia.org/wiki/SHA-2)
* [SHA-3](https://en.wikipedia.org/wiki/SHA-3)
* [Blake2b](https://en.wikipedia.org/wiki/BLAKE_(hash_function))

## Getting Started

### Prerequisites
Before build this project you need to add reference:
* [Portable.BouncyCastle](https://www.nuget.org/packages/Portable.BouncyCastle/)

## To do
* compare file with hash value
* more hash function
* hash multiple file

## Build with
* [Visual Studio 2017 build 15.9](https://visualstudio.microsoft.com/downloads/)

## Credits
Thanks to [Portable.BouncyCastle](https://github.com/onovotny/bc-csharp)

