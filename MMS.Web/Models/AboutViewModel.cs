 using System;
    
    namespace MMS.Web.Models
    {
       public class AboutViewModel
       {
          public string Title { get; set; } //fetching the title
          public string Message { get; set; } //fetching the message

          public string NameOfCreator { get; set; } //fetching the Name of the creator I.E me

          public string TitleOfCreator { get; set; } // My title

          public string InfoOnCreator { get; set; } // A little bit of infor for me 

          public string Url { get; set; } //url to the link I have posted
          public DateTime Formed { get; set; } = DateTime.Now;
          public string FormedString => Formed.ToLongDateString();
          public int Days => (DateTime.Now - Formed).Days;

        //I am not using any requirements due to it is only me using it for the about page 
       }
    }
    