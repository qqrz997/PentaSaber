﻿using IPA;
using IPA.Config;
using IPA.Config.Stores;
using IPA.Loader;
using PentaSaber.HarmonyPatches.Manager;
using SiraUtil.Zenject;
using IPALogger = IPA.Logging.Logger;

namespace PentaSaber
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        internal static Plugin Instance { get; private set; } = null!;
        internal static PluginConfig Config { get; private set; }
        /// <summary>
        /// Use to send log messages through BSIPA.
        /// </summary>
        internal static IPALogger Log { get; private set; } = null!;

        [Init]
        public Plugin(IPALogger logger, Config conf, Zenjector zenjector)
        {
            Instance = this;
            Log = logger;
            Config = conf.Generated<PluginConfig>();
            zenjector.UseLogger(logger);
            zenjector.Install<PentaSaberInstaller>(Location.StandardPlayer);
        }


        [OnStart]
        public void OnApplicationStart()
        {
            Plugin.Log.Info("OnApplicationStart");
        }

        [OnExit]
        public void OnApplicationQuit()
        {

        }

    }
}
