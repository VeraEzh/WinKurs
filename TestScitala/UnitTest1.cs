using System.Security.Cryptography;
using WinKurs;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestScitala
{
    public class Tests
    {
        Scitala sct;
        [SetUp]
        public void Setup()
        {
            sct = new Scitala(2);
        }
        
        [Test]
        public void Test1()
        {
            string expected = Convert.ToString("пвреит");
            string actual = sct.Encode(Convert.ToString("привет"));
            Assert.AreEqual(expected, actual); //сравнение значений - то, что должно получится и то, что считает программа.
        }

        [Test]
        public void TestEng()
        {
            string expected = Convert.ToString("HWeolrllod !");
            string actual = sct.Encode(Convert.ToString("Hello World!"));
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestBb()
        {
            string expected = Convert.ToString("Цоеилтьь  даилсгцоирпилтимныы  и« Орсенаолвиыз опврыовгартаьм миихр онваа нкиоям»п ь–ю тнеаруеч ивт ьв исдтеу дпернотгорва мсмт.р ");
            string actual = sct.Encode(Convert.ToString("Цель дисциплины «Основы программирования» – научить студентов строить алгоритмы и реализовывать их на компьютере в виде программ."));
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestNumber()
        {
            string expected = Convert.ToString("7д4а1л-и1,  рtаhбeо тeуn dс ");
            string actual = sct.Encode(Convert.ToString("741-1 работу сдали, the end"));
            Assert.AreEqual(expected, actual);
        }
    }
}