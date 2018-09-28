namespace AllyXBodyBlocker
{
    using System.Collections.Generic;
    using System.ComponentModel.Composition;

    using Ensage.SDK.Menu;
    using Ensage.SDK.Service;
    using Ensage.SDK.Service.Metadata;

    using Modes;

    [ExportPlugin("Ally X Body Blocker", StartupMode.Auto, "Exassasinx")]
    internal class Bootstrap : Plugin
    {
        private MenuFactory factory;

        [ImportMany]
        private IEnumerable<IBodyBlockMode> modes;

        protected override void OnActivate()
        {
            factory = MenuFactory.Create("Ally X Body Blocker", "xdbodyBlocker");

            foreach (var mode in modes)
            {
                mode.Activate();
            }
        }

        protected override void OnDeactivate()
        {
            foreach (var mode in modes)
            {
                mode.Dispose();
            }

            factory.Dispose();
        }
    }
}