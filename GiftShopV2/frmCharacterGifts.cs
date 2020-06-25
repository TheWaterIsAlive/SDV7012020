using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GiftShopV2
{
    /*
* Aurther: Allan Fry
* Date: 25/6/20
* Description: The Form for editing characters
*/
    public partial class frmCharacterGifts : Form
    {

        /*===============================Varables==================================*/
        private static Dictionary<string, frmCharacterGifts> _CharacterFormList = new Dictionary<string, frmCharacterGifts>();
        private clsCharacter _Character;

        /*===============================Varables==================================*/


        /*===============================Private Constructure==================================*/
        private frmCharacterGifts()
        {
            InitializeComponent();
        }

        /*===============================Private Constructure==================================*/


        /*===============================Manages Indurivatle forms for each character==================================*/
        public static void Run(string prCharacterName, string prCharacterID)
        {
            frmCharacterGifts lcCharacterForm;

            if (string.IsNullOrEmpty(prCharacterName) || !_CharacterFormList.TryGetValue(prCharacterName, out lcCharacterForm))
            {
                lcCharacterForm = new frmCharacterGifts();
                if (string.IsNullOrEmpty(prCharacterName))
                    lcCharacterForm.SetDetails(new clsCharacter());

                else
                {
                    _CharacterFormList.Add(prCharacterName, lcCharacterForm);
                    lcCharacterForm.refreshFormFromDB(prCharacterID);

                }
            }
            else
            {
                lcCharacterForm.Show();
                lcCharacterForm.Activate();
            }
        }

        /*===============================Manages Indurivatle forms for each character==================================*/

        //=====================Refreases the data in the database

        private async void refreshFormFromDB(string prCharacterID)
        {
           
            SetDetails(await ServiceClient.GetCharacterAsync(int.Parse(prCharacterID)));
        }

        //=====================Refreases the data in the database

        //=====================Sets the details of the form
        public void SetDetails(clsCharacter prCharacter)
        {
            _Character = prCharacter;
            UpdateForm();
            UpdateDisplay();
            Show();
        }
        //=====================Sets the details of the form

        //=====================This updates the gift box for the character

        private async void UpdateDisplay()
        {
            lstCharacterGifts.DataSource = null;
            lstCharacterGifts.DataSource = await ServiceClient.GetCharacterGiftsAsync(_Character.CharacterID);
         }
        //=====================This updates the gift box for the character

        //=====================This updates the input fields on the form

        public void UpdateForm()
        {
            txtCharacterName.Text = _Character.CharacterName;
            txtPlayerName.Text = _Character.PlayerName;
            lblCharacterID.Text = _Character.CharacterID.ToString();
            chbFinalised.Checked = _Character.Finalised;
        }
        //=====================This updates the input fields on the form

        //=====================Controls the exit button

        private async void BtnExit_Click(object sender, EventArgs e)
        {
                pushData();
                MessageBox.Show(await ServiceClient.UpdateCharacterAsync(_Character));
            frmCharacter.Instance.UpdateDisplay();
            Hide();
        }
        //=====================Controls the exit button

        //=====================Updates the cached data
        private void pushData()
        {
            _Character.CharacterName = txtCharacterName.Text;
            _Character.PlayerName = txtPlayerName.Text;
            _Character.Finalised = chbFinalised.Checked;
        }
        //=====================Updates the cached data

        //=====================Overrides exit funtion
        private void FrmCharacterGifts_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        //=====================Overrides exit funtion
    }





}
