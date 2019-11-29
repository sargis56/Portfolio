﻿var User = require('mongoose').model('User');
// Create a new 'create' controller method
exports.create = function (req, res, next) {
    // Create a new instance of the 'User' Mongoose model
    var user = new User(req.body);
    console.log("body: " + req.body.email);

    // Use the 'User' instance's 'save' method to save a new user document
    user.save(function (err) {
        if (err) {
            // Call the next middleware with an error message
            return next(err);
        } else {
            // Use the 'response' object to send a JSON response
            res.json(user);

        }
    });
};

// Create a new 'list' controller method
exports.list = function (req, res, next) {
    // Use the 'User' instance's 'find' method to retrieve a new user document
    User.find({}, function (err, users) {
        if (err) {
            return next(err);
        } else {
            res.json(users);
        }
    });
};