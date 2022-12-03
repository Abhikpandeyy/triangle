using System;

                    

public class Program

{

    public static void Main(string[] args)

    { int spec,len=1,count;

      Console.WriteLine("Enter the value:" );

      count=Convert.ToInt32(Console.ReadLine());

      spec=count-1;

     
     for(int i=1;i<=count;i++)

     { 

         for(int r=1; r<=spec;r++){

         Console.Write(" ");
         }

         for( int s=1;s<=len;s++)

         { 

             Console.Write("*");

         }
         spec--;

         len=len + 2;

         Console.WriteLine();

        

     }

     Console.ReadLine();

    

}

}



         

         

         