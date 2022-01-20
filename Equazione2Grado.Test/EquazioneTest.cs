using Equazione2Grado_Core;
using Xunit;

namespace Equazione2Grado.Test
{
    public class EquazioneTest
    {
        [Fact]
        public void Test1()
        {
            //ARRANGE: PREDISPOSIZIONE DEL TEST/PREREQUISITI 
            Equazione equazione = new Equazione();
            double a = 1;
            double b = -3;
            double c = 2;

            //ACT: CHIAMATA ALLA FUNZIONALITà DA TESTARE
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(a, b, c);

            //ASSERT: VALUTAZIONE DEL RISULTATO ATTESO VS RISULTATO RESTITUITO
            Assert.True(risultato.Length == 2);
            Assert.True(risultato[0] == 1);
            Assert.True(risultato[1] == 2);
            //alternativa con equal
            //Assert.Equal(1, risultato[0]);
            //Assert.Equal(2, risultato[1]);



        }

        [Fact]
        public void Test2()
        {
            //ARRANGE: PREDISPOSIZIONE DEL TEST/PREREQUISITI 
            Equazione equazione = new Equazione();
            double a = 1;
            double b = -5;
            double c = 6;

            //ACT: CHIAMATA ALLA FUNZIONALITà DA TESTARE
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(a, b, c);

            //ASSERT: VALUTAZIONE DEL RISULTATO ATTESO VS RISULTATO RESTITUITO
            Assert.True(risultato.Length == 2);
            Assert.True(risultato[0] == 2);
            Assert.True(risultato[1] == 3);
            //alternativa con equal
            //Assert.Equal(2, risultato[0]);
            //Assert.Equal(3, risultato[1]);



        }
        [Fact]
        public void Test3()
        {
            //ARRANGE: PREDISPOSIZIONE DEL TEST/PREREQUISITI 
            Equazione equazione = new Equazione();
            double a = 1;
            double b = 2;
            double c = 1;

            //ACT: CHIAMATA ALLA FUNZIONALITà DA TESTARE
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(a, b, c);

            //ASSERT: VALUTAZIONE DEL RISULTATO ATTESO VS RISULTATO RESTITUITO
            Assert.True(risultato.Length == 1);
            Assert.True(risultato[0] == -1);
            
            //alternativa con equal
            //Assert.Equal(-1, risultato[0]);
            



        }
        [Fact]
        public void Test4()
        {
            //ARRANGE: PREDISPOSIZIONE DEL TEST/PREREQUISITI 
            Equazione equazione = new Equazione();
            double a = 1;
            double b = -3;
            double c = 10;

            //ACT: CHIAMATA ALLA FUNZIONALITà DA TESTARE
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(a, b, c);

            //ASSERT: VALUTAZIONE DEL RISULTATO ATTESO VS RISULTATO RESTITUITO
            Assert.Null(risultato);



        }


    }
}