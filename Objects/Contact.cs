using System.Collections.Generic;

namespace ContactVariables.Objects
{
  public class Contact
  {
    private string _firstName;
    private string _lastName;
    private string _address;
    private string _phoneNumber;
    private static List<Contact> _contacts = new List<Contact> {};
    public Contact (string newFirstName, string newLastName, string newAddress, string newPhoneNumber)
    {
      _firstName = newFirstName;
      _lastName = newLastName;
      _address = newAddress;
      _phoneNumber= newPhoneNumber;
      _contacts.Add(this);
    }
    public string GetFirstName()
    {
      return _firstName;
    }
    public string GetLastName()
    {
      return _lastName;
    }
    public string GetAddress()
    {
      return _address;
    }
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public string GetFullName()
    {
      return _firstName + " " + _lastName;
    }

    public static List<Contact> GetAllContacts()
    {
      return _contacts;
    }
    public static void ClearContacts()
    {
      _contacts.Clear();
    }
    public static int Find(string searchContactName)
    {
      int counter=0;
      int searchIndex=-1;
      foreach(var contact in _contacts)
      {
        if(contact.GetFullName()==searchContactName)
        {
          searchIndex=counter;
        }
        counter++;
      }
      return searchIndex;
    }
    // public static List<Artist> SearchArtists(string searchTerm)
    // {
    //   List<Artist> searchedList = new List<Artist> {};
    //   foreach(var artist in _artists)
    //   {
    //     if (artist.GetArtist().ToLower().Contains(searchTerm.ToLower()))
    //     {
    //       searchedList.Add(artist);
    //     }
    //   }
    //   return searchedList;
    // }
  }
}
