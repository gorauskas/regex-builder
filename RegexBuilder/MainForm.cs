using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexBuilder {

    /// <summary>
    /// Main user interface
    /// </summary>
    public partial class MainForm : Form {

        private Regex regex;
        private MatchCollection matches;
        private List<Style> styles = new List<Style>();

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainForm() {
            InitializeComponent();
            registerStyles();
        }

        /// <summary>
        /// 3 default styles that will be alternated
        /// </summary>
        private void registerStyles() {
            styles.Add(new Style(Color.FromArgb(153, 204, 255), Color.Black)); // blueish
            styles.Add(new Style(Color.FromArgb(255, 153, 153), Color.Black)); // redish
            styles.Add(new Style(Color.FromArgb(153, 255, 153), Color.Black)); // greenish
        }
        
        /// <summary>
        /// Removes all styles from text box
        /// </summary>
        public void clearStyle() {
            rtbTest.SelectAll();
            rtbTest.SelectionColor = Color.Black;
            rtbTest.SelectionBackColor = Color.White;
            rtbTest.Select(0, 0);
            //string s = @"this is a test"; 
        }

        /// <summary>
        /// Returns one of the styles alternates
        /// </summary>
        /// <param name="i">and index to mod into the style list</param>
        /// <returns>A Style object</returns>
        public Style getStyle(int i) {
            int j = i % 3;
            return styles[j];
        }

        /// <summary>
        /// Finds all the Regex matches agains the sample text
        /// </summary>
        public void matchRegex() {
            string regexPattern = textRegex.Text;
            string inputText = rtbTest.Text;
            int i = 0;

            RegexOptions ro = new RegexOptions();
            
            if (!checkCase.Checked) 
                ro = ro | RegexOptions.IgnoreCase;

            if (checkMultiLine.Checked)
                ro = ro | RegexOptions.Multiline;

            regex = new Regex(regexPattern, ro);
            matches = regex.Matches(inputText);

            foreach (Match m in matches) {
                Style s = getStyle(i);
                rtbTest.SelectionStart = m.Index;
                rtbTest.SelectionLength = m.Length;
                rtbTest.SelectionColor = s.ForegroundColor;
                rtbTest.SelectionBackColor = s.BackgroundColor;
                rtbTest.Select(m.Index + m.Length, 0);

                i++;
            }
        }

        private void buttonMatch_Click(object sender, EventArgs e) {
            clearStyle();
            matchRegex();
        }

        private void buttonClear_Click(object sender, EventArgs e) {
            clearStyle();
        }
    }

}
