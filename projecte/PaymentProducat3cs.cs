using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace projecte
{
    public partial class PaymentProducat3cs : Form
    {
        public PaymentProducat3cs()
        {
            InitializeComponent();
        }

        private void bttnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                Document document = new Document(iTextSharp.text.PageSize.LETTER, 25, 25, 30, 30);
                PdfWriter pw = PdfWriter.GetInstance(document, ms);
                PdfWriter.GetInstance(document, new FileStream("C:/Rahul/a23.pdf", FileMode.Create));

                //document.AddImage(png);
                document.Open();
                var image = iTextSharp.text.Image.GetInstance("C:\\Users\\LENOVO\\Documents\\16-3-2023\\projecte2023\\projecte\\Resources\\Image.jpeg");
                image.Alignment = Element.ALIGN_MIDDLE;
                document.Add(image);

                Paragraph p = new Paragraph("Dear:" + login.SetValueForText1 + "\n\nThis is your Detiles Payment:\n\n " + "  " + " Plase paye 5 OR TO complete your Payment for More Information connect as in our phone: 97454075.           \n Appreciate your cooperationr  \n\nKind Regards,            \n\nEFAH Team.\n\n ");
                document.Add(p);

                PdfPTable table = new PdfPTable(4);
                table.AddCell("ID");
                table.AddCell("Size");
                table.AddCell("Color");
                table.AddCell("Price");
                table.AddCell(Producat3.SetValueForText5);
                table.AddCell(Producat3.SetValueForText1);
                table.AddCell(Producat3.SetValueForText2);
                table.AddCell(Producat3.SetValueForText4);

                document.Add(table);


                document.Close();
                byte[] bytstrm = ms.ToArray();
                ms.Write(bytstrm, 0, bytstrm.Length);
                ms.Position = 0;
                //return new FileStreamResult(ms)
                //Response.ContentType = "pdf/application";
                //Response.GetType = "x";
            }
            catch (Exception ex)
            {
            }

            MailMessage newMessage = new MailMessage();
            SmtpClient mailService = new SmtpClient();
            newMessage.From = new MailAddress("efah2023@gmail.com");
            newMessage.To.Add(login.SetValueForText1);
            newMessage.To.Add("rootalrashdi@gmail.com");



            newMessage.Subject = "EFAH Team";
            newMessage.Body = "";
            //Attachment oAttachment = newMessage.AddAttachment("d:\\test.gif");
            Attachment attachment = new Attachment("C:\\Users\\LENOVO\\Documents\\16-3-2023\\projecte2023\\projecte\\Resources\\بروفايل1-عفة.jpg");
            newMessage.Attachments.Add(attachment);
            Attachment attachment2 = new Attachment("C:/Rahul/a23.pdf");

            newMessage.Attachments.Add(attachment2);
            //newMessage.Attachments.Add(new Attachment("document"));
            mailService.EnableSsl = true;
            mailService.DeliveryMethod = SmtpDeliveryMethod.Network;
            mailService.Host = "smtp.gmail.com";
            mailService.UseDefaultCredentials = false;
            mailService.Credentials = new NetworkCredential("efah2023@gmail.com ", "bxitpyyuuzunbsfv");
            mailService.Send(newMessage);
            System.Diagnostics.Process.Start("C:/Rahul/a23.pdf");
            MessageBox.Show("Maile was Sent To Your Email With Detiles", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void PaymentProducat3cs_Load(object sender, EventArgs e)
        {
            label8.Text = Producat3.SetValueForText1;
            label9.Text = Producat3.SetValueForText2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Producat3 p3 = new Producat3();
            p3.ShowDialog();
        }
    }
}
