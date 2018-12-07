using System;
using System.Diagnostics;
using Foundation;
using Xamarin.Fliclib.Binding.iOS;

namespace FlicExample
{
    public class FlicButtonDelegate : SCLFlicButtonDelegate
    {
        private IFlicInteractionListener FlicInteractionListener { get; }

        public FlicButtonDelegate(IFlicInteractionListener flicInteractionListener)
        {
            FlicInteractionListener = flicInteractionListener;
        }

        public override void FlicButtonDidReceiveButtonClick(SCLFlicButton button, bool queued, nint age)
        {
            FlicInteractionListener.OnButtonClick();
        }

        public override void FlicButtonDidReceiveButtonDoubleClick(SCLFlicButton button, bool queued, nint age)
        {
            FlicInteractionListener.OnButtonDoubleClick();
        }

        public override void FlicButtonDidReceiveButtonHold(SCLFlicButton button, bool queued, nint age)
        {
            FlicInteractionListener.OnButtonHold();
        }

        public override void FlicButtonDidReceiveButtonUp(SCLFlicButton button, bool queued, nint age)
        {

        }

        public override void FlicButtonIsReady(SCLFlicButton button)
        {
            FlicInteractionListener.OnButtonReady();
        }

        public override void FlicButtonDidDisconnectWithError(SCLFlicButton button, NSError error)
        {
            FlicInteractionListener.OnButtonDisconnectedWithError(error.Description);
        }

        public override void FlicButtonDidConnect(SCLFlicButton button)
        {
            FlicInteractionListener.OnButtonConnected();
        }
    }
}