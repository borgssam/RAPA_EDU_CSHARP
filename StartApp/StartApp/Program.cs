using System;

class Program
{
  static void Main(string[] args)
  {
    //주석임당
    int count = 1;
    int totalClap = 0;
    while (true) {

      //박수개수
      int clap = 0;
      int num = count;
      while (true) {
        int num_1 = num % 10;
        if (num_1 == 3 || num_1 == 6 || num_1 == 9) {
          clap++;
        }
        num /= 10;
        if(num == 0) { break; }
      }

      totalClap += clap;
      int player = (count - 1) % 4;
      Console.WriteLine(player+"번 선수("+count+") 박수:"+ clap + ", 총박수:"+ totalClap);
      count++;

      if (totalClap >= 1000) { break; }
    }


    //for(int dan = 2; dan <= 9; dan++)
    //{
    //  for(int num = 2; num <= 9; num++)
    //  {
    //    Console.WriteLine(dan + "*" + num + "=" + (dan * num));
    //  }
    //}

    //문제 for, while를 한개만 사용해서 2단 ~ 9단출력
    //int dan = 2;
    //int num = 2;
    //while (dan<10) {
    //  Console.WriteLine(dan + "*" + num + "=" + (dan * num));
    //  num++;
    //  if(num > 9)
    //  {
    //    dan++;
    //    num = 2;
    //  }
    //}

    //for(int idx = 0; idx<64; idx++) {
    //  int dan = (idx / 8) +2;
    //  int num = (idx % 8) +2;
    //  Console.WriteLine(dan + "*" + num + "=" + (dan * num));
    //}


    //int row = 1; int star = 1; 
    //int rows = 18;
    ////최대별
    //int maxStar = 1;
    //for (int i = 0; i < rows; i++) {
    //  maxStar += 2;
    //}
    ////최대빈공간
    //int maxSpace = maxStar / 2;
    //int space = maxSpace;
    //while (row <= rows) {
    //  //스페이스 입력
    //  for (int i = 0; i < space; i++)
    //  {
    //    Console.Write(" ");
    //  }
    //  for(int s = 0; s < star; s++) {
    //    Console.Write("*");
    //  }
    //  Console.WriteLine();
    //  row++;
    //  star += 2;
    //  space--;    
    //}



    ////숫자->문자열
    //Console.WriteLine(3 + 4);
    //Console.WriteLine("3"+"4");
    //Console.WriteLine(3.ToString() + 4.ToString());
    //Console.WriteLine(3.1456789.ToString("0.000"));
    ////문자열+숫자 : 숫자->문자열 ==> 문자열+문자열
    //Console.WriteLine("고양이 " + (3 + 4) + "마리");

    //문자열->숫자

    //자동형변환
    //int intNum = 2147483647;
    //long longNum = intNum;
    //Console.WriteLine(longNum);

    //int a = 258;
    //byte b = (byte)a;
    //Console.WriteLine(b);
    //Console.Write("입력:");
    //string? _input = Console.ReadLine();
    //Console.WriteLine("입력값:" + _input);
  }
}


