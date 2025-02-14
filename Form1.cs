using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonAdventure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            startButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            startButton.MaximumSize = new Size(200, 50); // Set a reasonable max size
            startButton.MinimumSize = new Size(100, 30); // Ensure it doesn’t get too small
            startButton.TextAlign = ContentAlignment.MiddleCenter;
            startButton.Size = new Size(200, 50);

            titleLabel.Anchor = AnchorStyles.Top;
            titleLabel.AutoSize = true;  // Lets the label adjust its size based on content
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;  // Center the text within the label
            titleLabel.Location = new Point(this.ClientSize.Width / 2 - titleLabel.Width / 2, 20);
        }
    }
}
