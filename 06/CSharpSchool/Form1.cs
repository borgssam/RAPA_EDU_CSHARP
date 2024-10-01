using CSharpSchool.Pop;
using CSharpSchool.Utils;
using CSharpSchool.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

    private void button34_Click(object sender, EventArgs e)
    {

    }
    class PointX
    {
      public int x;
      public int y;
    }
    struct Point
    {
      public int x;
      public int y;
    }

    private void button35_Click(object sender, EventArgs e)
    {

      Point point;  //구조체는 스택할당
      point.x = 10;
      point.y = 20;

      WriteLine($"{point.x},{point.y}");

      //PointX point2; //클래스 힙에 할당해야함
      //point2.x = 10;
      //point2.y = 20;
      //WriteLine($"{point2.x},{point2.y}");


    }
    struct Point3
    {
      public int x;
      public int y;
      public Point3(int x, int y)
      {
        this.x = x;
        this.y = y;
      }
    }
    private void button36_Click(object sender, EventArgs e)
    {
      Point3 point = new Point3();
      //point.x = 10;
      //point.y = 20;
      WriteLine($"{point.x},{point.y}");

      Point3 point2 = new Point3(10,20);
      WriteLine($"{point2.x},{point2.y}");
    }

    struct Point4
    {
      public int x;
      public int y;
      public string name;
      public PointX pos;
      //public int age = 30;

      public Point4(int x, int y)
      {
        this.x = x;
        this.y = y;
        this.name = string.Empty;
        pos = null;
      }
      public Point4(int x, int y, string name)
      {
        this.x = x;
        this.y = y;
        this.name = name;
        pos = null;
      }
    }
    private void button37_Click(object sender, EventArgs e)
    {

    }
    //깊은복사 얕은복사 ( 값복사 , 참조복사)
    class PointClass
    {
      public int x;
      public int y;
      public PointClass(int x, int y)
      {
        this.x = x;
        this.y = y;
      }
    }

    struct PointStuct
    {
      public int x;
      public int y;
      public PointStuct(int x, int y)
      {
        this.x = x;
        this.y = y;
      }

    }

    private void button38_Click(object sender, EventArgs e)
    {
      PointClass pcA = new PointClass(10,20);
      PointClass pcB = pcA;  // 얕은복사, 참조복사
      pcB.x = 100;
      pcB.y = 200;

      WriteLine($"{pcA.x},{pcA.y}");

      PointStuct psA = new PointStuct(10, 20); 
      PointStuct psB = psA;  // 값복사 깊은복사
      psB.x = 100;
      psB.y = 200;
      WriteLine($"{psA.x},{psA.y}");
    }
    class Product39 { 
      public string Name {  get; set; }
      public int   Price { get; set; }

      public override string ToString()
      {
        return Name + ":" +Price+"원";
      }
    }
    private void button39_Click(object sender, EventArgs e)
    {
      List<Product39> list = new List<Product39>() {
        new Product39() { Name="고구마", Price=1500},
        new Product39() { Name="사과", Price=2400},
        new Product39() { Name="바나나", Price=1000},
        new Product39() { Name="배", Price=3000}
      };
      list.Sort();
      foreach (Product39 p in list) {
        WriteLine(p);
      }


    }
    class Product40 : IComparable
    {
      public string Name { get; set; }
      public int Price { get; set; }

      public override string ToString()
      {
        return Name + ":" + Price + "원";
      }
     
      public int CompareTo(object obj)
      {
        if (this.Name.Length > ((Product40)obj).Name.Length) {
          return -1;
        } else if (this.Name.Length == ((Product40)obj).Name.Length) {
          return 0;
        } else {
          return 1;
        }
      }

    }

    private void button40_Click(object sender, EventArgs e)
    {
      List<Product40> list = new List<Product40>() {
        new Product40() { Name="고구마", Price=1500},
        new Product40() { Name="사과", Price=2400},
        new Product40() { Name="바나나", Price=1000},
        new Product40() { Name="배", Price=3000}
      };
      list.Sort();
      foreach (Product40 p in list)
      {
        WriteLine(p);
      }

    }

    class TestClass : IBasic
    {
      public int TestProperty {
        get { throw new NotImplementedException(); }
        set { throw new NotImplementedException(); }
      }

      public int TestInstanceMethod()
      {
        //throw new NotImplementedException();
        App.Instance().MainForm.WriteLine("Test");  
        return 0;
      }
    }

    private void button41_Click(object sender, EventArgs e)
    {
      IBasic basic = new TestClass();
      basic.TestInstanceMethod();
    }

    class Car : IDrivable
    {
      public string Name { get; set; }
      public Car(string name)
      {
        Name = name;
      } 
      public void Drive()
      {
        App.Instance().MainForm.WriteLine($"{this.Name}가 도로를 달린다.");
      }
    }
    class Plane : IFlyable
    {
      public string Name { get; set; }
      public Plane(string name)
      {
        Name = name;
      }

      public void Fly()
      {
        App.Instance().MainForm.WriteLine($"{this.Name}이 하늘을 난다.");
      }
    }

    class FlyingCar : IDrivable, IFlyable
    {
      public void Drive()
      {
        App.Instance().MainForm.WriteLine("도로를 달린다.");
      }

      public void Fly()
      {
        App.Instance().MainForm.WriteLine("하늘을 난다.");
      }
    }
    private void button42_Click(object sender, EventArgs e)
    {
      Car car = new Car("붕붕이");
      car.Drive();
      IDrivable drive = car;
      drive.Drive();
    }

    private void button43_Click(object sender, EventArgs e)
    {
      Plane plane = new Plane("쌕쌕기");
      plane.Fly();
      IFlyable flyable = plane;
      flyable.Fly();
    }

    private void button44_Click(object sender, EventArgs e)
    {
      FlyingCar flyingcar = new FlyingCar();
      IDrivable drivable = flyingcar;
      drivable.Drive();
      IFlyable flyable2 = flyingcar;
      flyable2.Fly();
    }

    private void button45_Click(object sender, EventArgs e)
    {
      List<IFlyable> list = new List<IFlyable>();
      list.Add(new FlyingCar());
      list.Add(new Plane("붕붕이"));
      list.Add(new Plane("날다람쥐"));
      list.Add(new Plane("대한항공"));

      foreach (IFlyable flyable in list)
      {
        flyable.Fly(); 
      }

    }

    private void button46_Click(object sender, EventArgs e)
    {
      //C:\EDU\edu_csharp\sample
      File.WriteAllText(@"C:\EDU\edu_csharp\sample\sample.txt", "문자열을 파일에 씁니다.");

    }

    private void button47_Click(object sender, EventArgs e)
    {
      string data = File.ReadAllText(@"C:\EDU\edu_csharp\sample\sample.txt");
      WriteLine(data);
    }

    private void button48_Click(object sender, EventArgs e)
    {
      using (StreamWriter writer = new StreamWriter(@"C:\EDU\edu_csharp\sample\sample.txt"))
      {
        writer.WriteLine("안녕하세요");
        writer.WriteLine("123456789");
        writer.WriteLine("Hello");
        for(int i = 0; i < 10; i++)
        {
          writer.WriteLine("반복문" + i);
        }


      }
    }

    private void button49_Click(object sender, EventArgs e)
    {
      string str_1 = tbox_1.Text;
      int int_1 = int.Parse(str_1);
      WriteLine("입력값:"+(int_1+1 ) );
    }

    private void button50_Click(object sender, EventArgs e)
    {
      string str_1 = tbox_1.Text;
      string str_2 = tbox_2.Text;
      try {
        int int_2 = int.Parse(str_2);
        int k = 100 / int_2;
        int int_1 = int.Parse(str_1);
        WriteLine("입력값:" + (int_1 + 1));
      }
      catch (FormatException ex)
      {
        WriteLine("예외발생(FormatException)");
        WriteLine(ex.Message);
      }
      catch (DivideByZeroException ex)
      {
        WriteLine("예외발생(DivideByZeroException)");
        WriteLine(ex.Message);
      } catch (Exception ex) {
        WriteLine("예외발생(Exception)");
        WriteLine(ex.Message);
        WriteLine(ex.StackTrace);
        WriteLine(ex.ToString());
      } finally {
        WriteLine("무조건 실행");
      
      }

      

    }
    class RedBox
    {
      private int width;
      public int Width { get{ return width; }
        
        set {
          if (value > 0) { width = value; 
          } else {
            width = 0;
            throw new Exception("가로는 0보다 커야합니다.");
          }
        }
      }

      private int height;
      public int Height
      {
        get
        { return height; }
        set
        {
          if (value > 0)
          {
            height = value;
          }
          else
          {
            height = 0;
            throw new Exception("높이는 0보다 커야합니다.");
          }
        }
      }
      public RedBox(int width, int height) { 
        Width = width; Height = height;
      }
      public int Area() { return Width * Height; }
    }
    private void button51_Click(object sender, EventArgs e)
    {
      string str_1 = tbox_1.Text; 
      string str_2 = tbox_2.Text;
      int int_1 = int.Parse (str_1);
      int int_2 = int.Parse(str_2);

      try {       
        RedBox box = new RedBox(int_1, int_2);
        WriteLine("면적: "+ box.Area() );
      } catch (Exception ex) {
        WriteLine(ex.Message);
      }

    }

    private void button52_Click(object sender, EventArgs e)
    {
      WriteLine("안녕하세요 버튼52입니다.");
    }
    private void click2(object sender, EventArgs e)
    {
      WriteLine("click2입니다.");
    }
    private void click3(object sender, EventArgs e)
    {
      WriteLine("click3입니다.");
    }
    private void button53_Click(object sender, EventArgs e)
    {
      //this.button52.Click -= this.button52_Click;
      //this.button52.Click -= null;
      this.button52.Click += new EventHandler(click3);
    }

    private void button54_Click(object sender, EventArgs e)
    {
      this.button55.Click += delegate (object sender2, EventArgs e2) {
        MessageBox.Show("버튼55이 무명메서드로 실행되었습니다.");
      };
    }

    public delegate void TestDelegate();
    private void button56_Click(object sender, EventArgs e)
    {
      TestDelegate dA = this.TestMethod;
      TestDelegate dB = delegate () { Debug.WriteLine("델리게이트방식으로 호출"); };
      TestDelegate dC = () => { Debug.WriteLine("람다식으로 호출"); };

      dA();
      dB();
      dC();
    }

    private void TestMethod() {
      Debug.WriteLine("일반함수방식으로 호출");
    }

    class Student
    {
      public string Name { get; set; }
      public double Score { get; set; }
      public Student() { }
      public Student(string name, double score)
      {
        Name = name;
        Score = score;
      }
      public override string ToString()
      {
        return Name + " : " + Score;
      }
    }

    class Students
    {
      private List<Student> studentList = new List<Student>();
      public delegate void PrintProcess(Student student);
      public delegate void WL(object obj);
      public void Add(Student student)
      {
        studentList.Add(student);
      }
      public void Print()
      {

      }
      public void Print(PrintProcess printProcess)
      {
        foreach (Student student in studentList) {
          printProcess(student);
        }
      }

      public void WriteLine(WL printLine) {
        printLine("안녕하세요");
      }
    }


    private Students students = new Students();
    private void button57_Click(object sender, EventArgs e)
    {
      students.Add(new Student("김지영", 4.3));
      students.Add(new Student("홍길동", 2.4));
      students.Add(new Student("뉴턴", 4.5));

      //students.Print((student) =>
      //{
      //  WriteLine($"이름: {student.Name}, 성적:{student.Score}");
      //});
    }
    private void process1(Student student)
    {
      WriteLine($"이름: {student.Name}, 성적:{student.Score}");
    }
    private void process2(Student student)
    {
      WriteLine($"name: {student.Name}, score:{student.Score}");
    }

    private void button58_Click(object sender, EventArgs e)
    {
      students.Print(this.process1);
    }

    private void button59_Click(object sender, EventArgs e)
    {
      students.Print(this.process2);
      students.WriteLine(this.WriteLine);
    }
  }
}
