using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rashmatz1 {
    class Item {
        /*
         * Each item is a DB row
        */

        public string itemID { get; set; }
        public string itemName { get; set; }
        public string itemData { get; set; }
        public string itemCount { get; set; }
        public string itemMakat { get; set; }
        public string itemMakatFactory { get; set; }
        public string itemLocation { get; set; }
        public string itemComments { get; set; }
        public string itemSign { get; set; }
        public string createdOn { get; set; }
        public string updatedOn { get; set; }
    }
}
