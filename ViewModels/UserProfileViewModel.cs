using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace chefData.ViewModels
{
    public class UserProfileViewModel
    {
        public String EmailAddress { get; set; }
        public String Name { get; set; }
        public String ProfileImage { get; set; }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    //public static class UserProfileViewModelExtensions
    //{
    //    public static IApplicationBuilder UseMiddlewareClassTemplate(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<UserProfileViewModel>();
    //    }
    //}
}
