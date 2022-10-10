using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Vasmegye {
    class Program {
        static bool CdvEll() {
            return false;
        }

        static void Main(string[] args) {
            string[] nyersAdat = File.ReadAllLines(@"" + Environment.CurrentDirectory + "/../../vas.txt");
            int[,] tisztaAdat = new int[nyersAdat.Length,3];
            for (int i = 0; i < nyersAdat.Length; i++) {
                string[] temp = nyersAdat[i].Split('-');
                for (int j = 0; j < temp.Length; j++) {
                    tisztaAdat[i, j] = Convert.ToInt32(temp[j]);
                }
            }
            Console.ReadKey();
        }
    }
}
