using System;
using System.Collections.Generic;
using AnimalHierarchy.Models;
using AnimalHierarchy.Presenters;
using AnimalHierarchy.Types;
using Ninject;
using Ninject.Parameters;

namespace AnimalHierarchy.BindingModules
{
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Security.Cryptography.X509Certificates;
    using Ninject.Extensions.Conventions;
    using Ninject.Modules;
    using Ninject.Extensions.Factory;

    using AnimalHierarchy.Interfaces;

    public class AnimalHierarchyModule : NinjectModule
    {
        private const string DogName = "Dog";
        private const string CatName = "Cat";
        private const string KittyName = "Kitty";
        private const string TomCatName = "TomCat";
        private const string FrogName = "Frog";

        public override void Load()
        {
            /* this.Kernel.Bind(x =>
             {
                 x.FromAssembliesInPath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
                 .SelectAllClasses()
                 .BindDefaultInterface();
             });*/

            this.Bind<IAnimal>().To<Cat>().Named(CatName);
            this.Bind<IAnimal>().To<Kitten>().Named(KittyName);
            this.Bind<IAnimal>().To<TomCat>().Named(TomCatName);
            this.Bind<IAnimal>().To<Dog>().Named(DogName);
            this.Bind<IAnimal>().To<Frog>().Named(FrogName);

            /* this.Bind<IAnimal>()
                 .ToMethod(context =>
                 {
                     List<IParameter> contextParams = context.Parameters.ToList();
                     return context.Kernel.Get<Cat>(KittyName, contextParams[2],
                         new ConstructorArgument(KittyName, context.Kernel.Get<Cat>(contextParams[0], contextParams[1])));
                 }).NamedLikeFactoryMethod((IAnimalFactory animalFactory) => animalFactory.GetKittyAnimal(null, 0));*/

            this.Bind<IAnimalFactory>().To<AnimalFactory>().InSingletonScope();

            this.Bind<IAnimal>().To<Kitten>().Named(KittyName);

            this.Bind<IAnimal>().To<TomCat>().Named(TomCatName);

            this.Bind<IAnimal>().To<Cat>().Named(CatName);

            this.Bind<IAnimal>().To<Dog>().Named(DogName);

            this.Bind<IAnimal>().To<Frog>().Named(FrogName);

            this.Bind<IAnimalHerarchyConsolePresenter>().ToConstant(AnimalHerarchyConsolePresenter.Instance).InSingletonScope();
        }
    }
}