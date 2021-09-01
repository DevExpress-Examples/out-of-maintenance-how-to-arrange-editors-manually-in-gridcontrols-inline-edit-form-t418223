Imports DevExpress.Xpf.Core

Namespace DXSample
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits DXWindow

		Public Sub New()
			InitializeComponent()
			DataContext = DataHelper.GetRows()
		End Sub
	End Class
End Namespace
