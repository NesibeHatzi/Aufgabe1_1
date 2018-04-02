using System;

namespace Aufgabe1_1
{
    
       
    class Program
    {
     
    

        

        public static double getCubeSurface(double durchmesse)
        {
            double d = durchmesse;
            double A =  6 * Math.Pow(d, 2);
                return A;
        }

        public static double getCubeVolume(double durchmesse)
        {
            double d = durchmesse;
            double V = Math.Pow(d, 3);
                return V;
        }
        public static String getCubeInfo(double durchmesse)
        {
            double d = durchmesse;
                Console.WriteLine("Würfel: " + " A = " + getCubeSurface(d) + " | " + " V = " + getCubeVolume(d) );
        }

        public static double getBulletSurface(double durchmesse)
        {
            double d = durchmesse;
            double A = 3.14 * Math.Pow(d, 2);
                return A;
        }

        public static double getBulletVolume(double durchmesse)
        {
            double d = durchmesse;
            double V = (3.14 * Math.Pow(d, 3)) / 6;
            return V;
        }
        public static String getBulletInfo(double durchmesse)
        {
           double d = durchmesse;
                Console.WriteLine("Kugel: " + " A = " + getBulletSurface(d) + " | " + " V = " + getBulletVolume(d) );
        }

        public static double getOctahedronSurface(double durchmesse)
        {
           double d = durchmesse;
           double A = 2 * Math.Sqrt(3) * Math.Pow(d, 2);
            return A;
        }

        public static double getOctahedronVolume(double durchmesse)
        {
           double d = durchmesse;
           double V = (Math.Sqrt(2) * Math.Pow(d, 3)) / 3;
            return V ;
        }

        public static String getOctahedronInfo(double durchmesse)
        {
           double d = durchmesse;
           
             Console.WriteLine(" Oktaeder: " + " A = " + getOctahedronSurface(d) + " | " + " V = " + getOctahedronVolume(d) );
        }
        static void Main(char [] args)
        {

        char w = 'w';
        char k = 'k';
        char o = 'o';
        
        var console = (args[0]);
        var nummer = (args[1]); 
        double d = Convert.ToDouble(nummer);
             if (w == console){
                getCubeInfo(d);
            }else if( k == console ){
                getBulletInfo(d);
            }else if( o == console ){
                getOctahedronInfo(d);
            }else{
    Console.WriteLine("false");
            }
        }
    }
}