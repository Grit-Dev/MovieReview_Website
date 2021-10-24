using Microsoft.AspNetCore.Mvc;

namespace MMS.Web.Controllers
{
    public enum AlertType { success, danger, warning, info}
    public class BaseController : Controller //Base controller interacts with the controllers 
    {
        public void Alert(string message, AlertType type = AlertType.info)
        {
            TempData["Alert.Message"] = message; //Alert message to string

            TempData["Alert.Type"] = type.ToString(); //Alert message type to string 

            //Store Alert in TempData Storage
            
            //Allows me to display alerts within the controller index
        }
    }
}
