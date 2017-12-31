//the foloowing cass would set the data of the GetInfo Scene to Database
//information that is sent to database include: usrname, age, and email

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using UnityEngine.UI;



public class User {
	public string username;
	public int age;
	public string userID;
	public string email;

	//the rest of the database set to null
	public bool MathParent;
//		public bool MathLearn = false;	
//			public bool MLearnLevel1 = false;
//			public bool MLearnLevel2 = false;
//			public bool MLearnLevel3 = false;
//		public bool MathQuiz = false;
//			public bool QuizLevel1 = false;	//level1 QUIZ
//				public int Quiz1Score = 0;
//			public bool QuizLevel2 = false;	//level2 QUIZ
//				public int Quiz2Score = 0;
//			public bool QuizLevel3 = false;	//level3 QUIZ
//				public int Quiz3Score = 0;
//			public bool QuizLevel4 = false;	//level4 QUIZ - this is the adaptive level
//				public int Quiz4Score = 0;

	public bool ShapesParent;
//		public bool ShapesLearn = false;
//			public bool SLearnLevel1 = false;
//			public bool SlearnLevel2 = false;
//			public bool SlearnLevel3 = false;
//		public bool ShapesQuiz = false;
//			public bool QuizSquare = false;
//				public int QuizSquareScore = 0;
//			public bool QuizTriangle = false;
//				public int QuizTriangleScore = 0;
//			public bool QuizCircle = false;
//				public int QuizCircleScore = 0;



	public User() {
	}

	public User(string userID, string username, int age, string email) {
		this.userID = userID;
		this.username = username;
		this.age = age;
		this.email = email;
	}
}

public class MathLearn{
	public bool MLearnLevel1;
	public bool MLearnLevel2;
	public bool MLearnLevel3;
	public MathLearn(){
		MLearnLevel1 = false;
		MLearnLevel2 = false;
		MLearnLevel3 = false;	
	}
}

public class MathQuizLevel1{
	public bool Quiz1Completed;
	public int Quiz1Score;
	public MathQuizLevel1(){
		Quiz1Completed = false;
		Quiz1Score = 0;
	}
}
public class MathQuizLevel2{
	public bool Quiz2Completed;
	public int Quiz2Score;
	public MathQuizLevel2(){
		Quiz2Completed = false;
		Quiz2Score = 0;
	}
}
public class MathQuizLevel3{
	public bool Quiz3Completed;
	public int Quiz3Score;
	public MathQuizLevel3(){
		Quiz3Completed = false;
		Quiz3Score = 0;
	}
}
public class MathQuizLevel4{	//this is adaptive level
	public bool Quiz4Completed;
	public int Quiz4Score;
	public MathQuizLevel4(){
		Quiz4Completed = false;
		Quiz4Score = 0;
	}
}

public class ShapesLearn{
	public bool SLearnLevel1;
	public bool SLearnLevel2;
	public bool SLearnLevel3;
	public ShapesLearn(){
		SLearnLevel1 = false;
		SLearnLevel2 = false;
		SLearnLevel3 = false;
	}
}
	
public class QuizSquare{
	public  bool QuizSquareCompleted;
	public int QuizSquareScore;
	public QuizSquare(){
		QuizSquareCompleted = false;
		QuizSquareScore = 0;
	}
}
public class QuizTriangle{
	public  bool QuizTriangleCompleted;
	public int QuizTriangleScore;
	public QuizTriangle(){
		QuizTriangleCompleted = false;
		QuizTriangleScore = 0;
	}
}
public class QuizCircle{
	public  bool QuizCircleCompleted;
	public int QuizCircleScore;
	public QuizCircle(){
		QuizCircleCompleted = false;
		QuizCircleScore = 0;
	}
}




//public class LeaderboardEntry {
//	public string uid;
//	public int score = 0;
//
//	public LeaderboardEntry() {
//	}
//
//	public LeaderboardEntry(string uid, int score) {
//		this.uid = uid;
//		this.score = score;
//	}
//
//	public Dictionary<string, Object> ToDictionary() {
//		Dictionary<string, Object> result = new Dictionary<string, Object>();
//		result["uid"] = uid;
//		result["score"] = score;
//
//		return result;
//	}
//}





/// 
/// ///
/// 
public class setData : MonoBehaviour {

//	private string username;
//	private int age;
//	private string email;

	string myuid;
	string myemail;

	[SerializeField]
	private Text UIUsername = null;
	[SerializeField]
	private Text UIAge = null;
	public Text ErrorText;

//			public bool MathLearn;	
//				public bool MLearnLevel1 = false;
//				public bool MLearnLevel2 = false;
//				public bool MLearnLevel3 = false;
//			public bool MathQuiz;
//				public bool QuizLevel1;	//level1 QUIZ
//					public int Quiz1Score = 0;
//				public bool QuizLevel2 = false;	//level2 QUIZ
//					public int Quiz2Score = 0;
//				public bool QuizLevel3 = false;	//level3 QUIZ
//					public int Quiz3Score = 0;
//				public bool QuizLevel4 = false;	//level4 QUIZ - this is the adaptive level
//					public int Quiz4Score = 0;




