using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
//using System.Data;
using BooksTable;

namespace BooksDisplayTable
{
    public partial class Form1 : Form
    {
        private BooksEntities dbContext = new BooksEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void authorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dbContext.Authors.OrderBy(author => author.LastName)
            //.ThenBy(author => author.FirstName)
            //.Load();

            //authorBindingSource.DataSource = dbContext.Authors.Local;
            button1_Click(sender, e);
        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
            //Question 1
            var authorsAndTitles =
               from author in dbContext.Authors
               from book in author.Titles
               orderby book.Title1
               select new { author.FirstName, author.LastName, book.Title1 };

            outputTextBox.AppendText("1.	 Get a list of all the titles and the authors who wrote them. Sort the results by title.");

            foreach (var element in authorsAndTitles)
            {
                outputTextBox.AppendText(
                   String.Format("\r\n\t{0,-10} {1,-10} {2,-10}",
                      element.FirstName, element.LastName, element.Title1));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();

            //Question 2
            var authorsTitlesAndABC =
               from author in dbContext.Authors
               from book in author.Titles
               orderby book.Title1, author.LastName, author.FirstName
               select new { author.FirstName, author.LastName, book.Title1 };

            outputTextBox.AppendText("2.	 Get a list of all the titles and the authors who wrote them. Sort the results by title.  Each title sort the authors alphabetically by last name, then first name");

            foreach (var element in authorsTitlesAndABC)
            {
                outputTextBox.AppendText(
                   String.Format("\r\n\t{0,-10} {1,-10} {2,-10}",
                      element.FirstName, element.LastName, element.Title1));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();

            //Question 3
            //var authorsTitlesAndABC =
            //   from author in dbContext.Authors
            //   from book in author.Titles
            //   orderby book.Title1, author.LastName, author.FirstName
            //   select new { author.FirstName, author.LastName, book.Title1 };

            // get authors and titles of each book 
            // they co-authored; group by author
            var authorsTitlesGrouped =
               from book in dbContext.Titles
               orderby book.Title1
               select new
               {
                   Name = book.Title1, //author.FirstName + " " + author.LastName,
                   Authors =
                     from author in book.Authors
                     orderby author.LastName, author.FirstName
                     select author.FirstName + " " + author.LastName,
               };

            outputTextBox.AppendText("3.	 Get a list of all the authors grouped by title, sorted by title; for a given title sort the author names alphabetically by last name then first name.");

            foreach (var element in authorsTitlesGrouped)
            {
                outputTextBox.AppendText("\r\n\t" + element.Name + ":");

                // display titles written by that author
                foreach (var author in element.Authors)
                {
                    outputTextBox.AppendText("\r\n\t\t" + author);
                } 
        }
        }
    }
}
