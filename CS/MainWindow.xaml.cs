using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using DevExpress.Xpf.RichEdit;
using DevExpress.XtraRichEdit;

namespace RichInGridColumnWpf {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            List<Invoice> invoices = new List<Invoice> { 
                new Invoice { Id = 1, Price = 10m, Description = @"{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}{\f1 Consolas;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;\red163\green21\blue21 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\f1\fs18\cf2 Invoice1}\par}" } ,
                new Invoice { Id = 2, Price = 15m, Description = @"{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}{\f1 Consolas;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;\red163\green21\blue21 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\f1\fs18\cf2 Invoice2}\par}" } ,
                new Invoice { Id = 3, Price = 20m, Description = @"{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}{\f1 Consolas;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;\red163\green21\blue21 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\f1\fs18\cf2 Invoice3}\par}" } 
            };

            gridControl1.ItemsSource = invoices;
        }
    }

    public class Invoice {
        private int id;

        public int Id {
            get { return id; }
            set { id = value; }
        }
        private decimal price;

        public decimal Price {
            get { return price; }
            set { price = value; }
        }
        private string description;

        public string Description {
            get { return description; }
            set { description = value; }
        }
    }
}
