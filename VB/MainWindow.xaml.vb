Imports System.Collections.Generic
Imports System.Windows

Namespace RichInGridColumnWpf

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Dim invoices As List(Of Invoice) = New List(Of Invoice) From {New Invoice With {.Id = 1, .Price = 10D, .Description = "{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}{\f1 Consolas;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;\red163\green21\blue21 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\f1\fs18\cf2 Invoice1}\par}"}, New Invoice With {.Id = 2, .Price = 15D, .Description = "{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}{\f1 Consolas;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;\red163\green21\blue21 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\f1\fs18\cf2 Invoice2}\par}"}, New Invoice With {.Id = 3, .Price = 20D, .Description = "{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}{\f1 Consolas;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;\red163\green21\blue21 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\f1\fs18\cf2 Invoice3}\par}"}}
            Me.gridControl1.ItemsSource = invoices
        End Sub
    End Class

    Public Class Invoice

        Private idField As Integer

        Public Property Id As Integer
            Get
                Return idField
            End Get

            Set(ByVal value As Integer)
                idField = value
            End Set
        End Property

        Private priceField As Decimal

        Public Property Price As Decimal
            Get
                Return priceField
            End Get

            Set(ByVal value As Decimal)
                priceField = value
            End Set
        End Property

        Private descriptionField As String

        Public Property Description As String
            Get
                Return descriptionField
            End Get

            Set(ByVal value As String)
                descriptionField = value
            End Set
        End Property
    End Class
End Namespace
