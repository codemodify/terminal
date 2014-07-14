
namespace Fourty6et2.KeyboardHooks
{
    public partial class KeyboardHookManager
    {
        private static object _keyboardHookManagerSyncObject = new object();
        private static KeyboardHookManager _keyboardHookManager;

        public static KeyboardHookManager Instance
        {
            get
            {
                lock(_keyboardHookManagerSyncObject)
                {
                    if (_keyboardHookManager == null)
                        _keyboardHookManager = new KeyboardHookManager();

                    return _keyboardHookManager;
                }
            }
        }
    }
}
