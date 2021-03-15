using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquzioniLibrary.Test
{
    [TestClass]
    public class EquazioniTest
    {
        [TestMethod]
        public void Determined()
        {
            double a = 1;
            bool valoreaspettato = true;
            bool risultato = Equazioni.IsDetermined(a);
            Assert.AreEqual(valoreaspettato, risultato);
        }

        [TestMethod]
        public void Determined1()
        {
            double a = 0;
            bool valoreaspettato = false;
            bool risultato = Equazioni.IsDetermined(a);
            Assert.AreEqual(valoreaspettato, risultato);
        }

        [TestMethod]
        public void Impossible()
        {
            double b = 1;
            double a = 1;
            bool valoreaspettato = false;
            bool risultato = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(valoreaspettato, risultato);
        }

        [TestMethod]
        public void Impossible1()
        {
            double b = 0;
            double a = 0;
            bool valoreaspettato = true;
            bool risultato = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(valoreaspettato, risultato);
        }

        [TestMethod]
        public void IsDegree2()
        {
            double a = 0;
            bool valoreaspettato = false;
            bool risultato = Equazioni.IsDegree2(a);
            Assert.AreEqual(valoreaspettato, risultato);
        }

        [TestMethod]
        public void IsDegree1()
        {
            double a = 2;
            bool valoreaspettato = true;
            bool risultato = Equazioni.IsDegree2(a);
            Assert.AreEqual(valoreaspettato, risultato);
        }

        [TestMethod]
        public void Delta()
        {
            int a = 3;
            int b = 2;
            int c = 4;
            int valoreaspettato = -44;
            double risultato = Equazioni.Delta(a, b, c);
            Assert.AreEqual(valoreaspettato, risultato);
        }

        [TestMethod]
        public void Delta1()
        {
            int a = 3;
            int b = 5;
            int c = 6;
            int valoreaspettato = -47;
            double risultato = Equazioni.Delta(a, b, c);
            Assert.AreEqual(valoreaspettato, risultato);
        }

        [TestMethod]
        public void DeltaUguale0()
        {
            int a = 4;
            int b = 20;
            int c = 25;
            int valoreaspettato = 0;
            double risultato = Equazioni.Delta(a, b, c);
            Assert.AreEqual(valoreaspettato, risultato);
        }

        [TestMethod]
        public void EquazioneSecondoGrado()
        {
            int a = 1;
            int b = 3;
            int c = 2;
            string valoreaspettato = "x1 - -2 x2 - -1";
            string risultato = Equazioni.EquazioneSecondo(a, b, c);
            Assert.AreEqual(valoreaspettato, risultato);
        }
        [TestMethod]
        public void EquazioneSecondoGrado1()
        {
            int a = 1;
            int b = -2;
            int c = 1;
            string valoreaspettato = "x - 0";
            string risultato = Equazioni.EquazioneSecondo(a, b, c);
            Assert.AreEqual(valoreaspettato, risultato);
        }

        [TestMethod]
        public void EquazionePrimoGrado()
        {
            int a = 5;
            int b = 10;
            string valoreaspettato = "x - 2";
            string risultato = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(valoreaspettato, risultato);
        }

        [TestMethod]
        public void AssertIsTrue()
        {
            double a = 1;
            bool valoreaspettato = true;
            bool risultato = Equazioni.IsDetermined(a);
            Assert.IsTrue(risultato);
        }

        [TestMethod]
        public void AssertIsFalse()
        {
            double a = 0;
            bool valoreaspettato = false;
            bool risultato = Equazioni.IsDetermined(a);
            Assert.IsFalse(risultato);
        }





    }
}
