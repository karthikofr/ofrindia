using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace OfrIndia
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MailMessage msg = new MailMessage();


            //sender email address
            msg.From = new MailAddress(TextBox2.Text);
            //Recipient email address
            msg.To.Add("karthikofr@gmail.com");
            msg.Subject = TextBox3.Text;
            msg.Body = "Name: " + TextBox1.Text + "\nFrom: " + TextBox2.Text + "\nMessage: " + TextBox4.Text;




            //your remote server smtp server ip
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("sujithofr@gmail.com", "asujith5358");
            smtp.EnableSsl = true;
            smtp.Send(msg);
            //clear fields


            TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = "";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('message sent succefully Thank you for contact us');", true);
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            
            MailMessage msg = new MailMessage();


            //sender email address
            msg.From = new MailAddress(TextBox2.Text);
            //Recipient email address
            msg.To.Add("karthikofr@gmail.com");
            msg.Subject = TextBox3.Text;
            msg.Body = "Name: " + TextBox1.Text + "\nFrom: " + TextBox2.Text + "\nMessage: " + TextBox4.Text;
           

            
          
            //your remote server smtp server ip
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("michaelgofr@gmail.com", "7795249636");
            smtp.EnableSsl = true;
            smtp.Send(msg);
            //clear fields


            
            ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('message sent succefully Thank you for contact us');", true);
            TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = "";
        }
    }
}