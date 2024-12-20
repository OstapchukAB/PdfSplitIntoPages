using System;
using System.IO;
using System.Reflection.PortableExecutable;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

class Program
{
    static void Main(string[] args)
    {
        // Укажите путь к исходному PDF-файлу
        string inputFilePath = @"input.pdf";

        // Папка для сохранения страниц
        string outputFolder = @"OutputPages";

        // Создаем папку, если она не существует
        if (!Directory.Exists(outputFolder))
        {
            Directory.CreateDirectory(outputFolder);
        }

        try
        {
            // Загружаем исходный PDF
            using (PdfDocument inputDocument = PdfReader.Open(inputFilePath, PdfDocumentOpenMode.Import))
            {
                // Проходим по страницам и сохраняем каждую отдельно
                for (int i = 0; i < inputDocument.PageCount; i++)
                {
                    PdfDocument outputDocument = new PdfDocument();
                    outputDocument.AddPage(inputDocument.Pages[i]);

                    // Формируем имя файла для сохранения страницы
                    string outputFilePath = Path.Combine(outputFolder, $"Page-{i + 1}.pdf");

                    // Сохраняем отдельную страницу
                    outputDocument.Save(outputFilePath);
                    Console.WriteLine($"Страница {i + 1} сохранена: {outputFilePath}");
                }
            }

            Console.WriteLine("Все страницы успешно сохранены.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
