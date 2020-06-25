using System;using System.Windows.Forms;

namespace GiftShopV2
{
    public partial class frmGiftList : Form
    {

        /*
         * Aurther: Allan Fry
         * Date: 25/6/20
         * Description: Shows a list of the 
         */

        //===============Signilton Instance
        private static readonly frmGiftList _Instance = new frmGiftList();
        //===============Signilton Instance

        //============Constructor
        public frmGiftList()
        {
            InitializeComponent();
        }
        //============Constructor


        /*===============================Public Funtion Which manages Singleton==================================*/
        public static void Run()
        {

            frmGiftList lcFrmGiftList;

            if (_Instance == null)
            {
                lcFrmGiftList = new frmGiftList();
                lcFrmGiftList.UpdateDisplay();


            }
            else
            {

                _Instance.Show();
                _Instance.Activate();
                _Instance.UpdateDisplay();
            }
        }

        /*===============================Public Funtion Which manages Singleton==================================*/

        /*===============================Updates the gift box==================================*/
        public async void UpdateDisplay()
        {

            lstGifts.DataSource = null;
            lstGifts.DataSource = await ServiceClient.GetGiftNamesAsync();

        }
        /*===============================Updates the gift box==================================*/

        /*===============================Overriders the exit butons code to hide form==================================*/
        private void FrmGiftList_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();

        }
        /*===============================Overriders the exit butons code to hide form==================================*/

        /*===============================Code for when an item is double click in the list box==================================*/
        private void LstGifts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                frmGift.Run(lstGifts.SelectedItem as string, lstGifts.SelectedIndex.ToString() as string);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*===============================Code for when an item is double click in the list box==================================*/
    }
}
