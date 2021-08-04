using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Adapters;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OgrenciManager>().As<IOgrenciService>().SingleInstance();
            builder.RegisterType<EfOgrenciDal>().As<IOgrenciDal>().SingleInstance();

            builder.RegisterType<IslemManager>().As<IIslemService>().SingleInstance();
            builder.RegisterType<EfIslemDal>().As<IIslemDal>().SingleInstance();

            builder.RegisterType<KitapManager>().As<IKitapService>().SingleInstance();
            builder.RegisterType<EfKitapDal>().As<IKitapDal>().SingleInstance();

            builder.RegisterType<TurManager>().As<ITurService>().SingleInstance();
            builder.RegisterType<EfTurDal>().As<ITurDal>().SingleInstance();

            builder.RegisterType<YazarManager>().As<IYazarService>().SingleInstance();
            builder.RegisterType<EfYazarDal>().As<IYazarDal>().SingleInstance();

            builder.RegisterType<PersonServiceManager>().As<IPersonService>().SingleInstance();




            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
