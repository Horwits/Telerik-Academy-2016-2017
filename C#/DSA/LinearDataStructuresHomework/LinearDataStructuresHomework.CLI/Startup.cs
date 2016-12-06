using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearDataStructuresHomework.CLI.Modules;
using LinearDataStructuresHomework.Data.Core;
using Ninject;

namespace LinearDataStructuresHomework.CLI
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var kernel = new StandardKernel(new DataStructuresHomeworkModule());
            var presenter = kernel.Get<Presenter>();
             //presenter.PresentListTasks();
             //presenter.PresentStackTasks();
             presenter.PresentArrayTasks();
        }
    }
}
