using Microsoft.VisualStudio.TestTools.UnitTesting;
using OperationLibrary;

namespace OperationTests
{
    [TestClass]
    public class GestioneTests
    {
        [TestMethod]
        public void SommaTest()
        {
            int a = 3;
            int b = 4;
            int risultato_aspettato = 7;
            int risultato_effettivo = Gestione.Somma(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
        [TestMethod]
        public void SommaTestNegativi()
        {
            int a = -3;
            int b = -2;
            int risultato_aspettato = -5;
            int risultato_effettivo = Gestione.Somma(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
        [TestMethod]
        public void SommaTestNulli()
        {
            int a = 0;
            int b = 0;
            int risultato_aspettato = 0;
            int risultato_effettivo = Gestione.Somma(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
        [TestMethod]
        public void SommaTestNulloNeg()
        {
            int a = 0;
            int b = -4;
            int risultato_aspettato = -4;
            int risultato_effettivo = Gestione.Somma(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }


        [TestMethod]
        public void SottrazioneTestNegativi()
        {
            int a = 3;
            int b = 4;
            int risultato_aspettato = -1;
            int risultato_effettivo = Gestione.Sottrazione(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
        [TestMethod]
        public void SottrazioneTestNegativi2()
        {
            int a = -3;
            int b = -2;
            int risultato_aspettato = -1;
            int risultato_effettivo = Gestione.Sottrazione(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
        [TestMethod]
        public void SottrazioneTestNullo()
        {
            int a = 0;
            int b = 0;
            int risultato_aspettato = 0;
            int risultato_effettivo = Gestione.Sottrazione(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
        [TestMethod]
        public void SottrazioneTestNulloPos()
        {
            int a = 0;
            int b = -4;
            int risultato_aspettato = 4;
            int risultato_effettivo = Gestione.Sottrazione(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }


        [TestMethod]
        public void MoltiplicazioneTest()
        {
            int a = 3;
            int b = 4;
            int risultato_aspettato = 12;
            int risultato_effettivo = Gestione.Moltiplicazione(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
        [TestMethod]
        public void MoltiplicazioneTestPos()
        {
            int a = -3;
            int b = -2;
            int risultato_aspettato = 6;
            int risultato_effettivo = Gestione.Moltiplicazione(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
        [TestMethod]
        public void MoltiplicazioneTestNullo()
        {
            int a = 0;
            int b = 0;
            int risultato_aspettato = 0;
            int risultato_effettivo = Gestione.Moltiplicazione(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
        [TestMethod]
        public void MoltiplicazioneTestNulloPos()
        {
            int a = 0;
            int b = -4;
            int risultato_aspettato = 0;
            int risultato_effettivo = Gestione.Moltiplicazione(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }


        [TestMethod]
        public void DivisioneTest()
        {
            double a = 3;
            double b = 4;
            double risultato_aspettato = 0.75;
            double risultato_effettivo = Gestione.Divisione(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
        [TestMethod]
        public void DivisioneTestPos()
        {
            double a = -3;
            double b = -2;
            double risultato_aspettato = 1.5;
            double risultato_effettivo = Gestione.Divisione(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
        [TestMethod]
        public void DivisioneTestNullo()
        {
            double a = 0;
            double b = 0;
            double risultato_aspettato = double.NaN;
            double risultato_effettivo = Gestione.Divisione(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
        [TestMethod]
        public void DivisioneTestNulloPos()
        {
            double a = 0;
            double b = -4;
            double risultato_aspettato = 0;
            double risultato_effettivo = Gestione.Divisione(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
    }
}

