Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Documents
Imports DevExpress.Xpf.RichEdit
Imports DevExpress.XtraRichEdit

Namespace RichInGridColumnWpf
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()

			Dim invoices As New List(Of Invoice) (New Invoice() {New Invoice With {.Id = 1, .Price = 10D, .Description = "{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}{\f1 Consolas;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;\red163\green21\blue21 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\f1\fs18\cf2 Invoice1}\par}"}, New Invoice With {.Id = 2, .Price = 15D, .Description = "{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}{\f1 Consolas;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;\red163\green21\blue21 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\f1\fs18\cf2 Invoice2}\par}"}, New Invoice With {.Id = 3, .Price = 20D, .Description = "{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}{\f1 Consolas;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;\red163\green21\blue21 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\f1\fs18\cf2 Invoice3}\par}"}})

			gridControl1.DataSource = invoices
		End Sub

		Private Sub richEditControl_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim richEditControl As RichEditControl = CType(sender, RichEditControl)

			richEditControl.ShowBorder = False
			richEditControl.ActiveViewType = RichEditViewType.Simple
			richEditControl.HorizontalScrollBarVisibility = System.Windows.Visibility.Collapsed
			richEditControl.VerticalScrollBarVisibility = System.Windows.Visibility.Collapsed

		End Sub
	End Class

	Public Class Invoice
		Private id_Renamed As Integer

		Public Property Id() As Integer
			Get
				Return id_Renamed
			End Get
			Set(ByVal value As Integer)
				id_Renamed = value
			End Set
		End Property
		Private price_Renamed As Decimal

		Public Property Price() As Decimal
			Get
				Return price_Renamed
			End Get
			Set(ByVal value As Decimal)
				price_Renamed = value
			End Set
		End Property
		Private description_Renamed As String

		Public Property Description() As String
			Get
				Return description_Renamed
			End Get
			Set(ByVal value As String)
				description_Renamed = value
			End Set
		End Property
	End Class
End Namespace
