using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Author : Meer Zaheen Nazmul
 * Student # : 300522487
 * Date : August, 12th, 2016
 * Description : Movie Bonanza!
 * Version : 0.0.5 
 */
namespace Movie_Bonanza
{
    public partial class StreamForm : Form
    {
        private string title, grandTotal;

        public string titleValue
        {
            get { return title; }
            set { title = value; }
        }

        public string totalValue
        {
            get { return grandTotal; }
            set { grandTotal = value; }
        }

        public StreamForm()
        {
            InitializeComponent();
        }

        private void StreamForm_Load(object sender, EventArgs e)
        {
            GrandTotalText.Text = "Your Credit card will be charged " + grandTotal.ToString();
            ChosenMovieLabel.Text = title + " will begin streaming shortly.";
        }


    }
}
