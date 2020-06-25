using System;


namespace GiftStoreSelfHost
{

    /*
    * Aurther: Allan Fry
    * Date: 25/6/20
    * Description: Store the classes which are the analoge to what is stored in the database.
    */




    /*=============================Character Class=============================*/
    public class clsCharacter
    {

        public int CharacterID { get; set; }
        public string CharacterName { get; set; }
        public string PlayerName { get; set; }
        public bool Finalised { get; set; }
    }
    /*=============================Character Class=============================*/

    /*=============================Gift Class=============================*/
    public class clsGift
    {

        public int GiftID { get; set; }
        public string GiftName { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
        public bool Availibity { get; set; }
        public string Effect { get; set; }
        public string ModuleName { get; set; }
        public int CharacterID { get; set; }
        public int ExpValue { get; set; }
        public int GoldValue { get; set; }
        public bool GiftType { get; set; }
        public string ItemType { get; set; }
        public string Source { get; set; }

    }
    /*=============================Gift Class=============================*/
}
