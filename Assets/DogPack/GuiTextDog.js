function OnGUI () {
    GUI.Label (Rect (10, 10, 300, 20), "Use the WASD keys  to move");
    GUI.Label (Rect (10, 30, 300, 20), "Hold 'Shift' to run");
    GUI.Label (Rect (10, 50, 300, 20), "Press the keys 1-4 to test extra animations");
}

/* Example level loader */


// JavaScript
//function OnGUI () {
//    // Make a background box
//    GUI.Box (Rect (10,10,100,90), "Loader Menu");
//
//    // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
//    if (GUI.Button (Rect (20,40,80,20), "Level 1")) {
//        Application.LoadLevel (1);
//    }
//
//    // Make the second button.
//    if (GUI.Button (Rect (20,70,80,20), "Level 2")) {
//        Application.LoadLevel (2);
//    }
//}
