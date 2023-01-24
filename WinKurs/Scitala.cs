using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinKurs
{
    public class Scitala
    {
        private int Diam = 0;  // диаметр цилиндра (число строк в матрице)
        private char[,] EMatr = null;  //матрица для записи шифротекста
        private int kk = 0;    //число столбцов в матрице
        private int TxtLen = 0;  //длина сообщения

        public Scitala(int NDiam)
        {//конструктор клаасса 
            if (NDiam <= 0)
            {
                throw new ArgumentException("Диаметр цилиндра шифрования должен быть больше 0");
            }
            Diam = NDiam;
            Clear();
        }

        public void Clear()
        {
            EMatr = null;
            kk = 0;
            TxtLen = 0;
        }

        public int Length()
        {
            return TxtLen;
        }

        public string Encode(string sa)
        {
            if (sa.Length <= 0)
            {
                throw new Exception("Нельзя зашифровать пустую строку!");
            }
            int TLen = sa.Length;
            Clear();
            kk = TLen / Diam;  //сколько столбцов (оборотов) нам нужно при заданном диаметре цилиндра и известном сообщении?
            if ((TLen % Diam) > 0) kk++; //проверка на необходимость для доп. столбца
            TxtLen = Diam * kk;
            while (sa.Length < TxtLen) sa += " ";  //давляем символв в строку шифрования
                                                   //для выравнивания размера матрицы
                                                   //кодирование (размещение в матрице)
            int c = 0;
            EMatr = new char[Diam, kk]; //создание новой матрицы символов 
            for (int i = 0; i < Diam; i++)
            {
                for (int j = 0; j < kk; j++)
                {
                    EMatr[i, j] = sa[c++];
                }
            }
            return CodedTxt();
        }

        public string CodedTxt()
        {
            if (TxtLen == 0)
            {
                return "Нет зашифрованного текста!";
            }
            string s = "";
            for (int i = 0; i < kk; i++)
            { //читаем матрицу в обратном направлении
                for (int j = 0; j < Diam; j++)
                {
                    s += EMatr[j, i];
                }
            }
            return s; // вывод зашифрованного текста
        }

        public string Decode()
        {//не используем (метод читает в изначальном направлении)
            if (TxtLen == 0)
            {
                return "Нет зашифрованного текста!";
            }
            string s = "";
            for (int i = 0; i < Diam; i++)
            {
                for (int j = 0; j < kk; j++)
                {
                    s += EMatr[i, j];
                }
            }
            return s;
        }

        public string DecodePure(string sa)
        {
            if (sa.Length <= Diam)
            {
                throw new Exception("Нельзя расшифровать пустую строку!");
            }
            int TLen = sa.Length;
            int kk = TLen / Diam;  //сколько столбцов (оборотов) нам нужно при заданном диаметре уилиндра и известном сообщении?
            if ((TLen % Diam) > 0) kk++;
            TxtLen = Diam * kk;
            while (sa.Length < TxtLen) sa += " ";  //давляем символв в строку шифрования
                                                   //для выравнивания размера матрицы
                                                   //кодирование (размещение в матрице)
            char[,] EMatr2 = new char[Diam, kk];
            int c = 0;
            for (int i = 0; i < kk; i++)
            {
                for (int j = 0; j < Diam; j++)
                {
                    EMatr2[j, i] = sa[c++];
                }
            } //транспонироваание матрицы
            string s = "";
            for (int i = 0; i < Diam; i++)
            {
                for (int j = 0; j < kk; j++)
                {
                    s += EMatr2[i, j];
                }
            }
            return s; //вывод дешифрованного текста
        }

        //public void TestEMatr()
        //{
        //    Console.WriteLine("TestEMatr:  --- >");
        //    if (TxtLen == 0)
        //    {
        //        Console.WriteLine("а она таки пустая!");
        //    }
        //    else
        //    {
        //        for (int i = 0; i < Diam; i++)
        //        {
        //            for (int j = 0; j < kk; j++)
        //            {
        //                Console.Write(EMatr[i, j]);
        //            }
        //            Console.WriteLine();
        //        }
        //    }
        //    Console.WriteLine("End Test < ---");
        //}

    } //end Scitala
}

