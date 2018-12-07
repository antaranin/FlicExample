using System;
using MoreLinq;
using UIKit;
using Xamarin.Fliclib.Binding.iOS;

namespace FlicExample
{
    public partial class ViewController : UIViewController, IFlicInteractionListener
    {
        //Change this to whatever your app url might be
        private const string FlicAppUrl = "flicExample.com";
        private int _clickCount = 0;
        private FlicButtonDelegate _delegate;
        
        
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            
            ConnectFlicBtn.TouchUpInside += ConnectFlicBtnOnTouchUpInside;
            RegisterFlic();
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
            DeregisterFlic();
        }

        private void ConnectFlicBtnOnTouchUpInside(object sender, EventArgs e)
        {
            SCLFlicManager.SharedManager().GrabFlicFromFlicAppWithCallbackUrlScheme(FlicAppUrl);
            
        }

        private void RegisterFlic()
        {
            _delegate = new FlicButtonDelegate(this);
            var buttons = SCLFlicManager.SharedManager().KnownButtons.Values;
            buttons.ForEach(button => button.Delegate = _delegate);
        }

        private void DeregisterFlic()
        {
            var buttons = SCLFlicManager.SharedManager().KnownButtons.Values;
            buttons.ForEach(button => button.Delegate = null);
            _delegate?.Dispose();
            _delegate = null;
        }

        public void OnButtonClick()
        {
            _clickCount++;
            ClickCountLbl.Text = _clickCount.ToString();
        }

        public void OnButtonDoubleClick()
        {
            _clickCount++;
            ClickCountLbl.Text = _clickCount.ToString();
        }

        public void OnButtonHold()
        {
            _clickCount++;
            ClickCountLbl.Text = _clickCount.ToString();
        }

        public void OnButtonReady()
        {
            StatusLbl.Text = "Ready";
        }

        public void OnButtonDisconnectedWithError(string errorMessage)
        {
            StatusLbl.Text = $"Disconnected: {errorMessage}";
        }

        public void OnButtonConnected()
        {
            StatusLbl.Text = "Connected";
        }
    }
}
