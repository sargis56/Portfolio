exports.render = function (request, response) {

    var email = request.session.email;
    var emailFeed = request.body.emailFeed;
    var session = request.session; 
    var firstName = request.body.firstName;
    var lastName = request.body.lastName;

    console.log("In feedback.ejs got email: " + email + " from index.ejs");
    console.log("In feedback.ejs got emailFeed: " + emailFeed);

    session.emailFeed = emailFeed;
    session.firstName = firstName;
    session.lastName = lastName;

    if ((session.emailFeed) && (session.firstName) && (session.lastName))
    {
        console.log("Feedback Successful");
        response.redirect('/thankyou');
    }
    else
    {
       //response.render('feedback');     

        response.render('feedback', {
            emailin: email
        });
    }

};