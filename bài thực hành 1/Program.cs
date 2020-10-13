using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.ComTypes;

namespace bài_thực_hành_1
//BÀI 1:
{

    class Diem
    {
        private double x, y;
        public Diem()
        {
            x = y = 0;
        }
        public Diem(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Nhap()
        {
            Console.Write("Nhap x:");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y:");
            y = double.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.WriteLine("Toa do (x,y)=({0},{1})");
        }
        public double TinhDT(Diem B)
        {
            return Math.Sqrt(Math.Pow(B.x - this.x, 2) + Math.Pow(B.y - this.y, 2));
        }
    }
}
//BÀI 2:
class Employee
{
    private int id;
    private string name;
    private int yearOfBirth;
    private double salaryLever;
    private double basicSalary;
    public int getld()
    {
        return id;
    }
    public string getname()
    {
        return name;
    }
    public int getyearOBirth()
    {
        return yearOfBirth;
    }
    public double getIncome()dkjfgufg
    {
        return salaryLever * basicSalary;
    }
    public void display()
    {
        Console.WriteLine("Thong tin ve nguoi lao dong:");
        Console.Write("Dinh danh", id, "Ten", name, "Nam sinh", yearOfBirth, "Luong co ban", basicSalary, "Thu nhap", getIncome());
    }
}
//BÀI 3:
class Stack
{
    private int top;
    private int[] s;
    public Stack()
    {
        top = -1;
        s = new int[20];
    }
    public Stack(int n)
    {
        top = -1;
        s = new int[n];
    }
    public bool Full()
    {
        return top == s.Length - 1;
    }
    public bool Empty()
    {
        return top == -1;
    }
    public void Push(int x)
    {
        if (Full()) Console.WriteLine("Stack day");
        else s[++top] = x;
    }
    public int Pop()
    {
        if (Empty()) throw new Exception("Stack rong");
        else
        {
            int x = s[top--];
            return x;
        }
    }
}
//BAI 4:
class Sophuc
{
    private double thuc, ao;
    public Sophuc()
    {
        thuc = 0;
        ao = 0;
    }
    public Sophuc(double thuc,double ao)
    {
        this.thuc = thuc;
        this.ao = ao;
    }
    public Sophuc(Sophuc t2)
    {
        this.thuc = t2.thuc;
        this.ao = t2.ao;
    }
    public void Nhap()
    {
        Console.WriteLine("Nhap phan thuc:");
        thuc = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap phan ao:");
        ao = double.Parse(Console.ReadLine());

    }
    public void Hien()
    {
        string kq = thuc + (ao > 0 ? "+" : "") + ao + "+i";
        Console.WriteLine(kq);
    }
    public static Sophuc operator+(Sophuc t1,Sophuc t2)
    {
        Sophuc tmp = new Sophuc();
        tmp.thuc = t1.thuc + t2.thuc;
        tmp.ao = t1.ao + t2.ao;
        return tmp;
    }
    public Sophuc Tong(Sophuc t2)
    {
        Sophuc tmp = new Sophuc();
        tmp.thuc = this.thuc + t2.thuc;
        tmp.ao = this.ao + t2.ao;
        return tmp;
    }
    public Sophuc Hieu(Sophuc t2)
    {
        Sophuc tmp = new Sophuc();
        tmp.thuc = this.thuc - t2.thuc;
        tmp.ao = this.ao - t2.ao;
        return tmp;
    }
}

//BÀI 5:
using System
class MaTran
{
    private int sh, sc;
    private int[,] a;
    public MaTran(int sh,int sc)
    {
        this.sh = sh;
        this.sc = sc;
    }
    public void print()
    {
        Console.WriteLine("Cac phan tu cua ma tran la:");
        for(int i=0;i<sh;i++)
        {
            for (int j = 0; j < sh; j++)
                Console.Write("{0}\t", a[i, j]);
            Console.WriteLine();
                
        }
    }
    public void Nhap()
    {
        Console.WriteLine("Nhap cac phan tu cua ma tran:");
        for (int i = 0; i < sh; i++)
            for (int j = 0; j < sh; j++)
            {
                Console.Write("a({0},{1})=", i, j);
                a[i, j] = int.Parse(Console.ReadLine());
            }
    }
    public MaTran()
    {
        sh = sc = 2;
        a = new int[sh, sc];
    }
    public MaTran(int sh,int sc)
    {
        this.sh = sh;
        this.sc = sc;
        a = new int[sh, sc];
    }
    public MaTran(MaTran t2)
    {
        this.sh = t2.sh;
        this.sc = t2.sc;
        this.a = new int[sh, sc];
        for (int i = 0; i < sh; i++)
            for (int j = 0; j < sh; j++)
                this.a[i, j] = t2.a[i, j];
    }
    public MaTran Tong(MaTran t2)
    {
        if (this.sh == t2.sh && this.sc == t2.sc)
        {
            MaTran t = new MaTran(this.sh, this.sc);
            for (int i = 0; i < sh; i++)
                for (int j = 0; j < sh; j++)
                    t.a[i, j] = this.a[i, j] + t2.a[i, j];
            return t;
        }
        else return null;

    }
    public MaTran Hieu(MaTran t2)
    {
        if (this.sh == t2.sh && this.sc == t2.sc)
        {
            MaTran t = new MaTran(this.sh, this.sc);
            for (int i = 0; i < sh; i++)
                for (int j = 0; j < sh; j++)
                    t.a[i, j] = this.a[i, j] - t2.a[i, j];
            return t;
        }
        else return null;

    }

}

