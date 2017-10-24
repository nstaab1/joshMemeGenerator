using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;

namespace Project.Web.Models
{
    public class Card
    {
        public int CardId { get; set; }
        public int TemplateId { get; set; }
        public string ImageName{ get; set; }
        public string ToEmail { get; set; }
        public string ToName  { get; set; }
        public string MessageLineOne { get; set; }
        public string MessageLineTwo { get; set; }
        public string FromName { get; set; }
        public string FromEmail { get; set; }



        public void SaveImage()
        {
            Bitmap bitMapImage = new
            System.Drawing.Bitmap(HttpContext.Current.Server.MapPath("~/content/images/memephotos/" + this.ImageName));
            Graphics graphicImage = Graphics.FromImage(bitMapImage);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;

            //Rectangle for message one
            float x = 0.0F;
            float y = 10.0F;
            float width = 1080.0F;
            float height = 200.0F;
            RectangleF drawRect = new RectangleF(x, y, width, height);

            //Rectangle for message two
            float xTwo = 0.0F;
            float yTwo = 1100.0F;
            float widthTwo = 1080.0F;
            float heightTwo = 200.0F;
            RectangleF drawRect2 = new RectangleF(xTwo, yTwo, widthTwo, heightTwo);


            graphicImage.DrawString(MessageLineOne,
            new Font("Impact", 80, FontStyle.Bold),
            new SolidBrush(Color.White), drawRect, sf);
            graphicImage.DrawString(MessageLineTwo,
            new Font("Impact", 80, FontStyle.Bold),
            new SolidBrush(Color.White), drawRect2, sf);
            //need to figure out how to save to ASP
            //Bitmap bitMapNew = Bitmap.FromHbitmap(graphicImage.GetHdc());
            //bitMapNew.Save("bitmaptest.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            bitMapImage.Save(HttpContext.Current.Server.MapPath("~/Content/Images/SavedMemes/") + this.ImageName, ImageFormat.Jpeg);
            bitMapImage.Save((@"C:\Users\Nathan Staab\Desktop\SavedMemes\" + this.ImageName), ImageFormat.Jpeg);
            graphicImage.Dispose();
            bitMapImage.Dispose();
        }
    }

    
}