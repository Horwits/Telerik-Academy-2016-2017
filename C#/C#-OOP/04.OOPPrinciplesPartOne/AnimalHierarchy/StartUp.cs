using AnimalHierarchy.BindingModules;
using AnimalHierarchy.Interfaces;
using Ninject;

namespace AnimalHierarchy
{
    internal class StartUp
    {
        internal static void Main(string[] args)
        {
            var kernel = new StandardKernel(new AnimalHierarchyModule());

            var factory = kernel.Get<IAnimalFactory>();

            var hierarchy = kernel.Get<IAnimalHerarchyConsolePresenter>();
            hierarchy.ShowAnimalsAbstraction(factory);
        }
    }
}
