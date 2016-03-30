using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform.Platform;
using UIKit;
using MvvmCross.Platform.Plugins;

namespace DownloadCacheTest.iOS
{
    public class Setup : MvxIosSetup
    {
        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }
        
        public Setup(MvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
        
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

		protected override void AddPluginsLoaders (MvxLoaderPluginRegistry registry)
		{
			registry.AddConventionalPlugin<MvvmCross.Plugins.DownloadCache.iOS.Plugin>();
			registry.AddConventionalPlugin<MvvmCross.Plugins.File.iOS.Plugin>();

			base.AddPluginsLoaders (registry);
		}

		protected override void InitializeLastChance ()
		{	
			MvvmCross.Plugins.DownloadCache.PluginLoader.Instance.EnsureLoaded();
			MvvmCross.Plugins.File.PluginLoader.Instance.EnsureLoaded();
			MvvmCross.Plugins.Json.PluginLoader.Instance.EnsureLoaded();

			base.InitializeLastChance ();
		}
    }
}
