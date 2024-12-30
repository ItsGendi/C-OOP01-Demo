using System.Drawing;

namespace C__OOP01
{
    internal class Program
    {
        private static object phonebook;

        static void Main(string[] args)
        {
            #region Struct
            /*
                 **Struct : is a value type that will be stored in the Stack


                 */
            //    Point01 p01;
            //    /*1. Declaring the object from Pointer type
            //      2. P01: is an Object
            //      3. Allocating a space of 8 bytes in the stack
            //        3.1. 4 bytes for X value and 4 bytes for Y value

            //     */
            //    //assign values for x and y 
            //    //p01.x = 12;
            //    //p01.y = 12;

            //    p01 = new Point();
            //    /* what does the new statement do? 
            //     - used for selecting the constructor
            //        - Q) what is a constructor ? 
            //        - A) its a special method; named like the struct and it has no return type
            //     - CLR : will create a parameterless constructor
            //     - this constructor will initialize the atrributes will the default value 
            //     */
            //    Console.WriteLine(p01.x);
            //    Console.WriteLine(p01.y);
            //}

            // constructor
            //public Point()
            //{
            //} 
            #endregion

            /* OOP: Object Oriented Programming
                - its a programing paradigm
                - used to simulate the reality of dialy bases such as business and others
                - OOP is consisted of two basic pilars : 
                    1- Class : blueprint of the object               
                    2- Object : Specific instant of the class

                - OOP is based on 4 pilars: 
                    1- Encapsulation.
                    2- Inheritance.
                    3- Polymorphism.
                    4- Abstraction.

                1- Encapsulation : is simply the process of seperating the 
                data => (Attributes) definition from its usage.
             */

            #region Encapsulation using setter/getter method
            //Employee E01 = new Employee();
            //E01.id = 1;
            //E01.name = "Gendi";
            //E01.salary = 12500;
            //Console.WriteLine(E01.id);
            //Console.WriteLine(E01.name);
            //Console.WriteLine(E01.salary);

            /* using the previous method is not the best practice for these reasons : 
            1- End Use can easily access the data itself
            2- No Data Validation
            3- No Read only filed 

            but by using Encapsulation method: 
            1. Make all the Data (Attributes) Private
            2. Access the data by using any of the two methods
                2.1 setter getter method
                2.2 properties method

             */

            //without constructor
            //Employee E01 = new Employee();
            //E01.setId(1);
            //E01.setName("Ahmed Gendi");
            //E01.setSalary(12500);

            //Console.WriteLine(E01.getId());
            //Console.WriteLine(E01.getName());
            //Console.WriteLine(E01.getSalary());

            //with constructor
            //Employee E02 = new Employee(2,"Ahmed gamal",16500);
            //Console.WriteLine(E02);

            /*Important Note 01: in order to make a specific value read only we
             *have to remove its **setter** method
              
              Important Note 02: A struct is always presented in the stack
             
             */
            #endregion

            #region Encapsulation using Properties method
            // using properties

            //Employee E01 = new Employee();
            //E01.Id = 12;
            //E01.Name = "Ahmed Algendy";
            //E01.Salary = 12640;
            //E01.Address = "Egypt, cairo, El Hosary Square";
            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.Name);
            //Console.WriteLine(E01.Salary);
            //Console.WriteLine(E01.Address);

            //Phonebook phonebook = new Phonebook(3);
            //phonebook.AddPerson("Ahmed", 01018145957, 1);
            //phonebook.AddPerson("Ali", 01012323312, 2);
            //phonebook.AddPerson("Omar", 0101432344, 3);
            //Console.WriteLine(phonebook.GetNumber("Ahmed"));
            //phonebook.UpdateNumbers("Ahmed", 999);
            //Console.WriteLine(phonebook.GetNumber("Ahmed"));

            //Indexers code
            /*
             1- named this
             */


            //phonebook["Ahmed"] = 0102321312;
            //Console.WriteLine(phonebook["Ahmed"]);

            /*
             - Class: Reference type that will be stored in HEAP
             
             */

            #endregion

            Car C01;
            // declaring the reference for the Pointer from the type "Car"
            // C01: can refer to Object from type 'Car' or any class inhertitence
            // C01: refer to null

            // 8 bytes will be allocated at stack for the ref C01 at stack
            // 0 bytes will be allocated at Heap for the ref C01 at stack
            C01 = new Car(1,300,"Z360");
            // 1- allocate the number of required bytes at HEAP for the object
            // 2- Initialize the allocated Bytes with the defualt values of the datatype
            // 3- Call User-Defined Constructor if exists
            // 4- Assign the object to the reference
            Console.WriteLine(C01.Id);
            Console.WriteLine(C01.Speed);
            Console.WriteLine(C01.Model);
            Console.WriteLine(C01);




    }
}
}