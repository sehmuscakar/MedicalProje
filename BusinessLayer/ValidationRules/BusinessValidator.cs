using DataAccessLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    // Validation Rules :Doğrulama Kuralları , nu validayomlar için fluent kütüphanesi ve başka bi fluen ile ilgili iki kütüphane lazım yuklenen kütüphanelere bak burdakielere business dakilere
    //fluentValidation
    //fluentValidation.Asp.net.Core
    //fluentValidation.DependecyInjectionExtensions bu kütphaneleri eklemen lazım ilgili katmana 
    public class BusinessValidator : AbstractValidator<Business>
    {
        //ctor
        public BusinessValidator() //bunu kullanmaadım ilgili controllerda 
        {
            RuleFor(x => x.About).NotEmpty().WithName("Hakımızda").WithMessage("HaKKIMIZDA kısmı boş geçilemez");



        }
    }
}
