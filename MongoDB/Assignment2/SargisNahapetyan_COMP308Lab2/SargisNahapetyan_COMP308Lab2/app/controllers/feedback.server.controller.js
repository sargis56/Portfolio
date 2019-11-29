var User = require('mongoose').model('User');

exports.render = function (request, response) {

    var email = request.session.email;
    var session = request.session;

    request.body.email = email;

    session.email = request.body.email;
    
    var query = { email: session.email };

    var newquery = { $set: { email: session.email, feedback: request.body.feedBack } };
    //var newquery = { $set: { email: session.email, feedback: "test" } };



    User.findOne(query, function (err, users) {

        if ((request.body.feedBack != null)) {

            User.update(query, newquery, function (err2, users2) {
                console.log("1 document updated");
            });

            console.log("Feedback Successful");
            response.redirect('/thankyou');
        }
        else {
            response.render('feedback', {
                emailin: email,
                lastNamein: users.lastName,
                firstNamein: users.firstName,
                passwordin: users.password,
                fsin: users.fs,
                ftin: users.ft
            });

        }

    });


};