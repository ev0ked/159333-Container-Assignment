using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Containerv2
{
    public partial class Form1 : Form
    {
        private bool _saved = true;
        private ContainerSite _containerSite;
        private Button _currentClicked;
        private Container _currentCont;
        private List<Button> _btnList = new List<Button>();
        private List<string> _classList = new List<string> { "As New", "Second Hand", "Self Storage", "Hire", "Yard Hire", "Dirty Hire", "Empty" };
        private List<string> _typeList = new List<string> { "Standard 20Ft", "Standard 10Ft", "Double Door 20Ft", "High Cube 20Ft", "High Cube Double Door 20Ft",
        "Side Opener 20Ft","Side Opener High Cube 20ft", "None" };

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _containerSite = new ContainerSite();

            _containerSite.InitContainers(); //Initialises Containers.
            typeBox.DataSource = _typeList;
            statusBox.DataSource = _classList;
            checkBox1.Enabled = false;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_saved == false)
            {
                var window = MessageBox.Show(
                    "Close the program without Saving?",
                    "Are You Sure?",
                    MessageBoxButtons.YesNo);

                e.Cancel = (window == DialogResult.No);
            }
        }

        //Container on Click Function

        private void Container_Clicked(int pos)
        {
            checkBox1.Enabled = true;
            checkBox1.Checked = false;
            Container cont = _containerSite.SiteContainer[pos - 1];
            colourBox.Text = cont.ContainerColour;
            dateBox.Value = cont.ArrivalTime;
            numBox.Text = cont.ContainerNum.ToString();
            priceBox.Text = "$" + cont.ContainerPrice.ToString();

            if(cont.ContainerClass == ContainerClass.AsNew)
            {
                int index = statusBox.FindString("As New");
                statusBox.SetSelected(index, true);
                lblHiree.Visible = false;
                hireeBox.Visible = false;
            }
            if (cont.ContainerClass == ContainerClass.SelfStorage)
            {
                int index = statusBox.FindString("Self Storage");
                statusBox.SetSelected(index, true);
                lblHiree.Visible = true;
                hireeBox.Visible = true;
            }
            if (cont.ContainerClass == ContainerClass.Hire)
            {
                int index = statusBox.FindString("Hire");
                statusBox.SetSelected(index, true);
                lblHiree.Visible = false;
                hireeBox.Visible = false;
            }
            if (cont.ContainerClass == ContainerClass.HireDirty)
            {
                int index = statusBox.FindString("Dirty Hire");
                statusBox.SetSelected(index, true);
                lblHiree.Visible = false;
                hireeBox.Visible = false;
            }
            if (cont.ContainerClass == ContainerClass.SecondHand)
            {
                int index = statusBox.FindString("Second Hand");
                statusBox.SetSelected(index, true);
                lblHiree.Visible = false;
                hireeBox.Visible = false;
            }
            if (cont.ContainerClass == ContainerClass.Empty)
            {
                int index = statusBox.FindString("Empty");
                statusBox.SetSelected(index, true);
                lblHiree.Visible = false;
                hireeBox.Visible = false;
            }
            if (cont.ContainerClass == ContainerClass.YardHire)
            {
                int index = statusBox.FindString("Yard Hire");
                statusBox.SetSelected(index, true);
                lblHiree.Visible = true;
                hireeBox.Visible = true;
            }

            if (cont.ContainerType == ContainerType.STD20)
            {
                int index = typeBox.FindString("Standard 20Ft");
                typeBox.SetSelected(index, true);
            }
            if (cont.ContainerType == ContainerType.STD10)
            {
                int index = typeBox.FindString("Standard 10Ft");
                typeBox.SetSelected(index, true);
            }
            if (cont.ContainerType == ContainerType.DD20)
            {
                int index = typeBox.FindString("Double Door 20Ft");
                typeBox.SetSelected(index, true);
            }
            if (cont.ContainerType == ContainerType.HC20)
            {
                int index = typeBox.FindString("High Cube 20Ft");
                typeBox.SetSelected(index, true);
            }
            if (cont.ContainerType == ContainerType.HCDD20)
            {
                int index = typeBox.FindString("High Cube Double Door 20Ft");
                typeBox.SetSelected(index, true);
            }
            if (cont.ContainerType == ContainerType.SO20)
            {
                int index = typeBox.FindString("Side Opener 20Ft");
                typeBox.SetSelected(index, true);
            }
            if (cont.ContainerType == ContainerType.SOHC20)
            {
                int index = typeBox.FindString("Side Opener High Cube 20Ft");
                typeBox.SetSelected(index, true);
            }
            if (cont.ContainerType == ContainerType.NONE)
            {
                int index = typeBox.FindString("None");
                typeBox.SetSelected(index, true);
            }
            _currentCont = cont;


        }

        //Container Button Functions
        
        private void container55_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);

        }

        private void container62_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container61_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container60_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container59_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container58_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container57_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container56_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container81_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container75_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container73_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container71_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container69_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container67_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container65_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container63_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container76_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container74_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container72_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container70_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container68_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container66_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container64_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container54_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container53_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container52_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container51_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container50_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container49_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container48_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container47_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container46_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container45_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container44_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container43_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container42_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container41_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container40_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container39_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container38_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container37_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container2_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container3_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container4_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container103_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container102_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container101_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container100_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container99_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container98_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container97_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container96_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container95_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container94_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container93_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container92_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container91_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container90_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container89_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container88_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container87_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container86_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container85_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container29_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container28_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container27_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container26_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container25_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container23_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container24_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container22_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container21_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container20_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container19_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container18_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container17_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container16_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container15_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container14_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container13_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container12_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container11_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container10_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container9_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container8_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container6_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container5_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container7_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container30_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container31_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container32_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container33_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container34_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container35_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container36_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container80_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container79_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container78_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container77_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container82_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container83_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        private void container84_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name.Remove(0, 9));
            _currentClicked = (sender as Button); Container_Clicked(num);
        }

        //Information Form Functions

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                _saved = false;
                colourBox.Enabled = true;
                dateBox.Enabled = true;
                numBox.Enabled = true;
                priceBox.Enabled = true;
                statusBox.Enabled = true;
                typeBox.Enabled = true;
                serialBox.Enabled = true;
                hireeBox.Enabled = true;
                btnEmpty.Enabled = true;
            }
            else
            {
                colourBox.Enabled = false;
                dateBox.Enabled = false;
                numBox.Enabled = false;
                priceBox.Enabled = false;
                statusBox.Enabled = false;
                typeBox.Enabled = false;
                serialBox.Enabled = false;
                hireeBox.Enabled = false;
                btnEmpty.Enabled = false;
            }
        }

        private void statusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusBox.SelectedItem.ToString() == "Self Storage" && checkBox1.Checked == true)
            {
                _currentCont.ContainerClass = ContainerClass.SelfStorage;
                _currentClicked.FlatAppearance.BorderColor = Color.ForestGreen;
                _currentClicked.FlatAppearance.BorderSize = 2;
                _currentCont.ContainerEmpty = false;
                hireeBox.Visible = true;
                lblHiree.Visible = true;
            }

            if (statusBox.SelectedItem.ToString() == "As New" && checkBox1.Checked == true)
            {
                _currentCont.ContainerClass = ContainerClass.AsNew;
                _currentClicked.FlatAppearance.BorderColor = Color.RoyalBlue;
                _currentClicked.FlatAppearance.BorderSize = 2;
                _currentCont.ContainerEmpty = false;
                hireeBox.Visible = false;
                lblHiree.Visible = false;
            }

            if (statusBox.SelectedItem.ToString() == "Hire" && checkBox1.Checked == true)
            {
                _currentCont.ContainerClass = ContainerClass.Hire;
                _currentClicked.FlatAppearance.BorderColor = Color.DarkTurquoise;
                _currentClicked.FlatAppearance.BorderSize = 2;
                _currentCont.ContainerEmpty = false;
                hireeBox.Visible = false;
                lblHiree.Visible = false;


            }

            if (statusBox.SelectedItem.ToString() == "Dirty Hire" && checkBox1.Checked == true)
            {
                _currentCont.ContainerClass = ContainerClass.HireDirty;
                _currentClicked.FlatAppearance.BorderColor = Color.Crimson;
                _currentClicked.FlatAppearance.BorderSize = 2;
                _currentCont.ContainerEmpty = false;
                hireeBox.Visible = false;
                lblHiree.Visible = false;
            }

            if (statusBox.SelectedItem.ToString() == "Second Hand" && checkBox1.Checked == true)
            {
                _currentCont.ContainerClass = ContainerClass.SecondHand;
                _currentClicked.FlatAppearance.BorderColor = Color.Indigo;
                _currentClicked.FlatAppearance.BorderSize = 2;
                _currentCont.ContainerEmpty = false;
                hireeBox.Visible = false;
                lblHiree.Visible = false;
            }

            if (statusBox.SelectedItem.ToString() == "Empty" && checkBox1.Checked == true)
            {
                _currentCont.ContainerClass = ContainerClass.Empty;
                _currentClicked.FlatAppearance.BorderColor = Color.Empty;
                _currentClicked.FlatAppearance.BorderSize = 1;
                _currentCont.ContainerEmpty = true;
                hireeBox.Visible = false;
                lblHiree.Visible = false;
            }

            if (statusBox.SelectedItem.ToString() == "Yard Hire" && checkBox1.Checked == true)
            {
                _currentCont.ContainerClass = ContainerClass.YardHire;
                _currentClicked.FlatAppearance.BorderColor = Color.DarkOrange;
                _currentClicked.FlatAppearance.BorderSize = 1;
                _currentCont.ContainerEmpty = false;
                hireeBox.Visible = true;
                lblHiree.Visible = true;
            }


        }

        private void numBox_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                int num;
                if (int.TryParse(numBox.Text, out num))
                {
                    _currentCont.ContainerNum = num;
                }
                else
                {
                    MessageBox.Show("Please enter a Valid Number");
                    numBox.Text = "";
                };
                _currentClicked.Text = numBox.Text;
            }
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeBox.SelectedItem.ToString() == "Standard 20Ft" && checkBox1.Checked == true)
            {
                _currentCont.ContainerType = ContainerType.STD20;
            }

            if (typeBox.SelectedItem.ToString() == "Double Door 20Ft" && checkBox1.Checked == true)
            {
                _currentCont.ContainerType = ContainerType.DD20;
            }

            if (typeBox.SelectedItem.ToString() == "Standard 10Ft" && checkBox1.Checked == true)
            {
                _currentCont.ContainerType = ContainerType.STD10;
            }

            if (typeBox.SelectedItem.ToString() == "High Cube 20Ft" && checkBox1.Checked == true)
            {
                _currentCont.ContainerType = ContainerType.HC20;
            }

            if (typeBox.SelectedItem.ToString() == "High Cube Double Door 20Ft" && checkBox1.Checked == true)
            {
                _currentCont.ContainerType = ContainerType.HCDD20;
            }

            if (typeBox.SelectedItem.ToString() == "Side Opener 20Ft" && checkBox1.Checked == true)
            {
                _currentCont.ContainerType = ContainerType.SO20;
            }

            if (typeBox.SelectedItem.ToString() == "Side Opener High Cube 20ft" && checkBox1.Checked == true)
            {
                _currentCont.ContainerType = ContainerType.SOHC20;
            }

            if (typeBox.SelectedItem.ToString() == "None" && checkBox1.Checked == true)
            {
                _currentCont.ContainerType = ContainerType.NONE;
            }
        }

        private void dateBox_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                _currentCont.ArrivalTime = dateBox.Value;
            }
        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {
            decimal price;
            if (checkBox1.Checked == true)
            {
                if (decimal.TryParse(priceBox.Text.Remove(0, 1), out price))
                {
                    _currentCont.ContainerPrice = price;
                }
                else
                {
                    MessageBox.Show("Please enter a Valid Price");
                    priceBox.Text = "$";
                }

                
            }
        }

        private void colourBox_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                _currentCont.ContainerColour = colourBox.Text;
            }
        }
                
        private void Button_Refresh()
        {
            //Creates an array of the 'container' buttons and then refreshes their state.
            
            Button[] buttons = this.Controls.OfType<Button>().Where(x => x.Name.StartsWith("container")).OrderBy(x => int.Parse(x.Name.Substring(9))).ToArray();

            for (int i = 0; i < 103; i++)
            {
                Colour_Selector(buttons[i], _containerSite.SiteContainer[i].ContainerClass);
                buttons[i].Text = _containerSite.SiteContainer[i].ContainerNum.ToString();
            }
        }

        private void Colour_Selector(Button btn, ContainerClass colour)
        {
            //Function that sets the Button style depending on the type of container.
            
            if (colour == ContainerClass.SelfStorage)
            {
                btn.FlatAppearance.BorderColor = Color.ForestGreen;
                btn.FlatAppearance.BorderSize = 2;
            }

            if (colour == ContainerClass.AsNew)
            {
                btn.FlatAppearance.BorderColor = Color.RoyalBlue;
                btn.FlatAppearance.BorderSize = 2;
            }

            if (colour == ContainerClass.Hire)
            {
                btn.FlatAppearance.BorderColor = Color.DarkTurquoise;
                btn.FlatAppearance.BorderSize = 2;
            }

            if (colour == ContainerClass.HireDirty)
            {
                btn.FlatAppearance.BorderColor = Color.Crimson;
                btn.FlatAppearance.BorderSize = 2;
            }

            if (colour == ContainerClass.SecondHand)
            {
                btn.FlatAppearance.BorderColor = Color.Indigo;
                btn.FlatAppearance.BorderSize = 2;
            }

            if (colour == ContainerClass.Empty)
            {
                btn.FlatAppearance.BorderColor = Color.Empty;
                btn.FlatAppearance.BorderSize = 1;
            }

            if (colour == ContainerClass.YardHire)
            {
                btn.FlatAppearance.BorderColor = Color.DarkOrange;
                btn.FlatAppearance.BorderSize = 2;
            }
        }

        private void serialBox_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                var text = serialBox.Text;
                
                // Regex Input validation to check for 4 Leading Characters then 7 Following digits
                if (Regex.IsMatch(text, @"(^\w{4})(\d{7})"))
                {
                    _currentCont.ContainerSerial = text;
                }
                else
                {
                    MessageBox.Show("Please Enter a Valid Serial Number\nFormat: [ABCD1234567]");
                    text = "";
                }
            }
        }

        private void hireeBox_Leave(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                _currentCont.Hiree = hireeBox.Text;
            }
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                _currentCont.emptyContainer();
                Button_Refresh();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _containerSite.SerializeContainers();
            Statistics_Manager();
            _saved = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"containers.json"))
            {
                _containerSite.DeserializeContainers();
                Button_Refresh();
                Statistics_Manager();
            }
            else
            {
                MessageBox.Show("You do not have a containers.json Storage File, Hit Save to continue.");
            }


        }

        //Statistics Form Functions

        private void Statistics_Manager()
        {
            List<string> oldContainers = new List<string>();

            int empty = 0;
            int asNew = 0;
            int used = 0;
            int dirty = 0;
            int hire = 0;
            int yhire = 0;
            int outdate = 0;

            for (int i = 0; i < 103; i++)
            {
                var con = _containerSite.SiteContainer[i];

                if (con.ContainerClass == ContainerClass.Empty)
                {
                    empty += 1;
                }

                if(con.ContainerClass == ContainerClass.AsNew)
                {
                    asNew += 1;
                }

                if(con.ContainerClass == ContainerClass.SecondHand)
                {
                    used += 1;
                }

                if (con.ContainerClass == ContainerClass.HireDirty)
                {
                    dirty += 1;
                }

                if (con.ContainerClass == ContainerClass.Hire)
                {
                    hire += 1;
                }

                if (con.ContainerClass == ContainerClass.YardHire)
                {
                    yhire += 1;
                }

                // Checks containers for stock that is more than a month old.
                if (DateTime.Today > con.ArrivalTime.AddMonths(1) && con.ContainerClass == ContainerClass.AsNew || con.ContainerClass == ContainerClass.SecondHand)
                {
                    oldContainers.Add(con.ContainerNum.ToString() + " Arrived: " + con.ArrivalTime.ToString("dd/MM/yyyy"));
                    outdate += 1;
                }
            }


            _containerSite.CurrentSlots = empty;

            // Sets Statistics Page Labels.

            lblSlots.Text = _containerSite.CurrentSlots.ToString();
            lblYHire.Text = yhire.ToString();
            lblHire.Text = hire.ToString();
            lblNew.Text = asNew.ToString();
            lblSHand.Text = used.ToString();
            lblDirty.Text = dirty.ToString();
            lblTotal.Text = outdate.ToString();

            //Populates Text Box with Stock
            richTextBox1.Clear();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

            foreach (string str in oldContainers)
            {
                richTextBox1.SelectedText = "Container #: " + str + "\n";
            }
        }

        //Change Selection Highlight

        private void typeBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            //if the item state is selected them change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.WhiteSmoke);//Choose the color

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Draw the current item text
            e.Graphics.DrawString(typeBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        private void statusBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            //if the item state is selected them change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.WhiteSmoke);//Choose the color

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Draw the current item text
            e.Graphics.DrawString(statusBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
