namespace _001_Practice
{
    public class Person
    {
        //data or field
        public string name;
        public int age;
        public string address; 

        //overloading constructors
        public Person()
        {
            name = "jackson"; 
        }

        public Person(string name)
        {
            this.name = name; 
        }

        public Person(string name, int age)
            :this(name)
        {
            //this.name = name;
            this.age = age;
        }

        public Person(string name, int age, string address)
            :this(name, age)
        {
            this.address = address; 
        }

        public void SetName(string name)
        {
            this.name = name; 
        }

        public string GetInfo()
        {
            return $"Name : {name}, Age : {age}, Address : {address}"; 
        }
    }

}
