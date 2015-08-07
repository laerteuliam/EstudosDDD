using EstudosDDD.Data.UnityOfWork;
using EstudosDDD.Infra.CrossCutting.Ioc.Extensions;
using SimpleInjector;

namespace EstudosDDD.Infra.CrossCutting.Ioc.Containers
{
    public static class UnityOfWorkContainer
    {
        public static void RegisterUnityOfWork(this Container container)
        {
            container.BatchRegister<EstudosDDDUnityOfWork>();
        }
    }
}