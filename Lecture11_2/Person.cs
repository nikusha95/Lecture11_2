namespace Lecture11_2;

public class Person
{
    private string _firstName;
    private string _lastName;
    private DateTime _birthDate;

    public Person(string firstName, string lastName, DateTime birthDate)
    {
        _lastName = lastName;
        _birthDate = birthDate;
        _firstName = firstName;
    }

    public string FirstName
    {
        get => _firstName;
        set
        {
            if (value.Length < 3)
            {
                throw new InvalidLengthException("invalid length", "info for customer");
            }

            _firstName = value;
        }
    }

    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }

    public int Age
    {
         get => Convert.ToInt32(DateTime.Now - _birthDate);
        //get => DateTime.Now.Year - _birthDate.Year;
        set => _birthDate = DateTime.Now.AddYears(-value);
    }
}