using UnityEngine;
using System;
using System.IO;
using System.Collections.Generic;
namespace UnityApp
{
    public class DataService
    {

        private SQLiteConnection _connection;

        public DataService(string DatabaseName,bool variable)
        {

#if UNITY_EDITOR
            var dbPath = string.Format(@"Assets/{0}", DatabaseName);
#else
            // check if file exists in Application.persistentDataPath
            var filepath = string.Format("{0}/{1}", Application.persistentDataPath, DatabaseName);

            if (!File.Exists(filepath))
            {
                Debug.Log("Database not in Persistent path");
                // if it doesn't ->
                // open StreamingAssets directory and load the db ->

#if UNITY_ANDROID
            var loadDb = new WWW("jar:file://" + Application.dataPath + "!/assets/" + DatabaseName);  // this is the path to your StreamingAssets in android
            while (!loadDb.isDone) { }  // CAREFUL here, for safety reasons you shouldn't let this while loop unattended, place a timer and error check
            // then save to Application.persistentDataPath
            File.WriteAllBytes(filepath, loadDb.bytes);
#elif UNITY_IOS
                 var loadDb = Application.dataPath + "/Raw/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
                // then save to Application.persistentDataPath
                File.Copy(loadDb, filepath);
#elif UNITY_WP8
                var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
                // then save to Application.persistentDataPath
                File.Copy(loadDb, filepath);

#elif UNITY_WINRT
		var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
		// then save to Application.persistentDataPath
		File.Copy(loadDb, filepath);
#else
                var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
                                                                                         // then save to Application.persistentDataPath
                File.Copy(loadDb, filepath);

#endif

                Debug.Log("Database written");
            }

            var dbPath = filepath;
#endif
            _connection = new SQLiteConnection(dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create);
            CreateDB();
            Debug.Log("Final PATH: " + dbPath);

        }
        public DataService(string DatabaseName)
        {
#if UNITY_EDITOR
            var dbPath = string.Format(@"Assets/{0}", DatabaseName);
#else
            // check if file exists in Application.persistentDataPath
            var filepath = string.Format("{0}/{1}", Application.persistentDataPath, DatabaseName);

            if (!File.Exists(filepath))
            {
                Debug.Log("Database not in Persistent path");
                // if it doesn't ->
                // open StreamingAssets directory and load the db ->

#if UNITY_ANDROID
            var loadDb = new WWW("jar:file://" + Application.dataPath + "!/assets/" + DatabaseName);  // this is the path to your StreamingAssets in android
            while (!loadDb.isDone) { }  // CAREFUL here, for safety reasons you shouldn't let this while loop unattended, place a timer and error check
            // then save to Application.persistentDataPath
            File.WriteAllBytes(filepath, loadDb.bytes);
#elif UNITY_IOS
                 var loadDb = Application.dataPath + "/Raw/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
                // then save to Application.persistentDataPath
                File.Copy(loadDb, filepath);
#elif UNITY_WP8
                var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
                // then save to Application.persistentDataPath
                File.Copy(loadDb, filepath);

#elif UNITY_WINRT
		var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
		// then save to Application.persistentDataPath
		File.Copy(loadDb, filepath);
#else
                var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
                                                                                         // then save to Application.persistentDataPath
                File.Copy(loadDb, filepath);

#endif

                Debug.Log("Database written");
            }

            var dbPath = filepath;
#endif
            _connection = new SQLiteConnection(dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create);
            Debug.Log("Final PATH: " + dbPath);
        }
        private void CreateDB()
        {
            //_connection.DropTable<User>();
            //_connection.DropTable<LocationMMSE>();
            //_connection.DropTable<NumberOnClock>();
            //_connection.DropTable<AnimalRecognize>();
            //_connection.DropTable<RecallImages>();
            //_connection.DropTable<SerialSeven>();
            //_connection.DropTable<CompleteSentence>();
            //_connection.DropTable<NameObject>();
            //_connection.DropTable<ConnectDots>();
            //_connection.DropTable<ClockArams>();
            _connection.DropTable<UserSession>();

            _connection.CreateTable<User>();
            _connection.CreateTable<LocationMMSE>();
            _connection.CreateTable<NumberOnClock>();
            _connection.CreateTable<AnimalRecognize>();
            _connection.CreateTable<RecallImages>();
            _connection.CreateTable<SerialSeven>();
            _connection.CreateTable<CompleteSentence>();
            _connection.CreateTable<NameObject>();
            _connection.CreateTable<ConnectDots>();
            _connection.CreateTable<ClockArams>();
            _connection.CreateTable<UserSession>();
        }

        public IEnumerable<User> GetUsers()
        {
            return _connection.Table<User>();
        }

        public User GetUser(string userName, string password)
        {
            return _connection.Table<User>().Where(
                x => x.UserName == userName &&
                x.Password == password).FirstOrDefault();
        }

        public User CreateDemoUser()
        {
            var user = new User
            {
                Id = 1,
                UserName = @"User",
                Password = @"pass",
                EMail = @"user@email.com",
                Auth = null
            };
            _connection.Insert(user);
            return user;
        }
        public UserSession CreateSession(string userName)
        {
            var session = new UserSession
            {
                MMSEScreen = 0,
                MocaScreen = 0,
                UserName = userName
            };
            _connection.Insert(session);
            return session;
        }
        public UserSession GetSession()
        {
            var userSession = _connection.Table<UserSession>().FirstOrDefault();
            return userSession;
        }
        public UserSession UpdateSession(int mocaScreen = 0,int mmseScreen = 0)
        {
            var userSession = GetSession();
            if (mocaScreen != 0)
                userSession.MocaScreen = mocaScreen;
            if (mmseScreen != 0)
                userSession.MocaScreen = mmseScreen;
            _connection.Update(userSession);
            return userSession;
        }
        public LocationMMSE CreateLocationMMSE(LocationMMSE model)
        {
            _connection.Insert(model);
            return model;
        }
        public RecallImages CreateRecallImagesMMSE(RecallImages model)
        {
            _connection.Insert(model);
            return model;
        }
        public SerialSeven CreateSerialSevenMMSE(SerialSeven model)
        {
            _connection.Insert(model);
            return model;
        }
        public CompleteSentence CreateCompleteSentenceMMSE(CompleteSentence model)
        {
            _connection.Insert(model);
            return model;
        }

        public NameObject CreateNameObjectMMSE(NameObject model)
        {
            _connection.Insert(model);
            return model;
        }
        public ConnectDots CreateConnectDotsMoca(ConnectDots model)
        {
            _connection.Insert(model);
            return model;
        }
        public NumberOnClock CreateNumberOnClock(NumberOnClock model)
        {
            _connection.Insert(model);
            return model;
        }

        public ClockArams CreateClockArams(ClockArams model)
        {
            _connection.Insert(model);
            return model;
        }

        public AnimalRecognize CreateAnimalRecognize(AnimalRecognize model)
        {
            _connection.Insert(model);
            return model;
        }
    }

}