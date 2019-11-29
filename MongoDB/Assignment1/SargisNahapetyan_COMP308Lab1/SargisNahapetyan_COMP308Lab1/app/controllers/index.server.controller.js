exports.render = function (request, response) {

    var email = request.body.email;
    var password = request.body.password;
    var session = request.session;

    session.email = email;
    session.password = password;

    console.log("In index.ejs got email: " + email);
    console.log("In index.ejs got password: " + password);

    if ((session.email) && (session.password))
    {
        console.log("Login Success");
        response.redirect('/feedback');
    }
    else
    {
        response.render('index');
    }
        
};