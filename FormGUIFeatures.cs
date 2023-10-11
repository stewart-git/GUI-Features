using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Ivan 08/09/2022            
// Some error trapping in the MotorBike class and on the Form.
// Needs further testing.
namespace GUI_Features
{
    public partial class FormGUIFeatures : Form
    {
        public FormGUIFeatures()
        {
            InitializeComponent();
        }
        List<MotorBike> motorBikeList = new List<MotorBike>();

        private void ButtonAddNewBike_Click(object sender, EventArgs e)
        {

            if (DuplicateCheck(TextBoxBikeModel.Text) && InputOK())
            {
                MotorBike addBike = new MotorBike();
                addBike.SetModel(TextBoxBikeModel.Text);
                addBike.SetManufacturer(GetManufacturerRadioButton());
                addBike.SetStyle(ComboBoxStyle.Text);
                addBike.SetCapacity((int)numericUpDownEngine.Value);
                addBike.SetAccessories(GetAccessoriesCheckBox());
                motorBikeList.Add(addBike);
                DisplayAllBikes();
                ClearResetInput();
            }
            else
            {
                ErrorMsg.Text = "Your cannot add duplicate Models";
                ClearResetInput();
            }
        }
        // Check for duplicate values in the Model field
        private bool DuplicateCheck(string newModel)
        {
            if (motorBikeList.Exists(CheckModel => CheckModel.GetModel() == newModel))
                return false;
            else
                return true;
        }
        // Check if all fields have suitable values
        private bool InputOK()
        {
            if(!string.IsNullOrEmpty(TextBoxBikeModel.Text)
                && !string.IsNullOrEmpty(ComboBoxStyle.Text))
                return true;
            else
                return false;
        }
        private void DisplayAllBikes()
        {
            ListViewBikeDisplay.Items.Clear();
            motorBikeList.Sort(); // sort implmented in the class
            foreach (var bike in motorBikeList)
            {   // no accessory displayed.
                ListViewItem lvi = new ListViewItem(bike.GetModel());
                lvi.SubItems.Add(bike.GetManufacturer());
                lvi.SubItems.Add(bike.GetStyle());
                lvi.SubItems.Add(bike.GetCapacity().ToString());
                ListViewBikeDisplay.Items.Add(lvi);
            }
        }
        private void ClearResetInput()
        {
            TextBoxBikeModel.Clear();
            ComboBoxStyle.SelectedIndex = 0; // set the value to the first item in the list
            numericUpDownEngine.Value = 500; // set value to 500
            // set all radio buttons to un-checked
            foreach (RadioButton rb in groupBoxManufacturer.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }
            foreach (CheckBox cb in groupBoxAccessories.Controls.OfType<CheckBox>())
            {
                cb.Checked = false;
            }
        }
        private void ListViewBikeDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedBike = ListViewBikeDisplay.SelectedIndices[0];
            TextBoxBikeModel.Text = motorBikeList[selectedBike].GetModel();
            ComboBoxStyle.Text = motorBikeList[selectedBike].GetStyle();
            SetManufacturerRadioButton(selectedBike);
            numericUpDownEngine.Value = motorBikeList[selectedBike].GetCapacity();
            SetAccessoriesCheckBox(selectedBike);
        }
        private void ButtonFindBike_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxBikeModel.Text))
            {
                MotorBike findBike = new MotorBike();
                findBike.SetModel(TextBoxBikeModel.Text);
                int found = motorBikeList.BinarySearch(findBike);
                if (found >= 0)
                {
                    ListViewBikeDisplay.SelectedItems.Clear();
                    ListViewBikeDisplay.Items[found].Selected = true;
                    ListViewBikeDisplay.Focus();
                    TextBoxBikeModel.Text = motorBikeList[found].GetModel();
                    ComboBoxStyle.Text = motorBikeList[found].GetStyle();
                    SetManufacturerRadioButton(found);
                    numericUpDownEngine.Value = motorBikeList[found].GetCapacity();
                    SetAccessoriesCheckBox(found);
                }
                else
                {
                    // MessageBox.Show("Cannot find bike", "Not Found Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ErrorMsg.Text = "Cannot find that bike";
                    TextBoxBikeModel.Clear();
                    TextBoxBikeModel.Focus();
                }
            }
            else
            {
                // MessageBox.Show("Please enter Bike Model into Text box", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorMsg.Text = "Please enter Bike Model into text box";
                TextBoxBikeModel.Clear();
                TextBoxBikeModel.Focus();
            }
        }
        private string GetManufacturerRadioButton()
        {
            string rbValue = "";
            foreach (RadioButton rb in groupBoxManufacturer.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    rbValue = rb.Text;
                    break; // is this really needed?
                }
                else
                {
                    rbValue = "Other";
                }
            }
            return rbValue;
        }
        private void SetManufacturerRadioButton(int item)
        {
            foreach (RadioButton rb in groupBoxManufacturer.Controls.OfType<RadioButton>())
            {
                if (rb.Text == motorBikeList[item].GetManufacturer())
                {
                    rb.Checked = true;
                }
                else
                {
                    rb.Checked = false;
                }
            }
        }
        private string[] GetAccessoriesCheckBox()
        {
            string[] accessory = new string[3];
            int x = 0;
            foreach (CheckBox cb in groupBoxAccessories.Controls.OfType<CheckBox>())
            {
                if (cb.Checked == true)
                {
                    accessory[x] = cb.Text;
                }
                else
                {
                    accessory[x] = " ";
                }
                x++;
            }
            return accessory;
        }
        private void SetAccessoriesCheckBox(int item)
        {
            string[] cbL = motorBikeList[item].GetAccessories();
            int indx = 0;
            foreach (CheckBox cb in groupBoxAccessories.Controls.OfType<CheckBox>())
            {
                if (cbL[indx] == cb.Text)
                    cb.Checked = true;
                else
                    cb.Checked = false;
                indx++;
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string fileName = "BikeInformation.bin";
            SaveFileDialog SaveBinFile = new SaveFileDialog();
            SaveBinFile.InitialDirectory = Application.StartupPath;
            SaveBinFile.Filter = "BIN |*.bin";
            SaveBinFile.Title = "Save your bike information to a binary file";
            DialogResult sr = SaveBinFile.ShowDialog();
            if (sr == DialogResult.Cancel)
            {
                SaveBinFile.FileName = fileName;
            }
            if (sr == DialogResult.OK)
            {
                fileName = SaveBinFile.FileName;
            }
            try
            {
                using (var stream = File.Open(fileName, FileMode.Create))
                {
                    using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                    {
                        foreach (var bike in motorBikeList)
                        {
                            writer.Write(bike.GetModel());
                            writer.Write(bike.GetManufacturer());
                            writer.Write(bike.GetStyle());
                            writer.Write(bike.GetCapacity());
                            writer.Write(string.Join(",", bike.GetAccessories()));
                        }
                    }
                }
            }
            catch (IOException)
            {
                // MessageBox.Show("Could not save Bike information","Critical Save Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                ErrorMsg.Text = "Could not save Bike information";
            }
        }
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            string fileName = "BikeInformation.bin";
            OpenFileDialog OpenBinFile = new OpenFileDialog();
            OpenBinFile.InitialDirectory = Application.StartupPath;
            OpenBinFile.Filter = "BIN |*.bin";
            OpenBinFile.Title = "Open a binary file with Bike information..";
            DialogResult sr = OpenBinFile.ShowDialog();
            if (sr == DialogResult.OK)
            {
                fileName = OpenBinFile.FileName;
            }
            try
            {
                motorBikeList.Clear();
                using (Stream stream = File.Open(fileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        while (stream.Position < stream.Length)
                        {
                            MotorBike bike = new MotorBike();
                            bike.SetModel(reader.ReadString());
                            bike.SetManufacturer(reader.ReadString());
                            bike.SetStyle(reader.ReadString());
                            bike.SetCapacity(reader.ReadInt32());
                            bike.SetAccessories(reader.ReadString().Split(','));
                            motorBikeList.Add(bike);
                        }
                    }
                }
                DisplayAllBikes();
            }
            catch (IOException)
            {
                // MessageBox.Show("Could not open Bike information", "Critical Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorMsg.Text = "Could not open Bike information";
            }
        }
    }
}