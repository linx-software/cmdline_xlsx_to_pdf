using System;
using System.IO;
using Aspose.Cells;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Usage: ExcelToPdfConverter <input.xls or input.xlsx> [output.pdf]");
            return;
        }

        string inputFilePath = args[0];
        string outputFilePath = args.Length > 1 ? args[1] : System.IO.Path.ChangeExtension(inputFilePath, ".pdf");

        try
        {
            // Load license from file if available and not empty
            string licenseFilePath = "aspose.lic";  // Specify your license file path here
            ApplyLicenseIfAvailable(licenseFilePath);

            // Check if the input file exists
            if (!File.Exists(inputFilePath))
            {
                Console.WriteLine($"Error: The input file '{inputFilePath}' does not exist.");
                return;
            }

            // Load the Excel file (whether it's .xls or .xlsx)
            Workbook workbook = new Workbook(inputFilePath);

            // Force recalculation of all formulas
            workbook.CalculateFormula();

            // Save as PDF
            workbook.Save(outputFilePath, SaveFormat.Pdf);

            Console.WriteLine($"Conversion successful! PDF saved at: {outputFilePath}");
        }
        catch (FileNotFoundException fnfEx)
        {
            Console.WriteLine($"Error: The file '{inputFilePath}' was not found. {fnfEx.Message}");
        }
        catch (UnauthorizedAccessException uaEx)
        {
            Console.WriteLine($"Error: You do not have permission to access the file or folder. {uaEx.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: An unexpected error occurred. {ex.Message}");
        }
    }

    // Method to apply the Aspose license if the file exists and is not empty
    private static void ApplyLicenseIfAvailable(string licenseFilePath)
    {
        try
        {
            // Check if the license file exists and is not empty
            if (File.Exists(licenseFilePath) && new FileInfo(licenseFilePath).Length > 0)
            {
                License license = new License();
                license.SetLicense(licenseFilePath);
                Console.WriteLine("Aspose license applied successfully.");
            }
            else
            {
                Console.WriteLine("License file not found or empty. Using evaluation mode. Please copy license into file named 'aspose.lic'.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error applying Aspose license: {ex.Message}");
        }
    }
}
