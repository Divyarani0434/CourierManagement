using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagement.Entities
{
    internal class Courier
    {
        private long courierID;
        private string senderName;
        private string senderAddress;
        private string receiverName;
        private string receiverAddress;
        private double weight;
        private string status;
        private long trackingNumber;
        private DateTime deliveryDate;
        private int userId;

    
        public Courier() { }

        public Courier(long courierID, string senderName, string senderAddress, string receiverName,
                       string receiverAddress, double weight, string status, long trackingNumber, DateTime deliveryDate, int userId)
        {
            this.courierID = courierID;
            this.senderName = senderName;
            this.senderAddress = senderAddress;
            this.receiverName = receiverName;
            this.receiverAddress = receiverAddress;
            this.weight = weight;
            this.status = status;
            this.trackingNumber = trackingNumber;
            this.deliveryDate = deliveryDate;
            this.userId = userId;
        }

        public long CourierID { get => courierID; set => courierID = value; }
        public string SenderName { get => senderName; set => senderName = value; }
        public string SenderAddress { get => senderAddress; set => senderAddress = value; }
        public string ReceiverName { get => receiverName; set => receiverName = value; }
        public string ReceiverAddress { get => receiverAddress; set => receiverAddress = value; }
        public double Weight { get => weight; set => weight = value; }
        public string Status { get => status; set => status = value; }
        public long TrackingNumber { get => trackingNumber; set => trackingNumber = value; }
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
        public int UserId { get => userId; set => userId = value; }

        public override string ToString()
        {
            return $"Courier{{courierID={courierID}, senderName='{senderName}', senderAddress='{senderAddress}', receiverName='{receiverName}', receiverAddress='{receiverAddress}', weight={weight}, status='{status}', trackingNumber={trackingNumber}, deliveryDate={deliveryDate}, userId={userId}}}";
        }
    }
}

