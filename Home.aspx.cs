using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OfrIndia
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick1(object sender, EventArgs e)
        {
            slideshow();
        }
        private void slideshow()
        {
            String url = Image8.ImageUrl;
            Image8.ImageUrl = Image7.ImageUrl;
            Image7.ImageUrl = Image6.ImageUrl;
            Image6.ImageUrl = Image5.ImageUrl;
            Image5.ImageUrl = url;
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            slideshow();
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            slideshow();
        }
    }
}