using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
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
            builder.RegisterType<OgrenciManager>().As<IOgrenciServis>().SingleInstance();
            builder.RegisterType<EfOgrenciDal>().As<IOgrenciDal>().SingleInstance();

            builder.RegisterType<IslemManager>().As<IIslemServis>().SingleInstance();
            builder.RegisterType<EfIslemDal>().As<IIslemDal>().SingleInstance();

            builder.RegisterType<KitapManager>().As<IKitapServis>().SingleInstance();
            builder.RegisterType<EfKitapDal>().As<IKitapDal>().SingleInstance();

            builder.RegisterType<TurManager>().As<ITurServis>().SingleInstance();
            builder.RegisterType<EfTurDal>().As<ITurDal>().SingleInstance();

            builder.RegisterType<YazarManager>().As<IYazarServis>().SingleInstance();
            builder.RegisterType<EfYazarDal>().As<IYazarDal>().SingleInstance();




            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
