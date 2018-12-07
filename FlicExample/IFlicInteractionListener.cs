namespace FlicExample
{
    public interface IFlicInteractionListener
    {
        void OnButtonClick();

        void OnButtonDoubleClick();

        void OnButtonHold();

        void OnButtonReady();

        void OnButtonDisconnectedWithError(string errorMessage);

        void OnButtonConnected();
    }
}