using HTMLTagBuilder.Tags;
using System;

namespace HTMLTagBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseTag bt = new BaseTag(null);
            bt.Div().Id("teste").Div().Id("ee").Div().Close().Span().Close().Span().Div().Id("r").Close().Div().Id("id2");
            Console.WriteLine(bt);
            Console.ReadKey();
        }
    }
}
