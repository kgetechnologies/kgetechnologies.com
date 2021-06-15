function includeHTML() {
var z, i, elmnt, file, xhttp;
/*loop through a collection of all HTML elements:*/
z = document.getElementsByTagName("*");
for (i = 0; i < z.length; i++) {
  elmnt = z[i];
  /*search for elements with a certain atrribute:*/
  file = elmnt.getAttribute("w3-include-html");
  if (file) {
    /*make an HTTP request using the attribute value as the file name:*/
    xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
      if (this.readyState == 4) {
        if (this.status == 200) {elmnt.innerHTML = this.responseText;}
        if (this.status == 404) {elmnt.innerHTML = "Page not found.";}
        /*remove the attribute, and call this function once more:*/
        elmnt.removeAttribute("w3-include-html");
        includeHTML();
      }
    }      
    xhttp.open("GET", file, true);
    xhttp.send();
    /*exit the function:*/
    return;
  }
}
}

// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
/* The api keys can be public and will not be a vulnerability, since we 
  only allow request to fiebase from specific domain, which can be
  changed in Firebase console */
var firebaseConfig = {
  apiKey: "AIzaSyA1qfLx9oan8KzwFBDujSpphlQzWz63gM0",
  authDomain: "preview.kgetechnologies.com",
  databaseURL: "https://kgetechnologies-com-default-rtdb.asia-southeast1.firebasedatabase.app",
  projectId: "kgetechnologies-com",
  storageBucket: "kgetechnologies-com.appspot.com",
  messagingSenderId: "752230119570",
  appId: "1:752230119570:web:0a2b91fa9236dae58e0e4b",
  measurementId: "G-GH5026XK58"
};
// Initialize Firebase
firebase.initializeApp(firebaseConfig);
firebase.analytics();
const messages_ref = firebase.database().ref('messages');

// gets the value of the input field.
const get_input_val = (id) => document.getElementById(id).value;

// when form is submmitted. Send the data to firebase.
document.getElementById('contact-form').onsubmit = function(event) {
  event.preventDefault();
  const name = get_input_val('name');
  const email = get_input_val('email');
  const subject = get_input_val('subject');
  const mobileno = get_input_val('mobileno');
  const message = get_input_val('message');
  const enquired_for = get_input_val('enquired_for');

  // Creating a new child to the messages collection.
  const new_message_ref = messages_ref.push();
  
  // Setting the value of the new child.
  new_message_ref.set({
      name: name,
      email: email,
      subject: subject,
      mobileno: mobileno,
      message: message,
      enquired_for: enquired_for,
  });
}