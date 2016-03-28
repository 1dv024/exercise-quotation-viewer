# Lösning

___Program.cs___

Som synes är filhantering inte på något sätt komplicerat. Det viktigaste du behöver ta med dig från denna övning är att **alltid använda ett using-block** runt din filhanteringskod. 

Förstås är också felhanteringen viktig! Mer eller mindre beroende på aktuell tillämpning men oftast mer, eftersom det finns en hel del detaljer som kan gå fel när vi sysslar med filer ...

```c#
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
```

Klassdiagrammets första sektion ("Fields") ger de två privata fälten ```_count``` och ```_quotation``` samt dess typer (```int``` och ``` string```). Under rubriken "Properties" i klassdiagrammet hittar du de två publika egenskaperna som kapslar in respektive fält.

I avsnittet "Methods" finns de två konstruktorerna som ska implementeras. Observera att konstruktorer saknar returvärde och måste ha samma namn som klassen. Det som skiljer konstruktorerna åt är deras signaturer, dvs. namnet på konstruktorn och dess parameterlista. Titta gärna i metoden ```Main``` hur respektive konstruktor används.

Den publika metoden ```View``` skriver helt enkelt ut datat, som det privata fältet ```_quotation``` innehåller, ```_count``` gånger. Hur utskriften ska ske torde framgå av Figur 1.