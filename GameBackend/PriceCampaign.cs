using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class PriceCampaign:ICampaignsManagement
    {
        public void AddCampaign()
        {
            Console.WriteLine("CAMPAIGN ADDED");
        }

        public void DeleteCampaign()
        {
            Console.WriteLine("CAMPAIGN DELETED");
        }
    }
}
