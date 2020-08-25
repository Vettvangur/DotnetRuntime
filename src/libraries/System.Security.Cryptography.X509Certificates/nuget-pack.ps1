nuget restore Net5.X509Certificates.sln
nuget pack .\src\Net5.X509Certificates.csproj -build -Symbols -SymbolPackageFormat snupkg -Properties Configuration=Release
