namespace ProcSygWinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            userDialog = new Label();
            loadButton = new Button();
            signalModContainer = new Panel();
            buttonPlot = new Button();
            labelPar2 = new Label();
            maskedTextBoxPar2 = new MaskedTextBox();
            buttonClear = new Button();
            buttonApply = new Button();
            label2 = new Label();
            labelPar1 = new Label();
            maskedTextBoxPar1 = new MaskedTextBox();
            effectsComboBox = new ComboBox();
            saveButton = new Button();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            signalModContainer.SuspendLayout();
            SuspendLayout();
            // 
            // userDialog
            // 
            userDialog.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userDialog.AutoEllipsis = true;
            userDialog.BackColor = Color.DimGray;
            userDialog.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            userDialog.Location = new Point(26, 9);
            userDialog.Margin = new Padding(7, 0, 7, 0);
            userDialog.Name = "userDialog";
            userDialog.Size = new Size(903, 133);
            userDialog.TabIndex = 1;
            userDialog.Text = "Hello :)";
            userDialog.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loadButton
            // 
            loadButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loadButton.BackColor = Color.DimGray;
            loadButton.Location = new Point(572, 191);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(366, 51);
            loadButton.TabIndex = 2;
            loadButton.Text = "Load .wav file";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_LoadFile;
            // 
            // signalModContainer
            // 
            signalModContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signalModContainer.Controls.Add(buttonPlot);
            signalModContainer.Controls.Add(labelPar2);
            signalModContainer.Controls.Add(maskedTextBoxPar2);
            signalModContainer.Controls.Add(buttonClear);
            signalModContainer.Controls.Add(buttonApply);
            signalModContainer.Controls.Add(label2);
            signalModContainer.Controls.Add(labelPar1);
            signalModContainer.Controls.Add(maskedTextBoxPar1);
            signalModContainer.Controls.Add(effectsComboBox);
            signalModContainer.Controls.Add(saveButton);
            signalModContainer.Enabled = false;
            signalModContainer.Location = new Point(2, 248);
            signalModContainer.Name = "signalModContainer";
            signalModContainer.Size = new Size(953, 396);
            signalModContainer.TabIndex = 3;
            signalModContainer.Visible = false;
            // 
            // buttonPlot
            // 
            buttonPlot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonPlot.BackColor = Color.DimGray;
            buttonPlot.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonPlot.Location = new Point(570, 95);
            buttonPlot.Name = "buttonPlot";
            buttonPlot.Size = new Size(366, 64);
            buttonPlot.TabIndex = 13;
            buttonPlot.Text = "Save magnitude spectrum to .png";
            buttonPlot.UseVisualStyleBackColor = false;
            buttonPlot.Click += buttonPlot_Click;
            // 
            // labelPar2
            // 
            labelPar2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelPar2.AutoEllipsis = true;
            labelPar2.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelPar2.Location = new Point(34, 264);
            labelPar2.Name = "labelPar2";
            labelPar2.Size = new Size(278, 59);
            labelPar2.TabIndex = 12;
            labelPar2.Text = "Par2";
            labelPar2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxPar2
            // 
            maskedTextBoxPar2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBoxPar2.Culture = new System.Globalization.CultureInfo("en-001");
            maskedTextBoxPar2.Location = new Point(83, 326);
            maskedTextBoxPar2.Name = "maskedTextBoxPar2";
            maskedTextBoxPar2.Size = new Size(177, 39);
            maskedTextBoxPar2.TabIndex = 11;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonClear.BackColor = Color.Maroon;
            buttonClear.Location = new Point(675, 299);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(177, 50);
            buttonClear.TabIndex = 10;
            buttonClear.Text = "Clear effects";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonApply
            // 
            buttonApply.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonApply.BackColor = Color.Teal;
            buttonApply.Location = new Point(675, 209);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(177, 64);
            buttonApply.TabIndex = 9;
            buttonApply.Text = "Apply";
            buttonApply.UseVisualStyleBackColor = false;
            buttonApply.Click += buttonApply_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(128, 14);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 8;
            label2.Text = "Effect";
            // 
            // labelPar1
            // 
            labelPar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelPar1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelPar1.Location = new Point(34, 118);
            labelPar1.Name = "labelPar1";
            labelPar1.Size = new Size(278, 69);
            labelPar1.TabIndex = 7;
            labelPar1.Text = "Par1";
            labelPar1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxPar1
            // 
            maskedTextBoxPar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBoxPar1.Location = new Point(83, 190);
            maskedTextBoxPar1.Name = "maskedTextBoxPar1";
            maskedTextBoxPar1.Size = new Size(177, 39);
            maskedTextBoxPar1.TabIndex = 6;
            // 
            // effectsComboBox
            // 
            effectsComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            effectsComboBox.BackColor = Color.DimGray;
            effectsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            effectsComboBox.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            effectsComboBox.ForeColor = Color.WhiteSmoke;
            effectsComboBox.FormattingEnabled = true;
            effectsComboBox.ImeMode = ImeMode.NoControl;
            effectsComboBox.Items.AddRange(new object[] { "Add white noise", "Low-pass filter", "High-pass filter", "Time stretching/shrinking", "Change amplitude level", "Echo", "Delay" });
            effectsComboBox.Location = new Point(34, 49);
            effectsComboBox.Name = "effectsComboBox";
            effectsComboBox.Size = new Size(278, 32);
            effectsComboBox.TabIndex = 5;
            effectsComboBox.SelectionChangeCommitted += effectsComboBox_SelectionChangeCommitted;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            saveButton.BackColor = Color.DimGray;
            saveButton.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            saveButton.Location = new Point(570, 14);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(366, 49);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save signal to .wav";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.DefaultExt = "wav";
            openFileDialog.FileName = "openFileDialog";
            openFileDialog.Filter = "plik .wav |*.wav";
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "wav";
            saveFileDialog.FileName = "output.wav";
            saveFileDialog.Filter = "plik .wav |*.wav";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "png";
            saveFileDialog1.FileName = "plot.png";
            saveFileDialog1.Filter = "plik .png |*.png";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(955, 653);
            Controls.Add(signalModContainer);
            Controls.Add(loadButton);
            Controls.Add(userDialog);
            Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(7, 6, 7, 6);
            MaximizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Project mark = 5.0";
            signalModContainer.ResumeLayout(false);
            signalModContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label userDialog;
        private Button loadButton;
        private Panel signalModContainer;
        private Button saveButton;
        private ComboBox effectsComboBox;
        private OpenFileDialog openFileDialog;
        private Button buttonApply;
        private Label label2;
        private Label labelPar1;
        private MaskedTextBox maskedTextBoxPar1;
        private Button buttonClear;
        private Button buttonPlot;
        private Label labelPar2;
        private MaskedTextBox maskedTextBoxPar2;
        private SaveFileDialog saveFileDialog;
        private SaveFileDialog saveFileDialog1;
    }
}
