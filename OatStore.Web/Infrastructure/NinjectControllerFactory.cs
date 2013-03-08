using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using OatStore.Data.Models;

namespace OatStore.Web.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBinding();
            
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
                                        ? null
                                        : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBinding()
        {
            ninjectKernel.Bind<IProductRepository>().To<ProductRepository>();
        }
    }
}