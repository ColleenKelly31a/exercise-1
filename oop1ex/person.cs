namespace oop1ex
{
    public class Person
    {
        //variables/fields
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        

        
        //Constructor
        //called to set field values of each new object when instantiated in Main method
        public Person(string firstName, string lastName, DateTime dateOfBirth )
        {
            
           
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            
        }


        //properties
        //get accessor = used to return the property value
        //set accessor = used to assign a new value
        //value keyword = defines the value being assigned by the set (parameter) 
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
  
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
            
        }
        public DateTime DateOfBirth
        {
             get { return dateOfBirth; }
             set { dateOfBirth = value; }
            
        }
    }
}


