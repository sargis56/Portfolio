using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwimLibrary;

namespace SNahapetyan_300904358_A4
{
    public partial class Form1 : Form
    {
        Club club;
        Club aClub;
        Swimmer swimmer;
        Swimmer aSwimmer;
        Swimmer aClubsSwimmer;
        Coach coach;
        Coach aCoach;
        Coach aClubCoach;

        public Form1()
        {
            InitializeComponent();
        }

        private void butAddClub_Click(object sender, EventArgs e)
        {
            if (txtBoxClubName.Text == "")
            {
                MessageBox.Show("No Name Entered", "Add Club Failed", MessageBoxButtons.OK);
            }
            else if (txtBoxClubPhoneNum.Text == "")
            {
                MessageBox.Show("No Phone Number Entered", "Add Club Failed", MessageBoxButtons.OK);
            }
            else
            {
                Address address = new Address(txtBoxClubAddressStreet.Text, txtBoxClubAddressCity.Text, txtBoxClubAddressProvince.Text, txtBoxClubAddressZip.Text);
                club = new Club(txtBoxClubName.Text, address, Convert.ToInt64(txtBoxClubPhoneNum.Text));
                lstBoxClubs.Items.Add(club);
                MessageBox.Show("Club has been added successfully", "Add Club Successful", MessageBoxButtons.OK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butAddSwimmer_Click(object sender, EventArgs e)
        {
            if (txtBoxSwimmerName.Text == "")
            {
                MessageBox.Show("No Name Entered", "Add Swimmer Failed", MessageBoxButtons.OK);
            }
            else if (txtBoxSwimmerPhoneNum.Text == "")
            {
                MessageBox.Show("No Phone Number Entered", "Add Swimmer Failed", MessageBoxButtons.OK);
            }
            else if ((txtBoxSwimmerDOBYear.Text == "") || (comboBoxSwimmerDOBMonth.Text == "") || (comboBoxSwimmerDOBDay.Text == ""))
            {
                MessageBox.Show("Date of Birth Not Properly Entered", "Add Swimmer Failed", MessageBoxButtons.OK);
            }
            else if (Convert.ToInt32(comboBoxSwimmerDOBDay.Text) > 12)
            {
                MessageBox.Show("Date of Birth's month should not be greater then 12", "Add Coach Failed", MessageBoxButtons.OK);
            }
            else
            {
                Address address = new Address(txtBoxSwimmerAddressStreet.Text, txtBoxSwimmerAddressCity.Text, txtBoxSwimmerAddressProvince.Text, txtBoxSwimmerAddressZip.Text);
                DateTime dOB = new DateTime(Convert.ToInt32(txtBoxSwimmerDOBYear.Text), Convert.ToInt32(comboBoxSwimmerDOBMonth.Text), Convert.ToInt32(comboBoxSwimmerDOBDay.Text));
                swimmer = new Swimmer(txtBoxSwimmerName.Text, dOB, address, Convert.ToInt64(txtBoxSwimmerPhoneNum.Text));
                lstBoxSwimmers.Items.Add(swimmer);
                MessageBox.Show("Swimmer has been added successfully", "Add Swimmer Successful", MessageBoxButtons.OK);
            }
        }

        private void lstBoxSwimmers_SelectedIndexChanged(object sender, EventArgs e)
        {
            aSwimmer = (Swimmer)lstBoxSwimmers.SelectedItem;
        }

        private void lstBoxClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBoxClubsSwimmers.Items.Clear();
            lstBoxClubsCoachs.Items.Clear();

            aClub = (Club)lstBoxClubs.SelectedItem;

            lblSwimmerClub.Text = "Add selected Swimmer to Club " + aClub.ClubName + "?";
            lblCoachClub.Text = "Add selected Coach to Club " + aClub.ClubName + "?";

            lblClubNameInfo.Text = "Club Name: " + aClub.ClubName;
            lblClubAddressInfo.Text = "Club Address: " + aClub.Adress;
            lblClubPhoneNumInfo.Text = "Club Phone Number:\n" + aClub.ClubPhone;
            lblClubRegInfo.Text = "Club Registration Number: " + aClub.ClubNumber;

            foreach (Swimmer item in aClub.ArraySwimmers)
            {
                lstBoxClubsSwimmers.Items.Add(item);
            }
            foreach (Coach item in aClub.ArrayCoaches)
            {
                lstBoxClubsCoachs.Items.Add(item);
            }
        }

        private void butAddSwimmerToClub_Click(object sender, EventArgs e)
        {
            if (aSwimmer == null)
            {
                MessageBox.Show("No Swimmer selected", "Swimmer Added To Club Failed", MessageBoxButtons.OK);
            }
            else if (aClub == null)
            {
                MessageBox.Show("No Club selected", "Swimmer Added To Club Failed", MessageBoxButtons.OK);
            }
            else
            {
                aClub.AddSwimmer(aSwimmer);
                MessageBox.Show("Swimmer " + aSwimmer.RegistrantName + " has been added to club " + aClub.ClubName + " successfully", "Swimmer Added To Club Successfully", MessageBoxButtons.OK);
            }           
        }

        private void butAddCoach_Click(object sender, EventArgs e)
        {
            if (txtBoxCoachName.Text == "")
            {
                MessageBox.Show("No Name Entered", "Add Coach Failed", MessageBoxButtons.OK);
            }
            else if (txtBoxCoachPhoneNum.Text == "")
            {
                MessageBox.Show("No Phone Number Entered", "Add Coach Failed", MessageBoxButtons.OK);
            }
            else if ((txtBoxCoachDOBYear.Text == "") || (comboBoxCoachDOBMonth.Text == "") || (comboBoxCoachDOBDay.Text == ""))
            {
                MessageBox.Show("Date of Birth Not Properly Entered", "Add Coach Failed", MessageBoxButtons.OK);
            }
            else if (Convert.ToInt32(comboBoxCoachDOBMonth.Text) > 12)
            {
                MessageBox.Show("Date of Birth's month should not be greater then 12", "Add Coach Failed", MessageBoxButtons.OK);
            }
            else
            {
                Address address = new Address(txtBoxCoachAddressStreet.Text, txtBoxCoachAddressCity.Text, txtBoxCoachAddressProvince.Text, txtBoxCoachAddressZip.Text);
                DateTime dOB = new DateTime(Convert.ToInt32(txtBoxCoachDOBYear.Text), Convert.ToInt32(comboBoxCoachDOBMonth.Text), Convert.ToInt32(comboBoxCoachDOBDay.Text));
                coach = new Coach(txtBoxCoachName.Text, dOB, address, Convert.ToInt64(txtBoxCoachPhoneNum.Text));
                lstBoxCoachs.Items.Add(coach);
                MessageBox.Show("Coach has been added successfully", "Add Coach Successful", MessageBoxButtons.OK);
            }
        }

        private void lstBoxCoachs_SelectedIndexChanged(object sender, EventArgs e)
        {
            aCoach = (Coach)lstBoxCoachs.SelectedItem;
        }

        private void butAddCoachToClub_Click(object sender, EventArgs e)
        {
            if (aCoach == null)
            {
                MessageBox.Show("No Coach selected", "Coach Added To Club Failed", MessageBoxButtons.OK);
            }
            else if (aClub == null)
            {
                MessageBox.Show("No Club selected", "Coach Added To Club Failed", MessageBoxButtons.OK);
            }
            else
            {
                aClub.AddCoach(aCoach);
                MessageBox.Show("Coach " + aCoach.RegistrantName + " has been added to club " + aClub.ClubName + " successfully", "Coach Added To Club Successfully", MessageBoxButtons.OK);
            }
        }

        private void lstBoxClubsSwimmers_SelectedIndexChanged(object sender, EventArgs e)
        {
            aClubsSwimmer = (Swimmer)lstBoxClubsSwimmers.SelectedItem;

            lblClubSwimmerNameInfo.Text = "Swimmer Name: " + aClubsSwimmer.RegistrantName;
            lblClubSwimmerPhoneNumInfo.Text = "Swimmer Phone Number: \n" + aClubsSwimmer.RegistrantPhone;
            lblClubSwimmerDOBInfo.Text = "Swimmer Date of Birth:\n" + aClubsSwimmer.RegistrantDate;
            lblClubSwimmerAddressInfo.Text = "Swimmer Address: " + aClubsSwimmer.Adress;
            lblClubSwimmerRegInfo.Text = "Swimmer Registration Number: " + aClubsSwimmer.RegistrantNumber;
        }

        private void lstBoxClubsCoachs_SelectedIndexChanged(object sender, EventArgs e)
        {
            aClubCoach = (Coach)lstBoxClubsCoachs.SelectedItem;

            lblClubCoachNameInfo.Text = "Coach Name: " + aClubCoach.RegistrantName;
            lblClubCoachPhoneNumInfo.Text = "Coach Phone Number: \n" + aClubCoach.RegistrantPhone;
            lblClubCoachDOBInfo.Text = "Coach Date of Birth:\n" + aClubCoach.RegistrantDate;
            lblClubCoachAddressInfo.Text = "Coach Address: " + aClubCoach.Adress;
            lblClubCoachRegInfo.Text = "Coach Registration Number: " + aClubCoach.RegistrantNumber;
        }

        private void lblClubAddressInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblClubCoachDOBInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblClubSwimmerDOBInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblClubCoachRegInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblClubCoachAddressInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblClubRegInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblClubSwimmerRegInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblClubSwimmerAddressInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