	// Use this for initialization
	public void saveData() {
		//change age to type int and put at intUIAge
		int intUIAge;
		int.TryParse(UIAge.text, out intUIAge);
		writeNewUser(UIUsername.text, intUIAge);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void writeNewUser(string username1, int age1) {
		// Set up the Editor before calling into the realtime database.

		FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://gradproject-861f8.firebaseio.com/");

		// Get the root reference location of the database.
		DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;

		Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
		Firebase.Auth.FirebaseUser user = auth.CurrentUser;
		if (user != null) {
			myuid = user.UserId;
			myemail = user.Email;
//			System.Uri photo_url = user.PhotoUrl;
		}


		User NewUser1 = new User(myuid, username1, age1, myemail);
		string json = JsonUtility.ToJson(NewUser1);
		reference.Child("users").Child(myuid).SetRawJsonValueAsync(json);
		UpdateErrorMessage("data is saved to the database!");

//		reference.Child("users").Child(myuid).Child("MathParent").SetValueAsync(MathLearn);

		MathLearn MathLearn1 = new MathLearn();
		string json1 = JsonUtility.ToJson(MathLearn1);
		reference.Child("users").Child(myuid).Child("MathParent").Child("MathLearn").SetRawJsonValueAsync(json1);

		MathQuizLevel1 myMathQuizLevel1 = new MathQuizLevel1();
		string json2 = JsonUtility.ToJson(myMathQuizLevel1);
		reference.Child("users").Child(myuid).Child("MathParent").Child("MathQuiz").Child("MQuizLevel1").SetRawJsonValueAsync(json2);

		MathQuizLevel2 myMathQuizLevel2 = new MathQuizLevel2();
		string json3 = JsonUtility.ToJson(myMathQuizLevel2);
		reference.Child("users").Child(myuid).Child("MathParent").Child("MathQuiz").Child("MQuizLevel2").SetRawJsonValueAsync(json3);

		MathQuizLevel3 myMathQuizLevel3 = new MathQuizLevel3();
		string json4 = JsonUtility.ToJson(myMathQuizLevel3);
		reference.Child("users").Child(myuid).Child("MathParent").Child("MathQuiz").Child("MQuizLevel3").SetRawJsonValueAsync(json4);

		MathQuizLevel4 myMathQuizLevel4 = new MathQuizLevel4();
		string json5 = JsonUtility.ToJson(myMathQuizLevel4);
		reference.Child("users").Child(myuid).Child("MathParent").Child("MathQuiz").Child("MQuizLevel4").SetRawJsonValueAsync(json5);


		//
		ShapesLearn myShapesLearn = new ShapesLearn();
		string json6 = JsonUtility.ToJson(myShapesLearn);
		reference.Child("users").Child(myuid).Child("ShapesParent").Child("ShapesLearn").SetRawJsonValueAsync(json6);


		QuizSquare myQuizSquare = new QuizSquare();
		string json7 = JsonUtility.ToJson(myQuizSquare);
		reference.Child("users").Child(myuid).Child("ShapesParent").Child("ShapesQuiz").Child("QuizSquare").SetRawJsonValueAsync(json7);

		QuizTriangle myQuizTriangle = new QuizTriangle();
		string json8 = JsonUtility.ToJson(myQuizTriangle);
		reference.Child("users").Child(myuid).Child("ShapesParent").Child("ShapesQuiz").Child("QuizTriangle").SetRawJsonValueAsync(json8);

		QuizCircle myQuizCircle = new QuizCircle();
		string json9 = JsonUtility.ToJson(myQuizCircle);
		reference.Child("users").Child(myuid).Child("ShapesParent").Child("ShapesQuiz").Child("QuizCircle").SetRawJsonValueAsync(json9);







//		reference.Child("users").Child(myuid).Child("MathParent").SetValueAsync(MathLearn);
//			reference.Child("users").Child(myuid).Child("MathParent").Child("MathLearn").SetValueAsync(MLearnLevel1);
//			reference.Child("users").Child(myuid).Child("MathParent").Child("MathLearn").SetValueAsync(MLearnLevel2);
//			reference.Child("users").Child(myuid).Child("MathParent").Child("MathLearn").SetValueAsync(MLearnLevel3);
//		reference.Child("users").Child(myuid).Child("MathParent").SetValueAsync(MathQuiz);
//			reference.Child("users").Child(myuid).Child("MathParent").Child("MathQuiz").SetValueAsync(QuizLevel1);
//				reference.Child("users").Child(myuid).Child("MathParent").Child("MathQuiz").Child("QuizLevel1").SetValueAsync(Quiz1Score);
//			reference.Child("users").Child(myuid).Child("MathParent").Child("MathQuiz").SetValueAsync(QuizLevel2);
//				reference.Child("users").Child(myuid).Child("MathParent").Child("MathQuiz").Child("QuizLevel2").SetValueAsync(Quiz2Score);
//			reference.Child("users").Child(myuid).Child("MathParent").Child("MathQuiz").SetValueAsync(QuizLevel3);
//				reference.Child("users").Child(myuid).Child("MathParent").Child("MathQuiz").Child("QuizLevel3").SetValueAsync(Quiz3Score);



				





	}
	private void UpdateErrorMessage(string message)
	{
		ErrorText.text = message;
		Invoke("ClearErrorMessage", 3);
	}

	void ClearErrorMessage()
	{
		ErrorText.text = "";
	}

//	private void WriteNewScore(string userId, int score) {
//		// Create new entry at /user-scores/$userid/$scoreid and at
//		// /leaderboard/$scoreid simultaneously
//		string key = reference.Child("scores").Push().Key;
//		LeaderboardEntry entry = new LeaderBoardEntry(userId, score);
//		Dictionary<string, Object> entryValues = entry.ToDictionary();
//
//		Dictionary<string, Object> childUpdates = new Dictionary<string, Object>();
//		childUpdates["/scores/" + key] = entryValues;
//		childUpdates["/user-scores/" + userId + "/" + key] = entryValues;
//
//		reference.UpdateChildrenAsync(childUpdates);
//	}
}

