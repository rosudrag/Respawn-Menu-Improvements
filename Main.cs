﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VRage.Plugins;
using HarmonyLib;

namespace Respawn_Menu_Improvements
{
    public class Main : IPlugin, IDisposable
    {
        public void Init(object gameInstance)
        {
            Harmony harmony = new Harmony("RespawnMenuImprovements");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }

        public void Update()
        {

        }

        public void Dispose()
        {

        }
    }
}
