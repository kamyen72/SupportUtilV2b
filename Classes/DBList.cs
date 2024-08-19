namespace DupRecRemoval.Classes
{
    public class DBList
    {
       public List<db> dbs {  get; set; }

        public DBList() { 
            dbs = new List<db>();
            db db = new db();
            db.connStr = db_ace99.connStr;
            db.ip = db_ace99.ip;
            db.userId = db_ace99.userId;
            db.password = db_ace99.password;
            db.dbfullname = db_ace99.dbfullname;
            db.MyID = db_ace99.MyID;
            dbs.Add(db);

            db = new db();
            db.connStr = db_king4d.connStr;
            db.ip = db_king4d.ip;
            db.userId = db_king4d.userId;
            db.password = db_king4d.password;
            db.dbfullname = db_king4d.dbfullname;
            db.MyID = db_king4d.MyID;
            dbs.Add(db);

            db = new db();
            db.connStr = db_bv.connStr;
            db.ip = db_bv.ip;
            db.userId = db_bv.userId;
            db.password = db_bv.password;
            db.dbfullname = db_bv.dbfullname;
            db.MyID=db_bv.MyID;
            dbs.Add(db);

            db = new db();
            db.connStr = db_wl.connStr;
            db.ip = db_wl.ip;
            db.userId = db_wl.userId;
            db.password = db_wl.password;
            db.dbfullname = db_wl.dbfullname;
            db.MyID= db_wl.MyID;
            dbs.Add(db);

            //db = new db();
            //db.connStr = db_ghl33.connStr;
            //db.ip = db_ghl33.ip;
            //db.userId = db_ghl33.userId;
            //db.password = db_ghl33.password;
            //db.dbfullname = db_ghl33.dbfullname;
            //dbs.Add(db);

            db = new db();
            db.connStr = db_ghl55.connStr;
            db.ip = db_ghl55.ip;
            db.userId = db_ghl55.userId;
            db.password = db_ghl55.password;
            db.dbfullname = db_ghl55.dbfullname;
            db.MyID = db_ghl55.MyID;
            dbs.Add(db);

            //db = new db();
            //db.connStr = db_master.connStr;
            //db.ip = db_master.ip;
            //db.userId = db_master.userId;
            //db.password = db_master.password;
            //db.dbfullname = db_master.dbfullname;
            //dbs.Add(db);

            db = new db();
            db.connStr = db_tm.connStr;
            db.ip = db_tm.ip;
            db.userId = db_tm.userId;
            db.password = db_tm.password;
            db.dbfullname = db_tm.dbfullname;
            db.MyID=db_tm.MyID;
            dbs.Add(db);

            db = new db();
            db.connStr = db_tm2.connStr;
            db.ip = db_tm2.ip;
            db.userId = db_tm2.userId;
            db.password = db_tm2.password;
            db.dbfullname = db_tm2.dbfullname;
            db.MyID= db_tm2.MyID;
            dbs.Add(db);

            //remarked for Imran testing

            db = new db();
            db.connStr = db_local.connStr;
            db.ip = db_local.ip;
            db.userId = db_local.userId;
            db.password = db_local.password;
            db.dbfullname = db_local.dbfullname;
            db.MyID = db_local.MyID;
            dbs.Add(db);

            db = new db();
            db.connStr = db_GhlStaging.connStr;
            db.ip = db_GhlStaging.ip;
            db.userId = db_GhlStaging.userId;
            db.password = db_GhlStaging.password;
            db.dbfullname = db_GhlStaging.dbfullname;
            db.MyID=db_GhlStaging.MyID;
            dbs.Add(db);

        }
    }
}
