# cmdline_xlsx_to_pdf
This is a small Commandline app to convert XLSX to PDF using Aspose. Aspose is not a free service. You can use it in Evaluation mode, but if you want to remove the Evaluation text, or use it in any commercial application, you will need to purchase a license. (https://purchase.aspose.com/pricing/)

If you want to add a license, please add it into a file called ```aspose.lic``` into the same path from where the app is running.

Requires .NET 8

## To use:
```
ExcelToPdfConverter.exe path\to\input.xlsx path\to\output.pdf
```

## To build:

```
dotnet build -c Release
```
```
dotnet publish -c Release -r win-x64 --self-contained false
```

## Linx Example:

In the folder LinxXLSXtoPDF there's a Linx 6.10 example of using Linx to populate an Excel Template with data, and then converting the XLSX file to PDF.
