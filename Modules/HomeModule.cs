using System.Collections.Generic;
using ContactVariables.Objects;
using Nancy;

namespace ContactBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
          return View["index.cshtml"];
      };
      Get["/addcontact"] = _ => {
          return View["add_contact.cshtml"];
      };
      Post["/new_contact"] = _ =>{
        // List<Artist> allArtists = Artist.GetAllArtists();
        // int artistIndex=-1;
        // if (allArtists.Count > 0)
        // {
        //   artistIndex = Artist.Find(Request.Form["new-artist"]);
        // }
        // if (artistIndex == -1)
        // {
        //   Artist newArtist = new Artist(Request.Form["new-artist"]);
        //   newArtist.AddAlbum(Request.Form["new-album"]);
        //   return View["artist_details.cshtml", newArtist];
        // }
        // else
        // {
        //   Artist newArtist = allArtists[artistIndex];
        //   newArtist.AddAlbum(Request.Form["new-album"]);
        //   return View["artist_details.cshtml", newArtist];
        // }
        Contact newContact = new Contact(Request.Form["new-first-name"], Request.Form["new-last-name"]);
          return View ["contact_details.cshtml", newContact];
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
