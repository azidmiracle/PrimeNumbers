using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrimeNumbers[0] = 2;//put the value 2 to index 0. First Prime number is 2

            CreatePrime();//create prime numbers

            string str = "";

            foreach (double element in PrimeNumbers)
            {
                str = str + element.ToString() + "  " ;
            }


            MessageBox.Show(str);

            //PrimeFactors(600851475143, 0);

           // MessageBox.Show(factors);
        }


        float[] PrimeNumbers = new float[400];//size of an array

        int pointer = 1;//next available index in array

        public void CreatePrime()
        {
            //if(num>= 10000)
            //{
            //    return;
            //}

            for (float num=3;num< 1000; num++)
            {
                int index = 0;

                float modulo = num % PrimeNumbers[index];//get the modulo

                while (modulo != 0 && index < pointer)//increment the index until modulo 0 is encountered
                {
                    index++;


                    if (index >= pointer)//if number has no modulo of 0
                    {
                        PrimeNumbers[pointer] = num;//then it is prime number
                        pointer++;//increment the poiner
                        num = num + 1;//increment the number

                        break;//exit the loop
                    }


                        modulo = num % PrimeNumbers[index];


                    
                }

            }
  

            //CreatePrime(num);

        }

        //Largest prime factor
        //The prime factors of 13195 are 5, 7, 13 and 29.

        // What is the largest prime factor of the number 600851475143 ?


        string factors = "";

        public void PrimeFactors(float num,int index)//get the prime factors
        {
                 
            if (index >= pointer)
            {
                return;
            }

            float quotient = num / PrimeNumbers[index];
            float modulo = num % PrimeNumbers[index];

            while (modulo != 0 && index < pointer)
            {
                index++;

                if (index >= pointer)
                {
                    break;
                }

                modulo = num % PrimeNumbers[index];
                quotient = num / PrimeNumbers[index];
            }

            if (modulo == 0)
            {
                factors = factors + PrimeNumbers[index].ToString() + "  ";
                num = quotient;
                index++;
            }

            PrimeFactors(num, index);

        }

    }
}
