var User = require('mongoose').model('User');

exports.render = function (request, response) {

    var email = request.session.email;
    var session = request.session;



    session.email = request.body.email;
    session.password = request.body.password;

    console.log("In student.ejs got email: " + email + " from index.ejs");
    console.log("In student.ejs got email session: " + session.email);

    var query = { email: session.email };

    User.findOne(query, function (err, users) {

        console.log(users.email);
        console.log(users.password);

        if ((session.email == users.email) && (session.password == users.password) && (users.password != null) && (users.email != null)) {
            console.log("Login Successful");
            response.redirect('/feedback');
        }
        else {
            response.render('login', {
                emailin: email
            });
        }

    });



};