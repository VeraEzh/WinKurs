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
            string expected = Convert.ToString("������");
            string actual = sct.Encode(Convert.ToString("������"));
            Assert.AreEqual(expected, actual); //��������� �������� - ��, ��� ������ ��������� � ��, ��� ������� ���������.
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
            string expected = Convert.ToString("��������  �������������������  � ������������ �������������� ����� ����� ������� ��� �������� ��� �� ������ ������������ ����.� ");
            string actual = sct.Encode(Convert.ToString("���� ���������� ������� ����������������� � ������� ��������� ������� ��������� � ������������� �� �� ���������� � ���� ��������."));
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestNumber()
        {
            string expected = Convert.ToString("7�4�1�-�1,  �t�h�e� �e�n d� ");
            string actual = sct.Encode(Convert.ToString("741-1 ������ �����, the end"));
            Assert.AreEqual(expected, actual);
        }
    }
}