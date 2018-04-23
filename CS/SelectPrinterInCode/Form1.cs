using System;
using System.Windows.Forms;
using System.Drawing.Printing;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
// ...

namespace SelectPrinterInCode {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            ReportPrintTool pt = new ReportPrintTool(new XtraReport1());
            pt.PrintingSystem.StartPrint +=
                new PrintDocumentEventHandler(printingSystem_StartPrint);
            pt.Print();
        }

        private void printingSystem_StartPrint(object sender, PrintDocumentEventArgs e) {
            // Set the printer name.
            e.PrintDocument.PrinterSettings.PrinterName =
                PrinterSettings.InstalledPrinters[0];
        }

    }
}