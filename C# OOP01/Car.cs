using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP01
{
    internal class Car
    {
      
        #region Attributes
        private int id; // 4 Bytes
        private int speed; // 4 Bytes
        private string model; // 8 Bytes
        #endregion

        #region Properties
        //Model
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        //Speed 
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        //Id 
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        public override string ToString()
        {
            return $"Id:{Id} :: Speed:{Speed} :: Model:{Model}";
        }
        // CLR will always create a parameterless constructor
        // this constructor do nothing and has no effect
        //public Car() 
        //{ 
        //    Id = default;
        //    Model = default;
        //    Speed = default;
        //}

        //Chaining Constructor
        public Car(int id, int speed, string model) :this(id,speed)
        {
            //Id = id ;
            //Speed = speed;
            Model = model;
        }

        public Car(int id, int speed) :this(id)
        {
            //Id = id;
            Speed = speed;
        }

        public Car(int id)
        {
            Id = id;
         
        }

        /*
         **Important Note: bby creating any new constructor by user this means 
         the user will override over the default constructor that existed before 
         */
    }


}
