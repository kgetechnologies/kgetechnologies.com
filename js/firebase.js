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