nuget restore Net5.X509Certificates.sln
nuget pack .\src\Net5.X509Certificates.nuspec -build -Symbols -SymbolPackageFormat snupkg -Properties Configuration=Release
