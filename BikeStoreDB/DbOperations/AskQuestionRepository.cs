using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeStoreModels;

namespace BikeStoreDB.DbOperations
{
    public class AskQuestionRepository
    {
        BikeStores_2Entities db = new BikeStores_2Entities();
        public int AddQuestion(ask_qustionModel x)
        {
            var result = new ask_qustion()
            {
                qus_text = x.qus_text,
                c_email = x.c_email,
                p_id = x.p_id,
                date = x.date
            };
            db.ask_qustion.Add(result);
            db.SaveChanges();
            return result.qus_id;
        }
        public List<ask_qustionModel> GetAllQustions()
        {
            
            var result = db.ask_qustion.Select(x => new ask_qustionModel()
            {
                qus_text = x.qus_text,
                c_email = x.c_email,
                p_id = x.p_id,
                date = x.date
                
            }).ToList();
            return result;
        }
    }
}
