using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Reflection.PortableExecutable;

namespace UIWFPdfSplitter;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }
    private void btnSelectPdf_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory; 
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPdfPath.Text = openFileDialog.FileName;
            }
        }
    }

    private void btnSelectOutputFolder_Click(object sender, EventArgs e)
    {
        using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
        {
            folderDialog.SelectedPath = AppDomain.CurrentDomain.BaseDirectory;
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txtOutputFolder.Text = folderDialog.SelectedPath;
            }
        }
    }

    private void btnSplitPdf_Click(object sender, EventArgs e)
    {
        string inputFilePath = txtPdfPath.Text;
        string outputFolder = txtOutputFolder.Text;

        if (string.IsNullOrWhiteSpace(inputFilePath) || string.IsNullOrWhiteSpace(outputFolder))
        {
            MessageBox.Show("Пожалуйста, выберите PDF-файл и папку для сохранения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            using (PdfDocument inputDocument = PdfReader.Open(inputFilePath, PdfDocumentOpenMode.Import))
            {
                for (int i = 0; i < inputDocument.PageCount; i++)
                {
                    PdfDocument outputDocument = new PdfDocument();
                    outputDocument.AddPage(inputDocument.Pages[i]);

                    string outputFilePath = Path.Combine(outputFolder, $"Page-{i + 1}.pdf");
                    outputDocument.Save(outputFilePath);
                }
            }

            MessageBox.Show("PDF успешно разделён на страницы!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}
