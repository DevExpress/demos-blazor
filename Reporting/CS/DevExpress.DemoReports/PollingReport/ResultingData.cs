using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.DataAccess.Excel;
using DevExpress.XtraPrinting;


namespace XtraReportsDemos.PollingReport {
    public class ResultingData {
        public int QuestionID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int AnswerCount { get; set; }

    }
    class ResultingDataAdapter {
        readonly ExcelDataSource dataSource;

        public ResultingDataAdapter(ExcelDataSource dataSource) {
            this.dataSource = dataSource;
        }
        public void InitializeData(IList<ResultingData> data) {
            data.Add(CreateResultingData(0, GetAnswer(0), 1));
            data.Add(CreateResultingData(1, GetAnswer(1), 2));
            data.Add(CreateResultingData(4, GetAnswer(4), 2));
            data.Add(CreateResultingData(5, GetAnswer(5), 1));
            data.Add(CreateResultingData(9, "NBC", 1));
            data.Add(CreateResultingData(9, "HBO", 2));
            data.Add(CreateResultingData(10, "2", 2));
            data.Add(CreateResultingData(10, "3", 1));
            data.Add(CreateResultingData(11, GetAnswer(11), 1));
            data.Add(CreateResultingData(12, GetAnswer(12), 2));
        }
        public IList<ResultingData> GetData(IList<EditingField> EditingFields) {
            List<ResultingData> data = new List<ResultingData>();

            for(int i = 0; i < EditingFields.Count; i++) {
                EditingField field = EditingFields[i];
                int rowIndex = Convert.ToInt32(field.ID) - 1;

                if(field.EditValue is CheckBoxState) {
                    if(Equals(field.Brick.Value, "RadioText"))
                        continue;
                    CheckBoxState state = field.GetEditValue<CheckBoxState>();
                    ResultingData item = CreateResultingData(rowIndex, GetAnswer(rowIndex), state == CheckBoxState.Checked ? 1 : 0);
                    data.Add(item);
                }
                else if(field.EditValue is string && !field.ReadOnly && !string.IsNullOrWhiteSpace(field.GetEditValue<string>())) {
                    ResultingData item = CreateResultingData(rowIndex, field.GetEditValue<string>(), 1);
                    data.Add(item);
                }
            }
            return data;
        }
        string GetAnswer(int rowIndex) {
            return GetColumnValue<string>(rowIndex, "Answer");
        }
        ResultingData CreateResultingData(int rowIndex, string answer, int answerCount) {
            int questionID = GetColumnValue<int>(rowIndex, "QuestionID");
            return new ResultingData() { Question = GetColumnValue<string>(rowIndex, "Question"), QuestionID = questionID, Answer = answer, AnswerCount = answerCount };
        }
        T GetColumnValue<T>(int rowIndex, string columnName) {
            IList list = ((IListSource)dataSource).GetList();
            object row = list[rowIndex];

            DevExpress.DataAccess.Native.Excel.ViewColumn column = GetColumn(columnName);
            if(column != null) {
                return (T)column.GetValue(row);
            }
            return default(T);
        }
        DevExpress.DataAccess.Native.Excel.ViewColumn GetColumn(string name) {
            DevExpress.DataAccess.Native.Excel.DataView dv = ((IListSource)dataSource).GetList() as DevExpress.DataAccess.Native.Excel.DataView;
            for(int i = 0; i < dataSource.Schema.Count; i++) {
                if(dataSource.Schema[i].Name == name)
                    return dv.Columns[i];
            }
            return null;
        }
    }
}
