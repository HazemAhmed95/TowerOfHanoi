# TowerOfHanoi
Algorithm for Tower of Hanoi Problem using C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the hight");
            int hight = int.Parse(Console.ReadLine());

            Move(hight, 1, 2, 3);
        }


        public static void Move(int hight, int TowerA, int TowerB, int TowerC)
        {
            
            if (hight > 0)
            {
                /* move the disk hight -1 from tower A to Tower B using the tower C in the case of 3+
                 * 
                 * for example if you you have tower of 4 you and you know how to move 3 paltes to the B tower then move
                 * the largest plate to C tower then move the rest of the sorted plates from B to C this will solve it recursively
                */
                //Move(hight - 1, from_towerA, using_TowerC, to_TowerB);
                Move(hight - 1, TowerA, TowerC, TowerB);
                Console.WriteLine("moved the disk from {0} to {1}",TowerA,TowerC);
                // move H-1 from B to C using A to complete
                Move(hight - 1, TowerB, TowerA, TowerC);
 //this will deal as its one plate in the whole game per time 
            }
           
            
        }
    
    
    
    }
}
