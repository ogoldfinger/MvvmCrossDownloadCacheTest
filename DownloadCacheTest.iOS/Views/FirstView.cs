using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.iOS.Views;

namespace DownloadCacheTest.iOS.Views
{
    public partial class FirstView : MvxViewController
    {
		private readonly MvxImageViewLoader _imageViewLoader;

        public FirstView() : base("FirstView", null)
        {
			_imageViewLoader = new MvxImageViewLoader(() => imgTest);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel>();
            set.Bind(Label).To(vm => vm.Hello);
            set.Bind(TextField).To(vm => vm.Hello);

			set.Bind (_imageViewLoader).To (vm => vm.ImageUrl);

            set.Apply();
        }
    }
}
