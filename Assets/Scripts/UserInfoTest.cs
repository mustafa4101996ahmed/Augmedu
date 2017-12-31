using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Auth;
using Firebase.Unity.Editor;
using UnityEngine.UI;

public class UserInfoTest : MonoBehaviour
{
	string myusername, myemail, myuserID;
	string myage;
	//for MATH
	string myMLearnLevel1, myMLearnLevel2, myMLearnLevel3;
	string myQuiz1Completed, myQuiz2Completed, myQuiz3Completed, myQuiz4Completed;
	string myQuiz1Score, myQuiz2Score, myQuiz3Score, myQuiz4Score;
	//for Shapes
	string mySLearnLevel1, mySLearnLevel2, mySLearnLevel3;
	string myQuizCircleCompleted, myQuizSquareCompleted, myQuizTriangleCompleted;
	string myQuizCircleScore, myQuizSquareScore, myQuizTriangleScore;

	string uid;

	public Button UserInfoButton, LeaderboardsButton;
	public Text textboxInfo;

	Firebase.Auth.FirebaseAuth auth;

    void Start()
    {
        UserInfoButton.onClick.AddListener(() => GetUserData());
		LeaderboardsButton.onClick.AddListener(() => GetLeaderboards());

    }

	public void GetLeaderboards()
	{
		textboxInfo.text = "TOP 3 PLACES:\n1. Username : Mustafa has completed with score of 84\n2. Username: Mansour has completed with score of 77\n3. username: Hossam has completed with Score of 60";
	}

    public void GetUserData()
    {
		auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
		Firebase.Auth.FirebaseUser user = auth.CurrentUser;
		if (user != null) 
		{
			uid = user.UserId;
		}

		textboxInfo.text = "Mustafa with age of 10 is logged in with total score of 84.";


        // Set up the Editor before calling into the realtime database.
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://gradproject-861f8.firebaseio.com/");

        // Get the root reference location of the database.
        DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;

        FirebaseDatabase.DefaultInstance
        .GetReference("users")
        .ValueChanged += HandleValueChanged;
    }

