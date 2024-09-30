using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSchool
{
  public partial class Form1 : Form
  {
    class Test { 
      public int Multi(int x, int y) {  return x * y; }
      public void print() {
        Debug.WriteLine("print메소드 호출");
      }

      public int Sum(int min, int max)
      {
        int output = 0;
        for (int i = min; i <= max; i++)
        {
          output += i;
        }
        return output;
      }


      public int Multiply(int min, int max)
      {
        int output = 1;
        for (int i = min; i <= max; i++)
        {
          output *= i;
        }
        return output;
      }

    }

    public Form1()
    {
        InitializeComponent();
    }


    private void btn_clear_Click(object sender, EventArgs e)
    {

        ClearResult();
    }

    private void ClearResult()
    {
        this.tbox_result.Clear();
    }

    private void WriteLine(object obj)
    {
          Write(string.Format("{0}\r\n", obj));
    }
    private void Write(string aText)
    {
        this.tbox_result.AppendText(aText);
    }

    private void Write(object obj)
    {
        Write(string.Format("{0}", obj));
    }


    private void button1_Click(object sender, EventArgs e)
    {
        Write(1234);
        WriteLine(1234);
        WriteLine(5678);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Test test = new Test();
      WriteLine(test.Multi(52, 273));
      WriteLine(test.Multi(103, 32));
    }

    private void button3_Click(object sender, EventArgs e)
    {

      Test test = new Test();
      test.print();
    }

    private void button4_Click(object sender, EventArgs e)
    {

      Test test = new Test();
      WriteLine( test.Sum(1, 5) );
    }

    private void button5_Click(object sender, EventArgs e)
    {
      Test test = new Test();
      WriteLine(test.Multiply(1, 5));

    }

    private void button6_Click(object sender, EventArgs e)
    {
      String str_1 = this.tbox_1.Text;
      String str_2 = this.tbox_2.Text;
      if (str_1.Trim() == string.Empty) { str_1 = "1"; } //값이 비어있으면
      if (str_2.Trim() == string.Empty) { str_2 = "1"; }

      int int_1 = int.Parse(str_1); //문자열->숫자
      int int_2 = int.Parse(str_2); //문자열->숫자
      Test test = new Test();
      WriteLine(test.Multiply(int_1, int_2));
    }

    private void button7_Click(object sender, EventArgs e)
    {
      String str_1 = this.tbox_1.Text;
      if (str_1.Trim() == string.Empty) { str_1 = "0"; }
      int int_1 = int.Parse(str_1);

      WriteLine(MyMath.Abs(int_1));
    }

    private void button8_Click(object sender, EventArgs e)
    {
      MyMath myMath = new MyMath();
      WriteLine(MyMath.Multi10(123));

    }

    class MyMath
    {
      public static int Abs(int input)
      {
        if (input < 0)
        {
          input *= -1;
        }
        return input;
      }

      public static double Abs(double input)
      {
        if (input < 0)
        {
          input *= -1;
        }
        return input;
      }

      public static long Abs(long input)
      {
        if (input < 0)
        {
          input *= -1;
        }
        return input;
      }


      public static int num = 10;
      public static int Multi10(int input)
      {
        return input * num;
      }
    }
    private void button9_Click(object sender, EventArgs e)
    {
      WriteLine(MyMath.Abs(-10));
    }

    private void button10_Click(object sender, EventArgs e)
    {
      WriteLine(MyMath.Abs(-10.0));
    }

    private void button11_Click(object sender, EventArgs e)
    {
      WriteLine(MyMath.Abs(-2200000000 ) );
    }
    class Test12
    {
      private int add(int a, int b)
      {
        return a + b;
      }
      public int add2(int a, int b)
      {
        return add(a,b);
      }
      private int sub(int a, int b)
      {
        return a - b;
      }
      public int sub2(int a, int b)
      {
        return sub(a, b);
      }
    }
    private void button12_Click(object sender, EventArgs e)
    {
      Test12 test = new Test12();
      //test.add(1, 2);
      test.add2(1, 2);
      //test.sub(1, 2);
      test.sub2(1, 2);

    }

    class Product {
      public static int counter = 0;
      public int id;
      public string name;
      public int price;

      public Product()
      {
        Product.counter++;
        this.id = counter;
        this.name = "";
        this.price = 0;
      }

      public Product(string name, int price)
      {
        Product.counter++;
        this.id = counter;
        this.name = name;
        this.price = price;
      }

      public Product(int id, string name, int price)
      {
        this.id = id;
        this.name = name;
        this.price = price;
      }
    }
    private void button13_Click(object sender, EventArgs e)
    {
      Product productA = new Product("감자", 2000);
      Product productB = new Product("고구마", 3000);

      WriteLine(productA.name + "(" + productA.id + "):" + productA.price);
      WriteLine(productB.name + "(" + productB.id + "):" + productB.price);
      WriteLine(Product.counter + "개의 제품인스턴스가 만들어졌습니다.");

    }
  }
}
