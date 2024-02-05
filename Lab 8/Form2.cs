namespace Lab_8
{
    public partial class Form2 : Form
    {
        Color textClr;
        string textFont;
        int textSize;
     

        public Form2()
        {
            InitializeComponent();
            textClr = Color.Black;
            textFont = "Times New Roman";
            textSize = 20;
        }

        public Color TextClr { get { return textClr; } set { textClr = value; } }
        public string TextFont { get { return textFont; } set { textFont = value; } }
        public int TextSize { get { return textSize; } set { textSize = value; } }

        public bool Times
        {
            set { radioButton1.Checked = value; }
            get { return radioButton1.Checked; }
        }

        public bool Arial
        {
            set { radioButton2.Checked = value; }
            get { return radioButton2.Checked; }
        }

        public bool Courier
        {
            set { radioButton3.Checked = value; }
            get { return radioButton3.Checked; }
        }

        public bool Size16
        {
            set { radioButton4.Checked = value; }
            get { return radioButton4.Checked; }
        }

        public bool Size20
        {
            set { radioButton5.Checked = value; }
            get { return radioButton5.Checked; }
        }

        public bool Size24
        {
            set { radioButton6.Checked = value; }
            get { return radioButton6.Checked; }
        }
        public string TextBoxes { 
            set { OldText.Text = value; }

            get
            {
                string str;
                if (NewText.Text.Trim() == "") { str = OldText.Text; }
                else { str = NewText.Text; }
                return str;
            }
        }

        private void button1_Click(object sender, EventArgs e) //OK button
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //Cancel Button
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TextFont = "Times New Roman";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TextFont = "Arial";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            TextFont = "Courier New";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            TextSize = 16;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            TextSize = 20;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            TextSize = 24;
        }

        private void button4_Click(object sender, EventArgs e) //Color Dialog Box
        {
            ColorDialog x = new ColorDialog();
            DialogResult = x.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                textClr = x.Color;
            }
        }
    }
}
