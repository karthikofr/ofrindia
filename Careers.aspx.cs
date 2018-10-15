using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace OfrIndia
{
    public partial class Careers : System.Web.UI.Page
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
            msg.Body = "Name: " + TextBox1.Text + "\nFrom: " + TextBox2.Text + "\nPhone: " + TextBox4.Text + "\nAddress: " + TextBox5.Text + "\nCity: " + TextBox6.Text + "\nState: " + TextBox7.Text + "\nPincode: " + TextBox8.Text ;
            if (FileUpload1.HasFile)
            {
                String Filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                msg.Attachments.Add(new Attachment(FileUpload1.PostedFile.InputStream, Filename));


            }
            msg.IsBodyHtml = false;
            //your remote server smtp server ip
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("michaelgofr@gmail.com", "7795249636");
            smtp.EnableSsl = true;
            smtp.Send(msg);
            //clear fields


            TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = TextBox5.Text = TextBox6.Text = TextBox7.Text = TextBox8.Text = "";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('message sent succefully Thank you for contact us');", true);
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/e/1FAIpQLScfh9HD9I5VguU1nymvtICjVHgwLR0b9z-PB8abA56Ybg-pdA/viewform");
        }

    }
}