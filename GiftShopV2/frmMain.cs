using System;
using System.Windows.Forms;

namespace GiftShopV2
{

    /*
     * 
     * Aurther:Allan Fry
     * Date: 25/6/20
     * Description: This is the form which the application open to. 
     * It allows the user to navigate the application and will close all other forms
     * if it is closed.
     */
    public partial class frmMain : Form
    {
        //=====================The Instance varable for this forms singleton pattern
        private static readonly frmMain _Instance = new frmMain();
        //=====================The Instance varable for this forms singleton pattern
        public frmMain()
        {
            InitializeComponent();
        }
        //====The public accessers for private varables.=========================
        public static frmMain Instance
        {
            get { return frmMain._Instance; }
        }
        //====The public accessers for private varables.==========================

        //====Exit button==============================================
        private void BtnMainExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //====Exit button==============================================
        //====Button which creates or opens the character screen=======
        private void BtnGoToCharacters_Click(object sender, EventArgs e)
        {
           
                frmCharacter.Run();

        }
        //====Button which creates or opens the character screen=======
        //====Button which creates or opens the Gift screen=======
        private void BtnGoToGifts_Click(object sender, EventArgs e)
        {
            frmGiftList.Run();
        }
        //====Button which creates or opens the character screen=======
    }
}
