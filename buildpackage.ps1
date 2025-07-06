$version = "1.0.0"
dotnet pack -c Release -p:PackageVersion=$version
Copy-Item -Path "bin\Release\Cypherly.Message.Contracts.$version.nupkg" -Destination "C:\NuGetPackages"
