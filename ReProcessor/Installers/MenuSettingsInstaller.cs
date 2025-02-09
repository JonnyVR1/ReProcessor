﻿using System;
using ReProcessor.Managers;
using Zenject;
using SiraUtil;
using ReProcessor.UI;

namespace ReProcessor.Installers
{
    internal class MenuSettingsInstaller : Installer
    {
        public override void InstallBindings()
        {
            Plugin.Log.Notice("Binding Menu Button");
            Container.BindInterfacesAndSelfTo<ButtonManager>().AsSingle();
            Container.Bind<BloomSettingsView>().FromNewComponentAsViewController().AsSingle();
            Container.Bind<BaseColorBoostViewController>().FromNewComponentAsViewController().AsSingle();
            Container.Bind<EffectManager>().FromNewComponentAsViewController().AsSingle();
            Container.Bind<OverallSettingsView>().FromNewComponentAsViewController().AsSingle();
            Container.Bind<ErrorView>().FromNewComponentAsViewController().AsSingle();
            Container.Bind<IInitializable>().To<rSettingsFlowCoordinator>().FromNewComponentOnNewGameObject(nameof(rSettingsFlowCoordinator)).AsSingle();
        }
    }
}
