module.exports = function (app) {

    var users = require('../controllers/users.server.controller');

    var index = require('../controllers/index.server.controller');

    var feedback = require('../controllers/feedback.server.controller');

    var login = require('../controllers/login.server.controller');
    var thankyou = require('../controllers/thankyou.server.controller');
    var viewfeedback = require('../controllers/viewcustomerfeedback.server.controller');

    app.get('/', index.render);
    app.post('/', index.render);

    //app.post('/', users.create);
    //app.get('/login', users.create);
    app.get('/login', login.render);
    app.post('/login', login.render);

    app.get('/feedback', feedback.render);
    app.post('/feedback', feedback.render);

    app.get('/thankyou', thankyou.render);

    app.get('/viewfeedback', viewfeedback.render);
    app.post('/viewfeedback', viewfeedback.render);

    //app.post('/', users.create); 

    app.post('/', function (request, response) {
        index.render(request, response);
    });
};