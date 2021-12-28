using SiraUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;
using IPALogger = IPA.Logging.Logger;

namespace FloatingPoint.Installers
{
    class FPInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<FloatingPointController>().AsSingle();
        }
    }
    
}
