using System.Collections.Generic;

namespace XtraReportsDemos.CarryoverSummaryReport {
    public class Transaction {
        public string Name { set; get; }
        public int MinAmount { set; get; }
        public int MaxAmount { set; get; }

        public static List<Transaction> GetTransactions() {
            List<Transaction> transactions = new List<Transaction>();
            transactions.Add(new Transaction() { Name = "Bill – Meals & Entertainment", MinAmount = 50, MaxAmount = 150 });
            transactions.Add(new Transaction() { Name = "Bill – Office Supplies", MinAmount = 50, MaxAmount = 100 });
            transactions.Add(new Transaction() { Name = "Bill – Office Cleaning", MinAmount = 50, MaxAmount = 100 });
            transactions.Add(new Transaction() { Name = "Bill – Meals & Entertainment", MinAmount = 50, MaxAmount = 150 });
            transactions.Add(new Transaction() { Name = "Bill – Mobile Phone", MinAmount = 75, MaxAmount = 100 });
            transactions.Add(new Transaction() { Name = "Bill – Lodging", MinAmount = 500, MaxAmount = 1000 });
            transactions.Add(new Transaction() { Name = "Payment", MinAmount = -1500, MaxAmount = -300 });
            transactions.Add(new Transaction() { Name = "Bill – Printing Services", MinAmount = 50, MaxAmount = 150 });
            transactions.Add(new Transaction() { Name = "Bill – Meals & Entertainment", MinAmount = 50, MaxAmount = 150 });
            transactions.Add(new Transaction() { Name = "Bill – Office Phone", MinAmount = 50, MaxAmount = 75 });
            transactions.Add(new Transaction() { Name = "Payment", MinAmount = -1500, MaxAmount = -300 });
            transactions.Add(new Transaction() { Name = "Bill – Car Rental", MinAmount = 100, MaxAmount = 500 });
            transactions.Add(new Transaction() { Name = "Bill – Meals & Entertainment", MinAmount = 50, MaxAmount = 150 });
            transactions.Add(new Transaction() { Name = "Bill – Meals & Entertainment", MinAmount = 50, MaxAmount = 150 });
            transactions.Add(new Transaction() { Name = "Bill – Air Travel", MinAmount = 500, MaxAmount = 1000 });
            transactions.Add(new Transaction() { Name = "Bill – Print Advertising", MinAmount = 1000, MaxAmount = 2500 });
            transactions.Add(new Transaction() { Name = "Bill – Meals & Entertainment", MinAmount = 50, MaxAmount = 150 });
            transactions.Add(new Transaction() { Name = "Bill – Google AdWords", MinAmount = 500, MaxAmount = 1000 });
            transactions.Add(new Transaction() { Name = "Bill – Internet Service", MinAmount = 50, MaxAmount = 100 });
            transactions.Add(new Transaction() { Name = "Bill – Meals & Entertainment", MinAmount = 50, MaxAmount = 150 });
            transactions.Add(new Transaction() { Name = "Bill – Meals & Entertainment", MinAmount = 50, MaxAmount = 150 });
            transactions.Add(new Transaction() { Name = "Bill – Printing Services", MinAmount = 50, MaxAmount = 150 });
            transactions.Add(new Transaction() { Name = "Bill – Car Lease", MinAmount = 250, MaxAmount = 500 });
            transactions.Add(new Transaction() { Name = "Payment", MinAmount = -1500, MaxAmount = -300 });
            transactions.Add(new Transaction() { Name = "Bill – Office Supplies", MinAmount = 50, MaxAmount = 100 });
            transactions.Add(new Transaction() { Name = "Payment", MinAmount = -1500, MaxAmount = -300 });
            transactions.Add(new Transaction() { Name = "Bill – Meals & Entertainment", MinAmount = 50, MaxAmount = 150 });
            transactions.Add(new Transaction() { Name = "Bill – Air Travel", MinAmount = 500, MaxAmount = 1000 });
            transactions.Add(new Transaction() { Name = "Payment", MinAmount = -1500, MaxAmount = -300 });
            transactions.Add(new Transaction() { Name = "Bill – Meals & Entertainment", MinAmount = 50, MaxAmount = 150 });
            transactions.Add(new Transaction() { Name = "Payment", MinAmount = -1500, MaxAmount = -300 });
            transactions.Add(new Transaction() { Name = "Bill – Meals & Entertainment", MinAmount = 50, MaxAmount = 150 });
            transactions.Add(new Transaction() { Name = "Bill – Meals & Entertainment", MinAmount = 50, MaxAmount = 150 });
            transactions.Add(new Transaction() { Name = "Bill – Printing Services", MinAmount = 50, MaxAmount = 150 });
            transactions.Add(new Transaction() { Name = "Bill – Liability Insurance", MinAmount = 25, MaxAmount = 75 });
            transactions.Add(new Transaction() { Name = "Payment", MinAmount = -1500, MaxAmount = -300 });
            transactions.Add(new Transaction() { Name = "Bill – Air Travel", MinAmount = 500, MaxAmount = 1000 });
            transactions.Add(new Transaction() { Name = "Bill – Meals & Entertainment", MinAmount = 50, MaxAmount = 150 });
            transactions.Add(new Transaction() { Name = "Bill – Office Cleaning", MinAmount = 50, MaxAmount = 100 });
            transactions.Add(new Transaction() { Name = "Bill – Meals & Entertainment", MinAmount = 50, MaxAmount = 150 });
            transactions.Add(new Transaction() { Name = "Bill – Google AdWords", MinAmount = 500, MaxAmount = 1000 });
            transactions.Add(new Transaction() { Name = "Bill – E&O Insurance", MinAmount = 25, MaxAmount = 50 });
            transactions.Add(new Transaction() { Name = "Bill – Meals & Entertainment", MinAmount = 50, MaxAmount = 150 });
            transactions.Add(new Transaction() { Name = "Payment", MinAmount = -1500, MaxAmount = -300 });
            transactions.Add(new Transaction() { Name = "Bill – Office Supplies", MinAmount = 50, MaxAmount = 100 });
            transactions.Add(new Transaction() { Name = "Bill – Meals & Entertainment", MinAmount = 50, MaxAmount = 150 });
            transactions.Add(new Transaction() { Name = "Bill – Air Travel", MinAmount = 500, MaxAmount = 1000 });
            transactions.Add(new Transaction() { Name = "Bill – Meals & Entertainment", MinAmount = 50, MaxAmount = 150 });
            transactions.Add(new Transaction() { Name = "Bill – Office Cleaning", MinAmount = 50, MaxAmount = 100 });
            transactions.Add(new Transaction() { Name = "Bill – Printing Services", MinAmount = 50, MaxAmount = 150 });
            return transactions;
        }
    }
}
