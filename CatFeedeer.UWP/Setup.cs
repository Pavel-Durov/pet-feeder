using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.WindowsCommon.Platform;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;

namespace CatFeedeer.UWP
{
    public class Setup : MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
            
        }

 

        protected override IMvxApplication CreateApp()
        {
            
        
            return new CatFeedeer.Core.App();
        }
       
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}