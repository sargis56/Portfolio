const mongoose = require('mongoose');
const Article = mongoose.model('Article');

var seneca = require('seneca')();
seneca.use('./studentMicroService.js');

//
function getErrorMessage(err) {
    if (err.errors) {
        for (let errName in err.errors) {
            if (err.errors[errName].message) return err.errors[errName].
                message;
        }
    } else {
        return 'Unknown server error';
    }
};

exports.create = function (req, res) {

    var articleInput = new Article(req.body);
    var userInput = req.user;

    seneca.act({ role: 'CRUD', cmd: 'create', article: articleInput, user: userInput, res: res }, function (err, result) {
        console.log("Create");
    })

};

//
exports.list = function (req, res) {
    Article.find().sort('-created').populate('creator', 'firstName lastName fullName').exec((err, articles) => {
if (err) {
        return res.status(400).send({
            message: getErrorMessage(err)
        });
    } else {
        res.status(200).json(articles);
    }
});
};
//
exports.articleByID = function (req, res, next, id) {
    Article.findById(id).populate('creator', 'firstName lastName fullName').exec((err, article) => {if (err) return next(err);
if (!article) return next(new Error('Failed to load course '
        + id));
    req.article = article;
    next();
});
};

/*
exports.read = function (req, res) {
    res.status(200).json(req.article);
};
*/

exports.read = function (req, res) {

    seneca.act({ role: 'CRUD', cmd: 'read', res: res, req: req }, function (err, result) {
        console.log("Read");
    })

};

exports.update = function (req, res) {

    var articleInput = req.article;

    seneca.act({ role: 'CRUD', cmd: 'update', article: articleInput, res: res, req: req }, function (err, result) {
        console.log("Update");
    })

};

exports.delete = function (req, res) {

    var articleInput = req.article;

    seneca.act({ role: 'CRUD', cmd: 'delete', article: articleInput, res: res }, function (err, result) {
        console.log("Delete");
    })

};

//The hasAuthorization() middleware uses the req.article and req.user objects
//to verify that the current user is the creator of the current article
exports.hasAuthorization = function (req, res, next) {
    if (req.article.creator.id !== req.user.id) {
        return res.status(403).send({
            message: 'User is not authorized'
        });
    }
    next();
};


