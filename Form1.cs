using System;
using System.IO;
using System.Windows.Forms;

namespace Mikroprocesor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ax = new rejestr();
            bx = new rejestr();
            cx = new rejestr();
            dx = new rejestr();
            stala = new rejestr();

            ahButtons = new Button[8]; 
            alButtons = new Button[8];
            bhButtons = new Button[8]; 
            blButtons = new Button[8];
            chButtons = new Button[8]; 
            clButtons = new Button[8];
            dhButtons = new Button[8]; 
            dlButtons = new Button[8];

            ahButtons[0] = ah0; 
            ahButtons[1] = ah1; 
            ahButtons[2] = ah2; 
            ahButtons[3] = ah3;
            ahButtons[4] = ah4; 
            ahButtons[5] = ah5; 
            ahButtons[6] = ah6; 
            ahButtons[7] = ah7;

            alButtons[0] = al0; 
            alButtons[1] = al1; 
            alButtons[2] = al2; 
            alButtons[3] = al3;
            alButtons[4] = al4; 
            alButtons[5] = al5; 
            alButtons[6] = al6; 
            alButtons[7] = al7;

            bhButtons[0] = bh0; 
            bhButtons[1] = bh1; 
            bhButtons[2] = bh2; 
            bhButtons[3] = bh3;
            bhButtons[4] = bh4; 
            bhButtons[5] = bh5; 
            bhButtons[6] = bh6; 
            bhButtons[7] = bh7;

            blButtons[0] = bl0; 
            blButtons[1] = bl1; 
            blButtons[2] = bl2; 
            blButtons[3] = bl3;
            blButtons[4] = bl4; 
            blButtons[5] = bl5; 
            blButtons[6] = bl6; 
            blButtons[7] = bl7;

            chButtons[0] = ch0; 
            chButtons[1] = ch1; 
            chButtons[2] = ch2; 
            chButtons[3] = ch3;
            chButtons[4] = ch4; 
            chButtons[5] = ch5; 
            chButtons[6] = ch6; 
            chButtons[7] = ch7;

            clButtons[0] = cl0; 
            clButtons[1] = cl1; 
            clButtons[2] = cl2; 
            clButtons[3] = cl3;
            clButtons[4] = cl4; 
            clButtons[5] = cl5; 
            clButtons[6] = cl6; 
            clButtons[7] = cl7;

            dhButtons[0] = dh0; 
            dhButtons[1] = dh1; 
            dhButtons[2] = dh2; 
            dhButtons[3] = dh3;
            dhButtons[4] = dh4; 
            dhButtons[5] = dh5; 
            dhButtons[6] = dh6; 
            dhButtons[7] = dh7;

            dlButtons[0] = dl0; 
            dlButtons[1] = dl1; 
            dlButtons[2] = dl2; 
            dlButtons[3] = dl3;
            dlButtons[4] = dl4; 
            dlButtons[5] = dl5; 
            dlButtons[6] = dl6; 
            dlButtons[7] = dl7;

            ax.tabH = ahButtons; 
            ax.tabL = alButtons;
            bx.tabH = bhButtons; 
            bx.tabL = blButtons;
            cx.tabH = chButtons; 
            cx.tabL = clButtons;
            dx.tabH = dhButtons; 
            dx.tabL = dlButtons;

            ax.hLabel = AH_label;
            ax.lLabel = AL_label;
            bx.hLabel = BH_label;
            bx.lLabel = BL_label;
            cx.hLabel = CH_label;
            cx.lLabel = CL_label;
            dx.hLabel = DH_label;
            dx.lLabel = DL_label;
        }
    
       private void clickBit(object sender, EventArgs e)
       {
           Button bitButton = (Button)sender;
            if (bitButton.Text == "0")
                bitButton.Text = "1";
            else
                bitButton.Text = "0";
       }

        private void ahClick(object sender, EventArgs e)
        {
            clickBit(sender, e);
            
            int wartosc = 0;

            for (int i=0; i<8; i++)
            {
                if (ahButtons[i].Text == "1") 
                    wartosc = wartosc + (int) Math.Pow(2, i);
            }
            ax.h = wartosc;
            ax.hLabel.Text = ax.h.ToString();
        }

        private void alClick(object sender, EventArgs e)
        {
            clickBit(sender, e);

            int wartosc = 0;

            for (int i = 0; i < 8; i++)
            {
                if (alButtons[i].Text == "1")
                    wartosc = wartosc + (int)Math.Pow(2, i);
            }
            ax.l = wartosc;
            ax.lLabel.Text = ax.l.ToString();

        }

        private void bhClick(object sender, EventArgs e)
        {
            clickBit(sender, e);

            int wartosc = 0;

            for (int i = 0; i < 8; i++)
            {
                if (bhButtons[i].Text == "1")
                    wartosc = wartosc + (int)Math.Pow(2, i);
            }
            bx.h = wartosc;
            bx.hLabel.Text = bx.h.ToString();
        }
        private void blClick(object sender, EventArgs e)
        {
            clickBit(sender, e);

            int wartosc = 0;

            for (int i = 0; i < 8; i++)
            {
                if (blButtons[i].Text == "1")
                    wartosc = wartosc + (int)Math.Pow(2, i);
            }
            bx.l = wartosc;
            bx.lLabel.Text = bx.l.ToString();
        }
        private void chClick(object sender, EventArgs e)
        {
            clickBit(sender, e);

            int wartosc = 0;

            for (int i = 0; i < 8; i++)
            {
                if (chButtons[i].Text == "1")
                    wartosc = wartosc + (int)Math.Pow(2, i);
            }
            cx.h = wartosc;
            cx.hLabel.Text = cx.h.ToString();
        }
        private void clClick(object sender, EventArgs e)
        {
            clickBit(sender, e);

            int wartosc = 0;

            for (int i = 0; i < 8; i++)
            {
                if (clButtons[i].Text == "1")
                    wartosc = wartosc + (int)Math.Pow(2, i);
            }
            cx.l = wartosc;
            cx.lLabel.Text = cx.l.ToString();
        }

        private void dhClick(object sender, EventArgs e)
        {
            clickBit(sender, e);

            int wartosc = 0;

            for (int i = 0; i < 8; i++)
            {
                if (dhButtons[i].Text == "1")
                    wartosc = wartosc + (int)Math.Pow(2, i);
            }
            dx.h = wartosc;
            dx.hLabel.Text = dx.h.ToString();
        }

        private void dlClick(object sender, EventArgs e)
        {
            clickBit(sender, e);

            int wartosc = 0;

            for (int i = 0; i < 8; i++)
            {
                if (dlButtons[i].Text == "1")
                    wartosc = wartosc + (int)Math.Pow(2, i);
            }
            dx.l = wartosc;
            dx.lLabel.Text = dx.l.ToString();
        }

        private void resetButtonClick(object sender, EventArgs e)
        {
            lista_textbox.Clear();
            liczbaRozkazowDoWykonania = 0;
            biezacyRozkaz = 0;
        
            for (int i=0; i<8; i++)
            {
                ahButtons[i].Text = "0"; 
                alButtons[i].Text = "0";
                bhButtons[i].Text = "0"; 
                blButtons[i].Text = "0";
                chButtons[i].Text = "0"; 
                clButtons[i].Text = "0";
                dhButtons[i].Text = "0"; 
                dlButtons[i].Text = "0";
            }

            AH_label.Text = "0"; 
            AL_label.Text = "0";
            BH_label.Text = "0"; 
            BL_label.Text = "0";
            CH_label.Text = "0"; 
            CL_label.Text = "0";
            DH_label.Text = "0"; 
            DL_label.Text = "0";

            ax.h = 0; 
            ax.l = 0;
            bx.h = 0; 
            bx.l = 0;
            cx.h = 0; 
            cx.l = 0;
            dx.h = 0; 
            dx.l = 0;

            stala.l = 0;
            textBox_stala.Text = "0";

        }

        private void exitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dodaj_button_Click(object sender, EventArgs e)
        {
            string rejestr1 = "";
            string rozkaz = "";
            string rejestr2 = "";

            if (r1_AH.Checked)
            {
                rejestr1 = "AH";
            }
            else if (r1_AL.Checked)
            {
                rejestr1 = "AL";
            }
            else if (r1_BH.Checked)
            {
                rejestr1 = "BH";
            }
            else if (r1_BL.Checked)
            {
                rejestr1 = "BL";
            }
            else if (r1_CH.Checked)
            {
                rejestr1 = "CH";
            }
            else if (r1_CL.Checked)
            {
                rejestr1 = "CL";
            }
            else if (r1_DH.Checked)
            {
                rejestr1 = "DH";
            }
            else if (r1_DL.Checked)
            {
                rejestr1 = "DL";
            }


            if (ADD.Checked)
            {
                rozkaz = "ADD";
            }
            else if (MOV.Checked)
            {
                rozkaz = "MOV";
            }
            else if (SUB.Checked)
            {
                rozkaz = "SUB";
            }

            if (r2_AH.Checked)
            {
                rejestr2 = "AH";
            }
            else if (r2_AL.Checked)
            {
                rejestr2 = "AL";
            }
            else if (r2_BH.Checked)
            {
                rejestr2 = "BH";
            }
            else if (r2_BL.Checked)
            {
                rejestr2 = "BL";
            }
            else if (r2_CH.Checked)
            {
                rejestr2 = "CH";
            }
            else if (r2_CL.Checked)
            {
                rejestr2 = "CL";
            }
            else if (r2_DH.Checked)
            {
                rejestr2 = "DH";
            }
            else if (r2_DL.Checked)
            {
                rejestr2 = "DL";
            }


            if (checkBox_stala.Checked)
            {
                try
                {
                    stala.l = Convert.ToInt32(textBox_stala.Text);
                }
                catch 
                {
                    MessageBox.Show("Zła wartość w polu 'Stała'. Dozwolone wartości: 0-255");
                    stala.l = -1;
                    textBox_stala.Text = "0";
                }

                if (stala.l >= 0 && stala.l <= 255)
                {
                    string wartoscHex = Convert.ToString(stala.l, 16);
                    if (wartoscHex.Length == 1)
                        wartoscHex = "0" + wartoscHex;
                    lista_textbox.AppendText(rozkaz + " " + rejestr1 + ", " + wartoscHex + "h" + Environment.NewLine);
                }                  
                else if (stala.l != -1)
                {
                    MessageBox.Show("Zła wartość w polu 'Stała'. Dozwolone wartości: 0-255");
                    stala.l = 0;
                    textBox_stala.Text = "0";
                }

            } 
            else
                lista_textbox.AppendText(rozkaz + " " + rejestr1 + ", " + rejestr2 + Environment.NewLine);
                liczbaRozkazowDoWykonania++;
        }

        private void wyczysc_button_Click(object sender, EventArgs e)
        {
            lista_textbox.Clear();
            liczbaRozkazowDoWykonania = 0;
        }

        private void calosc_button_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (biezacyRozkaz < liczbaRozkazowDoWykonania)
                krokowa_button_Click(sender, e);
            else
                timer1.Stop();
        }

        
        private void ustawBity(rejestr rej1, bool low1)
        {
            string wartoscBinarna = "";
            int dlugosc;
            
            if (low1 == true)
            {
                wartoscBinarna = Convert.ToString(rej1.l, 2);
                dlugosc = 8 - wartoscBinarna.Length;
               
                for (int i = 0; i < dlugosc; i++)
                {
                    wartoscBinarna = "0" + wartoscBinarna;
                }
                
                for (int i=0; i<8; i++)
                {
                    rej1.tabL[7-i].Text = wartoscBinarna.Substring(i, 1);
                }
            }
            else
            {
                wartoscBinarna = Convert.ToString(rej1.h, 2);
                dlugosc = 8 - wartoscBinarna.Length;
                
                for (int i = 0; i < dlugosc; i++)
                {
                    wartoscBinarna = "0" + wartoscBinarna;
                }
                
                for (int i=0; i<8; i++)
                {
                    rej1.tabH[7-i].Text = wartoscBinarna.Substring(i, 1);
                }
            }
        }
        private void wykonajRozkaz(string rozkaz, ref rejestr rej1, bool low1, ref rejestr rej2lubStala, bool low2)
        {
            switch (rozkaz)
            {
                case "MOV":
                    if(low1 == true)
                    {
                        if (low2 == true)
                            rej1.l = rej2lubStala.l;
                        else
                            rej1.l = rej2lubStala.h;
                        rej1.lLabel.Text = rej1.l.ToString();
                    } 
                    else
                    {
                        if (low2 == true)
                            rej1.h = rej2lubStala.l;
                        else
                            rej1.h = rej2lubStala.h;
                        rej1.hLabel.Text = rej1.h.ToString();
                    }
                    ustawBity(rej1,low1);
                    break;
                case "ADD":
                    if (low1 == true)
                    {
                        if (low2 == true)
                            rej1.l += rej2lubStala.l;
                        else
                            rej1.l += rej2lubStala.h;
                        if (rej1.l > 255) rej1.l = rej1.l - 255;
                        rej1.lLabel.Text = rej1.l.ToString();
                    }
                    else
                    {
                        if (low2 == true)
                            rej1.h += rej2lubStala.l;
                        else
                            rej1.h += rej2lubStala.h;
                        if (rej1.h > 255) rej1.h = rej1.h - 255;
                        rej1.hLabel.Text = rej1.h.ToString();
                    }
                    ustawBity(rej1, low1);
                    break;
                case "SUB":
                    if (low1 == true)
                    {
                        if (low2 == true)
                            rej1.l -= rej2lubStala.l;
                        else
                            rej1.l -= rej2lubStala.h;
                        if (rej1.l < 0) rej1.l = -rej1.l;
                        rej1.lLabel.Text = rej1.l.ToString();
                    }
                    else
                    {
                        if (low2 == true)
                            rej1.h -= rej2lubStala.l;
                        else
                            rej1.h -= rej2lubStala.h;
                        if (rej1.h < 0) rej1.h = -rej1.h;
                        rej1.hLabel.Text = rej1.h.ToString();
                    }
                    ustawBity(rej1, low1);
                    break;
            }
        }
        private void krokowa_button_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"rozkazy.txt", lista_textbox.Text);  
            string[] rozkazy = File.ReadAllLines(@"rozkazy.txt"); 

            string rejestr1 = "";
            string rozkaz = "";
            string rejestr2lubStala = "";
            ref rejestr rej1 = ref ax;
            ref rejestr rej2lubStala = ref bx;
            bool low1=false, low2=false;
            
            if (biezacyRozkaz < liczbaRozkazowDoWykonania)
            {
                rozkaz = rozkazy[biezacyRozkaz].Substring(0, 3);
                rejestr1 = rozkazy[biezacyRozkaz].Substring(4, 2);
                rejestr2lubStala = rozkazy[biezacyRozkaz].Substring(8, 2);

                switch(rejestr1)
                {
                    case "AH":
                        rej1 = ref ax;
                        low1 = false;
                        break;
                    case "AL":
                        rej1 = ref ax;
                        low1 = true;
                        break;
                    case "BH":
                        rej1 = ref bx;
                        low1 = false;
                        break;
                    case "BL":
                        rej1 = ref bx;
                        low1 = true;
                        break;
                    case "CH":
                        rej1 = ref cx;
                        low1 = false;
                        break;
                    case "CL":
                        rej1 = ref cx;
                        low1 = true;
                        break;
                    case "DH":
                        rej1 = ref dx;
                        low1 = false;
                        break;
                    case "DL":
                        rej1 = ref dx;
                        low1 = true;
                        break;
                }
                switch (rejestr2lubStala)
                {
                    case "AH":
                        rej2lubStala = ref ax;
                        low2 = false;
                        break;
                    case "AL":
                        rej2lubStala = ref ax;
                        low2 = true;
                        break;
                    case "BH":
                        rej2lubStala = ref bx;
                        low2 = false;
                        break;
                    case "BL":
                        rej2lubStala = ref bx;
                        low2 = true;
                        break;
                    case "CH":
                        rej2lubStala = ref cx;
                        low2 = false;
                        break;
                    case "CL":
                        rej2lubStala = ref cx;
                        low2 = true;
                        break;
                    case "DH":
                        rej2lubStala = ref dx;
                        low2 = false;
                        break;
                    case "DL":
                        rej2lubStala = ref dx;
                        low2 = true;
                        break;
                    default:
                        stala.l = Convert.ToInt32(rejestr2lubStala, 16);
                        rej2lubStala = ref stala;
                        low2 = true;
                        break;
                }

                wykonajRozkaz(rozkaz, ref rej1, low1, ref rej2lubStala, low2);
                rozkazy[biezacyRozkaz] = rozkazy[biezacyRozkaz] + " >> wykonano <<";
                File.WriteAllLines(@"rozkazy.txt", rozkazy);   
                lista_textbox.Text = File.ReadAllText(@"rozkazy.txt"); 
                biezacyRozkaz++;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_stala.Checked)
                groupBox2.Enabled = false;
            else
                groupBox2.Enabled = true;
        }

        private void load_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                string filePath = openFileDialog.FileName;
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                    lines[i] = lines[i].Replace(" >> wykonano <<", "");
                lista_textbox.Text = string.Join(Environment.NewLine, lines);
                liczbaRozkazowDoWykonania++;
                liczbaRozkazowDoWykonania++;
                liczbaRozkazowDoWykonania++;
                liczbaRozkazowDoWykonania++;
                liczbaRozkazowDoWykonania++;
                liczbaRozkazowDoWykonania++;
            }

        }
    }
}
