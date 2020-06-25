
using System.Collections.Generic;
using System.Windows.Forms;

namespace GiftShopV2
{

    /*
     * Aurther: Allan Fry
     * Date: 25/6/20
     * Description:
     */


    public partial class frmGift : Form
    {

        /*=============================Varables=================================*/
        private static Dictionary<string, frmGift> _GiftFormList = new Dictionary<string, frmGift>();
        private clsGift _Gift;
        /*=============================Varables=================================*/

        public frmGift()
        {
            InitializeComponent();
        }

        /*======================Manages Instances Of Form ================================*/
        public static void Run(string prGiftName, string prGiftID)
        {
            frmGift lcGiftForm;

            if (string.IsNullOrEmpty(prGiftName) || !_GiftFormList.TryGetValue(prGiftName, out lcGiftForm))
            {
                lcGiftForm = new frmGift();
                if (string.IsNullOrEmpty(prGiftName))
                    lcGiftForm.SetDetails(new clsGift());

                else
                {
                    _GiftFormList.Add(prGiftName, lcGiftForm);
                    lcGiftForm.refreshFormFromDB(prGiftID);

                }
            }
            else
            {
                lcGiftForm.Show();
                lcGiftForm.Activate();
            }
        }

        /*======================Manages Instances Of Form ================================*/

         /*=========================Database Refreash===============================*/ 
        private async void refreshFormFromDB(string prGiftID)
        {
            SetDetails(await ServiceClient.GetGiftAsync(int.Parse(prGiftID)));
        }
        /*=========================Database Refreash===============================*/



        /*=========================Update and show Form With Gift Details===============================*/
        public void SetDetails(clsGift prGift)
        {
            _Gift = prGift;
            UpdateForm();
            Show();
        }

        /*=========================Update and show Form With Gift Details===============================*/


        /*=========================Populate the forms feilds with the approprate informatiom===============================*/
        private void UpdateForm()
        {
            txtGiftName.Text = _Gift.GiftName;
            txtGiftDescription.Text = _Gift.Description;
            txtGiftEffect.Text = _Gift.Effect;
            chbAvailable.Checked = _Gift.Availibity;
            lblLastUpdate.Text = "Last Updated: " + _Gift.LastUpdated;
        }

        /*=========================Populate the forms feilds with the approprate informatiom===============================*/
    }
}
