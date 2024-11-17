using ProcSyg_NET8._0;
using System.Diagnostics.Eventing.Reader;
using System.Web;

namespace ProcSygWinForms
{


    public partial class MainForm : Form
    {
        private SignalHolder signalHolder = new();

        private string par1Type = "double";



        public MainForm() {
            InitializeComponent();
            effectsComboBox.SelectedIndex = 0;
            labelPar1.Text = "Max/min of aplitude:";
            ShowPar2Prompt(false);

        }

        private void ShowPar2Prompt(bool b) {
            labelPar2.Visible = labelPar2.Enabled = b;
            maskedTextBoxPar2.Visible = maskedTextBoxPar2.Enabled = b;

        }
        private void effectsComboBox_SelectionChangeCommitted(object sender, EventArgs e) {

            switch (effectsComboBox.SelectedIndex) {

                case 0: //white noise
                    ShowPar2Prompt(false);
                    par1Type = "double";
                    labelPar1.Text = "Max/min of aplitude:";
                    userDialog.Text = "Effect: white noise";
                    break;
                case 1: // lowpass
                    ShowPar2Prompt(false);
                    par1Type = "int";
                    labelPar1.Text = "Max pass frequency (integer):";
                    userDialog.Text = "Effect: low-pass filter";
                    break;
                case 2: //highpass
                    ShowPar2Prompt(false);
                    par1Type = "int";
                    labelPar1.Text = "Min pass frequency (integer):";
                    userDialog.Text = "Effect: high-pass filter";
                    break;
                case 3: //time-stretch
                    ShowPar2Prompt(false);
                    par1Type = "double";
                    labelPar1.Text = "Time change parameter:";
                    userDialog.Text = "Effect: time stretching/shrinking";
                    break;
                case 4: // change dB
                    ShowPar2Prompt(false);
                    par1Type = "int";
                    labelPar1.Text = "Decibels (integer):";
                    userDialog.Text = "Effect: change amplitude level (dB)";
                    break;
                case 5: // echo
                    ShowPar2Prompt(true);
                    par1Type = "int";
                    labelPar1.Text = "ms (integer):";
                    labelPar2.Text = "feedback:";
                    userDialog.Text = "Effect: echo";
                    break;
                case 6: // delay
                    ShowPar2Prompt(true);
                    par1Type = "int";
                    labelPar1.Text = "ms (integer):";
                    labelPar2.Text = "feedback:";
                    userDialog.Text = "Effect: delay";
                    break;
            }


        }

        private void loadButton_LoadFile(object sender, EventArgs e) {

            var res = openFileDialog.ShowDialog();

            if (res == DialogResult.OK) {
                signalHolder.LoadSignal(openFileDialog.FileName);
                userDialog.Text = $"+ The file {openFileDialog.SafeFileName} loaded :)";
                signalModContainer.Enabled = true;
                signalModContainer.Visible = true;
            } else userDialog.Text = "Loading file caneled :|";
        }

        private void saveButton_Click(object sender, EventArgs e) {

            var res = saveFileDialog.ShowDialog();

            if (res == DialogResult.OK) {
                signalHolder.SaveSignal(saveFileDialog.FileName);
                userDialog.Text = $"+ The file successfully saved to {saveFileDialog.FileName}";
            } else userDialog.Text = "Saving file caneled :|";
            saveFileDialog.FileName = "output";
        }

        private void buttonClear_Click(object sender, EventArgs e) {

            signalHolder.CleanSignal();
            userDialog.Text = "+ Signal reverted to the original state (no effects) :)";

        }

        private bool ParseInfo(int num, ref int i, ref float f, ref double d) {

            if (num == 1) {

                string input = maskedTextBoxPar1.Text.Replace('.', ',');
                if (par1Type == "float") {
                    if (!float.TryParse(input, out f)) {
                        return false;
                    }
                } else if (par1Type == "double") {
                    if (!double.TryParse(input, out d)) {
                        return false;
                    }
                } else if (par1Type == "int") {
                    if (!int.TryParse(input, out i)) {
                        return false;
                    }
                }

            } else {

                string input = maskedTextBoxPar2.Text.Replace('.', ',');
                if (!float.TryParse(input, out f)) {
                    return false;
                }

            }
            return true;
        }

        private void buttonApply_Click(object sender, EventArgs e) {

            int parInt = 0;
            float parFloat = 0.0f;
            double parDouble = 0.0;

            if (!ParseInfo(1, ref parInt, ref parFloat, ref parDouble)) {
                userDialog.Text = "- Input error";
                return;
            }

            userDialog.Text = "Working...";

            switch (effectsComboBox.SelectedIndex) {

                case 0:
                    if (parDouble <= 0) {
                        userDialog.Text = "- Parametr needs to be > 0";
                        return;
                    }
                    SignalOperations.AddWhiteNoise(signalHolder, parDouble);
                    userDialog.Text = "+ White noise added :)";
                    break;
                case 1:
                    if (parInt <= 0) {
                        userDialog.Text = "- Parametr needs to be > 0";
                        return;
                    }
                    SignalOperations.LowPassFilter(signalHolder, parInt);
                    userDialog.Text = "+ Low-pass filter apllied :)";
                    break;
                case 2:
                    if (parInt <= 0) {
                        userDialog.Text = "- Parametr needs to be > 0";
                        return;
                    }
                    SignalOperations.HighPassFilter(signalHolder, parInt);
                    userDialog.Text = "+ High-pass filter applied :)";
                    break;
                case 3:
                    if (parDouble <= 0) {
                        userDialog.Text = "- Parametr needs to be > 0";
                        return;
                    }
                    SignalOperations.TimeStretching(signalHolder, parDouble);
                    userDialog.Text = "+ Time stretched/shrinked :)";
                    break;
                case 4:
                    SignalOperations.ChangeDBLevel(signalHolder, parInt);
                    userDialog.Text = "+ Decibels changed :)";
                    break;
                case 5:
                    if (!ParseInfo(2, ref parInt, ref parFloat, ref parDouble)) {
                        userDialog.Text = "- Input error";
                        return;
                    }
                    if (parInt <= 0 || parFloat <= 0) {
                        userDialog.Text = "- Parametrs needs to be > 0";
                        return;
                    }
                    SignalOperations.Echo(signalHolder, parInt, parFloat);
                    userDialog.Text = "+ Echo effect added :)";
                    break;
                case 6:
                    if (!ParseInfo(2, ref parInt, ref parFloat, ref parDouble)) {
                        userDialog.Text = "- Input error";
                        return;
                    }
                    if (parInt <= 0 || parFloat <= 0) {
                        userDialog.Text = "- Parametrs needs to be > 0";
                        return;
                    }
                    SignalOperations.Delay(signalHolder, parInt, parFloat);
                    userDialog.Text = "+ Delay effect added :)";
                    break;
            }

        }

        private void buttonPlot_Click(object sender, EventArgs e) {

            ScottPlot.Plot plt = signalHolder.GetMagnitudePlot();
            var res = saveFileDialog1.ShowDialog();

            if (res == DialogResult.OK) {
                plt.SavePng(saveFileDialog1.FileName, 1500, 1000);
                userDialog.Text = $"+ The file successfully saved to {saveFileDialog1.FileName}";
            } else userDialog.Text = "Saving file caneled :|";
            saveFileDialog1.FileName = "plot";
        }

 
        
    }
}
