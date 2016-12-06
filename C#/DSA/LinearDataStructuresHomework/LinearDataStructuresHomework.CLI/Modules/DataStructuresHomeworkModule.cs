using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Ninject.Extensions.Conventions;
using Ninject.Modules;

using LinearDataStructuresHomework.Data;
using LinearDataStructuresHomework.Data.Contracts;
using LinearDataStructuresHomework.Data.Core;
using Ninject;
using Ninject.Extensions.Factory;

namespace LinearDataStructuresHomework.CLI.Modules
{
    public class DataStructuresHomeworkModule : NinjectModule
    {
        public override void Load()
        {
            this.Kernel.Bind(x =>
            {
                x.FromAssembliesInPath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
                    .SelectAllClasses()
                    .BindDefaultInterface();
            });

            this.Bind<ITasker>().To<ListTasker>().InSingletonScope().Named("ListTasker");
            this.Bind<ITasker>().To<StackTasker>().InSingletonScope().Named("StackTasker");
            this.Bind<ITasker>().To<ArrayTasker>().InSingletonScope().Named("ArrayTasker");

            this.Bind<UInt32>().ToSelf().WhenInjectedExactlyInto<ArrayTasker>();

            this.Bind<IReadWriteProvider>().To<ConsoleReadWriteProvider>();
            this.Bind<IPresenter>().To<Presenter>().InSingletonScope();
            this.Bind<ITaskerFactory>().ToFactory().InSingletonScope();

            this.Bind<ITasker>().ToMethod(context =>
            {
                Type type = (Type)context.Parameters.Single().GetValue(context, null);
                return (ITasker)context.Kernel.Get(type);
            }).NamedLikeFactoryMethod((ITaskerFactory commandFactory) => commandFactory.GetTasker(null));
        }
    }
}