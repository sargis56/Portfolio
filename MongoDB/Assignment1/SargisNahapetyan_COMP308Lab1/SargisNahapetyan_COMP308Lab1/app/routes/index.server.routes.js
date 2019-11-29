module.exports = function (app) {

    var index = require('../controllers/index.server.controller');
    var feedback = require('../controllers/feedback.server.controller');
    var thankyou = require('../controllers/thankyou.server.controller');

    app.get('/', index.render);
    app.get('/feedback', feedback.render);
    app.post('/feedback', feedback.render);
    app.get('/thankyou', thankyou.render);

    app.post('/', function (request, response) {
        index.render(request, response);
    });
};