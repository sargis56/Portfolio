var User = require('mongoose').model('User');


exports.render = function (req, res) {

    var session = req.session;

    session.email = req.body.email;

    var query = { email: session.email };

    User.findOne(query, function (err, users) {

        console.log(users.email);
        console.log(users.password);
        console.log(users.lastName);
        console.log(users.firstName);
        console.log(users.fs);
        console.log(users.ft);

        console.log("feedback: " + users.feedback);

        res.render('viewcustomerfeedback', {
            title: 'Admin Control',
            emailin: users.email,
            lastNamein: users.lastName,
            firstNamein: users.firstName,
            passwordin: users.password,
            fsin: users.fs,
            ftin: users.ft,
            feedbackin: users.feedback

        });
    });



};
