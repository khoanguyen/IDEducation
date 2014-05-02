using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;

namespace IDEducation.AuthServer.Models.Binders
{
    public class OAuthROCRequestBinder : IModelBinder
    {
        public bool BindModel(System.Web.Http.Controllers.HttpActionContext actionContext, ModelBindingContext bindingContext)
        {
            
            var value = new OAuthROCRequest
            {
                GrantType = GetValue(bindingContext, "grant_type"),
                Username = GetValue(bindingContext, "username"),
                Password = GetValue(bindingContext, "password"),
                Scope = GetValue(bindingContext, "scope")
            };
            actionContext.ActionArguments[bindingContext.ModelName] = value;
            return true;
        }

        private static string GetValue(ModelBindingContext context, string name)
        {
            var value = context.ValueProvider.GetValue(name);
            return value == null ? null : value.AttemptedValue;
        }
    }
}