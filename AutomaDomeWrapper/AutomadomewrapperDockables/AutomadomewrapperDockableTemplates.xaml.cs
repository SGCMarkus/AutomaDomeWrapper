using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MarkusOrnik.NINA.Automadomewrapper.AutomadomewrapperDockables {
    [Export(typeof(ResourceDictionary))]
    public partial class MyPluginDockableTemplates : ResourceDictionary {
        public MyPluginDockableTemplates() {
            InitializeComponent();
        }
    }
}