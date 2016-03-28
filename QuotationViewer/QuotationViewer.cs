using System;

namespace QuotationViewer
{
    class QuotationViewer
    {
        // Fält
        private string _quotation;
        private int _count;

        // Konstruktorer
        public QuotationViewer()
        {
            Quotation = null;
            Count = 0;
        }

        public QuotationViewer(string quotation, int count)
        {
            Quotation = quotation;
            Count = count;
        }

        // Egenskaper
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public string Quotation
        {
            get { return _quotation; }
            set { _quotation = value; }
        }

        //Metod
        public void View()
        {
            Console.WriteLine("-----");
            for (int i = 0; i < _count; ++i)
            {
                Console.WriteLine(_quotation);
            }
            Console.WriteLine();
        }
    }
}
