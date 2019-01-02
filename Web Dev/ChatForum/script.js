function sendChat()
{
    var message = "";
    
    message = document.getElementById('chat').value;
    document.getElementById('chatbox').innerHTML += message + "<br>";

}
function loginSubmit()
{
    var username = "";
    username = document.getElementById('username').value;
    if(username == ""){
        alert('Please enter a username!');
    }
    else{
        alert('Welcome' + ' ' + username)
    }

}