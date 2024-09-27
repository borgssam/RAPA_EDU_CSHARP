using System;
using System.Collections.Generic;

class Program
{
  class Product {
    public static string color = "white";
    //속성(자료) : 필드, 인스턴스변수, 멤버변수
    public string name = "";
    public int price  = 0;
    //속성(동작) : 메소드, 멤버함수
  }

  class Student
  {
    //public int id;
    public string name = "";
    public int grade;
    //public string major = string.Empty;
    //public DateTime birthday;
  }


  static void Main(string[] args)
  {
    List <Student> list = new List <Student> ();
    list.Add(new Student() { name = "홍길동", grade = 1 }); 
    list.Add(new Student() { name = "강감찬", grade = 2 });
    Student stud = new Student() { name = "원균", grade = 3 };
    list.Add(stud);
    list.Add(new Student() { name = "이순신", grade = 4 });

    foreach (Student student in list)
    {
      Console.WriteLine(student.name + ":" + student.grade);
    }

    //list.Remove(stud);
    Student? delStudent = null;
    foreach (Student student in list)
    {
      if(student.name == "원균") {
        delStudent = student;
      } 
    }

    if(delStudent != null)
    {
      list.Remove(delStudent);
    }

    foreach (Student student in list)
    {
      Console.WriteLine(student.name + ":" + student.grade);
    }



    //Product prod = new Product();
    //prod.name = "감자";
    //prod.price = 2000;

    //Console.WriteLine(prod.name+ ":"+prod.price+"원, 색상:" + Product.color);

    //Product.color = "blue";
    //Product prod2 = new Product() { name = "고구마", price = 3000 };
    //Console.WriteLine(prod2.name + ":" + prod2.price + "원, 색상:" + Product.color);

    //  Console.WriteLine(Math.Abs(-1234));
    //  Console.WriteLine(Math.Round(1234.567));
    //List<int> list = new List<int>();
    //list.Add(1);
    //list.Add(2);
    //list.Add(3);
    //list.Add(4);
    //list.Add(5);
    //list.Add(3);
    //list.Add(5);

    //list.Remove(3);

    //foreach (int i in list)
    //{
    //  Console.WriteLine(i);
    //}

    //List<string> list2 = new List<string>();
    //list2.Add("a");
    //list2.Add("b");
    //list2.Add("c");
    //list2.Add("d");
    //foreach (string i in list2)
    //{
    //  Console.WriteLine(i);
    //}



    //Random random = new Random();
    //for (int i = 0; i < 10; i++)
    //{
    //  Console.WriteLine(random.Next());
    //}
    //Console.WriteLine("-----------");
    //for (int i = 0; i < 10; i++)
    //{
    //  Console.WriteLine(random.Next(10));
    //}
    //Console.WriteLine("-----------");
    //for (int i = 0; i < 10; i++)
    //{
    //  Console.WriteLine(random.Next(10, 100));
    //}


    //2차배열
    //int[,] matrix = new int[2, 3];
    //int[,] matrix2 = { {1,2,3},{4,5,6 } }; 

    //int value = matrix2[0, 1];
    //Console.WriteLine(value);

    //for (int x = 0; x < matrix2.GetLength(0); x++) {
    //  for (int y = 0; y < matrix2.GetLength(1); y++)
    //  {
    //    Console.Write(matrix2[x, y] + ", " );
    //  }
    //  Console.WriteLine();
    //}
    //    string[,] Tetris = {
    //      { "#", "#", "#" },
    //      { " ", " ", "#" },
    //      { " ", " ", " " }
    //    };

    //    for (int x = 0; x < Tetris.GetLength(0); x++) {
    //      for(int y = 0; y < Tetris.GetLength(1); y++) {
    //        Console.Write(Tetris[x, y]);
    //      }
    //      Console.WriteLine();
    //    }
    ////##
    ////#
    ////#
    //    for (int y = 2; y >= 0; y--)
    //    {
    //      for (int x = 0; x < Tetris.GetLength(0); x++) {
    //        Console.Write(Tetris[x, y]);
    //      }
    //      Console.WriteLine();
    //    }

    //변수 함수 표기 규칙 sweet  red  apple
    //카멜      sweetRedApple    함수명(메소드)
    //파스칼    SweetRedApple    클레스명
    //스네이크  sweet_red_apple  데이타베이스
    //케밥      sweet-red-apple  html css

    //if (3>1) { 
    //} else { 
    //}
    //read, open, bind

    //if (3 > 1)
    //{
    //}
    //else
    //{
    //}

    //int[] number = new int[5];
    //number[0] = 10;
    //number[1] = 20;
    //number[2] = 30;
    //number[3] = 40;
    //number[4] = 50;

    //Console.WriteLine(number);
    //Console.WriteLine("----------------------");
    //Console.WriteLine(number[2]);
    //Console.WriteLine(number.Length);

    //for (int i = 0; i < number.Length; i++) { 
    //  if(i > 0) { Console.Write(", "); }
    //  Console.Write(number[i]);
    //}
    //Console.WriteLine();
    //foreach( int item in number) { 
    //  Console.Write(item+", ");
    //}


    //주석임당
    //int count = 1;
    //int totalClap = 0;
    //while (true) {

    //  //박수개수
    //  int clap = 0;
    //  int num = count;
    //  while (true) {
    //    int num_1 = num % 10;
    //    if (num_1 == 3 || num_1 == 6 || num_1 == 9) {
    //      clap++;
    //    }
    //    num /= 10;
    //    if(num == 0) { break; }
    //  }

    //  totalClap += clap;
    //  int player = (count - 1) % 4;
    //  Console.WriteLine(player+"번 선수("+count+") 박수:"+ clap + ", 총박수:"+ totalClap);
    //  count++;

    //  if (totalClap >= 1000) { break; }
    //}


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


