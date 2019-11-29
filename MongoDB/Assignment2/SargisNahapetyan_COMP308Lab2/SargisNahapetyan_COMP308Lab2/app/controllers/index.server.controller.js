
var User = require('mongoose').model('User');

exports.render = function (request, response, next) {

    var email = request.body.email;
    var password = request.body.password;
    var session = request.session;

    session.email = email;
    session.password = password;

    console.log("In index.ejs got email: " + email);
    console.log("In index.ejs got password: " + password);

    var user = new User(request.body);
    console.log("body: " + email);

    // Use the 'User' instance's 'save' method to save a new user document
    user.save(function (err) {
        if (err) {
            // Call the next middleware with an error message
            return err;
        } else {
            // Use the 'response' object to send a JSON response
            if ((session.email) && (session.password)) {
                console.log("Login Success");
                response.redirect('/login');
                //response.json(user);
            }
            else {
                response.render('index');
            }
        }
    });


};