using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataMiner
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
            bars = new Panel[] { pnlJan, pnlFeb, pnlMar, pnlApr, pnlMay, pnlJun, pnlJul, pnlAug, pnlSep, pnlOct, pnlNov, pnlDec };

        }

        #region Variables

        Color[] barColours;
        Panel[] bars;
        bool save = false;

        #endregion
        #region Properties

        public Color[] BarColours
        {
            get
            {
                return barColours;
            }
            set
            {
                barColours = value;
            }
        }
        public bool Save
        {
            get
            {
                return save;
            }
            private set
            {
                save = value;
            }

        }

        #endregion
        #region Methods

        /// <summary>
        /// Sets the colours of the bars to the colours in the colour array
        /// </summary>
        private void UpdateBars()
        {
            for (int i = 0; i < bars.Length; i++)
            {
                bars[i].BackColor = barColours[i];
            }
        }

        #endregion
        #region Events

        /// <summary>
        /// When the save button is pressed
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The Event Data</param>
        private void btnsave(object sender, EventArgs e)
        {
            Save = true;
            Close();
        }

        /// <summary>
        /// When this form first opens
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The Event Data</param>
        private void frmOptions_Load(object sender, EventArgs e)
        {
            bool isTheSame = true;
            for (int i = 1; i < barColours.Length; i++)
            {
                if (barColours[i] != barColours[i - 1])
                    isTheSame = false;
            }
            cbUseOneColour.Checked = isTheSame;

            UpdateBars();
        }

        /// <summary>
        /// When the 'Use one colour' checkbox is clicked
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The Event Data</param>
        private void cbUseOneColour_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUseOneColour.Checked == true)
            {
                for (int i = 0; i < barColours.Length; i++)
                {
                    barColours[i] = barColours[0];
                }
                UpdateBars();
            }
        }

        /// <summary>
        /// When a bar in the graph is clicked on
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The Event Data</param>
        private void pnlBar_Click(object sender, EventArgs e)
        {
            cdBarColourPicker.ShowDialog();
            if (cbUseOneColour.Checked)
            {
                for (int i = 0; i < bars.Length; i++)
                {
                    barColours[i] = cdBarColourPicker.Color;
                }
            }
            else
            {
                barColours[Convert.ToInt32((sender as Panel).Tag)] = cdBarColourPicker.Color;
            }

            UpdateBars();
        }

        /// <summary>
        /// When the form is about to close
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The Event Data</param>
        private void frmOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Save)
            {
                switch(MessageBox.Show("Are you sure you want to close the options without saving?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
                {
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                }
            }
        }

        #endregion
    }
}
