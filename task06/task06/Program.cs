namespace task06
{
    using System;

    /*  public struct Point
      {
          // Attributes
          public int X { get; set; }
          public int Y { get; set; }

          public Point()
          {
              X = 5;
              Y = 5;
          }


          public Point(int x, int y)
          {
              X = x;
              Y = y;
          }


          public override string ToString()
          {
              return $"({X}, {Y})";
          }
      }

      class Program
      {
          static void Main()
          {

              Point defaultPoint = new Point();
              Console.WriteLine($"Default Point: {defaultPoint}"); 


              Point parameterizedPoint = new Point(20, 40);
              Console.WriteLine($"Parameterized Point: {parameterizedPoint}"); 
          }
      }

  }*/





    /*  public class TypeA
      {
          private int F = 10;


          internal int G = 20;


          public int H = 30;


          public int GetF()
          {
              return F;
          }

          public void SetF(int value)
          {
              F = value;
          }
      }

      class Program
      {
          static void Main()
          {

              TypeA obj = new TypeA();


              Console.WriteLine($"Public H: {obj.H}");

              Console.WriteLine($"Internal G: {obj.G}");


              Console.WriteLine($"Private F (via GetF): {obj.GetF()}");


              obj.SetF(50);
              Console.WriteLine($"Private F after modification: {obj.GetF()}");
          }
      }


      public class AnotherClass
      {
          public void AccessTypeA()
          {

              TypeA obj = new TypeA();


              Console.WriteLine($"Accessing Public H: {obj.H}");
              Console.WriteLine($"Accessing Internal G: {obj.G}");
          }
      }
  }*/





    /*  public struct Employee
      {

          private int empId;
          private string name;
          private decimal salary;


          public Employee(int empId, string name, decimal salary)
          {
              this.empId = empId;
              this.name = name;
              this.salary = salary;
          }

          public int EmpId
          {
              get { return empId; }
              set { empId = value; }
          }


          public string GetName()
          {
              return name;
          }

          public void SetName(string value)
          {
              name = value;
          }

          public decimal Salary
          {
              get { return salary; }
              set { salary = value; }
          }
      }

      class Program
      {
          static void Main()
          {

              Employee emp = new Employee(101, "amr", 50000);


              Console.WriteLine($"Employee ID: {emp.EmpId}");
              Console.WriteLine($"Employee Name: {emp.GetName()}");
              Console.WriteLine($"Employee Salary: {emp.Salary}");


              emp.SetName(" amr");
              emp.Salary = 55000;


              Console.WriteLine($"Updated Employee Name: {emp.GetName()}");
              Console.WriteLine($"Updated Employee Salary: {emp.Salary}");
          }
      }
  }*/


    /*  public struct Point
      {

          public int X { get; set; }
          public int Y { get; set; }

          public Point(int x)
          {
              X = x;
              Y = 0;
          }


          public Point(int x, int y)
          {
              X = x;
              Y = y;
          }

          public void Display()
          {
              Console.WriteLine($"Point: ({X}, {Y})");
          }
      }

      class Program
      {
          static void Main()
          {

              Point point1 = new Point(5);
              point1.Display();


              Point point2 = new Point(5, 10);
              point2.Display();
          }
      }
  }*/




    /*  public struct Point
      {

          public int X { get; set; }
          public int Y { get; set; }


          public Point(int x, int y)
          {
              X = x;
              Y = y;
          }

          public override string ToString()
          {
              return $"Point(X: {X}, Y: {Y})";
          }
      }

      class Program
      {
          static void Main()
          {

              Point point1 = new Point(5, 10);
              Point point2 = new Point(15, 20);
              Point point3 = new Point(30, 40);


              Console.WriteLine(point1);
              Console.WriteLine(point2);
              Console.WriteLine(point3);
          }
      }
  }*/




  /*  public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Program
    {

        static void ModifyPoint(Point p)
        {
            p.X = 100;
            p.Y = 200;
            Console.WriteLine($"Inside ModifyPoint: Point(X: {p.X}, Y: {p.Y})");
        }


        static void ModifyEmployee(Employee e)
        {
            e.Name = " amr";
            e.Age = 30;
            Console.WriteLine($"Inside ModifyEmployee: Name: {e.Name}, Age: {e.Age}");
        }

        static void Main()
        {

            Point point = new Point(5, 10);
            Console.WriteLine($"Before ModifyPoint: Point(X: {point.X}, Y: {point.Y})");
            ModifyPoint(point);
            Console.WriteLine($"After ModifyPoint: Point(X: {point.X}, Y: {point.Y})");


            Employee employee = new Employee("Alice", 25);
            Console.WriteLine($"Before ModifyEmployee: Name: {employee.Name}, Age: {employee.Age}");
            ModifyEmployee(employee);
            Console.WriteLine($"After ModifyEmployee: Name: {employee.Name}, Age: {employee.Age}");
        }
    }
}*/



