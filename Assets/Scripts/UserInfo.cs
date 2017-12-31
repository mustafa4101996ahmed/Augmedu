using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Auth;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;



//[System.Serializable]
//public class PlayerInfo
//{
//	public string name;
//	public int lives;
//	public float health;
//
//	public static PlayerInfo CreateFromJSON(string jsonString)
//	{
//		return JsonUtility.FromJson<PlayerInfo>(jsonString);
//	}

	// Given JSON input:
	// {"name":"Dr Charles","lives":3,"health":0.8}
	// this example will return a PlayerInfo object with
	// name == "Dr Charles", lives == 3, and health == 0.8f.
//}
	




public class UserInfo : MonoBehaviour {

//	object value;

		public Button UserInfoButton;
		public Text DisplayText;
		 string myuid;
		 string myemail;

	// Use this for initialization
		void Start()
		{
			UserInfoButton.onClick.AddListener(() => UserInformation());
		}
		public void UserInformation(){
			FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://gradproject-861f8.firebaseio.com/");

			// Get the root reference location of the database.
		DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference.Child("users").Child("MathParent").Child("MathQuiz").Child("MQuizLevel1");
		Debug.Log ("database connection done");
//
//			Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
//			Firebase.Auth.FirebaseUser user = auth.CurrentUser;
//			if (user != null) {
//				myuid = user.UserId;
//				myemail = user.Email;
//			}
//
//		Debug.Log ("2- database connection done");
//		Debug.Log (myuid);
//		Debug.Log (myemail);
//
////			FirebaseDatabase.DefaultInstance
////			.GetReference("users").Child(myuid).Child("MathParent").Child("MathQuiz").Child("MQuizLevel1").Child("Quiz1Score")
////				.GetValueAsync().ContinueWith(task => {
////					if (task.IsFaulted) {
////						// Handle the error...
////					}
////					else if (task.IsCompleted) {
////					DataSnapshot snapshot = task.Result;
////					value = snapshot.Value;
////					DisplayText.text = ToString(value);
//////						DisplayText.text = snapshot;
////
////					}
////				});
//
////		DisplayText.text = "this is it";
		//v1
		Debug.Log("go1: this is trying to output");

		reference
			.OrderByChild("Quiz1Score")
			.GetValueAsync().ContinueWith(task => {
				if (task.IsFaulted) {
					// Handle the error...
					Debug.Log("111.there is error herer");
				}
				else if (task.IsCompleted) {
					DataSnapshot snapshot = task.Result;
					Debug.Log("111.completed without error");
					Debug.Log(snapshot.GetRawJsonValue());
					// Do something with snapshot...
				}
			});
//
//		//v2
//		FirebaseDatabase.DefaultInstance
//			.GetReference(myuid)
//			.GetValueAsync().ContinueWith(task => {
//				if (task.IsFaulted) {
//					// Handle the error...
//					Debug.Log("2222.there is error herer");
//				}
//				else if (task.IsCompleted) {
//					DataSnapshot snapshot = task.Result;
//					Debug.Log("2222.completed without error");
//					Debug.Log(snapshot);
//					// Do something with snapshot...
//				}
//			});
//
//		//v3
//		FirebaseDatabase.DefaultInstance
//			.GetReference("Quiz1Score")
//			.GetValueAsync().ContinueWith(task => {
//				if (task.IsFaulted) {
//					// Handle the error...
//					Debug.Log("111.there is error herer");
//				}
//				else if (task.IsCompleted) {
//					DataSnapshot snapshot = task.Result;
//					Debug.Log("111.completed without error");
//					Debug.Log(snapshot);
//					// Do something with snapshot...
//				}
//			});
//
//		//v4
//		reference.GetValueAsync().ContinueWith(task => {
//				if (task.IsFaulted) {
//					// Handle the error...
//					Debug.Log("111.there is error herer");
//				}
//				else if (task.IsCompleted) {
//					DataSnapshot snapshot = task.Result;
//					Debug.Log("111.completed without error");
//					Debug.Log(snapshot);
//					// Do something with snapshot...
//				}
//			});
//
//		Debug.Log("go1: this is trying to output");
//
//
//			reference.GetValueAsync().ContinueWith(task => {
//				if (task.IsFaulted) {
//					// Handle the error...
//					Debug.Log("2.there is error herer");
//				}
//				else if (task.IsCompleted) {
//					DataSnapshot snapshot = task.Result;
//					Debug.Log("2.completed without error");
//					Debug.Log(snapshot);
//					// Do something with snapshot...
//				}
//			});
//		
//		Debug.Log("go2: this is trying to output");
//		//new here (reference)
//		reference.Child(myuid).Child("age")
//			.GetValueAsync().ContinueWith(task => {
//				if (task.IsFaulted) {
//					Debug.Log("there is error herer");
//					// Handle the error...
//				}
//				else if (task.IsCompleted) {
//					DataSnapshot snapshot = task.Result;
//					Debug.Log("completed without error");
//					Debug.Log(snapshot);
//					// Do something with snapshot...
//				}
//			});
//
//
//
//		Debug.Log("go3: this is trying to output");
//
		




		DisplayText.text = FirebaseDatabase.DefaultInstance
			.GetReference ("users").Child ("TKFtSOrxMENQe8y85eYxsHfTupC3").Child ("MathParent").Child ("MathQuiz").Child ("MQuizLevel1").Child ("Quiz1Score")
			.GetValueAsync ().Result.Value.ToString ();
		Debug.Log("by now the data should have been read");
		Debug.Log(FirebaseDatabase.DefaultInstance
			.GetReference ("users").Child ("TKFtSOrxMENQe8y85eYxsHfTupC3").Child ("MathParent").Child ("MathQuiz").Child ("MQuizLevel1").Child ("Quiz1Score")
			.GetValueAsync ().Result.Value.ToString ());

		

				}
}