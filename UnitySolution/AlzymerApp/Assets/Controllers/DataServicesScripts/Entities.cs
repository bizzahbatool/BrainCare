using System;

namespace UnityApp
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public string Auth { get; set; }

        public override string ToString()
        {
            return string.Format(@"User Name : {0} \nPassword : {1}\nEmail : {2}",
                UserName,Password,EMail);
        }
    }

    public class LocationMMSE
    {
        public string Country { get; set; }
        public string City { get; set; }
        public TimeSpan Time { get; set; }

        public override string ToString()
        {
            return string.Format(@"Country : {0} \City : {1}\Time : {2}",
                Country, City, Time);
        }
    }

    public class NumberOnClock
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public bool Correct { get; set; }
        public TimeSpan TimeToComplete { get; set; }
        public int IncorrectItems { get; set; }
    }
    public class AnimalRecognize
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public bool Correct { get; set; }
        public TimeSpan TimeToComplete { get; set; }
        public string OriginalAnimalName { get; set; }
        public string OptionAnimalName { get; set; }
    }
    public class RecallImages
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public TimeSpan TimeToComplete { get; set; }
    }

    public class SerialSeven
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int CorrectList { get; set; }
        public int InCorrectList { get; set; }
        public TimeSpan TimeToComplete { get; set; }
    }

    public class CompleteSentence
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string SentenceByUser { get; set; }
        public string OriginalSentence { get; set; }
        public bool Correct { get; set; }
        public TimeSpan TimeToComplete { get; set; }
    }

    public class NameObject
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NameOfObject { get; set; }
        public string SelectedNameOfObject { get; set; }
        public bool Correct { get; set; }
        public int ScreenNumber { get; set; }
        public TimeSpan TimeToComplete { get; set; }
    }

    public class ConnectDots
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int CorrectClicks { get; set; }
        public int WrongClikcs { get; set; }
        public TimeSpan TimeToComplete { get; set; }
    }
    public class ClockArams
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public TimeSpan TimeToComplete { get; set; }
    }

    public class RecognizeAnimal
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public bool Correct { get; set; }
        public string Animal { get; set; }
        public string SelectedAnimal { get; set; }
        public TimeSpan TimeToComplete { get; set; }
    }
    public class UserSession
    {
        [PrimaryKey,AutoIncrement]
        public int SessionId { get; set; }
        public string UserName { get; set; }
        public int MocaScreen { get; set; }
        public int MMSEScreen { get; set; }
        

    }
}