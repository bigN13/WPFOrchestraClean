namespace Orchestra.Modules.MyModule1
{
    using Catel.MVVM;
    using Catel.MVVM.Services;
    using Orchestra.Models;
    using Orchestra.Modules;
    using Orchestra.Services;

    /// <summary>
    /// The module.
    /// </summary>
    public class MyModule1 : Orchestra.Modules.ModuleBase
    {
        /// <summary>
        /// Initializes the module.
        /// </summary>
        public MyModule1()
            : base("MyModule")
        {
        }

        /// <summary>
        /// Called when the module is initialized.
        /// </summary>
        protected override void OnInitialized()
        {
           

            // TODO: Handle additional initialization code
        }

         /// <summary>
        /// Initializes the ribbon.
        /// <para />
        /// Use this method to hook up views to ribbon items.
        /// </summary>
        /// <param name="ribbonService">The ribbon service.</param>
        protected override void InitializeRibbon(IRibbonService ribbonService)
        {
            var orchestraService = GetService<IOrchestraService>();

            //TODO: Register ribbon items
            var openRibbonItem = new RibbonItem(ModuleName, ModuleName, "Action name", new Command(() =>
            {
                // Action to invoke
            }));
            //orchestraService.AddRibbonItem(openRibbonItem);

            ribbonService.RegisterRibbonItem(openRibbonItem);
            ribbonService.RegisterRibbonItem(new RibbonButton(HomeRibbonTabName, ModuleName, "Open", new Command(() => { })) { ItemImage = "/Resources/Images/action_browse.png" });


        }
    }
}