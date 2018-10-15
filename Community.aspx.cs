using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace OfrIndia
{
    public partial class Community : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
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
            msg.Body = "Name: " + TextBox1.Text + "\nEmail: " + TextBox2.Text + "\nPhone: " + TextBox3.Text + "\ncity: " + TextBox4.Text + "\nState: " + TextBox5.Text;




            //your remote server smtp server ip
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("michaelgofr@gmail.com", "7795249636");
            smtp.EnableSsl = true;
            smtp.Send(msg);
            //clear fields



            ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('message sent succefully Thank you for contact us');", true);
            TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = TextBox5.Text = "";
        }
    }
}