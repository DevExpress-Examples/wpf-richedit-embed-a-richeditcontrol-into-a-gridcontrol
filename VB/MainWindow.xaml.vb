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

			Dim invoices As New List(Of Invoice) From {
				New Invoice With {
					.Id = 1,
					.Price = 10D,
					.Description = "{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}{\f1 Consolas;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;\red163\green21\blue21 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\f1\fs18\cf2 Invoice1}\par}"
				},
				New Invoice With {
					.Id = 2,
					.Price = 15D,
					.Description = "{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}{\f1 Consolas;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;\red163\green21\blue21 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\f1\fs18\cf2 Invoice2}\par}"
				},
				New Invoice With {
					.Id = 3,
					.Price = 20D,
					.Description = "{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}{\f1 Consolas;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;\red163\green21\blue21 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\f1\fs18\cf2 Invoice3}\par}"
				}
			}

			gridControl1.ItemsSource = invoices
		End Sub
	End Class

	Public Class Invoice
'INSTANT VB NOTE: The field id was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private id_Conflict As Integer

		Public Property Id() As Integer
			Get
				Return id_Conflict
			End Get
			Set(ByVal value As Integer)
				id_Conflict = value
			End Set
		End Property
'INSTANT VB NOTE: The field price was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private price_Conflict As Decimal

		Public Property Price() As Decimal
			Get
				Return price_Conflict
			End Get
			Set(ByVal value As Decimal)
				price_Conflict = value
			End Set
		End Property
'INSTANT VB NOTE: The field description was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private description_Conflict As String

		Public Property Description() As String
			Get
				Return description_Conflict
			End Get
			Set(ByVal value As String)
				description_Conflict = value
			End Set
		End Property
	End Class
End Namespace
