using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class MyClass:IPropertyChanged
    {
        private int age;
        private int id;
        private string name;
        public int Age { get {
                return age;
            } set {
                age = value; 
                PropertyChanged.Invoke(this, new PropertyEventArgs($"The Age property has changed to {value}.")); } }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                PropertyChanged.Invoke(this, new PropertyEventArgs($"The Name property has changed to {value}."));
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                PropertyChanged.Invoke(this, new PropertyEventArgs($"The Id property has changed to {value}."));
            }
        }
        public MyClass(int age,string name,int id)
        {
            this.age = age;
            this.name = name;
            this.id = id;
        }

        public event PropertyEventHandler PropertyChanged;
    }
}
