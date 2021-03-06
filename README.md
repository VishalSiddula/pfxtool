# PFX Tool
**by [Aashish Koirala](https://www.aashishkoirala.com/)**

[![Build Status](https://dev.azure.com/aashishkoirala/PFX%20Tool/_apis/build/status/aashishkoirala.pfxtool?branchName=master)](https://dev.azure.com/aashishkoirala/PFX%20Tool/_build/latest?definitionId=3&branchName=master)

**PFX Tool** is a command line tool that does stuff with and around PFX certificates.

## Installation
**PFX Tool** is a [.NET Core Global Tool](https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools) that is built to run against the .NET Core 2.2 runtime. To install:

``` shell
dotnet tool install pfxtool -g
```

## Usage
The basic usage is as follows:

``` shell
pfxtool <command> <options>
```

The following commands are currently supported:
- **import**: Import certificates and keys from a PFX file to a certificate store.
- **export**: Export certificates and keys from a certificate store to a PFX file.
- **remove**: Remove an existing certificate and keys from a certificate store.
- **list**: List all certificates in a certificate store or in a PFX file.
- **show**: Show details of a certificate in a certificate store or in a PFX file.

The following commands are not currently supported but are planned:
- **create**: Create a PFX out of given certificate and key files (a-la *openssl*).
- **explode**: Explode a PFX into its constituent certificate and key files.

For details, run `pfxtool` without any options to get usage instructions.

## Examples

Import *test.pfx* (protected with password *Test123*) into the current user's personal store.

``` shell
pfxtool import --file test.pfx --password Test123 --scope user --store my
```

Export certificate and key with thumbprint *ABCDEF* from the machine's root certificate store into a file *test.pfx*, protecting the private key with password *Test123*.

``` shell
pfxtool export --file test.pfx --password Test123 --scope machine --store root
```

## Issues
To submit any issues, use the **Issues** section in this repository.

## Contributing
Feel free to fork and send PRs - this is pretty small and I haven't had a chance to set up guidelines.

## License
See [LICENSE](LICENSE).