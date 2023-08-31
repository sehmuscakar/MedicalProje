using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System.ComponentModel;

namespace PresentationLayer.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IContactManager _contactManager;

        private readonly IBookingManager _bookingManager;


     
        public HomeController(IContactManager contactManager, IBookingManager bookingManager)
        {
            _contactManager = contactManager;
            _bookingManager = bookingManager;
        }


        public async Task<IActionResult> Anasayfa()//Anasayfa alanı ,program cs burdan başlatıkacak buda Ana layouta bağlı çok öenmli nu ksım genel şieyleri hepsini getiriyor
        {

            return View();
        }

        public async Task<IActionResult> WhyUs()//neden biz alanı 
        {
   
            return View();
        }

        public async Task<IActionResult> Business()//kurumsal  alanı 
        {
            return View();
        }

        public async Task<IActionResult> Service()//Hizmetler  alanı 
        {
            return View();
        }

        public async Task<IActionResult> Branch()//Bölümler  alanı 
        {
            return View();
        }

        public async Task<IActionResult> Doctor()//Doktorlar alanı 
        {
            return View();
        }

        public async Task<IActionResult> Question()//sık sorulan sorular alanı 
        {
            return View();
        }


        public async Task<IActionResult> Gallery()//Galeri alanı 
        {
            return View();
        }



        [HttpGet]
        public async Task<IActionResult> Contact() //iletişim
        {
            return View();
        }
        //NETCore.MailKit bu kütüphane 
        // ve bu kütüphaneyi eklemen lazım  MimeKit 

        [HttpPost]
        public async Task<IActionResult> Contact(Contact contact)//iletişim alanı 
        {
            //gönderilecek olan kişin bilgileri
            MimeMessage mimeMessage = new MimeMessage();// minekit kütüphanesi eklemen lazım bunun için maile doğrulama yapmak için 

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Web'ten Mesajınız", "scakar542@gmail.com");//kimden geleceği isim ve mail

            mimeMessage.From.Add(mailboxAddressFrom);//kimden gelecek ekle
                                                     //alacak olan kişin bilgileri
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", contact.Mail);//kime gideği isim ve adres

            mimeMessage.To.Add(mailboxAddressTo);//kime gidecek ekle

            //  mimeMessage.Subject = contact.Subject;// bu direk mail başlığında yazar
            mimeMessage.Subject = "Mersin Sağlık Hastanesi";// bu direk mail başlığında yazar

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = "Gönderen Adı: "+contact.Name +"***"+"Konu: "+contact.Subject+"***"  + "Gönderilen Mesaj: " + contact.Message;
            mimeMessage.Body = bodyBuilder.ToMessageBody();   //mesaja ekle body kısmına 

            //mimeMessage.Subject = "Easy Cash Onay Kodu";//konu kısmı

            SmtpClient client = new SmtpClient();// mail trnsfer nesne örneği protokol
            client.Connect("smtp.gmail.com", 587, false);//prokol gereklikleri bağlantı kurma ,burda bağlatı güvenliğine false dedik çünkü ConfirmMailController da true işlemi yapacaz emailconfirmed

            client.Authenticate("scakar542@gmail.com", "qadbjdkzakguqufg");//mail ve mailde oluşturduğun güvenlik kodu,bunu her bir ayrı projede ayrı al bu güvenlik kodunu mail üzerinden bazı işlmlerle alırsın
            client.Send(mimeMessage);//gönder
            client.Disconnect(true);//gövenli çıkış yap 
                                    //bu işlemi yapman için iki adımlı doğrulamyı mail de açman lazım
            _contactManager.Add(contact);
            return View();

        }

        [HttpGet]
        public async Task<IActionResult> Booking()// randevu alanı
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Booking(Booking booking)
        {
            //gönderilecek olan kişin bilgileri
            MimeMessage mimeMessage = new MimeMessage();// minekit kütüphanesi eklemen lazım bunun için maile doğrulama yapmak için 

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Randevu Bilgileriniz", "scakar542@gmail.com");//kimden geleceği isim ve mail

            mimeMessage.From.Add(mailboxAddressFrom);//kimden gelecek ekle
                                                     //alacak olan kişin bilgileri
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", booking.Mail);//kime gideği isim ve adres

            mimeMessage.To.Add(mailboxAddressTo);//kime gidecek ekle

            mimeMessage.Subject = "Mersin Sağlık Hastanesi";// bu direk mail başlığında yazar
           

            var bodyBuilder = new BodyBuilder();      
            bodyBuilder.TextBody = "Randevunuz başarılı bir şeklide oluşturlmuştur." +"***"+ "Hasta Adı:" + "" + booking.Name +"***"+ "Poliklinik:" + "" + booking.Branch+"***"
                + "Doktorunuz:" + "" + booking.Doctor+"***"+ "Randevu Tarihi:" + "" + booking.Tarih;
   

            mimeMessage.Body = bodyBuilder.ToMessageBody();   //mesaja ekle body kısmına 

            //mimeMessage.Subject = "Easy Cash Onay Kodu";//konu kısmı

            SmtpClient client = new SmtpClient();// mail trnsfer nesne örneği protokol
            client.Connect("smtp.gmail.com", 587, false);//prokol gereklikleri bağlantı kurma ,burda bağlatı güvenliğine false dedik çünkü ConfirmMailController da true işlemi yapacaz emailconfirmed

            client.Authenticate("scakar542@gmail.com", "qadbjdkzakguqufg");//mail ve mailde oluşturduğun güvenlik kodu,bunu her bir ayrı projede ayrı al bu güvenlik kodunu mail üzerinden bazı işlmlerle alırsın
            client.Send(mimeMessage);//gönder
            client.Disconnect(true);//gövenli çıkış yap 
                                    //bu işlemi yapman için iki adımlı doğrulamyı mail de açman lazım
            _bookingManager.Add(booking);
            return View();
        }




    }
}