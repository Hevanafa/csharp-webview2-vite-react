using System;
using System.Runtime.InteropServices;
using System.Text.Json;
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

        public int AddByObject(string json_obj) {
            var example = JsonSerializer.Deserialize<ExampleAdd>(json_obj);
            return example.a + example.b;
        }
    }

    class ExampleAdd { 
        public int a { get; set; }
        public int b { get; set; }
    }
}
