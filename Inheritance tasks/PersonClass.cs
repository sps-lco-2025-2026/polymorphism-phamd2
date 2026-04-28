using System.Dynamic;


namespace Inheritance_Tasks;


public class Person
{
   private string _firstName ;
   private string _lastName;
   private string _emailAddress;
   private string _dateofBirth;


  


   public Person(string firstname, string lastname, string dob, string email)
   {
      _firstName = firstname;
      _lastName = lastname;
      _dateofBirth = dob;
      _emailAddress = email;
   }


   public Person(string firstname, string lastname, string dob)
   {
      _firstName = firstname;
      _lastName = lastname;
      _dateofBirth = dob;
     
   }


   internal int CalculateAge()
   {
       DateTime dobDateTime = DateTime.Parse(_dateofBirth);
       int age = DateTime.Now.Year - dobDateTime.Year;
       if (dobDateTime > DateTime.Now.AddYears(-age)) 
        age--;
       return age;
   }


   internal bool checkAge()
   {
       if (CalculateAge()<=0)
           return false;
       else
           return true;
   }


   public bool checkAdult()
   {  
       DateTime dobDateTime;
       return DateTime.TryParse(_dateofBirth, out dobDateTime);


   }


   public string ChineseSign()
   {
           DateTime dob = DateTime.Parse(_dateofBirth);
           int year = dob.Year;
          
           string[] signs = {
               "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake",
               "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig"
           };


           int offset = (year - 1900) % 12;
           return signs[offset];
   }


   public bool IsBirthday()
   {
           DateTime dob = DateTime.Parse(_dateofBirth);
           return dob.Month == DateTime.Today.Month && dob.Day == DateTime.Today.Day;
   }


   public string screenName()
   {
       DateTime dob = DateTime.Parse(_dateofBirth);
       string firstInitial = _firstName.Substring(0, 1).ToLower();
       string lastName = _lastName.Replace(" ", "").ToLower();


       string username = $"{firstInitial}{lastName}{dob.Month}{dob.Day}";
       return username;
      
   }
}





  

