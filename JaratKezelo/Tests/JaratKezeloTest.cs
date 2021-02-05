using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace JaratKezelo.Tests
{
    [TestFixture]
    class JaratKezeloTest
    {
        JaratKezelo j;
        [SetUp]
        public void SetUp()
        {
            j = new JaratKezelo();
        }

        [TestCase]
        public void UjJaratFelvetele()
        {
            j.UjJarat("111", "Budapest", "London", new DateTime(2021,5,25,15,0,0));
            j.UjJarat("222", "Bukarest", "Moszkva", new DateTime(2021,5,25,12,0,0));
            j.UjJarat("333", "Kecskemét", "Miami", new DateTime(2021,7,25,12,0,0));
            
        }

        [TestCase]
        public void KesesTeszt()
        {
            j.UjJarat("111", "Budapest", "London", new DateTime(2021, 5, 25, 15, 0, 0));
            j.UjJarat("222", "Bukarest", "Moszkva", new DateTime(2021, 5, 25, 12, 0, 0));
            j.UjJarat("333", "Kecskemét", "Miami", new DateTime(2021, 7, 25, 12, 0, 0));
            j.Keses("111", 5);
            j.Keses("111", 5);
            j.Keses("111", -5);
            j.Keses("222", 15);
            j.Keses("222", -10);
            j.Keses("333", 50);
            j.Keses("333", -5);

        }

        [TestCase]
        public void MikorIndulTeszt()
        {
            j.UjJarat("111", "Budapest", "London", new DateTime(2021, 5, 25, 15, 0, 0));
            j.UjJarat("222", "Bukarest", "Moszkva", new DateTime(2021, 5, 25, 12, 0, 0));
            j.UjJarat("333", "Kecskemét", "Miami", new DateTime(2021, 7, 25, 12, 0, 0));
            j.Keses("111", 5);
            j.Keses("222", 15);
            j.Keses("333", 50);
            j.MikorIndul("111");
            j.MikorIndul("222");
            j.MikorIndul("333");
            Assert.AreEqual(new DateTime(2021, 5, 25, 15, 5, 0), j.MikorIndul("111"));
            Assert.AreEqual(new DateTime(2021, 5, 25, 12, 15, 0), j.MikorIndul("222"));
            Assert.AreEqual(new DateTime(2021, 7, 25, 12, 50, 0), j.MikorIndul("333"));
        }

        [TestCase]
        public void JaratokRepuloTerrolTeszt()
        {
            j.UjJarat("111", "Budapest", "London", new DateTime(2021, 5, 25, 15, 0, 0));
            j.UjJarat("222", "Bukarest", "Moszkva", new DateTime(2021, 5, 25, 12, 0, 0));
            j.UjJarat("333", "Kecskemét", "Miami", new DateTime(2021, 7, 25, 12, 0, 0));

            Assert.AreEqual(new List<string>() {"111"}, j.JaratokRepuloterrol("Budapest"));
            Assert.AreEqual(new List<string>() {"222"}, j.JaratokRepuloterrol("Bukarest"));
            Assert.AreEqual(new List<string>() {"333"}, j.JaratokRepuloterrol("Kecskemét"));
            
        }










    }
}
