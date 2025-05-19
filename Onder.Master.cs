using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Onder1
{
    public partial class Onder : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Page.IsPostBack == false)
            //{
            //Dropdown Menu
            DropDownLearning.PostBackUrl = Class1.ToSectorByName("التعليم");
            DropDownCulture.PostBackUrl = Class1.ToSectorByName("الثقافة");
            DropDownSociety.PostBackUrl = Class1.ToSectorByName("التنمية");
            DropDownSport.PostBackUrl = Class1.ToSectorByName("الرياضة");
            //}
        }
        
        
    }
}