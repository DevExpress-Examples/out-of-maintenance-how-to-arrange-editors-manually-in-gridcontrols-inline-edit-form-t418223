Imports DevExpress.Xpf.Core

Namespace DXSample

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits DXWindow

        Public Sub New()
            Me.InitializeComponent()
            DataContext = GetRows()
        End Sub
    End Class
End Namespace
