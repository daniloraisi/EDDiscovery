﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDDiscovery.EliteDangerous.JournalEvents
{
    
  public class JournalShipyardSell : JournalEntry
    {
        //When Written: when selling a ship stored in the shipyard
        //Parameters:
        //•	ShipType: type of ship being sold
        //•	SellShipID
        //•	ShipPrice: sale price
        //•	System: (if ship is in another system) name of system
        public JournalShipyardSell(JObject evt ) : base(evt, JournalTypeEnum.ShipyardSell)
        {
            ShipType = Tools.GetStringDef(evt["ShipType"]);
            SellShipId = Tools.GetInt(evt["SellShipID"]);
            ShipPrice = Tools.GetInt(evt["ShipPrice"]);
            System = Tools.GetStringDef(evt["System"]);
        }
        public string ShipType { get; set; }
        public int SellShipId { get; set; }
        public int ShipPrice { get; set; }
        public string System { get; set; }

        public override string DefaultRemoveItems()
        {
            return base.DefaultRemoveItems() + ";SellShipID";
        }

        public static System.Drawing.Bitmap Icon { get { return EDDiscovery.Properties.Resources.shipyardsell; } }

    }
}
