﻿using CSharpSchool.Pop;
using CSharpSchool.Utils;
using CSharpSchool.Views;
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
      App app = App.Instance();
      app.MainForm = this;
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

    class Test14 {

      public string name = "홍길동";
      private static Test14 instance = null;
      private Test14() { }

      public static Test14 Instance()
      {
        if ( instance == null)
        {
          instance = new Test14(); 
        }
        return instance;
      }
    }
    private void button14_Click(object sender, EventArgs e)
    {
      //Test14 test = new Test14();
      Test14 test = Test14.Instance();
      WriteLine(test.name);
      Test14 test2 = Test14.Instance();
      test.name = "강감찬";
      WriteLine(test.name +", "+test2.name);

      //홍길동
      //강감찬, 홍길동
      //홍길동
      //강감찬, 강감찬

    }

    private void button15_Click(object sender, EventArgs e)
    {
      App app = App.Instance();
      WriteLine(app.name +"("+app.age+") : " + app.gender);

    }

    private void button16_Click(object sender, EventArgs e)
    {
      TestPop  pop = new TestPop();
      pop.ShowDialog();

    }
    class Product17 {
      public Product17() {
        Debug.WriteLine("Product17생성");
      }
      ~Product17()
      {
        Debug.WriteLine("Product17소멸");
      }
    
    }
    private void button17_Click(object sender, EventArgs e)
    {
      Product17 product = new Product17();
    }
    class Box {
      private int width;
      private int height;

      public Box() { }
      public Box(int width, int height )
      {
        this.width = width;
        this.height = height;
      }
      public int Area()
      {
        return height*width;
      }
      public int getWidth() {  return width; }
      public void setWidth(int value) { width = value; }

      public int getHeight() { return height; }
      public void setHeight(int value) { height = value; }
    }
    private void button18_Click(object sender, EventArgs e)
    {
      Box box = new Box(20,30);
      WriteLine(box.Area());
      // box.width = 30;
      box.setWidth(30);
      WriteLine("가로:"+box.getWidth()+",세로:"+box.getWidth()+",면적:"+box.Area());
    }
    class BoxEx
    {
      private int width;
      public int Width
      {
        get { return width; }
        set
        {
          if (value > 0)
          {
            width = value;
          }  else {
            width = 0;
          }
        }
      }
      private int height;
      
      public int Height
      {
        get { return height; }
        set { 
          if(value > 0) {
            height = value; 
          } else {
            height = 0;
          }       
        }
      }

      public BoxEx() { }
      public BoxEx(int width, int height)
      {
        this.width = width;
        this.height = height;
      }
      public int Area()
      {
        return height * width;
      }
    }
    private void button19_Click(object sender, EventArgs e)
    {
      BoxEx box = new BoxEx(20, 30);
      WriteLine(box.Area());

      box.Width = 30;
      WriteLine("가로:" + box.Width + ",세로:" + box.Height + ",면적:" + box.Area());
    }

    private void button20_Click(object sender, EventArgs e)
    {
      BoxEx box = new BoxEx(20, 30);
      WriteLine(box.Area());

      box.Width = -30;
      WriteLine("가로:" + box.Width + ",세로:" + box.Height + ",면적:" + box.Area());

    }
    class Animal
    {
      private void func1() { }
      protected void func2() { }
      public void func3() { }

      public Animal() {
        func1();func2(); func3();
      }

      public void Eat()
      {
        App.Instance().MainForm.WriteLine("냠냠");
      }
      public virtual void Sleep()
      {
        App.Instance().MainForm.WriteLine("쿨쿨");
      }
    }

    class Dog : Animal
    {
      public Dog() { }

      public override void Sleep() {

        App.Instance().MainForm.WriteLine("강아지가 쿨쿨잔다.");
      }
      public void Bark()
      {
        App.Instance().MainForm.WriteLine("멍멍멍");
      }

      public void Test()
      {
        this.func2();
        this.func3();
      }
    }

    class Cat : Animal
    {
      public Cat() { }
      public override void Sleep()
      {
        App.Instance().MainForm.WriteLine("야옹이가 새근새근 잔다.");
      }
      public void Meow()
      {
        App.Instance().MainForm.WriteLine("야옹야옹");
      }
    }
    private void button21_Click(object sender, EventArgs e)
    {
      Dog dog = new Dog();
      dog.func3();
    }

    private void button22_Click(object sender, EventArgs e)
    {
      List<Animal> animals = new List<Animal>();
      animals.Add(new Dog());
      animals.Add(new Cat());
      animals.Add(new Dog());
      animals.Add(new Cat());
      animals.Add(new Dog());

      foreach (Animal animal in animals)
      {
        animal.Eat();
        animal.Sleep();
        if (animal is Dog)
        {
          //((Dog)animal).Bark();
          (animal as Dog).Bark();
        }
        if (animal is Cat)
        {
          ((Cat)animal).Meow();
        }

      }


    }

    private void button23_Click(object sender, EventArgs e)
    {
      List<Animal> animals = new List<Animal>();
      animals.Add(new Dog());
      animals.Add(new Cat());
      animals.Add(new Dog());
      animals.Add(new Cat());
      animals.Add(new Dog());

      foreach (Animal animal in animals)
      {
        animal.Eat();
        animal.Sleep();

        var d = animal as Dog;
        if (d != null)
        {
          d.Bark();
        }

        var a = animal as Cat;
        if (a != null) {
          a.Meow();
        }
      }

    }
    class Parents {
      private String name = "일반부모";
      public Parents()
      {
        App.Instance().MainForm.WriteLine($"부모({this.name}) 생성됨");
      }
      public Parents(String name)
      {
        this.name = name;
        App.Instance().MainForm.WriteLine($"부모({this.name}) 생성됨");
      }
    }

    class Child :Parents
    {
      public Child() : base("좋은부모")
      {
        App.Instance().MainForm.WriteLine($"자식 생성됨");
      }
    }
    private void button24_Click(object sender, EventArgs e)
    {
      Child child = new Child(); 

    }

    class Animal2 {
      public void Eat() {
        App.Instance().MainForm.WriteLine("냠냠먹는다.");
      }
    }

    class Dog2: Animal2
    {
      public new void Eat()
      {
        App.Instance().MainForm.WriteLine("강아지가 먹는다.");
      }
    }
    class Cat2 : Animal2
    {
      public new void Eat()
      {
        App.Instance().MainForm.WriteLine("고양이가 먹는다.");
      }
    }

    private void button25_Click(object sender, EventArgs e)
    {
      List<Animal2> list = new List<Animal2>() { 
      new Dog2(), new Cat2(), new Dog2()
      };
      foreach(Animal2 ani in list)
      {
        ani.Eat();
      }

    }

    class Animal3
    {
      public virtual void Eat()
      {
        App.Instance().MainForm.WriteLine("냠냠먹는다.");
      }
    }

    class Dog3 : Animal3
    {
      public override void Eat()
      {
        App.Instance().MainForm.WriteLine("강아지가 먹는다.");
      }
    }
    class Cat3 : Animal3
    {
      public override void Eat()
      {
        App.Instance().MainForm.WriteLine("고양이가 먹는다.");
      }
    }
    private void button26_Click(object sender, EventArgs e)
    {
      List<Animal3> list = new List<Animal3>() {
      new Dog3(), new Cat3(), new Dog3()
      };
      foreach (Animal3 ani in list)
      {
        ani.Eat();
      }

    }
    abstract class Parent27 {
      public virtual void Eat() { }
      public abstract void Sleep();
    }
    class Child27: Parent27 {
      public override void Eat() { }
      public override void Sleep() { }
    }

    class GrdnChild27: Child27 {
      public override void Eat()
      {
        base.Eat();
      }
    }
    private void button27_Click(object sender, EventArgs e)
    {
      //Parent27 parent = new Parent27();
      Child27 child = new Child27(); 

    }

    private void button28_Click(object sender, EventArgs e)
    {
      ViewTestPop pop = new ViewTestPop();
      pop.ShowDialog();

    }
    public class Box<T>
    {
      public T content;
      public void SetContent(T value)
      {
        content = value;
      }
      public T GetContent()
      {
        return content;
      }
    }
    private void button29_Click(object sender, EventArgs e)
    {
      Box<int> box1 = new Box<int>();
      box1.SetContent(1);
      WriteLine(box1.GetContent() + 2);

      Box<string> box2 = new Box<string>();
      box2.SetContent("1");
      WriteLine(box2.GetContent() + 2);


    }
    public class Utility
    {
      public T identity<T>(T value)
      {
        return value;
      }
    }
    private void button30_Click(object sender, EventArgs e)
    {
      Utility utility = new Utility();
      WriteLine(utility.identity(1) + 2);    //정수
      WriteLine(utility.identity(1.2) + 2);  //실수
      WriteLine(utility.identity("1") + 2);   // 문자열

    }
    public class MyCollection
    {
      private string[] strArray = new string[10];
      public MyCollection()
      {
      }
      public string this[int i]
      {
        get { return strArray[i]; }
        set { strArray[i] = value; }
      }
    }
    private void button31_Click(object sender, EventArgs e)
    {
      MyCollection myCollection = new MyCollection();
      myCollection[0] = "홍길동";
      myCollection[1] = "강강찬";
      WriteLine(myCollection[0]);
    }

    private void button32_Click(object sender, EventArgs e)
    {
      string input = tbox_1.Text;
      int output = int.Parse(input);
      WriteLine("입력값:" + output);
    }

    private void button33_Click(object sender, EventArgs e)
    {

      string input = tbox_1.Text;
      int output;
      bool result = int.TryParse(input, out output);
      if (result)
      {
        WriteLine("입력값:" + output);
      }
      else
      {

        WriteLine("문자열 -> 숫자 실패");
      }
    }
  }
}
