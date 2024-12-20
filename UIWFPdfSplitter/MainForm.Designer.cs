namespace UIWFPdfSplitter;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox txtPdfPath;
    private System.Windows.Forms.Button btnSelectPdf;
    private System.Windows.Forms.TextBox txtOutputFolder;
    private System.Windows.Forms.Button btnSelectOutputFolder;
    private System.Windows.Forms.Button btnSplitPdf;
    private System.Windows.Forms.Label lblPdfPath;
    private System.Windows.Forms.Label lblOutputFolder;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.txtPdfPath = new System.Windows.Forms.TextBox();
        this.btnSelectPdf = new System.Windows.Forms.Button();
        this.txtOutputFolder = new System.Windows.Forms.TextBox();
        this.btnSelectOutputFolder = new System.Windows.Forms.Button();
        this.btnSplitPdf = new System.Windows.Forms.Button();
        this.lblPdfPath = new System.Windows.Forms.Label();
        this.lblOutputFolder = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // txtPdfPath
        // 
        this.txtPdfPath.Location = new System.Drawing.Point(15, 25);
        this.txtPdfPath.Name = "txtPdfPath";
        this.txtPdfPath.Size = new System.Drawing.Size(300, 23);
        this.txtPdfPath.TabIndex = 0;
        // 
        // btnSelectPdf
        // 
        this.btnSelectPdf.Location = new System.Drawing.Point(330, 25);
        this.btnSelectPdf.Name = "btnSelectPdf";
        this.btnSelectPdf.Size = new System.Drawing.Size(75, 23);
        this.btnSelectPdf.TabIndex = 1;
        this.btnSelectPdf.Text = "Выбрать";
        this.btnSelectPdf.UseVisualStyleBackColor = true;
        this.btnSelectPdf.Click += new System.EventHandler(this.btnSelectPdf_Click);
        // 
        // txtOutputFolder
        // 
        this.txtOutputFolder.Location = new System.Drawing.Point(15, 75);
        this.txtOutputFolder.Name = "txtOutputFolder";
        this.txtOutputFolder.Size = new System.Drawing.Size(300, 23);
        this.txtOutputFolder.TabIndex = 2;
        // 
        // btnSelectOutputFolder
        // 
        this.btnSelectOutputFolder.Location = new System.Drawing.Point(330, 75);
        this.btnSelectOutputFolder.Name = "btnSelectOutputFolder";
        this.btnSelectOutputFolder.Size = new System.Drawing.Size(75, 23);
        this.btnSelectOutputFolder.TabIndex = 3;
        this.btnSelectOutputFolder.Text = "Выбрать";
        this.btnSelectOutputFolder.UseVisualStyleBackColor = true;
        this.btnSelectOutputFolder.Click += new System.EventHandler(this.btnSelectOutputFolder_Click);
        // 
        // btnSplitPdf
        // 
        this.btnSplitPdf.Location = new System.Drawing.Point(15, 120);
        this.btnSplitPdf.Name = "btnSplitPdf";
        this.btnSplitPdf.Size = new System.Drawing.Size(390, 30);
        this.btnSplitPdf.TabIndex = 4;
        this.btnSplitPdf.Text = "Разделить PDF";
        this.btnSplitPdf.UseVisualStyleBackColor = true;
        this.btnSplitPdf.Click += new System.EventHandler(this.btnSplitPdf_Click);
        // 
        // lblPdfPath
        // 
        this.lblPdfPath.AutoSize = true;
        this.lblPdfPath.Location = new System.Drawing.Point(15, 7);
        this.lblPdfPath.Name = "lblPdfPath";
        this.lblPdfPath.Size = new System.Drawing.Size(63, 15);
        this.lblPdfPath.TabIndex = 5;
        this.lblPdfPath.Text = "Файл PDF:";
        // 
        // lblOutputFolder
        // 
        this.lblOutputFolder.AutoSize = true;
        this.lblOutputFolder.Location = new System.Drawing.Point(15, 57);
        this.lblOutputFolder.Name = "lblOutputFolder";
        this.lblOutputFolder.Size = new System.Drawing.Size(109, 15);
        this.lblOutputFolder.TabIndex = 6;
        this.lblOutputFolder.Text = "Папка для вывода:";
        // 
        // MainForm
        // 
        this.ClientSize = new System.Drawing.Size(420, 170);
        this.Controls.Add(this.lblOutputFolder);
        this.Controls.Add(this.lblPdfPath);
        this.Controls.Add(this.btnSplitPdf);
        this.Controls.Add(this.btnSelectOutputFolder);
        this.Controls.Add(this.txtOutputFolder);
        this.Controls.Add(this.btnSelectPdf);
        this.Controls.Add(this.txtPdfPath);
        this.Name = "MainForm";
        this.Text = "PDF Splitter";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}