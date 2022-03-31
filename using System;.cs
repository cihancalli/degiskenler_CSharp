using System;

class MainClass {

  public static string ArrayCouples(int[] arr) {


    // code goes here  
    string fList ="";
    //int aL = (arr.Length / 2);
    int length = 2;
    string sList ="";
    string tList ="";
    string ftList ="";

     for(int i=0; i<length;i++){
      fList = fList + arr[i];
     }
 
      for(int i=3; i>=length;i--){
      sList = sList + arr[i];
     }

     for(int i=5; i>3;i--){
        tList = tList + arr[i]; 
     }
     for(int i=7; i>5;i--){
        ftList = ftList + arr[i]; 
     }
   


    return fList+" "+sList+" "+tList+" "+ftList;

  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(ArrayCouples(Console.ReadLine()));
  } 

}