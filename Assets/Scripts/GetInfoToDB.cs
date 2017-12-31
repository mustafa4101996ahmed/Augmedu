using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.SqliteClient;

public class GetInfoToDB : MonoBehaviour {
	
	[SerializeField]
	private Text username = null;  
	[SerializeField]
	private Text pass = null;
	[SerializeField]
	private  Text email = null;
	[SerializeField]
	private Text age = null;
	private string description;



	ArrayList readArray = new ArrayList();


	public dbAccess objdbAccess;
	string demoDatabase = "first_database.db";

	// Use this for initialization
	public void SignUp () {
//		description = "something went wrong with the database";
		string demoTable = "myDemoTable";
		objdbAccess.OpenDB(demoDatabase); //name of Database
		/*public bool*/ objdbAccess.CreateTable(demoTable, new string[]{"username", "password", "email", "age"}, new string[]{"VARCHAR(20)", "VARCHAR(20)", "VARCHAR(20)", "INTEGER"});
		/*public int*/ objdbAccess.InsertIntoSpecific(demoTable, new string[]{"username", "password", "email", "age"}, new string[] {username.text, pass.text, email.text, age.text});
//		objdbAccess.InsertIntoSingle(demoTable, "username" , "firstUser");
//		/*public ArrayList*/ objdbAccess.SingleSelectWhere(demoTable , "username", "age", "=", "'11'");

		Debug.Log ("12345678");
		readArray = objdbAccess.SingleSelectWhere(demoTable , "username", "age", "=", "11");
		Debug.Log ("00009887777777");
	
		int number = readArray.Count;

		Debug.Log ("----the arraylist count is: " + number); 

//		int.TryParse(readArray.Count, out number);
		Debug.Log ("iiiiii99999900000");
//		for (int i = 0; i < number; i++)
//			Debug.Log (readArray);
////		Debug.Log("112233-done QUERY: " + readArray);

	
		Debug.Log("array count"+readArray.Count+"="+readArray);
		if(readArray.Count > 0)
		{
			description = ((string[])readArray[0])[2];
		}
		Debug.Log ("1-.-.-.-." + description.Length);

		Debug.Log("-.-.-.-.-."+description);

		/*public void*/ objdbAccess.CloseDB();
		
	}
}
	