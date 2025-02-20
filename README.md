# CMDlineAppXLSXtoPDF
Commandline app to convert XLSX to PDF using Aspose. Aspose is not a free service. You can use it in Evaluation mode, but if you want to remove the Evaluation text, or use it in any commercial sense, you need to purchase a license. 

If you want to add a license, please add it into a file called ```aspose.lic``` into the same path from where the app is running.

Requires .NET 8

## To build:

```
dotnet build -c Release
```
```
dotnet publish -c Release -r win-x64 --self-contained false
```

## To use:
```
ExcelToPdfConverter.exe path\to\input.xlsx path\to\output.pdf
```
