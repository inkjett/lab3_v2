﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace Lab3
{
    public partial class Form1 : Form
    {
        Int32[] a;
        ArrayList c,d, temp_arr = new ArrayList();
        Int32 i1, i2,temp;
        
        
        Int32 Count = 0;
        public void gen_arr(Int32 a, Int32 b, ref Int32[] A) // метод заполнения массивва
        {
            Random D = new Random();
            for (Byte i = 0; i < A.Length; i++)
                A[i] = D.Next(a, b);
                    }

        public void arr_out(Int32[] A, TextBox b) // метод вывода данных о массиве
        {
            b.Text = "";
            foreach (Int32 a in A)
                b.Text += String.Format("{0}", a) + " ";
        }


        public void arr_out2(ArrayList C, TextBox b) // метод вывода данных о массиве ArrayList
        {
           b.Text = "";
           foreach (int c in C)
           b.Text += String.Format("{0}", c) + " ";
        }

        public void max_arr (ArrayList F, ref ArrayList D)
        {
            Int32 firstNumber,secondNumber;
            foreach (int f in F)
            {
                secondNumber = Convert.ToInt32(F[f]) % 10;

            }

        }    
            
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Int32 c = Int32.Parse(textBox2.Text); //диапазон значений начало
            Int32 d = Int32.Parse(textBox3.Text); // диапазон значений конец
            Byte n = Byte.Parse(textBox1.Text); // количество чисел в массиве
            a = new Int32[n]; // инициализация массива, заполнен 0
            gen_arr(c, d, ref a); // передача в метод данных о массиве
           // arr_out(a, textBox4); // вывод данных из масиива в текст

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //textBox5.Text = String.Format("{0}", a.Length);
                        Int32 i = 0;
            Count = 0;
            while (i < a.Length)
            {
                if (a[i]>9&&a[i]<100)
                { Count++; }
                i++;
            }
            textBox6.Text = String.Format("{0}", Count);


        }


        private void button3_Click(object sender, EventArgs e)
        {
            arr_out(a, textBox4); // вывод данных из масиива в текст

        }

        private void button5_Click(object sender, EventArgs e)
        {
            c = new ArrayList(a);
            c.CopyTo(a,0);
            Int32 i = 0;
            Int32 i2 = 0;
            Int32 max = 0;
            //textBox8.Text = String.Format("{0}", c.Count); 
            while (i < c.Count)
            {
                if (max < Convert.ToInt32(c[i]))
                {
                    max = Convert.ToInt32(c[i]);
                }
                i++;
            }
            while (i2< c.Count)
            {
            if(Convert.ToInt32(c[i2]) == max)
                {
                    c.RemoveAt(i2);

                }
                i2++;
            }

            arr_out2(c, textBox8);


        }

        private void button6_Click(object sender, EventArgs e)
        {

            arr_out2(c, textBox8);









        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Int32 i;
            i1 = a.Length / 2 - 1;
            i2 = a.Length - 3;
            for (i = 0; i < 3; i++)
            {
                temp = a[i1];
                a[i1] = a[i2];
                a[i2] = temp;
                i1++;
                i2++;
            }
            arr_out(a, textBox7);

        }
    }
}