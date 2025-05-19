using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Onder1
{
    public partial class ContactUSAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButtonNews_Click(object sender, EventArgs e)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("ondersyria@gmail.com", "realjimi2020"),
                EnableSsl = true
            };
            string dateTime = DateTime.Now.ToLongDateString() + ", at " + DateTime.Now.ToShortTimeString();
            string Message = "Message generated on " + dateTime;
            Message += "\n\n Message Sender: " + TextBoxName.Text;
            Message += "\n\n Message Email: " + TextBoxEmail.Text;
            Message += "\n\n Message Body: " + TextBoxMessage.Text;
            client.Send("ondersyria@gmail.com", "ahmad.joumah@gmail.com", TextBoxSubject.Text, Message);

        }
    }
}