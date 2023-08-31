using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entities;

namespace PresentationLayer.Extensions
{
    public static class ServiceExtension
    {
        public static void MyconfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ITopbarManager, TopbarManager>();
            services.AddScoped<ITopbarDal, TopbarDal>();

            services.AddScoped<IWhyUsManager, WhyUsManager>();
            services.AddScoped<IWhyUsDal, WhyUsDal>();

            services.AddScoped<IBusinessManager, BusinessManager>();
            services.AddScoped<IBusinessDal, BusinessDal>();

            services.AddScoped<ICountManager, CountManager>();
            services.AddScoped<ICountDal, CountDal>();

            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IServiceDal, ServiceDal>();

            services.AddScoped<IBranchManager, BranchManager>();
            services.AddScoped<IBranchDal, BranchDal>();

            services.AddScoped<IDoctorManager, DoctorManager>();
            services.AddScoped<IDoctorDal, DoctorDal>();

            services.AddScoped<IBookingManager, BookingManager>();
            services.AddScoped<IBookingDal, BookingDal>();

            services.AddScoped<IContactManager, ContactManager>();
            services.AddScoped<IContactDal, ContactDal>();

            services.AddScoped<IFooterManager, FooterManager>();
            services.AddScoped<IFooterDal,FooterDal>(); 

            services.AddScoped<IQuestionManager, QuestionManager>();
            services.AddScoped<IQuestionDal, QuestionDal>();

            services.AddScoped<IGalleryManager, GalleryManager>();
            services.AddScoped<IGalleryDal, GalleryDal>();
        }
    }
}
