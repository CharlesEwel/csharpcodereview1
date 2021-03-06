using System.Collections.Generic;
using ContactVariables.Objects;
using Nancy;

namespace ContactBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/addcontact"] = _ => View["add_contact.cshtml"];
      Post["/new_contact"] = _ =>
      {
        List<Contact> allContacts = Contact.GetAllContacts();
        int contactIndex=-1;
        string newFullName = (Request.Form["new-first-name"])+" "+(Request.Form["new-last-name"]);
        if (allContacts.Count > 0)
        {
          contactIndex = Contact.Find(newFullName);
        }
        if (contactIndex == -1)
        {
          Contact newContact = new Contact(Request.Form["new-first-name"],
                                          Request.Form["new-last-name"],
                                          Request.Form["new-address"],
                                          Request.Form["new-phone-number"]);
          return View["contact_created.cshtml", newContact];
        }
        else
        {
          return View["contact_exists_already.cshtml", newFullName];
        }
      };
      Post["/contacts_deleted"] = _ =>
      {
        Contact.ClearContacts();
        return View["contacts_deleted.cshtml"];
      };
      Get["/{detailsContact}"] = parameters => {
        List<Contact> allContacts = Contact.GetAllContacts();
        Contact currentContact = allContacts[Contact.Find(parameters.detailsContact)];
        return View ["contact_details.cshtml", currentContact];
      };
      Get["/contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAllContacts();
        return View["contacts.cshtml", allContacts];
      };
      // Post["/search_list"] = _ => {
      //   List<Artist> searchedList = Artist.SearchArtists(Request.Form["search-artist"]);
      //   return View["view_all_artists.cshtml", searchedList];
      // };
      // Get["/search_form"] = _ =>{
      //   return View["search_form.cshtml"];
      // };
    }
  }
}
