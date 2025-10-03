using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EmailJsonConverter;

class Program
{
    // Maximum file size: 10 MB (reasonable for HTML templates)
    private const long MaxFileSizeBytes = 10 * 1024 * 1024;

    static void Main(string[] args)
    {
        Console.WriteLine("=== Email HTML to JSON Converter ===\n");

        // Get input HTML file path with retry logic
        string inputFile = GetValidInputFilePath(args);

        // Get template name
        string templateName = GetTemplateName(inputFile);
        Console.WriteLine($"Template Name: {templateName}");

        // Get output file path
        string outputFile = GetOutputFilePath(inputFile);
        Console.WriteLine($"Output File: {outputFile}\n");

        try
        {
            // Read the HTML template content
            Console.WriteLine("Reading HTML template...");
            var template = File.ReadAllText(inputFile);

            // Create the JSON term key
            var term = $"Notification.Engine.TemplateHtmlContent.{templateName}";

            // Create JSON object
            var jsonFlat = new JObject();
            jsonFlat.Add(term, template);

            // Serialize to JSON with proper formatting
            var json = JsonConvert.SerializeObject(jsonFlat, Formatting.Indented);

            // Write to output file
            Console.WriteLine("Writing JSON file...");
            File.WriteAllText(outputFile, json);

            Console.WriteLine($"\n✓ Successfully converted '{inputFile}' to '{outputFile}'");
            Console.WriteLine($"✓ JSON key: {term}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n✗ Error: {ex.Message}");
            Environment.Exit(1);
        }
    }

    static string GetValidInputFilePath(string[] args)
    {
        string? inputFile = null;
        bool isFirstAttempt = true;

        // If command-line argument provided, try it first
        if (args.Length > 0)
        {
            inputFile = args[0];
            var validationResult = ValidateFile(inputFile);
            if (validationResult.IsValid)
            {
                return inputFile;
            }
            Console.WriteLine($"✗ Error: {validationResult.ErrorMessage}\n");
            isFirstAttempt = false;
        }

        // Keep asking until a valid file is provided
        while (true)
        {
            if (isFirstAttempt)
            {
                Console.Write("Enter the HTML file path: ");
            }
            else
            {
                Console.Write("Please enter a valid HTML file path (or press Ctrl+C to exit): ");
            }

            inputFile = Console.ReadLine()?.Trim('"', ' ');

            if (string.IsNullOrWhiteSpace(inputFile))
            {
                Console.WriteLine("✗ Error: File path cannot be empty.\n");
                isFirstAttempt = false;
                continue;
            }

            var validationResult = ValidateFile(inputFile);
            if (validationResult.IsValid)
            {
                return inputFile;
            }

            Console.WriteLine($"✗ Error: {validationResult.ErrorMessage}\n");
            isFirstAttempt = false;
        }
    }

    static (bool IsValid, string ErrorMessage) ValidateFile(string filePath)
    {
        // Check if file exists
        if (!File.Exists(filePath))
        {
            return (false, $"File '{filePath}' not found.");
        }

        // Get file info for size validation
        var fileInfo = new FileInfo(filePath);
        var fileSizeMB = fileInfo.Length / (1024.0 * 1024.0);

        // Validate file size
        if (fileInfo.Length > MaxFileSizeBytes)
        {
            return (false, $"File size ({fileSizeMB:F2} MB) exceeds the maximum allowed size of {MaxFileSizeBytes / (1024 * 1024)} MB.");
        }

        // Print validation success
        Console.WriteLine($"✓ File found: {Path.GetFileName(filePath)}");
        Console.WriteLine($"✓ File size: {fileSizeMB:F2} MB (within limit)\n");

        return (true, string.Empty);
    }

    static string GetTemplateName(string inputFile)
    {
        // Extract filename without extension as default template name
        var defaultName = Path.GetFileNameWithoutExtension(inputFile);

        Console.Write($"Enter template name (default: {defaultName}): ");
        var name = Console.ReadLine()?.Trim();

        return string.IsNullOrWhiteSpace(name) ? defaultName : name;
    }

    static string GetOutputFilePath(string inputFile)
    {
        // Get the application's base directory
        var appDirectory = AppDomain.CurrentDomain.BaseDirectory;
        var outputDirectory = Path.Combine(appDirectory, "output-templates");
        
        // Create the output directory if it doesn't exist
        if (!Directory.Exists(outputDirectory))
        {
            Directory.CreateDirectory(outputDirectory);
            Console.WriteLine($"Created output directory: {outputDirectory}");
        }
        
        // Use the input filename to generate output filename
        var inputFileName = Path.GetFileNameWithoutExtension(inputFile);
        var defaultOutput = Path.Combine(outputDirectory, $"{inputFileName}.json");

        Console.Write($"Enter output file path (default: {defaultOutput}): ");
        var path = Console.ReadLine()?.Trim('"', ' ');

        return string.IsNullOrWhiteSpace(path) ? defaultOutput : path;
    }
}
