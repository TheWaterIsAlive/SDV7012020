using System;
using System.Windows.Forms;

namespace GiftShopV2
{

    /*
 * Aurther: Allan Fry
 * Date: 25/6/20
 * Description: The form which lets the user select characters
 */
    public partial class frmCharacter : Form
    {

        /*===============================Varables==================================*/
        private static readonly frmCharacter _Instance = new frmCharacter();
        public static frmCharacter Instance => _Instance;
        /*===============================Varables==================================*/

        /*===============================Private Constructure==================================*/
        private frmCharacter()
        {
            InitializeComponent();
        }

        /*===============================Private Constructure==================================*/


        /*===============================Public Funtion Which manages Singleton==================================*/
        public static void Run()
        {

            frmCharacter lcFrmCharacter;
          
            if (Instance == null)
            {
                lcFrmCharacter = new frmCharacter();
                lcFrmCharacter.UpdateDisplay();


            }
            else
            {

                Instance.Show();
                Instance.Activate();
                Instance.UpdateDisplay();
            }
        }

        /*===============================Public Funtion Which manages Singleton==================================*/


        /*===============================Updates text feild basied on database==================================*/
        public async void UpdateDisplay() {

            lstCharacters.DataSource = null;
            lstCharacters.DataSource = await ServiceClient.GetCharacterNamesAsync();

        }
        /*===============================Updates text feild basied on database==================================*/




        /*===============================Over Rides the form closing with just hiding it==================================*/

        private void FrmCharacter_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();

        }
        /*===============================Over Rides the form closing with just hiding it==================================*/


        /*===============================Code for selecting a character==================================*/
        private void LstCharacters_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frmCharacterGifts.Run(lstCharacters.SelectedItem as string, lstCharacters.SelectedIndex.ToString() as string);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*===============================Code for selecting a character==================================*/
    }
}
