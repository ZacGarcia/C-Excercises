using System;


internal class Program
{
    private static void Main(string[] args)
    {


        //FIBONACCI SEQUENCE TRIANGLE
        Console.WriteLine("---FIBONACCI SEQUENCE TRIANGLE---");
        int fibRange, fibNum1, fibNum2, fibNum3, fib_i, fib_j;
        Console.Write("Input range: ");
        fibRange = Convert.ToInt32(Console.ReadLine());
        for (fib_i = fibRange; fib_i > 0; fib_i--)
        {
            fibNum1 = 0;
            fibNum2 = 1;
            fibNum3 = 0;
            for (fib_j = fib_i; fib_j <= fibRange; fib_j++)
            {
                Console.Write(fibNum2 + " ");
                fibNum3 = fibNum1 + fibNum2;
                fibNum1 = fibNum2;
                fibNum2 = fibNum3;
            }
            Console.Write("\n");
        }

        
        //NUMBER TRIANGLE

        Console.WriteLine("--NUMBER TRAINGLE---");
        int numT, numT_i, numT_j, numT_k, numT_r, numT_temp=1;
        Console.Write("\nInput a range: ");
        numT = Convert.ToInt32(Console.ReadLine());
        numT_r = numT;
        for(numT_i=numT; numT_i>0; numT_i--){
            for(numT_j=numT_i; numT_j>0; numT_j--){
                Console.Write(" ");
            }
            numT_temp = 1;
            for(numT_k=numT_i; numT_k<=numT_r; numT_k++){
                Console.Write(numT_temp);
                if(numT_k<numT){
                    numT_temp++;
                }
                else{
                    numT_temp--;
                }
            }
            numT_r++;
            Console.Write("\n");

        }



        
         //ALPHABET TRIANGLE
        Console.WriteLine("---ALPHABET TRIANGLE---");
        char alphChar='A';
        int alphCnter,alph_I, alph_J, alph_T=5;
        for(alphCnter=5; alphCnter>0; alphCnter--){
            for(alph_I=alphCnter; alph_I>0; alph_I--){
                Console.Write(" ");
            }
            alphChar='A';
            for(alph_J=alphCnter; alph_J<=alph_T; alph_J++){
                Console.Write(alphChar);
                if(alph_J<5){
                    alphChar++;                    
                }
                else{
                    alphChar--;                    
                }
            }
            alph_T++;
            
            Console.Write("\n");
        }
        

        //FIBONACCI SEQUENCE
        Console.Write("---FIBONACCI SEQUENCE---\n");
        int a = 0, b = 1, c = 0;
        Console.Write(a+ " " +b+ " ");
        
        for (int i = 2; i < 10; i++)
        {
            c = a + b;
            Console.Write(c+ " ");
            a = b;
            b = i;
        }
        Console.WriteLine(" ");

        //PRIME NUMBER
        Console.Write("---PRIME NUMBER---");
        int num, m=1, count=0;

        Console.Write("\nInput a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        while(m<num){
            if(num%m == 0){
                count++;
            }
            m++;
        }
        if(count == 1){
            Console.WriteLine(num+ " is a Prime Number.");
            
        }
        else{
            Console.WriteLine(num+ " is not a Prime Number.");
        }

        //PALINDROME
        Console.Write("---PALINDROME NUMBER---");

        int pnum, c1, ptemp, palindrome=0;
        Console.Write("\nInput a three digit number: ");
        pnum = Convert.ToInt32(Console.ReadLine());
        ptemp = pnum;
        while(pnum > 0){
            c1=pnum%10;
            palindrome = (palindrome*10) + c1;
            pnum = pnum/10;
                       
        }
        if(ptemp==palindrome){
            Console.WriteLine(palindrome+ " is a Palindrome number.");
        }
        else{
            Console.WriteLine(palindrome+ " is not a Palindrome number.");
        }

        //FACTORIAL
        Console.Write("---FACTORIAL NUMBER---");
        int facNum, prodNum=1;
        Console.Write("\nInput a number: ");
        facNum = Convert.ToInt32(Console.ReadLine());
        
        while(facNum!=0){
            prodNum = prodNum*facNum;
            facNum--;
        }
        Console.WriteLine(prodNum+ " is the Factorial");

        // ARMSTRONG NUMBER
        Console.Write("---ARMSTRONG NUMBER---");
        int armNum, armProd=0, armTemp, armMod;
        Console.Write("\nInput a number: ");

        armNum = Convert.ToInt32(Console.ReadLine());
        armTemp = armNum;
        while(armNum>0){
            armMod = armNum%10;
            armNum = armNum/10;
            armProd = armProd + (armMod * armMod * armMod);
        }
        if(armTemp == armProd){
            Console.WriteLine(armProd+ " is an Armstrong number.");
        }
        else{
            Console.WriteLine(armProd+ " is not an Armstrong number.");
        }

        //SUM OF DIGITS
        Console.Write("---SUM OF DIGITS---");
        int digNum, digSum = 0, digMod;
        Console.Write("\nInput a number: ");
        digNum = Convert.ToInt32(Console.ReadLine());

        while(digNum>0){
            digMod = digNum%10;
            digSum = digSum + digMod;
            digNum = digNum/10;
        }
        Console.WriteLine(digSum+ " is the Sum of the digits.");


        //REVERSE NUMBERS
        Console.Write("---REVERSE NUMBER---");
        int revNum, revMod, revProd=0;
        Console.Write("\nInput a number: ");
        revNum = Convert.ToInt32(Console.ReadLine());

        while(revNum>0){
            revMod = revNum%10;
            revProd = (revProd*10)+revMod;
            revNum = revNum/10;
        }
        Console.WriteLine(revProd+ " is the Reverse number.");

        //SWAP TWO NUMBERS USING TWO VARIABLES
        Console.Write("---SWAP TWO NUMBERS USING TWO VARIABLES---");
        int num1, num2;
        Console.Write("\nInput the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("num1= " +num1+ " num2= "+num2);

        num2 = num2+num1;
        num1 = num2-num1;
        num2 = num2-num1;

        Console.WriteLine("num1= " +num1+ " num2= "+num2);

        //CONVERT DECIMAL TO BINARY
        Console.Write("---CONVERT DECIMAL TO BINARY---");
        int binNum, binMod, binProd=0;
        Console.Write("\nInput a number: ");  
        binNum = Convert.ToInt32(Console.ReadLine());

        while(binNum>0){
            binMod = binNum%2;
            binProd = (binProd*10)+binMod;
            binNum = binNum/2;
        }
        Console.Write("The Binary number: "+binProd);
        









    }
}