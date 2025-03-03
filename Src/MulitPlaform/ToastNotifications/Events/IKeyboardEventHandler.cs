
using System.Windows.Input;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;

namespace ToastNotifications.Events
{
    public interface IKeyboardEventHandler
    {
        void Handle(KeyEventArgs eventArgs);
    }
}
