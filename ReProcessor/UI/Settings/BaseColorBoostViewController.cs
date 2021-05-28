﻿using System;
using System.Collections.Generic;
using System.Linq;
using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.ViewControllers;
//using RuntimeUnityEditor.BSIPA4;
using UnityEngine.Serialization;
using Zenject;
using ReProcessor.Files;

namespace ReProcessor.UI
{
    [ViewDefinition("ReProcessor.UI.Views.BloomSettingsView.bsml")]
    [HotReload(RelativePathToLayout = @"..\UI\Views\BloomSettingsView.bsml")]
    public class BaseColorBoostViewController : BSMLAutomaticViewController
    {
        ColorBoostConfig tempConfig = Plugin.Config.preset.ColorBoost;




        [UIAction("apply-button")]
        internal void Apply()
        {
            var tc = Plugin.Config;
            tc.preset.ColorBoost = tempConfig;
            Plugin.ApplyConfig(tc);
        }
    }
}