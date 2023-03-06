using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace open_child_form_persist_values
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            checkBoxRoom.Appearance = Appearance.Button;
            checkBoxRoom.CheckedChanged += onCheckedChangedRoom;
            Disposed += (sender, e) => fr.Dispose();
            panelDesktopPanel.Controls.Add(fr);
        }

        FormRoom fr = new FormRoom
        {
            Visible = false,
            TopLevel = false,
            FormBorderStyle = FormBorderStyle.None,
            Dock = DockStyle.Fill,
            BackColor = Color.Azure,
        };
        private void onCheckedChangedRoom(object sender, EventArgs e)
        {
            fr.Visible = checkBoxRoom.Checked;
        }
        //private void btnRoom_Click(object sender, EventArgs e)
        //{
        //    FormRoom fr = new FormRoom();
        //    fr.TopLevel = false; 
        //    panelDesktopPanel.Controls.Add(fr); 
        //    fr.FormBorderStyle = FormBorderStyle.None; 
        //    fr.Dock = DockStyle.Fill; fr.BringToFront(); fr.Show(); 
        //    ActivateButton(sender); 
        //    lblTitle.Text = fr.Text;
        //}
    }
}
class FormRoom : Form
{
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);
        // Disallow close by [X] hide instead.
        FormClosing += (sender, e) =>
        {
            e.Cancel = e.CloseReason.Equals(CloseReason.UserClosing);
            Hide();
        };
    }
}

