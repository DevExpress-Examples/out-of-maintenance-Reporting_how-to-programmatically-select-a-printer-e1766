Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
' ...

Namespace SelectPrinterInCode
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim pt As New ReportPrintTool(New XtraReport1())
			AddHandler pt.PrintingSystem.StartPrint, AddressOf printingSystem_StartPrint
			pt.Print()
		End Sub

		Private Sub printingSystem_StartPrint(ByVal sender As Object, ByVal e As PrintDocumentEventArgs)
			' Set the printer name.
			e.PrintDocument.PrinterSettings.PrinterName = PrinterSettings.InstalledPrinters(0)
		End Sub

	End Class
End Namespace