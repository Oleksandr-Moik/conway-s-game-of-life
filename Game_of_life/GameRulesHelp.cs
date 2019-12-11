using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_life
{
    public partial class GameRulesHelp : Form
    {
        public GameRulesHelp()
        {
            InitializeComponent();
        }

        private void GameRulesHelp_Load(object sender, EventArgs e)
        {
            Icon =  SystemIcons.Information;
        }
    }
}
