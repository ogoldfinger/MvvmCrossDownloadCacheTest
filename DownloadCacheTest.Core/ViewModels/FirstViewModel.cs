using MvvmCross.Core.ViewModels;

namespace DownloadCacheTest.Core.ViewModels
{
    public class FirstViewModel  : MvxViewModel
    {
		public FirstViewModel() {
			this.ImageUrl = "http://jonathanroux.com/wp-content/uploads/2016/02/articleCover.png";
		}

        private string _hello = "Hello MvvmCross";
        public string Hello
        { 
            get { return _hello; }
            set { SetProperty (ref _hello, value); }
        }

		private string _ImageUrl;
		public string ImageUrl
		{ 
			get { return _ImageUrl; }
			set { SetProperty (ref _ImageUrl, value); }
		}
    }
}
