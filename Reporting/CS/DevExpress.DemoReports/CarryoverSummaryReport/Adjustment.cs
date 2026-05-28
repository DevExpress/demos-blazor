using System;
using XtraReportsDemos.CachedDocumentSourceReport;

namespace XtraReportsDemos.CarryoverSummaryReport {
    public class Adjustment {
        public static Adjustment CreateBalanceForward(DateTime dt, int random) {
            DeterministicRandom rnd = new DeterministicRandom(random);
            Adjustment res = new Adjustment();
            res.Date = dt;
            res.Description = "Balance Forward";
            res.Amount = rnd.Random(10, 300) * 10;
            return res;
        }
        public static Adjustment CreateAdjustment(DateTime dt, Transaction transaction, int random) {
            DeterministicRandom rnd = new DeterministicRandom(random);
            Adjustment res = new Adjustment();
            res.Date = dt;
            res.Description = transaction.Name;
            res.Amount = rnd.Random(transaction.MinAmount, transaction.MaxAmount);
            return res;
        }

        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }

        public Adjustment() {
        }
    }
}
