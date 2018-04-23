using System;
using System.Windows.Forms;
using System.Drawing.Printing;
using DevExpress.XtraPrinting;
// ...

namespace SelectPrinterInCode {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 rep = new XtraReport1();
            rep.PrintingSystem.StartPrint +=
                new PrintDocumentEventHandler(printingSystem_StartPrint);
            rep.Print();
        }

        private void printingSystem_StartPrint(object sender, PrintDocumentEventArgs e) {
            // set specific printer name
            e.PrintDocument.PrinterSettings.PrinterName =
                PrinterSettings.InstalledPrinters[0];
        }

    }
}