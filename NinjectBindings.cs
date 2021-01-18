namespace Ninject
{
   public class NinjectBindings  : Ninject.Modules.NinjectModule
        {
            public override void Load()
            {
                Bind<ILibrero>().To<Libreria>();
            }
        }
}
