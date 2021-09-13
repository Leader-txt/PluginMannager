using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TShockAPI;
using Terraria;
using TerrariaApi.Server;
using Microsoft.Xna.Framework;

namespace PM_SerPlugin
{
    [ApiVersion(2, 1)]
    public class PM_SerPlugin : TerrariaPlugin
    {
        /// <summary>
        /// Gets the author(s) of this plugin
        /// </summary>
        public override string Author => "Leader";

        /// <summary>
        /// Gets the description of this plugin.
        /// A short, one lined description that tells people what your plugin does.
        /// </summary>
        public override string Description => "插件管理器前置服务器端插件";

        /// <summary>
        /// Gets the name of this plugin.
        /// </summary>
        public override string Name => "Plugin Mannager-Server plugin";

        /// <summary>
        /// Gets the version of this plugin.
        /// </summary>
        public override Version Version => new Version(1, 0, 0, 0);

        const string PluginPath = "ServerPlugins/";
        /// <summary>
        /// Initializes a new instance of the PM_SerPlugin class.
        /// This is where you set the plugin's order and perfrom other constructor logic
        /// </summary>
        public PM_SerPlugin(Main game) : base(game)
        {

        }
        /// <summary>
        /// Handles plugin initialization. 
        /// Fired when the server is started and the plugin is being loaded.
        /// You may register hooks, perform loading procedures etc here.
        /// </summary>
        public override void Initialize()
        {

        }

        /// <summary>
        /// Handles plugin disposal logic.
        /// *Supposed* to fire when the server shuts down.
        /// You should deregister hooks and free all resources here.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Deregister hooks here
            }
            base.Dispose(disposing);
        }
    }
}