using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fermat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Solve_Click(object sender, EventArgs e) {
            string inNum = input.Text;
            string kNum = K.Text;

            int x = Convert.ToInt32(inNum);
            int k = Convert.ToInt32(kNum);
            
            Output.Text = primalityTest(x, k);
            
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
           
        }

        private string primalityTest(int x, int k) {
            Random rand = new Random();
            HashSet<int> valueSet = new HashSet<int>();
            bool test = true;
            
            /*This for loop is to see if a^(n-1) == 1
             * for k values 1 <= a < N */
            for(int i = 0; i < k; i++) {

                int randNum = rand.Next(1, x);
                while (valueSet.Contains(randNum)) {//check for uniqueness
                    randNum = rand.Next(1, k);
                }

                valueSet.Add(randNum);//add to valueSet once it's found unique

                //This will recurse down
                int result = modExp(randNum, (x - 1), x);//n^3

               if(result != 1) {
                    test = false;
                    break;
                }
            }

            if(test == false) {//Not Prime branch
                return "No, definitely not Prime";
            }
            else {//prime branch which also shows probability of correctness
                return "Yes it is Prime, with Probability " + Convert.ToString(1 - (1 / Math.Pow(2, k)));
            }
        }

        private int modExp(int x, int y, int n) {
            if(y == 0) {//constant
                return 1;
            }

            /*This is where it will recurse down. There will
            be n recursive steps*/
            int z = modExp(x, (y / 2), n);
            
            if(y % 2 == 0) {//Checking if even. This is constant
                return Convert.ToInt32(Math.Pow(z, 2)) % n;//n^2
            }
            else {//Will go to this branch if y is odd
                return (x * Convert.ToInt32(Math.Pow(z, 2)))  % n;//n^2
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
