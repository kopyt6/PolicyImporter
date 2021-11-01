using System;

namespace WpfApp1.Importing
{
    class PolicyObject
    {
        public String expirationDate { get; set; }
        public String insurerName { get; set; }
        public String number { get; set; }
        public String products { get; set; }
        public String clientName { get; set; }
        public String clientPhoneNumber { get; set; }
        public String vehicleDetails { get; set; }
        public String licensePlateNumber { get; set; }
        public String cost { get; set; }
        public String clientPeselRegon { get; set; }
        public String clientAddress { get; set; }
        public String policyNotes { get; set; }
        public String employeeID { get; set; }
        public PolicyObject()
        {
            this.expirationDate = "";
            this.insurerName = "";
            this.number = "";
            this.products = "";
            this.clientName = "";
            this.clientPhoneNumber = "";
            this.vehicleDetails = "";
            this.licensePlateNumber = "";
            this.cost = "";
            this.clientAddress = "";
            this.clientPeselRegon = "";
            this.policyNotes = "";
            this.employeeID = "";
        }
        public PolicyObject ConcatProducts(String productToAdd)
        {
            this.products = String.Format("%s, %s", products, productToAdd);
            return this;
        }

        public PolicyObject SumCosts(String cost)
        {
            if (!String.IsNullOrEmpty(cost))
                this.cost = (Double.Parse(this.cost) + Double.Parse(cost)).ToString();
            int i = 1;
            return this;
        }

        public PolicyObject UpdateExpirationDate(String updatedDate)
        {
            this.expirationDate = updatedDate;
            return this;
        }

        public PolicyObject UpdatePhoneNumber(String updatedPhoneNumber)
        {
            this.clientPhoneNumber = updatedPhoneNumber;
            return this;
        }

        override public String ToString()
        {
            return
                    (expirationDate + ";" +
                            insurerName + ";" +
                            number + ";" +
                            products + ";" +
                            clientName + ";" +
                            clientPhoneNumber + ";" +
                            vehicleDetails + ";" +
                            licensePlateNumber + ";" +
                            cost + ";" +
                            //                        clientPeselRegon + ";" +
                            clientAddress + ";" +
                            employeeID + ";" +
                            policyNotes)
                                .Replace("\n", "") + "\n";
        }
    }
}