    void HandleValueChanged(object sender, ValueChangedEventArgs args)
    {
        if (args.DatabaseError != null)
        {
            Debug.LogError(args.DatabaseError.Message);
            return;
        }
        var root = args.Snapshot.Value as Dictionary<string, object>;
        foreach (var users in root)
        {
			myuserID = users.Key;
		  if(uid == myuserID)
		  {
			//user ID
//			myuserID = users.Key;
//            Debug.Log(users.Key); // Kdq6...
			//we go inside the first user we grab::
            var values = users.Value as Dictionary<string, object>;
            foreach (var data in values)	//inside first user
            {
				Debug.Log ("this is it.. displaying age username email::");
				if (data.Key == "age")
					Debug.Log(myage = data.Value.ToString());
				if (data.Key == "username")
					Debug.Log(myusername = data.Value.ToString());
				if (data.Key == "email")
					Debug.Log(myemail = data.Value.ToString());

				Debug.Log ("after displaying age username and email.");
				if (data.Key == "MathParent") 
				{
					var values11 = data.Value as Dictionary<string, object>;
					foreach (var data11 in values11) {	//inside MathParent
						if (data11.Key == "MathLearn") {
							var values12 = data11.Value as Dictionary<string, object>;
							foreach (var data12 in values12) //inside MathLearn
							{	
								if (data12.Key == "MLearnLevel1") 
								{
									myMLearnLevel1 = data12.Value.ToString();
								}
								if (data12.Key == "MLearnLevel2") 
								{
									myMLearnLevel2 = data12.Value.ToString();
								}
								if (data12.Key == "MLearnLevel3") 
								{
									myMLearnLevel3 = data12.Value.ToString();
								}
									
							}
						}
						if (data11.Key == "MathQuiz") {
							var values13 = data11.Value as Dictionary<string, object>;
							foreach (var data13 in values13)	//inside MathQuiz
							{	
								if (data13.Key == "MQuizLevel1") 
								{
									var values14 = data13.Value as Dictionary<string, object>;
									foreach (var data14 in values14)	//inside MQuizLevel1
									{	
										if (data14.Key == "Quiz1Completed") 
										{
											myQuiz1Completed = data14.Value.ToString();
											Debug.Log ("Quiz1Completed" + "==" + myQuiz1Completed);//
										}
										if (data14.Key == "Quiz1Score") 
										{
											myQuiz1Score = data14.Value.ToString();//
											Debug.Log ("Quiz1Score" + "==" + myQuiz1Score);
										}
									}
								}
								if (data13.Key == "MQuizLevel2") {
									var values15 = data13.Value as Dictionary<string, object>;
									foreach (var data15 in values15)	//inside MQuizLevel2
									{	
										if (data15.Key == "Quiz2Completed") 
										{
											myQuiz2Completed = data15.Value.ToString();
											Debug.Log ("Quiz2Completed" + "==" + myQuiz2Completed);//

										}
										if (data15.Key == "Quiz2Score") 
										{
											myQuiz2Score = data15.Value.ToString();
											Debug.Log ("Quiz2Score" + "==" + myQuiz2Score);//
										}
									}
								}
								if (data13.Key == "MQuizLevel3") {
									var values16 = data13.Value as Dictionary<string, object>;
									foreach (var data16 in values16)	//inside MQuizLevel3
									{	
										if (data16.Key == "Quiz3Completed") 
										{
											myQuiz3Completed = data16.Value.ToString();
											Debug.Log ("Quiz3Completed" + "==" + myQuiz3Completed);//
										}
										if (data16.Key == "Quiz3Score") 
										{
											myQuiz3Score = data16.Value.ToString();
											Debug.Log ("Quiz3Score" + "==" + myQuiz3Score);//
										}
									}
								}
								if (data13.Key == "MQuizLevel4") {
									var values17 = data13.Value as Dictionary<string, object>;
									foreach (var data17 in values17)	//inside MQuizLevel4
									{	
										if (data17.Key == "Quiz4Completed") 
										{
											myQuiz4Completed = data17.Value.ToString();
											Debug.Log ("Quiz4Completed" + "==" + myQuiz4Completed);//
										}
										if (data17.Key == "Quiz4Score") 
										{
											myQuiz4Score = data17.Value.ToString();
											Debug.Log ("Quiz4Score" + "==" + myQuiz4Score);//
										}
									}
								}
								
							}
						}
					}
				}//MathParent
				if (data.Key == "ShapesParent") 
				{
					var values21 = data.Value as Dictionary<string, object>;
					foreach (var data21 in values21)	//inside MathParent
					{	
						if (data21.Key == "ShapesLearn") 
						{
							var values22 = data21.Value as Dictionary<string, object>;
							foreach (var data22 in values22)	//inside ShapesLearn
							{	
								if (data22.Key == "SLearnLevel1") 
								{
									mySLearnLevel1 = data22.Value.ToString();
									Debug.Log ("SLearnLevel1" + "==" + mySLearnLevel1);//
								}
								if (data22.Key == "SLearnLevel2") 
								{
									mySLearnLevel2 = data22.Value.ToString();
									Debug.Log ("SLearnLevel2" + "==" + mySLearnLevel2);//
								}
								if (data22.Key == "SLearnLevel3") 
								{
									mySLearnLevel3 = data22.Value.ToString();
									Debug.Log ("SLearnLevel3" + "==" + mySLearnLevel3);//
								}
//								mySLearnLevel1 = values22;
//								mySLearnLevel2 = values22;
//								mySLearnLevel3 = values22;
							}
						}
						if (data21.Key == "ShapesQuiz") 
						{
							var values23 = data21.Value as Dictionary<string, object>;
							foreach (var data23 in values23)	//inside ShapesQuiz 
							{	
								if (data.Key == "QuizCircle") 
								{
									var values24 = data23.Value as Dictionary<string, object>;
									foreach (var data24 in values24)	//inside QuizCircle 
									{	
										if (data24.Key == "QuizCircleCompleted") 
										{
											myQuizCircleCompleted = data24.Value.ToString();
											Debug.Log ("QuizCircleCompleted" + "==" + myQuizCircleCompleted);//
										}
										if (data24.Key == "QuizCircleCompleted") 
										{
											myQuizCircleCompleted = data24.Value.ToString();
											Debug.Log ("QuizCircleCompleted" + "==" + myQuizCircleCompleted);//
										}
//										myQuizCircleCompleted = values24;
//										myQuizCircleScore = values24;
									}
								}
								if (data.Key == "QuizSquare") 
								{
									var values25 = data23.Value as Dictionary<string, object>;
									foreach (var data25 in values25)	//inside QuizSquare  
									{	
										if (data25.Key == "QuizSquareCompleted") 
										{
											myQuizSquareCompleted = data25.Value.ToString();
											Debug.Log ("QuizSquareCompleted" + "==" + myQuizSquareCompleted);//
										}
										if (data25.Key == "QuizSquareScore") 
										{
											myQuizSquareScore = data25.Value.ToString();
											Debug.Log ("QuizSquareScore" + "==" + myQuizSquareScore);//
										}
//										myQuizSquareCompleted = values25;
//										myQuizSquareScore = values25;
									}
								}
								if (data.Key == "QuizTriangle") 
								{
									var values26 = data23.Value as Dictionary<string, object>;
									foreach (var data26 in values26)	//inside QuizTriangle 
									{	
										if (data26.Key == "QuizSquareCompleted") 
										{
											myQuizSquareCompleted = data26.Value.ToString();
											Debug.Log ("QuizSquareCompleted" + "==" + myQuizSquareCompleted);//
										}
										if (data26.Key == "QuizSquareScore") 
										{
											myQuizSquareScore = data26.Value.ToString();
											Debug.Log ("QuizSquareScore" + "==" + myQuizSquareScore);
										}
//										myQuizSquareCompleted = values26;
//										myQuizSquareScore = values26;
									}
								}


							}
						}

					}//fix
				}//ShapesParent
			}//inside first user
//                Debug.Log("--" + data.Key + ":" + data.Value); // username:mustafa, age:10 ...
//				if (data.Key == "ShapesParent") 
//				{
//					Debug.Log ("now we are in the Child: ShapesParent");
//					var values1 = data.Value as Dictionary<string, object>;
//					foreach (var data1 in values1) 
//					{
//						if (data1.Key == "ShapesQuiz") 
//						{
//							Debug.Log ("now we are in Child: ShapesQuiz");
//							var values2 = data1.Value as Dictionary<string, object>;
//							foreach (var data2 in values2) 
//							{
//								if (data2.Key == "QuizSquare") 
//								{
//									Debug.Log ("now we are in Child: QuizSquare");
//									var values3 = data2.Value as Dictionary<string, object>;
//									foreach (var data3 in values3) 
//									{
//										if (data3.Key == "QuizSquareScore") 
//										{
//											Debug.Log ("now we are in Child: QuizSquareScore");
//											Debug.Log(data3.Key + ":" + data3.Value);
//											Debug.Log("-----------------");
//											Debug.Log("-----------------");
//											Debug.Log("-----------------");
//
//										}
//									}
//									
//								}
//							}
//
//
//						}
//					}
//					
//				}
			}//uid == myuserID
					
            }	//inside users

		Debug.Log (myage);
		Debug.Log (myusername);
		Debug.Log (myemail);
		Debug.Log (myMLearnLevel1);
		Debug.Log (myMLearnLevel2);
		Debug.Log (myMLearnLevel3);
		Debug.Log ("Quiz1Completed" + "==" + myQuiz1Completed);
		Debug.Log ("Quiz1Score" + "==" + myQuiz1Score);
		Debug.Log ("Quiz2Completed" + "==" + myQuiz2Completed);
		Debug.Log ("Quiz2Score" + "==" + myQuiz2Score);
		Debug.Log ("Quiz3Completed" + "==" + myQuiz3Completed);
		Debug.Log ("Quiz3Score" + "==" + myQuiz3Score);
		Debug.Log ("Quiz3Score" + "==" + myQuiz3Score);
		Debug.Log ("Quiz4Completed" + "==" + myQuiz4Completed);
		Debug.Log ("Quiz4Score" + "==" + myQuiz4Score);
		Debug.Log ("SLearnLevel1" + "==" + mySLearnLevel1);
		Debug.Log ("SLearnLevel2" + "==" + mySLearnLevel2);
		Debug.Log ("SLearnLevel3" + "==" + mySLearnLevel3);
		Debug.Log ("QuizCircleCompleted" + "==" + myQuizCircleCompleted);
		Debug.Log ("QuizCircleCompleted" + "==" + myQuizCircleCompleted);
		Debug.Log ("QuizSquareCompleted" + "==" + myQuizSquareCompleted);
		Debug.Log ("QuizSquareScore" + "==" + myQuizSquareScore);
		Debug.Log ("QuizSquareCompleted" + "==" + myQuizSquareCompleted);
		Debug.Log ("QuizSquareScore" + "==" + myQuizSquareScore);








		//putting all data in String format:
		string dataString;
		dataString = "username [" + myusername + "] with age of [" + myage.ToString() + "]";
		Debug.Log ("<<<<<at this step should work>>>>>>");
		if (!(myMLearnLevel1.Trim().Equals("true"))) //true
		{
			Debug.Log ("this is first equality -true");
			dataString += " has completed MLearnLevel1";
		}
		if ((myMLearnLevel1.Trim().Equals("true"))) 
		{
			Debug.Log ("this is first equality -false");
			dataString += " has NOT completed MLearnLevel1";
		}
		if (!(myMLearnLevel2.Trim().Equals("true"))) //true
		{
			Debug.Log ("22 this is second equality -true");
			dataString += "and has completed MLearnLevel2";
		}
		if ((myMLearnLevel2.Trim().Equals("true"))) 
		{
			Debug.Log ("22 this is second equality -false");
			dataString += "and has NOT completed MLearnLevel2";
		}
		if (!(myMLearnLevel3.Trim().Equals("true"))) //true
		{
			Debug.Log ("22 this is 3rd equality -true");
			dataString += " has completed MLearnLevel3";
		}
		if ((myMLearnLevel3.Trim().Equals("true"))) 
		{
			Debug.Log ("22 this is 3rd equality -false");
			dataString += " has NOT completed MLearnLevel3";
		}

		//MathQuiz::
		if (!(myQuiz1Completed.Trim().Equals("true"))) //true
		{
			Debug.Log ("22 this is 4th equality -true");
			dataString += " has completed Math Quiz 1 with score of [" + myQuiz1Score + "]" ;
		}
		if ((myQuiz1Completed.Trim().Equals("true"))) 
		{
			Debug.Log ("22 this is 4th equality -false");
			dataString += " has NOT completed Math Quiz 1";
		}

		if (!(myQuiz2Completed.Trim().Equals("true"))) //true
		{
			Debug.Log ("22 this is 5th equality -true");
			dataString += " has completed Math Quiz 2 with score of [" + myQuiz2Score + "]" ;
		}
		if ((myQuiz2Completed.Trim().Equals("true"))) 
		{
			Debug.Log ("22 this is 5th equality -false");
			dataString += " has NOT completed Math Quiz 2";
		}

		if (!(myQuiz3Completed.Trim().Equals("true"))) //true
		{
			Debug.Log ("22 this is 6th equality -true");
			dataString += " has completed Math Quiz 1 with score of [" + myQuiz3Score + "]" ;
		}
		if ((myQuiz3Completed.Trim().Equals("true"))) 
		{
			Debug.Log ("22 this is 6th equality -false");
			dataString += " has NOT completed Math Quiz 3";
		}

		if (!(myQuiz4Completed.Trim().Equals("true"))) //true
		{
			Debug.Log ("22 this is 7th equality -true");
			dataString += " has completed Math Quiz 1 with score of [" + myQuiz4Score + "]" ;
		}
		if ((myQuiz4Completed.Trim().Equals("true"))) 
		{
			Debug.Log ("22 this is 7th equality -false");
			dataString += " has NOT completed Math Quiz 4";
		}

		if (!(mySLearnLevel1.Trim().Equals("true"))) //true
		{
			Debug.Log ("22 this is 8th equality -true");
			dataString += " has completed Shapes -Circle- Learn Level 1";
		}
		if ((mySLearnLevel1.Trim().Equals("true"))) 
		{
			Debug.Log ("22 this is 8th equality -false");
			dataString += " has NOT completed Shapes -Circle- Learn Level 1";
		}

		if (!(mySLearnLevel2.Trim().Equals("true"))) //true
		{
			Debug.Log ("22 this is 9th equality -true");
			dataString += " has completed Shapes -Square- Learn Level 2";
		}
		if ((mySLearnLevel1.Trim().Equals("true"))) 
		{
			Debug.Log ("22 this is 9th equality -false");
			dataString += " has NOT completed Shapes -Square- Learn Level 2";
		}

		if (!(mySLearnLevel3.Trim().Equals("true"))) //true
		{
			Debug.Log ("22 this is 10th equality -true");
			dataString += " has completed Shapes -Triangle- Learn Level 3";
		}
		if ((mySLearnLevel3.Trim().Equals("true"))) 
		{
			Debug.Log ("22 this is 10th equality -false");
			dataString += " has NOT completed Shapes -Triangle- Learn Level 3";
		}

		if (!(myQuizCircleCompleted.Trim().Equals("true"))) //true
		{
			Debug.Log ("22 this is 11th equality -true");
			dataString += " has completed Quiz -Circle- with score of [" + myQuizCircleScore + "] ";
		}
		if ((myQuizCircleCompleted.Trim().Equals("true"))) 
		{
			Debug.Log ("22 this is 11th equality -false");
			dataString += " has NOT completed Quiz -Circle-.";
		}

		if (!(myQuizSquareCompleted.Trim().Equals("true"))) //true
		{
			Debug.Log ("22 this is 12th equality -true");
			dataString += " has completed Quiz -Square- with score of [" + myQuizSquareScore + "] ";
		}
		if ((myQuizSquareCompleted.Trim().Equals("true"))) 
		{
			Debug.Log ("22 this is 12th equality -false");
			dataString += " has NOT completed Quiz -Square-.";
		}

		if (!(myQuizTriangleCompleted.Trim().Equals("true"))) //true
		{
			Debug.Log ("22 this is 13th equality -true");
			dataString += " has completed Quiz -Triangle- with score of [" + myQuizTriangleScore + "] ";
		}
		if ((myQuizSquareCompleted.Trim().Equals("true"))) 
		{
			Debug.Log ("22 this is 13th equality -false");
			dataString += " has NOT completed Quiz -Triangle-.";
		}


		Debug.Log (dataString);







		textboxInfo.text = dataString;
        }//end HandleValueChanged
}


