using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CSharpReact
{
    [ComVisible(true)]
    public class NativeClass
    {
        public void Show() {
            MessageBox.Show("Hello from .NET!");
        }

        public int Add(int a, int b) {
            return a + b;
        }
    }
}
