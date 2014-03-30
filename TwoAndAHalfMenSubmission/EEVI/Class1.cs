using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;

namespace speechRec
{
    public class Class1
    {
        private Cluster myCluster;

        private Session mySession;
        public string[] myArr = new string[8];

       

        public void Connect(String node)
        {
            myCluster = Cluster.Builder()
                .AddContactPoint(node).Build();
            mySession = myCluster.Connect();
            Metadata metadata = myCluster.Metadata;

            Console.WriteLine("Connected to cluster: " + metadata.ClusterName.ToString());
            foreach (Host myHost in metadata.AllHosts())
            {
                Console.WriteLine("Host: " + myHost.Address);
            }
        }

        public void Close()
        {
            myCluster.Shutdown();
        }

        public void CreateSchema()
        {
            mySession.Execute("CREATE KEYSPACE IF NOT EXISTS hr WITH replication" +
                "= {'class':'SimpleStrategy', 'replication_factor':1};");

            mySession.Execute("CREATE TABLE IF NOT EXISTS hr.users(" +
                 "id int primary key, " +
                  "fName varchar, " +
                  "lName varchar, " +
                  "accessType varchar," +
                  "password varchar);");

            mySession.Execute("CREATE TABLE IF NOT EXISTS hr.building(" +
                "id int primary key, " +
               "buildName varchar, " +
               "sensor int, " +
               "location varchar, " +
               "info1 text, " +
               "info2 text, " +
               "info3 text, " +
               "info4 text);");
        }

        public void LoadData()
        {
            mySession.Execute("INSERT into hr.users " +
                "(id, fName, lName, accessType, password) VALUES (1,'Graeme', 'Brown', 'admin', 'passAdmin')");

            mySession.Execute("INSERT into hr.users " +
                 "(id, fName, lName, accessType, password) VALUES (2, 'Mhairi', 'Taylor', 'admin', 'passAdmin')");

            mySession.Execute("INSERT into hr.users " +
                  "(id, fName, lName, accessType, password) VALUES (3, 'Joel', 'Robinson', 'admin', 'passAdmin')");

            mySession.Execute("INSERT into hr.users " +
                "(id, fName, lName, accessType, password) VALUES (4, 'John', 'Doe', 'user', 'passUser')");

            mySession.Execute("INSERT into hr.building " +
                "(id, buildName, sensor, location, info1, info2, info3, info4)" +
                "VALUES(" +
                "1, 'QMB', 1, 'Front Entrance.'," +
                " 'You are in the entrance of the Queen Mother Building.', " +
                "'To the left is a set of automatic double doors leading to the computing labs 0 1 and 2.'," +
                "'Straight ahead are the stairs that lead to the upper floors of the building.'," +
                "'To the right is a set of automatic double doors that lead to the street area, where you can find a lift to access the upper floors of the building.')" + ";");

            mySession.Execute("INSERT into hr.building " +
                "(id, buildName, sensor, location, info1, info2, info3, info4)" +
                "VALUES(" +
                "2, 'QMB', 2, 'User Centre'," +
                " 'You are in the User Centre of the Queen Mother Building.', " +
                "'Straight ahead is the lift to the upper floors.'," +
                "'Straight ahead is the street and access to toilets. The street is an area where students can display their projects.'," +
                "'To the right is a pod that contains several computers and is used as a learning zone.')" + ";");

            mySession.Execute("INSERT into hr.building " +
                "(id, buildName, sensor, location, info1, info2, info3, info4)" +
                "VALUES(" +
                "3, 'QMB', 3, 'Floor 1 Lift Vestibule'," +
                " 'You are at the first floor lift area.', " +
                "'To the left is a door that leads to the offices of Andy Cobley and various other staff members.'," +
                "'On the wall straight ahead is a button to open the automatic doors that are located on the right. '," +
                "'These doors will lead you to another set of button operated doors. After these doors lie the pods on the first floor.')" + ";");
        }

        public void printUsers()
        {
            RowSet results = mySession.Execute("Select * from hr.users");

            Console.WriteLine(String.Format("{0,-3}\n{1,-10}\n{2,-10}\n{3,-10}\n{4,-10}\n", "id", "fname", "lname", "accesstype", "password"));

            foreach (Row row in results.GetRows())
            {
                Console.WriteLine(String.Format("{0,-3}\n{1,-10}\n{2,-10}\n{3,-10}\n{4,-10}\n\n",
                     row.GetValue<int>("id"),
                     row.GetValue<String>("fname"),
                     row.GetValue<String>("lname"),
                     row.GetValue<String>("accesstype"),
                     row.GetValue<String>("password")));

            }


        }

        public void printBuilding()
        {
            RowSet results = mySession.Execute("Select * from hr.building");

            Console.WriteLine(String.Format("{0,-3}\n{1,-10}\n{2,-10}\n{3,-10}\n{4,-10}\n", "id", "fname", "lname", "accesstype", "password"));

            foreach (Row row in results.GetRows())
            {
                Console.WriteLine(String.Format("{0,-3}\n{1,-10}\n{2,-10}\n{3,-10}\n{4,-10}\n{5,-10}\n{6,-10}\n{7,-10}\n\n",
                     row.GetValue<int>("id"),
                     row.GetValue<String>("buildname"),
                     row.GetValue<int>("sensor"),
                     row.GetValue<String>("location"),
                     row.GetValue<String>("info1"),
                     row.GetValue<String>("info2"),
                     row.GetValue<String>("info3"),
                     row.GetValue<String>("info4")));

            }

        }

        public void printBuilding2(int num)
        {
            RowSet results = mySession.Execute("Select * from hr.building where id="+num);

            Console.WriteLine(String.Format("{0,-3}\n{1,-10}\n{2,-10}\n{3,-10}\n{4,-10}\n", "id", "fname", "lname", "accesstype", "password"));

           // string[] arr = new string[8];
            int i = 0;

            foreach (Row row in results.GetRows())
            {
                

                //Console.WriteLine(String.Format("{0,-3}\n{1,-10}\n{2,-10}\n{3,-10}\n{4,-10}\n{5,-10}\n{6,-10}\n{7,-10}\n\n",
                 myArr[0] = Convert.ToString(row.GetValue<int>("id"));
                 myArr[1] = row.GetValue<String>("buildname");
                 myArr[2] = Convert.ToString(row.GetValue<int>("sensor"));
                 myArr[3] = row.GetValue<String>("location");
                 myArr[4] = row.GetValue<String>("info1");
                 myArr[5] = row.GetValue<String>("info2");
                 myArr[6] = row.GetValue<String>("info3");
                 myArr[7] = row.GetValue<String>("info4");

            }

            
            Console.WriteLine("--------- ARRAY TEST------------");
            for (i = 0; i < 8; i++)
            {
                Console.WriteLine(myArr[i]);
                
            }
         


        }

    }
    }


