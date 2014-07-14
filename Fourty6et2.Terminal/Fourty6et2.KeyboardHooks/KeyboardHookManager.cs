using Fourty6et2.ThirdParty.GlobalMouseKeyHook.HotKeys;
using Fourty6et2.ThirdParty.GlobalMouseKeyHook.WinApi;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fourty6et2.KeyboardHooks
{
    public partial class KeyboardHookManager
    {
        private HotKeySetsListener _shortCutListener;
        Dictionary<HotKeySet, ShortCutDelegate>_shortCutDelegates;

        public delegate void ShortCutDelegate();

        private KeyboardHookManager()
        {
            _shortCutListener = new HotKeySetsListener(new HotKeySetCollection(), new GlobalHooker());
            _shortCutDelegates = new Dictionary<HotKeySet, ShortCutDelegate>();
        }

        ~KeyboardHookManager()
        {
            _shortCutListener.Enabled = false;
        }

        public void SetShortCutDelegate(IEnumerable<Keys> keys, ShortCutDelegate shortCutDelegate)
        {
            _shortCutListener.Enabled = false;
            {
                RemoveShortCutDelegate(keys);

                var hotKeySet = new HotKeySet(keys);
                hotKeySet.OnHotKeysUp += OnHotKeysUp;

                _shortCutDelegates.Add(hotKeySet, shortCutDelegate);
                _shortCutListener.HotKeyCollection.Add(hotKeySet);
            }
            _shortCutListener.Enabled = true;
        }

        public void RemoveShortCutDelegate(IEnumerable<Keys> keys)
        {
            HotKeySet hotKeySet = new HotKeySet(keys);

            if (_shortCutDelegates.ContainsKey(hotKeySet))
            {
                _shortCutDelegates.Remove(hotKeySet);
                _shortCutListener.HotKeyCollection.Remove(hotKeySet);
            }
        }

        void OnHotKeysUp(object sender, HotKeyArgs e)
        {
            HotKeySet hotKeySet = sender as HotKeySet;

            if (_shortCutDelegates.ContainsKey(hotKeySet))
                _shortCutDelegates[hotKeySet]();
        }

        public void StopAllHooks()
        {
            _shortCutListener.Enabled = false;
        }
    }
}
