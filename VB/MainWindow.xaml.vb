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

            Dim invoices As New List(Of Invoice) From { _
                New Invoice With { _
                    .Id = 1, _
                    .Price = 10D, _
                    .Description = "{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}{\f1 Consolas;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;\red163\green21\blue21 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\f1\fs18\cf2 Invoice1}\par}" _
                }, _
                New Invoice With { _
                    .Id = 2, _
                    .Price = 15D, _
                    .Description = "{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}{\f1 Consolas;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;\red163\green21\blue21 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\f1\fs18\cf2 Invoice2}\par}" _
                }, _
                New Invoice With { _
                    .Id = 3, _
                    .Price = 20D, _
                    .Description = "{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}{\f1 Consolas;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;\red163\green21\blue21 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\f1\fs18\cf2 Invoice3}\par}" _
                } _
            }

            gridControl1.ItemsSource = invoices
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
