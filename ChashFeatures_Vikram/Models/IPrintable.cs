using System;

namespace ChashFeatures_Vikram.Models
{
    interface IPrintable
    {
        void GeneratePrint();
        void Generate3DPrint()
        {
            Console.WriteLine("");
        }
        virtual void GeneratePrintVirtual()
        {
            Console.WriteLine("");
        }
        static void GeneratePrintStatic()
        {
            Console.WriteLine("");
        }
    }
}
