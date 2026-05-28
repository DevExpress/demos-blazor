using System;
using System.Collections.Generic;
using System.ComponentModel;
using XtraReportsDemos.CachedDocumentSourceReport;

namespace XtraReportsDemos.CarryoverSummaryReport {
    public class DataItem {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public DateTime BillingDate { get; set; }
        public DateTime BillingPeriodStart { get; set; }
        public DateTime BillingPeriodEnd { get; set; }
        public Adjustment[] Adjustments { get; set; }

        public DataItem(int i) {
            DeterministicRandom rnd = new DeterministicRandom(i);
            Customer c = rnd.GetRandomItem(Customer.Customers);
            CustomerID = c.CustomerID;
            ContactName = c.ContactName;
            ContactTitle = c.ContactTitle;
            BillingPeriodStart = rnd.RandomTime();
            BillingPeriodEnd = rnd.RandomTime(BillingPeriodStart, 20 * 24, 30 * 24);
            BillingDate = rnd.RandomTime(BillingPeriodEnd, 20 * 24, 30 * 24);

            int adjustmentsCount = rnd.Random(40, 50);
            Adjustments = new Adjustment[adjustmentsCount];
            int h = (int)((BillingPeriodEnd - BillingPeriodStart).TotalHours / adjustmentsCount);

            Adjustments[0] = Adjustment.CreateBalanceForward(rnd.RandomTime(BillingPeriodStart, 0, h), rnd.Random(10000));
            List<Transaction> transactions = Transaction.GetTransactions();

            for(int j = 1; j < Adjustments.Length; j++) {
                DateTime nextDate = rnd.RandomTime(BillingPeriodStart.AddHours(h * j), 0, h);
                Adjustments[j] = Adjustment.CreateAdjustment(nextDate, transactions[j - 1], rnd.Random(10000));
            }
        }
    }

    [DisplayName("Carryover Summary Report Data Source")]
    public class DataSource {
        public static List<DataItem> GetData() {
            return new List<DataItem>() {
                new DataItem(0)
            };
        }
    }
}
