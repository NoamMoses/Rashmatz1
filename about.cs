using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rashmatz1 {
    public partial class about : Form {
        public about() {
            InitializeComponent();
        }

        private void about_Load(object sender, EventArgs e) {
            credits.Text = Sys.credits;
            Sys.setVersionLabel(version);
        }
    }
}
