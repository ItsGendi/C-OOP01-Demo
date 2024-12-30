using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP01
{
    internal struct Employee
    {
        private int id;
        private string name;
        private double salary;

        #region apply the encapsulation using setter getter method

        //for the id
        //public void setId(int id)
        //{
        //    this.id = id;
        //}

        //public int getId() 
        //{ 
        //    return id;
        //}

        ////for the name
        //public void setName(string name)
        //{
        //    if (name.Length >= 8 && name.Length <= 20) 
        //    this.name = name;
        //}

        //public string getName()
        //{
        //    return name;
        //}

        ////for the salary
        //public void setSalary(double salary)
        //{
        //    if (salary > 0) 
        //    this.salary = salary;
        //}

        //public double getSalary()
        //{
        //    return salary;
        //}

        // or for a better code syntax we just create a constructor 
        #endregion

        // apply Encapsulation using Properties:
        // 1. Full Property
        // For ID 
        public int Id
        {
            set 
            {
                id = value;
            }
            get 
            {
                return id;
            }
        }

        //For Name
        public string Name
        {
            set
            {
                if(value.Length >=8 && value.Length <=20) 
                name = value;
            }
            get
            {
                return name;
            }
        }

        //For Salary
        public double Salary
        {
            set
            {
                if (value > 0 )
                salary = value;
            }
            get
            {
                return salary;
            }
        }

        //2. Automatic Property
        public string Address { set; get; }
        /*Note: only used while the attributes use no logic like If conditions and others*/

        //3. Special Property (Indexer)

         


        //public Employee (int id, string name, double salary)
        //{
        //    setId(id);
        //    setName(name);
        //    setSalary(salary);
        //}
        //public override string ToString()
        //{
        //    return $"Id:{id} :: Name {name} :: Salary {salary}";
        //}
    }
}
