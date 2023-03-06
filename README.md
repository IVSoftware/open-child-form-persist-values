It's fairly straightforward to achieve your objective but there is one "trick" you have to know. So, first, make `fr` a _member_ of the main form class and add it to the `Controls` collection of `panelDesktopPanel` from the start. Its visibility is set to `false` so it's not going to show until you want it to.

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            checkBoxRoom.Appearance = Appearance.Button;
            checkBoxRoom.CheckedChanged += onCheckedChangedRoom;
            Disposed += (sender, e) =>fr.Dispose();
            panelDesktopPanel.Controls.Add(fr);
        }

        FormRoom fr = new FormRoom
        {
            Visible = false,
            TopLevel = false,
            FormBorderStyle= FormBorderStyle.None,
            Dock= DockStyle.Fill,
            BackColor= Color.Azure,
        };
        .
        .
        .
    }

The part I mentioned that requires special handling is when a `Form` visibility is going to be cycled multiple times. Because you are setting the `FormBorderStyle` to `None` this issue will be minimal in your project. But other times when the [**X**] box is visible to `Close` the form you have to be very careful that the OS doesn't dispose the underlying window handle.

In an abundance of caution, lets make sure that the `Handle` of `FormRoom` can't be destroyed in that manner by overriding the `FormClosing` event.

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

***
**Test**


For testing purposes, I replaced your [**Room**] button with a checkbox that _looks_ like a button so we can cycle its visibility and it appears that all is well!

[![screenshot][1]][1]

    public partial class MainForm : Form
    {
        .
        .
        .
        private void onCheckedChangedRoom(object sender, EventArgs e)
        {
            fr.Visible = checkBoxRoom.Checked;
        }
    }

  [1]: https://i.stack.imgur.com/mRz62.png