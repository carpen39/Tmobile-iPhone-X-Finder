using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{


    public class AppleResponse
    {
        public Head head { get; set; }
        public Body body { get; set; }
    }

    public class Head
    {
        public string status { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
    }

    public class Body
    {
        public Store[] stores { get; set; }
        public bool overlayInitiatedFromWarmStart { get; set; }
        public string viewMoreHoursLinkText { get; set; }
        public string storesCount { get; set; }
        public bool little { get; set; }
        public string location { get; set; }
        public string notAvailableNearby { get; set; }
        public string notAvailableNearOneStore { get; set; }
        public string productLocatorSpecialHours { get; set; }
        public string productLocatorSpecialHoursView { get; set; }
    }

    public class Store
    {
        public string storeEmail { get; set; }
        public string storeName { get; set; }
        public string reservationUrl { get; set; }
        public string makeReservationUrl { get; set; }
        public string state { get; set; }
        public string storeImageUrl { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string storeNumber { get; set; }
        public Dictionary<string, Parts> partsAvailability { get; set; }
        public string phoneNumber { get; set; }
        public Address address { get; set; }
        public string hoursUrl { get; set; }
        public string directionsUrl { get; set; }
        public Storehours storeHours { get; set; }
        public float storelatitude { get; set; }
        public float storelongitude { get; set; }
        public float storedistance { get; set; }
        public string storeDistanceWithUnit { get; set; }
        public string storeDistanceVoText { get; set; }
        public int storelistnumber { get; set; }
        public int storeListNumber { get; set; }
    }

    public class Partsavailability
    {
        public MQAM2LLA MQAM2LLA { get; set; }
    }


    public class Parts
    {
        public bool storePickEligible { get; set; }
        public bool storeSearchEnabled { get; set; }
        public bool storeSelectionEnabled { get; set; }
        public string storePickupQuote { get; set; }
        public string pickupSearchQuote { get; set; }
        public string storePickupLabel { get; set; }
        public string partNumber { get; set; }
        public string purchaseOption { get; set; }
        public string ctoOptions { get; set; }
        public string storePickupLinkText { get; set; }
        public string storePickupProductTitle { get; set; }
        public string pickupDisplay { get; set; }
    }


    public class MQAM2LLA
    {
        public bool storePickEligible { get; set; }
        public bool storeSearchEnabled { get; set; }
        public bool storeSelectionEnabled { get; set; }
        public string storePickupQuote { get; set; }
        public string pickupSearchQuote { get; set; }
        public string storePickupLabel { get; set; }
        public string partNumber { get; set; }
        public string purchaseOption { get; set; }
        public string ctoOptions { get; set; }
        public string storePickupLinkText { get; set; }
        public string storePickupProductTitle { get; set; }
        public string pickupDisplay { get; set; }
    }

    public class Address
    {
        public string address { get; set; }
        public object address3 { get; set; }
        public string address2 { get; set; }
        public string postalCode { get; set; }
    }

    public class Storehours
    {
        public string storeHoursText { get; set; }
        public string bopisPickupDays { get; set; }
        public string bopisPickupHours { get; set; }
        public Hour[] hours { get; set; }
    }

    public class Hour
    {
        public string storeTimings { get; set; }
        public string storeDays { get; set; }
    }


}
