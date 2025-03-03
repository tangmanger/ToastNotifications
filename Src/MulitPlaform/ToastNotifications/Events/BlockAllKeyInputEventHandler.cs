using System.Windows.Input;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;

namespace ToastNotifications.Events
{
    public class BlockAllKeyInputEventHandler: IKeyboardEventHandler
    {
        public void Handle(KeyEventArgs eventArgs)
        {
            eventArgs.Handled = true;
        }
    }
}