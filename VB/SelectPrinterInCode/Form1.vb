Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting
' ...

Namespace SelectPrinterInCode
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim rep As New XtraReport1()
			AddHandler rep.PrintingSystem.StartPrint, AddressOf printingSystem_StartPrint
			rep.Print()
		End Sub

		Private Sub printingSystem_StartPrint(ByVal sender As Object, ByVal e As PrintDocumentEventArgs)
			' set specific printer name
			e.PrintDocument.PrinterSettings.PrinterName = PrinterSettings.InstalledPrinters(0)
		End Sub

	End Class
End Namespace