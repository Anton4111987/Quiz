using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Exam
{
    public partial class ShowPlayers : Form
    {
        public List<PlayerTable> playerTable = new List<PlayerTable>();

        public string NameForm;
        public ShowPlayers(List<PlayerTable> playerTable, string NameForm )
        {            
            InitializeComponent();
            this.NameForm = NameForm;
            this.playerTable = playerTable;
            listBox.Items.Clear();
            
            foreach (PlayerTable PT in playerTable) // добавление коллекции в листбокс + показать
            {
                listBox.Items.Add(PT);               
            }
        }

        private void ShowPlayers_Load(object sender, EventArgs e)
        {
            this.Text = NameForm;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
