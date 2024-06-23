

namespace SloppyBits

{
    public partial class SloppyBits : Form
    {
        UInt16 bit1 { get; set; } = 0;
        UInt16 bit2 { get; set; } = 0;
        UInt16 bit3 { get; set; } = 0;
        UInt16 bit4 { get; set; } = 0;
        UInt16 bit5 { get; set; } = 0;
        UInt16 bit6 { get; set; } = 0;
        UInt16 bit7 { get; set; } = 0;
        UInt16 bit8 { get; set; } = 0;
        UInt16 bit9 { get; set; } = 0;
        UInt16 bit10 { get; set; } = 0;
        UInt16 bit11 { get; set; } = 0;
        UInt16 bit12 { get; set; } = 0;
        UInt16 bit13 { get; set; } = 0;
        UInt16 bit14 { get; set; } = 0;
        UInt16 bit15 { get; set; } = 0;
        UInt16 bit16 { get; set; } = 0;






        public SloppyBits()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateMyBit();

        }

        private void updateMyBit()
        {
            long myBoxes =

                bit1 |
                bit2 |
                bit3 |
                bit4 |
                bit5 |
                bit6 |
                bit7 |
                bit8 |
                bit9 |
                bit10 |
                bit11 |
                bit12 |
                bit13 |
                bit14 |
                bit15 |
                bit16;

            // byte[] myByte = BitConverter.GetBytes(myBoxes);
            label1.Text = myBoxes.ToString("b16");
            label2.Text = myBoxes.ToString();
            label6.Text = "0x" + (myBoxes.ToString("X"));


            byte[] shortnumber = (BitConverter.GetBytes(myBoxes));

            label7.Text = shortnumber[0].ToString();
            label8.Text = shortnumber[1].ToString();
            label11.Text = shortnumber[1].ToString() + "*256+" + shortnumber[0].ToString() + " = " + myBoxes.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                bit1 = 1;

            }
            else
            {
                bit1 = 0;
            }
            updateMyBit();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                bit2 = 1 << 1;

            }
            else
            {
                bit2 = 0;
            }
            updateMyBit();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                bit3 = 1 << 2;

            }
            else
            {
                bit3 = 0;
            }
            updateMyBit();

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                bit4 = 1 << 3;

            }
            else
            {
                bit4 = 0;
            }
            updateMyBit();

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                bit5 = 1 << 4;

            }
            else
            {
                bit5 = 0;
            }
            updateMyBit();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                bit6 = 1 << 5;

            }
            else
            {
                bit6 = 0;
            }
            updateMyBit();

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                bit7 = 1 << 6;

            }
            else
            {
                bit7 = 0;
            }
            updateMyBit();

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                bit8 = 1 << 7;

            }
            else
            {
                bit8 = 0;
            }
            updateMyBit();

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                bit9 = 1 << 8;

            }
            else
            {
                bit9 = 0;
            }
            updateMyBit();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                bit10 = 1 << 9;

            }
            else
            {
                bit10 = 0;
            }
            updateMyBit();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                bit11 = 1 << 10;

            }
            else
            {
                bit11 = 0;
            }
            updateMyBit();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                bit12 = 1 << 11;

            }
            else
            {
                bit12 = 0;
            }
            updateMyBit();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                bit13 = 1 << 12;

            }
            else
            {
                bit13 = 0;
            }
            updateMyBit();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                bit14 = 1 << 13;

            }
            else
            {
                bit14 = 0;
            }
            updateMyBit();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                bit15 = 1 << 14;

            }
            else
            {
                bit15 = 0;
            }
            updateMyBit();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                bit16 = 1 << 15;

            }
            else
            {
                bit16 = 0;
            }
            updateMyBit();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
